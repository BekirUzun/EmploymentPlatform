using System;
using System.Collections.Generic;
using System.Collections;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmploymentPlatform
{
    public class JobCategory {
        Node root;
        public string jobs_title; // name of category. all jobs must have this title
        public MaxAdvertHeap max_heap;
        public int node_count; // how many company in this job title

        public JobCategory(string title) {
            node_count = 0;
            jobs_title = title;
            max_heap = new MaxAdvertHeap();
        }
        public void AddNode(JobAdvert advert) {
            Node newNode = new Node(advert);
            if (root == null) 
                root = newNode;
            else
                root = RecursiveInsert(root, newNode, advert);

            node_count++;
        }
        private Node RecursiveInsert(Node current, Node n, JobAdvert advert) {

            if (current == null) {
                current = n;
                return current;
            }
            else if (n.company_name.CompareTo(current.company_name) < 0) {
                current.left = RecursiveInsert(current.left, n, advert);
                current = balance_tree(current);
            }
            else if (n.company_name.CompareTo(current.company_name) > 0) {
                current.right = RecursiveInsert(current.right, n, advert);
                current = balance_tree(current);
            }
            return current;
        }
        private Node balance_tree(Node current) {
            int b_factor = balance_factor(current);
            if (b_factor > 1) {
                if (balance_factor(current.left) > 0)
                    current = RotateLL(current);
                else
                    current = RotateLR(current);
            }
            else if (b_factor < -1) {
                if (balance_factor(current.right) > 0)
                    current = RotateRL(current);
                else
                    current = RotateRR(current);
            }
            return current;
        }
        public void Delete(string target) {//and here
            root = Delete(root, target);
        }
        private Node Delete(Node current, string target) {
            Node parent;
            if (current == null) { return null; }
            else {
                //left subtree
                if (target.CompareTo(current.company_name) < 0) {
                    current.left = Delete(current.left, target);
                    if (balance_factor(current) == -2)//here
                    {
                        if (balance_factor(current.right) <= 0) {
                            current = RotateRR(current);
                        }
                        else {
                            current = RotateRL(current);
                        }
                    }
                }
                //right subtree
                else if (target.CompareTo(current.company_name) > 0) {
                    current.right = Delete(current.right, target);
                    if (balance_factor(current) == 2) {
                        if (balance_factor(current.left) >= 0) {
                            current = RotateLL(current);
                        }
                        else {
                            current = RotateLR(current);
                        }
                    }
                }
                //if target is found
                else {
                    if (current.right != null) {
                        //delete its inorder successor
                        parent = current.right;
                        while (parent.left != null) {
                            parent = parent.left;
                        }
                        current.company_name = parent.company_name;
                        current.right = Delete(current.right, parent.company_name);
                        if (balance_factor(current) == 2)//rebalancing
                        {
                            if (balance_factor(current.left) >= 0) {
                                current = RotateLL(current);
                            }
                            else { current = RotateLR(current); }
                        }
                    }
                    else {   //if current.left != null
                        return current.left;
                    }
                }
            }
            return current;
        }
        public Node GetNode(string key) {
            Node found = Find(key, root);
            return found;
        }
        public Node Find(string company_name) {

            return Find(company_name, root);
        } 
        private Node Find(string target, Node current) {
            if (current == null) //sorry but nothing found :/
                return null;
            else if (current.company_name.IndexOf(target, StringComparison.OrdinalIgnoreCase) >= 0)
                return current;

            if(String.Compare(target, current.company_name, StringComparison.OrdinalIgnoreCase) < 0) { 
            //if (target.CompareTo(current.company_name) < 0) {
                if (String.Equals( target, current.company_name, StringComparison.OrdinalIgnoreCase))
                    return current;
                else
                    return Find(target, current.left);
            }
            else {
                if (String.Equals(target, current.company_name, StringComparison.OrdinalIgnoreCase))
                    return current;
                else
                    return Find(target, current.right);
            }

        }
        /*public JobAdvert FindAdvertById(int target_id) {
            return Find(root, target_id);

        }
        private JobAdvert Find(Node current, int target_id) {
            if (current != null) {
                InOrderDisplayTree(current.left);
                InOrderDisplayTree(current.right);
            }

        }*/

        #region BST Treversal with levels. Not used in project
        public void DisplayTree() {
            if (root == null) {
                Console.WriteLine("Tree is empty");
                return;
            }
            InOrderDisplayTree(root, -1);
        }
        private void InOrderDisplayTree(Node current, int level) {
            if (current != null) {
                InOrderDisplayTree(current.left, level++);
                foreach (JobAdvert advert in current.adverts)
                    Console.Write("({0}) ", advert.ToShortString());
                Console.Write("Level: " + level);
                Console.WriteLine();
                InOrderDisplayTree(current.right, level++);
            }
        }
        #endregion

        private int getHeight(Node current) {
            int height = 0;
            if (current != null) {
                int l = getHeight(current.left);
                int r = getHeight(current.right);
                int m = Math.Max(l, r);
                height = m + 1;
            }
            return height;
        }
        private int balance_factor(Node current) {
            int l = getHeight(current.left);
            int r = getHeight(current.right);
            int b_factor = l - r;
            return b_factor;
        }
        private Node RotateRR(Node parent) {
            Node pivot = parent.right;
            parent.right = pivot.left;
            pivot.left = parent;
            return pivot;
        }
        private Node RotateLL(Node parent) {
            Node pivot = parent.left;
            parent.left = pivot.right;
            pivot.right = parent;
            return pivot;
        }
        private Node RotateLR(Node parent) {
            Node pivot = parent.left;
            parent.left = RotateRR(pivot);
            return RotateLL(parent);
        }
        private Node RotateRL(Node parent) {
            Node pivot = parent.right;
            parent.right = RotateLL(pivot);
            return RotateRR(parent);
        }
        public Node GetRoot() {
            return root;
        }
        public override bool Equals(object obj) {
            JobCategory temp = (JobCategory)obj;
            if (this.jobs_title == temp.jobs_title)
                return true;
            else
                return false;

        }
    }
    public class Node {
        public string company_name;
        public List<JobAdvert> adverts; // Level 3
        public Node left;
        public Node right;

        public Node(JobAdvert advert) {
            this.company_name = advert.company_name;
            adverts = new List<JobAdvert>();
            adverts.Add(advert);
        }
    }
    public class MaxAdvertHeap {
        public List<JobAdvert> nodes;

        public MaxAdvertHeap() {
            nodes = new List<JobAdvert>();
        }
        private void TrickleUp(int index) {
            while (index > 0) {
                int parent = (index - 1) / 2;
                if (nodes[index].salary > nodes[parent].salary) {
                    Swap(index, parent);
                    index = parent;
                }
                else
                    break;

            }
        }
        private void TrickleDown(int index) {
            while (index < nodes.Count) {
                int leftChild = index * 2 + 1;
                int rightChild = index * 2 + 2;

                if (leftChild > nodes.Count - 1)
                    break;

                if (rightChild < nodes.Count) {
                    if (nodes[rightChild].salary > nodes[leftChild].salary) {
                        if (nodes[rightChild].salary > nodes[index].salary) {
                            Swap(index, rightChild);
                            index = rightChild;
                        }
                        else
                            break;
                    }
                    else {
                        if (nodes[leftChild].salary > nodes[index].salary) {
                            Swap(index, leftChild);
                            index = leftChild;
                        }
                        else
                            break;
                    }
                }
                else {
                    if (nodes[leftChild].salary > nodes[index].salary) {
                        Swap(index, leftChild);
                        index = leftChild;
                    }
                    else
                        break;
                }

            }
        }
        private void Swap(int i, int j) {
            JobAdvert i_temp = nodes[i].Clone();
            nodes[i] = nodes[j];
            nodes[j] = i_temp;
        }
        public void Insert(JobAdvert new_advert) {
            nodes.Add(new_advert);
            TrickleUp(nodes.Count - 1);
        }
        public JobAdvert PopMax() {
            JobAdvert max_temp = nodes[0].Clone();

            nodes[0] = nodes[nodes.Count - 1];
            nodes.RemoveAt(nodes.Count - 1);
            TrickleDown(0);
            return max_temp;
        }
        public bool IsEmpty() {
            return nodes.Count == 0;
        }
    }
    public class JobAdvert
    {
        public static int last_id = -1;
        public readonly int id;
        public readonly string company_name;
        public string title, description, location;
        public int salary;
        public string[] skills;
        public DateTime deadline, posted;
        public List<string> applications;

        public JobAdvert(Hashtable skills_table, string company_name, string title, int salary, string[] skills, string description, string location, DateTime posted, DateTime deadline, string[] applications) {
            id = ++last_id;
            this.company_name = company_name;
            this.title = title;
            this.salary = salary;
            this.skills = skills;
            this.description = description;
            this.location = location;
            this.deadline = deadline;
            this.posted = posted;
            this.applications = new List<string>();

            if (skills != null) {
                if (skills.Length > 0) {
                    foreach (string _skill in skills) {
                        string skill = _skill.ToLower();
                        if (skills_table.ContainsKey(skill)) {
                            List<JobAdvert> temp = (List<JobAdvert>)skills_table[skill];
                            temp.Add(this);
                        }
                        else {
                            List<JobAdvert> temp = new List<JobAdvert>();
                            temp.Add(this);
                            skills_table.Add(skill, temp);
                        }
                    }
                }
            }

            if (applications != null && applications.Length > 0) {
                foreach (string application in applications) {
                    this.applications.Add(application);
                }
            }
        }
        public bool IsApplicantExists(string applicant) {
            foreach(string str in applications) {
                if (String.Equals(str, applicant, StringComparison.OrdinalIgnoreCase))
                    return true;          
            }
            return false;
        }
        public void AddApplication(string applicant)
        {
            applications.Add(applicant);
        }
        public string ToShortString() {
            return company_name + " - " + title;
        }
        public string ToLongString()
        {
            string salary_str = "Unknown", skills_str = "", applications_str = "";
            if (salary > 0)
                salary_str = salary.ToString();
            if (skills.Length == 0)
                skills_str = "None";
            for (int i = 0; i < skills.Length; i++)
            {
                if (i == skills.Length - 1)
                   skills_str += skills[i];
                else
                    skills_str += skills[i] + ", ";
            }

            if (applications.Count == 0)
                applications_str = "None";
            for (int i = 0; i < applications.Count; i++)
            {
                if (i == applications.Count - 1)
                    applications_str += applications[i];
                else
                    applications_str += applications[i] + ", ";
            }

            // return string in RTF format. Rtf allows bold words in string
            string str = @"{\rtf1\ansi \b Company Name: \b0 " + company_name +
                @"\cf0\par\cf1\b Job Title: \b0 " + title + 
                @"\cf0\par\cf1\b Salary: \b0 " + salary_str + 
                @"\cf0\par\cf1\b Skills and Expertises: \b0 " + skills_str + 
                @"\cf0\par\cf1\b Job Description: \b0 " + description + 
                @"\cf0\par\cf1\b Job Location: \b0 " + location + 
                @"\cf0\par\cf1\b Date Posted: \b0 " + posted.ToShortDateString() +
                @"\cf0\par\cf1\b Application Deadline: \b0 " + deadline.ToShortDateString() +
                @"\cf0\par\cf1\b Applications: \b0 " + applications_str +
                @"}";

            string old_chars = "ŞşİıÖöÇçÜüĞğ", new_chars = "SsIiOoCcUuGg";
            for(int i = 0; i < 12; i++)
                str = str.Replace(old_chars[i], new_chars[i]);
            
            return str;

        }
        public string ToDataString() {
            string  skills_str = "", applications_str = "";

            for (int i = 0; i < skills.Length; i++) {
                if (i == skills.Length - 1)
                    skills_str += skills[i];
                else
                    skills_str += skills[i] + ",";
            }

            for (int i = 0; i < applications.Count; i++) {
                if (i == applications.Count - 1)
                    applications_str += applications[i];
                else
                    applications_str += applications[i] + ",";
            }
            return company_name + "-" + title + "-" + salary + "-" + skills_str + "-" + description + "-" + location + "-" + posted.ToShortDateString() + "-" + deadline.ToShortDateString() + "-" + applications_str;
        }
        public JobAdvert Clone() {
            object clone = this.MemberwiseClone();
            return (JobAdvert)clone;
        }
        public override bool Equals(object obj) {
            JobAdvert temp = (JobAdvert)obj;
            if (this.id == temp.id)
                return true;
            else
                return false;
        }
    }
    public class User 
    {
        public int id;
        public string email, password, name, gender;
        public int age;
        public string[] skills;
        public string[] experiences;
        public int[] experiences_time;

        public User(int id, string email, string password, string name, int age, string gender, string skills_str, string exp) {
            this.id = id;
            this.gender = gender;
            if(exp != null) {
                if(exp != "") {
                    if(exp.Split(',').Length > 1) {
                        string[] exps = exp.Split(',');
                        experiences = new string[exps.Length];
                        experiences_time = new int[exps.Length];
                        for (int i = 0; i< exps.Length; i++) {
                            string exp_name = exps[i].Split('*')[0];
                            int time = int.Parse(exps[i].Split('*')[1]);
                            experiences[i] = exp_name;
                            experiences_time[i] = time;
                        }
                    } else {
                        experiences = new string[1];
                        experiences_time = new int[1];
                        string exp_name = exp.Split('*')[0];
                        int time = int.Parse(exp.Split('*')[1]);
                        experiences[0] = exp_name;
                        experiences_time[0] = time;
                    }
                }
            }
            UpdateInfo(email, password, name, age, skills_str);
        }
        public User(int id, string email, string password, string name, int age, string gender, string skills_str) {
            this.id = id;
            this.gender = gender;
            UpdateInfo(email, password, name, age, skills_str);
        }// end of constructor

        public void UpdateInfo(string email, string password, string name, int age, string skills_str) {
            this.email = email;
            this.password = password;
            this.name = name;
            this.age = age;
            if (skills_str != "") {
                if (skills_str.Split(',').Length > 1)
                    this.skills = skills_str.Split(',');
                else {
                    skills = new string[1];
                    skills[0] = skills_str;
                }
            }
        }
        public string ToDataString() {
            string skills_str = "";
            if (skills != null) {
                for (int i = 0; i < skills.Length; i++) {
                    if (i == skills.Length - 1)
                        skills_str += skills[i];
                    else
                        skills_str += skills[i] + ",";
                }
            }
            return email + "-" + password + "-" + name + "-" + age + "-" + gender + "-" + skills_str + "-"; //last - is for recommend system
        }
    }
    public class Company 
    {
        public string company_name;
        public List<JobAdvert> company_adverts;

        public Company(string company_name) {
            this.company_name = company_name;
            company_adverts = new List<JobAdvert>();
        }
        public Company() {
            company_adverts = new List<JobAdvert>();
        }

        public void AddAdvert(JobAdvert newAdvert) {
            company_adverts.Add(newAdvert);
        }

        public void RemoveAdvert(int id) {
            for(int i = 0; i < company_adverts.Count; i++) {
                if (company_adverts[i].id == id) {
                    company_adverts.RemoveAt(i);
                }
            }
        }
    }

    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new EmploymentPlatform());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmploymentPlatform {
    public partial class FindEmployee : Form {
        EmploymentPlatform mainForm;
        FindJob findJobForm;
        Company company;
        List<JobCategory> job_categories;
        List<JobAdvert> adverts;
        Hashtable skills_table;
        int selected_advert_id;
        string selected_advert_title;
        JobAdvert selected_advert;
        int advert_count;
        Label[] job_labels;
        List<User> users;

        public FindEmployee(EmploymentPlatform mainF, FindJob findJobF, Company company) {
            mainForm = mainF;
            findJobForm = findJobF;
            this.company = company;
            findJobForm.RetrieveInfo(this);
            InitializeComponent();

            UpdateAdvertsTable();
            List<string> skillz = new List<string>();
            foreach (string key in skills_table.Keys) {
                skillz.Add(key[0].ToString().ToUpper() + key.Substring(1)); //First char is big others are small
            }
            skillz.Sort();
            foreach (string s in skillz) {
                skillsCheckedList.Items.Add(s);
            }

            welcomeLabel.Text = "Welcome " + company.company_name + "!";
            companyNameInput.Text = company.company_name;

        } // end of constructor

        private void backButton_Click(object sender, EventArgs e) {
            mainForm.Show();
            this.Hide();
        }
        private void JobAdvert_MouseEnter(object sender, EventArgs e) {
            Label lab = (Label)sender;
            lab.Font = new Font(lab.Font, FontStyle.Bold);
        }
        private void JobAdvert_MouseLeave(object sender, EventArgs e) {
            Label lab = (Label)sender;
            lab.Font = new Font(lab.Font, FontStyle.Regular);
        }
        private void JobAdvert_Click(object sender, EventArgs e) {
            Label lab = (Label)sender;
            selected_advert_title = lab.Text.Split('-')[1].TrimStart(' ');
            selected_advert_id = int.Parse(new string(lab.Name.Where(char.IsDigit).ToArray()));
            for (int i = 0; i < skillsCheckedList.Items.Count; i++)
                skillsCheckedList.SetItemChecked(i, false); //uncheck skills

            foreach (JobCategory category in job_categories) {
                if (category.jobs_title == selected_advert_title) {
                    foreach (JobAdvert adv in category.Find(company.company_name).adverts) {
                        if (adv.id == selected_advert_id) {
                            // fill job inputs
                            FillInputs(adv);
                            selected_advert = adv;
                            break; // no need to check other adverts
                        }
                    }
                    break; // no need to check other categories
                }
            }
        }
        private void createAdvertButton_Click(object sender, EventArgs e) {
            if(selected_advert != null)
                ResetInputs();
            saveAdvertButton.Text = "Create Advert";
            saveAdvertButton.Visible = true;
            saveAdvertButton.Refresh();
        }
        private void deleteAdvertButton_Click(object sender, EventArgs e) {
            //delete last clicked/selected advert
            company.company_adverts.Remove(selected_advert);
            adverts.Remove(selected_advert);
            foreach (JobCategory category in job_categories) {
                if (category.jobs_title == selected_advert_title) {
                    adverts.Remove(selected_advert);
                    category.Find(company.company_name).adverts.Remove(selected_advert);
                    break;
                }
            }
            #region Read file again, change it and rewrite it
            /* 
                StreamReader adv_reader = new StreamReader("adverts-data.dat");
                List<string> adv_data = new List<string>();
                while (true) {
                    string line = adv_reader.ReadLine();
                    if (line == null)
                        break;

                    adv_data.Add(line);
                }
                adv_reader.Close();

                adv_data.RemoveAt(selected_advert_id);
                StreamWriter adv_writer = new StreamWriter("adverts-data.dat");
                foreach (string line in adv_data) {
                    adv_writer.WriteLine(line);
                }
                adv_writer.Close(); */
            #endregion
            UpdateAdvertsFile();
            UpdateAdvertsTable();
            mainForm.UpdateFindjobAdvertsTable();
            ResetInputs();
            successAlert.Text = "Advert deleted successfully!";
            successAlert.Visible = true;
            selected_advert = null;
            //advertDeletedAlert.Visible = true;
        }
        private void saveAdvertButton_Click(object sender, EventArgs e) {
            int salary = 0;
            int.TryParse(salaryInput.Text, out salary);
            if (salary == 0) {
                errorAlert.Text = "Salary is not valid!";
                errorAlert.Visible = true;
                return;
            }
            if(descriptionInput.Text.Contains('-') || jobTitleInput.Text.Contains('-') || locationInput.Text.Contains('-') || salaryInput.Text.Contains('-')) {
                errorAlert.Text = "'-' character is not allowed in any inputs!";
                errorAlert.Visible = true;
                return;
            }

            if(String.Equals(saveAdvertButton.Text, "Save Advert")) {
                // change the currently selected advert
                selected_advert.description = descriptionInput.Text;
                selected_advert.title = jobTitleInput.Text;
                selected_advert.salary = int.Parse(salaryInput.Text);
                selected_advert.location = locationInput.Text;
                string[] skills = new string[skillsCheckedList.CheckedItems.Count];
                for (int i = 0; i < skillsCheckedList.CheckedItems.Count; i++) {
                    skills[i] = skillsCheckedList.CheckedItems[i].ToString();
                }
                selected_advert.skills = skills;
                selected_advert.deadline = deadlineInput.Value;
                
                foreach (JobCategory category in job_categories) {
                    if (category.jobs_title == selected_advert_title) {
                        int index = category.Find(company.company_name).adverts.IndexOf(selected_advert);
                        category.Find(company.company_name).adverts[index] = selected_advert;

                        break;
                    }
                }
                adverts[selected_advert_id] = selected_advert;
                for(int i = 0; i < company.company_adverts.Count; i++) {
                    if (company.company_adverts[i].id == selected_advert_id) {
                        company.company_adverts[i] = selected_advert;
                        break;
                    }
                }
                successAlert.Text = "Changes applied successfully!";
                successAlert.Visible = true;
            }
            else {
                string[] skills = new string[skillsCheckedList.CheckedItems.Count];
                for(int i = 0; i < skillsCheckedList.CheckedItems.Count; i++) {
                    skills[i] = skillsCheckedList.CheckedItems[i].ToString();
                }
                //public JobAdvert(Hashtable skills_table, string company_name, string title, int salary, string[] skills, string description, string location, DateTime posted, DateTime deadline, string[] applications) {
                JobAdvert new_advert = new JobAdvert(skills_table, company.company_name, jobTitleInput.Text, salary, skills, descriptionInput.Text, locationInput.Text, DateTime.Now, deadlineInput.Value, null);
                // create new advert with inputs
                company.company_adverts.Add(new_advert);
                adverts.Add(new_advert);

                for(int i = 0; i < job_categories.Count; i++)  {
                    if(job_categories[i].jobs_title == new_advert.title) {
                        job_categories[i].Find(company.company_name).adverts.Add(new_advert);
                        break;
                    } else if(i == job_categories.Count - 1) {
                        // category does not exists, create a new category
                        JobCategory temp_category_tree = new JobCategory(new_advert.title);
                        temp_category_tree.AddNode(new_advert);
                        job_categories.Add(temp_category_tree);
                    }
                }
            }
            selected_advert = null;
            UpdateAdvertsFile();
            UpdateAdvertsTable();
            mainForm.UpdateFindjobAdvertsTable();
            saveAdvertButton.Text = "Save Advert";
            saveAdvertButton.Refresh();
            saveAdvertButton.Visible = true;
            deleteAdvertButton.Visible = true;
            successAlert.Text = "Advert created successfully!";

        }
        private void hireButton_Click(object sender, EventArgs e) {
            if (selected_advert.applications.Contains(applicantNameInput.Text)) {
                selected_advert.applications.Remove(applicantNameInput.Text);
                successAlert.Text = applicantNameInput.Text + " hired successfully!";
                UpdateAdvertsTable();
                UpdateAdvertsFile();
                FillInputs(selected_advert);
                successAlert.Visible = true;
            }
            else {
                errorAlert.Text = applicantNameInput.Text + " is not applied for this job!";
                errorAlert.Visible = true;
            }
        }
        private void recommendButton_Click(object sender, EventArgs e) {
            if (selected_advert == null) {
                errorAlert.Text = "You need to select or create an advert in order to get recommendations!";
                errorAlert.Visible = true;
                return;
            }
            else if (selected_advert.skills.Length < 1) {
                errorAlert.Text = "To get recommendations, selected job should have required skill(s)!";
                errorAlert.Visible = true;
                return;
            }

            if (users == null) {
                users = new List<User>();
                StreamReader usr_reader = new StreamReader("users-data.dat");
                List<string[]> usr_data = new List<string[]>();
                while (true) {
                    string line = usr_reader.ReadLine();
                    if (line == null)
                        break;
                    usr_data.Add(line.Split('-'));
                }
                usr_reader.Close();
                for (int i = 0; i < usr_data.Count; i++) {
                    users.Add(new User(i, usr_data[i][0], usr_data[i][1], usr_data[i][2], int.Parse(usr_data[i][3]), usr_data[i][4], usr_data[i][5], usr_data[i][6]));
                }
            }

            double[] points = new double[users.Count];

            for (int u = 0; u < users.Count; u++) {
                for (int i = 0; i < skillsCheckedList.CheckedItems.Count; i++) {
                    for (int j = 0; j < users[u].experiences.Length; j++) {
                        if (string.Equals(users[u].experiences[j], skillsCheckedList.CheckedItems[i].ToString(), StringComparison.InvariantCultureIgnoreCase)) {
                            points[u] += users[u].experiences_time[j];
                        }
                    }
                }
                for (int i = 0; i < skillsCheckedList.CheckedItems.Count; i++) {
                    for (int j = 0; j < users[u].skills.Length; j++) {
                        if (string.Equals(users[u].skills[j], skillsCheckedList.CheckedItems[i].ToString(), StringComparison.InvariantCultureIgnoreCase)) {
                            points[u] += 0.5;
                        }
                    }
                }
            }

            double[] sorted_points = new double[users.Count];
            List<User> sorted_users = new List<User>();

            for (int u = 0; u < points.Length; u++) {
                double max = points[u];
                int max_index = u;
                for (int i = 0; i < points.Length; i++) {
                    if (points[i] > max) {
                        max = points[i];
                        max_index = i;
                    }
                }
                points[max_index] = -1;
                sorted_points[u] = max;
                sorted_users.Add(users[max_index]);
            }

            Recommend rec = new Recommend(sorted_users, sorted_points);
            rec.Show();

            //Console.WriteLine();
        }
        public void Init(Hashtable skills, List<JobCategory> categories, List<JobAdvert> adverts) {
            this.adverts = adverts;
            skills_table = skills;
            job_categories = categories;
        }
        public void SetCompany(Company comp) {
            company = comp;
            welcomeLabel.Text = "Welcome " + company.company_name + "!";
            companyNameInput.Text = company.company_name;
        }
        private void UpdateAdvertsTable() {
            jobListPanel.Controls.Clear();  //reset advers panel
            jobListPanel.RowStyles.Clear();
            advert_count = 0;
            job_labels = new Label[adverts.Count]; // yeah some of them will be null
            for (int i = 0; i < adverts.Count; i++) {
                if (String.Equals(adverts[i].company_name, company.company_name)) {
                    advert_count++;
                    company.company_adverts.Add(adverts[i]);
                    job_labels[i] = new Label() { Name = "jobLabel" + i, Text = adverts[i].ToShortString(), AutoSize = true, MaximumSize = new Size(350, 30) };
                    job_labels[i].Click += new EventHandler(JobAdvert_Click);
                    job_labels[i].MouseEnter += new EventHandler(JobAdvert_MouseEnter);
                    job_labels[i].MouseLeave += new EventHandler(JobAdvert_MouseLeave);

                    jobListPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
                    jobListPanel.Controls.Add(job_labels[i]);
                    jobListPanel.RowCount = jobListPanel.RowCount + 1;

                }

            }
        }
        private void ResetInputs() {
            selected_advert = null;
            jobTitleInput.Text = "";
            salaryInput.Text = "";
            for (int i = 0; i < skillsCheckedList.Items.Count; i++)
                skillsCheckedList.SetItemChecked(i, false); //uncheck everything

            descriptionInput.Text = "";
            locationInput.Text = "";
            applicationsInput.Text = "";
            deadlineInput.Text = "";
            deleteAdvertButton.Visible = false;
            applicantNameLabel.Visible = false;
            applicantNameInput.Visible = false;
            hireButton.Visible = false;
            recommendButton.Visible = false;
        }
        private void FillInputs(JobAdvert advert) {
            recommendButton.Visible = true;
            jobTitleInput.Text = advert.title;
            salaryInput.Text = advert.salary.ToString();
            if (advert.skills.Length > 0) {
                for (int i = 0; i < advert.skills.Length; i++) {
                    string skill_right_form = advert.skills[i][0].ToString().ToUpper() + advert.skills[i].Substring(1).ToLower();
                    if (skillsCheckedList.Items.Contains(skill_right_form)) {
                        int index = skillsCheckedList.Items.IndexOf(skill_right_form);
                        skillsCheckedList.SetItemChecked(index, true);
                    }
                }
            }
            descriptionInput.Text = advert.description;
            locationInput.Text = advert.location;
            deadlineInput.Text = advert.deadline.ToShortDateString();
            if (advert.applications.Count > 0) {
                for (int i = 0; i < advert.applications.Count; i++) {
                    if (i == 0)
                        applicationsInput.Text = advert.applications[i];
                    else
                        applicationsInput.Text += ", " + advert.applications[i];
                }
                applicantNameInput.Text = advert.applications[0];
                applicantNameLabel.Visible = true;
                applicantNameInput.Visible = true;
                hireButton.Visible = true;
            }
            else {
                applicationsInput.Text = "";
                applicantNameInput.Text = "";
                applicantNameLabel.Visible = false;
                applicantNameInput.Visible = false;
                hireButton.Visible = false;
            }
            saveAdvertButton.Text = "Save Advert";
            saveAdvertButton.Refresh();
            saveAdvertButton.Visible = true;
            deleteAdvertButton.Visible = true;
        }       
        private void UpdateAdvertsFile() {
            StreamWriter adv_writer = new StreamWriter("adverts-data.dat");
            foreach (JobAdvert advert in adverts) {
                adv_writer.WriteLine(advert.ToDataString());
            }
            adv_writer.Close();
        }
    }
}

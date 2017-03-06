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

namespace EmploymentPlatform
{
    public partial class FindJob : Form
    {
        EmploymentPlatform mainForm;
        FindEmployee findEmployee;
        SignUp signupForm;
        List<JobCategory> job_categories; // 1
        List<JobAdvert> adverts;
        Hashtable skills_table; // 3
        int selected_job_id;
        JobAdvert selected_advert;
        int advert_count;
        Label[] job_labels;
        User user;


        public FindJob(EmploymentPlatform mainF)
        {   
            mainForm = mainF;
            job_categories = new List<JobCategory>();
            adverts = new List<JobAdvert>();
            skills_table = new Hashtable();
            InitializeComponent();

            StreamReader adv_reader = new StreamReader("adverts-data.dat");
            List<string[]> adv_data = new List<string[]>();

            while (true)
            {
                string line = adv_reader.ReadLine();
                if (line == null)
                    break;

                adv_data.Add(line.Split('-'));
            }
            adv_reader.Close();
            advert_count = adv_data.Count;

            job_labels = new Label[advert_count];

            for (int i = 0; i < advert_count; i++) {
                string[] posted_str = adv_data[i][6].Split('.');
                int[] po = new int[3];
                for (int j = 0; j < po.Length; j++)
                    po[j] = int.Parse(posted_str[j]);
                DateTime posted = new DateTime(po[2], po[1], po[0]);

                string[] deadline_str;
                int[] dl = new int[3];
                deadline_str = adv_data[i][7].Split('.');
                for (int j = 0; j < dl.Length; j++)
                    dl[j] = int.Parse(deadline_str[j]);
                DateTime deadline = new DateTime(dl[2], dl[1], dl[0]);

                string[] applications;
                if (adv_data[i][8] != "") {
                    if (adv_data[i][8].Split(',').Length > 1)
                        applications = adv_data[i][8].Split(',');
                    else {
                        applications = new string[1];
                        applications[0] = adv_data[i][8];
                    }
                }
                else
                    applications = null;

                //public JobAdvert(Hashtable skills_table, string company_name, string title, int salary, string[] skills, string description, string location, DateTime posted, DateTime deadline)
                JobAdvert temp_adv = new JobAdvert(skills_table, adv_data[i][0], adv_data[i][1], int.Parse(adv_data[i][2]), adv_data[i][3].Split(','), adv_data[i][4], adv_data[i][5], posted, deadline, applications);
                JobCategory temp_category_tree = new JobCategory(adv_data[i][1]);

                if (!job_categories.Contains(temp_category_tree)) { // we didn't created that job category before
                    temp_category_tree.AddNode(temp_adv);           // lets add that jobadvert to this category
                    temp_category_tree.max_heap.Insert(temp_adv);
                    job_categories.Add(temp_category_tree);         // and add this category in categories list
                } else {    // That job category exists in job_categories list
                    int index = job_categories.IndexOf(temp_category_tree); // find where is that category
                    JobCategory current_category = job_categories[index];   // asigned it to a temp variable to increa understanding of code a bit
                    current_category.max_heap.Insert(temp_adv);

                    if (current_category.GetNode(adv_data[i][0]) == null)   // check if that category dont have company name
                        current_category.AddNode(temp_adv); // add that advert to a new node. A
                    else // that company exists
                        current_category.GetNode(adv_data[i][0]).adverts.Add(temp_adv); // add that advert to releated node
                }
                job_labels[i] = new Label() { Name = "jobLabel" + i, Text = temp_adv.ToShortString(), AutoSize = true, MaximumSize = new Size(350, 30) };
                job_labels[i].Click += new EventHandler(JobAdvert_Click);
                job_labels[i].MouseEnter += new EventHandler(JobAdvert_MouseEnter);
                job_labels[i].MouseLeave += new EventHandler(JobAdvert_MouseLeave);

                jobListPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
                jobListPanel.Controls.Add(job_labels[i]);
                if (i != advert_count - 1)
                    jobListPanel.RowCount = jobListPanel.RowCount + 1;

                adverts.Add(temp_adv);
            }


            jobAdvertCountLabel.Text = "Job Advert Count: " + advert_count;

            if (advert_count < 10)
                jobListPanel.AutoScroll = false;
            else
                jobListPanel.AutoScroll = true;

            foreach(JobCategory category in job_categories) {
                selectCategory.Items.Add(category.jobs_title);
               
            }
            signupForm = new SignUp(this, skills_table);          
        } // end of constructor

        private void JobAdvert_Click(object sender, EventArgs e) {
            Label lab = (Label)sender;

            string clicked_company = lab.Text.Split('-')[0].TrimEnd(' ');
            string clicked_job_title = lab.Text.Split('-')[1].TrimStart(' ');
            selected_job_id = int.Parse(new string(lab.Name.Where(char.IsDigit).ToArray()));

            foreach (JobCategory category in job_categories) {
                if (category.jobs_title == clicked_job_title) {
                    foreach (JobAdvert adv in category.Find(clicked_company).adverts) {
                        if (adv.id == selected_job_id) {
                            jobInfo.Rtf = adv.ToLongString();
                            selected_advert = adv;
                            break;
                        }
                    }
                    break;
                }
            }
            
          //jobInfo.Rtf = adverts[selected_job_id].ToLongString();
            applyButton.Visible = true;
        }
        private void applyButton_Click(object sender, EventArgs e) {
            if(user == null) {
                signUpAlert.Visible = true;
                return;
            } else if (selected_advert.IsApplicantExists(user.name)) {
                applicationSentAlert.Visible = false;
                applicantExistsAlert.Visible = true;
            } else {
                selected_advert.AddApplication(user.name);

                StreamReader adv_reader = new StreamReader("adverts-data.dat");
                List<string> adv_data = new List<string>();

                while (true) {
                    string line = adv_reader.ReadLine();
                    if (line == null)
                        break;

                    adv_data.Add(line);
                }
                adv_reader.Close();

                adv_data[selected_advert.id] = selected_advert.ToDataString();

                StreamWriter adv_writer = new StreamWriter("adverts-data.dat");
                foreach (string line in adv_data) {
                    adv_writer.WriteLine(line);
                }
                adv_writer.Close();
                jobInfo.Rtf = selected_advert.ToLongString(); //refresh content
                applicationSentAlert.Visible = true;
            }
            

        }
        private void backButton_Click(object sender, EventArgs e)
        {
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
        private void filterButton_Click(object sender, EventArgs e) {
            List<JobAdvert> filtered_adverts = new List<JobAdvert>();

            // <--- START OF FILTER BY KEYWORD --->
            if (filterKeyword.Text.Length > 0) { 
                string input = filterKeyword.Text.ToLower();
                if (input.Split(',').Length == 1) {
                    if(skills_table.ContainsKey(input))
                        filtered_adverts = (List<JobAdvert>)skills_table[input];
                } else {
                    string[] keywords = input.Split(',');
                    List<JobAdvert> prefiltered_adverts = new List<JobAdvert>();
                    int[] number_of_each_advert = new int[10] ;
                    for (int i = 0; i < keywords.Length; i++) {
                        if (!skills_table.ContainsKey(keywords[i]))
                            continue;

                        foreach (JobAdvert adv in (List<JobAdvert>)skills_table[keywords[i]]) {
                            if (!prefiltered_adverts.Contains(adv)) {
                                prefiltered_adverts.Add(adv);
                            }
                            number_of_each_advert[prefiltered_adverts.IndexOf(adv)]++;
                        }
                    }

                    for (int j = 0; j < prefiltered_adverts.Count; j++) {
                        if (number_of_each_advert[j] >= keywords.Length) {
                            filtered_adverts.Add(prefiltered_adverts[j]);
                        }
                    }
                }
            } else {
                filtered_adverts.AddRange(adverts);
            } // <--- END OF FILTER BY KEYWORD --->

            // <--- START OF FILTER BY COMPANY --->
            if(filterCompany.Text.Length > 1) {
                //filtered_adverts.Clear();
                List<JobAdvert> prefiltered_adverts = new List<JobAdvert>();
                List<JobAdvert> temp = new List<JobAdvert>();
                temp.AddRange(filtered_adverts);
                filtered_adverts = new List<JobAdvert>();
                foreach (JobCategory category in job_categories) {
                    if (category.Find(filterCompany.Text) != null) {
                        prefiltered_adverts.AddRange(category.Find(filterCompany.Text).adverts);
                    }
                }
                foreach (JobAdvert advert in temp) {
                    if (prefiltered_adverts.Contains(advert)) {
                        filtered_adverts.Add(advert);
                    }
                }
            }

            if(filterSalaryMin.Value != 0 || filterSalaryMax.Value != 999999) { // something changed. lets check
                List<JobAdvert> prefiltered_adverts = new List<JobAdvert>();
                List<JobAdvert> temp = new List<JobAdvert>();
                temp.AddRange(filtered_adverts);
                filtered_adverts = new List<JobAdvert>();
                foreach(JobAdvert advert in temp) {
                    if(advert.salary < filterSalaryMax.Value && advert.salary > filterSalaryMin.Value) {
                        filtered_adverts.Add(advert);
                    }
                }

            }

            jobAdvertCountLabel.Text = "Job Advert Count: " + filtered_adverts.Count;
            if (filtered_adverts.Count < 10)
                jobListPanel.AutoScroll = false;
            else
                jobListPanel.AutoScroll = true;

            jobInfo.Rtf = "";       // reset jobInfo
            jobListPanel.Controls.Clear();  //reset advers panel
            jobListPanel.RowStyles.Clear();

            Label[] filtered_job_labels = new Label[filtered_adverts.Count];

            for (int i = 0; i < filtered_adverts.Count; i++) {
                filtered_job_labels[i] = new Label() { Name = "jobLabel" + filtered_adverts[i].id, Text = filtered_adverts[i].ToShortString(), AutoSize = true, MaximumSize = new Size(350, 30) };
                filtered_job_labels[i].Click += new EventHandler(JobAdvert_Click);
                filtered_job_labels[i].MouseEnter += new EventHandler(JobAdvert_MouseEnter);
                filtered_job_labels[i].MouseLeave += new EventHandler(JobAdvert_MouseLeave);
            }

            for (int i = 0; i < filtered_adverts.Count; i++) {
                jobListPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
                jobListPanel.Controls.Add(filtered_job_labels[i]);
                if (i != filtered_adverts.Count - 1)
                    jobListPanel.RowCount = jobListPanel.RowCount + 1;
            }

        }
        private void signupButton_Click(object sender, EventArgs e) {
            signupForm.Show();
            this.Hide();
        }
        private void fetchFromHeapButton_Click(object sender, EventArgs e) {
            // If we didn't fetched anything before, this function will fetch right ammount of adverts
            // but if fetched adverts before, this function wont fetch adverts that fetched before
            // because fetched adverts gets removed from heap!!!
            foreach (JobCategory category in job_categories) {
                if (String.Equals(category.jobs_title, selectCategory.SelectedItem.ToString())) {
                    jobInfo.Rtf = "";       // reset jobInfo
                    jobListPanel.Controls.Clear();  //reset advers panel
                    jobListPanel.RowStyles.Clear();
                    Label[] filtered_job_labels = new Label[category.max_heap.nodes.Count];

                    int i = 0; // advert counter
                    while (!category.max_heap.IsEmpty() && i < N_numberOfAdvertsToShow.Value) {

                        JobAdvert advert = category.max_heap.PopMax();
                        filtered_job_labels[i] = new Label() { Name = "jobLabel" + advert.id, Text = advert.ToShortString(), AutoSize = true, MaximumSize = new Size(350, 30) };
                        filtered_job_labels[i].Click += new EventHandler(JobAdvert_Click);
                        filtered_job_labels[i].MouseEnter += new EventHandler(JobAdvert_MouseEnter);
                        filtered_job_labels[i].MouseLeave += new EventHandler(JobAdvert_MouseLeave);

                        jobListPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
                        jobListPanel.Controls.Add(filtered_job_labels[i]);
                        if (!category.max_heap.IsEmpty())
                            jobListPanel.RowCount = jobListPanel.RowCount + 1;

                        i++;
                    }
                    jobAdvertCountLabel.Text = "Job Advert Count: " + i;
                    if(i < 10)
                        jobListPanel.AutoScroll = false;
                    else
                        jobListPanel.AutoScroll = true;

                    break; // No need to check other categories
                } 
            }
        }
        public void SetUser(User usr) {
            user = usr;
            welcomeLabel.Text = "Welcome " + user.name + "!";
            signupButton.Text = "Update Profile";
            signupForm.UpdateInputs(user);
        }
        public void RetrieveInfo(FindEmployee findE) {
            findEmployee = findE;
            findEmployee.Init(skills_table, job_categories, adverts);
        }
        public void UpdateAdvertsTable() {
            jobListPanel.Controls.Clear();  //reset advers panel
            jobListPanel.RowStyles.Clear();
            advert_count = 0;
            job_labels = new Label[adverts.Count]; // yeah some of them will be null
            for (int i = 0; i < adverts.Count; i++) {
                job_labels[i] = new Label() { Name = "jobLabel" + i, Text = adverts[i].ToShortString(), AutoSize = true, MaximumSize = new Size(350, 30) };
                job_labels[i].Click += new EventHandler(JobAdvert_Click);
                job_labels[i].MouseEnter += new EventHandler(JobAdvert_MouseEnter);
                job_labels[i].MouseLeave += new EventHandler(JobAdvert_MouseLeave);

                jobListPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30));
                jobListPanel.Controls.Add(job_labels[i]);
                if (i != advert_count - 1)
                    jobListPanel.RowCount = jobListPanel.RowCount + 1;
            }
        }
    }
}

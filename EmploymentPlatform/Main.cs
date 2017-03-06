using System;
using System.Collections.Generic;
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
    public partial class EmploymentPlatform : Form
    {
        FindJob findJob;
        FindEmployee findEmployee;
        bool company_set = false;
        Company company;

        public EmploymentPlatform()
        {
            InitializeComponent();
            findJob = new FindJob(this);
        }
        private void findJobButton_Click(object sender, EventArgs e)
        {
            findJob.Show();
            this.Hide();
        }
        private void findJobLoginButton_Click(object sender, EventArgs e) {
            if (jobEmailInput.Text != "" && (jobEmailInput.Text.Length < 6 || !jobEmailInput.Text.Contains('@') || !jobEmailInput.Text.Contains('.'))) {
                errorAlert.Text = "Invalid email...";
                errorAlert.Visible = true; 
                return;
            }
            else if (jobEmailInput.Text.Contains('-') || jobPassInput.Text.Contains('-')) { // actual else is not required, return ends function
                errorAlert.Text = "'-' character is not allowed in any input fields!";
                errorAlert.Visible = true;
                return;
            }
            else {

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
                    string email = usr_data[i][0];
                    string password = usr_data[i][1];
                    if (jobEmailInput.Text == email) { // we found that mail
                        if (jobPassInput.Text == password) {
                            //public User(int id, string email, string password, string name, int age, string gender, string skills_str) {
                            User user = new User(i, usr_data[i][0], usr_data[i][1], usr_data[i][2], int.Parse(usr_data[i][3]), usr_data[i][4], usr_data[i][5]);
                            findJob.SetUser(user);
                            welcomeLabel.Text = "Welcome " + user.name + "!";
                            welcomeLabel.Visible = true;
                            jobEmailInput.Visible = false;
                            jobEmailLabel.Visible = false;
                            jobPassInput.Visible = false;
                            jobPasswordLabel.Visible = false;
                            optionalLabel.Visible = false;
                            findJobLoginButton.Visible = false;
                            successAlert.Text = "You have logged in successfully!";
                            successAlert.Visible = true;
                            return; // no need to check other emails

                        }
                        else {
                            errorAlert.Text = "Wrong password!";
                            errorAlert.Visible = true;
                            return;
                        }
                    }

                    if (i == usr_data.Count - 1) {
                        errorAlert.Text = "This email does not belongs to any account!";
                        errorAlert.Visible = true;
                    }
                }
            }           
        }
        private void findEmpLoginButton_Click(object sender, EventArgs e) {
            if (companyInput.Text.Length < 3 ) {
                errorAlert.Text = "Company name must bu greater than two characters!";
                errorAlert.Visible = true;
                return;
            }
            else if (companyInput.Text.Contains('-') || empPassInput.Text.Contains('-')) {
                errorAlert.Text = "'-' character is not allowed in any input fields!";
                errorAlert.Visible = true;
                return;
            }
            else {
                StreamReader comp_reader = new StreamReader("company-data.dat");
                List<string[]> comp_data = new List<string[]>();
                

                while (true) {
                    string line = comp_reader.ReadLine();
                    if (line == null)
                        break;

                    comp_data.Add(line.Split('-'));
                }
                comp_reader.Close();

                for (int i = 0; i < comp_data.Count; i++) {
                    string comp_name = comp_data[i][0];
                    string password = comp_data[i][1];
                    if (String.Equals(companyInput.Text, comp_name)) { // we found that mail
                        if (String.Equals(empPassInput.Text, password)) {
                            company = new Company(companyInput.Text);
                            empWelcomeLabel.Text = "Welcome " + company.company_name + "!";
                            empWelcomeLabel.Visible = true;
                            empPassInput.Visible = false;
                            empPassLabel.Visible = false;
                            companyInput.Visible = false;
                            companyLabel.Visible = false;
                            requiredLabel.Visible = false;
                            findEmpLoginButton.Visible = false;
                            successAlert.Text = "You have logged in successfully!";
                            successAlert.Visible = true;
                            company_set = true;
                            return; // no need to check other emails
                        }
                        else {
                            errorAlert.Text = "Wrong password!";
                            errorAlert.Visible = true;
                            return;
                        }
                    }

                    if (i == comp_data.Count - 1) { //company doesn't exist, create a new company account
                        if (empPassInput.Text.Length < 6) {
                            errorAlert.Text = "Password must be more than 6 characters";
                            errorAlert.Visible = true;
                            return;
                        }

                        string[] new_company = new string[2];
                        new_company[0] = companyInput.Text;
                        new_company[1] = empPassInput.Text;

                        comp_data.Add(new_company);
                        StreamWriter comp_writer = new StreamWriter("company-data.dat");
                        foreach (string[] field in comp_data) {
                            string data = field[0] + "-" + field[1];
                            comp_writer.WriteLine(data);
                        }
                        comp_writer.Close();

                        company = new Company(companyInput.Text);
                        empWelcomeLabel.Text = "Welcome " + company.company_name + "!";
                        empWelcomeLabel.Visible = true;
                        empPassInput.Visible = false;
                        empPassLabel.Visible = false;
                        companyInput.Visible = false;
                        companyLabel.Visible = false;
                        findEmpLoginButton.Visible = false;
                        successAlert.Text = "Your account created successfully!";
                        successAlert.Visible = true;
                        company_set = true;
                    }
                }
            }
        }
        private void findEmployeeButton_Click(object sender, EventArgs e) {
            if (!company_set) {
                errorAlert.Text = "You must login to your company account to proceed!";
                errorAlert.Visible = true;
                return;
            } else {
                findEmployee = new FindEmployee(this, findJob, company);
                findEmployee.Show();
                this.Hide();
            }
        }
        public void UpdateFindjobAdvertsTable() {
            findJob.UpdateAdvertsTable();
        }
    }
}

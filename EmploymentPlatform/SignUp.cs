using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Collections;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmploymentPlatform {
    public partial class SignUp : Form {
        FindJob findJobForm;
        User user;
        Hashtable skills_table;
        bool progressing = false;

        public SignUp(FindJob finJobF, Hashtable skills_table) {
            findJobForm = finJobF;
            this.skills_table = skills_table;
            InitializeComponent();
            List<string> skillz = new List<string>();
            
            foreach(string key in skills_table.Keys) {
                skillz.Add(key[0].ToString().ToUpper() + key.Substring(1));
            }
            skillz.Sort();
            foreach(string s in skillz) {
                skillsCheckedList.Items.Add(s);
            }

        }
        private void skillsRadio_CheckedChanged(object sender) {
            if (yesSkillsRadio.Checked) {
                skillsGroup.Show();
                skillsCheckedList.Show();
                skillsLabel.Show();
            }
            else if (noSkillsRadio.Checked) {
                skillsLabel.Hide();
                skillsCheckedList.Hide();
                skillsGroup.Hide();

            }
        }
        private void cancelButtasdon_Click(object sender, EventArgs e) {
            findJobForm.Show();
            this.Hide();
        }
        private void saveButton_Click(object sender, EventArgs e) {

            if (!this.progressing) {

                progressing = true;
                flatProgressBar1.Value = 0;
                flatProgressBar1.Visible = true;

                new Thread(() => {
                    while (flatProgressBar1.Value < flatProgressBar1.Maximum) {
                        Thread.Sleep(3);
                        this.Invoke((MethodInvoker)delegate {
                            flatProgressBar1.Increment(1);

                            if (flatProgressBar1.Value == flatProgressBar1.Maximum) {
                                // progress bar is full !
                                flatProgressBar1.Visible = false;

                                if (nameInput.Text.Length < 3) {
                                    errorAlert.Text = "Inavlid name!";
                                }
                                else if (emailInput.Text.Length < 6 || !emailInput.Text.Contains("@")) {
                                    errorAlert.Text = "Invalid email!";
                                    errorAlert.Visible = true;
                                }
                                else if (passwordInput.Text.Length < 6) {
                                    errorAlert.Text = "Your password must be greater than five characters";
                                    errorAlert.Visible = true;
                                }
                                else if (nameInput.Text.Contains("-") || emailInput.Text.Contains("-") || passwordInput.Text.Contains("-")) {
                                    errorAlert.Text = "'-' character is not allowed in any inputs!";
                                }
                                else {
                                    string gender, skills_str = "";
                                    if (genderMaleRadio.Checked)
                                        gender = "Male";
                                    else
                                        gender = "Female";

                                    if (yesSkillsRadio.Checked) {
                                        for (int i = 0; i < skillsCheckedList.CheckedItems.Count; i++) {

                                            if (i == 0)
                                                skills_str = skillsCheckedList.CheckedItems[i].ToString() + ",";
                                            else if (i == skillsCheckedList.CheckedItems.Count - 1)
                                                skills_str += skillsCheckedList.CheckedItems[i].ToString();
                                            else
                                                skills_str += skillsCheckedList.CheckedItems[i].ToString() + ",";
                                        }
                                    }
                                    if (user == null)
                                        user = new User(-1, emailInput.Text, passwordInput.Text, nameInput.Text, (int)ageInput.Value, gender, skills_str);
                                    else
                                        user.UpdateInfo(emailInput.Text, passwordInput.Text, nameInput.Text, (int)ageInput.Value, skills_str);

                                    findJobForm.SetUser(user);

                                    StreamReader usr_reader = new StreamReader("users-data.dat");
                                    List<string> usr_data = new List<string>();

                                    while (true) {
                                        string line = usr_reader.ReadLine();
                                        if (line == null)
                                            break;

                                        usr_data.Add(line);
                                    }
                                    usr_reader.Close();


                                    StreamWriter usr_writer = new StreamWriter("users-data.dat");

                                    for (int i = 0; i < usr_data.Count; i++) {
                                        if(usr_data[i].Split('-')[0] == user.email) {
                                            usr_data[i] = user.ToDataString();
                                            break;

                                        }

                                        if(i == usr_data.Count - 1) {
                                            //write new user
                                            user.id = i;
                                            usr_writer.WriteLine(user.ToDataString());
                                        }
                                    }

                                    
                                    foreach(string line in usr_data) {
                                        usr_writer.WriteLine(line);
                                    }
                                    usr_writer.Close();


                                    successAlert.Text = "Your account created successfully!";
                                    successAlert.Visible = true;
                                }
                            }
                        });
                    }
                    progressing = false;
                }).Start();
            }
        }
        public void UpdateInputs(User user) {
            this.user = user;
            nameInput.Text = user.name;
            emailInput.Text = user.email;
            passwordInput.Text = user.password;
            ageInput.Value = user.age;
            formSkin1.Text = "Employment Platform - Update Profile";
            if (user.gender == "Male") {
                genderFemaleRadio.Checked = false;
                genderMaleRadio.Checked = true;
            }
            if (user.skills != null) {
                if (user.skills.Length > 0) {
                    noSkillsRadio.Checked = false;
                    yesSkillsRadio.Checked = true;
                    skillsLabel.Visible = true;
                    skillsGroup.Visible = true;
                    skillsCheckedList.Visible = true;
                    for (int i = 0; i < user.skills.Length; i++) {
                        string skill_right_form = user.skills[i][0].ToString().ToUpper() + user.skills[i].Substring(1).ToLower();
                        if (skillsCheckedList.Items.Contains(skill_right_form)) {
                            int index = skillsCheckedList.Items.IndexOf(skill_right_form);
                            skillsCheckedList.SetItemChecked(index, true);
                        }
                    }
                }
            }
        }
        
    }
}

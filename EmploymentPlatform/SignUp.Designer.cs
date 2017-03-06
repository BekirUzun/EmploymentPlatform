namespace EmploymentPlatform {
    partial class SignUp {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.formSkin1 = new FlatUI.FormSkin();
            this.experienceGroup = new FlatUI.FlatGroupBox();
            this.noSkillsRadio = new FlatUI.FlatRadioButton();
            this.yesSkillsRadio = new FlatUI.FlatRadioButton();
            this.successAlert = new FlatUI.FlatAlertBox();
            this.errorAlert = new FlatUI.FlatAlertBox();
            this.skillsGroup = new FlatUI.FlatGroupBox();
            this.skillsCheckedList = new System.Windows.Forms.CheckedListBox();
            this.saveButton = new FlatUI.FlatButton();
            this.cancelButton = new FlatUI.FlatButton();
            this.flatProgressBar1 = new FlatUI.FlatProgressBar();
            this.flatLabel7 = new FlatUI.FlatLabel();
            this.ageInput = new FlatUI.FlatNumeric();
            this.emailInput = new FlatUI.FlatTextBox();
            this.flatLabel6 = new FlatUI.FlatLabel();
            this.flatLabel5 = new FlatUI.FlatLabel();
            this.skillsLabel = new FlatUI.FlatLabel();
            this.flatLabel4 = new FlatUI.FlatLabel();
            this.flatLabel3 = new FlatUI.FlatLabel();
            this.passwordInput = new FlatUI.FlatTextBox();
            this.nameInput = new FlatUI.FlatTextBox();
            this.flatLabel1 = new FlatUI.FlatLabel();
            this.flatClose1 = new FlatUI.FlatClose();
            this.genderGroup = new FlatUI.FlatGroupBox();
            this.genderFemaleRadio = new FlatUI.FlatRadioButton();
            this.genderMaleRadio = new FlatUI.FlatRadioButton();
            this.formSkin1.SuspendLayout();
            this.experienceGroup.SuspendLayout();
            this.skillsGroup.SuspendLayout();
            this.genderGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // formSkin1
            // 
            this.formSkin1.BackColor = System.Drawing.Color.White;
            this.formSkin1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.formSkin1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.formSkin1.Controls.Add(this.experienceGroup);
            this.formSkin1.Controls.Add(this.successAlert);
            this.formSkin1.Controls.Add(this.errorAlert);
            this.formSkin1.Controls.Add(this.skillsGroup);
            this.formSkin1.Controls.Add(this.saveButton);
            this.formSkin1.Controls.Add(this.cancelButton);
            this.formSkin1.Controls.Add(this.flatProgressBar1);
            this.formSkin1.Controls.Add(this.flatLabel7);
            this.formSkin1.Controls.Add(this.ageInput);
            this.formSkin1.Controls.Add(this.emailInput);
            this.formSkin1.Controls.Add(this.flatLabel6);
            this.formSkin1.Controls.Add(this.flatLabel5);
            this.formSkin1.Controls.Add(this.skillsLabel);
            this.formSkin1.Controls.Add(this.flatLabel4);
            this.formSkin1.Controls.Add(this.flatLabel3);
            this.formSkin1.Controls.Add(this.passwordInput);
            this.formSkin1.Controls.Add(this.nameInput);
            this.formSkin1.Controls.Add(this.flatLabel1);
            this.formSkin1.Controls.Add(this.flatClose1);
            this.formSkin1.Controls.Add(this.genderGroup);
            this.formSkin1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formSkin1.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(138)))), ((int)(((byte)(168)))));
            this.formSkin1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.formSkin1.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.formSkin1.HeaderMaximize = false;
            this.formSkin1.Location = new System.Drawing.Point(0, 0);
            this.formSkin1.Name = "formSkin1";
            this.formSkin1.Size = new System.Drawing.Size(550, 520);
            this.formSkin1.TabIndex = 0;
            this.formSkin1.Text = "Employment Platform - Sign up";
            // 
            // experienceGroup
            // 
            this.experienceGroup.BackColor = System.Drawing.Color.Transparent;
            this.experienceGroup.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.experienceGroup.Controls.Add(this.noSkillsRadio);
            this.experienceGroup.Controls.Add(this.yesSkillsRadio);
            this.experienceGroup.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.experienceGroup.Location = new System.Drawing.Point(194, 255);
            this.experienceGroup.Name = "experienceGroup";
            this.experienceGroup.ShowText = true;
            this.experienceGroup.Size = new System.Drawing.Size(235, 31);
            this.experienceGroup.TabIndex = 14;
            // 
            // noSkillsRadio
            // 
            this.noSkillsRadio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.noSkillsRadio.Checked = true;
            this.noSkillsRadio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.noSkillsRadio.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.noSkillsRadio.Location = new System.Drawing.Point(0, 6);
            this.noSkillsRadio.Name = "noSkillsRadio";
            this.noSkillsRadio.Options = FlatUI.FlatRadioButton._Options.Style1;
            this.noSkillsRadio.Size = new System.Drawing.Size(125, 22);
            this.noSkillsRadio.TabIndex = 4;
            this.noSkillsRadio.Tag = "experience";
            this.noSkillsRadio.Text = "No, I don\'t have";
            this.noSkillsRadio.CheckedChanged += new FlatUI.FlatRadioButton.CheckedChangedEventHandler(this.skillsRadio_CheckedChanged);
            // 
            // yesSkillsRadio
            // 
            this.yesSkillsRadio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.yesSkillsRadio.Checked = false;
            this.yesSkillsRadio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.yesSkillsRadio.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.yesSkillsRadio.Location = new System.Drawing.Point(128, 6);
            this.yesSkillsRadio.Name = "yesSkillsRadio";
            this.yesSkillsRadio.Options = FlatUI.FlatRadioButton._Options.Style1;
            this.yesSkillsRadio.Size = new System.Drawing.Size(92, 22);
            this.yesSkillsRadio.TabIndex = 4;
            this.yesSkillsRadio.Tag = "experience";
            this.yesSkillsRadio.Text = "Yes, I have";
            this.yesSkillsRadio.CheckedChanged += new FlatUI.FlatRadioButton.CheckedChangedEventHandler(this.skillsRadio_CheckedChanged);
            // 
            // successAlert
            // 
            this.successAlert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.successAlert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.successAlert.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.successAlert.kind = FlatUI.FlatAlertBox._Kind.Success;
            this.successAlert.Location = new System.Drawing.Point(12, 461);
            this.successAlert.Name = "successAlert";
            this.successAlert.Size = new System.Drawing.Size(526, 42);
            this.successAlert.TabIndex = 11;
            this.successAlert.Text = "Action completed successfully!";
            this.successAlert.Visible = false;
            // 
            // errorAlert
            // 
            this.errorAlert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.errorAlert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.errorAlert.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.errorAlert.kind = FlatUI.FlatAlertBox._Kind.Error;
            this.errorAlert.Location = new System.Drawing.Point(12, 461);
            this.errorAlert.Name = "errorAlert";
            this.errorAlert.Size = new System.Drawing.Size(526, 42);
            this.errorAlert.TabIndex = 11;
            this.errorAlert.Text = "Action failed!";
            this.errorAlert.Visible = false;
            // 
            // skillsGroup
            // 
            this.skillsGroup.BackColor = System.Drawing.Color.Transparent;
            this.skillsGroup.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.skillsGroup.Controls.Add(this.skillsCheckedList);
            this.skillsGroup.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.skillsGroup.Location = new System.Drawing.Point(184, 283);
            this.skillsGroup.Name = "skillsGroup";
            this.skillsGroup.ShowText = true;
            this.skillsGroup.Size = new System.Drawing.Size(256, 111);
            this.skillsGroup.TabIndex = 10;
            this.skillsGroup.Tag = "Skills";
            this.skillsGroup.Text = "Skills";
            this.skillsGroup.Visible = false;
            // 
            // skillsCheckedList
            // 
            this.skillsCheckedList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.skillsCheckedList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skillsCheckedList.CheckOnClick = true;
            this.skillsCheckedList.ForeColor = System.Drawing.Color.White;
            this.skillsCheckedList.FormattingEnabled = true;
            this.skillsCheckedList.Location = new System.Drawing.Point(14, 15);
            this.skillsCheckedList.Name = "skillsCheckedList";
            this.skillsCheckedList.Size = new System.Drawing.Size(224, 80);
            this.skillsCheckedList.TabIndex = 9;
            this.skillsCheckedList.ThreeDCheckBoxes = true;
            this.skillsCheckedList.Visible = false;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Transparent;
            this.saveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.saveButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(138)))), ((int)(((byte)(168)))));
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.saveButton.Location = new System.Drawing.Point(322, 415);
            this.saveButton.Name = "saveButton";
            this.saveButton.Rounded = false;
            this.saveButton.Size = new System.Drawing.Size(110, 40);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Save Profile";
            this.saveButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.Transparent;
            this.cancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancelButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(138)))), ((int)(((byte)(168)))));
            this.cancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cancelButton.Location = new System.Drawing.Point(101, 415);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Rounded = false;
            this.cancelButton.Size = new System.Drawing.Size(110, 40);
            this.cancelButton.TabIndex = 8;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.cancelButton.Click += new System.EventHandler(this.cancelButtasdon_Click);
            // 
            // flatProgressBar1
            // 
            this.flatProgressBar1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flatProgressBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.flatProgressBar1.DarkerProgress = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(148)))), ((int)(((byte)(92)))));
            this.flatProgressBar1.Location = new System.Drawing.Point(12, 461);
            this.flatProgressBar1.Maximum = 100;
            this.flatProgressBar1.Name = "flatProgressBar1";
            this.flatProgressBar1.Pattern = true;
            this.flatProgressBar1.PercentSign = false;
            this.flatProgressBar1.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(138)))), ((int)(((byte)(168)))));
            this.flatProgressBar1.ShowBalloon = false;
            this.flatProgressBar1.Size = new System.Drawing.Size(526, 42);
            this.flatProgressBar1.TabIndex = 7;
            this.flatProgressBar1.Text = "flatProgressBar1";
            this.flatProgressBar1.Value = 0;
            this.flatProgressBar1.Visible = false;
            // 
            // flatLabel7
            // 
            this.flatLabel7.AutoSize = true;
            this.flatLabel7.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel7.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatLabel7.ForeColor = System.Drawing.Color.White;
            this.flatLabel7.Location = new System.Drawing.Point(97, 256);
            this.flatLabel7.Name = "flatLabel7";
            this.flatLabel7.Size = new System.Drawing.Size(91, 21);
            this.flatLabel7.TabIndex = 5;
            this.flatLabel7.Text = "Experience :";
            // 
            // ageInput
            // 
            this.ageInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.ageInput.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.ageInput.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(138)))), ((int)(((byte)(168)))));
            this.ageInput.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.ageInput.ForeColor = System.Drawing.Color.White;
            this.ageInput.Location = new System.Drawing.Point(195, 186);
            this.ageInput.Maximum = ((long)(150));
            this.ageInput.Minimum = ((long)(0));
            this.ageInput.Name = "ageInput";
            this.ageInput.Size = new System.Drawing.Size(75, 30);
            this.ageInput.TabIndex = 3;
            this.ageInput.Text = "ageInput";
            this.ageInput.Value = ((long)(18));
            // 
            // emailInput
            // 
            this.emailInput.BackColor = System.Drawing.Color.Transparent;
            this.emailInput.FocusOnHover = false;
            this.emailInput.Location = new System.Drawing.Point(195, 108);
            this.emailInput.MaxLength = 100;
            this.emailInput.Multiline = false;
            this.emailInput.Name = "emailInput";
            this.emailInput.ReadOnly = false;
            this.emailInput.Size = new System.Drawing.Size(237, 29);
            this.emailInput.TabIndex = 2;
            this.emailInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.emailInput.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.emailInput.UseSystemPasswordChar = false;
            // 
            // flatLabel6
            // 
            this.flatLabel6.AutoSize = true;
            this.flatLabel6.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel6.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatLabel6.ForeColor = System.Drawing.Color.White;
            this.flatLabel6.Location = new System.Drawing.Point(120, 225);
            this.flatLabel6.Name = "flatLabel6";
            this.flatLabel6.Size = new System.Drawing.Size(68, 21);
            this.flatLabel6.TabIndex = 1;
            this.flatLabel6.Text = "Gender :";
            // 
            // flatLabel5
            // 
            this.flatLabel5.AutoSize = true;
            this.flatLabel5.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel5.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatLabel5.ForeColor = System.Drawing.Color.White;
            this.flatLabel5.Location = new System.Drawing.Point(144, 195);
            this.flatLabel5.Name = "flatLabel5";
            this.flatLabel5.Size = new System.Drawing.Size(44, 21);
            this.flatLabel5.TabIndex = 1;
            this.flatLabel5.Text = "Age :";
            // 
            // skillsLabel
            // 
            this.skillsLabel.AutoSize = true;
            this.skillsLabel.BackColor = System.Drawing.Color.Transparent;
            this.skillsLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.skillsLabel.ForeColor = System.Drawing.Color.White;
            this.skillsLabel.Location = new System.Drawing.Point(135, 291);
            this.skillsLabel.Name = "skillsLabel";
            this.skillsLabel.Size = new System.Drawing.Size(53, 21);
            this.skillsLabel.TabIndex = 1;
            this.skillsLabel.Text = "Skills :";
            this.skillsLabel.Visible = false;
            // 
            // flatLabel4
            // 
            this.flatLabel4.AutoSize = true;
            this.flatLabel4.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatLabel4.ForeColor = System.Drawing.Color.White;
            this.flatLabel4.Location = new System.Drawing.Point(105, 151);
            this.flatLabel4.Name = "flatLabel4";
            this.flatLabel4.Size = new System.Drawing.Size(83, 21);
            this.flatLabel4.TabIndex = 1;
            this.flatLabel4.Text = "Password :";
            // 
            // flatLabel3
            // 
            this.flatLabel3.AutoSize = true;
            this.flatLabel3.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatLabel3.ForeColor = System.Drawing.Color.White;
            this.flatLabel3.Location = new System.Drawing.Point(133, 116);
            this.flatLabel3.Name = "flatLabel3";
            this.flatLabel3.Size = new System.Drawing.Size(55, 21);
            this.flatLabel3.TabIndex = 1;
            this.flatLabel3.Text = "Email :";
            // 
            // passwordInput
            // 
            this.passwordInput.BackColor = System.Drawing.Color.Transparent;
            this.passwordInput.FocusOnHover = false;
            this.passwordInput.Location = new System.Drawing.Point(195, 143);
            this.passwordInput.MaxLength = 20;
            this.passwordInput.Multiline = false;
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.ReadOnly = false;
            this.passwordInput.Size = new System.Drawing.Size(158, 29);
            this.passwordInput.TabIndex = 2;
            this.passwordInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.passwordInput.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.passwordInput.UseSystemPasswordChar = false;
            // 
            // nameInput
            // 
            this.nameInput.BackColor = System.Drawing.Color.Transparent;
            this.nameInput.FocusOnHover = false;
            this.nameInput.Location = new System.Drawing.Point(195, 73);
            this.nameInput.MaxLength = 20;
            this.nameInput.Multiline = false;
            this.nameInput.Name = "nameInput";
            this.nameInput.ReadOnly = false;
            this.nameInput.Size = new System.Drawing.Size(158, 29);
            this.nameInput.TabIndex = 2;
            this.nameInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.nameInput.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.nameInput.UseSystemPasswordChar = false;
            // 
            // flatLabel1
            // 
            this.flatLabel1.AutoSize = true;
            this.flatLabel1.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatLabel1.ForeColor = System.Drawing.Color.White;
            this.flatLabel1.Location = new System.Drawing.Point(32, 81);
            this.flatLabel1.Name = "flatLabel1";
            this.flatLabel1.Size = new System.Drawing.Size(156, 21);
            this.flatLabel1.TabIndex = 1;
            this.flatLabel1.Text = "Name and Surname :";
            // 
            // flatClose1
            // 
            this.flatClose1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatClose1.BackColor = System.Drawing.Color.White;
            this.flatClose1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.flatClose1.Font = new System.Drawing.Font("Marlett", 10F);
            this.flatClose1.Location = new System.Drawing.Point(520, 13);
            this.flatClose1.Name = "flatClose1";
            this.flatClose1.Size = new System.Drawing.Size(18, 18);
            this.flatClose1.TabIndex = 0;
            this.flatClose1.Text = "flatClose1";
            this.flatClose1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // genderGroup
            // 
            this.genderGroup.BackColor = System.Drawing.Color.Transparent;
            this.genderGroup.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.genderGroup.Controls.Add(this.genderFemaleRadio);
            this.genderGroup.Controls.Add(this.genderMaleRadio);
            this.genderGroup.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.genderGroup.Location = new System.Drawing.Point(194, 222);
            this.genderGroup.Name = "genderGroup";
            this.genderGroup.ShowText = true;
            this.genderGroup.Size = new System.Drawing.Size(235, 31);
            this.genderGroup.TabIndex = 14;
            // 
            // genderFemaleRadio
            // 
            this.genderFemaleRadio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.genderFemaleRadio.Checked = false;
            this.genderFemaleRadio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.genderFemaleRadio.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.genderFemaleRadio.Location = new System.Drawing.Point(128, 6);
            this.genderFemaleRadio.Name = "genderFemaleRadio";
            this.genderFemaleRadio.Options = FlatUI.FlatRadioButton._Options.Style1;
            this.genderFemaleRadio.Size = new System.Drawing.Size(74, 22);
            this.genderFemaleRadio.TabIndex = 13;
            this.genderFemaleRadio.Tag = "Gender";
            this.genderFemaleRadio.Text = "Female";
            // 
            // genderMaleRadio
            // 
            this.genderMaleRadio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.genderMaleRadio.Checked = true;
            this.genderMaleRadio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.genderMaleRadio.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.genderMaleRadio.Location = new System.Drawing.Point(0, 6);
            this.genderMaleRadio.Name = "genderMaleRadio";
            this.genderMaleRadio.Options = FlatUI.FlatRadioButton._Options.Style1;
            this.genderMaleRadio.Size = new System.Drawing.Size(66, 22);
            this.genderMaleRadio.TabIndex = 12;
            this.genderMaleRadio.Tag = "gender";
            this.genderMaleRadio.Text = "Male";
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 520);
            this.Controls.Add(this.formSkin1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.formSkin1.ResumeLayout(false);
            this.formSkin1.PerformLayout();
            this.experienceGroup.ResumeLayout(false);
            this.skillsGroup.ResumeLayout(false);
            this.genderGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FlatUI.FormSkin formSkin1;
        private FlatUI.FlatClose flatClose1;
        private FlatUI.FlatLabel flatLabel7;
        private FlatUI.FlatRadioButton yesSkillsRadio;
        private FlatUI.FlatRadioButton noSkillsRadio;
        private FlatUI.FlatNumeric ageInput;
        private FlatUI.FlatTextBox emailInput;
        private FlatUI.FlatLabel flatLabel5;
        private FlatUI.FlatLabel skillsLabel;
        private FlatUI.FlatLabel flatLabel4;
        private FlatUI.FlatLabel flatLabel3;
        private FlatUI.FlatTextBox passwordInput;
        private FlatUI.FlatTextBox nameInput;
        private FlatUI.FlatLabel flatLabel1;
        private FlatUI.FlatButton saveButton;
        private FlatUI.FlatButton cancelButton;
        private FlatUI.FlatProgressBar flatProgressBar1;
        private System.Windows.Forms.CheckedListBox skillsCheckedList;
        private FlatUI.FlatGroupBox skillsGroup;
        private FlatUI.FlatAlertBox errorAlert;
        private FlatUI.FlatAlertBox successAlert;
        private FlatUI.FlatRadioButton genderFemaleRadio;
        private FlatUI.FlatLabel flatLabel6;
        private FlatUI.FlatGroupBox genderGroup;
        private FlatUI.FlatRadioButton genderMaleRadio;
        private FlatUI.FlatGroupBox experienceGroup;
    }
}
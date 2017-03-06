namespace EmploymentPlatform {
    partial class FindEmployee {
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
            this.errorAlert = new FlatUI.FlatAlertBox();
            this.successAlert = new FlatUI.FlatAlertBox();
            this.savedSuccesfullyAlert = new FlatUI.FlatAlertBox();
            this.deadlineInput = new System.Windows.Forms.DateTimePicker();
            this.skillsLabel = new FlatUI.FlatLabel();
            this.skillsGroup = new FlatUI.FlatGroupBox();
            this.skillsCheckedList = new System.Windows.Forms.CheckedListBox();
            this.deadlineLabel = new FlatUI.FlatLabel();
            this.applicantNameLabel = new FlatUI.FlatLabel();
            this.applicationsLabel = new FlatUI.FlatLabel();
            this.flatLabel3 = new FlatUI.FlatLabel();
            this.flatLabel2 = new FlatUI.FlatLabel();
            this.flatLabel1 = new FlatUI.FlatLabel();
            this.jobTitleLabel = new FlatUI.FlatLabel();
            this.companyNameLabel = new FlatUI.FlatLabel();
            this.applicantNameInput = new FlatUI.FlatTextBox();
            this.applicationsInput = new FlatUI.FlatTextBox();
            this.locationInput = new FlatUI.FlatTextBox();
            this.descriptionInput = new FlatUI.FlatTextBox();
            this.salaryInput = new FlatUI.FlatTextBox();
            this.jobTitleInput = new FlatUI.FlatTextBox();
            this.companyNameInput = new FlatUI.FlatTextBox();
            this.hireButton = new FlatUI.FlatButton();
            this.saveAdvertButton = new FlatUI.FlatButton();
            this.deleteAdvertButton = new FlatUI.FlatButton();
            this.createAdvertButton = new FlatUI.FlatButton();
            this.jobAdvertCountLabel = new FlatUI.FlatLabel();
            this.jobListPanel = new System.Windows.Forms.TableLayoutPanel();
            this.welcomeLabel = new FlatUI.FlatLabel();
            this.backButton = new FlatUI.FlatButton();
            this.flatMini1 = new FlatUI.FlatMini();
            this.flatClose1 = new FlatUI.FlatClose();
            this.recommendButton = new FlatUI.FlatButton();
            this.formSkin1.SuspendLayout();
            this.skillsGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // formSkin1
            // 
            this.formSkin1.BackColor = System.Drawing.Color.White;
            this.formSkin1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.formSkin1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.formSkin1.Controls.Add(this.recommendButton);
            this.formSkin1.Controls.Add(this.errorAlert);
            this.formSkin1.Controls.Add(this.successAlert);
            this.formSkin1.Controls.Add(this.savedSuccesfullyAlert);
            this.formSkin1.Controls.Add(this.deadlineInput);
            this.formSkin1.Controls.Add(this.skillsLabel);
            this.formSkin1.Controls.Add(this.skillsGroup);
            this.formSkin1.Controls.Add(this.deadlineLabel);
            this.formSkin1.Controls.Add(this.applicantNameLabel);
            this.formSkin1.Controls.Add(this.applicationsLabel);
            this.formSkin1.Controls.Add(this.flatLabel3);
            this.formSkin1.Controls.Add(this.flatLabel2);
            this.formSkin1.Controls.Add(this.flatLabel1);
            this.formSkin1.Controls.Add(this.jobTitleLabel);
            this.formSkin1.Controls.Add(this.companyNameLabel);
            this.formSkin1.Controls.Add(this.applicantNameInput);
            this.formSkin1.Controls.Add(this.applicationsInput);
            this.formSkin1.Controls.Add(this.locationInput);
            this.formSkin1.Controls.Add(this.descriptionInput);
            this.formSkin1.Controls.Add(this.salaryInput);
            this.formSkin1.Controls.Add(this.jobTitleInput);
            this.formSkin1.Controls.Add(this.companyNameInput);
            this.formSkin1.Controls.Add(this.hireButton);
            this.formSkin1.Controls.Add(this.saveAdvertButton);
            this.formSkin1.Controls.Add(this.deleteAdvertButton);
            this.formSkin1.Controls.Add(this.createAdvertButton);
            this.formSkin1.Controls.Add(this.jobAdvertCountLabel);
            this.formSkin1.Controls.Add(this.jobListPanel);
            this.formSkin1.Controls.Add(this.welcomeLabel);
            this.formSkin1.Controls.Add(this.backButton);
            this.formSkin1.Controls.Add(this.flatMini1);
            this.formSkin1.Controls.Add(this.flatClose1);
            this.formSkin1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formSkin1.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(138)))), ((int)(((byte)(168)))));
            this.formSkin1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.formSkin1.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.formSkin1.HeaderMaximize = false;
            this.formSkin1.Location = new System.Drawing.Point(0, 0);
            this.formSkin1.Name = "formSkin1";
            this.formSkin1.Size = new System.Drawing.Size(800, 650);
            this.formSkin1.TabIndex = 0;
            this.formSkin1.Text = "Employment Platform - Find Employee";
            // 
            // errorAlert
            // 
            this.errorAlert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.errorAlert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.errorAlert.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.errorAlert.kind = FlatUI.FlatAlertBox._Kind.Error;
            this.errorAlert.Location = new System.Drawing.Point(15, 596);
            this.errorAlert.Name = "errorAlert";
            this.errorAlert.Size = new System.Drawing.Size(773, 42);
            this.errorAlert.TabIndex = 26;
            this.errorAlert.Text = "Action failed!";
            this.errorAlert.Visible = false;
            // 
            // successAlert
            // 
            this.successAlert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.successAlert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.successAlert.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.successAlert.kind = FlatUI.FlatAlertBox._Kind.Success;
            this.successAlert.Location = new System.Drawing.Point(15, 596);
            this.successAlert.Name = "successAlert";
            this.successAlert.Size = new System.Drawing.Size(773, 42);
            this.successAlert.TabIndex = 26;
            this.successAlert.Text = "Action successfully completed!";
            this.successAlert.Visible = false;
            // 
            // savedSuccesfullyAlert
            // 
            this.savedSuccesfullyAlert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.savedSuccesfullyAlert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.savedSuccesfullyAlert.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.savedSuccesfullyAlert.kind = FlatUI.FlatAlertBox._Kind.Success;
            this.savedSuccesfullyAlert.Location = new System.Drawing.Point(15, 596);
            this.savedSuccesfullyAlert.Name = "savedSuccesfullyAlert";
            this.savedSuccesfullyAlert.Size = new System.Drawing.Size(773, 42);
            this.savedSuccesfullyAlert.TabIndex = 26;
            this.savedSuccesfullyAlert.Text = "Advert saved successfully!";
            this.savedSuccesfullyAlert.Visible = false;
            // 
            // deadlineInput
            // 
            this.deadlineInput.Location = new System.Drawing.Point(555, 463);
            this.deadlineInput.MinDate = new System.DateTime(2016, 12, 1, 0, 0, 0, 0);
            this.deadlineInput.Name = "deadlineInput";
            this.deadlineInput.Size = new System.Drawing.Size(233, 29);
            this.deadlineInput.TabIndex = 25;
            this.deadlineInput.Value = new System.DateTime(2016, 12, 1, 0, 0, 0, 0);
            // 
            // skillsLabel
            // 
            this.skillsLabel.AutoSize = true;
            this.skillsLabel.BackColor = System.Drawing.Color.Transparent;
            this.skillsLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.skillsLabel.ForeColor = System.Drawing.Color.White;
            this.skillsLabel.Location = new System.Drawing.Point(496, 172);
            this.skillsLabel.Name = "skillsLabel";
            this.skillsLabel.Size = new System.Drawing.Size(53, 21);
            this.skillsLabel.TabIndex = 24;
            this.skillsLabel.Text = "Skills :";
            // 
            // skillsGroup
            // 
            this.skillsGroup.BackColor = System.Drawing.Color.Transparent;
            this.skillsGroup.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.skillsGroup.Controls.Add(this.skillsCheckedList);
            this.skillsGroup.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.skillsGroup.Location = new System.Drawing.Point(545, 158);
            this.skillsGroup.Name = "skillsGroup";
            this.skillsGroup.ShowText = true;
            this.skillsGroup.Size = new System.Drawing.Size(252, 109);
            this.skillsGroup.TabIndex = 23;
            this.skillsGroup.Tag = "";
            // 
            // skillsCheckedList
            // 
            this.skillsCheckedList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.skillsCheckedList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skillsCheckedList.CheckOnClick = true;
            this.skillsCheckedList.ForeColor = System.Drawing.Color.White;
            this.skillsCheckedList.FormattingEnabled = true;
            this.skillsCheckedList.Location = new System.Drawing.Point(13, 14);
            this.skillsCheckedList.Name = "skillsCheckedList";
            this.skillsCheckedList.Size = new System.Drawing.Size(224, 80);
            this.skillsCheckedList.TabIndex = 9;
            this.skillsCheckedList.ThreeDCheckBoxes = true;
            // 
            // deadlineLabel
            // 
            this.deadlineLabel.AutoSize = true;
            this.deadlineLabel.BackColor = System.Drawing.Color.Transparent;
            this.deadlineLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.deadlineLabel.ForeColor = System.Drawing.Color.White;
            this.deadlineLabel.Location = new System.Drawing.Point(473, 469);
            this.deadlineLabel.Name = "deadlineLabel";
            this.deadlineLabel.Size = new System.Drawing.Size(78, 21);
            this.deadlineLabel.TabIndex = 22;
            this.deadlineLabel.Text = "Deadline :";
            // 
            // applicantNameLabel
            // 
            this.applicantNameLabel.AutoSize = true;
            this.applicantNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.applicantNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.applicantNameLabel.ForeColor = System.Drawing.Color.White;
            this.applicantNameLabel.Location = new System.Drawing.Point(425, 522);
            this.applicantNameLabel.Name = "applicantNameLabel";
            this.applicantNameLabel.Size = new System.Drawing.Size(124, 21);
            this.applicantNameLabel.TabIndex = 22;
            this.applicantNameLabel.Text = "Applicant Name:";
            this.applicantNameLabel.Visible = false;
            // 
            // applicationsLabel
            // 
            this.applicationsLabel.AutoSize = true;
            this.applicationsLabel.BackColor = System.Drawing.Color.Transparent;
            this.applicationsLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.applicationsLabel.ForeColor = System.Drawing.Color.White;
            this.applicationsLabel.Location = new System.Drawing.Point(448, 431);
            this.applicationsLabel.Name = "applicationsLabel";
            this.applicationsLabel.Size = new System.Drawing.Size(102, 21);
            this.applicationsLabel.TabIndex = 22;
            this.applicationsLabel.Text = "Applications :";
            // 
            // flatLabel3
            // 
            this.flatLabel3.AutoSize = true;
            this.flatLabel3.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatLabel3.ForeColor = System.Drawing.Color.White;
            this.flatLabel3.Location = new System.Drawing.Point(473, 396);
            this.flatLabel3.Name = "flatLabel3";
            this.flatLabel3.Size = new System.Drawing.Size(76, 21);
            this.flatLabel3.TabIndex = 22;
            this.flatLabel3.Text = "Location :";
            // 
            // flatLabel2
            // 
            this.flatLabel2.AutoSize = true;
            this.flatLabel2.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatLabel2.ForeColor = System.Drawing.Color.White;
            this.flatLabel2.Location = new System.Drawing.Point(453, 269);
            this.flatLabel2.Name = "flatLabel2";
            this.flatLabel2.Size = new System.Drawing.Size(96, 21);
            this.flatLabel2.TabIndex = 22;
            this.flatLabel2.Text = "Description :";
            // 
            // flatLabel1
            // 
            this.flatLabel1.AutoSize = true;
            this.flatLabel1.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatLabel1.ForeColor = System.Drawing.Color.White;
            this.flatLabel1.Location = new System.Drawing.Point(489, 134);
            this.flatLabel1.Name = "flatLabel1";
            this.flatLabel1.Size = new System.Drawing.Size(60, 21);
            this.flatLabel1.TabIndex = 22;
            this.flatLabel1.Text = "Salary :";
            // 
            // jobTitleLabel
            // 
            this.jobTitleLabel.AutoSize = true;
            this.jobTitleLabel.BackColor = System.Drawing.Color.Transparent;
            this.jobTitleLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.jobTitleLabel.ForeColor = System.Drawing.Color.White;
            this.jobTitleLabel.Location = new System.Drawing.Point(475, 98);
            this.jobTitleLabel.Name = "jobTitleLabel";
            this.jobTitleLabel.Size = new System.Drawing.Size(74, 21);
            this.jobTitleLabel.TabIndex = 22;
            this.jobTitleLabel.Text = "Job Title :";
            // 
            // companyNameLabel
            // 
            this.companyNameLabel.AutoSize = true;
            this.companyNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.companyNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.companyNameLabel.ForeColor = System.Drawing.Color.White;
            this.companyNameLabel.Location = new System.Drawing.Point(419, 63);
            this.companyNameLabel.Name = "companyNameLabel";
            this.companyNameLabel.Size = new System.Drawing.Size(130, 21);
            this.companyNameLabel.TabIndex = 22;
            this.companyNameLabel.Text = "Company Name :";
            // 
            // applicantNameInput
            // 
            this.applicantNameInput.BackColor = System.Drawing.Color.Transparent;
            this.applicantNameInput.FocusOnHover = false;
            this.applicantNameInput.Location = new System.Drawing.Point(555, 520);
            this.applicantNameInput.MaxLength = 32767;
            this.applicantNameInput.Multiline = false;
            this.applicantNameInput.Name = "applicantNameInput";
            this.applicantNameInput.ReadOnly = false;
            this.applicantNameInput.Size = new System.Drawing.Size(161, 29);
            this.applicantNameInput.TabIndex = 21;
            this.applicantNameInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.applicantNameInput.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.applicantNameInput.UseSystemPasswordChar = false;
            this.applicantNameInput.Visible = false;
            // 
            // applicationsInput
            // 
            this.applicationsInput.BackColor = System.Drawing.Color.Transparent;
            this.applicationsInput.Enabled = false;
            this.applicationsInput.FocusOnHover = false;
            this.applicationsInput.Location = new System.Drawing.Point(555, 428);
            this.applicationsInput.MaxLength = 32767;
            this.applicationsInput.Multiline = false;
            this.applicationsInput.Name = "applicationsInput";
            this.applicationsInput.ReadOnly = false;
            this.applicationsInput.Size = new System.Drawing.Size(233, 29);
            this.applicationsInput.TabIndex = 21;
            this.applicationsInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.applicationsInput.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.applicationsInput.UseSystemPasswordChar = false;
            // 
            // locationInput
            // 
            this.locationInput.BackColor = System.Drawing.Color.Transparent;
            this.locationInput.FocusOnHover = false;
            this.locationInput.Location = new System.Drawing.Point(555, 393);
            this.locationInput.MaxLength = 32767;
            this.locationInput.Multiline = false;
            this.locationInput.Name = "locationInput";
            this.locationInput.ReadOnly = false;
            this.locationInput.Size = new System.Drawing.Size(233, 29);
            this.locationInput.TabIndex = 21;
            this.locationInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.locationInput.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.locationInput.UseSystemPasswordChar = false;
            // 
            // descriptionInput
            // 
            this.descriptionInput.BackColor = System.Drawing.Color.Transparent;
            this.descriptionInput.FocusOnHover = false;
            this.descriptionInput.Location = new System.Drawing.Point(555, 264);
            this.descriptionInput.MaxLength = 32767;
            this.descriptionInput.Multiline = true;
            this.descriptionInput.Name = "descriptionInput";
            this.descriptionInput.ReadOnly = false;
            this.descriptionInput.Size = new System.Drawing.Size(233, 123);
            this.descriptionInput.TabIndex = 21;
            this.descriptionInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.descriptionInput.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.descriptionInput.UseSystemPasswordChar = false;
            // 
            // salaryInput
            // 
            this.salaryInput.BackColor = System.Drawing.Color.Transparent;
            this.salaryInput.FocusOnHover = false;
            this.salaryInput.Location = new System.Drawing.Point(555, 130);
            this.salaryInput.MaxLength = 32767;
            this.salaryInput.Multiline = false;
            this.salaryInput.Name = "salaryInput";
            this.salaryInput.ReadOnly = false;
            this.salaryInput.Size = new System.Drawing.Size(233, 29);
            this.salaryInput.TabIndex = 21;
            this.salaryInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.salaryInput.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.salaryInput.UseSystemPasswordChar = false;
            // 
            // jobTitleInput
            // 
            this.jobTitleInput.BackColor = System.Drawing.Color.Transparent;
            this.jobTitleInput.FocusOnHover = false;
            this.jobTitleInput.Location = new System.Drawing.Point(555, 95);
            this.jobTitleInput.MaxLength = 32767;
            this.jobTitleInput.Multiline = false;
            this.jobTitleInput.Name = "jobTitleInput";
            this.jobTitleInput.ReadOnly = false;
            this.jobTitleInput.Size = new System.Drawing.Size(233, 29);
            this.jobTitleInput.TabIndex = 21;
            this.jobTitleInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.jobTitleInput.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.jobTitleInput.UseSystemPasswordChar = false;
            // 
            // companyNameInput
            // 
            this.companyNameInput.BackColor = System.Drawing.Color.Transparent;
            this.companyNameInput.Enabled = false;
            this.companyNameInput.FocusOnHover = false;
            this.companyNameInput.Location = new System.Drawing.Point(555, 60);
            this.companyNameInput.MaxLength = 32767;
            this.companyNameInput.Multiline = false;
            this.companyNameInput.Name = "companyNameInput";
            this.companyNameInput.ReadOnly = false;
            this.companyNameInput.Size = new System.Drawing.Size(233, 29);
            this.companyNameInput.TabIndex = 21;
            this.companyNameInput.Text = "companyName";
            this.companyNameInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.companyNameInput.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.companyNameInput.UseSystemPasswordChar = false;
            // 
            // hireButton
            // 
            this.hireButton.BackColor = System.Drawing.Color.Transparent;
            this.hireButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(138)))), ((int)(((byte)(168)))));
            this.hireButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.hireButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.hireButton.Location = new System.Drawing.Point(722, 520);
            this.hireButton.Name = "hireButton";
            this.hireButton.Rounded = false;
            this.hireButton.Size = new System.Drawing.Size(66, 32);
            this.hireButton.TabIndex = 20;
            this.hireButton.Text = "Hire";
            this.hireButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.hireButton.Visible = false;
            this.hireButton.Click += new System.EventHandler(this.hireButton_Click);
            // 
            // saveAdvertButton
            // 
            this.saveAdvertButton.BackColor = System.Drawing.Color.Transparent;
            this.saveAdvertButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(138)))), ((int)(((byte)(168)))));
            this.saveAdvertButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveAdvertButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.saveAdvertButton.Location = new System.Drawing.Point(653, 558);
            this.saveAdvertButton.Name = "saveAdvertButton";
            this.saveAdvertButton.Rounded = false;
            this.saveAdvertButton.Size = new System.Drawing.Size(135, 32);
            this.saveAdvertButton.TabIndex = 20;
            this.saveAdvertButton.Text = "Create Advert";
            this.saveAdvertButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.saveAdvertButton.Visible = false;
            this.saveAdvertButton.Click += new System.EventHandler(this.saveAdvertButton_Click);
            // 
            // deleteAdvertButton
            // 
            this.deleteAdvertButton.BackColor = System.Drawing.Color.Transparent;
            this.deleteAdvertButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(138)))), ((int)(((byte)(168)))));
            this.deleteAdvertButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteAdvertButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.deleteAdvertButton.Location = new System.Drawing.Point(493, 558);
            this.deleteAdvertButton.Name = "deleteAdvertButton";
            this.deleteAdvertButton.Rounded = false;
            this.deleteAdvertButton.Size = new System.Drawing.Size(135, 32);
            this.deleteAdvertButton.TabIndex = 20;
            this.deleteAdvertButton.Text = "Delete Advert";
            this.deleteAdvertButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.deleteAdvertButton.Visible = false;
            this.deleteAdvertButton.Click += new System.EventHandler(this.deleteAdvertButton_Click);
            // 
            // createAdvertButton
            // 
            this.createAdvertButton.BackColor = System.Drawing.Color.Transparent;
            this.createAdvertButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(138)))), ((int)(((byte)(168)))));
            this.createAdvertButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.createAdvertButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.createAdvertButton.Location = new System.Drawing.Point(70, 68);
            this.createAdvertButton.Name = "createAdvertButton";
            this.createAdvertButton.Rounded = false;
            this.createAdvertButton.Size = new System.Drawing.Size(162, 32);
            this.createAdvertButton.TabIndex = 20;
            this.createAdvertButton.Text = "Create New Advert";
            this.createAdvertButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.createAdvertButton.Click += new System.EventHandler(this.createAdvertButton_Click);
            // 
            // jobAdvertCountLabel
            // 
            this.jobAdvertCountLabel.AutoSize = true;
            this.jobAdvertCountLabel.BackColor = System.Drawing.Color.Transparent;
            this.jobAdvertCountLabel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.jobAdvertCountLabel.ForeColor = System.Drawing.Color.White;
            this.jobAdvertCountLabel.Location = new System.Drawing.Point(12, 109);
            this.jobAdvertCountLabel.Name = "jobAdvertCountLabel";
            this.jobAdvertCountLabel.Size = new System.Drawing.Size(102, 13);
            this.jobAdvertCountLabel.TabIndex = 19;
            this.jobAdvertCountLabel.Text = "Job Advert Count: ";
            // 
            // jobListPanel
            // 
            this.jobListPanel.AutoScroll = true;
            this.jobListPanel.AutoSize = true;
            this.jobListPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(80)))), ((int)(((byte)(83)))));
            this.jobListPanel.ColumnCount = 1;
            this.jobListPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.jobListPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.jobListPanel.ForeColor = System.Drawing.Color.White;
            this.jobListPanel.Location = new System.Drawing.Point(15, 125);
            this.jobListPanel.MaximumSize = new System.Drawing.Size(450, 367);
            this.jobListPanel.MinimumSize = new System.Drawing.Size(0, 30);
            this.jobListPanel.Name = "jobListPanel";
            this.jobListPanel.RowCount = 1;
            this.jobListPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.jobListPanel.Size = new System.Drawing.Size(350, 30);
            this.jobListPanel.TabIndex = 18;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.welcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.welcomeLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.White;
            this.welcomeLabel.Location = new System.Drawing.Point(387, 9);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.welcomeLabel.Size = new System.Drawing.Size(305, 32);
            this.welcomeLabel.TabIndex = 15;
            this.welcomeLabel.Text = "Welcome Guest!";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(138)))), ((int)(((byte)(168)))));
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.backButton.Location = new System.Drawing.Point(12, 60);
            this.backButton.Name = "backButton";
            this.backButton.Rounded = false;
            this.backButton.Size = new System.Drawing.Size(40, 40);
            this.backButton.TabIndex = 3;
            this.backButton.Text = "◀";
            this.backButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // flatMini1
            // 
            this.flatMini1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatMini1.BackColor = System.Drawing.Color.White;
            this.flatMini1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.flatMini1.Font = new System.Drawing.Font("Marlett", 12F);
            this.flatMini1.Location = new System.Drawing.Point(746, 12);
            this.flatMini1.Name = "flatMini1";
            this.flatMini1.Size = new System.Drawing.Size(18, 18);
            this.flatMini1.TabIndex = 1;
            this.flatMini1.Text = "flatMini1";
            this.flatMini1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // flatClose1
            // 
            this.flatClose1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatClose1.BackColor = System.Drawing.Color.White;
            this.flatClose1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.flatClose1.Font = new System.Drawing.Font("Marlett", 10F);
            this.flatClose1.Location = new System.Drawing.Point(770, 13);
            this.flatClose1.Name = "flatClose1";
            this.flatClose1.Size = new System.Drawing.Size(18, 18);
            this.flatClose1.TabIndex = 0;
            this.flatClose1.Text = "flatClose1";
            this.flatClose1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // recommendButton
            // 
            this.recommendButton.BackColor = System.Drawing.Color.Transparent;
            this.recommendButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(138)))), ((int)(((byte)(168)))));
            this.recommendButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.recommendButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.recommendButton.Location = new System.Drawing.Point(238, 68);
            this.recommendButton.Name = "recommendButton";
            this.recommendButton.Rounded = false;
            this.recommendButton.Size = new System.Drawing.Size(175, 32);
            this.recommendButton.TabIndex = 27;
            this.recommendButton.Text = "Recommend Someone";
            this.recommendButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.recommendButton.Visible = false;
            this.recommendButton.Click += new System.EventHandler(this.recommendButton_Click);
            // 
            // FindEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 650);
            this.Controls.Add(this.formSkin1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FindEmployee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FindEmployee";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.formSkin1.ResumeLayout(false);
            this.formSkin1.PerformLayout();
            this.skillsGroup.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private FlatUI.FormSkin formSkin1;
        private FlatUI.FlatMini flatMini1;
        private FlatUI.FlatClose flatClose1;
        private FlatUI.FlatButton backButton;
        private FlatUI.FlatLabel welcomeLabel;
        private FlatUI.FlatLabel jobAdvertCountLabel;
        private System.Windows.Forms.TableLayoutPanel jobListPanel;
        private FlatUI.FlatLabel flatLabel1;
        private FlatUI.FlatLabel jobTitleLabel;
        private FlatUI.FlatLabel companyNameLabel;
        private FlatUI.FlatTextBox salaryInput;
        private FlatUI.FlatTextBox jobTitleInput;
        private FlatUI.FlatTextBox companyNameInput;
        private FlatUI.FlatButton createAdvertButton;
        private System.Windows.Forms.DateTimePicker deadlineInput;
        private FlatUI.FlatLabel skillsLabel;
        private FlatUI.FlatGroupBox skillsGroup;
        private System.Windows.Forms.CheckedListBox skillsCheckedList;
        private FlatUI.FlatLabel deadlineLabel;
        private FlatUI.FlatLabel flatLabel3;
        private FlatUI.FlatLabel flatLabel2;
        private FlatUI.FlatTextBox locationInput;
        private FlatUI.FlatTextBox descriptionInput;
        private FlatUI.FlatButton deleteAdvertButton;
        private FlatUI.FlatButton saveAdvertButton;
        private FlatUI.FlatAlertBox savedSuccesfullyAlert;
        private FlatUI.FlatLabel applicantNameLabel;
        private FlatUI.FlatLabel applicationsLabel;
        private FlatUI.FlatTextBox applicantNameInput;
        private FlatUI.FlatTextBox applicationsInput;
        private FlatUI.FlatButton hireButton;
        private FlatUI.FlatAlertBox successAlert;
        private FlatUI.FlatAlertBox errorAlert;
        private FlatUI.FlatButton recommendButton;
    }
}
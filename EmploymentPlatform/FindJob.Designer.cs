namespace EmploymentPlatform
{
    partial class FindJob
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            FlatUI.FormSkin formSkin1;
            this.fetchFromHeapButton = new FlatUI.FlatButton();
            this.N_numberOfAdvertsToShow = new FlatUI.FlatNumeric();
            this.N_label = new FlatUI.FlatLabel();
            this.selectCategoryLabel = new FlatUI.FlatLabel();
            this.selectCategory = new FlatUI.FlatComboBox();
            this.signupButton = new FlatUI.FlatButton();
            this.jobAdvertCountLabel = new FlatUI.FlatLabel();
            this.signUpAlert = new FlatUI.FlatAlertBox();
            this.applicantExistsAlert = new FlatUI.FlatAlertBox();
            this.applicationSentAlert = new FlatUI.FlatAlertBox();
            this.welcomeLabel = new FlatUI.FlatLabel();
            this.applyButton = new FlatUI.FlatButton();
            this.filterButton = new FlatUI.FlatButton();
            this.flatLabel4 = new FlatUI.FlatLabel();
            this.flatLabel3 = new FlatUI.FlatLabel();
            this.filterCompany = new FlatUI.FlatTextBox();
            this.flatLabel2 = new FlatUI.FlatLabel();
            this.flatLabel1 = new FlatUI.FlatLabel();
            this.filterSalaryMax = new FlatUI.FlatNumeric();
            this.filterSalaryMin = new FlatUI.FlatNumeric();
            this.filterKeyword = new FlatUI.FlatTextBox();
            this.jobListPanel = new System.Windows.Forms.TableLayoutPanel();
            this.jobInfo = new System.Windows.Forms.RichTextBox();
            this.backButton = new FlatUI.FlatButton();
            this.flatClose1 = new FlatUI.FlatClose();
            this.flatMini1 = new FlatUI.FlatMini();
            formSkin1 = new FlatUI.FormSkin();
            formSkin1.SuspendLayout();
            this.SuspendLayout();
            // 
            // formSkin1
            // 
            formSkin1.BackColor = System.Drawing.Color.White;
            formSkin1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            formSkin1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            formSkin1.Controls.Add(this.fetchFromHeapButton);
            formSkin1.Controls.Add(this.N_numberOfAdvertsToShow);
            formSkin1.Controls.Add(this.N_label);
            formSkin1.Controls.Add(this.selectCategoryLabel);
            formSkin1.Controls.Add(this.selectCategory);
            formSkin1.Controls.Add(this.signupButton);
            formSkin1.Controls.Add(this.jobAdvertCountLabel);
            formSkin1.Controls.Add(this.signUpAlert);
            formSkin1.Controls.Add(this.applicantExistsAlert);
            formSkin1.Controls.Add(this.applicationSentAlert);
            formSkin1.Controls.Add(this.welcomeLabel);
            formSkin1.Controls.Add(this.applyButton);
            formSkin1.Controls.Add(this.filterButton);
            formSkin1.Controls.Add(this.flatLabel4);
            formSkin1.Controls.Add(this.flatLabel3);
            formSkin1.Controls.Add(this.filterCompany);
            formSkin1.Controls.Add(this.flatLabel2);
            formSkin1.Controls.Add(this.flatLabel1);
            formSkin1.Controls.Add(this.filterSalaryMax);
            formSkin1.Controls.Add(this.filterSalaryMin);
            formSkin1.Controls.Add(this.filterKeyword);
            formSkin1.Controls.Add(this.jobListPanel);
            formSkin1.Controls.Add(this.jobInfo);
            formSkin1.Controls.Add(this.backButton);
            formSkin1.Controls.Add(this.flatClose1);
            formSkin1.Controls.Add(this.flatMini1);
            formSkin1.Dock = System.Windows.Forms.DockStyle.Fill;
            formSkin1.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(138)))), ((int)(((byte)(168)))));
            formSkin1.Font = new System.Drawing.Font("Segoe UI", 12F);
            formSkin1.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            formSkin1.HeaderMaximize = false;
            formSkin1.Location = new System.Drawing.Point(0, 0);
            formSkin1.Name = "formSkin1";
            formSkin1.Size = new System.Drawing.Size(800, 650);
            formSkin1.TabIndex = 0;
            formSkin1.Text = "Employment Platform - Find Job";
            // 
            // fetchFromHeapButton
            // 
            this.fetchFromHeapButton.BackColor = System.Drawing.Color.Transparent;
            this.fetchFromHeapButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(138)))), ((int)(((byte)(168)))));
            this.fetchFromHeapButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fetchFromHeapButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.fetchFromHeapButton.Location = new System.Drawing.Point(534, 112);
            this.fetchFromHeapButton.Name = "fetchFromHeapButton";
            this.fetchFromHeapButton.Rounded = false;
            this.fetchFromHeapButton.Size = new System.Drawing.Size(143, 30);
            this.fetchFromHeapButton.TabIndex = 21;
            this.fetchFromHeapButton.Text = "Fetch from Heap";
            this.fetchFromHeapButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.fetchFromHeapButton.Click += new System.EventHandler(this.fetchFromHeapButton_Click);
            // 
            // N_numberOfAdvertsToShow
            // 
            this.N_numberOfAdvertsToShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.N_numberOfAdvertsToShow.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.N_numberOfAdvertsToShow.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(138)))), ((int)(((byte)(168)))));
            this.N_numberOfAdvertsToShow.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.N_numberOfAdvertsToShow.ForeColor = System.Drawing.Color.White;
            this.N_numberOfAdvertsToShow.Location = new System.Drawing.Point(437, 112);
            this.N_numberOfAdvertsToShow.Maximum = ((long)(999));
            this.N_numberOfAdvertsToShow.Minimum = ((long)(1));
            this.N_numberOfAdvertsToShow.Name = "N_numberOfAdvertsToShow";
            this.N_numberOfAdvertsToShow.Size = new System.Drawing.Size(75, 30);
            this.N_numberOfAdvertsToShow.TabIndex = 20;
            this.N_numberOfAdvertsToShow.Text = "N";
            this.N_numberOfAdvertsToShow.Value = ((long)(1));
            // 
            // N_label
            // 
            this.N_label.AutoSize = true;
            this.N_label.BackColor = System.Drawing.Color.Transparent;
            this.N_label.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.N_label.ForeColor = System.Drawing.Color.White;
            this.N_label.Location = new System.Drawing.Point(402, 118);
            this.N_label.Name = "N_label";
            this.N_label.Size = new System.Drawing.Size(30, 19);
            this.N_label.TabIndex = 19;
            this.N_label.Text = "N : ";
            // 
            // selectCategoryLabel
            // 
            this.selectCategoryLabel.AutoSize = true;
            this.selectCategoryLabel.BackColor = System.Drawing.Color.Transparent;
            this.selectCategoryLabel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.selectCategoryLabel.ForeColor = System.Drawing.Color.White;
            this.selectCategoryLabel.Location = new System.Drawing.Point(69, 120);
            this.selectCategoryLabel.Name = "selectCategoryLabel";
            this.selectCategoryLabel.Size = new System.Drawing.Size(72, 19);
            this.selectCategoryLabel.TabIndex = 19;
            this.selectCategoryLabel.Text = "Category :";
            // 
            // selectCategory
            // 
            this.selectCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.selectCategory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.selectCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.selectCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectCategory.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.selectCategory.ForeColor = System.Drawing.Color.White;
            this.selectCategory.FormattingEnabled = true;
            this.selectCategory.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.selectCategory.ItemHeight = 18;
            this.selectCategory.Location = new System.Drawing.Point(149, 118);
            this.selectCategory.Name = "selectCategory";
            this.selectCategory.Size = new System.Drawing.Size(232, 24);
            this.selectCategory.TabIndex = 18;
            // 
            // signupButton
            // 
            this.signupButton.BackColor = System.Drawing.Color.Transparent;
            this.signupButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(138)))), ((int)(((byte)(168)))));
            this.signupButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signupButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.signupButton.Location = new System.Drawing.Point(624, 7);
            this.signupButton.Name = "signupButton";
            this.signupButton.Rounded = false;
            this.signupButton.Size = new System.Drawing.Size(116, 32);
            this.signupButton.TabIndex = 17;
            this.signupButton.Text = "Sign Up";
            this.signupButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.signupButton.Click += new System.EventHandler(this.signupButton_Click);
            // 
            // jobAdvertCountLabel
            // 
            this.jobAdvertCountLabel.AutoSize = true;
            this.jobAdvertCountLabel.BackColor = System.Drawing.Color.Transparent;
            this.jobAdvertCountLabel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.jobAdvertCountLabel.ForeColor = System.Drawing.Color.White;
            this.jobAdvertCountLabel.Location = new System.Drawing.Point(12, 169);
            this.jobAdvertCountLabel.Name = "jobAdvertCountLabel";
            this.jobAdvertCountLabel.Size = new System.Drawing.Size(102, 13);
            this.jobAdvertCountLabel.TabIndex = 16;
            this.jobAdvertCountLabel.Text = "Job Advert Count: ";
            // 
            // signUpAlert
            // 
            this.signUpAlert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.signUpAlert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signUpAlert.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.signUpAlert.kind = FlatUI.FlatAlertBox._Kind.Error;
            this.signUpAlert.Location = new System.Drawing.Point(15, 596);
            this.signUpAlert.Name = "signUpAlert";
            this.signUpAlert.Size = new System.Drawing.Size(775, 42);
            this.signUpAlert.TabIndex = 15;
            this.signUpAlert.Text = "You need to sign up to apply a job!";
            this.signUpAlert.Visible = false;
            // 
            // applicantExistsAlert
            // 
            this.applicantExistsAlert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.applicantExistsAlert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.applicantExistsAlert.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.applicantExistsAlert.kind = FlatUI.FlatAlertBox._Kind.Error;
            this.applicantExistsAlert.Location = new System.Drawing.Point(15, 596);
            this.applicantExistsAlert.Name = "applicantExistsAlert";
            this.applicantExistsAlert.Size = new System.Drawing.Size(775, 42);
            this.applicantExistsAlert.TabIndex = 15;
            this.applicantExistsAlert.Text = "You have already applied to this job. Wait for response please.";
            this.applicantExistsAlert.Visible = false;
            // 
            // applicationSentAlert
            // 
            this.applicationSentAlert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.applicationSentAlert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.applicationSentAlert.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.applicationSentAlert.kind = FlatUI.FlatAlertBox._Kind.Success;
            this.applicationSentAlert.Location = new System.Drawing.Point(15, 596);
            this.applicationSentAlert.Name = "applicationSentAlert";
            this.applicationSentAlert.Size = new System.Drawing.Size(775, 42);
            this.applicationSentAlert.TabIndex = 15;
            this.applicationSentAlert.Text = "Your application sent succesfully!";
            this.applicationSentAlert.Visible = false;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.welcomeLabel.BackColor = System.Drawing.Color.Transparent;
            this.welcomeLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.White;
            this.welcomeLabel.Location = new System.Drawing.Point(313, 7);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.welcomeLabel.Size = new System.Drawing.Size(305, 32);
            this.welcomeLabel.TabIndex = 14;
            this.welcomeLabel.Text = "Welcome Guest!";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // applyButton
            // 
            this.applyButton.BackColor = System.Drawing.Color.Transparent;
            this.applyButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.applyButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.applyButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.applyButton.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.applyButton.Location = new System.Drawing.Point(510, 558);
            this.applyButton.Name = "applyButton";
            this.applyButton.Rounded = false;
            this.applyButton.Size = new System.Drawing.Size(181, 32);
            this.applyButton.TabIndex = 13;
            this.applyButton.Text = "Apply for this Job!";
            this.applyButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.applyButton.Visible = false;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // filterButton
            // 
            this.filterButton.BackColor = System.Drawing.Color.Transparent;
            this.filterButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(138)))), ((int)(((byte)(168)))));
            this.filterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filterButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.filterButton.Location = new System.Drawing.Point(721, 57);
            this.filterButton.Name = "filterButton";
            this.filterButton.Rounded = false;
            this.filterButton.Size = new System.Drawing.Size(67, 32);
            this.filterButton.TabIndex = 12;
            this.filterButton.Text = "Filter";
            this.filterButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.filterButton.Click += new System.EventHandler(this.filterButton_Click);
            // 
            // flatLabel4
            // 
            this.flatLabel4.AutoSize = true;
            this.flatLabel4.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.flatLabel4.ForeColor = System.Drawing.Color.White;
            this.flatLabel4.Location = new System.Drawing.Point(69, 65);
            this.flatLabel4.Name = "flatLabel4";
            this.flatLabel4.Size = new System.Drawing.Size(74, 21);
            this.flatLabel4.TabIndex = 11;
            this.flatLabel4.Text = "Keyword:";
            // 
            // flatLabel3
            // 
            this.flatLabel3.AutoSize = true;
            this.flatLabel3.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.flatLabel3.ForeColor = System.Drawing.Color.White;
            this.flatLabel3.Location = new System.Drawing.Point(273, 65);
            this.flatLabel3.Name = "flatLabel3";
            this.flatLabel3.Size = new System.Drawing.Size(56, 21);
            this.flatLabel3.TabIndex = 10;
            this.flatLabel3.Text = "Salary:";
            // 
            // filterCompany
            // 
            this.filterCompany.BackColor = System.Drawing.Color.Transparent;
            this.filterCompany.FocusOnHover = false;
            this.filterCompany.Location = new System.Drawing.Point(616, 59);
            this.filterCompany.MaxLength = 32767;
            this.filterCompany.Multiline = false;
            this.filterCompany.Name = "filterCompany";
            this.filterCompany.ReadOnly = false;
            this.filterCompany.Size = new System.Drawing.Size(75, 29);
            this.filterCompany.TabIndex = 9;
            this.filterCompany.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.filterCompany.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.filterCompany.UseSystemPasswordChar = false;
            // 
            // flatLabel2
            // 
            this.flatLabel2.AutoSize = true;
            this.flatLabel2.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.flatLabel2.ForeColor = System.Drawing.Color.White;
            this.flatLabel2.Location = new System.Drawing.Point(530, 62);
            this.flatLabel2.Name = "flatLabel2";
            this.flatLabel2.Size = new System.Drawing.Size(80, 21);
            this.flatLabel2.TabIndex = 8;
            this.flatLabel2.Text = "Company:";
            // 
            // flatLabel1
            // 
            this.flatLabel1.AutoSize = true;
            this.flatLabel1.BackColor = System.Drawing.Color.Transparent;
            this.flatLabel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.flatLabel1.ForeColor = System.Drawing.Color.White;
            this.flatLabel1.Location = new System.Drawing.Point(416, 64);
            this.flatLabel1.Name = "flatLabel1";
            this.flatLabel1.Size = new System.Drawing.Size(16, 21);
            this.flatLabel1.TabIndex = 7;
            this.flatLabel1.Text = "-";
            // 
            // filterSalaryMax
            // 
            this.filterSalaryMax.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.filterSalaryMax.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.filterSalaryMax.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(138)))), ((int)(((byte)(168)))));
            this.filterSalaryMax.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.filterSalaryMax.ForeColor = System.Drawing.Color.White;
            this.filterSalaryMax.Location = new System.Drawing.Point(432, 59);
            this.filterSalaryMax.Maximum = ((long)(999999));
            this.filterSalaryMax.Minimum = ((long)(0));
            this.filterSalaryMax.Name = "filterSalaryMax";
            this.filterSalaryMax.Size = new System.Drawing.Size(80, 30);
            this.filterSalaryMax.TabIndex = 6;
            this.filterSalaryMax.Value = ((long)(999999));
            // 
            // filterSalaryMin
            // 
            this.filterSalaryMin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.filterSalaryMin.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.filterSalaryMin.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(138)))), ((int)(((byte)(168)))));
            this.filterSalaryMin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.filterSalaryMin.ForeColor = System.Drawing.Color.White;
            this.filterSalaryMin.Location = new System.Drawing.Point(335, 59);
            this.filterSalaryMin.Maximum = ((long)(999999));
            this.filterSalaryMin.Minimum = ((long)(0));
            this.filterSalaryMin.Name = "filterSalaryMin";
            this.filterSalaryMin.Size = new System.Drawing.Size(80, 30);
            this.filterSalaryMin.TabIndex = 6;
            this.filterSalaryMin.Value = ((long)(0));
            // 
            // filterKeyword
            // 
            this.filterKeyword.BackColor = System.Drawing.Color.Transparent;
            this.filterKeyword.FocusOnHover = false;
            this.filterKeyword.Location = new System.Drawing.Point(149, 62);
            this.filterKeyword.MaxLength = 32767;
            this.filterKeyword.Multiline = false;
            this.filterKeyword.Name = "filterKeyword";
            this.filterKeyword.ReadOnly = false;
            this.filterKeyword.Size = new System.Drawing.Size(99, 29);
            this.filterKeyword.TabIndex = 5;
            this.filterKeyword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.filterKeyword.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.filterKeyword.UseSystemPasswordChar = false;
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
            this.jobListPanel.Location = new System.Drawing.Point(15, 185);
            this.jobListPanel.MaximumSize = new System.Drawing.Size(450, 367);
            this.jobListPanel.MinimumSize = new System.Drawing.Size(0, 30);
            this.jobListPanel.Name = "jobListPanel";
            this.jobListPanel.RowCount = 1;
            this.jobListPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.jobListPanel.Size = new System.Drawing.Size(350, 30);
            this.jobListPanel.TabIndex = 4;
            // 
            // jobInfo
            // 
            this.jobInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(80)))), ((int)(((byte)(83)))));
            this.jobInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.jobInfo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.jobInfo.ForeColor = System.Drawing.Color.White;
            this.jobInfo.Location = new System.Drawing.Point(389, 185);
            this.jobInfo.Name = "jobInfo";
            this.jobInfo.ReadOnly = true;
            this.jobInfo.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.jobInfo.Size = new System.Drawing.Size(399, 367);
            this.jobInfo.TabIndex = 3;
            this.jobInfo.Text = "";
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.Transparent;
            this.backButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(138)))), ((int)(((byte)(168)))));
            this.backButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.backButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.backButton.Location = new System.Drawing.Point(13, 59);
            this.backButton.Name = "backButton";
            this.backButton.Rounded = false;
            this.backButton.Size = new System.Drawing.Size(40, 40);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "◀";
            this.backButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // flatClose1
            // 
            this.flatClose1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flatClose1.BackColor = System.Drawing.Color.White;
            this.flatClose1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.flatClose1.Font = new System.Drawing.Font("Marlett", 10F);
            this.flatClose1.Location = new System.Drawing.Point(770, 12);
            this.flatClose1.Name = "flatClose1";
            this.flatClose1.Size = new System.Drawing.Size(18, 18);
            this.flatClose1.TabIndex = 1;
            this.flatClose1.Text = "flatClose1";
            this.flatClose1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
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
            this.flatMini1.TabIndex = 0;
            this.flatMini1.Text = "flatMini1";
            this.flatMini1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // FindJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 650);
            this.Controls.Add(formSkin1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FindJob";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmploymentPlatformJob";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            formSkin1.ResumeLayout(false);
            formSkin1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private FlatUI.FlatButton backButton;
        private FlatUI.FlatClose flatClose1;
        private FlatUI.FlatMini flatMini1;
        private System.Windows.Forms.RichTextBox jobInfo;
        private System.Windows.Forms.TableLayoutPanel jobListPanel;
        private FlatUI.FlatTextBox filterKeyword;
        private FlatUI.FlatButton filterButton;
        private FlatUI.FlatLabel flatLabel4;
        private FlatUI.FlatLabel flatLabel3;
        private FlatUI.FlatTextBox filterCompany;
        private FlatUI.FlatLabel flatLabel2;
        private FlatUI.FlatLabel flatLabel1;
        private FlatUI.FlatNumeric filterSalaryMax;
        private FlatUI.FlatNumeric filterSalaryMin;
        private FlatUI.FlatButton applyButton;
        private FlatUI.FlatLabel welcomeLabel;
        private FlatUI.FlatAlertBox applicationSentAlert;
        private FlatUI.FlatAlertBox applicantExistsAlert;
        private FlatUI.FlatLabel jobAdvertCountLabel;
        private FlatUI.FlatButton signupButton;
        private FlatUI.FlatAlertBox signUpAlert;
        private FlatUI.FlatButton fetchFromHeapButton;
        private FlatUI.FlatNumeric N_numberOfAdvertsToShow;
        private FlatUI.FlatLabel N_label;
        private FlatUI.FlatLabel selectCategoryLabel;
        private FlatUI.FlatComboBox selectCategory;
    }
}
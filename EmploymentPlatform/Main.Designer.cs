namespace EmploymentPlatform
{
    partial class EmploymentPlatform
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
            this.findJobButton = new FlatUI.FlatButton();
            this.welcomeMainLabel = new FlatUI.FlatLabel();
            this.findEmployeeButton = new FlatUI.FlatButton();
            this.descLabel = new FlatUI.FlatLabel();
            this.MainForm = new FlatUI.FormSkin();
            this.errorAlert = new FlatUI.FlatAlertBox();
            this.successAlert = new FlatUI.FlatAlertBox();
            this.flatMini1 = new FlatUI.FlatMini();
            this.flatClose1 = new FlatUI.FlatClose();
            this.flatGroupBox1 = new FlatUI.FlatGroupBox();
            this.requiredLabel = new FlatUI.FlatLabel();
            this.findEmpLoginButton = new FlatUI.FlatButton();
            this.empPassInput = new System.Windows.Forms.MaskedTextBox();
            this.empPassLabel = new System.Windows.Forms.Label();
            this.companyInput = new FlatUI.FlatTextBox();
            this.companyLabel = new System.Windows.Forms.Label();
            this.empWelcomeLabel = new System.Windows.Forms.Label();
            this.jobGroupBox = new FlatUI.FlatGroupBox();
            this.optionalLabel = new FlatUI.FlatLabel();
            this.findJobLoginButton = new FlatUI.FlatButton();
            this.jobPassInput = new System.Windows.Forms.MaskedTextBox();
            this.jobPasswordLabel = new System.Windows.Forms.Label();
            this.jobEmailInput = new FlatUI.FlatTextBox();
            this.jobEmailLabel = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.MainForm.SuspendLayout();
            this.flatGroupBox1.SuspendLayout();
            this.jobGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // findJobButton
            // 
            this.findJobButton.BackColor = System.Drawing.Color.Transparent;
            this.findJobButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.findJobButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(138)))), ((int)(((byte)(168)))));
            this.findJobButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.findJobButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.findJobButton.Location = new System.Drawing.Point(122, 233);
            this.findJobButton.Name = "findJobButton";
            this.findJobButton.Rounded = false;
            this.findJobButton.Size = new System.Drawing.Size(150, 50);
            this.findJobButton.TabIndex = 0;
            this.findJobButton.Text = "Find Job";
            this.findJobButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.findJobButton.Click += new System.EventHandler(this.findJobButton_Click);
            // 
            // welcomeMainLabel
            // 
            this.welcomeMainLabel.BackColor = System.Drawing.Color.Transparent;
            this.welcomeMainLabel.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.welcomeMainLabel.ForeColor = System.Drawing.Color.White;
            this.welcomeMainLabel.Location = new System.Drawing.Point(12, 60);
            this.welcomeMainLabel.Name = "welcomeMainLabel";
            this.welcomeMainLabel.Size = new System.Drawing.Size(776, 40);
            this.welcomeMainLabel.TabIndex = 2;
            this.welcomeMainLabel.Text = "Welcome to Employment Platform!";
            this.welcomeMainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // findEmployeeButton
            // 
            this.findEmployeeButton.BackColor = System.Drawing.Color.Transparent;
            this.findEmployeeButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(138)))), ((int)(((byte)(168)))));
            this.findEmployeeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.findEmployeeButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.findEmployeeButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.findEmployeeButton.Location = new System.Drawing.Point(96, 233);
            this.findEmployeeButton.Name = "findEmployeeButton";
            this.findEmployeeButton.Rounded = false;
            this.findEmployeeButton.Size = new System.Drawing.Size(192, 50);
            this.findEmployeeButton.TabIndex = 3;
            this.findEmployeeButton.Text = "Find Employees";
            this.findEmployeeButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.findEmployeeButton.Click += new System.EventHandler(this.findEmployeeButton_Click);
            // 
            // descLabel
            // 
            this.descLabel.BackColor = System.Drawing.Color.Transparent;
            this.descLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.descLabel.ForeColor = System.Drawing.Color.White;
            this.descLabel.Location = new System.Drawing.Point(3, 127);
            this.descLabel.Name = "descLabel";
            this.descLabel.Size = new System.Drawing.Size(785, 37);
            this.descLabel.TabIndex = 4;
            this.descLabel.Text = "What are you looking for?";
            this.descLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            this.MainForm.BackColor = System.Drawing.Color.White;
            this.MainForm.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.MainForm.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(58)))), ((int)(((byte)(60)))));
            this.MainForm.Controls.Add(this.errorAlert);
            this.MainForm.Controls.Add(this.successAlert);
            this.MainForm.Controls.Add(this.flatMini1);
            this.MainForm.Controls.Add(this.flatClose1);
            this.MainForm.Controls.Add(this.descLabel);
            this.MainForm.Controls.Add(this.welcomeMainLabel);
            this.MainForm.Controls.Add(this.flatGroupBox1);
            this.MainForm.Controls.Add(this.jobGroupBox);
            this.MainForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainForm.FlatColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(138)))), ((int)(((byte)(168)))));
            this.MainForm.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.MainForm.HeaderColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.MainForm.HeaderMaximize = false;
            this.MainForm.Location = new System.Drawing.Point(0, 0);
            this.MainForm.Name = "MainForm";
            this.MainForm.Size = new System.Drawing.Size(800, 650);
            this.MainForm.TabIndex = 5;
            this.MainForm.Text = "Employment Platform";
            // 
            // errorAlert
            // 
            this.errorAlert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.errorAlert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.errorAlert.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.errorAlert.kind = FlatUI.FlatAlertBox._Kind.Error;
            this.errorAlert.Location = new System.Drawing.Point(12, 596);
            this.errorAlert.Name = "errorAlert";
            this.errorAlert.Size = new System.Drawing.Size(776, 42);
            this.errorAlert.TabIndex = 14;
            this.errorAlert.Text = "Action failed!";
            this.errorAlert.Visible = false;
            // 
            // successAlert
            // 
            this.successAlert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(70)))), ((int)(((byte)(73)))));
            this.successAlert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.successAlert.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.successAlert.kind = FlatUI.FlatAlertBox._Kind.Success;
            this.successAlert.Location = new System.Drawing.Point(12, 596);
            this.successAlert.Name = "successAlert";
            this.successAlert.Size = new System.Drawing.Size(776, 42);
            this.successAlert.TabIndex = 14;
            this.successAlert.Text = "Action completed successfully!";
            this.successAlert.Visible = false;
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
            this.flatMini1.TabIndex = 7;
            this.flatMini1.Text = "flatMini1";
            this.flatMini1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
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
            this.flatClose1.TabIndex = 5;
            this.flatClose1.Text = "flatClose1";
            this.flatClose1.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            // 
            // flatGroupBox1
            // 
            this.flatGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.flatGroupBox1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(63)))));
            this.flatGroupBox1.Controls.Add(this.requiredLabel);
            this.flatGroupBox1.Controls.Add(this.findEmpLoginButton);
            this.flatGroupBox1.Controls.Add(this.findEmployeeButton);
            this.flatGroupBox1.Controls.Add(this.empPassInput);
            this.flatGroupBox1.Controls.Add(this.empPassLabel);
            this.flatGroupBox1.Controls.Add(this.companyInput);
            this.flatGroupBox1.Controls.Add(this.companyLabel);
            this.flatGroupBox1.Controls.Add(this.empWelcomeLabel);
            this.flatGroupBox1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.flatGroupBox1.Location = new System.Drawing.Point(408, 206);
            this.flatGroupBox1.Name = "flatGroupBox1";
            this.flatGroupBox1.ShowText = true;
            this.flatGroupBox1.Size = new System.Drawing.Size(380, 324);
            this.flatGroupBox1.TabIndex = 15;
            this.flatGroupBox1.Text = "I am looking for employees";
            // 
            // requiredLabel
            // 
            this.requiredLabel.AutoSize = true;
            this.requiredLabel.BackColor = System.Drawing.Color.Transparent;
            this.requiredLabel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.requiredLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.requiredLabel.Location = new System.Drawing.Point(244, 156);
            this.requiredLabel.Name = "requiredLabel";
            this.requiredLabel.Size = new System.Drawing.Size(60, 13);
            this.requiredLabel.TabIndex = 16;
            this.requiredLabel.Text = "(Required)";
            // 
            // findEmpLoginButton
            // 
            this.findEmpLoginButton.BackColor = System.Drawing.Color.Transparent;
            this.findEmpLoginButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(138)))), ((int)(((byte)(168)))));
            this.findEmpLoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.findEmpLoginButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.findEmpLoginButton.Location = new System.Drawing.Point(132, 147);
            this.findEmpLoginButton.Name = "findEmpLoginButton";
            this.findEmpLoginButton.Rounded = false;
            this.findEmpLoginButton.Size = new System.Drawing.Size(106, 32);
            this.findEmpLoginButton.TabIndex = 14;
            this.findEmpLoginButton.Text = "Log In";
            this.findEmpLoginButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.findEmpLoginButton.Click += new System.EventHandler(this.findEmpLoginButton_Click);
            // 
            // empPassInput
            // 
            this.empPassInput.AsciiOnly = true;
            this.empPassInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.empPassInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.empPassInput.ForeColor = System.Drawing.Color.Silver;
            this.empPassInput.Location = new System.Drawing.Point(165, 115);
            this.empPassInput.Name = "empPassInput";
            this.empPassInput.PasswordChar = '*';
            this.empPassInput.Size = new System.Drawing.Size(150, 26);
            this.empPassInput.TabIndex = 11;
            // 
            // empPassLabel
            // 
            this.empPassLabel.AutoSize = true;
            this.empPassLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.empPassLabel.ForeColor = System.Drawing.Color.White;
            this.empPassLabel.Location = new System.Drawing.Point(79, 115);
            this.empPassLabel.Name = "empPassLabel";
            this.empPassLabel.Size = new System.Drawing.Size(77, 20);
            this.empPassLabel.TabIndex = 1;
            this.empPassLabel.Text = "Password :";
            // 
            // companyInput
            // 
            this.companyInput.BackColor = System.Drawing.Color.Transparent;
            this.companyInput.FocusOnHover = false;
            this.companyInput.Location = new System.Drawing.Point(165, 80);
            this.companyInput.MaxLength = 32767;
            this.companyInput.Multiline = false;
            this.companyInput.Name = "companyInput";
            this.companyInput.ReadOnly = false;
            this.companyInput.Size = new System.Drawing.Size(150, 29);
            this.companyInput.TabIndex = 12;
            this.companyInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.companyInput.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.companyInput.UseSystemPasswordChar = false;
            // 
            // companyLabel
            // 
            this.companyLabel.AutoSize = true;
            this.companyLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.companyLabel.ForeColor = System.Drawing.Color.White;
            this.companyLabel.Location = new System.Drawing.Point(40, 85);
            this.companyLabel.Name = "companyLabel";
            this.companyLabel.Size = new System.Drawing.Size(123, 20);
            this.companyLabel.TabIndex = 0;
            this.companyLabel.Text = "Company Name :";
            // 
            // empWelcomeLabel
            // 
            this.empWelcomeLabel.ForeColor = System.Drawing.Color.White;
            this.empWelcomeLabel.Location = new System.Drawing.Point(10, 64);
            this.empWelcomeLabel.Name = "empWelcomeLabel";
            this.empWelcomeLabel.Size = new System.Drawing.Size(356, 38);
            this.empWelcomeLabel.TabIndex = 15;
            this.empWelcomeLabel.Text = "Welcome Guest!";
            this.empWelcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.empWelcomeLabel.Visible = false;
            // 
            // jobGroupBox
            // 
            this.jobGroupBox.BackColor = System.Drawing.Color.Transparent;
            this.jobGroupBox.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(60)))), ((int)(((byte)(63)))));
            this.jobGroupBox.Controls.Add(this.optionalLabel);
            this.jobGroupBox.Controls.Add(this.findJobLoginButton);
            this.jobGroupBox.Controls.Add(this.jobPassInput);
            this.jobGroupBox.Controls.Add(this.jobPasswordLabel);
            this.jobGroupBox.Controls.Add(this.jobEmailInput);
            this.jobGroupBox.Controls.Add(this.jobEmailLabel);
            this.jobGroupBox.Controls.Add(this.findJobButton);
            this.jobGroupBox.Controls.Add(this.welcomeLabel);
            this.jobGroupBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.jobGroupBox.Location = new System.Drawing.Point(12, 206);
            this.jobGroupBox.Name = "jobGroupBox";
            this.jobGroupBox.ShowText = true;
            this.jobGroupBox.Size = new System.Drawing.Size(390, 324);
            this.jobGroupBox.TabIndex = 15;
            this.jobGroupBox.Text = "I am looking for a job";
            // 
            // optionalLabel
            // 
            this.optionalLabel.AutoSize = true;
            this.optionalLabel.BackColor = System.Drawing.Color.Transparent;
            this.optionalLabel.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.optionalLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.optionalLabel.Location = new System.Drawing.Point(257, 156);
            this.optionalLabel.Name = "optionalLabel";
            this.optionalLabel.Size = new System.Drawing.Size(59, 13);
            this.optionalLabel.TabIndex = 16;
            this.optionalLabel.Text = "(Optional)";
            // 
            // findJobLoginButton
            // 
            this.findJobLoginButton.BackColor = System.Drawing.Color.Transparent;
            this.findJobLoginButton.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(138)))), ((int)(((byte)(168)))));
            this.findJobLoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.findJobLoginButton.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.findJobLoginButton.Location = new System.Drawing.Point(145, 147);
            this.findJobLoginButton.Name = "findJobLoginButton";
            this.findJobLoginButton.Rounded = false;
            this.findJobLoginButton.Size = new System.Drawing.Size(106, 32);
            this.findJobLoginButton.TabIndex = 14;
            this.findJobLoginButton.Text = "Log In";
            this.findJobLoginButton.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.findJobLoginButton.Click += new System.EventHandler(this.findJobLoginButton_Click);
            // 
            // jobPassInput
            // 
            this.jobPassInput.AsciiOnly = true;
            this.jobPassInput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(47)))), ((int)(((byte)(49)))));
            this.jobPassInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.jobPassInput.ForeColor = System.Drawing.Color.Silver;
            this.jobPassInput.Location = new System.Drawing.Point(141, 107);
            this.jobPassInput.Name = "jobPassInput";
            this.jobPassInput.PasswordChar = '*';
            this.jobPassInput.Size = new System.Drawing.Size(150, 26);
            this.jobPassInput.TabIndex = 11;
            // 
            // jobPasswordLabel
            // 
            this.jobPasswordLabel.AutoSize = true;
            this.jobPasswordLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.jobPasswordLabel.ForeColor = System.Drawing.Color.White;
            this.jobPasswordLabel.Location = new System.Drawing.Point(55, 107);
            this.jobPasswordLabel.Name = "jobPasswordLabel";
            this.jobPasswordLabel.Size = new System.Drawing.Size(77, 20);
            this.jobPasswordLabel.TabIndex = 1;
            this.jobPasswordLabel.Text = "Password :";
            // 
            // jobEmailInput
            // 
            this.jobEmailInput.BackColor = System.Drawing.Color.Transparent;
            this.jobEmailInput.FocusOnHover = false;
            this.jobEmailInput.Location = new System.Drawing.Point(141, 72);
            this.jobEmailInput.MaxLength = 32767;
            this.jobEmailInput.Multiline = false;
            this.jobEmailInput.Name = "jobEmailInput";
            this.jobEmailInput.ReadOnly = false;
            this.jobEmailInput.Size = new System.Drawing.Size(150, 29);
            this.jobEmailInput.TabIndex = 12;
            this.jobEmailInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.jobEmailInput.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.jobEmailInput.UseSystemPasswordChar = false;
            // 
            // jobEmailLabel
            // 
            this.jobEmailLabel.AutoSize = true;
            this.jobEmailLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.jobEmailLabel.ForeColor = System.Drawing.Color.White;
            this.jobEmailLabel.Location = new System.Drawing.Point(79, 73);
            this.jobEmailLabel.Name = "jobEmailLabel";
            this.jobEmailLabel.Size = new System.Drawing.Size(53, 20);
            this.jobEmailLabel.TabIndex = 0;
            this.jobEmailLabel.Text = "Email :";
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.ForeColor = System.Drawing.Color.White;
            this.welcomeLabel.Location = new System.Drawing.Point(3, 64);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(356, 38);
            this.welcomeLabel.TabIndex = 15;
            this.welcomeLabel.Text = "Welcome Guest!";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.welcomeLabel.Visible = false;
            // 
            // EmploymentPlatform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(45)))), ((int)(((byte)(55)))));
            this.ClientSize = new System.Drawing.Size(800, 650);
            this.Controls.Add(this.MainForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EmploymentPlatform";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmploymentPlatform";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.MainForm.ResumeLayout(false);
            this.flatGroupBox1.ResumeLayout(false);
            this.flatGroupBox1.PerformLayout();
            this.jobGroupBox.ResumeLayout(false);
            this.jobGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FlatUI.FlatButton findJobButton;
        private FlatUI.FlatLabel welcomeMainLabel;
        private FlatUI.FlatButton findEmployeeButton;
        private FlatUI.FlatLabel descLabel;
        private FlatUI.FormSkin MainForm;
        private FlatUI.FlatMini flatMini1;
        private FlatUI.FlatClose flatClose1;
        private System.Windows.Forms.MaskedTextBox jobPassInput;
        private FlatUI.FlatTextBox jobEmailInput;
        private FlatUI.FlatGroupBox jobGroupBox;
        private FlatUI.FlatGroupBox flatGroupBox1;
        private System.Windows.Forms.Label jobPasswordLabel;
        private System.Windows.Forms.Label jobEmailLabel;
        private FlatUI.FlatButton findJobLoginButton;
        private FlatUI.FlatAlertBox successAlert;
        private System.Windows.Forms.Label welcomeLabel;
        private FlatUI.FlatButton findEmpLoginButton;
        private System.Windows.Forms.MaskedTextBox empPassInput;
        private System.Windows.Forms.Label empPassLabel;
        private System.Windows.Forms.Label empWelcomeLabel;
        private FlatUI.FlatTextBox companyInput;
        private System.Windows.Forms.Label companyLabel;
        private FlatUI.FlatAlertBox errorAlert;
        private FlatUI.FlatLabel requiredLabel;
        private FlatUI.FlatLabel optionalLabel;
    }
}


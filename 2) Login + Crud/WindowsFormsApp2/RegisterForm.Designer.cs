namespace WindowsFormsApp2
{
    partial class RegisterFrom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterFrom));
            this.labelName = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelContact = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.groupBoxUser = new System.Windows.Forms.GroupBox();
            this.errorMsg = new System.Windows.Forms.Label();
            this.inpFemale = new System.Windows.Forms.RadioButton();
            this.inpMale = new System.Windows.Forms.RadioButton();
            this.labelGender = new System.Windows.Forms.Label();
            this.inpAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.inpTerm = new System.Windows.Forms.CheckBox();
            this.labelTerm = new System.Windows.Forms.Label();
            this.labelRole = new System.Windows.Forms.Label();
            this.inpRole = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.inpPassword = new System.Windows.Forms.TextBox();
            this.inpContact = new System.Windows.Forms.TextBox();
            this.inpEmail = new System.Windows.Forms.TextBox();
            this.inpName = new System.Windows.Forms.TextBox();
            this.linkLogin = new System.Windows.Forms.LinkLabel();
            this.groupBoxUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.CausesValidation = false;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(23, 63);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(43, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.CausesValidation = false;
            this.labelEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEmail.Location = new System.Drawing.Point(23, 154);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(41, 13);
            this.labelEmail.TabIndex = 1;
            this.labelEmail.Text = "Email:";
            // 
            // labelContact
            // 
            this.labelContact.AutoSize = true;
            this.labelContact.CausesValidation = false;
            this.labelContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContact.Location = new System.Drawing.Point(23, 108);
            this.labelContact.Name = "labelContact";
            this.labelContact.Size = new System.Drawing.Size(55, 13);
            this.labelContact.TabIndex = 2;
            this.labelContact.Text = "Contact:";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.CausesValidation = false;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(23, 258);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(65, 13);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Password:";
            // 
            // groupBoxUser
            // 
            this.groupBoxUser.BackColor = System.Drawing.Color.Silver;
            this.groupBoxUser.Controls.Add(this.errorMsg);
            this.groupBoxUser.Controls.Add(this.inpFemale);
            this.groupBoxUser.Controls.Add(this.inpMale);
            this.groupBoxUser.Controls.Add(this.labelGender);
            this.groupBoxUser.Controls.Add(this.inpAddress);
            this.groupBoxUser.Controls.Add(this.label2);
            this.groupBoxUser.Controls.Add(this.label1);
            this.groupBoxUser.Controls.Add(this.inpTerm);
            this.groupBoxUser.Controls.Add(this.labelTerm);
            this.groupBoxUser.Controls.Add(this.labelRole);
            this.groupBoxUser.Controls.Add(this.inpRole);
            this.groupBoxUser.Controls.Add(this.btnSubmit);
            this.groupBoxUser.Controls.Add(this.inpPassword);
            this.groupBoxUser.Controls.Add(this.inpContact);
            this.groupBoxUser.Controls.Add(this.inpEmail);
            this.groupBoxUser.Controls.Add(this.inpName);
            this.groupBoxUser.Controls.Add(this.labelContact);
            this.groupBoxUser.Controls.Add(this.labelPassword);
            this.groupBoxUser.Controls.Add(this.labelName);
            this.groupBoxUser.Controls.Add(this.labelEmail);
            this.groupBoxUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxUser.Location = new System.Drawing.Point(20, 12);
            this.groupBoxUser.Name = "groupBoxUser";
            this.groupBoxUser.Size = new System.Drawing.Size(381, 471);
            this.groupBoxUser.TabIndex = 4;
            this.groupBoxUser.TabStop = false;
            this.groupBoxUser.Text = "Signup";
            this.groupBoxUser.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // errorMsg
            // 
            this.errorMsg.AutoSize = true;
            this.errorMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMsg.ForeColor = System.Drawing.Color.Red;
            this.errorMsg.Location = new System.Drawing.Point(252, 8);
            this.errorMsg.Name = "errorMsg";
            this.errorMsg.Size = new System.Drawing.Size(0, 13);
            this.errorMsg.TabIndex = 19;
            // 
            // inpFemale
            // 
            this.inpFemale.AutoSize = true;
            this.inpFemale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inpFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpFemale.Location = new System.Drawing.Point(138, 364);
            this.inpFemale.Name = "inpFemale";
            this.inpFemale.Size = new System.Drawing.Size(65, 17);
            this.inpFemale.TabIndex = 18;
            this.inpFemale.TabStop = true;
            this.inpFemale.Text = "Female";
            this.inpFemale.UseVisualStyleBackColor = true;
            // 
            // inpMale
            // 
            this.inpMale.AutoSize = true;
            this.inpMale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inpMale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpMale.Location = new System.Drawing.Point(26, 364);
            this.inpMale.Name = "inpMale";
            this.inpMale.Size = new System.Drawing.Size(52, 17);
            this.inpMale.TabIndex = 16;
            this.inpMale.TabStop = true;
            this.inpMale.Text = "Male";
            this.inpMale.UseVisualStyleBackColor = true;
            // 
            // labelGender
            // 
            this.labelGender.AutoSize = true;
            this.labelGender.CausesValidation = false;
            this.labelGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGender.Location = new System.Drawing.Point(23, 348);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(52, 13);
            this.labelGender.TabIndex = 17;
            this.labelGender.Text = "Gender:";
            // 
            // inpAddress
            // 
            this.inpAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpAddress.Location = new System.Drawing.Point(27, 214);
            this.inpAddress.Multiline = true;
            this.inpAddress.Name = "inpAddress";
            this.inpAddress.Size = new System.Drawing.Size(324, 39);
            this.inpAddress.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.CausesValidation = false;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Address:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Enter your credentials below";
            // 
            // inpTerm
            // 
            this.inpTerm.AutoSize = true;
            this.inpTerm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpTerm.Location = new System.Drawing.Point(73, 397);
            this.inpTerm.Name = "inpTerm";
            this.inpTerm.Size = new System.Drawing.Size(154, 17);
            this.inpTerm.TabIndex = 5;
            this.inpTerm.Text = "Agree Term and Conditions";
            this.inpTerm.UseVisualStyleBackColor = true;
            // 
            // labelTerm
            // 
            this.labelTerm.AutoSize = true;
            this.labelTerm.CausesValidation = false;
            this.labelTerm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTerm.Location = new System.Drawing.Point(23, 397);
            this.labelTerm.Name = "labelTerm";
            this.labelTerm.Size = new System.Drawing.Size(44, 13);
            this.labelTerm.TabIndex = 12;
            this.labelTerm.Text = "Agree:";
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.CausesValidation = false;
            this.labelRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRole.Location = new System.Drawing.Point(23, 304);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(37, 13);
            this.labelRole.TabIndex = 11;
            this.labelRole.Text = "Role:";
            // 
            // inpRole
            // 
            this.inpRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.inpRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpRole.FormattingEnabled = true;
            this.inpRole.Items.AddRange(new object[] {
            "Admin",
            "Manager",
            "Employee"});
            this.inpRole.Location = new System.Drawing.Point(26, 320);
            this.inpRole.Name = "inpRole";
            this.inpRole.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.inpRole.Size = new System.Drawing.Size(324, 21);
            this.inpRole.TabIndex = 10;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSubmit.Location = new System.Drawing.Point(152, 435);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 26);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.buttonSub_Click);
            // 
            // inpPassword
            // 
            this.inpPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpPassword.Location = new System.Drawing.Point(26, 274);
            this.inpPassword.Name = "inpPassword";
            this.inpPassword.PasswordChar = '*';
            this.inpPassword.Size = new System.Drawing.Size(324, 20);
            this.inpPassword.TabIndex = 7;
            // 
            // inpContact
            // 
            this.inpContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpContact.Location = new System.Drawing.Point(26, 124);
            this.inpContact.Name = "inpContact";
            this.inpContact.Size = new System.Drawing.Size(324, 20);
            this.inpContact.TabIndex = 6;
            // 
            // inpEmail
            // 
            this.inpEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpEmail.Location = new System.Drawing.Point(26, 170);
            this.inpEmail.Name = "inpEmail";
            this.inpEmail.Size = new System.Drawing.Size(324, 20);
            this.inpEmail.TabIndex = 5;
            // 
            // inpName
            // 
            this.inpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpName.Location = new System.Drawing.Point(26, 79);
            this.inpName.Name = "inpName";
            this.inpName.Size = new System.Drawing.Size(324, 20);
            this.inpName.TabIndex = 4;
            // 
            // linkLogin
            // 
            this.linkLogin.AutoSize = true;
            this.linkLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLogin.Location = new System.Drawing.Point(360, 483);
            this.linkLogin.Name = "linkLogin";
            this.linkLogin.Size = new System.Drawing.Size(40, 16);
            this.linkLogin.TabIndex = 13;
            this.linkLogin.TabStop = true;
            this.linkLogin.Text = "Login";
            this.linkLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLogin_LinkClicked);
            // 
            // RegisterFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(422, 506);
            this.Controls.Add(this.linkLogin);
            this.Controls.Add(this.groupBoxUser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "RegisterFrom";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Signup";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxUser.ResumeLayout(false);
            this.groupBoxUser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelContact;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.GroupBox groupBoxUser;
        private System.Windows.Forms.TextBox inpName;
        private System.Windows.Forms.TextBox inpPassword;
        private System.Windows.Forms.TextBox inpContact;
        private System.Windows.Forms.TextBox inpEmail;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.ComboBox inpRole;
        private System.Windows.Forms.CheckBox inpTerm;
        private System.Windows.Forms.Label labelTerm;
        private System.Windows.Forms.LinkLabel linkLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inpAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton inpFemale;
        private System.Windows.Forms.RadioButton inpMale;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.Label errorMsg;
    }
}


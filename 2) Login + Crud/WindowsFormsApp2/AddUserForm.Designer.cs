namespace WindowsFormsApp2
{
    partial class AddUserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUserForm));
            this.errorMsg = new System.Windows.Forms.Label();
            this.inpFemale = new System.Windows.Forms.RadioButton();
            this.inpMale = new System.Windows.Forms.RadioButton();
            this.labelGender = new System.Windows.Forms.Label();
            this.inpAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelRole = new System.Windows.Forms.Label();
            this.inpRole = new System.Windows.Forms.ComboBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.inpContact = new System.Windows.Forms.TextBox();
            this.inpEmail = new System.Windows.Forms.TextBox();
            this.inpName = new System.Windows.Forms.TextBox();
            this.labelContact = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.groupBoxUser = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.inpId = new System.Windows.Forms.TextBox();
            this.inpPassword = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.groupBoxUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorMsg
            // 
            this.errorMsg.AutoSize = true;
            this.errorMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorMsg.ForeColor = System.Drawing.Color.Red;
            this.errorMsg.Location = new System.Drawing.Point(244, 9);
            this.errorMsg.Name = "errorMsg";
            this.errorMsg.Size = new System.Drawing.Size(0, 13);
            this.errorMsg.TabIndex = 19;
            // 
            // inpFemale
            // 
            this.inpFemale.AutoSize = true;
            this.inpFemale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.inpFemale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpFemale.Location = new System.Drawing.Point(130, 322);
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
            this.inpMale.Location = new System.Drawing.Point(18, 322);
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
            this.labelGender.Location = new System.Drawing.Point(15, 306);
            this.labelGender.Name = "labelGender";
            this.labelGender.Size = new System.Drawing.Size(52, 13);
            this.labelGender.TabIndex = 17;
            this.labelGender.Text = "Gender:";
            // 
            // inpAddress
            // 
            this.inpAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpAddress.Location = new System.Drawing.Point(19, 215);
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
            this.label2.Location = new System.Drawing.Point(16, 199);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Address:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(103, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Enter users\' credentials below";
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.CausesValidation = false;
            this.labelRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRole.Location = new System.Drawing.Point(15, 262);
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
            this.inpRole.Location = new System.Drawing.Point(18, 278);
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
            this.btnSubmit.Location = new System.Drawing.Point(85, 420);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 26);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Add";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // inpContact
            // 
            this.inpContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpContact.Location = new System.Drawing.Point(18, 125);
            this.inpContact.Name = "inpContact";
            this.inpContact.Size = new System.Drawing.Size(324, 20);
            this.inpContact.TabIndex = 6;
            // 
            // inpEmail
            // 
            this.inpEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpEmail.Location = new System.Drawing.Point(18, 171);
            this.inpEmail.Name = "inpEmail";
            this.inpEmail.Size = new System.Drawing.Size(324, 20);
            this.inpEmail.TabIndex = 5;
            // 
            // inpName
            // 
            this.inpName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpName.Location = new System.Drawing.Point(18, 80);
            this.inpName.Name = "inpName";
            this.inpName.Size = new System.Drawing.Size(324, 20);
            this.inpName.TabIndex = 4;
            this.inpName.Text = "\r\n";
            // 
            // labelContact
            // 
            this.labelContact.AutoSize = true;
            this.labelContact.CausesValidation = false;
            this.labelContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContact.Location = new System.Drawing.Point(15, 109);
            this.labelContact.Name = "labelContact";
            this.labelContact.Size = new System.Drawing.Size(55, 13);
            this.labelContact.TabIndex = 2;
            this.labelContact.Text = "Contact:";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.CausesValidation = false;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(15, 64);
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
            this.labelEmail.Location = new System.Drawing.Point(15, 155);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(41, 13);
            this.labelEmail.TabIndex = 1;
            this.labelEmail.Text = "Email:";
            // 
            // groupBoxUser
            // 
            this.groupBoxUser.BackColor = System.Drawing.Color.Silver;
            this.groupBoxUser.Controls.Add(this.inpPassword);
            this.groupBoxUser.Controls.Add(this.labelPassword);
            this.groupBoxUser.Controls.Add(this.btnCancel);
            this.groupBoxUser.Controls.Add(this.errorMsg);
            this.groupBoxUser.Controls.Add(this.inpFemale);
            this.groupBoxUser.Controls.Add(this.inpMale);
            this.groupBoxUser.Controls.Add(this.labelGender);
            this.groupBoxUser.Controls.Add(this.inpAddress);
            this.groupBoxUser.Controls.Add(this.label2);
            this.groupBoxUser.Controls.Add(this.label1);
            this.groupBoxUser.Controls.Add(this.labelRole);
            this.groupBoxUser.Controls.Add(this.inpRole);
            this.groupBoxUser.Controls.Add(this.btnSubmit);
            this.groupBoxUser.Controls.Add(this.inpContact);
            this.groupBoxUser.Controls.Add(this.inpEmail);
            this.groupBoxUser.Controls.Add(this.inpName);
            this.groupBoxUser.Controls.Add(this.labelContact);
            this.groupBoxUser.Controls.Add(this.labelName);
            this.groupBoxUser.Controls.Add(this.labelEmail);
            this.groupBoxUser.Controls.Add(this.inpId);
            this.groupBoxUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxUser.Location = new System.Drawing.Point(21, 13);
            this.groupBoxUser.Name = "groupBoxUser";
            this.groupBoxUser.Size = new System.Drawing.Size(381, 471);
            this.groupBoxUser.TabIndex = 14;
            this.groupBoxUser.TabStop = false;
            this.groupBoxUser.Text = "Add User";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Red;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancel.Location = new System.Drawing.Point(201, 420);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 26);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // inpId
            // 
            this.inpId.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpId.Location = new System.Drawing.Point(293, 54);
            this.inpId.Name = "inpId";
            this.inpId.Size = new System.Drawing.Size(49, 20);
            this.inpId.TabIndex = 21;
            this.inpId.Text = "\r\n";
            this.inpId.Visible = false;
            // 
            // inpPassword
            // 
            this.inpPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inpPassword.Location = new System.Drawing.Point(19, 364);
            this.inpPassword.Name = "inpPassword";
            this.inpPassword.PasswordChar = '*';
            this.inpPassword.Size = new System.Drawing.Size(324, 20);
            this.inpPassword.TabIndex = 23;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.CausesValidation = false;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(16, 348);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(65, 13);
            this.labelPassword.TabIndex = 22;
            this.labelPassword.Text = "Password:";
            // 
            // AddUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 506);
            this.Controls.Add(this.groupBoxUser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "AddUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add User";
            this.groupBoxUser.ResumeLayout(false);
            this.groupBoxUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label errorMsg;
        private System.Windows.Forms.RadioButton inpFemale;
        private System.Windows.Forms.RadioButton inpMale;
        private System.Windows.Forms.Label labelGender;
        private System.Windows.Forms.TextBox inpAddress;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.ComboBox inpRole;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox inpContact;
        private System.Windows.Forms.TextBox inpEmail;
        private System.Windows.Forms.TextBox inpName;
        private System.Windows.Forms.Label labelContact;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.GroupBox groupBoxUser;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox inpId;
        private System.Windows.Forms.TextBox inpPassword;
        private System.Windows.Forms.Label labelPassword;
    }
}
namespace LocalDbPractice
{
    partial class AdminHome
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
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.manageUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addUserLink = new System.Windows.Forms.ToolStripMenuItem();
            this.viewUserLink = new System.Windows.Forms.ToolStripMenuItem();
            this.profileLink = new System.Windows.Forms.ToolStripMenuItem();
            this.updateProfileLink = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutLink = new System.Windows.Forms.ToolStripMenuItem();
            this.expensesLink = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(377, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageUserToolStripMenuItem,
            this.profileLink,
            this.expensesLink});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // manageUserToolStripMenuItem
            // 
            this.manageUserToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addUserLink,
            this.viewUserLink});
            this.manageUserToolStripMenuItem.Name = "manageUserToolStripMenuItem";
            this.manageUserToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.manageUserToolStripMenuItem.Text = "Manage User";
            // 
            // addUserLink
            // 
            this.addUserLink.Name = "addUserLink";
            this.addUserLink.Size = new System.Drawing.Size(139, 22);
            this.addUserLink.Text = "Add New";
            this.addUserLink.ToolTipText = "Add new user data";
            this.addUserLink.Click += new System.EventHandler(this.addUserLink_Click);
            // 
            // viewUserLink
            // 
            this.viewUserLink.Name = "viewUserLink";
            this.viewUserLink.Size = new System.Drawing.Size(139, 22);
            this.viewUserLink.Text = "View Record";
            this.viewUserLink.ToolTipText = "View user records";
            this.viewUserLink.Click += new System.EventHandler(this.viewUserLink_Click);
            // 
            // profileLink
            // 
            this.profileLink.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.profileLink.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.updateProfileLink,
            this.logoutLink});
            this.profileLink.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.profileLink.Name = "profileLink";
            this.profileLink.Size = new System.Drawing.Size(56, 20);
            this.profileLink.Text = "Profile";
            // 
            // updateProfileLink
            // 
            this.updateProfileLink.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.updateProfileLink.Name = "updateProfileLink";
            this.updateProfileLink.Size = new System.Drawing.Size(149, 22);
            this.updateProfileLink.Text = "Update Profile";
            this.updateProfileLink.Click += new System.EventHandler(this.updateProfileLink_Click);
            // 
            // logoutLink
            // 
            this.logoutLink.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.logoutLink.ForeColor = System.Drawing.Color.Red;
            this.logoutLink.Name = "logoutLink";
            this.logoutLink.Size = new System.Drawing.Size(149, 22);
            this.logoutLink.Text = "Logout";
            this.logoutLink.Click += new System.EventHandler(this.logoutLink_Click);
            // 
            // expensesLink
            // 
            this.expensesLink.Name = "expensesLink";
            this.expensesLink.Size = new System.Drawing.Size(67, 20);
            this.expensesLink.Text = "Expenses";
            this.expensesLink.ToolTipText = "View user expenses";
            this.expensesLink.Click += new System.EventHandler(this.expensesLink_Click);
            // 
            // AdminHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Home";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem manageUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addUserLink;
        private System.Windows.Forms.ToolStripMenuItem viewUserLink;
        private System.Windows.Forms.ToolStripMenuItem profileLink;
        private System.Windows.Forms.ToolStripMenuItem updateProfileLink;
        private System.Windows.Forms.ToolStripMenuItem logoutLink;
        private System.Windows.Forms.ToolStripMenuItem expensesLink;
    }
}
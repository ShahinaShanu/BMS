namespace BankManagementSystem
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newRegistrationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savingACToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentACToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.depositeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.withdrawlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allotIdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newAllotmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allotedListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transferToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newRegistrationToolStripMenuItem,
            this.depositeToolStripMenuItem,
            this.withdrawlToolStripMenuItem,
            this.allotIdToolStripMenuItem,
            this.transferToolStripMenuItem,
            this.customerProfileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1128, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // newRegistrationToolStripMenuItem
            // 
            this.newRegistrationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.savingACToolStripMenuItem,
            this.currentACToolStripMenuItem});
            this.newRegistrationToolStripMenuItem.Name = "newRegistrationToolStripMenuItem";
            this.newRegistrationToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.newRegistrationToolStripMenuItem.Text = "New Registration";
            this.newRegistrationToolStripMenuItem.Click += new System.EventHandler(this.newRegistrationToolStripMenuItem_Click);
            // 
            // savingACToolStripMenuItem
            // 
            this.savingACToolStripMenuItem.Name = "savingACToolStripMenuItem";
            this.savingACToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.savingACToolStripMenuItem.Text = "Customer";
            this.savingACToolStripMenuItem.Click += new System.EventHandler(this.savingACToolStripMenuItem_Click);
            // 
            // currentACToolStripMenuItem
            // 
            this.currentACToolStripMenuItem.Name = "currentACToolStripMenuItem";
            this.currentACToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.currentACToolStripMenuItem.Text = "Employee";
            this.currentACToolStripMenuItem.Click += new System.EventHandler(this.currentACToolStripMenuItem_Click);
            // 
            // depositeToolStripMenuItem
            // 
            this.depositeToolStripMenuItem.Name = "depositeToolStripMenuItem";
            this.depositeToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.depositeToolStripMenuItem.Text = "Deposite";
            this.depositeToolStripMenuItem.Click += new System.EventHandler(this.depositeToolStripMenuItem_Click);
            // 
            // withdrawlToolStripMenuItem
            // 
            this.withdrawlToolStripMenuItem.Name = "withdrawlToolStripMenuItem";
            this.withdrawlToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.withdrawlToolStripMenuItem.Text = "Withdraw";
            this.withdrawlToolStripMenuItem.Click += new System.EventHandler(this.withdrawlToolStripMenuItem_Click);
            // 
            // allotIdToolStripMenuItem
            // 
            this.allotIdToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newAllotmentToolStripMenuItem,
            this.allotedListToolStripMenuItem});
            this.allotIdToolStripMenuItem.Name = "allotIdToolStripMenuItem";
            this.allotIdToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.allotIdToolStripMenuItem.Text = "Allot Id";
            this.allotIdToolStripMenuItem.Click += new System.EventHandler(this.allotIdToolStripMenuItem_Click);
            // 
            // newAllotmentToolStripMenuItem
            // 
            this.newAllotmentToolStripMenuItem.Name = "newAllotmentToolStripMenuItem";
            this.newAllotmentToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.newAllotmentToolStripMenuItem.Text = "New Allotment";
            this.newAllotmentToolStripMenuItem.Click += new System.EventHandler(this.newAllotmentToolStripMenuItem_Click);
            // 
            // allotedListToolStripMenuItem
            // 
            this.allotedListToolStripMenuItem.Name = "allotedListToolStripMenuItem";
            this.allotedListToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.allotedListToolStripMenuItem.Text = "Alloted List";
            this.allotedListToolStripMenuItem.Click += new System.EventHandler(this.allotedListToolStripMenuItem_Click);
            // 
            // transferToolStripMenuItem
            // 
            this.transferToolStripMenuItem.Name = "transferToolStripMenuItem";
            this.transferToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.transferToolStripMenuItem.Text = "Mony Transfer";
            this.transferToolStripMenuItem.Click += new System.EventHandler(this.transferToolStripMenuItem_Click);
            // 
            // customerProfileToolStripMenuItem
            // 
            this.customerProfileToolStripMenuItem.Name = "customerProfileToolStripMenuItem";
            this.customerProfileToolStripMenuItem.Size = new System.Drawing.Size(108, 20);
            this.customerProfileToolStripMenuItem.Text = "Customer Profile";
            this.customerProfileToolStripMenuItem.Click += new System.EventHandler(this.customerProfileToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.exitToolStripMenuItem.Text = "Logout";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Teal;
            this.label1.Location = new System.Drawing.Point(438, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(475, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "Welcome to Employee Work Space";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.Red;
            this.lblUser.Location = new System.Drawing.Point(662, 41);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(57, 25);
            this.lblUser.TabIndex = 4;
            this.lblUser.Text = "User";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::BankManagementSystem.Properties.Resources.personal_banking;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button1.Location = new System.Drawing.Point(436, 112);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(475, 254);
            this.button1.TabIndex = 1;
            this.button1.Text = " ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1128, 471);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.Text = "Getway of Employee Work Space";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem newRegistrationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem savingACToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem currentACToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem depositeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem withdrawlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem allotIdToolStripMenuItem;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.ToolStripMenuItem newAllotmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allotedListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerProfileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transferToolStripMenuItem;
    }
}
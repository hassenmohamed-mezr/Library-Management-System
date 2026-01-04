namespace Library_Management_System
{
    partial class AdminDashboardForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.grpAdminTools = new System.Windows.Forms.GroupBox();
            this.btnSystemSettings = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.btnManageUsers = new System.Windows.Forms.Button();
            this.btnManageBooks = new System.Windows.Forms.Button();
            this.grpStatistics = new System.Windows.Forms.GroupBox();
            this.lblTotalFeesValue = new System.Windows.Forms.Label();
            this.lblTotalFees = new System.Windows.Forms.Label();
            this.lblActiveBorrowsValue = new System.Windows.Forms.Label();
            this.lblActiveBorrows = new System.Windows.Forms.Label();
            this.lblTotalUsersValue = new System.Windows.Forms.Label();
            this.lblTotalUsers = new System.Windows.Forms.Label();
            this.lblTotalBooksValue = new System.Windows.Forms.Label();
            this.lblTotalBooks = new System.Windows.Forms.Label();
            this.lblStatsTitle = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            this.grpAdminTools.SuspendLayout();
            this.grpStatistics.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Teal;
            this.pnlTop.Controls.Add(this.btnLogout);
            this.pnlTop.Controls.Add(this.btnBack);
            this.pnlTop.Controls.Add(this.lblWelcome);
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1000, 150);
            this.pnlTop.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Maroon;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnLogout.Location = new System.Drawing.Point(840, 45);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(140, 55);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Red;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnBack.Location = new System.Drawing.Point(690, 45);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(140, 55);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // lblWelcome
            // 
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblWelcome.Location = new System.Drawing.Point(28, 95);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(190, 29);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Welcome, Admin";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 34F);
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(391, 65);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Admin Dashboard";
            // 
            // grpAdminTools
            // 
            this.grpAdminTools.BackColor = System.Drawing.Color.Teal;
            this.grpAdminTools.Controls.Add(this.btnSystemSettings);
            this.grpAdminTools.Controls.Add(this.btnReports);
            this.grpAdminTools.Controls.Add(this.btnManageUsers);
            this.grpAdminTools.Controls.Add(this.btnManageBooks);
            this.grpAdminTools.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.grpAdminTools.Location = new System.Drawing.Point(25, 180);
            this.grpAdminTools.Name = "grpAdminTools";
            this.grpAdminTools.Size = new System.Drawing.Size(950, 200);
            this.grpAdminTools.TabIndex = 1;
            this.grpAdminTools.TabStop = false;
            this.grpAdminTools.Text = "Admin Tools";
            // 
            // btnSystemSettings
            // 
            this.btnSystemSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSystemSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnSystemSettings.Location = new System.Drawing.Point(485, 105);
            this.btnSystemSettings.Name = "btnSystemSettings";
            this.btnSystemSettings.Size = new System.Drawing.Size(440, 60);
            this.btnSystemSettings.TabIndex = 3;
            this.btnSystemSettings.Text = "⚙️ System Settings";
            this.btnSystemSettings.UseVisualStyleBackColor = false;
            // 
            // btnReports
            // 
            this.btnReports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnReports.Location = new System.Drawing.Point(25, 105);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(440, 60);
            this.btnReports.TabIndex = 2;
            this.btnReports.Text = "📊 Reports & Statistics";
            this.btnReports.UseVisualStyleBackColor = false;
            // 
            // btnManageUsers
            // 
            this.btnManageUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnManageUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnManageUsers.Location = new System.Drawing.Point(485, 35);
            this.btnManageUsers.Name = "btnManageUsers";
            this.btnManageUsers.Size = new System.Drawing.Size(440, 60);
            this.btnManageUsers.TabIndex = 1;
            this.btnManageUsers.Text = "👥 Manage Users";
            this.btnManageUsers.UseVisualStyleBackColor = false;
            // 
            // btnManageBooks
            // 
            this.btnManageBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnManageBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnManageBooks.Location = new System.Drawing.Point(25, 35);
            this.btnManageBooks.Name = "btnManageBooks";
            this.btnManageBooks.Size = new System.Drawing.Size(440, 60);
            this.btnManageBooks.TabIndex = 0;
            this.btnManageBooks.Text = "📚 Manage Books";
            this.btnManageBooks.UseVisualStyleBackColor = false;
            // 
            // grpStatistics
            // 
            this.grpStatistics.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.grpStatistics.Controls.Add(this.lblTotalFeesValue);
            this.grpStatistics.Controls.Add(this.lblTotalFees);
            this.grpStatistics.Controls.Add(this.lblActiveBorrowsValue);
            this.grpStatistics.Controls.Add(this.lblActiveBorrows);
            this.grpStatistics.Controls.Add(this.lblTotalUsersValue);
            this.grpStatistics.Controls.Add(this.lblTotalUsers);
            this.grpStatistics.Controls.Add(this.lblTotalBooksValue);
            this.grpStatistics.Controls.Add(this.lblTotalBooks);
            this.grpStatistics.Controls.Add(this.lblStatsTitle);
            this.grpStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.grpStatistics.Location = new System.Drawing.Point(25, 400);
            this.grpStatistics.Name = "grpStatistics";
            this.grpStatistics.Size = new System.Drawing.Size(950, 140);
            this.grpStatistics.TabIndex = 2;
            this.grpStatistics.TabStop = false;
            this.grpStatistics.Text = "System Statistics";
            // 
            // lblTotalFeesValue
            // 
            this.lblTotalFeesValue.AutoSize = true;
            this.lblTotalFeesValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTotalFeesValue.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTotalFeesValue.Location = new System.Drawing.Point(700, 85);
            this.lblTotalFeesValue.Name = "lblTotalFeesValue";
            this.lblTotalFeesValue.Size = new System.Drawing.Size(70, 29);
            this.lblTotalFeesValue.TabIndex = 8;
            this.lblTotalFeesValue.Text = "0 EGP";
            // 
            // lblTotalFees
            // 
            this.lblTotalFees.AutoSize = true;
            this.lblTotalFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTotalFees.Location = new System.Drawing.Point(500, 85);
            this.lblTotalFees.Name = "lblTotalFees";
            this.lblTotalFees.Size = new System.Drawing.Size(106, 25);
            this.lblTotalFees.TabIndex = 7;
            this.lblTotalFees.Text = "Total Fees:";
            // 
            // lblActiveBorrowsValue
            // 
            this.lblActiveBorrowsValue.AutoSize = true;
            this.lblActiveBorrowsValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblActiveBorrowsValue.ForeColor = System.Drawing.Color.Blue;
            this.lblActiveBorrowsValue.Location = new System.Drawing.Point(250, 85);
            this.lblActiveBorrowsValue.Name = "lblActiveBorrowsValue";
            this.lblActiveBorrowsValue.Size = new System.Drawing.Size(27, 29);
            this.lblActiveBorrowsValue.TabIndex = 6;
            this.lblActiveBorrowsValue.Text = "0";
            // 
            // lblActiveBorrows
            // 
            this.lblActiveBorrows.AutoSize = true;
            this.lblActiveBorrows.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblActiveBorrows.Location = new System.Drawing.Point(20, 85);
            this.lblActiveBorrows.Name = "lblActiveBorrows";
            this.lblActiveBorrows.Size = new System.Drawing.Size(148, 25);
            this.lblActiveBorrows.TabIndex = 5;
            this.lblActiveBorrows.Text = "Active Borrows:";
            // 
            // lblTotalUsersValue
            // 
            this.lblTotalUsersValue.AutoSize = true;
            this.lblTotalUsersValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTotalUsersValue.ForeColor = System.Drawing.Color.Green;
            this.lblTotalUsersValue.Location = new System.Drawing.Point(700, 40);
            this.lblTotalUsersValue.Name = "lblTotalUsersValue";
            this.lblTotalUsersValue.Size = new System.Drawing.Size(27, 29);
            this.lblTotalUsersValue.TabIndex = 4;
            this.lblTotalUsersValue.Text = "0";
            // 
            // lblTotalUsers
            // 
            this.lblTotalUsers.AutoSize = true;
            this.lblTotalUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTotalUsers.Location = new System.Drawing.Point(500, 40);
            this.lblTotalUsers.Name = "lblTotalUsers";
            this.lblTotalUsers.Size = new System.Drawing.Size(110, 25);
            this.lblTotalUsers.TabIndex = 3;
            this.lblTotalUsers.Text = "Total Users:";
            // 
            // lblTotalBooksValue
            // 
            this.lblTotalBooksValue.AutoSize = true;
            this.lblTotalBooksValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblTotalBooksValue.ForeColor = System.Drawing.Color.Purple;
            this.lblTotalBooksValue.Location = new System.Drawing.Point(250, 40);
            this.lblTotalBooksValue.Name = "lblTotalBooksValue";
            this.lblTotalBooksValue.Size = new System.Drawing.Size(27, 29);
            this.lblTotalBooksValue.TabIndex = 2;
            this.lblTotalBooksValue.Text = "0";
            // 
            // lblTotalBooks
            // 
            this.lblTotalBooks.AutoSize = true;
            this.lblTotalBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTotalBooks.Location = new System.Drawing.Point(20, 40);
            this.lblTotalBooks.Name = "lblTotalBooks";
            this.lblTotalBooks.Size = new System.Drawing.Size(116, 25);
            this.lblTotalBooks.TabIndex = 1;
            this.lblTotalBooks.Text = "Total Books:";
            // 
            // lblStatsTitle
            // 
            this.lblStatsTitle.AutoSize = true;
            this.lblStatsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblStatsTitle.Location = new System.Drawing.Point(15, 0);
            this.lblStatsTitle.Name = "lblStatsTitle";
            this.lblStatsTitle.Size = new System.Drawing.Size(197, 29);
            this.lblStatsTitle.TabIndex = 0;
            this.lblStatsTitle.Text = "Quick Statistics";
            // 
            // AdminDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.grpStatistics);
            this.Controls.Add(this.grpAdminTools);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashboardForm";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.grpAdminTools.ResumeLayout(false);
            this.grpStatistics.ResumeLayout(false);
            this.grpStatistics.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.GroupBox grpAdminTools;
        private System.Windows.Forms.Button btnManageBooks;
        private System.Windows.Forms.Button btnSystemSettings;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Button btnManageUsers;
        private System.Windows.Forms.GroupBox grpStatistics;
        private System.Windows.Forms.Label lblStatsTitle;
        private System.Windows.Forms.Label lblTotalBooks;
        private System.Windows.Forms.Label lblTotalBooksValue;
        private System.Windows.Forms.Label lblTotalUsersValue;
        private System.Windows.Forms.Label lblTotalUsers;
        private System.Windows.Forms.Label lblTotalFeesValue;
        private System.Windows.Forms.Label lblTotalFees;
        private System.Windows.Forms.Label lblActiveBorrowsValue;
        private System.Windows.Forms.Label lblActiveBorrows;
    }
}
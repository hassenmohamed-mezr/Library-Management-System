namespace Library_Management_System
{
    partial class UserDashboardForm
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
            this.grpUser = new System.Windows.Forms.GroupBox();
            this.btnMyHistory = new System.Windows.Forms.Button();
            this.btnReturnBook = new System.Windows.Forms.Button();
            this.btnBorrowBook = new System.Windows.Forms.Button();
            this.btnSearchBooks = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            this.grpUser.SuspendLayout();
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
            this.pnlTop.Size = new System.Drawing.Size(900, 150);
            this.pnlTop.TabIndex = 0;
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Maroon;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnLogout.Location = new System.Drawing.Point(740, 45);
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
            this.btnBack.Location = new System.Drawing.Point(590, 45);
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
            this.lblWelcome.Size = new System.Drawing.Size(178, 29);
            this.lblWelcome.TabIndex = 1;
            this.lblWelcome.Text = "Welcome, User";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 34F);
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(445, 65);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "User Dashboard";
            // 
            // grpUser
            // 
            this.grpUser.BackColor = System.Drawing.Color.Teal;
            this.grpUser.Controls.Add(this.btnMyHistory);
            this.grpUser.Controls.Add(this.btnReturnBook);
            this.grpUser.Controls.Add(this.btnBorrowBook);
            this.grpUser.Controls.Add(this.btnSearchBooks);
            this.grpUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.grpUser.Location = new System.Drawing.Point(25, 180);
            this.grpUser.Name = "grpUser";
            this.grpUser.Size = new System.Drawing.Size(850, 330);
            this.grpUser.TabIndex = 1;
            this.grpUser.TabStop = false;
            this.grpUser.Text = "User Tools";
            // 
            // btnMyHistory
            // 
            this.btnMyHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnMyHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnMyHistory.Location = new System.Drawing.Point(435, 145);
            this.btnMyHistory.Name = "btnMyHistory";
            this.btnMyHistory.Size = new System.Drawing.Size(390, 60);
            this.btnMyHistory.TabIndex = 3;
            this.btnMyHistory.Text = "My Borrow History";
            this.btnMyHistory.UseVisualStyleBackColor = false;
            // 
            // btnReturnBook
            // 
            this.btnReturnBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnReturnBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnReturnBook.Location = new System.Drawing.Point(25, 145);
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.Size = new System.Drawing.Size(390, 60);
            this.btnReturnBook.TabIndex = 2;
            this.btnReturnBook.Text = "Return Book";
            this.btnReturnBook.UseVisualStyleBackColor = false;
            // 
            // btnBorrowBook
            // 
            this.btnBorrowBook.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnBorrowBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnBorrowBook.Location = new System.Drawing.Point(435, 55);
            this.btnBorrowBook.Name = "btnBorrowBook";
            this.btnBorrowBook.Size = new System.Drawing.Size(390, 60);
            this.btnBorrowBook.TabIndex = 1;
            this.btnBorrowBook.Text = "Borrow Book";
            this.btnBorrowBook.UseVisualStyleBackColor = false;
            // 
            // btnSearchBooks
            // 
            this.btnSearchBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSearchBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnSearchBooks.Location = new System.Drawing.Point(25, 55);
            this.btnSearchBooks.Name = "btnSearchBooks";
            this.btnSearchBooks.Size = new System.Drawing.Size(390, 60);
            this.btnSearchBooks.TabIndex = 0;
            this.btnSearchBooks.Text = "Search Books";
            this.btnSearchBooks.UseVisualStyleBackColor = false;
            // 
            // UserDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(900, 560);
            this.Controls.Add(this.grpUser);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserDashboardForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserDashboardForm";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.grpUser.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.GroupBox grpUser;
        private System.Windows.Forms.Button btnSearchBooks;
        private System.Windows.Forms.Button btnBorrowBook;
        private System.Windows.Forms.Button btnReturnBook;
        private System.Windows.Forms.Button btnMyHistory;
    }
}

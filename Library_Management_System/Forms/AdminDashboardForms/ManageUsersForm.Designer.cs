namespace Library_Management_System
{
    partial class ManageUsersForm
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
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabViewUsers = new System.Windows.Forms.TabPage();
            this.gridUsers = new System.Windows.Forms.DataGridView();
            this.tabAddEdit = new System.Windows.Forms.TabPage();
            this.chkIsAdmin = new System.Windows.Forms.CheckBox();
            this.btnClearUser = new System.Windows.Forms.Button();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.txtUserId = new System.Windows.Forms.TextBox();
            this.lblUserId = new System.Windows.Forms.Label();
            this.tabSearch = new System.Windows.Forms.TabPage();
            this.btnSearchUser = new System.Windows.Forms.Button();
            this.txtSearchUserKeyword = new System.Windows.Forms.TextBox();
            this.lblSearchKeyword = new System.Windows.Forms.Label();
            this.cmbSearchUserBy = new System.Windows.Forms.ComboBox();
            this.lblSearchBy = new System.Windows.Forms.Label();
            this.gridUserResults = new System.Windows.Forms.DataGridView();
            this.pnlTop.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabViewUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsers)).BeginInit();
            this.tabAddEdit.SuspendLayout();
            this.tabSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUserResults)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.Teal;
            this.pnlTop.Controls.Add(this.btnBack);
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1100, 110);
            this.pnlTop.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Red;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnBack.Location = new System.Drawing.Point(930, 30);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(140, 50);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = false;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.lblTitle.Location = new System.Drawing.Point(18, 30);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(277, 52);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Manage Users";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabViewUsers);
            this.tabControl.Controls.Add(this.tabAddEdit);
            this.tabControl.Controls.Add(this.tabSearch);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tabControl.Location = new System.Drawing.Point(0, 110);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1100, 590);
            this.tabControl.TabIndex = 1;
            // 
            // tabViewUsers
            // 
            this.tabViewUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tabViewUsers.Controls.Add(this.gridUsers);
            this.tabViewUsers.Location = new System.Drawing.Point(4, 29);
            this.tabViewUsers.Name = "tabViewUsers";
            this.tabViewUsers.Padding = new System.Windows.Forms.Padding(3);
            this.tabViewUsers.Size = new System.Drawing.Size(1092, 557);
            this.tabViewUsers.TabIndex = 0;
            this.tabViewUsers.Text = "👥 View All Users";
            // 
            // gridUsers
            // 
            this.gridUsers.AllowUserToAddRows = false;
            this.gridUsers.AllowUserToDeleteRows = false;
            this.gridUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridUsers.BackgroundColor = System.Drawing.Color.White;
            this.gridUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUsers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridUsers.Location = new System.Drawing.Point(3, 3);
            this.gridUsers.Name = "gridUsers";
            this.gridUsers.ReadOnly = true;
            this.gridUsers.RowHeadersWidth = 51;
            this.gridUsers.RowTemplate.Height = 24;
            this.gridUsers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridUsers.Size = new System.Drawing.Size(1086, 551);
            this.gridUsers.TabIndex = 0;
            this.gridUsers.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridUsers_CellClick);
            // 
            // tabAddEdit
            // 
            this.tabAddEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tabAddEdit.Controls.Add(this.chkIsAdmin);
            this.tabAddEdit.Controls.Add(this.btnClearUser);
            this.tabAddEdit.Controls.Add(this.btnDeleteUser);
            this.tabAddEdit.Controls.Add(this.btnUpdateUser);
            this.tabAddEdit.Controls.Add(this.btnAddUser);
            this.tabAddEdit.Controls.Add(this.txtPhone);
            this.tabAddEdit.Controls.Add(this.lblPhone);
            this.tabAddEdit.Controls.Add(this.txtPassword);
            this.tabAddEdit.Controls.Add(this.lblPassword);
            this.tabAddEdit.Controls.Add(this.txtEmail);
            this.tabAddEdit.Controls.Add(this.lblEmail);
            this.tabAddEdit.Controls.Add(this.txtFullName);
            this.tabAddEdit.Controls.Add(this.lblFullName);
            this.tabAddEdit.Controls.Add(this.txtUserId);
            this.tabAddEdit.Controls.Add(this.lblUserId);
            this.tabAddEdit.Location = new System.Drawing.Point(4, 29);
            this.tabAddEdit.Name = "tabAddEdit";
            this.tabAddEdit.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddEdit.Size = new System.Drawing.Size(1092, 557);
            this.tabAddEdit.TabIndex = 1;
            this.tabAddEdit.Text = "✏️ Add/Edit User";
            // 
            // chkIsAdmin
            // 
            this.chkIsAdmin.AutoSize = true;
            this.chkIsAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chkIsAdmin.Location = new System.Drawing.Point(150, 340);
            this.chkIsAdmin.Name = "chkIsAdmin";
            this.chkIsAdmin.Size = new System.Drawing.Size(107, 29);
            this.chkIsAdmin.TabIndex = 15;
            this.chkIsAdmin.Text = "Is Admin";
            this.chkIsAdmin.UseVisualStyleBackColor = true;
            // 
            // btnClearUser
            // 
            this.btnClearUser.BackColor = System.Drawing.Color.Gray;
            this.btnClearUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClearUser.Location = new System.Drawing.Point(750, 450);
            this.btnClearUser.Name = "btnClearUser";
            this.btnClearUser.Size = new System.Drawing.Size(180, 50);
            this.btnClearUser.TabIndex = 14;
            this.btnClearUser.Text = "Clear";
            this.btnClearUser.UseVisualStyleBackColor = false;
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeleteUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDeleteUser.Location = new System.Drawing.Point(550, 450);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(180, 50);
            this.btnDeleteUser.TabIndex = 13;
            this.btnDeleteUser.Text = "Delete User";
            this.btnDeleteUser.UseVisualStyleBackColor = false;
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnUpdateUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnUpdateUser.Location = new System.Drawing.Point(350, 450);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(180, 50);
            this.btnUpdateUser.TabIndex = 12;
            this.btnUpdateUser.Text = "Update User";
            this.btnUpdateUser.UseVisualStyleBackColor = false;
            // 
            // btnAddUser
            // 
            this.btnAddUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAddUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAddUser.Location = new System.Drawing.Point(150, 450);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(180, 50);
            this.btnAddUser.TabIndex = 11;
            this.btnAddUser.Text = "Add New User";
            this.btnAddUser.UseVisualStyleBackColor = false;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPhone.Location = new System.Drawing.Point(150, 280);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(780, 30);
            this.txtPhone.TabIndex = 9;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPhone.Location = new System.Drawing.Point(20, 283);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(69, 25);
            this.lblPhone.TabIndex = 8;
            this.lblPhone.Text = "Phone";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPassword.Location = new System.Drawing.Point(150, 220);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(780, 30);
            this.txtPassword.TabIndex = 7;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPassword.Location = new System.Drawing.Point(20, 223);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(98, 25);
            this.lblPassword.TabIndex = 6;
            this.lblPassword.Text = "Password";
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtEmail.Location = new System.Drawing.Point(150, 170);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(780, 30);
            this.txtEmail.TabIndex = 5;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblEmail.Location = new System.Drawing.Point(20, 173);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(60, 25);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email";
            // 
            // txtFullName
            // 
            this.txtFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtFullName.Location = new System.Drawing.Point(150, 120);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(780, 30);
            this.txtFullName.TabIndex = 3;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblFullName.Location = new System.Drawing.Point(20, 123);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(97, 25);
            this.lblFullName.TabIndex = 2;
            this.lblFullName.Text = "Full Name";
            // 
            // txtUserId
            // 
            this.txtUserId.Enabled = false;
            this.txtUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtUserId.Location = new System.Drawing.Point(150, 70);
            this.txtUserId.Name = "txtUserId";
            this.txtUserId.ReadOnly = true;
            this.txtUserId.Size = new System.Drawing.Size(200, 30);
            this.txtUserId.TabIndex = 1;
            this.txtUserId.Text = "New User";
            // 
            // lblUserId
            // 
            this.lblUserId.AutoSize = true;
            this.lblUserId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblUserId.Location = new System.Drawing.Point(20, 73);
            this.lblUserId.Name = "lblUserId";
            this.lblUserId.Size = new System.Drawing.Size(73, 25);
            this.lblUserId.TabIndex = 0;
            this.lblUserId.Text = "User ID";
            // 
            // tabSearch
            // 
            this.tabSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tabSearch.Controls.Add(this.btnSearchUser);
            this.tabSearch.Controls.Add(this.txtSearchUserKeyword);
            this.tabSearch.Controls.Add(this.lblSearchKeyword);
            this.tabSearch.Controls.Add(this.cmbSearchUserBy);
            this.tabSearch.Controls.Add(this.lblSearchBy);
            this.tabSearch.Controls.Add(this.gridUserResults);
            this.tabSearch.Location = new System.Drawing.Point(4, 29);
            this.tabSearch.Name = "tabSearch";
            this.tabSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabSearch.Size = new System.Drawing.Size(1092, 557);
            this.tabSearch.TabIndex = 2;
            this.tabSearch.Text = "🔍 Search Users";
            // 
            // btnSearchUser
            // 
            this.btnSearchUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSearchUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSearchUser.Location = new System.Drawing.Point(750, 50);
            this.btnSearchUser.Name = "btnSearchUser";
            this.btnSearchUser.Size = new System.Drawing.Size(150, 40);
            this.btnSearchUser.TabIndex = 5;
            this.btnSearchUser.Text = "Search";
            this.btnSearchUser.UseVisualStyleBackColor = false;
            // 
            // txtSearchUserKeyword
            // 
            this.txtSearchUserKeyword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSearchUserKeyword.Location = new System.Drawing.Point(450, 50);
            this.txtSearchUserKeyword.Name = "txtSearchUserKeyword";
            this.txtSearchUserKeyword.Size = new System.Drawing.Size(280, 30);
            this.txtSearchUserKeyword.TabIndex = 4;
            // 
            // lblSearchKeyword
            // 
            this.lblSearchKeyword.AutoSize = true;
            this.lblSearchKeyword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSearchKeyword.Location = new System.Drawing.Point(450, 20);
            this.lblSearchKeyword.Name = "lblSearchKeyword";
            this.lblSearchKeyword.Size = new System.Drawing.Size(149, 25);
            this.lblSearchKeyword.TabIndex = 3;
            this.lblSearchKeyword.Text = "Search Keyword";
            // 
            // cmbSearchUserBy
            // 
            this.cmbSearchUserBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchUserBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbSearchUserBy.FormattingEnabled = true;
            this.cmbSearchUserBy.Items.AddRange(new object[] {
            "All Fields",
            "Name",
            "Email",
            "Phone"});
            this.cmbSearchUserBy.Location = new System.Drawing.Point(150, 50);
            this.cmbSearchUserBy.Name = "cmbSearchUserBy";
            this.cmbSearchUserBy.Size = new System.Drawing.Size(280, 33);
            this.cmbSearchUserBy.TabIndex = 2;
            // 
            // lblSearchBy
            // 
            this.lblSearchBy.AutoSize = true;
            this.lblSearchBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSearchBy.Location = new System.Drawing.Point(150, 20);
            this.lblSearchBy.Name = "lblSearchBy";
            this.lblSearchBy.Size = new System.Drawing.Size(95, 25);
            this.lblSearchBy.TabIndex = 1;
            this.lblSearchBy.Text = "Search By";
            // 
            // gridUserResults
            // 
            this.gridUserResults.AllowUserToAddRows = false;
            this.gridUserResults.AllowUserToDeleteRows = false;
            this.gridUserResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridUserResults.BackgroundColor = System.Drawing.Color.White;
            this.gridUserResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUserResults.Location = new System.Drawing.Point(20, 110);
            this.gridUserResults.Name = "gridUserResults";
            this.gridUserResults.ReadOnly = true;
            this.gridUserResults.RowHeadersWidth = 51;
            this.gridUserResults.RowTemplate.Height = 24;
            this.gridUserResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridUserResults.Size = new System.Drawing.Size(1050, 420);
            this.gridUserResults.TabIndex = 0;
            // 
            // ManageUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageUsersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageUsersForm";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabViewUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridUsers)).EndInit();
            this.tabAddEdit.ResumeLayout(false);
            this.tabAddEdit.PerformLayout();
            this.tabSearch.ResumeLayout(false);
            this.tabSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUserResults)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabViewUsers;
        private System.Windows.Forms.DataGridView gridUsers;
        private System.Windows.Forms.TabPage tabAddEdit;
        private System.Windows.Forms.TabPage tabSearch;
        private System.Windows.Forms.TextBox txtUserId;
        private System.Windows.Forms.Label lblUserId;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Button btnClearUser;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.Button btnUpdateUser;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.CheckBox chkIsAdmin;
        private System.Windows.Forms.Button btnSearchUser;
        private System.Windows.Forms.TextBox txtSearchUserKeyword;
        private System.Windows.Forms.Label lblSearchKeyword;
        private System.Windows.Forms.ComboBox cmbSearchUserBy;
        private System.Windows.Forms.Label lblSearchBy;
        private System.Windows.Forms.DataGridView gridUserResults;
    }
}
namespace Library_Management_System
{
    partial class SystemSettingsForm
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
            this.grpDatabase = new System.Windows.Forms.GroupBox();
            this.btnTestConnection = new System.Windows.Forms.Button();
            this.lblConnectionStatus = new System.Windows.Forms.Label();
            this.lblServer = new System.Windows.Forms.Label();
            this.txtDatabaseName = new System.Windows.Forms.TextBox();
            this.lblDatabase = new System.Windows.Forms.Label();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.grpFees = new System.Windows.Forms.GroupBox();
            this.numExtraDayFee = new System.Windows.Forms.NumericUpDown();
            this.numFirstDayFee = new System.Windows.Forms.NumericUpDown();
            this.lblExtraDay = new System.Windows.Forms.Label();
            this.lblFirstDay = new System.Windows.Forms.Label();
            this.grpBackup = new System.Windows.Forms.GroupBox();
            this.btnBackupNow = new System.Windows.Forms.Button();
            this.lblBackupInfo = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            this.grpDatabase.SuspendLayout();
            this.grpFees.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numExtraDayFee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFirstDayFee)).BeginInit();
            this.grpBackup.SuspendLayout();
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
            this.pnlTop.Size = new System.Drawing.Size(900, 110);
            this.pnlTop.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Red;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnBack.Location = new System.Drawing.Point(730, 30);
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
            this.lblTitle.Size = new System.Drawing.Size(307, 52);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "System Settings";
            // 
            // grpDatabase
            // 
            this.grpDatabase.Controls.Add(this.btnTestConnection);
            this.grpDatabase.Controls.Add(this.lblConnectionStatus);
            this.grpDatabase.Controls.Add(this.lblServer);
            this.grpDatabase.Controls.Add(this.txtDatabaseName);
            this.grpDatabase.Controls.Add(this.lblDatabase);
            this.grpDatabase.Controls.Add(this.txtServerName);
            this.grpDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.grpDatabase.Location = new System.Drawing.Point(25, 140);
            this.grpDatabase.Name = "grpDatabase";
            this.grpDatabase.Size = new System.Drawing.Size(850, 180);
            this.grpDatabase.TabIndex = 1;
            this.grpDatabase.TabStop = false;
            this.grpDatabase.Text = "Database";
            // 
            // btnTestConnection
            // 
            this.btnTestConnection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnTestConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnTestConnection.Location = new System.Drawing.Point(650, 110);
            this.btnTestConnection.Name = "btnTestConnection";
            this.btnTestConnection.Size = new System.Drawing.Size(180, 40);
            this.btnTestConnection.TabIndex = 5;
            this.btnTestConnection.Text = "Test Connection";
            this.btnTestConnection.UseVisualStyleBackColor = false;
            // 
            // lblConnectionStatus
            // 
            this.lblConnectionStatus.AutoSize = true;
            this.lblConnectionStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblConnectionStatus.Location = new System.Drawing.Point(30, 120);
            this.lblConnectionStatus.Name = "lblConnectionStatus";
            this.lblConnectionStatus.Size = new System.Drawing.Size(137, 20);
            this.lblConnectionStatus.TabIndex = 4;
            this.lblConnectionStatus.Text = "Status: Not tested";
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblServer.Location = new System.Drawing.Point(30, 45);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(119, 25);
            this.lblServer.TabIndex = 0;
            this.lblServer.Text = "Server Name";
            // 
            // txtDatabaseName
            // 
            this.txtDatabaseName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDatabaseName.Location = new System.Drawing.Point(200, 80);
            this.txtDatabaseName.Name = "txtDatabaseName";
            this.txtDatabaseName.Size = new System.Drawing.Size(630, 30);
            this.txtDatabaseName.TabIndex = 3;
            this.txtDatabaseName.Text = "LibraryDB";
            // 
            // lblDatabase
            // 
            this.lblDatabase.AutoSize = true;
            this.lblDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblDatabase.Location = new System.Drawing.Point(30, 83);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(144, 25);
            this.lblDatabase.TabIndex = 2;
            this.lblDatabase.Text = "Database Name";
            // 
            // txtServerName
            // 
            this.txtServerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtServerName.Location = new System.Drawing.Point(200, 42);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(630, 30);
            this.txtServerName.TabIndex = 1;
            this.txtServerName.Text = "(local)";
            // 
            // grpFees
            // 
            this.grpFees.Controls.Add(this.numExtraDayFee);
            this.grpFees.Controls.Add(this.numFirstDayFee);
            this.grpFees.Controls.Add(this.lblExtraDay);
            this.grpFees.Controls.Add(this.lblFirstDay);
            this.grpFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.grpFees.Location = new System.Drawing.Point(25, 340);
            this.grpFees.Name = "grpFees";
            this.grpFees.Size = new System.Drawing.Size(850, 120);
            this.grpFees.TabIndex = 2;
            this.grpFees.TabStop = false;
            this.grpFees.Text = "Borrowing Fees (EGP)";
            // 
            // numExtraDayFee
            // 
            this.numExtraDayFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numExtraDayFee.Location = new System.Drawing.Point(650, 45);
            this.numExtraDayFee.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numExtraDayFee.Name = "numExtraDayFee";
            this.numExtraDayFee.Size = new System.Drawing.Size(180, 30);
            this.numExtraDayFee.TabIndex = 3;
            this.numExtraDayFee.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // numFirstDayFee
            // 
            this.numFirstDayFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numFirstDayFee.Location = new System.Drawing.Point(200, 45);
            this.numFirstDayFee.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numFirstDayFee.Name = "numFirstDayFee";
            this.numFirstDayFee.Size = new System.Drawing.Size(180, 30);
            this.numFirstDayFee.TabIndex = 2;
            this.numFirstDayFee.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // lblExtraDay
            // 
            this.lblExtraDay.AutoSize = true;
            this.lblExtraDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblExtraDay.Location = new System.Drawing.Point(450, 47);
            this.lblExtraDay.Name = "lblExtraDay";
            this.lblExtraDay.Size = new System.Drawing.Size(169, 25);
            this.lblExtraDay.TabIndex = 1;
            this.lblExtraDay.Text = "Extra Day (Per day)";
            // 
            // lblFirstDay
            // 
            this.lblFirstDay.AutoSize = true;
            this.lblFirstDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblFirstDay.Location = new System.Drawing.Point(30, 47);
            this.lblFirstDay.Name = "lblFirstDay";
            this.lblFirstDay.Size = new System.Drawing.Size(132, 25);
            this.lblFirstDay.TabIndex = 0;
            this.lblFirstDay.Text = "First Day Fee";
            // 
            // grpBackup
            // 
            this.grpBackup.Controls.Add(this.btnBackupNow);
            this.grpBackup.Controls.Add(this.lblBackupInfo);
            this.grpBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.grpBackup.Location = new System.Drawing.Point(25, 480);
            this.grpBackup.Name = "grpBackup";
            this.grpBackup.Size = new System.Drawing.Size(850, 120);
            this.grpBackup.TabIndex = 3;
            this.grpBackup.TabStop = false;
            this.grpBackup.Text = "Backup";
            // 
            // btnBackupNow
            // 
            this.btnBackupNow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnBackupNow.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnBackupNow.Location = new System.Drawing.Point(650, 45);
            this.btnBackupNow.Name = "btnBackupNow";
            this.btnBackupNow.Size = new System.Drawing.Size(180, 40);
            this.btnBackupNow.TabIndex = 1;
            this.btnBackupNow.Text = "Backup Now";
            this.btnBackupNow.UseVisualStyleBackColor = false;
            // 
            // lblBackupInfo
            // 
            this.lblBackupInfo.AutoSize = true;
            this.lblBackupInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblBackupInfo.Location = new System.Drawing.Point(30, 55);
            this.lblBackupInfo.Name = "lblBackupInfo";
            this.lblBackupInfo.Size = new System.Drawing.Size(499, 20);
            this.lblBackupInfo.TabIndex = 0;
            this.lblBackupInfo.Text = "Create backup of database. Files saved in: C:\\LibraryBackups\\";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnSave.Location = new System.Drawing.Point(300, 620);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(180, 50);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save Settings";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Gray;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnReset.Location = new System.Drawing.Point(500, 620);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(180, 50);
            this.btnReset.TabIndex = 5;
            this.btnReset.Text = "Reset to Default";
            this.btnReset.UseVisualStyleBackColor = false;
            // 
            // SystemSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 700);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.grpBackup);
            this.Controls.Add(this.grpFees);
            this.Controls.Add(this.grpDatabase);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SystemSettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SystemSettingsForm";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.grpDatabase.ResumeLayout(false);
            this.grpDatabase.PerformLayout();
            this.grpFees.ResumeLayout(false);
            this.grpFees.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numExtraDayFee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFirstDayFee)).EndInit();
            this.grpBackup.ResumeLayout(false);
            this.grpBackup.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.GroupBox grpDatabase;
        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.Label lblDatabase;
        private System.Windows.Forms.TextBox txtDatabaseName;
        private System.Windows.Forms.Button btnTestConnection;
        private System.Windows.Forms.Label lblConnectionStatus;
        private System.Windows.Forms.GroupBox grpFees;
        private System.Windows.Forms.Label lblFirstDay;
        private System.Windows.Forms.Label lblExtraDay;
        private System.Windows.Forms.NumericUpDown numFirstDayFee;
        private System.Windows.Forms.NumericUpDown numExtraDayFee;
        private System.Windows.Forms.GroupBox grpBackup;
        private System.Windows.Forms.Button btnBackupNow;
        private System.Windows.Forms.Label lblBackupInfo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReset;
    }
}
using System;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class SystemSettingsForm : Form
    {
        public SystemSettingsForm()
        {
            InitializeComponent();

            // Link events
            btnBack.Click += (s, e) => this.Close();
            btnTestConnection.Click += BtnTestConnection_Click;
            btnBackupNow.Click += BtnBackupNow_Click;
            btnSave.Click += BtnSave_Click;
            btnReset.Click += BtnReset_Click;

            // Load current settings
            LoadCurrentSettings();

            // Keyboard
            this.KeyPreview = true;
            this.KeyDown += SystemSettingsForm_KeyDown;
        }

        private void LoadCurrentSettings()
        {
            // Default values
            txtServerName.Text = "(local)";
            txtDatabaseName.Text = "LibraryDB";
            numFirstDayFee.Value = 20;
            numExtraDayFee.Value = 40;
        }

        private void BtnTestConnection_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = $"Data Source={txtServerName.Text};" +
                                         $"Initial Catalog={txtDatabaseName.Text};" +
                                         "Integrated Security=True";

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    lblConnectionStatus.Text = "Status: Connected ✓";
                    lblConnectionStatus.ForeColor = System.Drawing.Color.Green;
                    MessageBox.Show("Database connection successful!", "Success");
                }
            }
            catch (Exception ex)
            {
                lblConnectionStatus.Text = "Status: Failed ✗";
                lblConnectionStatus.ForeColor = System.Drawing.Color.Red;
                MessageBox.Show($"Connection failed: {ex.Message}", "Error");
            }
        }

        private void BtnBackupNow_Click(object sender, EventArgs e)
        {
            try
            {
                string backupDir = @"C:\LibraryBackups\";

                // Create directory
                if (!Directory.Exists(backupDir))
                    Directory.CreateDirectory(backupDir);

                string backupFile = $"{backupDir}LibraryDB_Backup_{DateTime.Now:yyyyMMdd_HHmmss}.bak";

                string backupCommand = $"BACKUP DATABASE LibraryDB TO DISK = '{backupFile}'";

                using (SqlConnection conn = new SqlConnection(GetConnectionString()))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(backupCommand, conn))
                    {
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show($"Backup created:\n{backupFile}", "Backup Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Backup failed: {ex.Message}", "Error");
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Test connection first
                string connectionString = GetConnectionString();

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();

                    // Update fees in database
                    string updateFees = "UPDATE Borrows SET " +
                                       $"BaseDailyFee = {numFirstDayFee.Value}, " +
                                       $"ExtraDailyFee = {numExtraDayFee.Value} " +
                                       "WHERE BaseDailyFee IS NOT NULL";

                    using (SqlCommand cmd = new SqlCommand(updateFees, conn))
                    {
                        int rows = cmd.ExecuteNonQuery();

                        MessageBox.Show($"Settings saved!\nUpdated {rows} borrow records.", "Success");

                        // Update status
                        lblConnectionStatus.Text = "Status: Saved ✓";
                        lblConnectionStatus.ForeColor = System.Drawing.Color.Green;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Save failed: {ex.Message}", "Error");
            }
        }

        private void BtnReset_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Reset all settings to default?", "Confirm Reset",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                LoadCurrentSettings();
                lblConnectionStatus.Text = "Status: Reset to default";
                lblConnectionStatus.ForeColor = System.Drawing.Color.Black;

                MessageBox.Show("Settings reset to default.", "Reset Complete");
            }
        }

        private void SystemSettingsForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();

            // Shortcuts
            if (e.Control)
            {
                switch (e.KeyCode)
                {
                    case Keys.T: // Test connection
                        BtnTestConnection_Click(null, null);
                        break;
                    case Keys.S: // Save
                        BtnSave_Click(null, null);
                        break;
                    case Keys.B: // Backup
                        BtnBackupNow_Click(null, null);
                        break;
                }
            }
        }

        private string GetConnectionString()
        {
            return $"Data Source={txtServerName.Text};" +
                   $"Initial Catalog={txtDatabaseName.Text};" +
                   "Integrated Security=True";
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            // Simple close
        }
    }
}
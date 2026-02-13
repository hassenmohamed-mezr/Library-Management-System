using System;
using System.Configuration;
using System.Data.EntityClient;
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

            btnBack.Click += (s, e) => this.Close();
            btnTestConnection.Click += BtnTestConnection_Click;
            btnBackupNow.Click += BtnBackupNow_Click;
            btnSave.Click += BtnSave_Click;
            btnReset.Click += BtnReset_Click;

            LoadCurrentSettings();

            this.KeyPreview = true;
            this.KeyDown += SystemSettingsForm_KeyDown;
        }

        private void LoadCurrentSettings()
        {
            var connBuilder = GetSqlConnectionBuilderFromConfig();
            txtServerName.Text = connBuilder.DataSource;
            txtDatabaseName.Text = connBuilder.InitialCatalog;

            numFirstDayFee.Value = ParseDecimalOrDefault(ConfigurationManager.AppSettings["DefaultBaseDailyFee"], 20);
            numExtraDayFee.Value = ParseDecimalOrDefault(ConfigurationManager.AppSettings["DefaultExtraDailyFee"], 40);
        }

        private void BtnTestConnection_Click(object sender, EventArgs e)
        {
            try
            {
                using (SqlConnection conn = new SqlConnection(GetConnectionString()))
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
                string backupDir = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "LibraryBackups");

                if (!Directory.Exists(backupDir))
                    Directory.CreateDirectory(backupDir);

                string backupFile = Path.Combine(backupDir, $"LibraryDB_Backup_{DateTime.Now:yyyyMMdd_HHmmss}.bak");
                string safeDbName = txtDatabaseName.Text.Replace("]", "]]" );
                string backupCommand = $"BACKUP DATABASE [{safeDbName}] TO DISK = @backupPath";

                using (SqlConnection conn = new SqlConnection(GetConnectionString()))
                {
                    conn.Open();
                    using (SqlCommand cmd = new SqlCommand(backupCommand, conn))
                    {
                        cmd.Parameters.AddWithValue("@backupPath", backupFile);
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
                using (SqlConnection conn = new SqlConnection(GetConnectionString()))
                {
                    conn.Open();
                }

                SaveAppSetting("DefaultBaseDailyFee", numFirstDayFee.Value.ToString("0"));
                SaveAppSetting("DefaultExtraDailyFee", numExtraDayFee.Value.ToString("0"));

                MessageBox.Show("Settings saved! New borrows will use the updated fees.", "Success");
                lblConnectionStatus.Text = "Status: Saved ✓";
                lblConnectionStatus.ForeColor = System.Drawing.Color.Green;
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
                txtServerName.Text = "(local)";
                txtDatabaseName.Text = "LibraryDB";
                numFirstDayFee.Value = 20;
                numExtraDayFee.Value = 40;

                lblConnectionStatus.Text = "Status: Reset to default";
                lblConnectionStatus.ForeColor = System.Drawing.Color.Black;

                MessageBox.Show("Settings reset to default.", "Reset Complete");
            }
        }

        private void SystemSettingsForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();

            if (e.Control)
            {
                switch (e.KeyCode)
                {
                    case Keys.T:
                        BtnTestConnection_Click(null, null);
                        break;
                    case Keys.S:
                        BtnSave_Click(null, null);
                        break;
                    case Keys.B:
                        BtnBackupNow_Click(null, null);
                        break;
                }
            }
        }

        private string GetConnectionString()
        {
            return $"Data Source={txtServerName.Text};Initial Catalog={txtDatabaseName.Text};Integrated Security=True;TrustServerCertificate=True";
        }

        private SqlConnectionStringBuilder GetSqlConnectionBuilderFromConfig()
        {
            string entityConn = ConfigurationManager.ConnectionStrings["LibraryDBEntities"]?.ConnectionString;
            if (string.IsNullOrWhiteSpace(entityConn))
                return new SqlConnectionStringBuilder("Data Source=(local);Initial Catalog=LibraryDB;Integrated Security=True");

            var entityBuilder = new EntityConnectionStringBuilder(entityConn);
            return new SqlConnectionStringBuilder(entityBuilder.ProviderConnectionString);
        }

        private void SaveAppSetting(string key, string value)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            if (config.AppSettings.Settings[key] == null)
                config.AppSettings.Settings.Add(key, value);
            else
                config.AppSettings.Settings[key].Value = value;

            config.Save(ConfigurationSaveMode.Modified);
            ConfigurationManager.RefreshSection("appSettings");
        }

        private decimal ParseDecimalOrDefault(string value, decimal fallback)
        {
            return decimal.TryParse(value, out decimal parsed) ? parsed : fallback;
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
        }
    }
}

using System;
using System.Linq;
using System.Windows.Forms;
using Library_Management_System.Services;

namespace Library_Management_System
{
    public partial class AdminDashboardForm : Form
    {
        private readonly User _currentUser;
        private readonly BookService _bookService = new BookService();
        private readonly AuthService _authService = new AuthService();
        private readonly BorrowService _borrowService = new BorrowService();

        public AdminDashboardForm(User currentUser)
        {
            InitializeComponent();
            FormTheme.Apply(this);
            _currentUser = currentUser;

            
            lblWelcome.Text = _currentUser == null
                ? "Welcome, Admin"
                : $"Welcome, {_currentUser.FullName} (Admin)";

           
            btnBack.Click += BtnBack_Click;
            btnLogout.Click += BtnLogout_Click;
            btnManageBooks.Click += BtnManageBooks_Click;
            btnManageUsers.Click += BtnManageUsers_Click;
            btnReports.Click += BtnReports_Click;
            btnSystemSettings.Click += BtnSystemSettings_Click;

            
            LoadStatistics();

           
            this.KeyPreview = true;
            this.KeyDown += AdminDashboardForm_KeyDown;
        }

        private void LoadStatistics()
        {
            try
            {
                
                var allBooks = _bookService.GetAllBooks();
                lblTotalBooksValue.Text = allBooks.Count.ToString();

               
                var allUsers = _authService.GetAllUsers(); 
                lblTotalUsersValue.Text = allUsers.Count.ToString();

                
                var activeBorrows = _borrowService.GetCurrentBorrows();
                lblActiveBorrowsValue.Text = activeBorrows.Count.ToString();

                
                decimal totalFees = 0;
                var allBorrows = _borrowService.GetAllBorrows(); 
                foreach (var borrow in allBorrows)
                {
                    if (borrow.TotalFee.HasValue)
                        totalFees += borrow.TotalFee.Value;
                }
                lblTotalFeesValue.Text = $"{totalFees} EGP";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading statistics: {ex.Message}");
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure you want to logout?", "Confirm Logout",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Application.Exit(); 
            }
        }

        // block of Manage Books
        private void BtnManageBooks_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var manageBooksForm = new ManageBooksForm())
            {
                manageBooksForm.Owner = this;
                manageBooksForm.ShowDialog();
            }
            this.Show();
            LoadStatistics(); 
        }


        //block of BtnManage Users
        private void BtnManageUsers_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var manageUsersForm = new ManageUsersForm())
            {
                manageUsersForm.Owner = this;
                manageUsersForm.ShowDialog();
            }
            this.Show();
            LoadStatistics(); 
        }


        //block of Rebort
        private void BtnReports_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var reportsForm = new ReportsForm())
            {
                reportsForm.Owner = this;
                reportsForm.ShowDialog();
            }
            this.Show();
            LoadStatistics(); 
        }

        //block of System Setting
        private void BtnSystemSettings_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var settingsForm = new SystemSettingsForm())
            {
                settingsForm.Owner = this;
                settingsForm.ShowDialog();
            }
            this.Show();
            LoadStatistics(); 
        }  

        private void AdminDashboardForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                var result = MessageBox.Show("Logout from admin panel?", "Confirm",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                    Application.Exit();
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            
            if (e.CloseReason == CloseReason.UserClosing)
            {
                var result = MessageBox.Show("Return to login screen?", "Confirm",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                    e.Cancel = true;
            }
        }
    }
}
using Library_Management_System.Services;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Windows.Forms;

namespace Library_Management_System
{
    public partial class ManageUsersForm : Form
    {
        private readonly AuthService _authService = new AuthService();
        private readonly BorrowService _borrowService = new BorrowService();
        private List<User> _allUsers;
        private int _currentUserId = -1;

        public ManageUsersForm()
        {
            InitializeComponent();

            // Link events
            btnBack.Click += (s, e) => this.Close();
            btnAddUser.Click += BtnAddUser_Click;
            btnUpdateUser.Click += BtnUpdateUser_Click;
            btnDeleteUser.Click += BtnDeleteUser_Click;
            btnClearUser.Click += BtnClearUser_Click;
            btnSearchUser.Click += BtnSearchUser_Click;

            // Init data
            InitializeForm();

            // Keyboard
            this.KeyPreview = true;
            this.KeyDown += ManageUsersForm_KeyDown;
        }

        private void InitializeForm()
        {
            try
            {
                // Load users
                LoadAllUsers();

                // Init search
                cmbSearchUserBy.SelectedIndex = 0;

                // Select first tab
                tabControl.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Init error: {ex.Message}", "Error");
            }
        }

        private void LoadAllUsers()
        {
            try
            {
                _allUsers = _authService.GetAllUsers();
                BindUsersGrid(_allUsers);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Load error: {ex.Message}", "Error");
            }
        }

        private void BindUsersGrid(List<User> users)
        {
            var displayList = users.Select(u => new
            {
                u.UserId,
                u.FullName,
                u.Email,
                u.Phone,
                CreatedAt = u.CreatedAt.ToString("yyyy-MM-dd"),
                ActiveBorrows = _borrowService.GetCurrentBorrows().Count(b => b.UserId == u.UserId)
            }).ToList();

            gridUsers.DataSource = displayList;
            gridUserResults.DataSource = displayList;
        }

        private void gridUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var row = gridUsers.Rows[e.RowIndex];
                _currentUserId = Convert.ToInt32(row.Cells["UserId"].Value);

                // Go to edit tab
                tabControl.SelectedIndex = 1;

                // Load data
                LoadUserDetails(_currentUserId);
            }
        }

        private void LoadUserDetails(int userId)
        {
            try
            {
                var user = _allUsers.FirstOrDefault(u => u.UserId == userId);
                if (user != null)
                {
                    txtUserId.Text = user.UserId.ToString();
                    txtFullName.Text = user.FullName;
                    txtEmail.Text = user.Email;
                    txtPassword.Text = user.Password;
                    txtPhone.Text = user.Phone;
                    chkIsAdmin.Checked = user.IsAdmin; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Load error: {ex.Message}", "Error");
            }
        }

        private void BtnAddUser_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate
                if (!ValidateUserData())
                    return;

                var newUser = new User
                {
                    FullName = txtFullName.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    Password = txtPassword.Text,
                    Phone = txtPhone.Text.Trim(),
                    CreatedAt = DateTime.Now,
                    IsAdmin = false
                };

                bool success = _authService.Register(newUser);

                if (success)
                {
                    MessageBox.Show("User added!", "Success");

                    // Refresh
                    LoadAllUsers();
                    BtnClearUser_Click(null, null);
                }
                else
                {
                    MessageBox.Show("Email exists!", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Add error: {ex.Message}", "Error");
            }
        }

        private void BtnUpdateUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (_currentUserId <= 0)
                {
                    MessageBox.Show("Select user", "Warning");
                    return;
                }

                if (!ValidateUserData())
                    return;

                var updatedUser = new User
                {
                    UserId = _currentUserId,
                    FullName = txtFullName.Text.Trim(),
                    Email = txtEmail.Text.Trim(),
                    Password = txtPassword.Text,
                    Phone = txtPhone.Text.Trim(),
                    IsAdmin = chkIsAdmin.Checked
                };

                bool success = _authService.UpdateUser(updatedUser);

                if (success)
                {
                    MessageBox.Show("User updated!", "Success");

                    // Refresh
                    LoadAllUsers();
                    BtnClearUser_Click(null, null);
                }
                else
                {
                    MessageBox.Show("Update failed", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Update error: {ex.Message}", "Error");
            }
        }

        private void BtnDeleteUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (_currentUserId <= 0)
                {
                    MessageBox.Show("Select user", "Warning");
                    return;
                }

                // Confirm
                var result = MessageBox.Show(
                    $"Delete user?\nName: {txtFullName.Text}",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    bool success = _authService.DeleteUser(_currentUserId);

                    if (success)
                    {
                        MessageBox.Show("User deleted!", "Success");

                        // Refresh
                        LoadAllUsers();
                        BtnClearUser_Click(null, null);
                    }
                    else
                    {
                        MessageBox.Show("Delete failed", "Error");
                    }
                }
            }
            catch (DbUpdateException ex)
            {
                MessageBox.Show(ex.InnerException?.InnerException?.Message);
            }
        }

        private void BtnClearUser_Click(object sender, EventArgs e)
        {
            // Reset fields
            _currentUserId = -1;
            txtUserId.Text = "New User";
            txtFullName.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
            txtPhone.Clear();
            chkIsAdmin.Checked = false;

            // Go to view tab
            tabControl.SelectedIndex = 0;
        }

        private void BtnSearchUser_Click(object sender, EventArgs e)
        {
            try
            {
                string keyword = txtSearchUserKeyword.Text.Trim();
                if (string.IsNullOrWhiteSpace(keyword))
                {
                    MessageBox.Show("Enter keyword", "Warning");
                    return;
                }

                List<User> searchResults;
                string searchBy = cmbSearchUserBy.SelectedItem.ToString();

                // Convert keyword to lowercase once
                string keywordLower = keyword.ToLower();

                switch (searchBy)
                {
                    case "All Fields":
                        searchResults = _allUsers.Where(u =>
                            (u.FullName != null && u.FullName.ToLower().Contains(keywordLower)) ||
                            (u.Email != null && u.Email.ToLower().Contains(keywordLower)) ||
                            (u.Phone != null && u.Phone.Contains(keyword))).ToList();
                        break;
                    case "Name":
                        searchResults = _allUsers.Where(u =>
                            u.FullName != null && u.FullName.ToLower().Contains(keywordLower)).ToList();
                        break;
                    case "Email":
                        searchResults = _allUsers.Where(u =>
                            u.Email != null && u.Email.ToLower().Contains(keywordLower)).ToList();
                        break;
                    case "Phone":
                        searchResults = _allUsers.Where(u =>
                            u.Phone != null && u.Phone.Contains(keyword)).ToList();
                        break;
                    default:
                        searchResults = _allUsers;
                        break;
                }

                // Show results
                var displayResults = searchResults.Select(u => new
                {
                    u.UserId,
                    u.FullName,
                    u.Email,
                    u.Phone,
                    CreatedAt = u.CreatedAt.ToString("yyyy-MM-dd"),
                    ActiveBorrows = _borrowService.GetCurrentBorrows().Count(b => b.UserId == u.UserId)
                }).ToList();

                gridUserResults.DataSource = displayResults;

                // Message
                MessageBox.Show($"Found {searchResults.Count} user(s)", "Search Results");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Search error: {ex.Message}", "Error");
            }
        }



        private bool ValidateUserData()
        {
            if (string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                MessageBox.Show("Enter name", "Error");
                txtFullName.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Enter email", "Error");
                txtEmail.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Enter password", "Error");
                txtPassword.Focus();
                return false;
            }

            return true;
        }

        private void ManageUsersForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();

            // Shortcuts
            if (e.Control)
            {
                switch (e.KeyCode)
                {
                    case Keys.N: // New
                        BtnClearUser_Click(null, null);
                        break;
                    case Keys.S: // Save
                        if (tabControl.SelectedIndex == 1)
                        {
                            if (_currentUserId <= 0)
                                BtnAddUser_Click(null, null);
                            else
                                BtnUpdateUser_Click(null, null);
                        }
                        break;
                    case Keys.F: // Find
                        tabControl.SelectedIndex = 2;
                        txtSearchUserKeyword.Focus();
                        break;
                }
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            // Confirm close
            if (tabControl.SelectedIndex == 1 && _currentUserId > 0 && !string.IsNullOrWhiteSpace(txtFullName.Text))
            {
                var result = MessageBox.Show("Close anyway?", "Confirm Close", MessageBoxButtons.YesNo);

                if (result == DialogResult.No)
                    e.Cancel = true;
            }
        }
    }
}
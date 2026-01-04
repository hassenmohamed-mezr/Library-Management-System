namespace Library_Management_System
{
    partial class BorrowFromCartForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.gridCart = new System.Windows.Forms.DataGridView();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.btnClearSelection = new System.Windows.Forms.Button();
            this.lblSelectedCount = new System.Windows.Forms.Label();
            this.btnBorrowSelected = new System.Windows.Forms.Button();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.chkAcceptTerms = new System.Windows.Forms.CheckBox();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCart)).BeginInit();
            this.SuspendLayout();

            // pnlTop
            this.pnlTop.BackColor = System.Drawing.Color.Teal;
            this.pnlTop.Controls.Add(this.btnBack);
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Size = new System.Drawing.Size(900, 110);

            // btnBack
            this.btnBack.BackColor = System.Drawing.Color.Red;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnBack.Location = new System.Drawing.Point(730, 30);
            this.btnBack.Size = new System.Drawing.Size(140, 50);
            this.btnBack.Text = "Back";

            // lblTitle
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.lblTitle.Location = new System.Drawing.Point(18, 30);
            this.lblTitle.Text = "Borrow From Cart";

            // gridCart
            this.gridCart.AllowUserToAddRows = false;
            this.gridCart.AllowUserToDeleteRows = false;
            this.gridCart.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridCart.Location = new System.Drawing.Point(25, 130);
            this.gridCart.Size = new System.Drawing.Size(850, 300);
            this.gridCart.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCart.MultiSelect = true;

            // btnSelectAll
            this.btnSelectAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSelectAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSelectAll.Location = new System.Drawing.Point(25, 450);
            this.btnSelectAll.Size = new System.Drawing.Size(150, 40);
            this.btnSelectAll.Text = "Select All";

            // btnClearSelection
            this.btnClearSelection.BackColor = System.Drawing.Color.Gray;
            this.btnClearSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClearSelection.Location = new System.Drawing.Point(185, 450);
            this.btnClearSelection.Size = new System.Drawing.Size(150, 40);
            this.btnClearSelection.Text = "Clear Selection";

            // lblSelectedCount
            this.lblSelectedCount.AutoSize = true;
            this.lblSelectedCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblSelectedCount.Location = new System.Drawing.Point(350, 455);
            this.lblSelectedCount.Text = "Selected: 0 books";

            // lblPassword
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPassword.Location = new System.Drawing.Point(25, 510);
            this.lblPassword.Text = "Password";

            // txtPassword
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtPassword.Location = new System.Drawing.Point(150, 510);
            this.txtPassword.Size = new System.Drawing.Size(300, 30);
            this.txtPassword.PasswordChar = '*';

            // chkAcceptTerms
            this.chkAcceptTerms.AutoSize = true;
            this.chkAcceptTerms.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.chkAcceptTerms.Location = new System.Drawing.Point(25, 550);
            this.chkAcceptTerms.Text = "I accept terms (First day: 20 EGP, Extra days: 40 EGP per day)";

            // btnBorrowSelected
            this.btnBorrowSelected.BackColor = System.Drawing.Color.Green;
            this.btnBorrowSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnBorrowSelected.Location = new System.Drawing.Point(500, 500);
            this.btnBorrowSelected.Size = new System.Drawing.Size(375, 80);
            this.btnBorrowSelected.Text = "Borrow Selected Books";

            // Form
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.pnlTop, this.gridCart, this.btnSelectAll, this.btnClearSelection,
                this.lblSelectedCount, this.lblPassword, this.txtPassword,
                this.chkAcceptTerms, this.btnBorrowSelected
            });
        }

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView gridCart;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.Button btnClearSelection;
        private System.Windows.Forms.Label lblSelectedCount;
        private System.Windows.Forms.Button btnBorrowSelected;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.CheckBox chkAcceptTerms;
    }
}
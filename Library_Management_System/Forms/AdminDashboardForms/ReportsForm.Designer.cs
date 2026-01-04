namespace Library_Management_System
{
    partial class ReportsForm
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
            this.tabSummary = new System.Windows.Forms.TabPage();
            this.pnlSummaryCards = new System.Windows.Forms.Panel();
            this.cardTotalFees = new System.Windows.Forms.Panel();
            this.lblTotalFeesValue = new System.Windows.Forms.Label();
            this.lblTotalFeesTitle = new System.Windows.Forms.Label();
            this.cardActiveBorrows = new System.Windows.Forms.Panel();
            this.lblActiveBorrowsValue = new System.Windows.Forms.Label();
            this.lblActiveBorrowsTitle = new System.Windows.Forms.Label();
            this.cardTotalUsers = new System.Windows.Forms.Panel();
            this.lblTotalUsersValue = new System.Windows.Forms.Label();
            this.lblTotalUsersTitle = new System.Windows.Forms.Label();
            this.cardTotalBooks = new System.Windows.Forms.Panel();
            this.lblTotalBooksValue = new System.Windows.Forms.Label();
            this.lblTotalBooksTitle = new System.Windows.Forms.Label();
            this.tabBorrowTrends = new System.Windows.Forms.TabPage();
            this.gridBorrowTrends = new System.Windows.Forms.DataGridView();
            this.pnlTrendsFilter = new System.Windows.Forms.Panel();
            this.btnGenerateTrend = new System.Windows.Forms.Button();
            this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
            this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lblTo = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.cmbTrendPeriod = new System.Windows.Forms.ComboBox();
            this.lblPeriod = new System.Windows.Forms.Label();
            this.tabPopularBooks = new System.Windows.Forms.TabPage();
            this.gridPopularBooks = new System.Windows.Forms.DataGridView();
            this.tabUserActivity = new System.Windows.Forms.TabPage();
            this.gridUserActivity = new System.Windows.Forms.DataGridView();
            this.tabFinancial = new System.Windows.Forms.TabPage();
            this.gridFinancial = new System.Windows.Forms.DataGridView();
            this.pnlFinancialFilter = new System.Windows.Forms.Panel();
            this.btnGenerateFinancial = new System.Windows.Forms.Button();
            this.dtpFinancialEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpFinancialStart = new System.Windows.Forms.DateTimePicker();
            this.lblToFin = new System.Windows.Forms.Label();
            this.lblFromFin = new System.Windows.Forms.Label();
            this.tabPrint = new System.Windows.Forms.TabPage();
            this.btnPrintReport = new System.Windows.Forms.Button();
            this.txtReportContent = new System.Windows.Forms.RichTextBox();
            this.cmbReportType = new System.Windows.Forms.ComboBox();
            this.lblReportType = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabSummary.SuspendLayout();
            this.pnlSummaryCards.SuspendLayout();
            this.cardTotalFees.SuspendLayout();
            this.cardActiveBorrows.SuspendLayout();
            this.cardTotalUsers.SuspendLayout();
            this.cardTotalBooks.SuspendLayout();
            this.tabBorrowTrends.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBorrowTrends)).BeginInit();
            this.pnlTrendsFilter.SuspendLayout();
            this.tabPopularBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPopularBooks)).BeginInit();
            this.tabUserActivity.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUserActivity)).BeginInit();
            this.tabFinancial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridFinancial)).BeginInit();
            this.pnlFinancialFilter.SuspendLayout();
            this.tabPrint.SuspendLayout();
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
            this.pnlTop.Size = new System.Drawing.Size(1200, 110);
            this.pnlTop.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Red;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnBack.Location = new System.Drawing.Point(1030, 30);
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
            this.lblTitle.Size = new System.Drawing.Size(319, 52);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Reports & Stats";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabSummary);
            this.tabControl.Controls.Add(this.tabBorrowTrends);
            this.tabControl.Controls.Add(this.tabPopularBooks);
            this.tabControl.Controls.Add(this.tabUserActivity);
            this.tabControl.Controls.Add(this.tabFinancial);
            this.tabControl.Controls.Add(this.tabPrint);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tabControl.Location = new System.Drawing.Point(0, 110);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1200, 690);
            this.tabControl.TabIndex = 1;
            // 
            // tabSummary
            // 
            this.tabSummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tabSummary.Controls.Add(this.pnlSummaryCards);
            this.tabSummary.Location = new System.Drawing.Point(4, 29);
            this.tabSummary.Name = "tabSummary";
            this.tabSummary.Padding = new System.Windows.Forms.Padding(3);
            this.tabSummary.Size = new System.Drawing.Size(1192, 657);
            this.tabSummary.TabIndex = 0;
            this.tabSummary.Text = "📊 Dashboard";
            // 
            // pnlSummaryCards
            // 
            this.pnlSummaryCards.BackColor = System.Drawing.Color.Transparent;
            this.pnlSummaryCards.Controls.Add(this.cardTotalFees);
            this.pnlSummaryCards.Controls.Add(this.cardActiveBorrows);
            this.pnlSummaryCards.Controls.Add(this.cardTotalUsers);
            this.pnlSummaryCards.Controls.Add(this.cardTotalBooks);
            this.pnlSummaryCards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSummaryCards.Location = new System.Drawing.Point(3, 3);
            this.pnlSummaryCards.Name = "pnlSummaryCards";
            this.pnlSummaryCards.Size = new System.Drawing.Size(1186, 651);
            this.pnlSummaryCards.TabIndex = 0;
            // 
            // cardTotalFees
            // 
            this.cardTotalFees.BackColor = System.Drawing.Color.Orange;
            this.cardTotalFees.Controls.Add(this.lblTotalFeesValue);
            this.cardTotalFees.Controls.Add(this.lblTotalFeesTitle);
            this.cardTotalFees.Location = new System.Drawing.Point(650, 350);
            this.cardTotalFees.Name = "cardTotalFees";
            this.cardTotalFees.Size = new System.Drawing.Size(500, 250);
            this.cardTotalFees.TabIndex = 3;
            // 
            // lblTotalFeesValue
            // 
            this.lblTotalFeesValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalFeesValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold);
            this.lblTotalFeesValue.Location = new System.Drawing.Point(0, 50);
            this.lblTotalFeesValue.Name = "lblTotalFeesValue";
            this.lblTotalFeesValue.Size = new System.Drawing.Size(500, 200);
            this.lblTotalFeesValue.TabIndex = 1;
            this.lblTotalFeesValue.Text = "0 EGP";
            this.lblTotalFeesValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalFeesTitle
            // 
            this.lblTotalFeesTitle.BackColor = System.Drawing.Color.DarkOrange;
            this.lblTotalFeesTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTotalFeesTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lblTotalFeesTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTotalFeesTitle.Name = "lblTotalFeesTitle";
            this.lblTotalFeesTitle.Size = new System.Drawing.Size(500, 50);
            this.lblTotalFeesTitle.TabIndex = 0;
            this.lblTotalFeesTitle.Text = "💰 Total Fees";
            this.lblTotalFeesTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cardActiveBorrows
            // 
            this.cardActiveBorrows.BackColor = System.Drawing.Color.RoyalBlue;
            this.cardActiveBorrows.Controls.Add(this.lblActiveBorrowsValue);
            this.cardActiveBorrows.Controls.Add(this.lblActiveBorrowsTitle);
            this.cardActiveBorrows.Location = new System.Drawing.Point(50, 350);
            this.cardActiveBorrows.Name = "cardActiveBorrows";
            this.cardActiveBorrows.Size = new System.Drawing.Size(500, 250);
            this.cardActiveBorrows.TabIndex = 2;
            // 
            // lblActiveBorrowsValue
            // 
            this.lblActiveBorrowsValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblActiveBorrowsValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold);
            this.lblActiveBorrowsValue.Location = new System.Drawing.Point(0, 50);
            this.lblActiveBorrowsValue.Name = "lblActiveBorrowsValue";
            this.lblActiveBorrowsValue.Size = new System.Drawing.Size(500, 200);
            this.lblActiveBorrowsValue.TabIndex = 1;
            this.lblActiveBorrowsValue.Text = "0";
            this.lblActiveBorrowsValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblActiveBorrowsTitle
            // 
            this.lblActiveBorrowsTitle.BackColor = System.Drawing.Color.MediumBlue;
            this.lblActiveBorrowsTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblActiveBorrowsTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lblActiveBorrowsTitle.Location = new System.Drawing.Point(0, 0);
            this.lblActiveBorrowsTitle.Name = "lblActiveBorrowsTitle";
            this.lblActiveBorrowsTitle.Size = new System.Drawing.Size(500, 50);
            this.lblActiveBorrowsTitle.TabIndex = 0;
            this.lblActiveBorrowsTitle.Text = "📚 Active Borrows";
            this.lblActiveBorrowsTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cardTotalUsers
            // 
            this.cardTotalUsers.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.cardTotalUsers.Controls.Add(this.lblTotalUsersValue);
            this.cardTotalUsers.Controls.Add(this.lblTotalUsersTitle);
            this.cardTotalUsers.Location = new System.Drawing.Point(650, 50);
            this.cardTotalUsers.Name = "cardTotalUsers";
            this.cardTotalUsers.Size = new System.Drawing.Size(500, 250);
            this.cardTotalUsers.TabIndex = 1;
            // 
            // lblTotalUsersValue
            // 
            this.lblTotalUsersValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalUsersValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold);
            this.lblTotalUsersValue.Location = new System.Drawing.Point(0, 50);
            this.lblTotalUsersValue.Name = "lblTotalUsersValue";
            this.lblTotalUsersValue.Size = new System.Drawing.Size(500, 200);
            this.lblTotalUsersValue.TabIndex = 1;
            this.lblTotalUsersValue.Text = "0";
            this.lblTotalUsersValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalUsersTitle
            // 
            this.lblTotalUsersTitle.BackColor = System.Drawing.Color.SeaGreen;
            this.lblTotalUsersTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTotalUsersTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lblTotalUsersTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTotalUsersTitle.Name = "lblTotalUsersTitle";
            this.lblTotalUsersTitle.Size = new System.Drawing.Size(500, 50);
            this.lblTotalUsersTitle.TabIndex = 0;
            this.lblTotalUsersTitle.Text = "👥 Total Users";
            this.lblTotalUsersTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cardTotalBooks
            // 
            this.cardTotalBooks.BackColor = System.Drawing.Color.MediumPurple;
            this.cardTotalBooks.Controls.Add(this.lblTotalBooksValue);
            this.cardTotalBooks.Controls.Add(this.lblTotalBooksTitle);
            this.cardTotalBooks.Location = new System.Drawing.Point(50, 50);
            this.cardTotalBooks.Name = "cardTotalBooks";
            this.cardTotalBooks.Size = new System.Drawing.Size(500, 250);
            this.cardTotalBooks.TabIndex = 0;
            // 
            // lblTotalBooksValue
            // 
            this.lblTotalBooksValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTotalBooksValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold);
            this.lblTotalBooksValue.Location = new System.Drawing.Point(0, 50);
            this.lblTotalBooksValue.Name = "lblTotalBooksValue";
            this.lblTotalBooksValue.Size = new System.Drawing.Size(500, 200);
            this.lblTotalBooksValue.TabIndex = 1;
            this.lblTotalBooksValue.Text = "0";
            this.lblTotalBooksValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTotalBooksTitle
            // 
            this.lblTotalBooksTitle.BackColor = System.Drawing.Color.DarkOrchid;
            this.lblTotalBooksTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTotalBooksTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold);
            this.lblTotalBooksTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTotalBooksTitle.Name = "lblTotalBooksTitle";
            this.lblTotalBooksTitle.Size = new System.Drawing.Size(500, 50);
            this.lblTotalBooksTitle.TabIndex = 0;
            this.lblTotalBooksTitle.Text = "📚 Total Books";
            this.lblTotalBooksTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabBorrowTrends
            // 
            this.tabBorrowTrends.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tabBorrowTrends.Controls.Add(this.gridBorrowTrends);
            this.tabBorrowTrends.Controls.Add(this.pnlTrendsFilter);
            this.tabBorrowTrends.Location = new System.Drawing.Point(4, 29);
            this.tabBorrowTrends.Name = "tabBorrowTrends";
            this.tabBorrowTrends.Padding = new System.Windows.Forms.Padding(3);
            this.tabBorrowTrends.Size = new System.Drawing.Size(1192, 657);
            this.tabBorrowTrends.TabIndex = 1;
            this.tabBorrowTrends.Text = "📈 Borrow Trends";
            // 
            // gridBorrowTrends
            // 
            this.gridBorrowTrends.AllowUserToAddRows = false;
            this.gridBorrowTrends.AllowUserToDeleteRows = false;
            this.gridBorrowTrends.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridBorrowTrends.BackgroundColor = System.Drawing.Color.White;
            this.gridBorrowTrends.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBorrowTrends.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridBorrowTrends.Location = new System.Drawing.Point(3, 103);
            this.gridBorrowTrends.Name = "gridBorrowTrends";
            this.gridBorrowTrends.ReadOnly = true;
            this.gridBorrowTrends.RowHeadersWidth = 51;
            this.gridBorrowTrends.RowTemplate.Height = 24;
            this.gridBorrowTrends.Size = new System.Drawing.Size(1186, 551);
            this.gridBorrowTrends.TabIndex = 1;
            // 
            // pnlTrendsFilter
            // 
            this.pnlTrendsFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.pnlTrendsFilter.Controls.Add(this.btnGenerateTrend);
            this.pnlTrendsFilter.Controls.Add(this.dtpEndDate);
            this.pnlTrendsFilter.Controls.Add(this.dtpStartDate);
            this.pnlTrendsFilter.Controls.Add(this.lblTo);
            this.pnlTrendsFilter.Controls.Add(this.lblFrom);
            this.pnlTrendsFilter.Controls.Add(this.cmbTrendPeriod);
            this.pnlTrendsFilter.Controls.Add(this.lblPeriod);
            this.pnlTrendsFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTrendsFilter.Location = new System.Drawing.Point(3, 3);
            this.pnlTrendsFilter.Name = "pnlTrendsFilter";
            this.pnlTrendsFilter.Size = new System.Drawing.Size(1186, 100);
            this.pnlTrendsFilter.TabIndex = 0;
            // 
            // btnGenerateTrend
            // 
            this.btnGenerateTrend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnGenerateTrend.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnGenerateTrend.Location = new System.Drawing.Point(1000, 30);
            this.btnGenerateTrend.Name = "btnGenerateTrend";
            this.btnGenerateTrend.Size = new System.Drawing.Size(150, 40);
            this.btnGenerateTrend.TabIndex = 6;
            this.btnGenerateTrend.Text = "Generate";
            this.btnGenerateTrend.UseVisualStyleBackColor = false;
            // 
            // dtpEndDate
            // 
            this.dtpEndDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtpEndDate.Location = new System.Drawing.Point(750, 35);
            this.dtpEndDate.Name = "dtpEndDate";
            this.dtpEndDate.Size = new System.Drawing.Size(200, 30);
            this.dtpEndDate.TabIndex = 5;
            // 
            // dtpStartDate
            // 
            this.dtpStartDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtpStartDate.Location = new System.Drawing.Point(500, 35);
            this.dtpStartDate.Name = "dtpStartDate";
            this.dtpStartDate.Size = new System.Drawing.Size(200, 30);
            this.dtpStartDate.TabIndex = 4;
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTo.Location = new System.Drawing.Point(750, 5);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(34, 25);
            this.lblTo.TabIndex = 3;
            this.lblTo.Text = "To";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblFrom.Location = new System.Drawing.Point(500, 5);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(60, 25);
            this.lblFrom.TabIndex = 2;
            this.lblFrom.Text = "From";
            // 
            // cmbTrendPeriod
            // 
            this.cmbTrendPeriod.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTrendPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbTrendPeriod.FormattingEnabled = true;
            this.cmbTrendPeriod.Items.AddRange(new object[] {
            "Daily",
            "Weekly",
            "Monthly",
            "Yearly"});
            this.cmbTrendPeriod.Location = new System.Drawing.Point(150, 35);
            this.cmbTrendPeriod.Name = "cmbTrendPeriod";
            this.cmbTrendPeriod.Size = new System.Drawing.Size(280, 33);
            this.cmbTrendPeriod.TabIndex = 1;
            // 
            // lblPeriod
            // 
            this.lblPeriod.AutoSize = true;
            this.lblPeriod.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblPeriod.Location = new System.Drawing.Point(150, 5);
            this.lblPeriod.Name = "lblPeriod";
            this.lblPeriod.Size = new System.Drawing.Size(131, 25);
            this.lblPeriod.TabIndex = 0;
            this.lblPeriod.Text = "Report Period";
            // 
            // tabPopularBooks
            // 
            this.tabPopularBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tabPopularBooks.Controls.Add(this.gridPopularBooks);
            this.tabPopularBooks.Location = new System.Drawing.Point(4, 29);
            this.tabPopularBooks.Name = "tabPopularBooks";
            this.tabPopularBooks.Padding = new System.Windows.Forms.Padding(3);
            this.tabPopularBooks.Size = new System.Drawing.Size(1192, 657);
            this.tabPopularBooks.TabIndex = 2;
            this.tabPopularBooks.Text = "⭐ Popular Books";
            // 
            // gridPopularBooks
            // 
            this.gridPopularBooks.AllowUserToAddRows = false;
            this.gridPopularBooks.AllowUserToDeleteRows = false;
            this.gridPopularBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridPopularBooks.BackgroundColor = System.Drawing.Color.White;
            this.gridPopularBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPopularBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridPopularBooks.Location = new System.Drawing.Point(3, 3);
            this.gridPopularBooks.Name = "gridPopularBooks";
            this.gridPopularBooks.ReadOnly = true;
            this.gridPopularBooks.RowHeadersWidth = 51;
            this.gridPopularBooks.RowTemplate.Height = 24;
            this.gridPopularBooks.Size = new System.Drawing.Size(1186, 651);
            this.gridPopularBooks.TabIndex = 0;
            // 
            // tabUserActivity
            // 
            this.tabUserActivity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tabUserActivity.Controls.Add(this.gridUserActivity);
            this.tabUserActivity.Location = new System.Drawing.Point(4, 29);
            this.tabUserActivity.Name = "tabUserActivity";
            this.tabUserActivity.Padding = new System.Windows.Forms.Padding(3);
            this.tabUserActivity.Size = new System.Drawing.Size(1192, 657);
            this.tabUserActivity.TabIndex = 3;
            this.tabUserActivity.Text = "👤 User Activity";
            // 
            // gridUserActivity
            // 
            this.gridUserActivity.AllowUserToAddRows = false;
            this.gridUserActivity.AllowUserToDeleteRows = false;
            this.gridUserActivity.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridUserActivity.BackgroundColor = System.Drawing.Color.White;
            this.gridUserActivity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridUserActivity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridUserActivity.Location = new System.Drawing.Point(3, 3);
            this.gridUserActivity.Name = "gridUserActivity";
            this.gridUserActivity.ReadOnly = true;
            this.gridUserActivity.RowHeadersWidth = 51;
            this.gridUserActivity.RowTemplate.Height = 24;
            this.gridUserActivity.Size = new System.Drawing.Size(1186, 651);
            this.gridUserActivity.TabIndex = 0;
            // 
            // tabFinancial
            // 
            this.tabFinancial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tabFinancial.Controls.Add(this.gridFinancial);
            this.tabFinancial.Controls.Add(this.pnlFinancialFilter);
            this.tabFinancial.Location = new System.Drawing.Point(4, 29);
            this.tabFinancial.Name = "tabFinancial";
            this.tabFinancial.Padding = new System.Windows.Forms.Padding(3);
            this.tabFinancial.Size = new System.Drawing.Size(1192, 657);
            this.tabFinancial.TabIndex = 4;
            this.tabFinancial.Text = "💰 Financial";
            // 
            // gridFinancial
            // 
            this.gridFinancial.AllowUserToAddRows = false;
            this.gridFinancial.AllowUserToDeleteRows = false;
            this.gridFinancial.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridFinancial.BackgroundColor = System.Drawing.Color.White;
            this.gridFinancial.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridFinancial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridFinancial.Location = new System.Drawing.Point(3, 103);
            this.gridFinancial.Name = "gridFinancial";
            this.gridFinancial.ReadOnly = true;
            this.gridFinancial.RowHeadersWidth = 51;
            this.gridFinancial.RowTemplate.Height = 24;
            this.gridFinancial.Size = new System.Drawing.Size(1186, 551);
            this.gridFinancial.TabIndex = 1;
            // 
            // pnlFinancialFilter
            // 
            this.pnlFinancialFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.pnlFinancialFilter.Controls.Add(this.btnGenerateFinancial);
            this.pnlFinancialFilter.Controls.Add(this.dtpFinancialEnd);
            this.pnlFinancialFilter.Controls.Add(this.dtpFinancialStart);
            this.pnlFinancialFilter.Controls.Add(this.lblToFin);
            this.pnlFinancialFilter.Controls.Add(this.lblFromFin);
            this.pnlFinancialFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlFinancialFilter.Location = new System.Drawing.Point(3, 3);
            this.pnlFinancialFilter.Name = "pnlFinancialFilter";
            this.pnlFinancialFilter.Size = new System.Drawing.Size(1186, 100);
            this.pnlFinancialFilter.TabIndex = 0;
            // 
            // btnGenerateFinancial
            // 
            this.btnGenerateFinancial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnGenerateFinancial.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnGenerateFinancial.Location = new System.Drawing.Point(1000, 30);
            this.btnGenerateFinancial.Name = "btnGenerateFinancial";
            this.btnGenerateFinancial.Size = new System.Drawing.Size(150, 40);
            this.btnGenerateFinancial.TabIndex = 4;
            this.btnGenerateFinancial.Text = "Generate";
            this.btnGenerateFinancial.UseVisualStyleBackColor = false;
            // 
            // dtpFinancialEnd
            // 
            this.dtpFinancialEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtpFinancialEnd.Location = new System.Drawing.Point(600, 35);
            this.dtpFinancialEnd.Name = "dtpFinancialEnd";
            this.dtpFinancialEnd.Size = new System.Drawing.Size(250, 30);
            this.dtpFinancialEnd.TabIndex = 3;
            // 
            // dtpFinancialStart
            // 
            this.dtpFinancialStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.dtpFinancialStart.Location = new System.Drawing.Point(250, 35);
            this.dtpFinancialStart.Name = "dtpFinancialStart";
            this.dtpFinancialStart.Size = new System.Drawing.Size(250, 30);
            this.dtpFinancialStart.TabIndex = 2;
            // 
            // lblToFin
            // 
            this.lblToFin.AutoSize = true;
            this.lblToFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblToFin.Location = new System.Drawing.Point(600, 5);
            this.lblToFin.Name = "lblToFin";
            this.lblToFin.Size = new System.Drawing.Size(34, 25);
            this.lblToFin.TabIndex = 1;
            this.lblToFin.Text = "To";
            // 
            // lblFromFin
            // 
            this.lblFromFin.AutoSize = true;
            this.lblFromFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblFromFin.Location = new System.Drawing.Point(250, 5);
            this.lblFromFin.Name = "lblFromFin";
            this.lblFromFin.Size = new System.Drawing.Size(60, 25);
            this.lblFromFin.TabIndex = 0;
            this.lblFromFin.Text = "From";
            // 
            // tabPrint
            // 
            this.tabPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tabPrint.Controls.Add(this.btnPrintReport);
            this.tabPrint.Controls.Add(this.txtReportContent);
            this.tabPrint.Controls.Add(this.cmbReportType);
            this.tabPrint.Controls.Add(this.lblReportType);
            this.tabPrint.Location = new System.Drawing.Point(4, 29);
            this.tabPrint.Name = "tabPrint";
            this.tabPrint.Padding = new System.Windows.Forms.Padding(3);
            this.tabPrint.Size = new System.Drawing.Size(1192, 657);
            this.tabPrint.TabIndex = 5;
            this.tabPrint.Text = "🖨️ Print Report";
            // 
            // btnPrintReport
            // 
            this.btnPrintReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnPrintReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnPrintReport.Location = new System.Drawing.Point(50, 580);
            this.btnPrintReport.Name = "btnPrintReport";
            this.btnPrintReport.Size = new System.Drawing.Size(200, 50);
            this.btnPrintReport.TabIndex = 3;
            this.btnPrintReport.Text = "Print Report";
            this.btnPrintReport.UseVisualStyleBackColor = false;
            // 
            // txtReportContent
            // 
            this.txtReportContent.Font = new System.Drawing.Font("Consolas", 10F);
            this.txtReportContent.Location = new System.Drawing.Point(50, 100);
            this.txtReportContent.Name = "txtReportContent";
            this.txtReportContent.Size = new System.Drawing.Size(1100, 450);
            this.txtReportContent.TabIndex = 2;
            this.txtReportContent.Text = "";
            // 
            // cmbReportType
            // 
            this.cmbReportType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReportType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbReportType.FormattingEnabled = true;
            this.cmbReportType.Items.AddRange(new object[] {
            "Summary Report",
            "Borrow Trends",
            "Popular Books",
            "User Activity",
            "Financial Report"});
            this.cmbReportType.Location = new System.Drawing.Point(200, 35);
            this.cmbReportType.Name = "cmbReportType";
            this.cmbReportType.Size = new System.Drawing.Size(300, 33);
            this.cmbReportType.TabIndex = 1;
            // 
            // lblReportType
            // 
            this.lblReportType.AutoSize = true;
            this.lblReportType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblReportType.Location = new System.Drawing.Point(50, 38);
            this.lblReportType.Name = "lblReportType";
            this.lblReportType.Size = new System.Drawing.Size(115, 25);
            this.lblReportType.TabIndex = 0;
            this.lblReportType.Text = "Report Type";
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 800);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportsForm";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabSummary.ResumeLayout(false);
            this.pnlSummaryCards.ResumeLayout(false);
            this.cardTotalFees.ResumeLayout(false);
            this.cardActiveBorrows.ResumeLayout(false);
            this.cardTotalUsers.ResumeLayout(false);
            this.cardTotalBooks.ResumeLayout(false);
            this.tabBorrowTrends.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridBorrowTrends)).EndInit();
            this.pnlTrendsFilter.ResumeLayout(false);
            this.pnlTrendsFilter.PerformLayout();
            this.tabPopularBooks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPopularBooks)).EndInit();
            this.tabUserActivity.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridUserActivity)).EndInit();
            this.tabFinancial.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridFinancial)).EndInit();
            this.pnlFinancialFilter.ResumeLayout(false);
            this.pnlFinancialFilter.PerformLayout();
            this.tabPrint.ResumeLayout(false);
            this.tabPrint.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabSummary;
        private System.Windows.Forms.Panel pnlSummaryCards;
        private System.Windows.Forms.Panel cardTotalFees;
        private System.Windows.Forms.Label lblTotalFeesValue;
        private System.Windows.Forms.Label lblTotalFeesTitle;
        private System.Windows.Forms.Panel cardActiveBorrows;
        private System.Windows.Forms.Label lblActiveBorrowsValue;
        private System.Windows.Forms.Label lblActiveBorrowsTitle;
        private System.Windows.Forms.Panel cardTotalUsers;
        private System.Windows.Forms.Label lblTotalUsersValue;
        private System.Windows.Forms.Label lblTotalUsersTitle;
        private System.Windows.Forms.Panel cardTotalBooks;
        private System.Windows.Forms.Label lblTotalBooksValue;
        private System.Windows.Forms.Label lblTotalBooksTitle;
        private System.Windows.Forms.TabPage tabBorrowTrends;
        private System.Windows.Forms.DataGridView gridBorrowTrends;
        private System.Windows.Forms.Panel pnlTrendsFilter;
        private System.Windows.Forms.Button btnGenerateTrend;
        private System.Windows.Forms.DateTimePicker dtpEndDate;
        private System.Windows.Forms.DateTimePicker dtpStartDate;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.ComboBox cmbTrendPeriod;
        private System.Windows.Forms.Label lblPeriod;
        private System.Windows.Forms.TabPage tabPopularBooks;
        private System.Windows.Forms.DataGridView gridPopularBooks;
        private System.Windows.Forms.TabPage tabUserActivity;
        private System.Windows.Forms.DataGridView gridUserActivity;
        private System.Windows.Forms.TabPage tabFinancial;
        private System.Windows.Forms.DataGridView gridFinancial;
        private System.Windows.Forms.Panel pnlFinancialFilter;
        private System.Windows.Forms.Button btnGenerateFinancial;
        private System.Windows.Forms.DateTimePicker dtpFinancialEnd;
        private System.Windows.Forms.DateTimePicker dtpFinancialStart;
        private System.Windows.Forms.Label lblToFin;
        private System.Windows.Forms.Label lblFromFin;
        private System.Windows.Forms.TabPage tabPrint;
        private System.Windows.Forms.Button btnPrintReport;
        private System.Windows.Forms.RichTextBox txtReportContent;
        private System.Windows.Forms.ComboBox cmbReportType;
        private System.Windows.Forms.Label lblReportType;
    }
}
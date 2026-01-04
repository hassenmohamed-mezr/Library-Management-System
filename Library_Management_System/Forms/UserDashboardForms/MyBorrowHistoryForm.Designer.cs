namespace Library_Management_System
{
    partial class MyBorrowHistoryForm
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
            this.gridHistory = new System.Windows.Forms.DataGridView();
            this.pnlSummary = new System.Windows.Forms.Panel();
            this.lblTotalFees = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCurrentCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblReturnedCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotalBorrows = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSummaryTitle = new System.Windows.Forms.Label();
            this.pnlFilters = new System.Windows.Forms.Panel();
            this.lblFilterStatus = new System.Windows.Forms.Label();
            this.btnPrintSummary = new System.Windows.Forms.Button();
            this.btnShowCurrent = new System.Windows.Forms.Button();
            this.btnShowReturned = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.lblFilterTitle = new System.Windows.Forms.Label();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridHistory)).BeginInit();
            this.pnlSummary.SuspendLayout();
            this.pnlFilters.SuspendLayout();
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
            this.lblTitle.Size = new System.Drawing.Size(324, 52);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "My Borrow History";
            // 
            // gridHistory
            // 
            this.gridHistory.AllowUserToAddRows = false;
            this.gridHistory.AllowUserToDeleteRows = false;
            this.gridHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridHistory.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridHistory.Location = new System.Drawing.Point(25, 250);
            this.gridHistory.Name = "gridHistory";
            this.gridHistory.ReadOnly = true;
            this.gridHistory.RowHeadersWidth = 51;
            this.gridHistory.RowTemplate.Height = 24;
            this.gridHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridHistory.Size = new System.Drawing.Size(1050, 350);
            this.gridHistory.TabIndex = 1;
            // 
            // pnlSummary
            // 
            this.pnlSummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.pnlSummary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSummary.Controls.Add(this.lblTotalFees);
            this.pnlSummary.Controls.Add(this.label4);
            this.pnlSummary.Controls.Add(this.lblCurrentCount);
            this.pnlSummary.Controls.Add(this.label3);
            this.pnlSummary.Controls.Add(this.lblReturnedCount);
            this.pnlSummary.Controls.Add(this.label2);
            this.pnlSummary.Controls.Add(this.lblTotalBorrows);
            this.pnlSummary.Controls.Add(this.label1);
            this.pnlSummary.Controls.Add(this.lblSummaryTitle);
            this.pnlSummary.Location = new System.Drawing.Point(650, 120);
            this.pnlSummary.Name = "pnlSummary";
            this.pnlSummary.Size = new System.Drawing.Size(425, 120);
            this.pnlSummary.TabIndex = 2;
            // 
            // lblTotalFees
            // 
            this.lblTotalFees.AutoSize = true;
            this.lblTotalFees.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalFees.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTotalFees.Location = new System.Drawing.Point(320, 80);
            this.lblTotalFees.Name = "lblTotalFees";
            this.lblTotalFees.Size = new System.Drawing.Size(64, 25);
            this.lblTotalFees.TabIndex = 8;
            this.lblTotalFees.Text = "0 EGP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(200, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Total Fees:";
            // 
            // lblCurrentCount
            // 
            this.lblCurrentCount.AutoSize = true;
            this.lblCurrentCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblCurrentCount.ForeColor = System.Drawing.Color.Blue;
            this.lblCurrentCount.Location = new System.Drawing.Point(150, 80);
            this.lblCurrentCount.Name = "lblCurrentCount";
            this.lblCurrentCount.Size = new System.Drawing.Size(24, 25);
            this.lblCurrentCount.TabIndex = 6;
            this.lblCurrentCount.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(20, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Current Borrows:";
            // 
            // lblReturnedCount
            // 
            this.lblReturnedCount.AutoSize = true;
            this.lblReturnedCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblReturnedCount.ForeColor = System.Drawing.Color.Green;
            this.lblReturnedCount.Location = new System.Drawing.Point(320, 45);
            this.lblReturnedCount.Name = "lblReturnedCount";
            this.lblReturnedCount.Size = new System.Drawing.Size(24, 25);
            this.lblReturnedCount.TabIndex = 4;
            this.lblReturnedCount.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(200, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Returned:";
            // 
            // lblTotalBorrows
            // 
            this.lblTotalBorrows.AutoSize = true;
            this.lblTotalBorrows.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblTotalBorrows.Location = new System.Drawing.Point(150, 45);
            this.lblTotalBorrows.Name = "lblTotalBorrows";
            this.lblTotalBorrows.Size = new System.Drawing.Size(24, 25);
            this.lblTotalBorrows.TabIndex = 2;
            this.lblTotalBorrows.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(20, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Total Borrows:";
            // 
            // lblSummaryTitle
            // 
            this.lblSummaryTitle.AutoSize = true;
            this.lblSummaryTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblSummaryTitle.Location = new System.Drawing.Point(15, 0);
            this.lblSummaryTitle.Name = "lblSummaryTitle";
            this.lblSummaryTitle.Size = new System.Drawing.Size(199, 29);
            this.lblSummaryTitle.TabIndex = 0;
            this.lblSummaryTitle.Text = "Borrow Summary";
            // 
            // pnlFilters
            // 
            this.pnlFilters.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.pnlFilters.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlFilters.Controls.Add(this.lblFilterStatus);
            this.pnlFilters.Controls.Add(this.btnPrintSummary);
            this.pnlFilters.Controls.Add(this.btnShowCurrent);
            this.pnlFilters.Controls.Add(this.btnShowReturned);
            this.pnlFilters.Controls.Add(this.btnShowAll);
            this.pnlFilters.Controls.Add(this.lblFilterTitle);
            this.pnlFilters.Location = new System.Drawing.Point(25, 120);
            this.pnlFilters.Name = "pnlFilters";
            this.pnlFilters.Size = new System.Drawing.Size(600, 120);
            this.pnlFilters.TabIndex = 3;
            // 
            // lblFilterStatus
            // 
            this.lblFilterStatus.AutoSize = true;
            this.lblFilterStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblFilterStatus.Location = new System.Drawing.Point(20, 80);
            this.lblFilterStatus.Name = "lblFilterStatus";
            this.lblFilterStatus.Size = new System.Drawing.Size(142, 25);
            this.lblFilterStatus.TabIndex = 5;
            this.lblFilterStatus.Text = "Showing: All";
            // 
            // btnPrintSummary
            // 
            this.btnPrintSummary.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnPrintSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnPrintSummary.Location = new System.Drawing.Point(420, 35);
            this.btnPrintSummary.Name = "btnPrintSummary";
            this.btnPrintSummary.Size = new System.Drawing.Size(160, 35);
            this.btnPrintSummary.TabIndex = 4;
            this.btnPrintSummary.Text = "Print Summary";
            this.btnPrintSummary.UseVisualStyleBackColor = false;
            // 
            // btnShowCurrent
            // 
            this.btnShowCurrent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnShowCurrent.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnShowCurrent.Location = new System.Drawing.Point(280, 35);
            this.btnShowCurrent.Name = "btnShowCurrent";
            this.btnShowCurrent.Size = new System.Drawing.Size(130, 35);
            this.btnShowCurrent.TabIndex = 3;
            this.btnShowCurrent.Text = "Current";
            this.btnShowCurrent.UseVisualStyleBackColor = false;
            // 
            // btnShowReturned
            // 
            this.btnShowReturned.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnShowReturned.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnShowReturned.Location = new System.Drawing.Point(140, 35);
            this.btnShowReturned.Name = "btnShowReturned";
            this.btnShowReturned.Size = new System.Drawing.Size(130, 35);
            this.btnShowReturned.TabIndex = 2;
            this.btnShowReturned.Text = "Returned";
            this.btnShowReturned.UseVisualStyleBackColor = false;
            // 
            // btnShowAll
            // 
            this.btnShowAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnShowAll.Location = new System.Drawing.Point(20, 35);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(110, 35);
            this.btnShowAll.TabIndex = 1;
            this.btnShowAll.Text = "All";
            this.btnShowAll.UseVisualStyleBackColor = false;
            // 
            // lblFilterTitle
            // 
            this.lblFilterTitle.AutoSize = true;
            this.lblFilterTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblFilterTitle.Location = new System.Drawing.Point(15, 0);
            this.lblFilterTitle.Name = "lblFilterTitle";
            this.lblFilterTitle.Size = new System.Drawing.Size(158, 29);
            this.lblFilterTitle.TabIndex = 0;
            this.lblFilterTitle.Text = "Filter History";
            // 
            // MyBorrowHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1100, 650);
            this.Controls.Add(this.pnlFilters);
            this.Controls.Add(this.pnlSummary);
            this.Controls.Add(this.gridHistory);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MyBorrowHistoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MyBorrowHistoryForm";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridHistory)).EndInit();
            this.pnlSummary.ResumeLayout(false);
            this.pnlSummary.PerformLayout();
            this.pnlFilters.ResumeLayout(false);
            this.pnlFilters.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView gridHistory;
        private System.Windows.Forms.Panel pnlSummary;
        private System.Windows.Forms.Label lblSummaryTitle;
        private System.Windows.Forms.Panel pnlFilters;
        private System.Windows.Forms.Label lblFilterTitle;
        private System.Windows.Forms.Label lblTotalFees;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCurrentCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblReturnedCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotalBorrows;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrintSummary;
        private System.Windows.Forms.Button btnShowCurrent;
        private System.Windows.Forms.Button btnShowReturned;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Label lblFilterStatus;
    }
}
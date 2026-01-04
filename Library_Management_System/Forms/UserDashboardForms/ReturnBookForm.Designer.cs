namespace Library_Management_System
{
    partial class ReturnBookForm
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
            this.gridBorrows = new System.Windows.Forms.DataGridView();
            this.lblCurrentBorrows = new System.Windows.Forms.Label();
            this.pnlSelectionInfo = new System.Windows.Forms.Panel();
            this.lblEstimatedFee = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSelectedTitle = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSelectedBorrowId = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSelectedBookId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSelectionInfoTitle = new System.Windows.Forms.Label();
            this.btnReturnSelected = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBorrows)).BeginInit();
            this.pnlSelectionInfo.SuspendLayout();
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
            this.pnlTop.Size = new System.Drawing.Size(950, 110);
            this.pnlTop.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Red;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnBack.Location = new System.Drawing.Point(790, 30);
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
            this.lblTitle.Size = new System.Drawing.Size(244, 52);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Return Book";
            // 
            // gridBorrows
            // 
            this.gridBorrows.AllowUserToAddRows = false;
            this.gridBorrows.AllowUserToDeleteRows = false;
            this.gridBorrows.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridBorrows.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridBorrows.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBorrows.Location = new System.Drawing.Point(25, 170);
            this.gridBorrows.Name = "gridBorrows";
            this.gridBorrows.ReadOnly = true;
            this.gridBorrows.RowHeadersWidth = 51;
            this.gridBorrows.RowTemplate.Height = 24;
            this.gridBorrows.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridBorrows.Size = new System.Drawing.Size(900, 300);
            this.gridBorrows.TabIndex = 1;
            // 
            // lblCurrentBorrows
            // 
            this.lblCurrentBorrows.AutoSize = true;
            this.lblCurrentBorrows.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.lblCurrentBorrows.Location = new System.Drawing.Point(20, 130);
            this.lblCurrentBorrows.Name = "lblCurrentBorrows";
            this.lblCurrentBorrows.Size = new System.Drawing.Size(197, 29);
            this.lblCurrentBorrows.TabIndex = 2;
            this.lblCurrentBorrows.Text = "Current Borrows:";
            // 
            // pnlSelectionInfo
            // 
            this.pnlSelectionInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.pnlSelectionInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSelectionInfo.Controls.Add(this.lblEstimatedFee);
            this.pnlSelectionInfo.Controls.Add(this.label4);
            this.pnlSelectionInfo.Controls.Add(this.lblSelectedTitle);
            this.pnlSelectionInfo.Controls.Add(this.label3);
            this.pnlSelectionInfo.Controls.Add(this.lblSelectedBorrowId);
            this.pnlSelectionInfo.Controls.Add(this.label2);
            this.pnlSelectionInfo.Controls.Add(this.lblSelectedBookId);
            this.pnlSelectionInfo.Controls.Add(this.label1);
            this.pnlSelectionInfo.Controls.Add(this.lblSelectionInfoTitle);
            this.pnlSelectionInfo.Location = new System.Drawing.Point(25, 480);
            this.pnlSelectionInfo.Name = "pnlSelectionInfo";
            this.pnlSelectionInfo.Size = new System.Drawing.Size(900, 120);
            this.pnlSelectionInfo.TabIndex = 3;
            // 
            // lblEstimatedFee
            // 
            this.lblEstimatedFee.AutoSize = true;
            this.lblEstimatedFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblEstimatedFee.ForeColor = System.Drawing.Color.DarkRed;
            this.lblEstimatedFee.Location = new System.Drawing.Point(660, 70);
            this.lblEstimatedFee.Name = "lblEstimatedFee";
            this.lblEstimatedFee.Size = new System.Drawing.Size(64, 25);
            this.lblEstimatedFee.TabIndex = 8;
            this.lblEstimatedFee.Text = "0 EGP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(500, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(136, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Estimated Fee:";
            // 
            // lblSelectedTitle
            // 
            this.lblSelectedTitle.AutoSize = true;
            this.lblSelectedTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblSelectedTitle.Location = new System.Drawing.Point(320, 70);
            this.lblSelectedTitle.Name = "lblSelectedTitle";
            this.lblSelectedTitle.Size = new System.Drawing.Size(36, 25);
            this.lblSelectedTitle.TabIndex = 6;
            this.lblSelectedTitle.Text = "NA";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(240, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Title:";
            // 
            // lblSelectedBorrowId
            // 
            this.lblSelectedBorrowId.AutoSize = true;
            this.lblSelectedBorrowId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblSelectedBorrowId.Location = new System.Drawing.Point(160, 70);
            this.lblSelectedBorrowId.Name = "lblSelectedBorrowId";
            this.lblSelectedBorrowId.Size = new System.Drawing.Size(36, 25);
            this.lblSelectedBorrowId.TabIndex = 4;
            this.lblSelectedBorrowId.Text = "NA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(20, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Borrow Record:";
            // 
            // lblSelectedBookId
            // 
            this.lblSelectedBookId.AutoSize = true;
            this.lblSelectedBookId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.lblSelectedBookId.Location = new System.Drawing.Point(120, 35);
            this.lblSelectedBookId.Name = "lblSelectedBookId";
            this.lblSelectedBookId.Size = new System.Drawing.Size(36, 25);
            this.lblSelectedBookId.TabIndex = 2;
            this.lblSelectedBookId.Text = "NA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(20, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Book ID:";
            // 
            // lblSelectionInfoTitle
            // 
            this.lblSelectionInfoTitle.AutoSize = true;
            this.lblSelectionInfoTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblSelectionInfoTitle.Location = new System.Drawing.Point(15, 0);
            this.lblSelectionInfoTitle.Name = "lblSelectionInfoTitle";
            this.lblSelectionInfoTitle.Size = new System.Drawing.Size(185, 29);
            this.lblSelectionInfoTitle.TabIndex = 0;
            this.lblSelectionInfoTitle.Text = "Selected Book:";
            // 
            // btnReturnSelected
            // 
            this.btnReturnSelected.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnReturnSelected.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnReturnSelected.Location = new System.Drawing.Point(25, 620);
            this.btnReturnSelected.Name = "btnReturnSelected";
            this.btnReturnSelected.Size = new System.Drawing.Size(900, 60);
            this.btnReturnSelected.TabIndex = 4;
            this.btnReturnSelected.Text = "Return Selected Book";
            this.btnReturnSelected.UseVisualStyleBackColor = false;
            // 
            // ReturnBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(950, 700);
            this.Controls.Add(this.btnReturnSelected);
            this.Controls.Add(this.pnlSelectionInfo);
            this.Controls.Add(this.lblCurrentBorrows);
            this.Controls.Add(this.gridBorrows);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReturnBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReturnBookForm";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBorrows)).EndInit();
            this.pnlSelectionInfo.ResumeLayout(false);
            this.pnlSelectionInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.DataGridView gridBorrows;
        private System.Windows.Forms.Label lblCurrentBorrows;
        private System.Windows.Forms.Panel pnlSelectionInfo;
        private System.Windows.Forms.Button btnReturnSelected;
        private System.Windows.Forms.Label lblSelectionInfoTitle;
        private System.Windows.Forms.Label lblEstimatedFee;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSelectedTitle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSelectedBorrowId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblSelectedBookId;
        private System.Windows.Forms.Label label1;
    }
}
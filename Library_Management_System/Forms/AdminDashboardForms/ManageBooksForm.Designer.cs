namespace Library_Management_System
{
    partial class ManageBooksForm
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
            this.tabViewBooks = new System.Windows.Forms.TabPage();
            this.gridBooks = new System.Windows.Forms.DataGridView();
            this.tabAddEdit = new System.Windows.Forms.TabPage();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.numAvailableCopies = new System.Windows.Forms.NumericUpDown();
            this.numTotalCopies = new System.Windows.Forms.NumericUpDown();
            this.lblAvailableCopies = new System.Windows.Forms.Label();
            this.lblTotalCopies = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.lblAuthor = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.lblTitleBook = new System.Windows.Forms.Label();
            this.txtBookId = new System.Windows.Forms.TextBox();
            this.lblBookId = new System.Windows.Forms.Label();
            this.tabSearch = new System.Windows.Forms.TabPage();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchKeyword = new System.Windows.Forms.TextBox();
            this.lblSearchKeyword = new System.Windows.Forms.Label();
            this.cmbSearchBy = new System.Windows.Forms.ComboBox();
            this.lblSearchBy = new System.Windows.Forms.Label();
            this.gridSearchResults = new System.Windows.Forms.DataGridView();
            this.pnlTop.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabViewBooks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBooks)).BeginInit();
            this.tabAddEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAvailableCopies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalCopies)).BeginInit();
            this.tabSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSearchResults)).BeginInit();
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
            this.lblTitle.Text = "Manage Books";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabViewBooks);
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
            // tabViewBooks
            // 
            this.tabViewBooks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tabViewBooks.Controls.Add(this.gridBooks);
            this.tabViewBooks.Location = new System.Drawing.Point(4, 29);
            this.tabViewBooks.Name = "tabViewBooks";
            this.tabViewBooks.Padding = new System.Windows.Forms.Padding(3);
            this.tabViewBooks.Size = new System.Drawing.Size(1092, 557);
            this.tabViewBooks.TabIndex = 0;
            this.tabViewBooks.Text = "📖 View All Books";
            // 
            // gridBooks
            // 
            this.gridBooks.AllowUserToAddRows = false;
            this.gridBooks.AllowUserToDeleteRows = false;
            this.gridBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridBooks.BackgroundColor = System.Drawing.Color.White;
            this.gridBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBooks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridBooks.Location = new System.Drawing.Point(3, 3);
            this.gridBooks.Name = "gridBooks";
            this.gridBooks.ReadOnly = true;
            this.gridBooks.RowHeadersWidth = 51;
            this.gridBooks.RowTemplate.Height = 24;
            this.gridBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridBooks.Size = new System.Drawing.Size(1086, 551);
            this.gridBooks.TabIndex = 0;
            this.gridBooks.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridBooks_CellClick);
            // 
            // tabAddEdit
            // 
            this.tabAddEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tabAddEdit.Controls.Add(this.btnClear);
            this.tabAddEdit.Controls.Add(this.btnDelete);
            this.tabAddEdit.Controls.Add(this.btnUpdate);
            this.tabAddEdit.Controls.Add(this.btnAdd);
            this.tabAddEdit.Controls.Add(this.numAvailableCopies);
            this.tabAddEdit.Controls.Add(this.numTotalCopies);
            this.tabAddEdit.Controls.Add(this.lblAvailableCopies);
            this.tabAddEdit.Controls.Add(this.lblTotalCopies);
            this.tabAddEdit.Controls.Add(this.txtCategory);
            this.tabAddEdit.Controls.Add(this.lblCategory);
            this.tabAddEdit.Controls.Add(this.txtAuthor);
            this.tabAddEdit.Controls.Add(this.lblAuthor);
            this.tabAddEdit.Controls.Add(this.txtTitle);
            this.tabAddEdit.Controls.Add(this.lblTitleBook);
            this.tabAddEdit.Controls.Add(this.txtBookId);
            this.tabAddEdit.Controls.Add(this.lblBookId);
            this.tabAddEdit.Location = new System.Drawing.Point(4, 29);
            this.tabAddEdit.Name = "tabAddEdit";
            this.tabAddEdit.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddEdit.Size = new System.Drawing.Size(1092, 557);
            this.tabAddEdit.TabIndex = 1;
            this.tabAddEdit.Text = "✏️ Add/Edit Book";
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Gray;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClear.Location = new System.Drawing.Point(750, 400);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(180, 50);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDelete.Location = new System.Drawing.Point(550, 400);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(180, 50);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete Book";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnUpdate.Location = new System.Drawing.Point(350, 400);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(180, 50);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update Book";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnAdd.Location = new System.Drawing.Point(150, 400);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(180, 50);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "Add New Book";
            this.btnAdd.UseVisualStyleBackColor = false;
            // 
            // numAvailableCopies
            // 
            this.numAvailableCopies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numAvailableCopies.Location = new System.Drawing.Point(150, 330);
            this.numAvailableCopies.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numAvailableCopies.Name = "numAvailableCopies";
            this.numAvailableCopies.Size = new System.Drawing.Size(780, 30);
            this.numAvailableCopies.TabIndex = 11;
            // 
            // numTotalCopies
            // 
            this.numTotalCopies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.numTotalCopies.Location = new System.Drawing.Point(150, 280);
            this.numTotalCopies.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numTotalCopies.Name = "numTotalCopies";
            this.numTotalCopies.Size = new System.Drawing.Size(780, 30);
            this.numTotalCopies.TabIndex = 10;
            // 
            // lblAvailableCopies
            // 
            this.lblAvailableCopies.AutoSize = true;
            this.lblAvailableCopies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAvailableCopies.Location = new System.Drawing.Point(20, 332);
            this.lblAvailableCopies.Name = "lblAvailableCopies";
            this.lblAvailableCopies.Size = new System.Drawing.Size(154, 25);
            this.lblAvailableCopies.TabIndex = 9;
            this.lblAvailableCopies.Text = "Available Copies";
            // 
            // lblTotalCopies
            // 
            this.lblTotalCopies.AutoSize = true;
            this.lblTotalCopies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTotalCopies.Location = new System.Drawing.Point(20, 282);
            this.lblTotalCopies.Name = "lblTotalCopies";
            this.lblTotalCopies.Size = new System.Drawing.Size(119, 25);
            this.lblTotalCopies.TabIndex = 8;
            this.lblTotalCopies.Text = "Total Copies";
            // 
            // txtCategory
            // 
            this.txtCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtCategory.Location = new System.Drawing.Point(150, 220);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(780, 30);
            this.txtCategory.TabIndex = 7;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblCategory.Location = new System.Drawing.Point(20, 223);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(92, 25);
            this.lblCategory.TabIndex = 6;
            this.lblCategory.Text = "Category";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtAuthor.Location = new System.Drawing.Point(150, 170);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(780, 30);
            this.txtAuthor.TabIndex = 5;
            // 
            // lblAuthor
            // 
            this.lblAuthor.AutoSize = true;
            this.lblAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblAuthor.Location = new System.Drawing.Point(20, 173);
            this.lblAuthor.Name = "lblAuthor";
            this.lblAuthor.Size = new System.Drawing.Size(70, 25);
            this.lblAuthor.TabIndex = 4;
            this.lblAuthor.Text = "Author";
            // 
            // txtTitle
            // 
            this.txtTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTitle.Location = new System.Drawing.Point(150, 120);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(780, 30);
            this.txtTitle.TabIndex = 3;
            // 
            // lblTitleBook
            // 
            this.lblTitleBook.AutoSize = true;
            this.lblTitleBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblTitleBook.Location = new System.Drawing.Point(20, 123);
            this.lblTitleBook.Name = "lblTitleBook";
            this.lblTitleBook.Size = new System.Drawing.Size(51, 25);
            this.lblTitleBook.TabIndex = 2;
            this.lblTitleBook.Text = "Title";
            // 
            // txtBookId
            // 
            this.txtBookId.Enabled = false;
            this.txtBookId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtBookId.Location = new System.Drawing.Point(150, 70);
            this.txtBookId.Name = "txtBookId";
            this.txtBookId.ReadOnly = true;
            this.txtBookId.Size = new System.Drawing.Size(200, 30);
            this.txtBookId.TabIndex = 1;
            this.txtBookId.Text = "New Book";
            // 
            // lblBookId
            // 
            this.lblBookId.AutoSize = true;
            this.lblBookId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblBookId.Location = new System.Drawing.Point(20, 73);
            this.lblBookId.Name = "lblBookId";
            this.lblBookId.Size = new System.Drawing.Size(76, 25);
            this.lblBookId.TabIndex = 0;
            this.lblBookId.Text = "Book ID";
            // 
            // tabSearch
            // 
            this.tabSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.tabSearch.Controls.Add(this.btnSearch);
            this.tabSearch.Controls.Add(this.txtSearchKeyword);
            this.tabSearch.Controls.Add(this.lblSearchKeyword);
            this.tabSearch.Controls.Add(this.cmbSearchBy);
            this.tabSearch.Controls.Add(this.lblSearchBy);
            this.tabSearch.Controls.Add(this.gridSearchResults);
            this.tabSearch.Location = new System.Drawing.Point(4, 29);
            this.tabSearch.Name = "tabSearch";
            this.tabSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabSearch.Size = new System.Drawing.Size(1092, 557);
            this.tabSearch.TabIndex = 2;
            this.tabSearch.Text = "🔍 Search Books";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSearch.Location = new System.Drawing.Point(750, 50);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(150, 40);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // txtSearchKeyword
            // 
            this.txtSearchKeyword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSearchKeyword.Location = new System.Drawing.Point(450, 50);
            this.txtSearchKeyword.Name = "txtSearchKeyword";
            this.txtSearchKeyword.Size = new System.Drawing.Size(280, 30);
            this.txtSearchKeyword.TabIndex = 4;
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
            // cmbSearchBy
            // 
            this.cmbSearchBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearchBy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cmbSearchBy.FormattingEnabled = true;
            this.cmbSearchBy.Items.AddRange(new object[] {
            "All Fields",
            "Title",
            "Author",
            "Category"});
            this.cmbSearchBy.Location = new System.Drawing.Point(150, 50);
            this.cmbSearchBy.Name = "cmbSearchBy";
            this.cmbSearchBy.Size = new System.Drawing.Size(280, 33);
            this.cmbSearchBy.TabIndex = 2;
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
            // gridSearchResults
            // 
            this.gridSearchResults.AllowUserToAddRows = false;
            this.gridSearchResults.AllowUserToDeleteRows = false;
            this.gridSearchResults.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridSearchResults.BackgroundColor = System.Drawing.Color.White;
            this.gridSearchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridSearchResults.Location = new System.Drawing.Point(20, 110);
            this.gridSearchResults.Name = "gridSearchResults";
            this.gridSearchResults.ReadOnly = true;
            this.gridSearchResults.RowHeadersWidth = 51;
            this.gridSearchResults.RowTemplate.Height = 24;
            this.gridSearchResults.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridSearchResults.Size = new System.Drawing.Size(1050, 420);
            this.gridSearchResults.TabIndex = 0;
            // 
            // ManageBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageBooksForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageBooksForm";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.tabViewBooks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridBooks)).EndInit();
            this.tabAddEdit.ResumeLayout(false);
            this.tabAddEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAvailableCopies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTotalCopies)).EndInit();
            this.tabSearch.ResumeLayout(false);
            this.tabSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridSearchResults)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabViewBooks;
        private System.Windows.Forms.DataGridView gridBooks;
        private System.Windows.Forms.TabPage tabAddEdit;
        private System.Windows.Forms.TabPage tabSearch;
        private System.Windows.Forms.TextBox txtBookId;
        private System.Windows.Forms.Label lblBookId;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblTitleBook;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Label lblAuthor;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblTotalCopies;
        private System.Windows.Forms.Label lblAvailableCopies;
        private System.Windows.Forms.NumericUpDown numTotalCopies;
        private System.Windows.Forms.NumericUpDown numAvailableCopies;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchKeyword;
        private System.Windows.Forms.Label lblSearchKeyword;
        private System.Windows.Forms.ComboBox cmbSearchBy;
        private System.Windows.Forms.Label lblSearchBy;
        private System.Windows.Forms.DataGridView gridSearchResults;
    }
}
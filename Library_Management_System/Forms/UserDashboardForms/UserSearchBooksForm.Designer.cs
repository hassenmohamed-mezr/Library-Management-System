namespace Library_Management_System
{
    partial class UserSearchBooksForm
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
            this.lblSearchTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.btnSearchTitle = new System.Windows.Forms.Button();
            this.lblSearchAuthor = new System.Windows.Forms.Label();
            this.txtAuthor = new System.Windows.Forms.TextBox();
            this.btnSearchAuthor = new System.Windows.Forms.Button();
            this.lblSearchCategory = new System.Windows.Forms.Label();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.btnSearchCategory = new System.Windows.Forms.Button();
            this.gridBooks = new System.Windows.Forms.DataGridView();
            this.btnAddToCart = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBooks)).BeginInit();
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
            this.pnlTop.Size = new System.Drawing.Size(1050, 110);
            this.pnlTop.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.Red;
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.btnBack.Location = new System.Drawing.Point(885, 30);
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
            this.lblTitle.Size = new System.Drawing.Size(293, 52);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Search Books";
            // 
            // lblSearchTitle
            // 
            this.lblSearchTitle.AutoSize = true;
            this.lblSearchTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSearchTitle.Location = new System.Drawing.Point(22, 135);
            this.lblSearchTitle.Name = "lblSearchTitle";
            this.lblSearchTitle.Size = new System.Drawing.Size(49, 25);
            this.lblSearchTitle.TabIndex = 2;
            this.lblSearchTitle.Text = "Title";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(110, 138);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(520, 22);
            this.txtTitle.TabIndex = 3;
            // 
            // btnSearchTitle
            // 
            this.btnSearchTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSearchTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnSearchTitle.Location = new System.Drawing.Point(650, 130);
            this.btnSearchTitle.Name = "btnSearchTitle";
            this.btnSearchTitle.Size = new System.Drawing.Size(180, 38);
            this.btnSearchTitle.TabIndex = 4;
            this.btnSearchTitle.Text = "Search Title";
            this.btnSearchTitle.UseVisualStyleBackColor = false;
            // 
            // lblSearchAuthor
            // 
            this.lblSearchAuthor.AutoSize = true;
            this.lblSearchAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSearchAuthor.Location = new System.Drawing.Point(22, 185);
            this.lblSearchAuthor.Name = "lblSearchAuthor";
            this.lblSearchAuthor.Size = new System.Drawing.Size(70, 25);
            this.lblSearchAuthor.TabIndex = 5;
            this.lblSearchAuthor.Text = "Author";
            // 
            // txtAuthor
            // 
            this.txtAuthor.Location = new System.Drawing.Point(110, 188);
            this.txtAuthor.Name = "txtAuthor";
            this.txtAuthor.Size = new System.Drawing.Size(520, 22);
            this.txtAuthor.TabIndex = 6;
            // 
            // btnSearchAuthor
            // 
            this.btnSearchAuthor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSearchAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnSearchAuthor.Location = new System.Drawing.Point(650, 180);
            this.btnSearchAuthor.Name = "btnSearchAuthor";
            this.btnSearchAuthor.Size = new System.Drawing.Size(180, 38);
            this.btnSearchAuthor.TabIndex = 7;
            this.btnSearchAuthor.Text = "Search Author";
            this.btnSearchAuthor.UseVisualStyleBackColor = false;
            // 
            // lblSearchCategory
            // 
            this.lblSearchCategory.AutoSize = true;
            this.lblSearchCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.lblSearchCategory.Location = new System.Drawing.Point(22, 235);
            this.lblSearchCategory.Name = "lblSearchCategory";
            this.lblSearchCategory.Size = new System.Drawing.Size(92, 25);
            this.lblSearchCategory.TabIndex = 8;
            this.lblSearchCategory.Text = "Category";
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(110, 238);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(520, 22);
            this.txtCategory.TabIndex = 9;
            // 
            // btnSearchCategory
            // 
            this.btnSearchCategory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnSearchCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.btnSearchCategory.Location = new System.Drawing.Point(650, 230);
            this.btnSearchCategory.Name = "btnSearchCategory";
            this.btnSearchCategory.Size = new System.Drawing.Size(180, 38);
            this.btnSearchCategory.TabIndex = 10;
            this.btnSearchCategory.Text = "Search Category";
            this.btnSearchCategory.UseVisualStyleBackColor = false;
            // 
            // gridBooks
            // 
            this.gridBooks.AllowUserToAddRows = false;
            this.gridBooks.AllowUserToDeleteRows = false;
            this.gridBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gridBooks.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.gridBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBooks.Location = new System.Drawing.Point(27, 286);
            this.gridBooks.Name = "gridBooks";
            this.gridBooks.ReadOnly = true;
            this.gridBooks.RowHeadersWidth = 51;
            this.gridBooks.RowTemplate.Height = 24;
            this.gridBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridBooks.Size = new System.Drawing.Size(998, 350);
            this.gridBooks.TabIndex = 11;
            // 
            // btnAddToCart
            // 
            this.btnAddToCart.BackColor = System.Drawing.Color.SpringGreen;
            this.btnAddToCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToCart.Location = new System.Drawing.Point(847, 138);
            this.btnAddToCart.Name = "btnAddToCart";
            this.btnAddToCart.Size = new System.Drawing.Size(178, 104);
            this.btnAddToCart.TabIndex = 12;
            this.btnAddToCart.Text = "Add To Cart";
            this.btnAddToCart.UseVisualStyleBackColor = false;
            // 
            // UserSearchBooksForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1050, 740);
            this.Controls.Add(this.btnAddToCart);
            this.Controls.Add(this.gridBooks);
            this.Controls.Add(this.btnSearchCategory);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.lblSearchCategory);
            this.Controls.Add(this.btnSearchAuthor);
            this.Controls.Add(this.txtAuthor);
            this.Controls.Add(this.lblSearchAuthor);
            this.Controls.Add(this.btnSearchTitle);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblSearchTitle);
            this.Controls.Add(this.pnlTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserSearchBooksForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserSearchBooksForm";
            this.pnlTop.ResumeLayout(false);
            this.pnlTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnBack;

        private System.Windows.Forms.Label lblSearchTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Button btnSearchTitle;

        private System.Windows.Forms.Label lblSearchAuthor;
        private System.Windows.Forms.TextBox txtAuthor;
        private System.Windows.Forms.Button btnSearchAuthor;

        private System.Windows.Forms.Label lblSearchCategory;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Button btnSearchCategory;

        private System.Windows.Forms.DataGridView gridBooks;
        private System.Windows.Forms.Button btnAddToCart;
    }
}

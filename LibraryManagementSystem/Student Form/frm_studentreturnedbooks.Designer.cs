namespace LibraryManagementSystem.Student_Form
{
    partial class frm_studentreturnedbooks
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.data_ReturnedBooks = new System.Windows.Forms.DataGridView();
            this.BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BooksReturned = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.data_ReturnedBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // data_ReturnedBooks
            // 
            this.data_ReturnedBooks.AllowUserToAddRows = false;
            this.data_ReturnedBooks.AllowUserToDeleteRows = false;
            this.data_ReturnedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_ReturnedBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookID,
            this.UserID,
            this.Title,
            this.BooksReturned});
            this.data_ReturnedBooks.Location = new System.Drawing.Point(100, 121);
            this.data_ReturnedBooks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.data_ReturnedBooks.Name = "data_ReturnedBooks";
            this.data_ReturnedBooks.ReadOnly = true;
            this.data_ReturnedBooks.Size = new System.Drawing.Size(1166, 923);
            this.data_ReturnedBooks.TabIndex = 1;
            // 
            // BookID
            // 
            this.BookID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BookID.HeaderText = "BookID";
            this.BookID.Name = "BookID";
            this.BookID.ReadOnly = true;
            // 
            // UserID
            // 
            this.UserID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserID.HeaderText = "UserID";
            this.UserID.Name = "UserID";
            this.UserID.ReadOnly = true;
            // 
            // Title
            // 
            this.Title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // BooksReturned
            // 
            this.BooksReturned.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BooksReturned.HeaderText = "Books Returned";
            this.BooksReturned.Name = "BooksReturned";
            this.BooksReturned.ReadOnly = true;
            // 
            // frm_studentreturnedbooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1376, 1061);
            this.Controls.Add(this.data_ReturnedBooks);
            this.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_studentreturnedbooks";
            this.Text = "Returned Books";
            this.Load += new System.EventHandler(this.frm_studentreturnedbooks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_ReturnedBooks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView data_ReturnedBooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn BooksReturned;
    }
}
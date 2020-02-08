namespace LibraryManagementSystem.Student_Form
{
    partial class frm_studentborrowedbook
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
            this.data_BorrowedBooks = new System.Windows.Forms.DataGridView();
            this.BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CurrentBookBorrowed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.data_BorrowedBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // data_BorrowedBooks
            // 
            this.data_BorrowedBooks.AllowUserToAddRows = false;
            this.data_BorrowedBooks.AllowUserToDeleteRows = false;
            this.data_BorrowedBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_BorrowedBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookID,
            this.UserID,
            this.Title,
            this.CurrentBookBorrowed});
            this.data_BorrowedBooks.Location = new System.Drawing.Point(44, 71);
            this.data_BorrowedBooks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.data_BorrowedBooks.Name = "data_BorrowedBooks";
            this.data_BorrowedBooks.ReadOnly = true;
            this.data_BorrowedBooks.Size = new System.Drawing.Size(777, 769);
            this.data_BorrowedBooks.TabIndex = 0;
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
            // CurrentBookBorrowed
            // 
            this.CurrentBookBorrowed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CurrentBookBorrowed.HeaderText = "Current Book Borrowed";
            this.CurrentBookBorrowed.Name = "CurrentBookBorrowed";
            this.CurrentBookBorrowed.ReadOnly = true;
            // 
            // frm_studentborrowedbook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(865, 897);
            this.Controls.Add(this.data_BorrowedBooks);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frm_studentborrowedbook";
            this.Text = "Borrowed Books";
            this.Load += new System.EventHandler(this.frm_studentborrowedbook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_BorrowedBooks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView data_BorrowedBooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn CurrentBookBorrowed;
    }
}
namespace LibraryManagementSystem
{
    partial class frm_borrowBook
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
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Users = new System.Windows.Forms.Label();
            this.dataCart = new System.Windows.Forms.DataGridView();
            this.BookID2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataUser = new System.Windows.Forms.DataGridView();
            this.UserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MiddleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.dataBooks = new System.Windows.Forms.DataGridView();
            this.BookID1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(490, 40);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 18);
            this.label6.TabIndex = 55;
            this.label6.Text = "Cart";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(78, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 18);
            this.label1.TabIndex = 54;
            this.label1.Text = "Books";
            // 
            // Users
            // 
            this.Users.AutoSize = true;
            this.Users.ForeColor = System.Drawing.SystemColors.Control;
            this.Users.Location = new System.Drawing.Point(903, 40);
            this.Users.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Users.Name = "Users";
            this.Users.Size = new System.Drawing.Size(49, 18);
            this.Users.TabIndex = 53;
            this.Users.Text = "Users";
            // 
            // dataCart
            // 
            this.dataCart.AllowUserToAddRows = false;
            this.dataCart.AllowUserToDeleteRows = false;
            this.dataCart.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCart.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookID2,
            this.Title2,
            this.Quantity});
            this.dataCart.Location = new System.Drawing.Point(471, 75);
            this.dataCart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataCart.Name = "dataCart";
            this.dataCart.ReadOnly = true;
            this.dataCart.Size = new System.Drawing.Size(363, 539);
            this.dataCart.TabIndex = 52;
            // 
            // BookID2
            // 
            this.BookID2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BookID2.HeaderText = "BookID";
            this.BookID2.Name = "BookID2";
            this.BookID2.ReadOnly = true;
            // 
            // Title2
            // 
            this.Title2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Title2.HeaderText = "Title";
            this.Title2.Name = "Title2";
            this.Title2.ReadOnly = true;
            // 
            // Quantity
            // 
            this.Quantity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            // 
            // dataUser
            // 
            this.dataUser.AllowUserToAddRows = false;
            this.dataUser.AllowUserToDeleteRows = false;
            this.dataUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserID,
            this.FirstName,
            this.MiddleName,
            this.LastName});
            this.dataUser.Location = new System.Drawing.Point(880, 79);
            this.dataUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataUser.Name = "dataUser";
            this.dataUser.ReadOnly = true;
            this.dataUser.Size = new System.Drawing.Size(592, 299);
            this.dataUser.TabIndex = 51;
            this.dataUser.SelectionChanged += new System.EventHandler(this.dataUser_SelectionChanged);
            // 
            // UserID
            // 
            this.UserID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.UserID.HeaderText = "UserID";
            this.UserID.Name = "UserID";
            this.UserID.ReadOnly = true;
            // 
            // FirstName
            // 
            this.FirstName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FirstName.HeaderText = "FirstName";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // MiddleName
            // 
            this.MiddleName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.MiddleName.HeaderText = "MiddleName";
            this.MiddleName.Name = "MiddleName";
            this.MiddleName.ReadOnly = true;
            // 
            // LastName
            // 
            this.LastName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LastName.HeaderText = "LastName";
            this.LastName.Name = "LastName";
            this.LastName.ReadOnly = true;
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(1035, 462);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(301, 26);
            this.txtName.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(940, 467);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 18);
            this.label3.TabIndex = 37;
            this.label3.Text = "Name";
            // 
            // txtUserID
            // 
            this.txtUserID.Enabled = false;
            this.txtUserID.Location = new System.Drawing.Point(1035, 414);
            this.txtUserID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(301, 26);
            this.txtUserID.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(940, 418);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 18);
            this.label2.TabIndex = 35;
            this.label2.Text = "User ID";
            // 
            // btnBorrow
            // 
            this.btnBorrow.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnBorrow.Location = new System.Drawing.Point(1128, 534);
            this.btnBorrow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(125, 39);
            this.btnBorrow.TabIndex = 34;
            this.btnBorrow.Text = "Borrow";
            this.btnBorrow.UseVisualStyleBackColor = true;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            // 
            // btnClear
            // 
            this.btnClear.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnClear.Location = new System.Drawing.Point(975, 534);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(123, 39);
            this.btnClear.TabIndex = 33;
            this.btnClear.Text = "Clear Cart";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // dataBooks
            // 
            this.dataBooks.AllowUserToAddRows = false;
            this.dataBooks.AllowUserToDeleteRows = false;
            this.dataBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookID1,
            this.Title1,
            this.Quantity1});
            this.dataBooks.Location = new System.Drawing.Point(68, 75);
            this.dataBooks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataBooks.Name = "dataBooks";
            this.dataBooks.ReadOnly = true;
            this.dataBooks.Size = new System.Drawing.Size(356, 539);
            this.dataBooks.TabIndex = 30;
            this.dataBooks.SelectionChanged += new System.EventHandler(this.dataBooks_SelectionChanged);
            this.dataBooks.Click += new System.EventHandler(this.dataBooks_Click);
            // 
            // BookID1
            // 
            this.BookID1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BookID1.HeaderText = "BookID";
            this.BookID1.Name = "BookID1";
            this.BookID1.ReadOnly = true;
            // 
            // Title1
            // 
            this.Title1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Title1.HeaderText = "Title";
            this.Title1.Name = "Title1";
            this.Title1.ReadOnly = true;
            // 
            // Quantity1
            // 
            this.Quantity1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Quantity1.HeaderText = "Quantity";
            this.Quantity1.Name = "Quantity1";
            this.Quantity1.ReadOnly = true;
            // 
            // frm_borrowBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1539, 864);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Users);
            this.Controls.Add(this.dataCart);
            this.Controls.Add(this.dataUser);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBorrow);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.dataBooks);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_borrowBook";
            this.Text = "Borrow Book";
            this.Load += new System.EventHandler(this.frm_borrowBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Users;
        private System.Windows.Forms.DataGridView dataCart;
        private System.Windows.Forms.DataGridView dataUser;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBorrow;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.DataGridView dataBooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn MiddleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookID2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookID1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity1;
    }
}
namespace LibraryManagementSystem
{
    partial class frm_adminmenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.borrowBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBookToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addBookSupplyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookSupplyReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bookBorrowReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageMembersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataCurrentStocks = new System.Windows.Forms.DataGridView();
            this.BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Available = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCurrentStocks)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.reportToolStripMenuItem,
            this.manageMembersToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1214, 80);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listOfBookToolStripMenuItem,
            this.borrowBookToolStripMenuItem,
            this.returnBookToolStripMenuItem,
            this.addBookToolStripMenuItem,
            this.addBookSupplyToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Padding = new System.Windows.Forms.Padding(4, 0, 9, 0);
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(131, 74);
            this.fileToolStripMenuItem.Text = "Manage Books";
            // 
            // listOfBookToolStripMenuItem
            // 
            this.listOfBookToolStripMenuItem.Name = "listOfBookToolStripMenuItem";
            this.listOfBookToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.listOfBookToolStripMenuItem.Text = "List of Books";
            this.listOfBookToolStripMenuItem.Click += new System.EventHandler(this.listOfBookToolStripMenuItem_Click);
            // 
            // borrowBookToolStripMenuItem
            // 
            this.borrowBookToolStripMenuItem.Name = "borrowBookToolStripMenuItem";
            this.borrowBookToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.borrowBookToolStripMenuItem.Text = "Borrow Book";
            this.borrowBookToolStripMenuItem.Click += new System.EventHandler(this.borrowBookToolStripMenuItem_Click);
            // 
            // returnBookToolStripMenuItem
            // 
            this.returnBookToolStripMenuItem.Name = "returnBookToolStripMenuItem";
            this.returnBookToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.returnBookToolStripMenuItem.Text = "Return Book";
            this.returnBookToolStripMenuItem.Click += new System.EventHandler(this.returnBookToolStripMenuItem_Click);
            // 
            // addBookToolStripMenuItem
            // 
            this.addBookToolStripMenuItem.Name = "addBookToolStripMenuItem";
            this.addBookToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.addBookToolStripMenuItem.Text = "Add Book Info";
            this.addBookToolStripMenuItem.Click += new System.EventHandler(this.addBookToolStripMenuItem_Click);
            // 
            // addBookSupplyToolStripMenuItem
            // 
            this.addBookSupplyToolStripMenuItem.Name = "addBookSupplyToolStripMenuItem";
            this.addBookSupplyToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.addBookSupplyToolStripMenuItem.Text = "Add Book Supply";
            this.addBookSupplyToolStripMenuItem.Click += new System.EventHandler(this.addBookSupplyToolStripMenuItem_Click);
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bookSupplyReportToolStripMenuItem,
            this.bookBorrowReportToolStripMenuItem});
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(67, 74);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // bookSupplyReportToolStripMenuItem
            // 
            this.bookSupplyReportToolStripMenuItem.Name = "bookSupplyReportToolStripMenuItem";
            this.bookSupplyReportToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.bookSupplyReportToolStripMenuItem.Text = "Book Supply Report";
            this.bookSupplyReportToolStripMenuItem.Click += new System.EventHandler(this.bookSupplyReportToolStripMenuItem_Click);
            // 
            // bookBorrowReportToolStripMenuItem
            // 
            this.bookBorrowReportToolStripMenuItem.Name = "bookBorrowReportToolStripMenuItem";
            this.bookBorrowReportToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.bookBorrowReportToolStripMenuItem.Text = "Book Borrow Report";
            this.bookBorrowReportToolStripMenuItem.Click += new System.EventHandler(this.bookBorrowReportToolStripMenuItem_Click);
            // 
            // manageMembersToolStripMenuItem
            // 
            this.manageMembersToolStripMenuItem.Name = "manageMembersToolStripMenuItem";
            this.manageMembersToolStripMenuItem.Size = new System.Drawing.Size(147, 74);
            this.manageMembersToolStripMenuItem.Text = "Manage Members";
            this.manageMembersToolStripMenuItem.Click += new System.EventHandler(this.manageMembersToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(75, 74);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // dataCurrentStocks
            // 
            this.dataCurrentStocks.AllowUserToAddRows = false;
            this.dataCurrentStocks.AllowUserToDeleteRows = false;
            this.dataCurrentStocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCurrentStocks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookID,
            this.Title,
            this.Available});
            this.dataCurrentStocks.Location = new System.Drawing.Point(426, 173);
            this.dataCurrentStocks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataCurrentStocks.Name = "dataCurrentStocks";
            this.dataCurrentStocks.ReadOnly = true;
            this.dataCurrentStocks.Size = new System.Drawing.Size(688, 431);
            this.dataCurrentStocks.TabIndex = 4;
            // 
            // BookID
            // 
            this.BookID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BookID.HeaderText = "BookID";
            this.BookID.Name = "BookID";
            this.BookID.ReadOnly = true;
            // 
            // Title
            // 
            this.Title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // Available
            // 
            this.Available.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Available.HeaderText = "Available";
            this.Available.Name = "Available";
            this.Available.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(422, 112);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Currently Available Books";
            // 
            // frm_adminmenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1214, 726);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataCurrentStocks);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_adminmenu";
            this.Text = "Admin Menu";
            this.Load += new System.EventHandler(this.frm_adminmenu_Load);
            this.Click += new System.EventHandler(this.frm_adminmenu_Click);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataCurrentStocks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listOfBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBookToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addBookSupplyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageMembersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bookSupplyReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem borrowBookToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataCurrentStocks;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Available;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem bookBorrowReportToolStripMenuItem;
    }
}
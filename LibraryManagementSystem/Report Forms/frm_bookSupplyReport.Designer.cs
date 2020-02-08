namespace LibraryManagementSystem
{
    partial class frm_bookSupplyReport
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
            this.dataCurrentStocks = new System.Windows.Forms.DataGridView();
            this.BookID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalSupply = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalBorrow = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataCurrentStocks)).BeginInit();
            this.SuspendLayout();
            // 
            // dataCurrentStocks
            // 
            this.dataCurrentStocks.AllowUserToAddRows = false;
            this.dataCurrentStocks.AllowUserToDeleteRows = false;
            this.dataCurrentStocks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCurrentStocks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BookID,
            this.Title,
            this.TotalSupply,
            this.TotalBorrow});
            this.dataCurrentStocks.Location = new System.Drawing.Point(84, 80);
            this.dataCurrentStocks.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataCurrentStocks.Name = "dataCurrentStocks";
            this.dataCurrentStocks.ReadOnly = true;
            this.dataCurrentStocks.Size = new System.Drawing.Size(1263, 780);
            this.dataCurrentStocks.TabIndex = 5;
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
            // TotalSupply
            // 
            this.TotalSupply.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.TotalSupply.HeaderText = "Total Supply";
            this.TotalSupply.Name = "TotalSupply";
            this.TotalSupply.ReadOnly = true;
            this.TotalSupply.Width = 116;
            // 
            // TotalBorrow
            // 
            this.TotalBorrow.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.TotalBorrow.HeaderText = "Total Borrow";
            this.TotalBorrow.Name = "TotalBorrow";
            this.TotalBorrow.ReadOnly = true;
            // 
            // frm_bookSupplyReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1420, 928);
            this.Controls.Add(this.dataCurrentStocks);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_bookSupplyReport";
            this.Text = "Supply Report";
            this.Load += new System.EventHandler(this.frm_bookSupplyReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataCurrentStocks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataCurrentStocks;
        private System.Windows.Forms.DataGridViewTextBoxColumn BookID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalSupply;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalBorrow;
    }
}
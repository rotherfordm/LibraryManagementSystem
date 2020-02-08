using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using LibraryManagementSystem.Report_Forms;

namespace LibraryManagementSystem
{
    public partial class frm_adminmenu : Form
    {

        #region  Sql Connection Initialization
        //starts connection to sql server
        SqlConnection con = DatabaseHandler.GetNewConnection();
        SqlCommand cmd;
        SqlDataReader rdr;
        #endregion

        public frm_adminmenu()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        

        private void addBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_addbook form = new frm_addbook();
            try
            {
                form.Show();
            }
            catch (InvalidOperationException)
            {
                form.Show();
            }
        }


        private void addBookSupplyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_addBookSupply form = new frm_addBookSupply();
            try
            {
                form.Show();
            }
            catch (InvalidOperationException)
            {
                form.Show();
            }
        }

        private void manageMembersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_manageMembers form = new frm_manageMembers();
            try
            {
                form.Show();
            }
            catch (InvalidOperationException)
            {
                form.Show();
            }
        }

        private void returnBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_returnedbooks form = new frm_returnedbooks();
            try
            {
                form.Show();
            }
            catch (InvalidOperationException)
            {
                form.Show();
            }
        }

        private void listOfBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_listOfBooks form = new frm_listOfBooks();
            try
            {
                form.Show();
            }
            catch (InvalidOperationException)
            {
                form.Show();
            }
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frm_login login = new frm_login();
            try
            {
                login.Show();
            }
            catch (InvalidOperationException)
            {
                login.Show();
            }
        }

        private void borrowBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_borrowBook form = new frm_borrowBook();
            form.Show();
        }

        private void bookSupplyReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_bookSupplyReport form = new frm_bookSupplyReport();
            form.Show();
        }


        private void frm_adminmenu_Load(object sender, EventArgs e)
        {
            LoadCurrentStocks();
        }

        private void LoadCurrentStocks() {

            con.Open();
            cmd = new SqlCommand(@"Select TotalBorrowTrans.BookID, Title, TSupply - TBorrow AS CurrentStocks FROM
            (SELECT BookID, sum(Quantity) AS TBorrow FROM BorrowingTransaction GROUP BY BookID) As TotalBorrowTrans
            INNER JOIN
            (SELECT BookID, sum(Supplies) AS TSupply FROM BookSupplyTransaction GROUP BY BookID) As TotalSupplyTrans
            INNER JOIN
            (SELECT BookID, Title FROM Books GROUP BY BookID, Title) AS NTotal
            ON NTotal.BookID = TotalSupplyTrans.BookID ON TotalBorrowTrans.BookID = NTotal.BookID", con);

            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                dataCurrentStocks.Rows.Add(rdr[0].ToString(),rdr[1].ToString(), rdr[2].ToString());
            }
            con.Close();


        }



        private void frm_adminmenu_Click(object sender, EventArgs e)
        {
            dataCurrentStocks.Rows.Clear();
            LoadCurrentStocks();
        }

        private void bookBorrowReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_borrowedBooksReport form = new frm_borrowedBooksReport();
            form.Show();
        }
    }
}

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

namespace LibraryManagementSystem.Report_Forms
{
    public partial class frm_borrowedBooksReport : Form
    {
        #region  Sql Connection Initialization
        //starts connection to sql server
        SqlConnection con = DatabaseHandler.GetNewConnection();
        SqlCommand cmd;
        SqlDataReader rdr;
        #endregion

        public frm_borrowedBooksReport()
        {
            InitializeComponent();
        }

        private void frm_borrowedBooks_Load(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand(@"SELECT BorrowTrans.BookID, BorrowTrans.UserID, NBooks.Title, BorrowTrans.Quantity
            FROM
            (SELECT BookID, UserID, SUM(Quantity) AS Quantity FROM BorrowingTransaction GROUP BY BookID, UserID) AS BorrowTrans
            INNER JOIN
            (SELECT BookID, Title FROM Books GROUP BY BookID, Title) AS NBooks
            on NBooks.BookID = BorrowTrans.BookID", con);

            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                if (rdr[1].ToString() != "")
                {
                    dataBorrow.Rows.Add(rdr[0].ToString(), rdr[1].ToString(), rdr[2].ToString(), rdr[3].ToString());
                }
                
            }
            con.Close();
        }
    }
}

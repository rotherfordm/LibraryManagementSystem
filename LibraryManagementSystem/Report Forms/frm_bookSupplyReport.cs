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

namespace LibraryManagementSystem
{
    public partial class frm_bookSupplyReport : Form
    {
        #region  Sql Connection Initialization
        //starts connection to sql server
        SqlConnection con = DatabaseHandler.GetNewConnection();
        SqlCommand cmd;
        SqlDataReader rdr;
        #endregion

        public frm_bookSupplyReport()
        {
            InitializeComponent();
        }

        private void frm_bookSupplyReport_Load(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand(@"
			Select TotalBorrowTrans.BookID, Title, TotalSupply, TotalBorrows FROM
            (SELECT BookID, sum(Quantity) AS TotalBorrows FROM BorrowingTransaction GROUP BY BookID) As TotalBorrowTrans
            INNER JOIN
            (SELECT BookID, sum(Supplies) AS TotalSupply FROM BookSupplyTransaction GROUP BY BookID) As TotalSupplyTrans
            INNER JOIN
            (SELECT BookID, Title FROM Books GROUP BY BookID, Title) AS NTotal
            ON NTotal.BookID = TotalSupplyTrans.BookID ON TotalBorrowTrans.BookID = NTotal.BookID", con);

            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                dataCurrentStocks.Rows.Add(rdr[0].ToString(), rdr[1].ToString(), rdr[2].ToString(),rdr[3].ToString());
            }
            con.Close();
        }
    }
}

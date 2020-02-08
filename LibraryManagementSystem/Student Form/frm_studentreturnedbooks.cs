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

namespace LibraryManagementSystem.Student_Form
{
    public partial class frm_studentreturnedbooks : Form
    {


        #region  Sql Connection Initialization
        //starts connection to sql server
        SqlConnection con = DatabaseHandler.GetNewConnection();
        SqlCommand cmd;
        SqlDataReader rdr;
        #endregion


        public frm_studentreturnedbooks()
        {
            InitializeComponent();
        }

        private void frm_studentreturnedbooks_Load(object sender, EventArgs e)
        {
            con.Open();
            cmd = new SqlCommand(@"SELECT ReturnBookTrans.BookID, ReturnBookTrans.UserID, NBooks.Title, ReturnBookTrans.BRTQuantity AS 'Books Returned'
            FROM
            (SELECT BookID, Title FROM Books GROUP BY BookID, Title) AS NBooks
            INNER JOIN
            (SELECT BookID, UserID, SUM(Quantity) AS BRTQuantity FROM BookReturnTransaction GROUP BY BookID, USERID) AS ReturnBookTrans
            on NBooks.BookID = ReturnBookTrans.BookID
            Where ReturnBookTrans.UserID = '"+frm_login.setValueForUserID+"' ", con);

            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                if (rdr[1].ToString() != "")
                {
                    data_ReturnedBooks.Rows.Add(rdr[0].ToString(), rdr[1].ToString(), rdr[2].ToString(), rdr[3].ToString());
                }

            }
        }
    }
}

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
    public partial class frm_returnedbooks : Form
    {
        #region  Sql Connection Initialization
        //starts connection to sql server
        SqlConnection con = DatabaseHandler.GetNewConnection();
        SqlCommand cmd;
        SqlDataReader rdr;
        #endregion

        public frm_returnedbooks()
        {
            InitializeComponent();
        }

        private void LoadUser() {
            con.Open();
            cmd = new SqlCommand(@"SELECT UserID, FirstName, MiddleName, LastName FROM Users", con);

            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                dataUser.Rows.Add(rdr[0].ToString(), rdr[1].ToString() + " " + rdr[2].ToString() + " " + rdr[3].ToString());
            }
            con.Close();

            int startValue = 0;
            txtQuantity.Text = startValue.ToString();
        }


        private void btn_returnbook_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtQuantity.Text) <= int.Parse(dataBorrow.SelectedRows[0].Cells[3].Value.ToString()))
            {
                con.Open();

                cmd = new SqlCommand(@"INSERT INTO BookReturnTransaction
                         (BookID,Quantity,UserID)
                         VALUES 
                         ('" + int.Parse(lblBookID.Text) + "','" + txtQuantity.Text + "','"+lblUserID.Text+"')", con);
                cmd.ExecuteNonQuery();

                con.Close();
                dataBorrow.Rows.Clear();
                MessageBox.Show("Congrats, Returned!", "Congrats");


            }

        }

        private void frm_returnedbooks_Load(object sender, EventArgs e)
        {
            LoadUser();
        }

        private void dataUser_SelectionChanged(object sender, EventArgs e)
        {
            if (dataUser.SelectedRows.Count != 0)
            {
                dataBorrow.Rows.Clear();
                int user_id = int.Parse(dataUser.SelectedRows[0].Cells[0].Value.ToString());


                con.Open();
                cmd = new SqlCommand(@"SELECT BorrowTrans.UserID, BorrowTrans.BookID, NBooks.Title, BorrowTrans.Quantity
                FROM
                (SELECT BookID, UserID, SUM(Quantity) AS Quantity FROM BorrowingTransaction GROUP BY BookID, UserID) AS BorrowTrans
                INNER JOIN
                (SELECT BookID, Title FROM Books GROUP BY BookID, Title) AS NBooks
                on NBooks.BookID = BorrowTrans.BookID
                Where BorrowTrans.UserID = '" + user_id+"'  ", con);

                rdr = cmd.ExecuteReader();
                while (rdr.Read())
                {
                    dataBorrow.Rows.Add(rdr[0].ToString(), rdr[1].ToString(), rdr[2].ToString(),rdr[3].ToString());
                }
                con.Close();
            }
        }

        private void dataBorrow_SelectionChanged(object sender, EventArgs e)
        {
            if (dataBorrow.SelectedRows.Count != 0)
            {
                lblBookID.Text = dataBorrow.SelectedRows[0].Cells[1].Value.ToString();
                lblUserID.Text = dataUser.SelectedRows[0].Cells[0].Value.ToString();
                txtQuantity.Text = dataBorrow.SelectedRows[0].Cells[3].Value.ToString();


            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (dataBorrow.SelectedRows.Count != 0 && txtQuantity.Text != "")
            {
                if (int.Parse(txtQuantity.Text) > int.Parse(dataBorrow.SelectedRows[0].Cells[3].Value.ToString()))
                {
                    MessageBox.Show("Value cannot be more than amount borrowed", "Error");
                    txtQuantity.Clear();
                    return;
                }
                else {
                    return;
                }
            }
        }
    }
}

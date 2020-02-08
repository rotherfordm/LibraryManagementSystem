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
    public partial class frm_addBookSupply : Form
    {
        #region  Sql Connection Initialization
        //starts connection to sql server
        SqlConnection con = DatabaseHandler.GetNewConnection();
        SqlCommand cmd;
        SqlDataReader rdr;
        #endregion

        public frm_addBookSupply()
        {
            InitializeComponent();
        }

        private void frm_addBookSupply_Load(object sender, EventArgs e)
        {
            loadBooks();
        }

        private void loadBooks() {
            con.Open();
            cmd = new SqlCommand(@"SELECT BookID, ISBN, Category, Title, Author FROM Books", con);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                dataBook.Rows.Add(rdr[0].ToString(), rdr[1].ToString(), rdr[2].ToString(),
                    rdr[3].ToString(), rdr[4].ToString());
            }
            con.Close();
        }

        private void dataBook_SelectionChanged(object sender, EventArgs e)
        {
            if (dataBook.SelectedRows.Count != 0)
            {
                lbl_BookID.Text =
                     dataBook.SelectedRows[0].Cells[0].Value.ToString();
                lbl_ISBN.Text =
                     dataBook.SelectedRows[0].Cells[1].Value.ToString();
                lbl_Category.Text =
                     dataBook.SelectedRows[0].Cells[2].Value.ToString();
                lbl_Title.Text =
                     dataBook.SelectedRows[0].Cells[3].Value.ToString();
                lbl_Author.Text =
                     dataBook.SelectedRows[0].Cells[4].Value.ToString();
            }

        }

        private void btn_AddSupply_Click(object sender, EventArgs e)
        {
            if (txtQuantity.Text != "" && lbl_BookID.Text != "" )
            {
                con.Open();

                cmd = new SqlCommand(@"INSERT INTO BookSupplyTransaction
                         (BookID,Supplies)
                         VALUES 
                         ('" + int.Parse(lbl_BookID.Text) + "','" + txtQuantity.Text + "')", con);
                cmd.ExecuteNonQuery();

                cmd = new SqlCommand(@"INSERT INTO BorrowingTransaction
                         (BookID,Quantity)
                         VALUES 
                         ('" + int.Parse(lbl_BookID.Text) + "','0')", con);
                cmd.ExecuteNonQuery();


                con.Close();

                MessageBox.Show("Congrats, Added!", "Congrats");
            }
            else {
                MessageBox.Show("Input Error", "Error");
            }
      
        }
    }
}

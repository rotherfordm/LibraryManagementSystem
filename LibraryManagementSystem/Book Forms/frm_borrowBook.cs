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
    public partial class frm_borrowBook : Form
    {

        #region  Sql Connection Initialization
        //starts connection to sql server
        SqlConnection con = DatabaseHandler.GetNewConnection();
        SqlCommand cmd;
        SqlDataReader rdr;
        #endregion

        public frm_borrowBook()
        {
            InitializeComponent();
        }

        private void loadBooks() {
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
                dataBooks.Rows.Add(rdr[0].ToString(), rdr[1].ToString(), rdr[2].ToString());
            }

            con.Close();
        }

        private void loadUsers() {
            con.Open();
            cmd = new SqlCommand(@"SELECT UserID, FirstName, MiddleName, LastName FROM Users", con);
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                dataUser.Rows.Add(rdr[0].ToString(), rdr[1].ToString(), rdr[2].ToString(), rdr[3].ToString()); 
            }
            
            con.Close();
        }

        private void btnAddCart_Click(object sender, EventArgs e)
        {

        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataCart.SelectedRows)
            {
                if (!row.IsNewRow)
                    dataCart.Rows.Remove(row);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            dataCart.Rows.Clear();
            dataBooks.Rows.Clear();
            dataUser.Rows.Clear();
            txtName.Clear();
            txtUserID.Clear();
            loadBooks();
            loadUsers();
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {

            if (dataCart.RowCount.ToString() != "")
            {
                con.Open();

                for (int x = 0; x < dataCart.Rows.Count; x++)
                {
                    cmd = new SqlCommand(@"INSERT INTO BorrowingTransaction
                        (BookID, UserID, Quantity)
                        Values
                        ('" + dataCart.Rows[x].Cells[0].Value.ToString() + "','"
                    + txtUserID.Text + "','"
                    + dataCart.Rows[x].Cells[2].Value.ToString() + "')", con);

                    cmd.ExecuteNonQuery();
                }

                con.Close();
                MessageBox.Show("Transaction Sucessful", "Success");
            }

            else
            {
                MessageBox.Show("Input Error", "Error");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dataCart.Rows.Clear();
        }

        private void frm_borrowBook_Load(object sender, EventArgs e)
        {
            loadBooks();
            loadUsers();

        }

        private void dataBooks_SelectionChanged(object sender, EventArgs e)
        {
            /*
            //This simply adds selected books to cart
            
            if (dataBooks.SelectedRows.Count != 0)
            {
                bool exist = false;
                int currentQuantity = int.Parse(dataBooks.SelectedRows[0].Cells[2].Value.ToString());

                if (currentQuantity > 0) //Checks if the quantity of the currently selected book if greater than 0
                {
                    for (int i = 0; i < dataCart.Rows.Count; i++) // search the cart if it exist
                    {
                        for (int j = 0; j < dataCart.Columns.Count; j++)
                        {
                            if (dataCart.Rows[i].Cells[0].Value != null && dataBooks.SelectedRows[0].Cells[0].Value.ToString() == dataCart.Rows[i].Cells[0].Value.ToString())
                            {
                                //if it exist then increment the one in the cart then decrement the one in the databook
                                exist = true;
                                int quantity = 1;
                                string squantity;

                                squantity = dataCart.Rows[i].Cells[2].Value.ToString();
                                quantity += Int32.Parse(squantity);
                                squantity = quantity.ToString();

                                dataCart.Rows[i].Cells[2].Value = quantity;

                                currentQuantity = currentQuantity - 1;
                                dataBooks.SelectedRows[0].Cells[2].Value = currentQuantity.ToString();

                                break;
                            }
                        }
                    }
                    if (exist == false) // adds a new row if the book does not exist in the cart
                    {
                        dataCart.Rows.Add(dataBooks.SelectedRows[0].Cells[0].Value.ToString(),
                            dataBooks.SelectedRows[0].Cells[1].Value.ToString(), 1);
                    }
                }

                if (currentQuantity == 0) 
                {
                    MessageBox.Show("Error no more available books", "Error");
                }
            }
            */
        }

        private void dataBooks_Click(object sender, EventArgs e)
        {
            //This simply adds selected books to cart

            if (dataBooks.SelectedRows.Count != 0)
            {
                bool exist = false;
                int currentQuantity = int.Parse(dataBooks.SelectedRows[0].Cells[2].Value.ToString());

                if (currentQuantity > 0) //Checks if the quantity of the currently selected book if greater than 0
                {
                    for (int i = 0; i < dataCart.Rows.Count; i++) // search the cart if it exist
                    {
                        for (int j = 0; j < dataCart.Columns.Count; j++)
                        {
                            if (dataCart.Rows[i].Cells[0].Value != null && dataBooks.SelectedRows[0].Cells[0].Value.ToString() == dataCart.Rows[i].Cells[0].Value.ToString())
                            {
                                //if it exist then increment the one in the cart then decrement the one in the databook
                                exist = true;
                                int quantity = 1;
                                string squantity;

                                squantity = dataCart.Rows[i].Cells[2].Value.ToString();
                                quantity += Int32.Parse(squantity);
                                squantity = quantity.ToString();

                                dataCart.Rows[i].Cells[2].Value = quantity;

                                currentQuantity = currentQuantity - 1;
                                dataBooks.SelectedRows[0].Cells[2].Value = currentQuantity.ToString();

                                break;
                            }
                        }
                    }
                    if (exist == false) // adds a new row if the book does not exist in the cart
                    {
                        dataCart.Rows.Add(dataBooks.SelectedRows[0].Cells[0].Value.ToString(),
                            dataBooks.SelectedRows[0].Cells[1].Value.ToString(), 1);
                        currentQuantity = currentQuantity - 1;
                        dataBooks.SelectedRows[0].Cells[2].Value = currentQuantity.ToString();
                    }
                }

                if (currentQuantity == 0)
                {
                    MessageBox.Show("Error no more available books", "Error");
                }
            }
        }

        private void dataUser_SelectionChanged(object sender, EventArgs e)
        {
            if (dataUser.SelectedRows.Count != 0)
            {
                txtUserID.Text =
                    dataUser.SelectedRows[0].Cells[0].Value.ToString();
                txtName.Text =
                    dataUser.SelectedRows[0].Cells[1].Value.ToString() +" "+ dataUser.SelectedRows[0].Cells[2].Value.ToString() + " " + dataUser.SelectedRows[0].Cells[3].Value.ToString(); 
              
            }
        }
    }
}

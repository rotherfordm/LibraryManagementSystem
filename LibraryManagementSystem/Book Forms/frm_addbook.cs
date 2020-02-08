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
    public partial class frm_addbook : Form
    {

        #region  Sql Connection Initialization
        //starts connection to sql server
        SqlConnection con = DatabaseHandler.GetNewConnection();
        SqlCommand cmd;
        SqlDataReader rdr;
        #endregion

        public frm_addbook()
        {
            InitializeComponent();
        }

        private void Reset() {
            EnableAddButton();
            txtAbstract.Clear();
            txtAuthor.Clear();
            txtBookTitle.Clear();
            txtCategory.Clear();
            txtISBN.Clear();
            txtBookID.Clear();
        }

        private void DisableAddButton() {
            btn_AddBook.Enabled = false;
            btn_EditBook.Enabled = true;
        }

        private void EnableAddButton() {
            btn_AddBook.Enabled = true;
            btn_EditBook.Enabled = false;
        }

        private bool isTextBoxEmpty(TextBox input_text)
        {
            //checks if textbox is empty
            bool output;
            if (input_text.Text == "")
            {
                output = true;
            }
            else
            {
                output = false;
            }
            return output;
        }

        private bool checkTextBoxes() {
            //accepts
            bool output;
            output = isTextBoxEmpty(txtAbstract) || isTextBoxEmpty(txtAuthor) || isTextBoxEmpty(txtBookTitle) ||
            isTextBoxEmpty(txtCategory) || isTextBoxEmpty(txtISBN);
            return output;
        }

        private void btn_AddBook_Click(object sender, EventArgs e)
        {
            if (txtBookTitle.Text == "" || txtISBN.Text == "" || txtCategory.Text == "" || txtAbstract.Text == "" || txtAuthor.Text == "")
            {
                MessageBox.Show("Missing Inputs","Error");
            }
            else {
                con.Open();
                cmd = new SqlCommand(@"INSERT INTO Books
                      (ISBN, Category, Title, Author, Abstract) 
                       VALUES
                       ('" + txtISBN.Text + "','" + txtCategory.Text + "','" + txtBookTitle.Text + "'," +
                "'" + txtAuthor.Text + "','" + txtAbstract.Text + "')", con);

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Added Book", "Congrats");
            }

            Reset();
            dataBook.Rows.Clear();
            LoadBooks();
        }

        private void btn_EditBook_Click(object sender, EventArgs e)
        {
            if (txtBookTitle.Text == "" || txtISBN.Text == "" || txtCategory.Text == "" || txtAbstract.Text == "" || txtAuthor.Text == "")
            {
                
                MessageBox.Show("Missing Inputs", "Error");
            }
            else
            {
                con.Open();
                cmd = new SqlCommand(@"update Books
                    set ISBN = '" + txtISBN.Text + "', Category = '" + txtCategory.Text + "',Title = '" + txtBookTitle.Text + "',Author = '" + txtAuthor.Text
                                 + "',Abstract = '" + txtAbstract.Text + "' where BookID = '" + txtBookID.Text + "' ", con);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Edit Saved", "Congrats");
            }

            Reset();
            dataBook.Rows.Clear();
            LoadBooks();
            EnableAddButton();
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            Reset();
            EnableAddButton();
        }

        private void txt_Search_TextChanged(object sender, EventArgs e)
        {

        }

        private void frm_addbook_Load(object sender, EventArgs e)
        {
            LoadBooks();
            EnableAddButton();
        }

        private void LoadBooks() {
            con.Open();
            cmd = new SqlCommand(@"SELECT BookID, ISBN, Category, Title, Author, Abstract FROM Books", con);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                dataBook.Rows.Add(rdr[0].ToString(), rdr[1].ToString(), rdr[2].ToString(),
                    rdr[3].ToString(), rdr[4].ToString(), rdr[5].ToString());
            }
            con.Close();

        }

        private void dataBook_SelectionChanged(object sender, EventArgs e)
        {
            DisableAddButton();

            if (dataBook.SelectedRows.Count != 0)
            {
                txtBookID.Text =
                     dataBook.SelectedRows[0].Cells[0].Value.ToString();
                txtISBN.Text =
                     dataBook.SelectedRows[0].Cells[1].Value.ToString();
                txtCategory.Text =
                     dataBook.SelectedRows[0].Cells[2].Value.ToString();
                txtBookTitle.Text =
                     dataBook.SelectedRows[0].Cells[3].Value.ToString();
                txtAuthor.Text =
                      dataBook.SelectedRows[0].Cells[4].Value.ToString();
                txtAbstract.Text =
                     dataBook.SelectedRows[0].Cells[5].Value.ToString();
            }

          
        }
    }
}

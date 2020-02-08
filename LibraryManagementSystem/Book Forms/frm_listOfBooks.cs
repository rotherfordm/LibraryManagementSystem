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
    public partial class frm_listOfBooks : Form
    {

        #region  Sql Connection Initialization
        //starts connection to sql server
        SqlConnection con = DatabaseHandler.GetNewConnection();
        SqlCommand cmd;
        SqlDataReader rdr;
        #endregion


        public frm_listOfBooks()
        {
            InitializeComponent();
        }

        private void LoadBooks() {
            con.Open();
            cmd = new SqlCommand(@"SELECT BookID, Title, Author, Title, Abstract, Category FROM Books", con);
            rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                dataListOfBooks.Rows.Add(rdr[0].ToString(), rdr[1].ToString(), rdr[2].ToString(),
                    rdr[3].ToString(), rdr[4].ToString(), rdr[5].ToString());
            }
            con.Close();
        }

        private void frm_listOfBooks_Load(object sender, EventArgs e)
        {
            LoadBooks();
        }
    }
}

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
    public partial class frm_studentregistration : Form
    {

        #region  Sql Connection Initialization
        //starts connection to sql server
        SqlConnection con = DatabaseHandler.GetNewConnection();
        SqlCommand cmd;
        SqlDataReader rdr;
        #endregion

        public frm_studentregistration()
        {
            InitializeComponent();
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
            bool output;
            output = isTextBoxEmpty(txtFirstName) || isTextBoxEmpty(txtLastName) || isTextBoxEmpty(txtMiddleName) ||
            isTextBoxEmpty(txtEmail) || isTextBoxEmpty(txtContactNumber) || isTextBoxEmpty(txtAddress);
            return output;
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {

            if (checkTextBoxes())
            {
                MessageBox.Show("You have Missing Values!");
                return;
            }
            else {
                //add to database
                con.Open();
                cmd = new SqlCommand(@"INSERT INTO Users
                      (FirstName, MiddleName, LastName, Address, ContactNumber, Email, UserName, Password ,IsAdmin) 
                       VALUES
                       ('" + txtFirstName.Text + "','" + txtMiddleName.Text + "','" + txtLastName.Text + "'," +
                "'" + txtContactNumber.Text + "','" + txtAddress.Text + "', '" + txtContactNumber.Text + "'" +
                ",'" + txtUsername.Text + "', '" + txtPassword.Text + "', '0')", con);

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Registered Successfully!");
            }

  
        }
    }
}

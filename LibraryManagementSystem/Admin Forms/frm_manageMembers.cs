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
    public partial class frm_manageMembers : Form
    {

        #region  Sql Connection Initialization
        //starts connection to sql server
        SqlConnection con = DatabaseHandler.GetNewConnection();
        SqlCommand cmd;
        SqlDataReader rdr;
        #endregion

        public frm_manageMembers()
        {
            InitializeComponent();
            //CheckBoxAdminChecked();
        }

        private void Reset() {
            dataMembers.Rows.Clear();
            txtPassword.Clear();
            txtUsername.Clear();
            txtAddress.Clear();
            txtContactNumber.Clear();
            txtEmail.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            txtMiddleName.Clear();
            txtUserID.Clear();
            checkbox_admin.Checked = false;
            EnableAddButton();
            LoadMembers();
        }

        private void CheckBoxAdminChecked()
        {
            if (checkbox_admin.Checked)
            {
                txtUsername.Enabled = true;
                txtPassword.Enabled = true;
            }
            else
            {
                txtUsername.Enabled = false;
                txtPassword.Enabled = false;

            }
        }

        private void checkbox_admin_CheckedChanged(object sender, EventArgs e)
        {
            //CheckBoxAdminChecked();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
         
            Reset();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

            int admin;
            if (checkbox_admin.Checked == true)
            {
                admin = 1;
            }
            else
            {
                admin = 0;
            }


            con.Open();
            cmd = new SqlCommand(@"update Users
                    set FirstName = '" + txtFirstName.Text + "',MiddleName = '" + txtMiddleName.Text
            + "',LastName='" + txtLastName.Text + "',ContactNumber = '" + txtContactNumber.Text + "'"
            + ",Email = '" + txtEmail.Text + "',Address = '" + txtAddress.Text + "', Username = '" + txtUsername.Text
            + "', Password = '" + txtPassword.Text + "', IsAdmin = '" + admin + "' where UserID = '" + txtUserID.Text + "' ", con);

            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Edit Sucessful", "Success");

            dataMembers.Rows.Clear();
            Reset();
        }

        private bool isTextBoxEmpty(TextBox input_text) {
            //checks if textbox is empty
            bool output;
            if (input_text.Text == "")
            {
                output = true;
            } else
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //if admin

            if (checkbox_admin.Checked.Equals(true))
            {
                if (txtUsername.Text == "" || txtPassword.Text == "")
                {
                    MessageBox.Show("You have Missing Values","Error");
                    return;
                }

                if (checkTextBoxes())
                {
                    MessageBox.Show("You have Missing Values!","Error");
                    return;
                }

                con.Open();
                cmd = new SqlCommand(@"INSERT INTO Users
                      (FirstName, MiddleName, LastName, ContactNumber, Address, Email, UserName, Password ,IsAdmin) 
                       VALUES
                       ('" + txtFirstName.Text + "','" + txtMiddleName.Text + "','" + txtLastName.Text + "'," +
                "'" + txtContactNumber.Text + "','" + txtAddress.Text + "', '" + txtEmail.Text + "'" +
                ",'" + txtUsername.Text + "', '" + txtPassword.Text + "', '1')", con);

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Congrats, Added!", "Congrats");



            }



            //if not admin
            if (checkbox_admin.Checked.Equals(false))
            {
               
                if (checkTextBoxes())
                {
                    MessageBox.Show("You have Missing Values!");
                    return;
                }

                //add to database
                con.Open();
                cmd = new SqlCommand(@"INSERT INTO Users
                    (FirstName, MiddleName, LastName, Address, ContactNumber, Email, UserName, Password, IsAdmin) 
                       VALUES
                       ('" + txtFirstName.Text + "','" + txtMiddleName.Text + "','" + txtLastName.Text + "'," +
                    "'" + txtAddress.Text + "','" + txtContactNumber.Text + "', '" + txtEmail.Text + "'" +
                    ", '"+txtUsername.Text+"','"+txtPassword.Text+"','" + '0' + "')", con);
                
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Congrats, Added!", "Congrats");

            }
            
            Reset();
        }

        private void LoadMembers()
        {
            con.Open();
            cmd = new SqlCommand(@"SELECT UserID, FirstName, MiddleName, Lastname, Address, ContactNumber, Email, isAdmin FROM Users", con);
            
            rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                string isadmin= "";
                if (rdr[7].ToString() == "1") { isadmin = "Yes";  } else if (rdr[7].ToString() == "0") { isadmin = "No";  }

                dataMembers.Rows.Add(rdr[0].ToString(), rdr[1].ToString(), rdr[2].ToString(),
                    rdr[3].ToString(), rdr[4].ToString(), rdr[5].ToString(), rdr[6].ToString(), isadmin);
            }
            con.Close();

            EnableAddButton();
        }

        private void frm_manageMembers_Load(object sender, EventArgs e)
        {
            
            LoadMembers();
        }

        private void dataMembers_SelectionChanged(object sender, EventArgs e)
        {

            
            if (dataMembers.SelectedRows.Count != 0)
            {
                txtUserID.Text =
                     dataMembers.SelectedRows[0].Cells[0].Value.ToString();
                txtFirstName.Text =
                     dataMembers.SelectedRows[0].Cells[1].Value.ToString();
                txtMiddleName.Text =
                     dataMembers.SelectedRows[0].Cells[2].Value.ToString();
                txtLastName.Text =
                     dataMembers.SelectedRows[0].Cells[3].Value.ToString();
                txtAddress.Text =
                      dataMembers.SelectedRows[0].Cells[4].Value.ToString();
                txtContactNumber.Text =
                     dataMembers.SelectedRows[0].Cells[5].Value.ToString();
                txtEmail.Text =
                     dataMembers.SelectedRows[0].Cells[6].Value.ToString();

                if (dataMembers.SelectedRows[0].Cells[7].Value.ToString() == "Yes")
                {
                    checkbox_admin.Checked = true;
                }
                else
                {
                    checkbox_admin.Checked = false;
                }
                DisableAddButton();
            }

            if (checkbox_admin.Checked == true) {

                con.Open();
                cmd = new SqlCommand(@"SELECT UserName, Password FROM Users WHERE UserID = '"+txtUserID.Text+"' ", con);
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    txtUsername.Text = rdr[0].ToString();
                    txtPassword.Text = rdr[1].ToString();
                }

                con.Close();

            }

        }

        private void DisableAddButton() {
            btnAdd.Enabled = false;
            btnEdit.Enabled = true;
        }

        private void EnableAddButton()
        {
            btnAdd.Enabled = true;
            btnEdit.Enabled = false;
        }

    }
}

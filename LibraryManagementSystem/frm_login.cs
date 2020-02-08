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
    public partial class frm_login : Form
    {
        public static string setValueForUserID;
        public static string setValueForUserName;

        #region  Sql Connection Initialization
        //starts connection to sql server
        SqlConnection con = DatabaseHandler.GetNewConnection();
        SqlCommand cmd;
        SqlDataReader rdr;
        #endregion


        public frm_login()
        {
            InitializeComponent();
            txt_Password.PasswordChar = '*';
        }

        private void btn_login_Click(object sender, EventArgs e)
        {


            //simple login authentication system
            //password is in plaintext
            //could be hashed then sent to database
            //but for simplicity plain-text should be
            //good enough.

            if (txt_Password.Text == "" || txt_Username.Text == "")
            {
                MessageBox.Show("Invalid Input!", "Error");
                return;
            }
            else
            {

                #region Check If User Exist
                string Exist = "";
                con.Open();
                cmd = new SqlCommand(@"(
                SELECT CASE WHEN EXISTS (
                SELECT * FROM Users
                WHERE Username = '" + txt_Username.Text + "'  AND Password = '" + txt_Password.Text + "') " +
                " THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END)", con);
                rdr = cmd.ExecuteReader();

                while (rdr.Read())
                {
                    Exist = rdr[0].ToString();
                }
                con.Close();

                #endregion

                if (Exist == "True")
                {
                    string IsAdmin = "";
                    con.Open();
                    cmd = new SqlCommand(@"(
                    SELECT CASE WHEN EXISTS 
                    (
                    SELECT * FROM Users
                    Where Username = '" + txt_Username.Text + "' AND Password = '" + txt_Password.Text
                        + "' AND IsAdmin = 1)  THEN CAST(1 AS BIT) ELSE CAST(0 AS BIT) END)", con);
                    rdr = cmd.ExecuteReader();

                    while (rdr.Read())
                    {
                        IsAdmin = rdr[0].ToString();
                    }
                    con.Close();


                    if (IsAdmin == "True")
                    {
                        frm_adminmenu form = new frm_adminmenu();
                        this.Visible = false;
                        form.Show();
                        return;
                    }

                    if (IsAdmin == "False")
                    {
                        frm_studentmenu form = new frm_studentmenu();
                        con.Open();
                        cmd = new SqlCommand(@"SELECT Users.UserID, FirstName + ' ' + MiddleName +' '+ LastName AS FullName  FROM Users where Users.UserName = '"+txt_Username.Text+"'", con);

                        rdr = cmd.ExecuteReader();
                        while (rdr.Read())
                        {
                            if (rdr[1].ToString() != "")
                            {
                                setValueForUserID = rdr[0].ToString();
                                setValueForUserName = rdr[1].ToString();
                            }

                            this.Visible = false;
                            form.Show();
                            
                        }
                    }

                    else
                    {
                        MessageBox.Show("Invalid Credentials", "Error");
                        txt_Username.Clear();
                        txt_Password.Clear();
                    }
                }
            }
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            frm_studentregistration studregform = new frm_studentregistration();
            studregform.Show();
        }

        private void lbl_title_Click(object sender, EventArgs e)
        {

        }
    }
}




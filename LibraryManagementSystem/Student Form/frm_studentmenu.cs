using LibraryManagementSystem.Student_Form;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class frm_studentmenu : Form
    {

        public static string setValueForUserID;
       
        public frm_studentmenu()
        {
            InitializeComponent();
            setValueForUserID = lbl_studentID.Text;
        }

        private void listOfBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_listOfBooks form = new frm_listOfBooks();
            form.Show();
        }

        private void borrowedBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_studentborrowedbook form = new frm_studentborrowedbook();
            form.Show();
        }

        private void returnedBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_studentreturnedbooks form = new frm_studentreturnedbooks();
            form.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Dispose();
            frm_login login = new frm_login();
            login.Show();
        }

        private void frm_studentmenu_Load(object sender, EventArgs e)
        {
            lbl_StudentName.Text = frm_login.setValueForUserName;
            lbl_studentID.Text = frm_login.setValueForUserID;
        }
    }
}

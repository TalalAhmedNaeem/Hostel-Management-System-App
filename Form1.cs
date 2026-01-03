using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostel_Management_System_GUI_App__
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnSignIn_Click_1(object sender, EventArgs e)
        {
            string correctUsername = "Admin";
            string correctPassword = "pass";

            if (txtUsername.Text == correctUsername && txtPassword.Text == correctPassword)
            {
                this.Hide();
                Form2 ds = new Form2();
                ds.Show();
            }
            else
            {
                lblErrorMessage.Text = "Wrong username or password!";
                txtPassword.Clear();
            }
            
        }
        private void BackgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
           
        }

        private void lblErrorMessage_Click(object sender, EventArgs e)
        {

        }    
    }
}

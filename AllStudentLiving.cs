using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace Hostel_Management_System_GUI_App__
{
    public partial class AllStudentLiving : Form
    {
        Function fn = new Function();

        public AllStudentLiving()
        {
            InitializeComponent();
        }

        private void AllStudentLiving_Load(object sender, EventArgs e)
        {
            this.Location = new Point(250, 150);
            string query = "select * from newStudent where living = 'Yes'";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
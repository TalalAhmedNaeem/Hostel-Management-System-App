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

    public partial class LeavedStudents : Form
    {
        Function fn = new Function();

        public LeavedStudents()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LeavedStudents_Load(object sender, EventArgs e)
        {
            this.Location = new Point(250, 150);
            String query = "select * from newStudent where living = 'No' ";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];

        }
    }
}

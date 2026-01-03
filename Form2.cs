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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            fm.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        Boolean LabelVisible = true;
        private void timer1_Tick(object sender, EventArgs e)
        {
             if(LabelVisible==true)
            {
                hmsLabel.Visible = true;
                LabelVisible = false;
            }
            else
            {
                hmsLabel.Visible = false;
                LabelVisible = true;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            this.Location = new Point(100, 50);
            timer1.Enabled = true;
            timer1.Start();
        }

        private void btnManageRooms_Click(object sender, EventArgs e)
        {
            AddNewRooms anr = new AddNewRooms();
            anr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            NewStudent ns = new NewStudent();
            ns.Show();
        }

        private void btnUpdateDeleteStudent_Click(object sender, EventArgs e)
        {
            UpdateDeleteStudent uds = new UpdateDeleteStudent();
            uds.Show();
        }

        private void btnStudentFees_Click(object sender, EventArgs e)
        {
            StudentFees sf = new StudentFees();
            sf.Show();
        }

        private void btnAllStudentLiving_Click(object sender, EventArgs e)
        {
            AllStudentLiving asl = new AllStudentLiving();
            asl.Show();
        }

        private void btnLeavedStudents_Click(object sender, EventArgs e)
        {
            LeavedStudents ls = new LeavedStudents();
            ls.Show();
        }
    }
}

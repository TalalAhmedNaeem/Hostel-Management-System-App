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
    public partial class AddNewRooms : Form
    {
        Function fn = new Function();
        String query;


        public AddNewRooms()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void AddNewRooms_Load(object sender, EventArgs e)
        {
            this.Location = new Point(250, 170);
            labelRoomExist1.Visible = false;
            labelRoomExist2.Visible = false;

            query = "select * from allroom";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelRoomExist1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            //100
            query = "select * from allroom where roomNo = "+txtRoomNo1.Text+"";
            DataSet ds = fn.getData(query);

            if (ds.Tables[0].Rows .Count==0)
            {
                String status;
                
                if(checkBox1.Checked)
                {
                    status = "Yes";
                }
                else
                {
                    status = "No";
                }
                labelRoomExist1.Visible = false;
                query = "insert into allroom (roomNo,roomStatus) values(" + txtRoomNo1.Text + ",'" + status + "') ";
                fn.setData(query,"Room Added.");
                AddNewRooms_Load(this, null);
            }
            else
            {
                labelRoomExist1.Text = "Room All Ready Exist.";
                labelRoomExist1.Visible = true; 
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            query = "select * from allroom where roomNo ="+txtRoomNo2.Text+"";
            DataSet ds = fn.getData(query);


            if (ds.Tables[0].Rows.Count==0)
            {
                labelRoomExist2.Text = "No Room Exist.";
                labelRoomExist2.Visible = true;
                checkBox2.Checked = false;
            }
            else
            {
                labelRoomExist2.Text = "Room Found.";
                labelRoomExist2.Visible = true;
                if (ds.Tables[0].Rows[0][1].ToString()=="Yes")
                {
                    checkBox2.Checked = true;
                }
                else
                {
                    checkBox2.Checked = false;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            String status;
            if(checkBox2.Checked)
            {
                status = "Yes";
            }
            else
            {
                status = "No";
            }
            query = "update allroom set rooStatus='" + status + "' where roomNo = " + txtRoomNo2.Text + "";
            fn.setData(query, "Details Updated.");
            AddNewRooms_Load(this, null);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(labelRoomExist2.Text=="Room Found.")
            {
                query = "delete from allroom where roomNo=" + txtRoomNo2.Text + "";
                fn.setData(query, "Room Details Deleted.");
                AddNewRooms_Load(this, null);
            }
            else
            {
                MessageBox.Show("Trying to delete which doesn't Exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

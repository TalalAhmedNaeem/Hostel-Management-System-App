using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hostel_Management_System_GUI_App__
{
    public partial class StudentFees : Form
    {
        Function fn = new Function();
        String query;

        public StudentFees()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StudentFees_Load(object sender, EventArgs e)
        {
            this.Location = new Point(250, 150);
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "MMMM yyyy";

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
           if(txtMobile.Text != "")
           {
                query = "select name,email,roomNo from newStudent where mobile =" + txtMobile.Text + " ";
                DataSet ds = fn.getData(query);

                if (ds.Tables[0].Rows.Count != 0)
                {
                    txtName.Text = ds.Tables[0].Rows[0][0].ToString();
                    txtEmailId.Text = ds.Tables[0].Rows[0][1].ToString();
                    txtRoomNo.Text = ds.Tables[0].Rows[0][2].ToString();
                    setDataGrid(Int64.Parse(txtMobile.Text));
                }
                else
                {
                    MessageBox.Show("No Record Exists", "Information",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
           }
        }


        public void setDataGrid(Int64 mobile)
        {
            query = "select * from fees where mobileNo = " +mobile+ "";
            DataSet ds = fn.getData(query);
            dataGridView1.DataSource = ds.Tables[0];

        }


        private void btnPay_Click(object sender, EventArgs e)
        {
            if (txtMobile.Text != "" && txtAmount.Text != "")
            {
                query = "select * from fees where mobileNo = " + long.Parse(txtMobile.Text) + " and fmonth = '" + dateTimePicker.Text + "'";
                DataSet ds = fn.getData(query);
                if (ds.Tables[0].Rows.Count == 0)
                {
                    long mobile = long.Parse(txtMobile.Text);
                    string month = dateTimePicker.Text;
                    long amount = long.Parse(txtAmount.Text);
                    query = "insert into fees values(" + mobile + ",'" + month + "'," + amount + ")";
                    fn.setData(query, "Fees Paid.");
                    clearAll();
                }
            }
            else
            {
                MessageBox.Show("No dues of" + dateTimePicker.Text + "left.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }

        public void clearAll()
        {
            txtMobile.Clear();
            txtName.Clear();
            txtAmount.Clear();
            txtRoomNo.Clear();
            txtEmailId.Clear();
            dataGridView1.DataSource = 0;
        }
    }
}

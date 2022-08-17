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

namespace BookBiz_Managment_System
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void LogBut_Click(object sender, EventArgs e)
        {
            string strcon = "Data Source=MRLAPTOP;Initial Catalog=Bookbiz;Integrated Security=True";
            SqlConnection con = new SqlConnection(strcon);
            SqlCommand com = new SqlCommand("prlogin", con);
            com.CommandType = System.Data.CommandType.StoredProcedure;
            SqlParameter sp1 = new SqlParameter("fullname", comboBoxname.Text);
            SqlParameter sp2 = new SqlParameter("password", textBoxPass.Text);
            SqlParameter sp3 = new SqlParameter("users", comboBoxCarrier.Text);

            com.Parameters.Add(sp1);
            com.Parameters.Add(sp2);
            com.Parameters.Add(sp3);

            con.Open();
            SqlDataReader dr = com.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                lblmsg.Text = "Login successful.";
                lblmsg.Visible = true;
               if (comboBoxname.Text == "Henry Brown" && comboBoxCarrier.Text == "MIS Manager")
              // if (true)
                {
                    Form f = new Manager();
                    f.ShowDialog();
                }
                else if (comboBoxname.Text == "Thomas Moore" && comboBoxCarrier.Text == "Sales Manager")
                {
                    Form f1 = new salemanager();
                    f1.ShowDialog();
                }
                else if (comboBoxname.Text == "Peter Wang" && comboBoxCarrier.Text == "Inventory Controller")
                {
                    Form f2 = new Inventorycontroller();
                    f2.ShowDialog();
                }
                else
                {
                    Form f3 = new clerk();
                    f3.ShowDialog();
                }
            }
            else
            {
                lblmsg.Text = "Invalid username or password.";
                lblmsg.Visible = true;
            }
          

            

        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

      

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_2(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

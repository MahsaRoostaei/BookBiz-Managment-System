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
    public partial class clerk : Form
    {//connection string
        string strcon = "Data Source=MRLAPTOP;Initial Catalog=Bookbiz;Integrated Security=True";
        string g;
        string s;
        public clerk()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM order_tb ";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        //Add button 
        private void butadd_Click(object sender, EventArgs e)
        {//radio button for order by
            if (radioButton3.Checked == true)
            {
                g = "Phone";
            }
            else if(radioButton2.Checked == true)
            {
                g = "fax";
            }else
            {
                g = "Email";
            }
            //for status is cancel or not
            if (radioButton4.Checked == true)
            {
                s = "Cancel";
            }



            {  //validation for empty textbox

                if (textBox1.Text != "" && textBox2.Text != "")
                {


                    try
                    {
                        SqlConnection con = new SqlConnection(strcon);
                        if (con.State == ConnectionState.Closed)
                        {
                            con.Open();
                        }
                        SqlCommand cmd = new SqlCommand(" INSERT INTO order_tb(client_name,orderby,payment,title,status) values(@client_name,@orderby,@payment,@title,@status)", con);
                        cmd.Parameters.AddWithValue("@payment", comboBox1.Text.Trim());
                        cmd.Parameters.AddWithValue("@client_name", textBox1.Text.Trim());
                        cmd.Parameters.AddWithValue("@orderby",g);
                        cmd.Parameters.AddWithValue("@title", textBox2.Text.Trim());
                        cmd.Parameters.AddWithValue("@status", s);

                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("book information Created sucsessfully. ");
                        

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("" + ex.Message + "");
                    }
                }
                else
                {
                    MessageBox.Show("You need to fill all the fields");
                }

            }
        }
        //Exit button
        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Are you sure to exit the application?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        // Search button with validation  
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM order_tb WHERE client_name='" + comboBoxSearchuser.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                if (dt.Rows.Count <= 0)
                {
                    MessageBox.Show("Client could not found");
                }
                else
                {
                    dataGridView1.DataSource = dt;
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message + "");

            }
           
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

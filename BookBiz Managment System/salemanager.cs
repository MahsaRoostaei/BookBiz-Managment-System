using BookBiz_Managment_System.validation;
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
    public partial class salemanager : Form
    {//connection string
        string strcon = "Data Source=MRLAPTOP;Initial Catalog=Bookbiz;Integrated Security=True";

        public object Response { get; private set; }

        public salemanager()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        //  method add client
        private void button1_Click(object sender, EventArgs e)
        {

            if (checkClientExists())
            {

                MessageBox.Show("Client Already Exist with this Name, try other Name");
            }
            else
            {
                addNewClient();
            }
        }

        //  method check the client exits or not
        bool checkClientExists()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("SELECT * from college_uni_tb where client_name='" + textBox14.Text.Trim() + "';", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count >= 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message + "");
                return false;
            }
        } //  method add client
        void addNewClient()
        {//validation for phone number and client_name 
            if ((Validator.IsValidID(textBox10, 10)) && (Validator.IsValidName(textBox14)))

            {//validation for filling all the fields
                if (textBox14.Text != "" && textBox10.Text != "" && textBox9.Text != "" && textBox8.Text != "")
                {
                    try
                    {
                        SqlConnection con = new SqlConnection(strcon);
                        if (con.State == ConnectionState.Closed)
                        {
                            con.Open();
                        }
                        SqlCommand cmd = new SqlCommand(" INSERT INTO college_uni_tb(client_name,Street,city,postalcode,phonenumber,faxnumber,creditlimite) values(@client_name,@Street,@city,@postalcode,@phonenumber,@faxnumber,@creditlimite)", con);
                        cmd.Parameters.AddWithValue("@client_name", textBox14.Text.Trim());
                        cmd.Parameters.AddWithValue("@Street", textBox13.Text.Trim());
                        cmd.Parameters.AddWithValue("@city", textBox12.Text.Trim());
                        cmd.Parameters.AddWithValue("@postalcode", textBox11.Text.Trim());
                        cmd.Parameters.AddWithValue("@phonenumber", Convert.ToInt32(textBox10.Text.Trim()));
                        cmd.Parameters.AddWithValue("@faxnumber", Convert.ToInt32(textBox9.Text.Trim()));
                        cmd.Parameters.AddWithValue("@creditlimite", textBox8.Text.Trim());

                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Client information Created sucsessfully.");


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
        private void textBox14_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxSearchuser_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        // Search button with validation  
        private void button2_Click(object sender, EventArgs e)
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
                cmd.CommandText = "SELECT * FROM college_uni_tb WHERE client_name='" + textBox1.Text + "'";
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
                    GridResultclient.DataSource = dt;
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message + "");

            }

        }
       
    

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        //list button 
        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strcon);
            con.Open();

            
            SqlCommand cmd = con.CreateCommand();

            
            cmd.CommandType = CommandType.Text;

           
            cmd.CommandText = "SELECT * FROM college_uni_tb ";

          
            cmd.ExecuteNonQuery();



            DataTable dt = new DataTable();

    
            SqlDataAdapter da = new SqlDataAdapter(cmd);

           
            da.Fill(dt);

            
            GridResultclient.DataSource = dt;

            
            con.Close();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
        //Exit button
        private void button4_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Are you sure to exit the application?", "Confirmation",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}

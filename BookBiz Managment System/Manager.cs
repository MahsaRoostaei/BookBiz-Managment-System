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
    public partial class Manager : Form
    {    //connection string
        string strcon = "Data Source=MRLAPTOP;Initial Catalog=Bookbiz;Integrated Security=True";
        public Manager()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        //going to salemanager window
        private void button8_Click(object sender, EventArgs e)
        {
            Form f1 = new salemanager();
            f1.ShowDialog();
        }
        //going to Inventorycontroller window
        private void button7_Click(object sender, EventArgs e)
        {
            Form f2 = new Inventorycontroller();
            f2.ShowDialog();
        }
        //Add button can add users to the Db
        private void button1_Click(object sender, EventArgs e)
        {
            if (checkClientExists())
            {

                MessageBox.Show("user Already Exist with this Name, try other Name");
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
                SqlCommand cmd = new SqlCommand("SELECT * from users_table where fullname='" + textBox1.Text.Trim() + "';", con);
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
        }
        //  method add client
        void addNewClient()
        {//validation for password and fullname and career
            if ((Validator.IsValidID(textBox2, 4)) && (Validator.IsValidName(textBox1)) && (Validator.IsValidName(textBox3)))
            {
                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "")
                {
                    try
                    {
                        SqlConnection con = new SqlConnection(strcon);
                        if (con.State == ConnectionState.Closed)
                        {
                            con.Open();
                        }
                        SqlCommand cmd = new SqlCommand(" INSERT INTO users_table(fullname,users,password) values(@fullname,@users,@password)", con);
                        cmd.Parameters.AddWithValue("@fullname", textBox1.Text.Trim());
                        cmd.Parameters.AddWithValue("@users", textBox3.Text.Trim());
                        cmd.Parameters.AddWithValue("@password", textBox2.Text.Trim());

                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Users information Created sucsessfully.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("" + ex.Message + "");
                    }
                }
                else
                {
                    MessageBox.Show("alert('You need to fill all the fields");
                }
            }
        }
        //list button bring all columns of user to the front 
        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strcon);
            con.Open();

            SqlCommand cmd = con.CreateCommand();


            cmd.CommandType = CommandType.Text;


            cmd.CommandText = "SELECT * FROM users_table ";


            cmd.ExecuteNonQuery();



            DataTable dt = new DataTable();


            SqlDataAdapter da = new SqlDataAdapter(cmd);


            da.Fill(dt);


            dataGridView2.DataSource = dt;


            con.Close();
        }
        // Search button with validation 
        private void button3_Click(object sender, EventArgs e)
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
                cmd.CommandText = "SELECT * FROM users_table WHERE fullname='" + textBox7.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                if (dt.Rows.Count <= 0 )
                {
                    MessageBox.Show("user could not found");
                }
                else
                {
                    dataGridView2.DataSource = dt;
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message + "");
               
            }
            
        }

        //Add button can add users to the Db
        private void button6_Click(object sender, EventArgs e)
        {
            if (checkemployeeExists())
            {

                MessageBox.Show("Employee Already Exist with this Name, try other Name");
            }
            else
            {
                addNewEmployee();
            }
        }

        //  method
        bool checkemployeeExists()
        {
            try
            {
                SqlConnection con = new SqlConnection(strcon);
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand cmd = new SqlCommand("SELECT * from employee_tb where fullname='" + textBox4.Text.Trim() + "';", con);
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
        }   //  method add
        void addNewEmployee()
        {
            if ((Validator.IsValidID(textBox6, 5)) && (Validator.IsValidName(textBox5)) && (Validator.IsValidName(textBox4)))

            {
                if (textBox4.Text != "" && textBox5.Text != "" && textBox6.Text != "")
                {


                    try
                    {
                        SqlConnection con = new SqlConnection(strcon);
                        if (con.State == ConnectionState.Closed)
                        {
                            con.Open();
                        }
                        SqlCommand cmd = new SqlCommand(" INSERT INTO employee_tb(fullname,carrier,password) values(@fullname,@carrier,@password)", con);
                        cmd.Parameters.AddWithValue("@fullname", textBox4.Text.Trim());
                        cmd.Parameters.AddWithValue("@carrier", textBox5.Text.Trim());
                        cmd.Parameters.AddWithValue("@password", textBox6.Text.Trim());


                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("Employee information Created sucsessfully. ");

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
        } //list button bring all columns of employee table to the front 
        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strcon);
            con.Open();


            SqlCommand cmd = con.CreateCommand();


            cmd.CommandType = CommandType.Text;


            cmd.CommandText = "SELECT * FROM employee_tb ";


            cmd.ExecuteNonQuery();



            DataTable dt = new DataTable();


            SqlDataAdapter da = new SqlDataAdapter(cmd);


            da.Fill(dt);


            dataGridView2.DataSource = dt;


            con.Close();
        }
        // Search button with validation 
        private void button4_Click(object sender, EventArgs e)
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
                cmd.CommandText = "SELECT * FROM employee_tb WHERE fullname='" + textBox8.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                if (dt.Rows.Count <= 0)
                {
                    MessageBox.Show("Employee could not found");
                }
                else
                {
                    dataGridView2.DataSource = dt;
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message + "");

            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
        //Exit button
        private void button10_Click(object sender, EventArgs e)
        {

            DialogResult answer = MessageBox.Show("Are you sure to exit the application?", "Confirmation",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        //move to clerk window
        private void button9_Click(object sender, EventArgs e)
        {
            Form f3 = new clerk();
            f3.ShowDialog();
        }
    }
    }


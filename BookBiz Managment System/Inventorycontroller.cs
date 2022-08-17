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
    public partial class Inventorycontroller : Form
    {//connection string
        string strcon = "Data Source=MRLAPTOP;Initial Catalog=Bookbiz;Integrated Security=True";
        public Inventorycontroller()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        //Add button
        private void butadd_Click(object sender, EventArgs e)
        {
            {
                if (checkBookExists())
                {

                    MessageBox.Show("Book Already Exist with this Name, try other Name");
                }
                else
                {
                    addNewBook();
                }
            }

            // book defined method
            bool checkBookExists()
            {
                try
                {
                    SqlConnection con = new SqlConnection(strcon);
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    }
                    SqlCommand cmd = new SqlCommand("SELECT * from book_tb where title='" + textBox1.Text.Trim() + "';", con);
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
            } //  method add book
            void addNewBook()
            {
                

                if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
                {


                    try
                    {
                        SqlConnection con = new SqlConnection(strcon);
                        if (con.State == ConnectionState.Closed)
                        {
                            con.Open();
                        }
                        SqlCommand cmd = new SqlCommand(" INSERT INTO book_tb(title,uniteprice,yearpublished,quantityonhand,author_name,publisher_name) values(@title,@uniteprice,@yearpublished,@quantityonhand,@author_name,@publisher_name)", con);
                        cmd.Parameters.AddWithValue("@title", textBox1.Text.Trim());
                        cmd.Parameters.AddWithValue("@uniteprice", textBox2.Text.Trim());
                        cmd.Parameters.AddWithValue("@yearpublished", textBox3.Text.Trim());
                        cmd.Parameters.AddWithValue("@quantityonhand", textBox4.Text.Trim());
                        cmd.Parameters.AddWithValue("@author_name", textBox8.Text.Trim());
                        cmd.Parameters.AddWithValue("@publisher_name", textBox10.Text.Trim());


                        cmd.ExecuteNonQuery();
                        con.Close();
                        MessageBox.Show("book information Created sucsessfully. ");
                        con.Open();

                        SqlCommand cmd2 = new SqlCommand(" INSERT INTO author_tb(author_name,email) values(@author_name,@email)", con);
                        cmd2.Parameters.AddWithValue("@author_name", textBox8.Text.Trim());
                        cmd2.Parameters.AddWithValue("@email", textBox4.Text.Trim());
                        
                         cmd2.ExecuteNonQuery();
                         con.Close();
                         con.Open();

                        SqlCommand cmd3 = new SqlCommand(" INSERT INTO publisher_tb(publisher_name) values(@publisher_name)", con);
                        cmd3.Parameters.AddWithValue("@publisher_name", textBox10.Text.Trim());
                        cmd3.ExecuteNonQuery();


                        con.Close();

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
                cmd.CommandText = "SELECT * FROM book_tb WHERE title='" + textBox9.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                if (dt.Rows.Count <= 0)
                {
                    MessageBox.Show("Book could not found,plz enter valid name");
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
        //list button
        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(strcon);
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "SELECT * FROM book_tb";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void inventorycontroller_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

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
    } 

}

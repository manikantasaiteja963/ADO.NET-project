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

namespace adoproject
{
    public partial class Form9 : Form
    {

        SqlConnection con=new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\BHARGAVI\\Documents\\stulogindetails.mdf;Integrated Security=True;Connect Timeout=30");
        public Form9()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {
                for (int i = 0; i < 10; i++)
                {
                    try
                    {
                        if (textBox1.Text != "")
                        {
                            con.Open();
                            SqlCommand cmd = new SqlCommand("update stuinfo set fname=@fname where uname=@uname", con);
                            cmd.Parameters.AddWithValue("@fname", textBox1.Text);
                            cmd.Parameters.AddWithValue("@uname", textBox2.Text);
                            cmd.ExecuteNonQuery();
                            con.Close();

                        }
                        else if (textBox3.Text != "")
                        {
                            con.Open();
                            SqlCommand cmd = new SqlCommand("update stuinfo set password=@password where uname=@uname", con);
                            cmd.Parameters.AddWithValue("@password", textBox3.Text);
                            cmd.Parameters.AddWithValue("@uname", textBox2.Text);
                            cmd.ExecuteNonQuery();
                            con.Close();                         
                        }

                        else if (textBox5.Text != "")
                        {
                            con.Open();
                            SqlCommand cmd = new SqlCommand("update stuinfo set study=@study where uname=@uname", con);
                            cmd.Parameters.AddWithValue("@study", textBox5.Text);
                            cmd.ExecuteNonQuery();
                            con.Close();


                        }
                        else if (textBox6.Text != "")
                        {
                            con.Open();
                            SqlCommand cmd = new SqlCommand("update stuinfo set gmail=@gmail where uname=@uname", con);
                            cmd.Parameters.AddWithValue("@gmail", textBox6.Text);
                            cmd.Parameters.AddWithValue("@uname", textBox2.Text);
                            cmd.ExecuteNonQuery();
                            con.Close();


                        }
                        else if (textBox7.Text != "")
                        {
                            con.Open();
                            SqlCommand cmd = new SqlCommand("update stuinfo set phno=@phno where uname=@uname", con);
                            cmd.Parameters.AddWithValue("@phno", textBox7.Text);
                            cmd.Parameters.AddWithValue("@uname", textBox2.Text);
                            cmd.ExecuteNonQuery();
                            con.Close();


                        }
                        else if (textBox8.Text != "")
                        {
                            con.Open();
                            SqlCommand cmd = new SqlCommand("update stuinfo set address=@address where uname=@uname", con);
                            cmd.Parameters.AddWithValue("@address", textBox8.Text);
                            cmd.Parameters.AddWithValue("@uname", textBox2.Text);
                            cmd.ExecuteNonQuery();
                            con.Close();


                        }
                        else if (dateTimePicker1.Created == false)
                        {
                            con.Open();
                            SqlCommand cmd = new SqlCommand("update stuinfo set dob=@dob where uname=@uname", con);
                            cmd.Parameters.AddWithValue("@dob", dateTimePicker1.Text);
                            cmd.Parameters.AddWithValue("@uname", textBox2.Text);
                            cmd.ExecuteNonQuery();
                            con.Close();

                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
                MessageBox.Show("Data Updated", "UPDATE", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("ENTER USER NAME", "INVALLID USER", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("ENTER USER NAME FOR VIEW DETAILS", "INVALLID USER", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select * from stuinfo where uname='" + textBox2.Text + "'";
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                dataGridView1.DataSource = dt;
                con.Close();
            }
        }
        private void Form9_Load(object sender, EventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 f=new Form8();
            f.ShowDialog();       
        }
    }
}

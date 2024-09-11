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
    public partial class Form4 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\BHARGAVI\\Documents\\stulogindetails.mdf;Integrated Security=True;Connect Timeout=30");
        public Form4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from admin";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(textBox1.Text !="")
                {
                    if(textBox3.Text==textBox4.Text)
                    {
                        int v = check(textBox9.Text);
                        if (v != 1)
                        {
                            con.Open();
                            SqlCommand cmd = new SqlCommand("insert into stuinfo values(@fname,@uname,@password,@cid,@dob,@gender,@study,@gmail,@phno,@address)", con);
                            cmd.Parameters.AddWithValue("@fname", textBox1.Text);
                            cmd.Parameters.AddWithValue("@uname", textBox2.Text);
                            cmd.Parameters.AddWithValue("@password", textBox3.Text);
                            cmd.Parameters.AddWithValue("@cid", textBox5.Text);
                            cmd.Parameters.AddWithValue("@dob", Convert.ToDateTime(dateTimePicker1.Text));
                            cmd.Parameters.AddWithValue("@gender", comboBox1.Text);
                            cmd.Parameters.AddWithValue("@study", textBox6.Text);
                            cmd.Parameters.AddWithValue("@gmail", textBox7.Text);
                            cmd.Parameters.AddWithValue("@phno", int.Parse(textBox8.Text));
                            cmd.Parameters.AddWithValue("@address", textBox9.Text);
                            cmd.ExecuteNonQuery();
                            con.Close();
                            MessageBox.Show("RGISTER SUCCESSFULL", "register", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            textBox1.Text = "";
                            textBox2.Text = "";
                            textBox3.Text = "";
                            textBox4.Text = "";
                            textBox5.Text = "";
                            textBox6.Text = "";
                            textBox7.Text = "";
                            textBox8.Text = "";
                            textBox9.Text = "";
                            comboBox1.Text = "";
                        }
                        else
                        {
                            MessageBox.Show("You already Register", "INVALID INF", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Password Doesn't Match","INVALID INF", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("FILL ALL DETAILS", "INVALID INF", MessageBoxButtons.OK, MessageBoxIcon.Error);
           
                }
            }
            catch(Exception ex)
            {  MessageBox.Show(ex.Message); }
            finally
            {
                con.Close();
            }
        }
        int check(string gmail)
        {
            con.Open();
            string query = "select count(*) from stuinfo where gmail='" + gmail + "'";
            SqlCommand cmd = new SqlCommand(query,con);
            int v=(int)cmd.ExecuteScalar(); 
            con.Close();
            return v;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f= new Form3();
            f.ShowDialog();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from admin";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox1.DropDownStyle= ComboBoxStyle.DropDown; 
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

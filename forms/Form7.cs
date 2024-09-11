using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adoproject
{
    public partial class Form7 : Form
    {
        SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\BHARGAVI\\Documents\\stulogindetails.mdf;Integrated Security=True;Connect Timeout=30");
        public Form7()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("FILL ALL DETAILS","INVALID INF",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {

                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into admin  values(@cid, @cname,@cduration)", conn);
                cmd.Parameters.AddWithValue("@cid", textBox1.Text);
                cmd.Parameters.AddWithValue("@cname", textBox2.Text);
                cmd.Parameters.AddWithValue("@cduration", textBox3.Text);
                cmd.ExecuteNonQuery();
                conn.Close();   
                MessageBox.Show("COURSE ADDED", "VALID INF", MessageBoxButtons.OK, MessageBoxIcon.Information);
                displaydata();
            }
           /* Form18 f = new Form18();
            f.ShowDialog();
            this.Hide();*/
        }
        private void button3_Click(object sender, EventArgs e)
        {
            

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            displaydata();
        }
        public void displaydata()
        {
            conn.Open();
            SqlCommand cmd =conn.CreateCommand ();
            cmd.CommandType= CommandType.Text;
            cmd.CommandText = "select * from admin";
            cmd.ExecuteNonQuery();
            DataTable dt=new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill (dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("ENTER CID  OR CNAME ", "INVALID INF", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                conn.Open();
                SqlCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "delete from admin where cid='" + textBox1.Text + "' or cname='" + textBox2.Text + "'";
                cmd.ExecuteNonQuery();
                conn.Close();
                displaydata();
                MessageBox.Show("Delete successful","DELETE",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }

        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("ENTER CID", "INVALID INF", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                conn.Open();
                try
                {                   
                    SqlCommand cmd = new SqlCommand("update admin set cname=@cname,cduration=@cduration where cid=@cid", conn);
                    cmd.Parameters.AddWithValue("@cid", textBox1.Text);
                    cmd.Parameters.AddWithValue("@cname", textBox2.Text);
                    cmd.Parameters.AddWithValue("@cduration", textBox3.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                   
                    MessageBox.Show("DATA UPDATED","UPDATED",MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                   conn.Close() ;
                }
            }
          
        }
        private void button5_Click(object sender, EventArgs e)
        {         

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            Form6 f=new Form6();
            f.ShowDialog();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "" && textBox2.Text == "")
            {
                MessageBox.Show("ENTER CID  OR CNAME ", "INVALID INF", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                conn.Open();
                try
                {    
                    SqlCommand cmd = new SqlCommand("select * from admin where cid='" + textBox1.Text + "' or cname='" + textBox2.Text + "'", conn);
                    cmd.ExecuteNonQuery();
                    DataTable dt = new DataTable();
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(dt);
                    dataGridView1.DataSource = dt;
                    MessageBox.Show("DISPLAY ON DATA GRID VIEW ", "VALID INF", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                { MessageBox.Show(ex.Message);}
                finally { conn.Close(); }
            }
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 f = new Form6();
            f.ShowDialog();
        }
    }
}

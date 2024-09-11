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
    public partial class Form16 : Form
    {
        public Form16()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\BHARGAVI\\Documents\\stulogindetails.mdf;Integrated Security=True;Connect Timeout=30");
                conn.Open();
                SqlCommand cmd = new SqlCommand("insert into adminreg values(@name,@uname,@password,@cpassword,@dob,@gender,@qulification,@gmail,@phone,@address)", conn);
                cmd.Parameters.AddWithValue("@name", textBox1.Text);
                cmd.Parameters.AddWithValue("@uname", textBox2.Text);
                cmd.Parameters.AddWithValue("@password", textBox3.Text);
                cmd.Parameters.AddWithValue("@cpassword", textBox4.Text);
                cmd.Parameters.AddWithValue("@dob", dateTimePicker1.Text);
                cmd.Parameters.AddWithValue("@gender", comboBox1.Text);
                cmd.Parameters.AddWithValue("@qulification", textBox6.Text);
                cmd.Parameters.AddWithValue("@gmail", textBox7.Text);
                cmd.Parameters.AddWithValue("@phone", textBox8.Text);
                cmd.Parameters.AddWithValue("@address", textBox9.Text);
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("REGISTER SUCCESSFULL","VALID DETAILS",MessageBoxButtons.OK,MessageBoxIcon.None);
                Form5 f = new Form5();
                f.ShowDialog();
            }
            catch
            {
                MessageBox.Show("FILL ALL DETAILS ","INCORRECT FORMAT",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void Form16_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 form = new Form5();
            form.ShowDialog();
            this.Hide();
        }
    }
}

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
    public partial class Form18 : Form
    {
        public Form18()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\BHARGAVI\\Documents\\stulogindetails.mdf;Integrated Security=True;Connect Timeout=30");
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into cou values(@con)",conn);
            cmd.Parameters.AddWithValue("@con",textBox1.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("course added successfully","course",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Form7 f = new Form7();
            f.ShowDialog();
            this.Hide();

        }
    }
}

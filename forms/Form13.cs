using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace adoproject
{
    public partial class Form13 : Form
    {
        
        public Form13()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == textBox3.Text) 
            {
                try
                {
                    SqlConnection conn = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\BHARGAVI\\Documents\\stulogindetails.mdf;Integrated Security=True;Connect Timeout=30");
                    conn.Open();
                    SqlCommand cmd = new SqlCommand("update acredentials set apassword=@apassword where aid='1234'");
                    cmd.Parameters.AddWithValue("@apassword",textBox2.Text);
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    MessageBox.Show("PASSWORD CHANGED");
                }
                catch(Exception ex)  
                {
                    MessageBox.Show(ex.Message);
                }
                

            }
            else
            {
                MessageBox.Show("PASSWORD DOES NOT MATCH");
            }
        }
    }
}

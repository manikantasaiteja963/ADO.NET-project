using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace adoproject
{
        public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }
        public static string b;
        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text =="")
            {
                MessageBox.Show("ENTER YOUR NAME","Fill",MessageBoxButtons.OKCancel,MessageBoxIcon.Error);
            }
            else
            {

                /*label6.Text =textBox1.Text;
                label2.Enabled = true;
                label2.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;
                label7.Visible = true;
                label8.Visible = true;
                label9.Visible = true;*/
                b = textBox1.Text;
                Form17  f = new Form17();
                f.ShowDialog();
                this.Hide();
                
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form8 f=new Form8();
            f.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Form8 : Form
    {
        public Form8()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form9 f=new Form9();
            f.ShowDialog();         
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form11 form2 = new Form11();
            form2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form10 f=new Form10();
            f.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show("LOG OUT SUCCESSFUL","LOG OUT",MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.Hide();
            Form3 f=new Form3();
            f.ShowDialog();
           

        }
    }
}

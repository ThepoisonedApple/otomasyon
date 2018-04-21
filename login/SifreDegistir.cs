using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class SifreDegistir : Form
    {
        public SifreDegistir()
        {
            InitializeComponent();
            this.ActiveControl = this.panel1;
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            Form1 nextForm = new Form1();
            nextForm.Show();
            this.Dispose();
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            panel4.BackColor = Color.Gainsboro;
            panel6.BackColor = Color.DeepSkyBlue;
            if (textBox2.Text == "Şifre")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            panel4.BackColor = Color.White;
            panel6.BackColor = Color.White;
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Gainsboro;
            panel11.BackColor = Color.DeepSkyBlue;
            if (textBox3.Text == "Şifre Tekrar")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;
            }
        }
   

        private void textBox3_Leave(object sender, EventArgs e)
        {
            panel2.BackColor = Color.White;
            panel11.BackColor = Color.White;
        }
    }
}

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
    public partial class kayitol : Form
    {
        public kayitol()
        {
            InitializeComponent();
            this.ActiveControl = this.panel1;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel18_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            panel3.BackColor = Color.Gainsboro;
            panel12.BackColor = Color.DeepSkyBlue;
            if (textBox1.Text=="Kullanıcı Adı")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
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

        private void textBox5_Enter(object sender, EventArgs e)
        {
            panel13.BackColor = Color.Gainsboro;
            panel16.BackColor = Color.DeepSkyBlue;
            if (textBox5.Text == "Personel ID")
            {
                textBox5.Text = "";
                textBox5.ForeColor = Color.Black;
            }
        }

        private void comboBox2_Enter(object sender, EventArgs e)
        {
            panel14.BackColor = Color.Gainsboro;
            panel15.BackColor = Color.DeepSkyBlue;
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            panel17.BackColor = Color.Gainsboro;
            panel20.BackColor = Color.DeepSkyBlue;
            if (textBox4.Text == "Güvenlik sorusu cevabınız")
            {
                textBox4.Text = "";
                textBox4.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            panel3.BackColor = Color.White;
            panel12.BackColor = Color.White;
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            panel4.BackColor = Color.White;
            panel6.BackColor = Color.White;
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            panel2.BackColor = Color.White;
            panel11.BackColor = Color.White;
        }

        private void textBox5_Leave(object sender, EventArgs e)
        {
            panel13.BackColor = Color.White;
            panel16.BackColor = Color.White;
        }

        private void comboBox2_Leave(object sender, EventArgs e)
        {
            panel14.BackColor = Color.White;
            panel15.BackColor = Color.White;
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            panel17.BackColor = Color.White;
            panel20.BackColor = Color.White;
        }

        private void panel18_Click(object sender, EventArgs e)
        {
            Form1 nextForm = new Form1();
            nextForm.Show();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class SifremiUnuttum : Form
    {
        public SifremiUnuttum()
        {
            InitializeComponent();
            this.ActiveControl = this.panel1;
        }

        private void panel9_Click(object sender, EventArgs e)
        {
            Form1 nextForm = new Form1();
            nextForm.Show();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SifreDegistir nextForm = new SifreDegistir();
            nextForm.Show();
            this.Dispose();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            panel3.BackColor = Color.Gainsboro;
            panel12.BackColor = Color.DeepSkyBlue;
            if (textBox1.Text == "Kullanıcı Adı")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            panel3.BackColor = Color.White;
            panel12.BackColor = Color.White;
        }

        private void comboBox2_Enter(object sender, EventArgs e)
        {
            panel14.BackColor = Color.Gainsboro;
            panel15.BackColor = Color.DeepSkyBlue;
        }

        private void comboBox2_Leave(object sender, EventArgs e)
        {
            panel14.BackColor = Color.White;
            panel15.BackColor = Color.White;
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

        private void textBox4_Leave(object sender, EventArgs e)
        {
            panel17.BackColor = Color.White;
            panel20.BackColor = Color.White;
        }
    }
}

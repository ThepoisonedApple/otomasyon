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
        bool kadc = false, gsc = false;
        public static int kid;
        public SifremiUnuttum()
        {
            InitializeComponent();
            comboBox2.SelectedIndex = 0;
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
            if (kadc&&gsc)
            {
                SifreUnuttumClass sifredegis = new SifreUnuttumClass();
                kid = sifredegis.GuvenlikSoruCevap(textBox1.Text, comboBox2.Text, textBox4.Text);
                if (kid!=0)
                {
                    SifreDegistir nextForm = new SifreDegistir();
                    nextForm.Show();
                    this.Dispose();
                }
                
            }

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
            if (textBox1.Text == "")
            {
                panel3.BackColor = Color.FromArgb(218, 68, 83);
                kadc = false;
                MessageBox.Show("kullanıcı adını boş bırakamassınız.");
            }
            else if (textBox1.Text.Length < 6 || textBox1.Text.Length > 20)
            {
                panel3.BackColor = Color.FromArgb(218, 68, 83);
                kadc = false;
                MessageBox.Show("kullanıcı adınız en az 6 en çok 20 haneli olmalıdır.");
            }
            else kadc = true;

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
            if (textBox4.Text == "")
            {
                panel17.BackColor = Color.FromArgb(218, 68, 83);
                gsc = false;
                MessageBox.Show("Güvenlik sorusu cevabınızı");
            }
            else if (textBox4.Text.Length < 3)
            {
                panel17.BackColor = Color.FromArgb(218, 68, 83);
                gsc = false;
                MessageBox.Show("güvenlik sorusu cevabınız en az 4 haneli olmalıdır.");
            }
            else gsc = true;
        }



        private void Charkontrol(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetterOrDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
                MessageBox.Show("Lütfen İşaret veya Türkçe Karakter Kullanmayınız.");
            }
            string x = "şŞüÜğĞıİÇçöÖ";
            bool c = false;
            for (int i = 0; i < x.Length; i++)
            {
                if (x[i] == e.KeyChar)
                {
                    c = true;
                    break;
                }
            }
            if (c)
            {
                e.Handled = true;
                MessageBox.Show("Lütfen İşaret veya Türkçe Karakter Kullanmayınız.");
            }
        }

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}

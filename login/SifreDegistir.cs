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
        bool pwd1 = false, pwd2 = false;
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
                textBox2.UseSystemPasswordChar = true;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            panel4.BackColor = Color.White;
            panel6.BackColor = Color.White;
            if (textBox2.Text.Length < 8 || textBox2.Text.Length > 20)
            {
                panel4.BackColor = Color.FromArgb(218, 68, 83);
                pwd1 = false;
                MessageBox.Show("Şifreniz en az 8 en çok 20 karakterden oluşmalıdır.");
            }
            else pwd1 = true;
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            panel2.BackColor = Color.Gainsboro;
            panel11.BackColor = Color.DeepSkyBlue;
            if (textBox3.Text == "Şifre Tekrar")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;
                textBox3.UseSystemPasswordChar = true;
            }

        }
   

        private void textBox3_Leave(object sender, EventArgs e)
        {
            panel2.BackColor = Color.White;
            panel11.BackColor = Color.White;
            if (textBox3.Text.Length < 8 || textBox3.Text.Length > 20)
            {
                panel2.BackColor = Color.FromArgb(218, 68, 83);
                pwd2 = false;
                MessageBox.Show("Şifreniz en az 8 en çok 20 karakterden oluşmalıdır.");
            }
            else if (textBox3.Text != textBox2.Text)
            {
                panel2.BackColor = Color.FromArgb(218, 68, 83);
                pwd2 = false;
                MessageBox.Show("Şifreleriniz uyuşmamaktadır lütfen şifrenizi tekrar giriniz");
            }
            else pwd2 = true;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            if (pwd1&&pwd2)
            {
                KayitInsert md5hash = new KayitInsert();
                string newpw = md5hash.Hashing(textBox2.Text);
                SifreUnuttumClass degis = new SifreUnuttumClass();
                degis.SifreDegistirFonk(newpw,SifremiUnuttum.kid.ToString());
                MessageBox.Show("Şifreniz Başarıyla değiştirildi giriş ekranına yönlendiriliyorsunuz");
                Form1 nextForm = new Form1();
                nextForm.Show();
                this.Dispose();

            }
        }
    }
}

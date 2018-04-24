using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace login
{
    public partial class kayitol : Form
    {
        public bool Kontrol = false;
        public bool NK=false, PD=false, PDT=false, PID=false, GSC=false;

        public kayitol()
        {
            InitializeComponent();
            comboBox2.SelectedIndex = 0;
            this.ActiveControl = this.panel1;

        }

        public void charkontrol(KeyPressEventArgs e)
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
                textBox2.UseSystemPasswordChar = true;
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
                textBox3.UseSystemPasswordChar = true;
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
            int x=-1;
            panel3.BackColor = Color.White;
            panel12.BackColor = Color.White;
            if (textBox1.Text.Length < 6 || textBox1.Text.Length > 20)
            {
                panel3.BackColor = Color.FromArgb(218, 68, 83);
                NK = false;
                MessageBox.Show("Kullanıcı adınız en az 6 en çok 20 karakterden oluşmalıdır.");
            }
            else
            {
                KayitInsert kontrolkad = new KayitInsert();
                x =  kontrolkad.kadkontrol(textBox1.Text);
            }

            if (x!=0)
            {
                panel3.BackColor = Color.FromArgb(218, 68, 83);
                NK = false;
            }
            else NK = true;
            
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            panel4.BackColor = Color.White;
            panel6.BackColor = Color.White;
            if (textBox2.Text.Length < 8 || textBox2.Text.Length > 20)
            {
                panel4.BackColor = Color.FromArgb(218, 68, 83);
                PD = false;
                MessageBox.Show("Şifreniz en az 8 en çok 20 karakterden oluşmalıdır.");
            }
            else PD = true;
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            panel2.BackColor = Color.White;
            panel11.BackColor = Color.White;
            if (textBox3.Text.Length < 8 || textBox3.Text.Length > 20)
            {
                panel2.BackColor = Color.FromArgb(218, 68, 83);
                PDT = false;
                MessageBox.Show("Şifreniz en az 8 en çok 20 karakterden oluşmalıdır.");
            }
            else if (textBox3.Text != textBox2.Text)
            {
                panel2.BackColor = Color.FromArgb(218, 68, 83);
                PDT = false;
                MessageBox.Show("Şifreleriniz uyuşmamaktadır lütfen şifrenizi tekrar giriniz");
            }
            else PDT = true;

        }

        private void textBox5_Leave(object sender, EventArgs e)
        {

            panel13.BackColor = Color.White;
            panel16.BackColor = Color.White;
            if (textBox5.Text == "")
            {
                panel13.BackColor = Color.FromArgb(218, 68, 83);
                PID = false;
            }
            else if (textBox5.Text!="")
            {

                KayitInsert kontrol1 = new KayitInsert();
                Kontrol = kontrol1.PidKontrol(textBox5.Text);
                if (!Kontrol)
                {
                    panel13.BackColor = Color.FromArgb(218, 68, 83);
                    PID = false;
                }
                else PID = true;
            }
            

            
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
            if (textBox4.Text.Length < 4)
            {
                panel17.BackColor = Color.FromArgb(218, 68, 83);
                GSC = false;
            }
            else GSC = true;
        }

        private void panel18_Click(object sender, EventArgs e)
        {
            Form1 nextForm = new Form1();
            nextForm.Show();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        { bool CompleteKontrol = NK & PD & PDT & PID & GSC;
            if (CompleteKontrol)
            {
                string kad, sifre, pid, gs, gc;
                KayitInsert kaydol = new KayitInsert();
                kad = textBox1.Text;
                sifre = textBox2.Text;
                sifre = kaydol.Hashing(sifre);
                pid = textBox5.Text;
                gs = comboBox2.SelectedItem.ToString();
                gc = textBox4.Text;


                int x = kaydol.TakeID(pid);

                kaydol.InsertKullanici(kad, sifre, x.ToString(), gs, gc, pid);

                MessageBox.Show("Kaydınız tamamlanmıstır Giris sayfasına yönlendiriliyorsunuz");
                panel18_Click(sender,e);
            }
            else if (!NK) MessageBox.Show("Kullanıcı adınız hatalı veye eksik");
                else if (!PD) MessageBox.Show("Şifreniz hatalı veye eksik");
                    else if(!PDT) MessageBox.Show("Şifre tekrarınız hatalı veye eksik");
                        else if(!PID) MessageBox.Show("Kullanıcı id'niz hatalı veya eksik");
                            else if(!GSC) MessageBox.Show("Güvenlik sorusu cevabınız hatalı veye eksik");


        }

        private void KeyPressControl(object sender, KeyPressEventArgs e)
        {
            charkontrol(e);
        }

        private void comboBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}

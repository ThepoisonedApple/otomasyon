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
    public partial class Form1 : Form
    {

        #region Degiskenler ve main
        public static string KID;
        public string K_ad;
        public string K_pw;
        bool ka = false, pw = false;


        public Form1()
        {
            InitializeComponent();
            button1.FlatAppearance.BorderSize = 0;
            this.ActiveControl = this.panel1;
        }
        #endregion

        #region Karakter kontrol
        private void CharKontrol(object sender, KeyPressEventArgs e)
        {
            var textbox = (TextBox)sender;
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
            if (textbox.Name=="textBox2" && e.KeyChar==13)
            {
                if (textBox2.Text.Length < 6 || textBox2.Text.Length > 20)
                {
                    panel4.BackColor = Color.FromArgb(218, 68, 83);
                    pw = false;
                }
                else pw = true;
                button1_Click(this, new EventArgs());
            }

        }
        #endregion

        #region textbox events-controls
        private void textBox2_Enter(object sender, EventArgs e)
        {
            panel4.BackColor = Color.Gainsboro;
            panel6.BackColor = Color.DeepSkyBlue;
            if (textBox2.Text=="Şifre")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
                textBox2.UseSystemPasswordChar = true;
            }


        }
        
        private void textBox2_Leave(object sender, EventArgs e)
        {

            panel4.BackColor = Color.WhiteSmoke;
            panel6.BackColor = Color.WhiteSmoke;
            if (textBox2.Text.Length < 6 || textBox2.Text.Length > 20)
            {
                panel4.BackColor = Color.FromArgb(218, 68, 83);
                pw = false;
            }
            else pw = true;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            panel3.BackColor = Color.Gainsboro;
            panel5.BackColor = Color.DeepSkyBlue;
            if (textBox1.Text == "Kullanıcı Adı")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            panel3.BackColor = Color.WhiteSmoke;
            panel5.BackColor = Color.WhiteSmoke;
            if (textBox1.Text.Length < 6 || textBox1.Text.Length > 20)
            {
                panel3.BackColor = Color.FromArgb(218, 68, 83);
                ka = false;
            }
            else ka = true;
        }

        #endregion

        #region Onclicks

        private void button1_Click(object sender, EventArgs e)
        { bool tamkontrol = ka & pw;
            if (tamkontrol)
            {
                K_ad = textBox1.Text;
                K_pw = textBox2.Text;
                KayitInsert Kyt = new KayitInsert();
                K_pw = Kyt.Hashing(K_pw);
                LoginClass Baglan = new LoginClass();
                int x = Baglan.LoginControl(K_ad, K_pw);

                if (x == 1)
                {
                    YoneticiMain nextForm = new YoneticiMain();
                    this.Hide();
                    nextForm.Show();
                }
                else if (x == 2)
                {
                    BolumsefiMain nextForm = new BolumsefiMain();
                    this.Hide();
                    nextForm.Show();
                }
                else if (x == 3)
                {
                    IKMain nextForm = new IKMain();
                    this.Hide();
                    nextForm.Show();
                }
                else if (x == 4)
                {
                    MusteritemsilcisiMain nextForm = new MusteritemsilcisiMain();
                    this.Hide();
                    nextForm.Show();
                }
                else if (x == 5)
                {
                    StokMain nextForm = new StokMain();
                    this.Hide();
                    nextForm.Show();
                }
                else if (x == 6)
                {
                    ModellemeMain nextForm = new ModellemeMain();
                    this.Hide();
                    nextForm.Show();
                }
                else if (x == 7)
                {
                    MakineMain nextForm = new MakineMain();
                    this.Hide();
                    nextForm.Show();
                }
                else
                {
                    MessageBox.Show("         Hatalı giriş");

                }
            }
            else if (!ka) MessageBox.Show("Kullanici adınızı yanlış girdiniz.");
                else if (!pw) MessageBox.Show("Sifrenizi yanlış girdiniz.");
            
        }
    

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            kayitol nextForm = new kayitol();
            this.Hide();
            nextForm.Show();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SifremiUnuttum nextForm = new SifremiUnuttum();
            this.Hide();
            nextForm.Show();
        }

        private void panel9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel10_Click(object sender, EventArgs e)
        {
            if (textBox2.UseSystemPasswordChar == false)
                textBox2.UseSystemPasswordChar = true;
            else textBox2.UseSystemPasswordChar = false;
        }

        #endregion

    }
}

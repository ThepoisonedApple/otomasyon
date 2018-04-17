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
        public Form1()
        {
            InitializeComponent();
            button1.FlatAppearance.BorderSize = 0;
            this.ActiveControl = this.panel1;

           



        }
        public string K_ad { get; set; }
        public string K_pw { get; set; }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            panel4.BackColor = Color.Gainsboro;
            panel6.BackColor = Color.DeepSkyBlue;
            if (textBox2.Text=="Şifre")
            {
                textBox2.Text = "";
                textBox2.UseSystemPasswordChar = true;
            }
            
            
        }
        
        private void textBox2_Leave(object sender, EventArgs e)
        {

            panel4.BackColor = Color.WhiteSmoke;
            panel6.BackColor = Color.WhiteSmoke;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            panel3.BackColor = Color.Gainsboro;
            panel5.BackColor = Color.DeepSkyBlue;
            if (textBox1.Text == "Kullanıcı Adı")
            {
                textBox1.Text = "";
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            panel3.BackColor = Color.WhiteSmoke;
            panel5.BackColor = Color.WhiteSmoke;
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

        private void button1_Click(object sender, EventArgs e)
        {
            K_ad = textBox1.Text;
            K_pw = textBox2.Text;
            if(K_ad=="0")
            {
                YoneticiMain nextForm = new YoneticiMain();
                this.Hide();
                nextForm.Show();
            }
            else if (K_ad=="1")
            {
                BolumsefiMain nextForm = new BolumsefiMain();
                this.Hide();
                nextForm.Show();
            }
            else if (K_ad == "2")
            {
                IKMain nextForm = new IKMain();
                this.Hide();
                nextForm.Show();
            }
            else if (K_ad == "3")
            {
                MusteritemsilcisiMain nextForm = new MusteritemsilcisiMain();
                this.Hide();
                nextForm.Show();
            }
            else if (K_ad == "4")
            {
                StokMain nextForm = new StokMain();
                this.Hide();
                nextForm.Show();
            }
            else if (K_ad == "5")
            {
                ModellemeMain nextForm = new ModellemeMain();
                this.Hide();
                nextForm.Show();
            }
            else if (K_ad == "6")
            {
                MakineMain nextForm = new MakineMain();
                this.Hide();
                nextForm.Show();
            }
            else
            {
                MessageBox.Show("Hatalı giriş");
            }
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

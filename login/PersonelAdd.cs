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
    public partial class PersonelAdd : Form
    {
        public PersonelAdd()
        {
            InitializeComponent();
            
            button1.FlatAppearance.BorderSize = 0;
            button9.FlatAppearance.BorderSize = 0;
            button10.FlatAppearance.BorderSize = 0;
            button11.FlatAppearance.BorderSize = 0;
            button12.FlatAppearance.BorderSize = 0;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            IKMain nextForm = new IKMain();
            nextForm.Show();
            this.Dispose();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form1 nextForm = new Form1();
            nextForm.Show();
            this.Dispose();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      
        #region textbox geçişleri
        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text== "Personel Adı")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
            
        }

        private void textBox2_Click(object sender, EventArgs e)
        {

            if (textBox2.Text == "Personel Soyadı")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }
        private void textBox4_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "Personel Adresi")
            {
                textBox4.Text = "";
                textBox4.ForeColor = Color.Black;
            }
        }
        private void textBox3_Click(object sender, EventArgs e)
        {
            {
                 if (textBox3.Text == "Personel Telefonu")
                    {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;
                  }
            }
        }



        private void textBox5_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == "Personel e-mail")
            {
                textBox5.Text = "";
                textBox5.ForeColor = Color.Black;
            }
        }

        private void textBox6_Click(object sender, EventArgs e)
        {
            if (textBox6.Text == "Maaş")
            {
                textBox6.Text = "";
                textBox6.ForeColor = Color.Black;
            }
        }

        private void textBox7_Click(object sender, EventArgs e)
        {
            
           if (textBox7.Text == "Çalıştığı Bölüm")
            {
                textBox7.Text = "";
                textBox7.ForeColor = Color.Black;
            }
        }

        private void textBox8_Click(object sender, EventArgs e)
        {
            if (textBox8.Text == "Çalıştığı Pozisyon")
            {
                textBox8.Text = "";
                textBox8.ForeColor = Color.Black;
            }
        }




        #endregion

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            
                char ch = e.KeyChar;
                decimal x;
                if (ch == (char)Keys.Back)
                {
                    e.Handled = false;
                }
                else if (!char.IsDigit(ch) && ch != '.' || !Decimal.TryParse(textBox3.Text + ch, out x))
                {
                    e.Handled = true;
                }
            
        }
    }
}

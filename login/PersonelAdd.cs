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
            
            badd.FlatAppearance.BorderSize = 0;
            bhome.FlatAppearance.BorderSize = 0;
            binfo.FlatAppearance.BorderSize = 0;
            blogout.FlatAppearance.BorderSize = 0;
            bexit.FlatAppearance.BorderSize = 0;
        }

        private void bhome_Click(object sender, EventArgs e)
        {
            IKMain nextForm = new IKMain();
            nextForm.Show();
            this.Dispose();
        }

        private void blogout_Click(object sender, EventArgs e)
        {
            Form1 nextForm = new Form1();
            nextForm.Show();
            this.Dispose();
        }

        private void bexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      
        #region textbox geçişleri
        private void tpad_Click(object sender, EventArgs e)
        {
            if (tpad.Text== "Personel Adı")
            {
                tpad.Text = "";
                tpad.ForeColor = Color.Black;
            }
            
        }

        private void tpsad_Click(object sender, EventArgs e)
        {

            if (tpsad.Text == "Personel Soyadı")
            {
                tpsad.Text = "";
                tpsad.ForeColor = Color.Black;
            }
        }
        private void tpadres_Click(object sender, EventArgs e)
        {
            if (tpadres.Text == "Personel Adresi")
            {
                tpadres.Text = "";
                tpadres.ForeColor = Color.Black;
            }
        }
        private void tptel_Click(object sender, EventArgs e)
        {
            {
                 if (tptel.Text == "Personel Telefonu")
                    {
                tptel.Text = "";
                tptel.ForeColor = Color.Black;
                  }
            }
        }



        private void tpmail_Click(object sender, EventArgs e)
        {
            if (tpmail.Text == "Personel e-mail")
            {
                tpmail.Text = "";
                tpmail.ForeColor = Color.Black;
            }
        }

        private void tpmaas_Click(object sender, EventArgs e)
        {
            if (tpmaas.Text == "Maaş")
            {
                tpmaas.Text = "";
                tpmaas.ForeColor = Color.Black;
            }
        }

        private void tppoz_Click(object sender, EventArgs e)
        {
            if (tppoz.Text == "Çalıştığı Pozisyon")
            {
                tppoz.Text = "";
                tppoz.ForeColor = Color.Black;
            }
        }




        #endregion

        private void tptel_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            decimal x;
            if (ch == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else if (!char.IsDigit(ch) || !Decimal.TryParse(tptel.Text + ch, out x))
            {
                e.Handled = true;
            }
        }

        private void badd_Click(object sender, EventArgs e)
        {
            PersonelClass myclass = new PersonelClass();
            try
            {
                myclass.Personelekle(tpad.Text, tpsad.Text, tpmail.Text, Convert.ToDouble(tpmaas.Text), comboBox2.SelectedIndex+1, tpadres.Text, tptel.Text, tppoz.Text);
                MessageBox.Show("Personel başarıyla eklendi.");
            }
            catch (Exception)
            {
                MessageBox.Show("Personel ekleme başarısız.");
                
            }
            
        }

        private void PersonelAdd_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'otomasyonDataSet.yetki_bolum' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.yetki_bolumTableAdapter.Fill(this.otomasyonDataSet.yetki_bolum);

        }

        private void tpmaas_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            decimal x;
            if (ch == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else if (!char.IsDigit(ch) && ch != ',' || !Decimal.TryParse(tpmaas.Text + ch, out x))
            {
                e.Handled = true;
            }
        }
    }
}

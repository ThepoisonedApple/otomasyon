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
    public partial class PersonelUpdate : Form
    {
        string[] arr = new string[8];
        string pid;
        public PersonelUpdate()
        {
            InitializeComponent();
            this.ActiveControl = this.panel1;
            bupdate.FlatAppearance.BorderSize = 0;
            bbilgi.FlatAppearance.BorderSize = 0;
            bhome.FlatAppearance.BorderSize = 0;
            binfo.FlatAppearance.BorderSize = 0;
            blogout.FlatAppearance.BorderSize = 0;
            bexit.FlatAppearance.BorderSize = 0;
        }

        private void tpid_Enter(object sender, EventArgs e)
        {
            if (tpid.Text=="Personel ID")
            {
                tpid.Text = "";
                tpid.ForeColor = Color.Black;
            }

        }

        private void bbilgi_Click(object sender, EventArgs e)
        {
            try
            {
                pid = tpid.Text;
                PersonelClass myclass = new PersonelClass();
                arr = myclass.PersonelBilgiGetir(pid);
                tpad.Text = arr[0];
                tpad.ForeColor = Color.Black;
                tpsad.Text = arr[1];
                tpsad.ForeColor = Color.Black;
                tptel.Text = arr[6];
                tptel.ForeColor = Color.Black;
                tpadres.ForeColor = Color.Black;
                tpadres.Text = arr[5];
                tpmail.ForeColor = Color.Black;
                tpmail.Text = arr[2];
                tpmaas.ForeColor = Color.Black;
                tpmaas.Text = arr[3];
                tpbolum.ForeColor = Color.Black;
                tpbolum.Text = arr[4];
                tppoz.ForeColor = Color.Black;
                tppoz.Text = arr[7];
            }
            catch (Exception)
            {
                DBconnect conn = new DBconnect();
                conn.connectionclose();
                MessageBox.Show("Persone id'sini Eksik veya Yanlış Girdiniz");
            }

        }

        private void bexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
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

        private void tptel_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            decimal x;
            if (ch == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else if (!char.IsDigit(ch) && ch != '.' || !Decimal.TryParse(tptel.Text + ch, out x))
            {
                e.Handled = true;
            }
        }

        private void bupdate_Click(object sender, EventArgs e)
        {
            try
            {
                PersonelClass myclass = new PersonelClass();
                myclass.PersonelGuncelle(tpad.Text, tpsad.Text, tpmail.Text,Convert.ToDouble(tpmaas.Text),Convert.ToInt32(tpbolum.Text), tpadres.Text,tptel.Text, tppoz.Text,pid);
                MessageBox.Show("yuppi");
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı Veya Eksik bilgi girdiniz Güncelleme Başarısız");
            }
        }
    }
}

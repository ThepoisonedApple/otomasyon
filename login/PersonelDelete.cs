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
    public partial class PersonelDelete : Form
    {
        string[] arr = new string[8];
        public PersonelDelete()
        {
            InitializeComponent();
            this.ActiveControl = this.panel1;
            bdelete.FlatAppearance.BorderSize = 0;
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

        private void bbilgi_Click(object sender, EventArgs e)
        {
            try
            {
                PersonelClass myclass = new PersonelClass();
                arr = myclass.PersonelBilgiGetir(tpid.Text);
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
                comboBox2.SelectedIndex=Convert.ToInt32(arr[4])-1;
                tppoz.ForeColor = Color.Black;
                tppoz.Text = arr[7];
            }
            catch (Exception)
            {

                MessageBox.Show("Persone id'sini Eksik veya Yanlış Girdiniz");
                DBconnect conn = new DBconnect();
                conn.connectionclose();
            }
        }

        private void tpid_Enter(object sender, EventArgs e)
        {   
            
            if (tpid.Text == "Personel ID")
            {
                tpid.Text = "";
                tpid.ForeColor = Color.Black;
            }
        }

        private void bdelete_Click(object sender, EventArgs e)
        {
            try
            {
                PersonelClass myclass = new PersonelClass();
                myclass.PersonelSil(tpid.Text);
                MessageBox.Show("Personel başarıyla silindi.");
                foreach (Control c in panel5.Controls)
                {
                    if (c is TextBox)
                    {
                        c.ResetText();
                    }
                }
            }
            catch (Exception)
            {
                DBconnect conn = new DBconnect();
                conn.connectionclose();
                MessageBox.Show("Personel silme başarısız");
            }
        }

        private void PersonelDelete_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'otomasyonDataSet.yetki_bolum' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.yetki_bolumTableAdapter.Fill(this.otomasyonDataSet.yetki_bolum);

        }
    }
}

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
    public partial class HammaddestokDelete : Form
    {
        public HammaddestokDelete()
        {
            InitializeComponent();
            this.ActiveControl = this.panel1;
            bdelete.FlatAppearance.BorderSize = 0;
            bhome.FlatAppearance.BorderSize = 0;
            binfo.FlatAppearance.BorderSize = 0;
            blogout.FlatAppearance.BorderSize = 0;
            bexit.FlatAppearance.BorderSize = 0;
        }

        private void bexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bhome_Click(object sender, EventArgs e)
        {
            Stokhammadde nextForm = new Stokhammadde();
            nextForm.Show();
            this.Dispose();
        }

        private void blogout_Click(object sender, EventArgs e)
        {
            Form1 nextForm = new Form1();
            nextForm.Show();
            this.Dispose();
        }

        private void bdelete_Click(object sender, EventArgs e)
        {
            var silmeOnay = MessageBox.Show("Silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (silmeOnay == DialogResult.Yes)
            {
                try
                {
                    HammaddeClass myclass = new HammaddeClass();
                    myclass.HammaddeSil(tuid.Text);
                    MessageBox.Show("Hammadde Stoğu başarıyla silindi.");
                }
                catch (Exception)
                {
                    DBconnect.connectionclose();
                    MessageBox.Show("Silme işlemi Başarısız");
                }
            }
        }

        private void bbilgi_Click(object sender, EventArgs e)
        {
            string[] arr = new string[3];
            try
            {
                HammaddeClass myclass = new HammaddeClass();
                arr = myclass.HammaddeBilgiGetir(tuid.Text);
                tuadi.Text = arr[0];
                tuadet.Text = arr[1];
                ttid.Text = arr[2];
                tuadi.ForeColor = Color.Black;
                tuadet.ForeColor = Color.Black;
                ttid.ForeColor = Color.Black;

            }
            catch (Exception)
            {
                DBconnect.connectionclose();
                MessageBox.Show("Hammadde Bilgileri Getirilemedi");
            }
        }

        private void tuid_Enter(object sender, EventArgs e)
        {
            var textbox = (TextBox)sender;
            if (textbox.ForeColor == Color.Silver)
            {
                textbox.ResetText();
                textbox.ForeColor = Color.Black;
            }

        }

        private void binfo_Click(object sender, EventArgs e)
        {
            Hakkında nextForm = new Hakkında();
            nextForm.Show();
        }
    }
}

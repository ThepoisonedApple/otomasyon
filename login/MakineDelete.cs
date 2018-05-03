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
    public partial class MakineDelete : Form
    {
        public MakineDelete()
        {
            InitializeComponent();
            bdelete.FlatAppearance.BorderSize = 0;
            bhome.FlatAppearance.BorderSize = 0;
            binfo.FlatAppearance.BorderSize = 0;
            blogout.FlatAppearance.BorderSize = 0;
            bexit.FlatAppearance.BorderSize = 0;
        }

        private void MakineDelete_Load(object sender, EventArgs e)
        {

        }

        private void bexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bhome_Click(object sender, EventArgs e)
        {
            MakineMain nextForm = new MakineMain();
            nextForm.Show();
            this.Dispose();
        }

        private void blogout_Click(object sender, EventArgs e)
        {
            Form1 nextForm = new Form1();
            nextForm.Show();
            this.Dispose();
        }

        private void bbilgi_Click(object sender, EventArgs e)
        {
            string[] arr = new string[4];
            try
            {
                MakineClass myclass = new MakineClass();
                arr = myclass.MakineBilgiGetir(tmid.Text);
                tmadi.Text = arr[0];
                tmalim.Text = arr[1];
                tmbakim.Text = arr[2];
                if (Convert.ToBoolean(arr[3]))
                {
                    cmbakim.SelectedIndex = 0;

                }
                else
                {
                    cmbakim.SelectedIndex = 1;
                }

                tmadi.ForeColor = Color.Black;
                tmalim.ForeColor = Color.Black;
                tmbakim.ForeColor = Color.Black;

            }
            catch (Exception)
            {
                 
                DBconnect.connectionclose();
                MessageBox.Show("Makine bilgileri getirilemedi.");
            }
        }

        private void bdelete_Click(object sender, EventArgs e)
        {
            var silmeOnay = MessageBox.Show("Silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (silmeOnay == DialogResult.Yes)
            {
                try
                {
                    MakineClass myclass = new MakineClass();
                    myclass.MakineSil(tmid.Text);
                    MessageBox.Show("Makine Başarıyla Silindi.");
                }
                catch (Exception)
                {
                    DBconnect.connectionclose();
                    MessageBox.Show("Makine Silinemedi");

                }
            }
        }

        private void tmid_Enter(object sender, EventArgs e)
        {
            var textbox = (TextBox)sender;
            if (textbox.ForeColor == Color.Silver)
            {
                textbox.ResetText();
            }
            textbox.ForeColor = Color.Black;
        }

        private void binfo_Click(object sender, EventArgs e)
        {
            Hakkında nextForm = new Hakkında();
            nextForm.Show();
        }
    }
}

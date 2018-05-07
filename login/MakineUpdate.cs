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
    public partial class MakineUpdate : Form
    {
        bool x;
        public MakineUpdate()
        {
            InitializeComponent();
            this.ActiveControl = this.panel1;
            bupdate.FlatAppearance.BorderSize = 0;
            bhome.FlatAppearance.BorderSize = 0;
            binfo.FlatAppearance.BorderSize = 0;
            blogout.FlatAppearance.BorderSize = 0;
            bexit.FlatAppearance.BorderSize = 0;
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

        private void bexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bupdate_Click(object sender, EventArgs e)
        {
            try
            {
                MakineClass myclass = new MakineClass();
                myclass.MakineGuncelle(tmadi.Text, x, Convert.ToDateTime(tmalim.Text), Convert.ToDateTime(tmbakim.Text),Convert.ToInt32(tmid.Text));
                MessageBox.Show("Makine Başarıyla Güncellendi");
            }
            catch (Exception)
            {
                DBconnect.connectionclose();
                MessageBox.Show("Makine Güncellenemedi");
               
            }
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
                MessageBox.Show("Makine Bilgileri Getirilemedi.");
                
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

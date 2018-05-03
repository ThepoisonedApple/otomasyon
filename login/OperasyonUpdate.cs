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
    public partial class OperasyonUpdate : Form
    {
        public OperasyonUpdate()
        {
            InitializeComponent();
            bupdate.FlatAppearance.BorderSize = 0;
            bbilgi.FlatAppearance.BorderSize = 0;
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
            ModellemeMain nextForm = new ModellemeMain();
            nextForm.Show();
            this.Dispose();
        }

                     
                   
        private void bupdate_Click(object sender, EventArgs e)
        {
            try
            {
                OperasyonClass myclass = new OperasyonClass();
                myclass.OperasyonGuncelle(toadi.Text, totanim.Text, Convert.ToInt32(toid.Text));
                MessageBox.Show("Operasyon Başarıyla güncellendi.");
            }
            catch (Exception)
            {
                DBconnect.connectionclose();
                MessageBox.Show("Operasyon güncellenemedi.");
            }
        }

        private void bbilgi_Click(object sender, EventArgs e)
        {
            string[] arr = new string[2];
            try
            {
                OperasyonClass myclass = new OperasyonClass();
               arr= myclass.OperasyonBilgiGetir(toid.Text);
                toadi.Text = arr[0];
                totanim.Text = arr[1];
                toadi.ForeColor = Color.Black;
                totanim.ForeColor = Color.Black;

            }
            catch (Exception)
            {
                DBconnect.connectionclose();
                MessageBox.Show("Operasyon bilgileri getirilemedi.");
            }
        }

        private void blogout_Click(object sender, EventArgs e)
        {
            Form1 nextForm = new Form1();
            nextForm.Show();
            this.Dispose();
        }

        private void binfo_Click(object sender, EventArgs e)
        {
            Hakkında nextForm = new Hakkında();
            nextForm.Show();
        }
    }
}

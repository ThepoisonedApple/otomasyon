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
    public partial class HammaddeStokUpdate : Form
    {
        public HammaddeStokUpdate()
        {
            InitializeComponent();
            bupdate.FlatAppearance.BorderSize = 0;
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

        private void bupdate_Click(object sender, EventArgs e)
        {
            try
            {
                HammaddeClass myclass = new HammaddeClass();
                myclass.HammaddeGuncelle(tuadi.Text, Convert.ToInt32(tuadet.Text), Convert.ToInt32(ttid.Text),Convert.ToInt32(tuid.Text));
                MessageBox.Show("Başarılı");
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı");
                throw;
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

                MessageBox.Show("Başarılı");
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı");
                throw;
            }
        }
    }
}

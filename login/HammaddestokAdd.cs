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
    public partial class HammaddestokAdd : Form
    {
        public HammaddestokAdd()
        {
            InitializeComponent();
            badd.FlatAppearance.BorderSize = 0;
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

        private void badd_Click(object sender, EventArgs e)
        {
            try
            {
                HammaddeClass myclass = new HammaddeClass();
                myclass.HammaddeEkle(tuadi.Text, Convert.ToInt32(tuadet.Text), Convert.ToInt32(ttid.Text));

                MessageBox.Show("Hammadde Stoğu Başarıyla Eklendi");
            }
            catch (Exception)
            {
                DBconnect.connectionclose();
                MessageBox.Show("Hammadde Stoğu Eklenemedi.");
            }


        }

        private void tuadet_Enter(object sender, EventArgs e)
        {
            var textbox = (TextBox)sender;
            if (textbox.ForeColor == Color.Silver)
            {
                textbox.ResetText();
                textbox.ForeColor = Color.Black;
            }

        }
    }
}

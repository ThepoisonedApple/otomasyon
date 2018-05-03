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
    public partial class ASiparisAdd : Form
    {
        public ASiparisAdd()
        {
            InitializeComponent();
            button1.FlatAppearance.BorderSize = 0;
            button9.FlatAppearance.BorderSize = 0;
            button10.FlatAppearance.BorderSize = 0;
            button11.FlatAppearance.BorderSize = 0;
            button12.FlatAppearance.BorderSize = 0;
            DateTime thisDay1 = DateTime.Today;
            tstarih.Text = thisDay1.ToString("d");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                AsiparisClass myclass = new AsiparisClass();
                myclass.AsipEkle(Convert.ToInt32(ttid.Text), Convert.ToInt32(thid.Text), Convert.ToDateTime(tstarih.Text), Convert.ToDateTime(tbtarih.Text), Convert.ToInt32(tadet.Text), Convert.ToInt32(tfiyat.Text));
                MessageBox.Show("Sipariş Başarıyla Eklendi.");
            }
            catch (Exception)
            {
                DBconnect.connectionclose();
                MessageBox.Show("Sipariş Eklenemedi.");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MusteritemsilcisiAlim nextForm = new MusteritemsilcisiAlim();
            nextForm.Show();
            this.Dispose();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form1 nextForm = new Form1();
            nextForm.Show();
            this.Dispose();
        }

        private void ttid_Enter(object sender, EventArgs e)
        {
            var textbox = (TextBox)sender;
            if (textbox.ForeColor == Color.Silver)
            {
                textbox.ResetText();
                textbox.ForeColor = Color.Black;
            }

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Hakkında nextForm = new Hakkında();
            nextForm.Show();
        }
    }
}

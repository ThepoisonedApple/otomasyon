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
    public partial class SSiparisAdd : Form
    {
        public SSiparisAdd()
        {
            InitializeComponent();
            this.ActiveControl = this.panel1;
            button1.FlatAppearance.BorderSize = 0;
            button9.FlatAppearance.BorderSize = 0;
            button10.FlatAppearance.BorderSize = 0;
            button11.FlatAppearance.BorderSize = 0;
            button12.FlatAppearance.BorderSize = 0;
            tstarih.Text = DateTime.Today.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MusterıtemsilcisiSatim nextForm = new MusterıtemsilcisiSatim();
            nextForm.Show();
            this.Dispose();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form1 nextForm = new Form1();
            nextForm.Show();
            this.Dispose();
        }

        private void tadet_Enter(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SSiparisClass myclass = new SSiparisClass();
                myclass.SsipEkle(Convert.ToInt32(tmid.Text),Convert.ToDateTime(tstarih.Text), Convert.ToDateTime(tbtarih.Text), Convert.ToInt32(tadet.Text), Convert.ToInt32(tfiyat.Text),tbilgi.Text);
                MessageBox.Show("Sipariş Başarıyla Eklendi.");
            }
            catch (Exception)
            {
                 
                DBconnect.connectionclose();
                MessageBox.Show("Sipariş Eklenemedi.");
            }
        }
    }
}

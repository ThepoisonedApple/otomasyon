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
    public partial class SSiparisUpdate : Form
    {
        int sid;
        public SSiparisUpdate()
        {
            InitializeComponent();
            this.ActiveControl = this.panel1;
            button1.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.BorderSize = 0;
            button9.FlatAppearance.BorderSize = 0;
            button10.FlatAppearance.BorderSize = 0;
            button11.FlatAppearance.BorderSize = 0;
            button12.FlatAppearance.BorderSize = 0;

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

        private void tsid_Enter(object sender, EventArgs e)
        {
            var textbox = (TextBox)sender;
            if (textbox.ForeColor == Color.Silver)
            {
                textbox.ResetText();
                textbox.ForeColor = Color.Black;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] arr = new string[6];
            try
            {
                SSiparisClass myclass = new SSiparisClass();
                sid = Convert.ToInt32(tsid.Text);
                arr = myclass.BilgiGetir(sid);
                tmid.Text = arr[0];
                tmid.ForeColor = Color.Black;
                tbilgi.Text = arr[1];
                tbilgi.ForeColor = Color.Black;
                tstarih.Text = arr[2];
                tstarih.ForeColor = Color.Black;
                tbtarih.Text = arr[3];
                tbtarih.ForeColor = Color.Black;
                tadet.Text = arr[4];
                tadet.ForeColor = Color.Black;
                tfiyat.Text = arr[5];
                tfiyat.ForeColor = Color.Black;
            }
            catch (Exception)
            {
                 
                DBconnect.connectionclose();
                MessageBox.Show("Bilgiler getirilemedi");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SSiparisClass myclass = new SSiparisClass();
                myclass.SsipGuncelle(sid, Convert.ToInt32(tmid.Text), Convert.ToDateTime(tstarih.Text), Convert.ToDateTime(tbtarih.Text), Convert.ToInt32(tadet.Text), Convert.ToInt32(tfiyat.Text), tbilgi.Text);
                MessageBox.Show("Sipariş başarıyla güncellendi.");
            }
            catch (Exception)
            {
                 
                DBconnect.connectionclose();
                MessageBox.Show("Sipariş güncellenemedi.");
            }
        }
    }
}

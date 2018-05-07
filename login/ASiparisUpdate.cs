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
    public partial class ASiparisUpdate : Form
    {
        int sid;
        public ASiparisUpdate()
        {
            InitializeComponent();
            this.ActiveControl = this.panel1;
            button1.FlatAppearance.BorderSize = 0;
            button9.FlatAppearance.BorderSize = 0;
            button10.FlatAppearance.BorderSize = 0;
            button11.FlatAppearance.BorderSize = 0;
            button12.FlatAppearance.BorderSize = 0;
            DateTime thisDay1 = DateTime.Today;
            tstarih.Text = thisDay1.ToString("d");
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

        private void button2_Click(object sender, EventArgs e)
        {
            string[] arr = new string[6];
            try
            {
                AsiparisClass myclass = new AsiparisClass();
                sid = Convert.ToInt32(tsid.Text);
                arr = myclass.BilgiGetir(sid);
                ttid.Text = arr[0];
                thid.Text = arr[1];
                tstarih.Text = arr[2];
                tbtarih.Text = arr[3];
                tadet.Text = arr[4];
                tfiyat.Text = arr[5];
            }
            catch (Exception)
            {
      
                DBconnect.connectionclose();
                MessageBox.Show("Sipariş Bilgileri Getirilemedi.");

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                AsiparisClass myclass = new AsiparisClass();
                myclass.AsipGuncelle(sid,Convert.ToInt32(ttid.Text), Convert.ToInt32(thid.Text), Convert.ToDateTime(tstarih.Text), Convert.ToDateTime(tbtarih.Text), Convert.ToInt32(tadet.Text), Convert.ToInt32(tfiyat.Text));
                MessageBox.Show("Sipariş başarıyla güncellendi.");
            }
            catch (Exception)
            {

                DBconnect.connectionclose();
                MessageBox.Show("Sipariş güncellenemedi.");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Hakkında nextForm = new Hakkında();
            nextForm.Show();
        }

        private void tsid_Enter(object sender, EventArgs e)
        {
            if (tsid.ForeColor==Color.Silver)
            {
                tsid.ResetText();
                tsid.ForeColor = Color.Black;
            }
        }
    }
}

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
    public partial class ASiparisDelete : Form
    {
        int sid;
        public ASiparisDelete()
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

        private void textBox1_Enter(object sender, EventArgs e)
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
                DBconnect mycon = new DBconnect();
                mycon.connectionclose();
                MessageBox.Show("Bilgiler getirilemedi");

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            var silmeOnay = MessageBox.Show("Silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (silmeOnay == DialogResult.Yes)
            {
                try
                {
                    AsiparisClass myclass = new AsiparisClass();
                    myclass.AsipSil(sid);
                    MessageBox.Show("Sipariş Başarıyla Silindi");
                }
                catch (Exception)
                {

                    MessageBox.Show("Sipariş Silinemedi");
                }
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Hakkında nextForm = new Hakkında();
            nextForm.Show();
        }
    }
}

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
    public partial class TedarikciDelete : Form
    {
        int tid;
        public TedarikciDelete()
        {
            InitializeComponent();
            button1.FlatAppearance.BorderSize = 0;
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

        private void textBox9_Enter(object sender, EventArgs e)
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
            string[] arr = new string[5];
            try
            {
                TedarikciClass myclass = new TedarikciClass();
                tid = Convert.ToInt32(ttid.Text);
                arr = myclass.BilgiGetir(tid);
                ttad.Text = arr[0];
                ttad.ForeColor = Color.Black;
                tyad.Text = arr[1];
                tyad.ForeColor = Color.Black;
                tadres.Text = arr[2];
                tadres.ForeColor = Color.Black;
                ttel.Text = arr[3];
                ttel.ForeColor = Color.Black;
                temail.Text = arr[4];
                temail.ForeColor = Color.Black;
            }
            catch (Exception)
            {
                 
                DBconnect.connectionclose();
                MessageBox.Show("Tedarikçi Bilgileri Getirilemedi");
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Hakkında nextForm = new Hakkında();
            nextForm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var silmeOnay = MessageBox.Show("Silmek istediğinize emin misiniz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (silmeOnay == DialogResult.Yes)
            {
                try
                {
                    TedarikciClass myclass = new TedarikciClass();
                    myclass.TedarikciSil(tid);
                    MessageBox.Show("Tedarikçi Başarıyla Silindi");
                }
                catch (Exception)
                {
                     
                    DBconnect.connectionclose();
                    MessageBox.Show("Tedarikçi Silinemedi."+ Environment.NewLine+"Bu Tedarikçiye Bağlı Veriler Bulunuyorsa Silinemez!");
                }
            }
        }
    }
}

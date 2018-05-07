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
    public partial class UrunUpdate : Form
    {
        public UrunUpdate()
        {
            InitializeComponent();
            this.ActiveControl = this.panel1;
            button1.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.BorderSize = 0;
            button6.FlatAppearance.BorderSize = 0;
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
            ModellemeMain nextForm = new ModellemeMain();
            nextForm.Show();
            this.Dispose();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form1 nextForm = new Form1();
            nextForm.Show();
            this.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                UrunClass myclass = new UrunClass();
                string[] arr = new string[4];
                arr=myclass.BilgiGetir(Convert.ToInt32(tuid.Text));
                tuad.Text = arr[0];
                tsid.Text = arr[3];
                tutl.Text = arr[1];
                tukl.Text = arr[2];
            }
            catch (Exception)
            {
                DBconnect.connectionclose();
                MessageBox.Show("Urun Bilgileri Getirilemedi.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                UrunClass myclass = new UrunClass();
                myclass.UruneOperasyonEkle(Convert.ToInt32(tuid.Text), Convert.ToInt32(toid.Text));
                MessageBox.Show("Urune Operasyon Başarıyla Eklendi.");
            }
            catch (Exception)
            {
                DBconnect.connectionclose();
                MessageBox.Show("Urune Operasyon Eklenemedi.");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                UrunClass myclass = new UrunClass();
                myclass.UruneHammaddeEkle(Convert.ToInt32(tuid.Text), Convert.ToInt32(thid.Text));
                MessageBox.Show("Urune Hammadde Başarıyla Eklendi.");
            }
            catch (Exception)
            {
                DBconnect.connectionclose();
                MessageBox.Show("Urune Hammadde Eklenemedi.");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                UrunClass myclass = new UrunClass();
                myclass.UrundenOperasyonSil(Convert.ToInt32(tuid.Text), Convert.ToInt32(toid.Text));
                MessageBox.Show("Urunden Operasyon Başarıyla Silindi.");
            }
            catch (Exception)
            {
                DBconnect.connectionclose();
                MessageBox.Show("Urunden Operasyon Silinemedi.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                UrunClass myclass = new UrunClass();
                myclass.UrunGuncelle(Convert.ToInt32(tuid.Text), tuad.Text, tutl.Text, tukl.Text, Convert.ToInt32(tsid.Text));
                MessageBox.Show("Urun Başarıyla Güncellendi.");
            }
            catch (Exception)
            {
                DBconnect.connectionclose();
                MessageBox.Show("Urun Güncellenemedi.");
            }

        }

        private void tuid_Enter(object sender, EventArgs e)
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

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
    public partial class UrunDelete : Form
    {
        string[] arr = new string[4];
        public UrunDelete()
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
                myclass.AratabloListele(Convert.ToInt32(tuid.Text));
                arr=myclass.BilgiGetir(Convert.ToInt32(tuid.Text));
                foreach (Control c in panel5.Controls)
                {
                    if (c is TextBox)
                    {
                        ((TextBox)c).ForeColor = Color.Black;
                        if (c.Name!="tuid")
                        {
                            ((TextBox)c).ResetText();
                        }

                    }
                }
                thid.ForeColor = Color.Black;
                toid.ForeColor = Color.Black;
                toid.ResetText();
                thid.ResetText();
                for (int i = 0; i < UrunClass.operasyonlist.Count; i++)
                {
                    toid.Text += UrunClass.operasyonlist[i]+ Environment.NewLine;

                }
                for (int i = 0; i < UrunClass.hammaddelist.Count; i++)
                {
                    toid.Text += UrunClass.hammaddelist[i] + Environment.NewLine;

                }

                tuad.Text = arr[0];
                tutl.Text = arr[1];
                tukl.Text = arr[2];
                tsid.Text = arr[3];
                
            }
            catch (Exception)
            {
                DBconnect mycon = new DBconnect();
                mycon.connectionclose();
                MessageBox.Show("Hatalı ID bilgiler getirilemedi");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                UrunClass myclass = new UrunClass();
                myclass.UrunSil(Convert.ToInt32(tuid.Text));
            }
            catch (Exception)
            {
                MessageBox.Show("Urun Silinemedi");
                throw;
            }
        }
    }
}

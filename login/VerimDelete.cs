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
    public partial class VerimDelete : Form
    {
        public VerimDelete()
        {
            InitializeComponent();
            DateTime thisDay1 = DateTime.Today;
            ttarih.Text = thisDay1.ToString("d");           
            button1.FlatAppearance.BorderSize = 0;
            button9.FlatAppearance.BorderSize = 0;
            button10.FlatAppearance.BorderSize = 0;
            button11.FlatAppearance.BorderSize = 0;
            button12.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.BorderSize = 0;
            ttoplam.Text = "125";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            BolumsefiMain nextForm = new BolumsefiMain();
            nextForm.Show();
            this.Dispose();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form1 nextForm = new Form1();
            nextForm.Show();
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                VerimClass myclass = new VerimClass();
                ttoplam.Text = myclass.BilgileriGetir(Convert.ToInt32(tuid.Text), Convert.ToInt32(toid.Text), Convert.ToInt32(tpid.Text), Convert.ToDateTime(ttarih.Text));
            }
            catch (Exception)
            {

                throw;
            }
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                VerimClass myclass = new VerimClass();
                myclass.VerimSil();
            }
            catch (Exception)
            {

                throw;
            }


        }

        private void tpad_Enter(object sender, EventArgs e)
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

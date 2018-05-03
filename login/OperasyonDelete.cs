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
    public partial class OperasyonDelete : Form
    {
        public OperasyonDelete()
        {
            InitializeComponent();
            bdelete.FlatAppearance.BorderSize = 0;
            bhome.FlatAppearance.BorderSize = 0;
            binfo.FlatAppearance.BorderSize = 0;
            blogout.FlatAppearance.BorderSize = 0;
            bexit.FlatAppearance.BorderSize = 0;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bhome_Click(object sender, EventArgs e)
        {
            ModellemeMain nextForm = new ModellemeMain();
            nextForm.Show();
            this.Dispose();
        }

        private void blogout_Click(object sender, EventArgs e)
        {
            Form1 nextForm = new Form1();
            nextForm.Show();
            this.Dispose();
        }


        private void bbilgi_Click(object sender, EventArgs e)
        {
             string[] arr = new string[2];
            try
            {
                OperasyonClass myclass = new OperasyonClass();
               arr= myclass.OperasyonBilgiGetir(toid.Text);
                toadi.Text = arr[0];
                totanim.Text = arr[1];
                MessageBox.Show("Başarılı");


            }
            catch (Exception)
            {

                throw;
            }
        }

        private void bdelete_Click(object sender, EventArgs e)
        {
            try
            {
                OperasyonClass myclass = new OperasyonClass();
                myclass.OperasyonSil(toid.Text);
                MessageBox.Show("Başarılı");
            }
            catch (Exception)
            {
                MessageBox.Show("Hatalı");
                throw;
            }
        }

        private void binfo_Click(object sender, EventArgs e)
        {
            Hakkında nextForm = new Hakkında();
            nextForm.Show();
        }

        private void toid_Enter(object sender, EventArgs e)
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

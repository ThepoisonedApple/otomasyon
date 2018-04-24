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
    public partial class OperasyonUpdate : Form
    {
        public OperasyonUpdate()
        {
            InitializeComponent();
            button1.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.BorderSize = 0;
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

        private void button11_click(object sender, EventArgs e)
        {
            Form1 nextForm = new Form1();
            nextForm.Show();
            this.Dispose();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OperasyonClass myclass = new OperasyonClass();
                myclass.OperasyonGuncelle(toadi.Text, totanim.Text);
                MessageBox.Show("yuppi");
            }
            catch (Exception)
            {
                MessageBox.Show("hatalı");
                throw;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string[] arr = new string[2];
            try
            {
                OperasyonClass myclass = new OperasyonClass();
               arr= myclass.OperasyonBilgiGetir(toid.Text);
                toadi.Text = arr[0];
                totanim.Text = arr[1];
                toadi.ForeColor = Color.Black;
                totanim.ForeColor = Color.Black;

                MessageBox.Show("yuppi");
            }
            catch (Exception)
            {
                MessageBox.Show("hatalı");
                throw;
            }
        }
    }
}

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
    public partial class PersonelDelete : Form
    {
        public PersonelDelete()
        {
            InitializeComponent();
            this.ActiveControl = this.panel1;
            button1.FlatAppearance.BorderSize = 0;
            button9.FlatAppearance.BorderSize = 0;
            button10.FlatAppearance.BorderSize = 0;
            button11.FlatAppearance.BorderSize = 0;
            button12.FlatAppearance.BorderSize = 0;

        }

        private void button9_Click(object sender, EventArgs e)
        {
            IKMain nextForm = new IKMain();
            nextForm.Show();
            this.Dispose();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form1 nextForm = new Form1();
            nextForm.Show();
            this.Dispose();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.ForeColor = Color.Black;
            textBox2.Text = "";
            textBox2.ForeColor = Color.Black;
            textBox3.Text = "";
            textBox3.ForeColor = Color.Black;
            textBox4.Text = "";
            textBox5.ForeColor = Color.Black;
            textBox5.Text = "";
            textBox6.ForeColor = Color.Black;
            textBox6.Text = "";
            textBox7.ForeColor = Color.Black;
            textBox7.Text = "";
            textBox8.ForeColor = Color.Black;
            textBox8.Text = "";
        }

        private void textBox9_Enter(object sender, EventArgs e)
        {
            if (textBox9.Text == "Personel ID")
            {
                textBox9.Text = "";
                textBox9.ForeColor = Color.Black;
            }
        }
    }
}

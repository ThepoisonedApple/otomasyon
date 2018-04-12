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
    public partial class IKMain : Form
    {
        public IKMain()
        {
            InitializeComponent();
            button5.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.BorderSize = 0;
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

        private void button11_Click(object sender, EventArgs e)
        {
            Form1 nextForm = new Form1();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            PersonelSearch nextForm = new PersonelSearch();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            PersonelAdd nextForm = new PersonelAdd();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PersonelDelete nextForm = new PersonelDelete();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PersonelUpdate nextForm = new PersonelUpdate();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }
    }
}

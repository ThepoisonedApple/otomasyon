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
    public partial class ModellemeMain : Form
    {
        public ModellemeMain()
        {
            InitializeComponent();
            button1.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.BorderSize = 0;
            button6.FlatAppearance.BorderSize = 0;
            button7.FlatAppearance.BorderSize = 0;
            button8.FlatAppearance.BorderSize = 0;
            button9.FlatAppearance.BorderSize = 0;
            button10.FlatAppearance.BorderSize = 0;
            button11.FlatAppearance.BorderSize = 0;
            button12.FlatAppearance.BorderSize = 0;
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form1 nextForm = new Form1();
            nextForm.Show();
            this.Dispose();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            UrunAdd nextForm = new UrunAdd();
            nextForm.Show();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UrunUpdate nextForm = new UrunUpdate();
            nextForm.Show();
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UrunDelete nextForm = new UrunDelete();
            nextForm.Show();
            this.Dispose();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OperasyonAdd nextForm = new OperasyonAdd();
            nextForm.Show();
            this.Dispose();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OperasyonSearch nextForm = new OperasyonSearch();
            nextForm.Show();
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OperasyonUpdate nextForm = new OperasyonUpdate();
            nextForm.Show();
            this.Dispose();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OperasyonDelete nextForm = new OperasyonDelete();
            nextForm.Show();
            this.Dispose();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UrunSearch nextForm = new UrunSearch();
            nextForm.Show();
            this.Dispose();
        }
    }
}

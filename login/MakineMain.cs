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
    public partial class MakineMain : Form
    {
        public MakineMain()
        {
            InitializeComponent();
            button5.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.BorderSize = 0;
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

        private void button4_Click(object sender, EventArgs e)
        {
            MakineSearch nextForm = new MakineSearch();
            nextForm.Show();
            this.Dispose();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MakineAdd nextForm = new MakineAdd();
            nextForm.Show();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MakineUpdate nextForm = new MakineUpdate();
            nextForm.Show();
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MakineDelete nextForm = new MakineDelete();
            nextForm.Show();
            this.Dispose();
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }
    }
}

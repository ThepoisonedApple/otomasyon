﻿using System;
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
    public partial class Stokurun : Form
    {
        public Stokurun()
        {
            InitializeComponent();
            button1.FlatAppearance.BorderSize = 0;
       //     button2.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.BorderSize = 0;
          //  button6.FlatAppearance.BorderSize = 0;
         //   button7.FlatAppearance.BorderSize = 0;
         //   button8.FlatAppearance.BorderSize = 0;
            button9.FlatAppearance.BorderSize = 0;
            button10.FlatAppearance.BorderSize = 0;
            button11.FlatAppearance.BorderSize = 0;
            button12.FlatAppearance.BorderSize = 0;
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            StokMain nextForm = new StokMain();
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

        private void button4_Click(object sender, EventArgs e)
        {
            UrunStokSearch nextForm = new UrunStokSearch();
            nextForm.Show();
            this.Dispose();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UrunStokAdd nextForm = new UrunStokAdd();
            nextForm.Show();
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UrunStokDelete nextForm = new UrunStokDelete();
            nextForm.Show();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UrunStokUpdate nextForm = new UrunStokUpdate();
            nextForm.Show();
            this.Dispose();
        }
    }
}

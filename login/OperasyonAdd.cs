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
    public partial class OperasyonAdd : Form
    {
        public OperasyonAdd()
        {
            InitializeComponent();
            badd.FlatAppearance.BorderSize = 0;
            bhome.FlatAppearance.BorderSize = 0;
            binfo.FlatAppearance.BorderSize = 0;
            blogout.FlatAppearance.BorderSize = 0;
            bexit.FlatAppearance.BorderSize = 0;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OperasyonClass myclass = new OperasyonClass();
                myclass.operasyonekle(toadi.Text,totanim.Text);
                MessageBox.Show("yuppi");
            }
            catch (Exception)
            {
                MessageBox.Show("hatalı");
            }
        }
    }
}
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
    public partial class YoneticiMain : Form
    {
        public YoneticiMain()
        {
            InitializeComponent();
            RaporClass myclass = new RaporClass();
            myclass.YeniRapor();
            button1.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.BorderSize = 0;
            button4.FlatAppearance.BorderSize = 0;
            button5.FlatAppearance.BorderSize = 0;
            button7.FlatAppearance.BorderSize = 0;
            button8.FlatAppearance.BorderSize = 0;
            button9.FlatAppearance.BorderSize = 0;
            button10.FlatAppearance.BorderSize = 0;
            button11.FlatAppearance.BorderSize = 0;
            button12.FlatAppearance.BorderSize = 0;
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            HammaddestokSearch nextForm = new HammaddestokSearch();
            nextForm.Show();
            this.Dispose();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Form1 nextForm = new Form1();
            nextForm.Show();
            this.Dispose();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Hakkında nextForm = new Hakkında();
            nextForm.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            PersonelSearch nextForm = new PersonelSearch();
            nextForm.Show();
            this.Dispose();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            VerimSearch nextForm = new VerimSearch();
            nextForm.Show();
            this.Dispose();
        }

        private void rapor_Click(object sender, EventArgs e)
        {
            MakineSearch nextForm = new MakineSearch();
            nextForm.Show();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UrunStokSearch nextForm = new UrunStokSearch();
            nextForm.Show();
            this.Dispose();
        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OperasyonSearch nextForm = new OperasyonSearch();
            nextForm.Show();
            this.Dispose();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            UrunSearch nextForm = new UrunSearch();
            nextForm.Show();
            this.Dispose();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Rapor nextForm = new Rapor();
            nextForm.Show();
            this.Dispose();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            SSiparisSearch nextForm = new SSiparisSearch();
            nextForm.Show();
            this.Dispose();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            ASiparisSearch nextForm = new ASiparisSearch();
            nextForm.Show();
            this.Dispose();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            TedarikciSearch nextForm = new TedarikciSearch();
            nextForm.Show();
            this.Dispose();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            MusteriSearch nextForm = new MusteriSearch();
            nextForm.Show();
            this.Dispose();
        }
    }
}

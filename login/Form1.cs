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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.FlatAppearance.BorderSize = 0;
            this.ActiveControl = this.panel1;

           



        }

        /*    private void textBox1_MouseEnter(object sender, EventArgs e)
                {
                    /*textBox1.BackColor = Color.LightGray;*//*
                   panel3.BackColor = Color.LightGray;
                    panel5.BackColor = Color.DeepSkyBlue;
               }

                private void textBox1_MouseLeave(object sender, EventArgs e)
                {
                    textBox1.BackColor = Color.White;
                    panel3.BackColor = Color.White;
                    panel5.BackColor = Color.White;
                }

                private void textBox2_MouseEnter(object sender, EventArgs e)
                {

                    /*textBox2.BackColor = Color.LightGray;*//*
                    panel4.BackColor = Color.LightGray;
                    panel6.BackColor = Color.DeepSkyBlue;
                }

                private void textBox2_MouseLeave(object sender, EventArgs e)
                {
                    textBox2.BackColor = Color.White;
                    panel4.BackColor = Color.White;
                    panel6.BackColor = Color.White;
                }
                */

        private void textBox2_Enter(object sender, EventArgs e)
        {
            panel4.BackColor = Color.Gainsboro;
            panel6.BackColor = Color.DeepSkyBlue;
            if (textBox2.Text=="Şifre")
            {
                textBox2.Text = "";
                textBox2.UseSystemPasswordChar = true;
            }
            
            
        }
        
        private void textBox2_Leave(object sender, EventArgs e)
        {

            panel4.BackColor = Color.WhiteSmoke;
            panel6.BackColor = Color.WhiteSmoke;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            panel3.BackColor = Color.Gainsboro;
            panel5.BackColor = Color.DeepSkyBlue;
            if (textBox1.Text == "Kullanıcı Adı")
            {
                textBox1.Text = "";
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            panel3.BackColor = Color.WhiteSmoke;
            panel5.BackColor = Color.WhiteSmoke;
        }

        private void panel9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel10_Click(object sender, EventArgs e)
        {
            if (textBox2.UseSystemPasswordChar == false)
            textBox2.UseSystemPasswordChar = true;
            else textBox2.UseSystemPasswordChar = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            YoneticiMain nextForm = new YoneticiMain();
            this.Hide();
            nextForm.ShowDialog();
            this.Close();
        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

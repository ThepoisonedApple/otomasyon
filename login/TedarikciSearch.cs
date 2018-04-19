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
    public partial class TedarikciSearch : Form
    {
        Graphics gr_graphics = default(Graphics);
        public TedarikciSearch()
        {
            InitializeComponent();
            button1.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.BorderSize = 0;
            button9.FlatAppearance.BorderSize = 0;
            button10.FlatAppearance.BorderSize = 0;
            button11.FlatAppearance.BorderSize = 0;
            button12.FlatAppearance.BorderSize = 0;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            MusteritemsilcisiAlim nextForm = new MusteritemsilcisiAlim();
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
        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            Pen pen_draw = new Pen(Color.FromArgb(59, 175, 218));
            gr_graphics = e.Graphics;
            //Draw a triangle on the form.
            //first have to define an array of points.
            Point[] pnt = new Point[3];

            pnt[0].X = 0;
            pnt[0].Y = 0;

            pnt[1].X = 49;
            pnt[1].Y = 0;

            pnt[2].X = 25;
            pnt[2].Y = 16;

            gr_graphics.DrawPolygon(pen_draw, pnt);
            gr_graphics.FillPolygon(new SolidBrush(Color.FromArgb(59, 175, 218)), pnt);
        }
        private void panel8_Paint(object sender, PaintEventArgs e)
        {
            Pen pen_draw = new Pen(Color.FromArgb(55, 188, 155));
            gr_graphics = e.Graphics;
            //Draw a triangle on the form.
            //first have to define an array of points.
            Point[] pnt = new Point[3];

            pnt[0].X = 0;
            pnt[0].Y = 0;

            pnt[1].X = 49;
            pnt[1].Y = 0;

            pnt[2].X = 25;
            pnt[2].Y = 16;

            gr_graphics.DrawPolygon(pen_draw, pnt);
            gr_graphics.FillPolygon(new SolidBrush(Color.FromArgb(55, 188, 155)), pnt);
        }
        private void panel4_Click(object sender, EventArgs e)
        {
            panel8.Show();
            panel7.Hide();
            panel2.Hide();
            panel11.Show();
        }
        private void panel5_Click(object sender, EventArgs e)
        {
            panel8.Show();
            panel7.Hide();
            panel2.Hide();
            panel11.Show();
        }
        private void label2_Click(object sender, EventArgs e)
        {
            panel8.Show();
            panel7.Hide();
            panel2.Hide();
            panel11.Show();
        }
        private void panel6_Click(object sender, EventArgs e)
        {
            panel7.Show();
            panel8.Hide();
            panel2.Show();
            panel11.Hide();
        }

        private void panel3_Click(object sender, EventArgs e)
        {
            panel7.Show();
            panel8.Hide();
            panel2.Show();
            panel11.Hide();

        }
        private void label1_Click(object sender, EventArgs e)
        {
            panel7.Show();
            panel8.Hide();
            panel2.Show();
            panel11.Hide();
        }
    }
}

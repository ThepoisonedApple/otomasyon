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
    public partial class Rapor : Form
    {
        Graphics gr_graphics = default(Graphics);
        public Rapor()
        {
            InitializeComponent();
            button1.FlatAppearance.BorderSize = 0;
            button9.FlatAppearance.BorderSize = 0;
            button10.FlatAppearance.BorderSize = 0;
            button11.FlatAppearance.BorderSize = 0;
            button12.FlatAppearance.BorderSize = 0;
            comboBox1.SelectedIndex = 0;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            YoneticiMain nextForm = new YoneticiMain();
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



        private void button2_Click(object sender, EventArgs e)
        {
            RaporClass myclass = new RaporClass();
            RaporClass.mylist.Clear();
            listView2.Items.Clear();
            try
            {
                myclass.RaporListele();

                bool x = true;
                int i = 0;
                while (x)
                {
                    ListViewItem item = new ListViewItem(RaporClass.mylist[i]);
                    item.SubItems.Add(RaporClass.mylist[i + 1]);
                    item.SubItems.Add(RaporClass.mylist[i + 2]);
                    item.SubItems.Add(RaporClass.mylist[i + 3]);
                    item.SubItems.Add(RaporClass.mylist[i + 4]);
                    item.SubItems.Add(RaporClass.mylist[i + 5]);
                    i = i + 6;
                    listView2.Items.Add(item);
                    if (RaporClass.mylist.Count == i)
                    {
                        x = false;
                        break;
                    }
                }
            }
            catch (Exception)
            {
                DBconnect.connectionclose();
                MessageBox.Show("Rapor Bulunamadı");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RaporClass.mylist.Clear();
            listView1.Items.Clear();
            RaporClass myclass = new RaporClass();
            try
            {
                myclass.RaporAra(Convert.ToDateTime(tuad.Text));

                bool x = true;
                int i = 0;
                while (x)
                {
                    ListViewItem item = new ListViewItem(RaporClass.mylist[i]);
                    item.SubItems.Add(RaporClass.mylist[i + 1]);
                    item.SubItems.Add(RaporClass.mylist[i + 2]);
                    item.SubItems.Add(RaporClass.mylist[i + 3]);
                    item.SubItems.Add(RaporClass.mylist[i + 4]);
                    item.SubItems.Add(RaporClass.mylist[i + 5]);
                    i = i + 6;
                    listView1.Items.Add(item);
                    if (RaporClass.mylist.Count == i)
                    {
                        x = false;
                        break;
                    }
                }
            }
            catch (Exception)
            {
                DBconnect.connectionclose();
                MessageBox.Show("Rapor Bulunamadı");
            }
        }

        private void tuad_Enter(object sender, EventArgs e)
        {
            if (tuad.ForeColor==Color.Silver)
            {
                tuad.ResetText();
                tuad.ForeColor = Color.Black;

            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Hakkında nextForm = new Hakkında();
            nextForm.Show();
        }
    }
}

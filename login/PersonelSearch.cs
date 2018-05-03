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
    public partial class PersonelSearch : Form
    {
        Graphics gr_graphics = default(Graphics);
        //need a pen for drawing and make it black
        string sorgu;
        List<string> bolumler = new List<string>();
        string z;
        public PersonelSearch()
        {
            InitializeComponent();
            bsearch.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.BorderSize = 0;
            bhome.FlatAppearance.BorderSize = 0;
            binfo.FlatAppearance.BorderSize = 0;
            blogout.FlatAppearance.BorderSize = 0;
            bexit.FlatAppearance.BorderSize = 0;
            //comboBox2.SelectedIndex = 2;
            bolumler.Add("yok");
            bolumler.Add("Yönetici");
            bolumler.Add("Bölüm Şefi");
            bolumler.Add("İnsan Kaynakları");
            bolumler.Add("Müşteri Temsilcisi");
            bolumler.Add("Stok");
            bolumler.Add("Modelleme");
            bolumler.Add("Makine Bakım");

        }



        #region ucgen ciz
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

        #endregion
        #region ara/listele gecisi
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
        #endregion
        #region sayfa gecisi
        private void bexit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bhome_Click(object sender, EventArgs e)
        {
            if (Form1.YID == 1)
            {
                YoneticiMain NextForm = new YoneticiMain();
                NextForm.Show();
                this.Dispose();
            }
            else
            {
                IKMain nextForm = new IKMain();
                nextForm.Show();
                this.Dispose();
            }
        }

        private void blogout_Click(object sender, EventArgs e)
        {
            Form1 nextForm = new Form1();
            nextForm.Show();
            this.Dispose();
        }




        #endregion


        private void bsearch_Click(object sender, EventArgs e)
        {
            try
            {
                PersonelClass.mylist.Clear();
                listView1.Items.Clear();
                bool x = true;
                int i = 0;
                PersonelClass myclass = new PersonelClass();
                myclass.PersonelAra(tpad.Text, tpsad.Text);
                while (x)
                {
                    ListViewItem item = new ListViewItem(PersonelClass.mylist[i]);
                    item.SubItems.Add(PersonelClass.mylist[i + 1]);
                    item.SubItems.Add(PersonelClass.mylist[i + 2]);
                    item.SubItems.Add(PersonelClass.mylist[i + 3]);
                    item.SubItems.Add(PersonelClass.mylist[i + 4]);
                    item.SubItems.Add(bolumler[Convert.ToInt32(PersonelClass.mylist[i + 5])]);
                    item.SubItems.Add(PersonelClass.mylist[i + 6]);
                    item.SubItems.Add(PersonelClass.mylist[i + 7]);
                    item.SubItems.Add(PersonelClass.mylist[i + 8]);
                    i = i + 9;
                    listView1.Items.Add(item);
                    if (PersonelClass.mylist.Count == i)
                    {
                        x = false;
                        break;
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Aramanızla Eşleşen Sonuç Bulunamadı");
            }

            
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            z = (comboBox2.SelectedIndex + 1).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                PersonelClass.mylist.Clear();
                listView2.Items.Clear();
                bool x = true;
                int i = 0;
                PersonelClass myclass = new PersonelClass();

                myclass.Personellistele(z, sorgu);
                while (x)
                {
                    ListViewItem item = new ListViewItem(PersonelClass.mylist[i]);
                    item.SubItems.Add(PersonelClass.mylist[i + 1]);
                    item.SubItems.Add(PersonelClass.mylist[i + 2]);
                    item.SubItems.Add(PersonelClass.mylist[i + 3]);
                    item.SubItems.Add(PersonelClass.mylist[i + 4]);
                    item.SubItems.Add(bolumler[Convert.ToInt32(PersonelClass.mylist[i + 5])]);
                    item.SubItems.Add(PersonelClass.mylist[i + 6]);
                    item.SubItems.Add(PersonelClass.mylist[i + 7]);
                    item.SubItems.Add(PersonelClass.mylist[i + 8]);
                    i = i + 9;
                    listView2.Items.Add(item);
                    if (PersonelClass.mylist.Count == i)
                    {
                        x = false;
                        break;
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Aramanızla Eşleşen Sonuç Bulunamadı");
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 1)
            {
                textBox1.Hide();
                comboBox2.Show();
                sorgu = "bolum_id";
                z = (comboBox2.SelectedIndex + 1).ToString();
            }
            else
            {

                comboBox2.Hide();
                textBox1.Show();
                sorgu = "pozisyon";
            }
            }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            z = textBox1.Text;
        }

        private void PersonelSearch_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'otomasyonDataSet.yetki_bolum' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.yetki_bolumTableAdapter.Fill(this.otomasyonDataSet.yetki_bolum);

        }

        private void binfo_Click(object sender, EventArgs e)
        {
            Hakkında nextForm = new Hakkında();
            nextForm.Show();
        }
    }
}

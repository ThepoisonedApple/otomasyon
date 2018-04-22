using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data;
using System.Windows.Forms;

namespace login
{
    class DBconnect
    {

        public static string baglantiSatiri = "Server=localhost;User ID=postgres;password=159357;Database=Otomasyon";

        public static NpgsqlConnection baglanti = new NpgsqlConnection(baglantiSatiri);

        public void connectionopen()
        {
            if (baglanti.State==ConnectionState.Closed)
            {
                try
                {
                    
                    baglanti.Open();
                }

                catch (Exception a)
                {
                    MessageBox.Show("Hata !!! " + a.ToString());
                }
            }

        }
        public void connectionclose()
        {

            if (baglanti.State == ConnectionState.Open)
            {
                try
                {

                    baglanti.Close();
                }

                catch (Exception a)
                {
                    MessageBox.Show("Hata !!! " + a.ToString());
                }
            }
        }




    }
}


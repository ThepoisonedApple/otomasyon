using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Forms;

namespace login
{
    class SifreUnuttumClass
    {
        public int GuvenlikSoruCevap(string kad,string kgs,string kgc)
        {
             
            DBconnect.connectionopen();
            string query = "select COUNT(kullanici_id) FROM kullanici WHERE (kullanici_adi='" + kad + "') AND (guvenlik_soru='" + kgs + "') AND (guvenlik_cevap='"+kgc+"');";
            NpgsqlCommand comm1 = new NpgsqlCommand(query, DBconnect.baglanti);
            Int32 count1 = Convert.ToInt32(comm1.ExecuteScalar());
            if (count1 == 0)
            {
                MessageBox.Show("Girdiğiniz bilgiler yanlış kontrol edip tekrar giriniz");
                DBconnect.connectionclose();
                return count1;
            }
            else
            {
                DBconnect.connectionclose();
                DBconnect.connectionopen();
                string findkid = "SELECT kullanici_id FROM kullanici WHERE (kullanici_adi='" + kad + "') AND (guvenlik_soru='" + kgs + "') AND (guvenlik_cevap='" + kgc + "');";
                NpgsqlCommand comm2 = new NpgsqlCommand(findkid , DBconnect.baglanti);
                var yetki_kid = comm2.ExecuteReader();
                yetki_kid.Read();
                string x = yetki_kid["kullanici_id"].ToString();
                DBconnect.connectionclose();
                return Convert.ToInt32(x);
            }


        }

        public void SifreDegistirFonk(string sifre,string kid)
        {
             
            DBconnect.connectionopen();
            string query = "UPDATE kullanici SET sifre='"+sifre+"' WHERE kullanici_id='"+kid+"';";
            NpgsqlCommand comm = new NpgsqlCommand(query,DBconnect.baglanti);
            comm.ExecuteNonQuery();
            DBconnect.connectionclose();


        }


    }
}

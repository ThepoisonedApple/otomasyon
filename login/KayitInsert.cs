using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace login
{
    class KayitInsert
    {
        public bool PidKontrol(string pid)
        {
            bool x;
            DBconnect mycon = new DBconnect();
            mycon.connectionopen();
            string query = "select COUNT(*) FROM personel WHERE personel_id="+pid+";";
            NpgsqlCommand comm1 = new NpgsqlCommand(query, DBconnect.baglanti);
            Int32 count1 = Convert.ToInt32(comm1.ExecuteScalar());
            if (count1 == 0)
            {
                x = false;
                MessageBox.Show("Personel ID'sini yanlış girdiniz");
                mycon.connectionclose();
                return x;
            }

            else mycon.connectionclose();
            mycon.connectionopen();
            query = "SELECT COUNT(*) FROM kullanici WHERE personel_id="+pid+";";
            NpgsqlCommand comm = new NpgsqlCommand(query,DBconnect.baglanti);
            Int32 count = Convert.ToInt32(comm.ExecuteScalar());
            mycon.connectionclose();
            if (count != 0)
            {
                x = false;
                MessageBox.Show("Her Personelin 1 kullanici hesabı olabilir");
                return x;
            }
            else return true;
        }


        public int TakeID(string pid)
        {
            

            DBconnect mycon = new DBconnect();

            mycon.connectionopen();
            string query = "SELECT bolum_id FROM personel WHERE personel_id=" + pid + ";";
            NpgsqlCommand yetkicek = new NpgsqlCommand(query, DBconnect.baglanti);
            var yetki = yetkicek.ExecuteReader();
            int x;

            yetki.Read();
            var yid = yetki["bolum_id"];
            x = Convert.ToInt32(yid);
            mycon.connectionclose();
            return x;
        }

        public void InsertKullanici(string kad,string sifre,string yid,string gs,string gc,string pid)
        {
            DBconnect mycon = new DBconnect();


            mycon.connectionopen();

            string query = string.Format("insert into kullanici (kullanici_adi,sifre,yetki_id,guvenlik_soru,guvenlik_cevap,personel_id) values ('{0}','{1}','{2}','{3}','{4}','{5}') ",
              kad,sifre,yid,gs,gc,pid);
            NpgsqlCommand newcommand = new NpgsqlCommand(query, DBconnect.baglanti);
            var reader = newcommand.ExecuteNonQuery();
            mycon.connectionclose();
        }


        public string Hashing(string sifre)
        {

            SHA256CryptoServiceProvider sha256 = new SHA256CryptoServiceProvider();
            byte[] inputBytes = Encoding.Unicode.GetBytes(sifre);
            byte[] hash = sha256.ComputeHash(inputBytes);
            

            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }


            return sb.ToString();
        }


    }
}

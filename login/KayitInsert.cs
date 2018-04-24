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
            NpgsqlCommand comm1 = new NpgsqlCommand();
            comm1.Connection = DBconnect.baglanti;
            comm1.CommandText = "SELECT COUNT(*) FROM personel WHERE personel_id=@pid;";
            comm1.Parameters.AddWithValue("@pid",Convert.ToInt32(pid));
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
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = DBconnect.baglanti;
            comm.CommandText = "SELECT COUNT(*) FROM kullanici WHERE personel_id=@pid;";
            comm.Parameters.AddWithValue("@pid",Convert.ToInt32(pid));
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
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = DBconnect.baglanti;
            command.CommandText= "SELECT bolum_id FROM personel WHERE personel_id=@pid;";
            command.Parameters.AddWithValue("@pid", Convert.ToInt32(pid));
            var yetki = command.ExecuteReader();
            int x;

            yetki.Read();
            var yid = yetki["bolum_id"];
            x = Convert.ToInt32(yid);
            mycon.connectionclose();
            return x;
        }

        public int kadkontrol(string kad)
        {
            DBconnect mycon = new DBconnect();
            mycon.connectionopen();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = DBconnect.baglanti;
            command.CommandText = "SELECT COUNT(*) FROM kullanici WHERE kullanici_adi=@kad;";
            command.Parameters.AddWithValue("@kad", kad);
            int x = Convert.ToInt32(command.ExecuteScalar());
            if (x!=0)
            {
                MessageBox.Show("Kullanıcı Adı başka bir kullanıcı tarafından Kullanılmaktadır.");
            }
            return x;
        }

        public void InsertKullanici(string kad,string sifre,string yid,string gs,string gc,string pid)
        {
            DBconnect mycon = new DBconnect();
            mycon.connectionopen();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = DBconnect.baglanti;
            command.CommandText = "INSERT INTO kullanici (kullanici_adi,sifre,yetki_id,guvenlik_soru,guvenlik_cevap,personel_id) " +
            "VALUES (@kad,@sifre,@yid,@gs,@gc,@pid)";
            command.Parameters.AddWithValue("@kad", kad);
            command.Parameters.AddWithValue("@sifre", sifre);
            command.Parameters.AddWithValue("@yid", Convert.ToInt32(yid));
            command.Parameters.AddWithValue("@gs", gs);
            command.Parameters.AddWithValue("@gc", gc);
            command.Parameters.AddWithValue("@pid", Convert.ToInt32(pid));
            var reader = command.ExecuteNonQuery();
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

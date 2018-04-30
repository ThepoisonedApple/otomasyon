using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
namespace login
{
    class VerimClass
    {
        public static int vid;
        public void VerimEkle(int pid,int uid,int oid,DateTime time,int toplam)
        {
            DBconnect mycon = new DBconnect();
            mycon.connectionopen();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = DBconnect.baglanti;
            command.CommandText = "INSERT INTO verim (urun_id,operasyon_id,personel_id,toplam,tarih)" +
                " VALUES (@uid,@oid,@pid,@toplam,@time)";
            command.Parameters.AddWithValue("@uid",uid);
            command.Parameters.AddWithValue("@oid", oid);
            command.Parameters.AddWithValue("@pid", pid);
            command.Parameters.AddWithValue("@toplam", toplam);
            command.Parameters.AddWithValue("@time", time);
            command.ExecuteNonQuery();
            mycon.connectionclose();
        }

        public string BilgileriGetir(int uid, int oid, int pid, DateTime time)
        {
            string[] x = new string[2];
            DBconnect mycon = new DBconnect();
            mycon.connectionopen();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = DBconnect.baglanti;
            command.CommandText = "select * from verim where urun_id=@uid and operasyon_id=@oid and personel_id=@pid and tarih=@time";
            command.Parameters.AddWithValue("@uid",uid);
            command.Parameters.AddWithValue("@oid", oid);
            command.Parameters.AddWithValue("@pid", pid);
            command.Parameters.AddWithValue("@time",time);
            NpgsqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
               x[0] = reader.GetValue(0).ToString();
               x[1] = reader.GetValue(4).ToString();
            }
            vid = Convert.ToInt32(x[0]);
            mycon.connectionclose();
            return x[1];
        }


        public void VerimGuncelle(int toplam)
        {
            DBconnect mycon = new DBconnect();
            mycon.connectionopen();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = DBconnect.baglanti;
            command.CommandText = "update verim set toplam=@toplam where verim_id=@x";
            command.Parameters.AddWithValue("@x", vid);
            command.Parameters.AddWithValue("@toplam", toplam);

            command.ExecuteNonQuery();
            mycon.connectionclose();
        }
    
        public void VerimSil()
        {
            DBconnect mycon = new DBconnect();
            mycon.connectionopen();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = DBconnect.baglanti;
            command.CommandText = "delete from verim where verim_id=@x";
            command.Parameters.AddWithValue("@x",vid);
            command.ExecuteNonQuery();
            mycon.connectionclose();
        }

        public void VerimListele()
        {


        }



    }
}

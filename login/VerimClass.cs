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
        public static List<string> mylist = new List<string>();
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

        public void VerimAra(string uid,string oid,string pid,string tarih)
        {
            DBconnect mycon = new DBconnect();
            mycon.connectionopen();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = DBconnect.baglanti;
            comm.CommandText = "SELECT * FROM verim WHERE (urun_id::text) LIKE @uid AND (operasyon_id::text) LIKE @oid AND (personel_id::text) LIKE @pid AND (tarih::text) LIKE @tarih ;";
            comm.Parameters.AddWithValue("@uid", "%" + uid + "%");
            comm.Parameters.AddWithValue("@oid", "%" + oid + "%");
            comm.Parameters.AddWithValue("@pid", "%" + pid + "%");
            comm.Parameters.AddWithValue("@tarih", "%" + tarih + "%");
            NpgsqlDataReader reader = comm.ExecuteReader();
            int x = 0;
            while (reader.Read())
            {

                mylist.Add(reader.GetValue(x).ToString());
                mylist.Add(reader.GetValue(x + 1).ToString());
                mylist.Add(reader.GetValue(x + 2).ToString());
                mylist.Add(reader.GetValue(x + 3).ToString());
                mylist.Add(reader.GetValue(x + 4).ToString());
                mylist.Add(reader.GetValue(x + 5).ToString());

            }

            mycon.connectionclose();


        }


        public void VerimListele(string degisken, int secim)
        {
            DBconnect mycon = new DBconnect();
            mycon.connectionopen();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = DBconnect.baglanti;
            if (secim == 0)
            {
                comm.CommandText = "SELECT * FROM verim WHERE urun_id=@degisken";
                comm.Parameters.AddWithValue("@degisken", Convert.ToInt32(degisken));
            }
            else if (secim == 1)
            {
                comm.CommandText = "SELECT * FROM verim WHERE operasyon_id=@degisken";
                comm.Parameters.AddWithValue("@degisken", Convert.ToInt32(degisken));
            }
            else if (secim == 2)
            {
                comm.CommandText = "SELECT * FROM verim WHERE personel_id=@degisken";
                comm.Parameters.AddWithValue("@degisken", Convert.ToInt32(degisken));
            }
            else
            {
                comm.CommandText = "SELECT * FROM verim WHERE tarih=@degisken";
                comm.Parameters.AddWithValue("@degisken", Convert.ToDateTime(degisken));
            }

            NpgsqlDataReader reader = comm.ExecuteReader();
            int x = 0;
            while (reader.Read())
            {

                mylist.Add(reader.GetValue(x).ToString());
                mylist.Add(reader.GetValue(x + 1).ToString());
                mylist.Add(reader.GetValue(x + 2).ToString());
                mylist.Add(reader.GetValue(x + 3).ToString());
                mylist.Add(reader.GetValue(x + 4).ToString());
                mylist.Add(reader.GetValue(x + 5).ToString());

            }


        }

    }
}

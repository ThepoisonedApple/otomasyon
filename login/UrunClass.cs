using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace login
{
    class UrunClass
    {
        public int UrunEkle(string uad,string utl,string ukl,int sid)
        {
            int adet=0;
            DBconnect mycon = new DBconnect();
            mycon.connectionopen();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = DBconnect.baglanti;
            command.CommandText = "INSERT INTO urun (adi,tasarim_link,kesim_link,siparis_id,adet) " +
            "VALUES (@uad,@utl,@ukl,@sid,@adet) "+
            "RETURNING urun_id";
            command.Parameters.AddWithValue("@uad",uad);
            command.Parameters.AddWithValue("@utl",utl);
            command.Parameters.AddWithValue("@ukl",ukl);
            command.Parameters.AddWithValue("@sid",sid);
            command.Parameters.AddWithValue("@adet",adet);
            var reader = command.ExecuteScalar();

            int iid =Convert.ToInt32(reader);
            mycon.connectionclose();
            return iid;


        }

        public string[] BilgiGetir(int uid)
        {
            string[] arr = new string[4];
            DBconnect mycon = new DBconnect();
            mycon.connectionopen();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = DBconnect.baglanti;
            command.CommandText = "SELECT * FROM urun WHERE urun_id=@uid";
            command.Parameters.AddWithValue("@uid",uid);
            NpgsqlDataReader comread = command.ExecuteReader();
            comread.Read();
            arr[0] = comread["adi"].ToString();
            arr[1] = comread["tasarim_link"].ToString();
            arr[2] = comread["kesim_link"].ToString();
            arr[3] = comread["siparis_id"].ToString();
            mycon.connectionclose();
            return arr;
        }

        public void UrunSil(int uid)
        {
            DBconnect mycon = new DBconnect();
            mycon.connectionopen();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = DBconnect.baglanti;
            command.CommandText = "DELETE FROM urun WHERE urun_id=@uid";
            command.Parameters.AddWithValue("@uid", uid);
            command.ExecuteNonQuery();
            mycon.connectionclose();

        }

        public void UrunGuncelle(int uid, string uad, string utl, string ukl, int sid)
        {
            DBconnect mycon = new DBconnect();
            mycon.connectionopen();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = DBconnect.baglanti;
            command.CommandText = "UPDATE urun SET adi=@uad, tasarim_link=@utl, kesim_link=@ukl, siparis_id=@sid WHERE urun_id=@uid;";
            command.Parameters.AddWithValue("@uad", uad);
            command.Parameters.AddWithValue("@utl", utl);
            command.Parameters.AddWithValue("@ukl", ukl);
            command.Parameters.AddWithValue("@sid", sid);
            command.Parameters.AddWithValue("@uid", uid);
            command.ExecuteNonQuery();
            mycon.connectionclose();
        }

        public void UruneOperasyonEkle(int uid,int oid)
        {
            DBconnect mycon = new DBconnect();
            mycon.connectionopen();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = DBconnect.baglanti;
            command.CommandText = "INSERT INTO urun_operasyon (urun_id,operasyon_id) VALUES (@uid,@oid)";
            command.Parameters.AddWithValue("@uid",uid);
            command.Parameters.AddWithValue("@oid",oid);
            command.ExecuteNonQuery();
            mycon.connectionclose();

        }
        public void UruneHammaddeEkle(int uid,int hid)
        {
            DBconnect mycon = new DBconnect();
            mycon.connectionopen();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = DBconnect.baglanti;
            command.CommandText = "INSERT INTO urun_hammadde (urun_id,hammadde_id) VALUES (@uid,@hid)";
            command.Parameters.AddWithValue("@uid", uid);
            command.Parameters.AddWithValue("@hid", hid);
            command.ExecuteNonQuery();
            mycon.connectionclose();
        }
        public void UrundenOperasyonSil(int uid,int oid)
        {
            DBconnect mycon = new DBconnect();
            mycon.connectionopen();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = DBconnect.baglanti;
            command.CommandText = "DELETE FROM urun_operasyon WHERE urun_id=@uid and operasyon_id=@oid";
            command.Parameters.AddWithValue("@uid", uid);
            command.Parameters.AddWithValue("@oid", oid);
            command.ExecuteNonQuery();
            mycon.connectionclose();
        }
        public void UrundenHammaddeSil(int uid,int hid)
        {
            DBconnect mycon = new DBconnect();
            mycon.connectionopen();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = DBconnect.baglanti;
            command.CommandText = "DELETE FROM urun_hammadde WHERE urun_id=@uid and hammadde_id=@hid";
            command.Parameters.AddWithValue("@uid", uid);
            command.Parameters.AddWithValue("@hid", hid);
            command.ExecuteNonQuery();
            mycon.connectionclose();
        }

    }
}

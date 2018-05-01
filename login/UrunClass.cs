﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Forms;

namespace login
{
    class UrunClass
    {
        public static List<string> hammaddelist = new List<string>();
        public static List<string> operasyonlist = new List<string>();

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
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = DBconnect.baglanti;
            mycon.connectionopen();
            command.CommandText = "SELECT COUNT(urun_id) FROM verim WHERE urun_id=@uid";
            command.Parameters.AddWithValue("@uid",uid);
            int i =Convert.ToInt32(command.ExecuteScalar());
            string x = "Bu ürün üretim aşamasına geçmiştir ilişkili " + i.ToString() + " veri bulunmaktadır silinemez.";
            if (i==0)
            {

                mycon.connectionopen();
                command.CommandText = "DELETE FROM urun_operasyon WHERE urun_id=@uid";
                command.Parameters.AddWithValue("@uid", uid);
                command.ExecuteNonQuery();
                mycon.connectionclose();

                mycon.connectionopen();
                command.CommandText = "DELETE FROM urun_hammadde WHERE urun_id=@uid";
                command.Parameters.AddWithValue("@uid", uid);
                command.ExecuteNonQuery();
                mycon.connectionclose();

                mycon.connectionopen();
                command.CommandText = "DELETE FROM urun WHERE urun_id=@uid";
                command.Parameters.AddWithValue("@uid", uid);
                command.ExecuteNonQuery();
                mycon.connectionclose();

            }
            else
            {
                MessageBox.Show(x);
            }



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

        public void AratabloListele(int uid)
        {
            DBconnect mycon = new DBconnect();
            mycon.connectionopen();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = DBconnect.baglanti;
            command.CommandText = "select operasyon_id from urun_operasyon where urun_id=@uid";
            command.Parameters.AddWithValue("@uid", uid);
            NpgsqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                operasyonlist.Add(Convert.ToString(reader.GetValue(0)));
            }
            reader.Close();
            mycon.connectionclose();
            mycon.connectionopen();
            command.CommandText = "select hammadde_id from urun_hammadde where urun_id=@uid";
            command.Parameters.AddWithValue("@uid", uid);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                hammaddelist.Add(Convert.ToString(reader.GetValue(0)));
            }
            mycon.connectionclose();
        }

    }
}

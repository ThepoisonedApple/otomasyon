using System;
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
        public static List<string> mylist = new List<string>();

        public int UrunEkle(string uad, string utl, string ukl, int sid)
        {
            int adet = 0;
             
            DBconnect.connectionopen();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = DBconnect.baglanti;
            command.CommandText = "INSERT INTO urun (adi,tasarim_link,kesim_link,siparis_id,adet) " +
            "VALUES (@uad,@utl,@ukl,@sid,@adet) " +
            "RETURNING urun_id";
            command.Parameters.AddWithValue("@uad", uad);
            command.Parameters.AddWithValue("@utl", utl);
            command.Parameters.AddWithValue("@ukl", ukl);
            command.Parameters.AddWithValue("@sid", sid);
            command.Parameters.AddWithValue("@adet", adet);
            var reader = command.ExecuteScalar();

            int iid = Convert.ToInt32(reader);
            DBconnect.connectionclose();
            return iid;


        }

        public string[] BilgiGetir(int uid)
        {
            string[] arr = new string[4];
             
            DBconnect.connectionopen();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = DBconnect.baglanti;
            command.CommandText = "SELECT * FROM urun WHERE urun_id=@uid";
            command.Parameters.AddWithValue("@uid", uid);
            NpgsqlDataReader comread = command.ExecuteReader();
            comread.Read();
            arr[0] = comread["adi"].ToString();
            arr[1] = comread["tasarim_link"].ToString();
            arr[2] = comread["kesim_link"].ToString();
            arr[3] = comread["siparis_id"].ToString();
            DBconnect.connectionclose();
            return arr;
        }

        public void UrunSil(int uid)
        {
             
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = DBconnect.baglanti;
            DBconnect.connectionopen();
            command.CommandText = "SELECT COUNT(urun_id) FROM verim WHERE urun_id=@uid";
            command.Parameters.AddWithValue("@uid", uid);
            int i = Convert.ToInt32(command.ExecuteScalar());
            string x = "Bu ürün üretim aşamasına geçmiştir ilişkili " + i.ToString() + " veri bulunmaktadır silinemez.";
            if (i == 0)
            {

                DBconnect.connectionopen();
                command.CommandText = "DELETE FROM urun_operasyon WHERE urun_id=@uid";
                command.Parameters.AddWithValue("@uid", uid);
                command.ExecuteNonQuery();
                DBconnect.connectionclose();

                DBconnect.connectionopen();
                command.CommandText = "DELETE FROM urun_hammadde WHERE urun_id=@uid";
                command.Parameters.AddWithValue("@uid", uid);
                command.ExecuteNonQuery();
                DBconnect.connectionclose();

                DBconnect.connectionopen();
                command.CommandText = "DELETE FROM urun WHERE urun_id=@uid";
                command.Parameters.AddWithValue("@uid", uid);
                command.ExecuteNonQuery();
                DBconnect.connectionclose();

            }
            else
            {
                MessageBox.Show(x);
            }



        }

        public void UrunGuncelle(int uid, string uad, string utl, string ukl, int sid)
        {
             
            DBconnect.connectionopen();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = DBconnect.baglanti;
            command.CommandText = "UPDATE urun SET adi=@uad, tasarim_link=@utl, kesim_link=@ukl, siparis_id=@sid WHERE urun_id=@uid;";
            command.Parameters.AddWithValue("@uad", uad);
            command.Parameters.AddWithValue("@utl", utl);
            command.Parameters.AddWithValue("@ukl", ukl);
            command.Parameters.AddWithValue("@sid", sid);
            command.Parameters.AddWithValue("@uid", uid);
            command.ExecuteNonQuery();
            DBconnect.connectionclose();
        }

        public void UruneOperasyonEkle(int uid, int oid)
        {
             
            DBconnect.connectionopen();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = DBconnect.baglanti;
            command.CommandText = "INSERT INTO urun_operasyon (urun_id,operasyon_id) VALUES (@uid,@oid)";
            command.Parameters.AddWithValue("@uid", uid);
            command.Parameters.AddWithValue("@oid", oid);
            command.ExecuteNonQuery();
            DBconnect.connectionclose();

        }
        public void UruneHammaddeEkle(int uid, int hid)
        {
             
            DBconnect.connectionopen();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = DBconnect.baglanti;
            command.CommandText = "INSERT INTO urun_hammadde (urun_id,hammadde_id) VALUES (@uid,@hid)";
            command.Parameters.AddWithValue("@uid", uid);
            command.Parameters.AddWithValue("@hid", hid);
            command.ExecuteNonQuery();
            DBconnect.connectionclose();
        }
        public void UrundenOperasyonSil(int uid, int oid)
        {
             
            DBconnect.connectionopen();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = DBconnect.baglanti;
            command.CommandText = "DELETE FROM urun_operasyon WHERE urun_id=@uid and operasyon_id=@oid";
            command.Parameters.AddWithValue("@uid", uid);
            command.Parameters.AddWithValue("@oid", oid);
            command.ExecuteNonQuery();
            DBconnect.connectionclose();
        }
        public void UrundenHammaddeSil(int uid, int hid)
        {
             
            DBconnect.connectionopen();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = DBconnect.baglanti;
            command.CommandText = "DELETE FROM urun_hammadde WHERE urun_id=@uid and hammadde_id=@hid";
            command.Parameters.AddWithValue("@uid", uid);
            command.Parameters.AddWithValue("@hid", hid);
            command.ExecuteNonQuery();
            DBconnect.connectionclose();
        }

        public void AratabloListele(int uid)
        {
             
            DBconnect.connectionopen();
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
            DBconnect.connectionclose();
            DBconnect.connectionopen();
            command.CommandText = "select hammadde_id from urun_hammadde where urun_id=@uid";
            command.Parameters.AddWithValue("@uid", uid);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                hammaddelist.Add(Convert.ToString(reader.GetValue(0)));
            }
            DBconnect.connectionclose();
        }

        public void UrunAra(string ad)
        {
             
            DBconnect.connectionopen();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = DBconnect.baglanti;
            command.CommandText = "select * from urun where adi like @uid";
            command.Parameters.AddWithValue("@uid", "%" + ad + "%");
            NpgsqlDataReader reader = command.ExecuteReader();
            int x = 0;
            while (reader.Read())
            {

                mylist.Add(reader.GetValue(x).ToString());
                mylist.Add(reader.GetValue(x + 1).ToString());
                mylist.Add(reader.GetValue(x + 2).ToString());
                mylist.Add(reader.GetValue(x + 3).ToString());
                mylist.Add(reader.GetValue(x + 4).ToString());
                mylist.Add("");
                mylist.Add("");

            }
            DBconnect.connectionclose();
            for (int i = 0; i < mylist.Count; i = i + 7)
            {
                hammaddelist.Clear();
                operasyonlist.Clear();
                string ham = "";
                string ope = "";
                AratabloListele(Convert.ToInt32(mylist[i]));
                for (int j = 0; j < hammaddelist.Count; j++)
                {
                    ham = ham + hammaddelist[j] + ",";
                }

                for (int j = 0; j < operasyonlist.Count; j++)
                {
                    ope = ope + operasyonlist[j] + ",";
                }

                mylist[i + 5] = ham;
                mylist[i + 6] = ope;

            }

        }
        public void UrunListele(string sid)
        {
             
            DBconnect.connectionopen();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = DBconnect.baglanti;
            command.CommandText = "select * from urun where siparis_id=@uid";
            command.Parameters.AddWithValue("@uid", Convert.ToInt32(sid));
            NpgsqlDataReader reader = command.ExecuteReader();
            int x = 0;
            while (reader.Read())
            {

                mylist.Add(reader.GetValue(x).ToString());
                mylist.Add(reader.GetValue(x + 1).ToString());
                mylist.Add(reader.GetValue(x + 2).ToString());
                mylist.Add(reader.GetValue(x + 3).ToString());
                mylist.Add(reader.GetValue(x + 4).ToString());
                mylist.Add("");
                mylist.Add("");

            }
            DBconnect.connectionclose();
            for (int i = 0; i < mylist.Count; i = i + 7)
            {
                hammaddelist.Clear();
                operasyonlist.Clear();
                string ham = "";
                string ope = "";
                AratabloListele(Convert.ToInt32(mylist[i]));
                for (int j = 0; j < hammaddelist.Count; j++)
                {
                    ham = ham + hammaddelist[j] + ",";
                }

                for (int j = 0; j < operasyonlist.Count; j++)
                {
                    ope = ope + operasyonlist[j] + ",";
                }

                mylist[i + 5] = ham;
                mylist[i + 6] = ope;

            }

        }
    }
}
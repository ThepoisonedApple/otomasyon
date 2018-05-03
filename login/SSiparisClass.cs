using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace login
{
    class SSiparisClass
    {
        public static List<string> mylist = new List<string>();
        public void SsipEkle(int mid, DateTime date, DateTime date1, int adet, int fiyat, string bilgi)
        {
             
            DBconnect.connectionopen();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = DBconnect.baglanti;
            command.CommandText = "SELECT personel_id FROM kullanici WHERE kullanici_id = @kid";
            command.Parameters.AddWithValue("@kid", Convert.ToInt32(Form1.KID));
            int xyz = Convert.ToInt32(command.ExecuteScalar());
            DBconnect.connectionclose();

            DBconnect.connectionopen();
            command.CommandText = "INSERT INTO siparis (musteri_id, siparis_tarihi, teslim_tarihi, adet, fiyat, onaylayan_id, bilgi) VALUES (@mid, @date, @date1, @adet, @fiyat, @oid, @bilgi)";
            command.Parameters.AddWithValue("@mid", mid);
            command.Parameters.AddWithValue("@date", date);
            command.Parameters.AddWithValue("@date1", date1);
            command.Parameters.AddWithValue("@adet", adet);
            command.Parameters.AddWithValue("@fiyat", fiyat);
            command.Parameters.AddWithValue("@oid", xyz);
            command.Parameters.AddWithValue("@bilgi", bilgi);
            command.ExecuteNonQuery();
            DBconnect.connectionclose();
        }

        public string[] BilgiGetir(int id)
        {
             
            DBconnect.connectionopen();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = DBconnect.baglanti;
            command.CommandText = "SELECT * FROM siparis WHERE siparis_id = @id;";
            command.Parameters.AddWithValue("@id", id);
            var comread = command.ExecuteReader();
            comread.Read();
            string[] arr = new string[6];
            arr[0] = comread["musteri_id"].ToString();
            arr[2] = comread["siparis_tarihi"].ToString();
            arr[3] = comread["teslim_tarihi"].ToString();
            arr[4] = comread["adet"].ToString();
            arr[5] = comread["fiyat"].ToString();
            arr[1] = comread["bilgi"].ToString();
            comread.Close();
            DBconnect.connectionclose();
            return arr;
        }

        public void SSipSil(int id)
        {
             
            DBconnect.connectionopen();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = DBconnect.baglanti;
            command.CommandText = "DELETE FROM siparis WHERE siparis_id=@id ;";
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
            DBconnect.connectionclose();

        }

        public void SsipGuncelle(int sid,int mid, DateTime date, DateTime date1, int adet, int fiyat, string bilgi)
        {
             
            DBconnect.connectionopen();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = DBconnect.baglanti;
            command.CommandText = "SELECT personel_id FROM kullanici WHERE kullanici_id = @kid";
            command.Parameters.AddWithValue("@kid", Convert.ToInt32(Form1.KID));
            int xyz = Convert.ToInt32(command.ExecuteScalar());
            DBconnect.connectionclose();

            DBconnect.connectionopen();

            command.CommandText = "UPDATE siparis set musteri_id=@mid, siparis_tarihi=@date, teslim_tarihi=@date1, adet=@adet, fiyat=@fiyat, onaylayan_id=@oid, bilgi=@bilgi where siparis_id=@sid";
            command.Parameters.AddWithValue("@sid", sid);
            command.Parameters.AddWithValue("@mid", mid);
            command.Parameters.AddWithValue("@date", date);
            command.Parameters.AddWithValue("@date1", date1);
            command.Parameters.AddWithValue("@adet", adet);
            command.Parameters.AddWithValue("@fiyat", fiyat);
            command.Parameters.AddWithValue("@oid", xyz);
            command.Parameters.AddWithValue("@bilgi", bilgi);
            command.ExecuteNonQuery();
            DBconnect.connectionclose();
        }

        public void SsipAra(string mid, string date)
        {
             
            DBconnect.connectionopen();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = DBconnect.baglanti;
            command.CommandText = "SELECT * FROM siparis WHERE (musteri_id::text) LIKE @mid AND (siparis_tarihi::text) LIKE @date;";
            command.Parameters.AddWithValue("@mid", "%" + mid + "%");
            command.Parameters.AddWithValue("@date", "%" + date + "%");
            NpgsqlDataReader reader = command.ExecuteReader();
            int x = 0;
            while (reader.Read())
            {

                mylist.Add(reader.GetValue(x).ToString());
                mylist.Add(reader.GetValue(x + 1).ToString());
                mylist.Add(reader.GetValue(x + 2).ToString());
                mylist.Add(reader.GetValue(x + 3).ToString());
                mylist.Add(reader.GetValue(x + 4).ToString());
                mylist.Add(reader.GetValue(x + 5).ToString());
                mylist.Add(reader.GetValue(x + 6).ToString());
                mylist.Add(reader.GetValue(x + 7).ToString());

            }

            DBconnect.connectionclose();

        }
    }
}

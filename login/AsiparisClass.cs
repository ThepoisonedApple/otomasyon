using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
namespace login
{
    class AsiparisClass
    {
        public static List<string> mylist = new List<string>();
        public void AsipEkle(int tid,int hid,DateTime date,DateTime date1,int adet,int fiyat)
        {
            DBconnect.connectionopen();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = DBconnect.baglanti;
            command.CommandText= "INSERT INTO hammadde_siparis (tedarikci_id, hammadde_id,siparis_tarihi, beklenen_tarih, adet, fiyat) VALUES (@tedarikci_id, @hammadde_id, @date1, @beklenen_tarih, @adet, @fiyat)";
            command.Parameters.AddWithValue("@tedarikci_id", tid);
            command.Parameters.AddWithValue("@hammadde_id", hid);
            command.Parameters.AddWithValue("@date1", date1);
            command.Parameters.AddWithValue("@beklenen_tarih", date);
            command.Parameters.AddWithValue("@adet", adet);
            command.Parameters.AddWithValue("@fiyat", fiyat);
            command.ExecuteNonQuery();
            DBconnect.connectionclose();
        }

        public string[] BilgiGetir(int id)
        {
            DBconnect.connectionopen();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = DBconnect.baglanti;
            command.CommandText = "SELECT * FROM hammadde_siparis where id = @id;";
            command.Parameters.AddWithValue("@id", id);
            var comread = command.ExecuteReader();
            comread.Read();
            string[] arr = new string[6];
            arr[0] = comread["tedarikci_id"].ToString();
            arr[1] = comread["hammadde_id"].ToString();
            arr[2] = comread["siparis_tarihi"].ToString();
            arr[3] = comread["beklenen_tarih"].ToString();
            arr[4] = comread["adet"].ToString();
            arr[5] = comread["fiyat"].ToString();
            comread.Close();
            DBconnect.connectionclose();
            return arr;         
        }

        public void AsipSil(int id)
        {
            DBconnect.connectionopen();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = DBconnect.baglanti;
            command.CommandText = "DELETE FROM hammadde_siparis WHERE id=@id;";
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
            DBconnect.connectionclose();

        }

        public void AsipGuncelle(int sid,int tid, int hid, DateTime date, DateTime date1, int adet, int fiyat)
        {

            DBconnect.connectionopen();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = DBconnect.baglanti;
            command.CommandText = "UPDATE hammadde_siparis SET tedarikci_id=@tid, hammadde_id = @hid, adet=@adet, fiyat=@fiyat, beklenen_tarih = @btarih, siparis_tarihi = @starih where id=@sid;";
            command.Parameters.AddWithValue("@tid", tid);
            command.Parameters.AddWithValue("@hid", hid);
            command.Parameters.AddWithValue("@starih", date1);
            command.Parameters.AddWithValue("@btarih", date);
            command.Parameters.AddWithValue("@adet", adet);
            command.Parameters.AddWithValue("@fiyat", fiyat);
            command.Parameters.AddWithValue("@sid", sid);
            command.ExecuteNonQuery();
            DBconnect.connectionclose();
        }

        public void AsipAra(string tid, string date)
        {
            DBconnect.connectionopen();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = DBconnect.baglanti;
            command.CommandText = "SELECT * FROM hammadde_siparis WHERE (tedarikci_id::text) LIKE @tid AND (siparis_tarihi::text) LIKE @date;";
            command.Parameters.AddWithValue("@tid","%"+tid+"%");
            command.Parameters.AddWithValue("@date","%"+date+"%");
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

            }

            DBconnect.connectionclose();

        }


    }
}

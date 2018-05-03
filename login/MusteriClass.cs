using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace login
{
    class MusteriClass
    {
        public static List<string> mylist = new List<string>();
        public void MusteriEkle(string yetkili_adi, string adres, string telefon, string email, string firma_adi)
        {
             
            DBconnect.connectionopen();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = DBconnect.baglanti;
            command.CommandText = "INSERT INTO musteri (yetkili_adi, adres, telefon, email, firma_adi) VALUES (@yetkili_adi, @adres, @telefon, @email, @firma_adi)";
            command.Parameters.AddWithValue("yetkili_adi", yetkili_adi);
            command.Parameters.AddWithValue("adres", adres);
            command.Parameters.AddWithValue("telefon", telefon);
            command.Parameters.AddWithValue("email", email);
            command.Parameters.AddWithValue("firma_adi", firma_adi);

            command.ExecuteNonQuery();
            DBconnect.connectionclose();
        }

        public string[] BilgiGetir(int id)
        {
             
            DBconnect.connectionopen();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = DBconnect.baglanti;
            command.CommandText = "SELECT * FROM musteri where musteri_id = @id;";
            command.Parameters.AddWithValue("@id", id);
            var comread = command.ExecuteReader();
            comread.Read();
            string[] arr = new string[5];
            arr[0] = comread["firma_adi"].ToString();
            arr[1] = comread["yetkili_adi"].ToString();
            arr[2] = comread["adres"].ToString();
            arr[3] = comread["telefon"].ToString();
            arr[4] = comread["email"].ToString();
            comread.Close();
            DBconnect.connectionclose();
            return arr;
        }

        public void MusteriSil(int id)
        {
             
            DBconnect.connectionopen();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = DBconnect.baglanti;
            command.CommandText = "DELETE FROM musteri WHERE musteri_id=@id ;";
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
            DBconnect.connectionclose();

        }

        public void MusteriGuncelle(int id, string y_adi, string t_adi, string adres, string tel, string email)
        {
             
            DBconnect.connectionopen();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = DBconnect.baglanti;
            command.CommandText = "UPDATE musteri set yetkili_adi = @yetkili_adi, adres = @adres, telefon=@telefon, email=@email, firma_adi = @firma_adi where musteri_id=@id";
            command.Parameters.AddWithValue("@yetkili_adi", y_adi);
            command.Parameters.AddWithValue("@adres", adres);
            command.Parameters.AddWithValue("@telefon", tel);
            command.Parameters.AddWithValue("@email", email);
            command.Parameters.AddWithValue("@firma_adi", t_adi);
            command.Parameters.AddWithValue("@id", id);
            command.ExecuteNonQuery();
            DBconnect.connectionclose();
        }

        public void MusteriAra(string tad)
        {
             
            DBconnect.connectionopen();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = DBconnect.baglanti;
            command.CommandText = "SELECT * FROM musteri WHERE firma_adi LIKE @tad;";
            command.Parameters.AddWithValue("@tad", "%" + tad + "%");
            NpgsqlDataReader reader = command.ExecuteReader();
            int x = 0;
            while (reader.Read())
            {

                mylist.Add(reader.GetValue(x).ToString());
                mylist.Add(reader.GetValue(x + 1).ToString());
                mylist.Add(reader.GetValue(x + 5).ToString());
                mylist.Add(reader.GetValue(x + 2).ToString());
                mylist.Add(reader.GetValue(x + 3).ToString());
                mylist.Add(reader.GetValue(x + 4).ToString());


            }

            DBconnect.connectionclose();

        }
    }
}

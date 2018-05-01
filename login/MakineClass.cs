using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace login
{
    class MakineClass
    {
        public static List<string> mylist = new List<string>();
        public void MakineEkle(string ad, bool durum, DateTime alimtarihi, DateTime bakimtarihi)
        {
            DBconnect mycon = new DBconnect();
            mycon.connectionopen();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = DBconnect.baglanti;
            command.CommandText = "INSERT INTO makine (ad,alim_tarihi,bakim_tarihi,durum) " +
                "VALUES (@mad,@malim,@mbakim,@mdurum);";
            command.Parameters.AddWithValue("@mad", ad);
            command.Parameters.AddWithValue("@malim", alimtarihi);
            command.Parameters.AddWithValue("@mbakim",bakimtarihi);
            command.Parameters.AddWithValue("@mdurum", durum);
            command.ExecuteNonQuery();
            mycon.connectionclose();


        }
        public string[] MakineBilgiGetir(string mid)
        {
            DBconnect mycon = new DBconnect();
            mycon.connectionopen();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = DBconnect.baglanti;
            command.CommandText = "SELECT * FROM makine WHERE makine_id=@mid";
            command.Parameters.AddWithValue("@mid", Convert.ToInt32(mid));
            var comread = command.ExecuteReader();
            comread.Read();
            string[] arr = new string[4];

            arr[0] = comread["ad"].ToString();
            arr[1] = comread["alim_tarihi"].ToString();
            arr[2] = comread["bakim_tarihi"].ToString();
            arr[3] = comread["durum"].ToString();

            mycon.connectionclose();
            return arr;
        }
        public void MakineGuncelle(string ad, bool durum, DateTime alimtarihi, DateTime bakimtarihi, int mid)
        {
            DBconnect mycon = new DBconnect();
            mycon.connectionopen();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = DBconnect.baglanti;
            command.CommandText = "UPDATE makine SET ad=@madi,durum=@mdurum,alim_tarihi=@malim , bakim_tarihi=@mbakim WHERE makine_id=@mid";
            command.Parameters.AddWithValue("@madi", ad);
            command.Parameters.AddWithValue("@mdurum", durum);
            command.Parameters.AddWithValue("@malim", alimtarihi);
            command.Parameters.AddWithValue("@mbakim", bakimtarihi);
            command.Parameters.AddWithValue("@mid", mid);


            command.ExecuteNonQuery();
            mycon.connectionclose();
        }
        public void MakineSil(string mid)
        {
            DBconnect mycon = new DBconnect();
            mycon.connectionopen();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = DBconnect.baglanti;
            command.CommandText = "DELETE FROM makine WHERE makine_id=@mid;";
            command.Parameters.AddWithValue("@mid", Convert.ToInt32(mid));
            command.ExecuteNonQuery();
            mycon.connectionclose();

        }

        public void MakineAra(string mad)
        {
            DBconnect mycon = new DBconnect();
            mycon.connectionopen();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = DBconnect.baglanti;
            command.CommandText = "SELECT * FROM makine WHERE ad LIKE @mad";
            command.Parameters.AddWithValue("@mad","%"+mad+"%");
            NpgsqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                mylist.Add(Convert.ToString(reader.GetValue(0)));
                mylist.Add(Convert.ToString(reader.GetValue(1)));
                mylist.Add(Convert.ToString(reader.GetValue(2)));
                mylist.Add(Convert.ToString(reader.GetValue(3)));
                mylist.Add(Convert.ToString(reader.GetValue(4)));

            }
            mycon.connectionclose();
        }
        public void MakineDurumListele(bool x)
        {
            DBconnect mycon = new DBconnect();
            mycon.connectionopen();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = DBconnect.baglanti;
            command.CommandText = "SELECT * FROM makine WHERE durum=@durum";
            command.Parameters.AddWithValue("@durum",x);
            NpgsqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                mylist.Add(Convert.ToString(reader.GetValue(0)));
                mylist.Add(Convert.ToString(reader.GetValue(1)));
                mylist.Add(Convert.ToString(reader.GetValue(2)));
                mylist.Add(Convert.ToString(reader.GetValue(3)));
                mylist.Add(Convert.ToString(reader.GetValue(4)));

            }
            mycon.connectionclose();
        }

        public void MakineTarihListele()
        {
            var x=DateTime.Today;
            DBconnect mycon = new DBconnect();
            mycon.connectionopen();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = DBconnect.baglanti;
            command.CommandText = "SELECT * FROM makine WHERE bakim_tarihi<=@durum";
            command.Parameters.AddWithValue("@durum", x);
            NpgsqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                mylist.Add(Convert.ToString(reader.GetValue(0)));
                mylist.Add(Convert.ToString(reader.GetValue(1)));
                mylist.Add(Convert.ToString(reader.GetValue(2)));
                mylist.Add(Convert.ToString(reader.GetValue(3)));
                mylist.Add(Convert.ToString(reader.GetValue(4)));

            }
            mycon.connectionclose();
        }

    }
}

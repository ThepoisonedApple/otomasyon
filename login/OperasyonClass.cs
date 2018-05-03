using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace login
{
    class OperasyonClass
    {
        public static List<string> mylist = new List<string>();
        public void operasyonekle(string oadi,string otanim)
        {
             
            DBconnect.connectionopen();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = DBconnect.baglanti;
            command.CommandText = "INSERT INTO operasyon (ad,tanim) "+"VALUES (@oadi,@otanim);";
            command.Parameters.AddWithValue("@oadi",oadi);
            command.Parameters.AddWithValue("@otanim", otanim);
            command.ExecuteNonQuery();
            DBconnect.connectionclose();


        }
        public string[] OperasyonBilgiGetir(string oid)
        {
             
            DBconnect.connectionopen();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = DBconnect.baglanti;
            command.CommandText = "SELECT * FROM operasyon WHERE operasyon_id=@oid";
            command.Parameters.AddWithValue("@oid", Convert.ToInt32(oid));
            var comread = command.ExecuteReader();
            comread.Read();
            string[] arr = new string[2];

            arr[0] = comread["ad"].ToString();
            arr[1] = comread["tanim"].ToString();
            
            DBconnect.connectionclose();
            return arr;
        }
        public void OperasyonGuncelle(string oadi, string otanim, int oid)
        {
             
            DBconnect.connectionopen();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = DBconnect.baglanti;
            command.CommandText = "UPDATE operasyon SET ad=@oadi,tanim=@otanim WHERE operasyon_id=@oid ";
            command.Parameters.AddWithValue("@oadi", oadi);
            command.Parameters.AddWithValue("@otanim", otanim);
            command.Parameters.AddWithValue("@oid", Convert.ToInt32(oid));
            command.ExecuteNonQuery();
            DBconnect.connectionclose();
        }
        public void OperasyonSil(string oid)
        {
             
            DBconnect.connectionopen();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = DBconnect.baglanti;
            command.CommandText = "DELETE FROM operasyon WHERE operasyon_id=@oid;";
            command.Parameters.AddWithValue("@oid", Convert.ToInt32(oid));
            command.ExecuteNonQuery();
            DBconnect.connectionclose();

        }
        public void OperasyonAra(string oad)
        {
             
            DBconnect.connectionopen();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = DBconnect.baglanti;
            command.CommandText = "SELECT * FROM operasyon WHERE ad LIKE @mad";
            command.Parameters.AddWithValue("@mad", "%" + oad + "%");
            NpgsqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                mylist.Add(Convert.ToString(reader.GetValue(0)));
                mylist.Add(Convert.ToString(reader.GetValue(1)));
                mylist.Add(Convert.ToString(reader.GetValue(2)));

            }
            DBconnect.connectionclose();
        }



    }
}

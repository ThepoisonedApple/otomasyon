using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace login
{
    class HammaddeClass
    {

        public static List<string> mylist = new List<string>();
        public void HammaddeEkle(string adi, int adet, int tid)
        {
            DBconnect.connectionopen();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = DBconnect.baglanti;
            command.CommandText = "INSERT INTO hammadde (adi,adet,tedarikci_id) " + "VALUES (@uadi,@uadet,@tid);";
            command.Parameters.AddWithValue("@uadi", adi);
            command.Parameters.AddWithValue("@uadet", adet);
            command.Parameters.AddWithValue("@tid", tid);
            command.ExecuteNonQuery();
            DBconnect.connectionclose();
        }
        public string[] HammaddeBilgiGetir(string uid)
        {
            DBconnect.connectionopen();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = DBconnect.baglanti;
            command.CommandText = "SELECT * FROM hammadde WHERE id=@uid";
            command.Parameters.AddWithValue("@uid", Convert.ToInt32(uid));
            var comread = command.ExecuteReader();
            comread.Read();
            string[] arr = new string[3];

            arr[0] = comread["adi"].ToString();
            arr[1] = comread["adet"].ToString();
            arr[2] = comread["tedarikci_id"].ToString();

            DBconnect.connectionclose();
            return arr;
        }
        public void HammaddeGuncelle(string adi, int adet, int tid , int id)
        {
            DBconnect.connectionopen();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = DBconnect.baglanti;
            command.CommandText = "UPDATE hammadde SET adi=@uadi,adet=@uadet , tedarikci_id=@ttdi WHERE id=@uid";
            command.Parameters.AddWithValue("@uadi", adi);
            command.Parameters.AddWithValue("@uadet", adet);
            command.Parameters.AddWithValue("@ttdi", tid);
            command.Parameters.AddWithValue("@uid", Convert.ToInt32(id));
            command.ExecuteNonQuery();
            DBconnect.connectionclose();
        }
        public void HammaddeSil(string uid)
        {
            DBconnect.connectionopen();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = DBconnect.baglanti;
            command.CommandText = "DELETE FROM hammadde WHERE id=@uid;";
            command.Parameters.AddWithValue("@uid", Convert.ToInt32(uid));
            command.ExecuteNonQuery();
            DBconnect.connectionclose();
            
        }

        public void UrunStokAra(string ad)
        {
            DBconnect.connectionopen();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = DBconnect.baglanti;
            comm.CommandText = "SELECT * FROM hammadde WHERE adi like @ad";
            comm.Parameters.AddWithValue("@ad", "%" + ad + "%");
            NpgsqlDataReader reader = comm.ExecuteReader();
            int x = 0;
            while (reader.Read())
            {
                mylist.Add(reader.GetValue(x).ToString());
                mylist.Add(reader.GetValue(x + 1).ToString());
                mylist.Add(reader.GetValue(x + 2).ToString());
                mylist.Add(reader.GetValue(x + 3).ToString());
            }
            DBconnect.connectionclose();
        }

        public void UrunStokListele(int ID)
        {
             
            DBconnect.connectionopen();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = DBconnect.baglanti;
            comm.CommandText = "SELECT * FROM hammadde WHERE tedarikci_id=@ID";
            comm.Parameters.AddWithValue("@ID",ID);
            NpgsqlDataReader reader = comm.ExecuteReader();
            int x = 0;
            while (reader.Read())
            {
                mylist.Add(reader.GetValue(x).ToString());
                mylist.Add(reader.GetValue(x + 1).ToString());
                mylist.Add(reader.GetValue(x + 2).ToString());
                mylist.Add(reader.GetValue(x + 3).ToString());
            }
            DBconnect.connectionclose();
        }
    }
}

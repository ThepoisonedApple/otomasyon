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
        public void HammaddeEkle(string adi, int adet, int tid)
        {
            DBconnect mycon = new DBconnect();
            mycon.connectionopen();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = DBconnect.baglanti;
            command.CommandText = "INSERT INTO hammadde (adi,adet,tedarikci_id) " + "VALUES (@uadi,@uadet,@tid);";
            command.Parameters.AddWithValue("@uadi", adi);
            command.Parameters.AddWithValue("@uadet", adet);
            command.Parameters.AddWithValue("@tid", tid);
            command.ExecuteNonQuery();
            mycon.connectionclose();


        }
        public string[] HammaddeBilgiGetir(string uid)
        {
            DBconnect mycon = new DBconnect();
            mycon.connectionopen();
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

            mycon.connectionclose();
            return arr;
        }
        public void HammaddeGuncelle(string adi, int adet, int tid , int id)
        {
            DBconnect mycon = new DBconnect();
            mycon.connectionopen();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = DBconnect.baglanti;
            command.CommandText = "UPDATE hammadde SET adi=@uadi,adet=@uadet , tedarikci_id=@ttdi WHERE id=@uid";
            command.Parameters.AddWithValue("@uadi", adi);
            command.Parameters.AddWithValue("@uadet", adet);
            command.Parameters.AddWithValue("@ttdi", tid);
            command.Parameters.AddWithValue("@uid", Convert.ToInt32(id));
            command.ExecuteNonQuery();
            mycon.connectionclose();
        }
        public void HammaddeSil(string uid)
        {
            DBconnect mycon = new DBconnect();
            mycon.connectionopen();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = DBconnect.baglanti;
            command.CommandText = "DELETE FROM hammadde WHERE id=@uid;";
            command.Parameters.AddWithValue("@uid", Convert.ToInt32(uid));
            command.ExecuteNonQuery();
            mycon.connectionclose();
            
        }
    }
}

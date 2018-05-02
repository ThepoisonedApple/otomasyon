using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace login
{
    class RaporClass
    {
        public static List<string> mylist = new List<string>();
        public void YeniRapor()
        {
            try
            {
                int x = 0;
                DBconnect mycon = new DBconnect();
                mycon.connectionopen();
                NpgsqlCommand command = new NpgsqlCommand();
                command.Connection = DBconnect.baglanti;
                try
                {
                    command.CommandText = "SELECT COUNT(id) FROM rapor WHERE tarih=@tarih ";
                    command.Parameters.AddWithValue("@tarih", DateTime.Today);
                    x = Convert.ToInt32(command.ExecuteScalar());
                }
                catch (Exception)
                {


                }
                mycon.connectionclose();
                if (x == 0)
                {
                    mycon.connectionopen();
                    command.CommandText = "SELECT SUM(maas) FROM Personel";
                    double maas = Convert.ToDouble(command.ExecuteScalar());
                    mycon.connectionclose();
                    mycon.connectionopen();
                    command.CommandText = "SELECT SUM(fiyat) FROM hammadde_siparis";
                    double hamucret = Convert.ToDouble(command.ExecuteScalar());
                    mycon.connectionclose();
                    mycon.connectionopen();
                    command.CommandText = "SELECT SUM(fiyat) FROM siparis";
                    double gelir = Convert.ToDouble(command.ExecuteScalar());
                    mycon.connectionclose();
                    double kar = gelir - hamucret - maas;
                    mycon.connectionopen();
                    command.CommandText = "INSERT INTO rapor (gelir,gider_personel,gider_hammadde,kar,tarih) VALUES (@gelir,@gper,@gham,@kar,@tarih)";
                    command.Parameters.AddWithValue("@gelir", Convert.ToInt32(gelir));
                    command.Parameters.AddWithValue("@gper", Convert.ToInt32(maas));
                    command.Parameters.AddWithValue("@gham", Convert.ToInt32(hamucret));
                    command.Parameters.AddWithValue("@kar", Convert.ToInt32(kar));
                    command.Parameters.AddWithValue("@tarih", Convert.ToInt32(kar));
                    command.ExecuteNonQuery();
                    mycon.connectionclose();
                }
            }
            catch (Exception)
            {

            }




        }

        public void RaporAra(DateTime tarih)
        {
            DBconnect mycon = new DBconnect();
            mycon.connectionopen();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = DBconnect.baglanti;
            command.CommandText = "select * from rapor where tarih=@uid";
            command.Parameters.AddWithValue("@uid",tarih);
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
            }
            mycon.connectionclose();
        }
        public void RaporListele()
        {
            DBconnect mycon = new DBconnect();
            mycon.connectionopen();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = DBconnect.baglanti;
            command.CommandText = "select * from rapor";
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
            }
            mycon.connectionclose();
        }



    }
}

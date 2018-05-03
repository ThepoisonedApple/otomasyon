using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Forms;
namespace login
{
    class UrunStokClass
    {
        public static List<string> mylist = new List<string>();
        public void UrunStokEkle(int uid,int uadet)
        {
             
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = DBconnect.baglanti;
            DBconnect.connectionopen();
            command.CommandText = "SELECT adet FROM urun WHERE urun_id=@uid";
            command.Parameters.AddWithValue("@uid",uid);
            int x = Convert.ToInt32(command.ExecuteScalar());
            string y = "Bu ürün için stok zaten açılmıştır, " + Convert.ToString(x) + " ürün stoktadır .Güncelleme Kısmından Stok ekleme veya çıkarma yabilirsiniz.";
            DBconnect.connectionclose();
            if (x==0)
            {
                DBconnect.connectionopen();
                command.CommandText = "UPDATE urun SET adet=@uadet WHERE urun_id=@uid";
                command.Parameters.AddWithValue("@uadet", uadet);
                command.Parameters.AddWithValue("@uid", uid);
                command.ExecuteNonQuery();
                DBconnect.connectionclose();
            }
            else
            {
                MessageBox.Show(y);
            }

        }

        public string[] UrunStokBilgiGetir(int uid)
        {

            string[] arr = new string[2];
             
            DBconnect.connectionopen();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = DBconnect.baglanti;
            command.CommandText = "SELECT adi,adet FROM urun WHERE urun_id=@uid";
            command.Parameters.AddWithValue("@uid",uid);
            NpgsqlDataReader reader = command.ExecuteReader();
            reader.Read();
            arr[0]=Convert.ToString(reader.GetValue(0));
            arr[1]=Convert.ToString(reader.GetValue(1));
            DBconnect.connectionclose();
            return arr;

        }

        public void UrunStokGuncelle(int uid,int uadet)
        {
             
            NpgsqlCommand command = new NpgsqlCommand();
            DBconnect.connectionopen();
            command.CommandText = "UPDATE urun SET adet=@uadet WHERE urun_id=@uid";
            command.Parameters.AddWithValue("@uadet", uadet);
            command.Parameters.AddWithValue("@uid", uid);
            command.ExecuteNonQuery();
            DBconnect.connectionclose();

        }

        public void UrunStokSil(int uid)
        {
             
            NpgsqlCommand command = new NpgsqlCommand();
            DBconnect.connectionopen();
            command.CommandText = "UPDATE urun SET adet=0 WHERE urun_id=@uid";
            command.Parameters.AddWithValue("@uid", uid);
            command.ExecuteNonQuery();
            DBconnect.connectionclose();

        }

        public void UrunStokListele(string ad)
        {
             
            DBconnect.connectionopen();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = DBconnect.baglanti;
            comm.CommandText = "SELECT * FROM urun WHERE adi like @ad";
            comm.Parameters.AddWithValue("@ad", "%" + ad + "%");
            NpgsqlDataReader reader = comm.ExecuteReader();
            int x = 0;
            while (reader.Read())
            {

                mylist.Add(reader.GetValue(x).ToString());
                mylist.Add(reader.GetValue(x + 1).ToString());
                mylist.Add(reader.GetValue(x + 5).ToString());

            }

            DBconnect.connectionclose();

        }


    }
}

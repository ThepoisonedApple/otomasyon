using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
namespace login
{
    class PersonelClass
    {
        public static List<string> mylist = new List<string>();

        public struct Personel
        {
            public int id;
            public string Ad;
            public string Soyad;
            public string Email;
            public double Maas;
            public string Bolum;
            public string Adres;
            public string Telefon;
            public string Pozisyon;

            public Personel(int a, string b, string c, string d, double e, string f, string g, string h, string i)
            {
                id = a;
                Ad = b;
                Soyad = c;
                Email = d;
                Maas = e;
                Bolum = f;
                Adres = g;
                Telefon = h;
                Pozisyon = i;
            }
          

        }

            public void Personelekle(string ad,string sad, string mail, double maas, int bolum_id,string adres, string tel,string poz)
        {
            DBconnect mycon = new DBconnect();
            mycon.connectionopen();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = DBconnect.baglanti;
            command.CommandText = "INSERT INTO personel (ad,soyad,email,maas,bolum_id,adres,telefon,pozisyon) " +
                     "VALUES (@name,@sname,@mail,@maas,@bid,@adres,@tel,@poz);";
            command.Parameters.AddWithValue("@name", ad);
            command.Parameters.AddWithValue("@sname", sad);
            command.Parameters.AddWithValue("@mail", mail);
            command.Parameters.AddWithValue("@maas", maas);
            command.Parameters.AddWithValue("@bid", bolum_id);
            command.Parameters.AddWithValue("@adres", adres);
            command.Parameters.AddWithValue("@tel", tel);
            command.Parameters.AddWithValue("@poz", poz);
            command.ExecuteNonQuery();
            mycon.connectionclose();
        }

        public string[] PersonelBilgiGetir(string pid)
        {
            DBconnect mycon = new DBconnect();
            mycon.connectionopen();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = DBconnect.baglanti;
            command.CommandText = "SELECT * FROM personel WHERE personel_id=@pid";
            command.Parameters.AddWithValue("@pid",Convert.ToInt32(pid));
            var comread = command.ExecuteReader();
            comread.Read();
            string[] arr = new string[8];

            arr[0] = comread["ad"].ToString();
            arr[1] = comread["soyad"].ToString();
            arr[2] = comread["email"].ToString();
            arr[3] = comread["maas"].ToString();
            arr[4] = comread["bolum_id"].ToString();
            arr[5] = comread["adres"].ToString();
            arr[6] = comread["telefon"].ToString();
            arr[7] = comread["pozisyon"].ToString();
            comread.Close();
            mycon.connectionclose();
            return arr;
        }

        public void PersonelGuncelle(string ad, string sad, string mail, double maas, int bolum_id, string adres, string tel, string poz,string pid)
        {
            DBconnect mycon = new DBconnect();
            mycon.connectionopen();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = DBconnect.baglanti;
            command.CommandText = "UPDATE personel SET ad=@name, soyad=@sname, email=@mail, maas=@maas, bolum_id=@bid, adres=@adres, telefon=@tel, pozisyon=@poz WHERE personel_id = @pid";
            command.Parameters.AddWithValue("@name", ad);
            command.Parameters.AddWithValue("@sname", sad);
            command.Parameters.AddWithValue("@mail", mail);
            command.Parameters.AddWithValue("@maas", maas);
            command.Parameters.AddWithValue("@bid", bolum_id);
            command.Parameters.AddWithValue("@adres", adres);
            command.Parameters.AddWithValue("@tel", tel);
            command.Parameters.AddWithValue("@poz", poz);
            command.Parameters.AddWithValue("@pid", Convert.ToInt32(pid));
            command.ExecuteNonQuery();
            mycon.connectionclose();
        }

        public void PersonelSil(string pid)
        {
            DBconnect mycon = new DBconnect();
            mycon.connectionopen();
            NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = DBconnect.baglanti;
            command.CommandText = "DELETE FROM kullanici WHERE personel_id=@pid;";
            command.Parameters.AddWithValue("@pid",Convert.ToInt32(pid));
            command.ExecuteNonQuery();
            mycon.connectionclose();
            mycon.connectionopen();
            command.CommandText = "DELETE FROM personel WHERE personel_id=@pid;";
            command.Parameters.AddWithValue("@pid",Convert.ToInt32(pid));
            command.ExecuteNonQuery();
            mycon.connectionclose();
        }

        public void PersonelAra(string pad,string sad)
        {
            DBconnect mycon = new DBconnect();
            mycon.connectionopen();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = DBconnect.baglanti;
            comm.CommandText = "SELECT * FROM personel WHERE ad like @pad and soyad like @sad;";
            comm.Parameters.AddWithValue("@pad", "%" + pad + "%");
            comm.Parameters.AddWithValue("@sad", "%" + sad + "%");
            NpgsqlDataReader reader = comm.ExecuteReader();
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
                mylist.Add(reader.GetValue(x + 8).ToString());

            }

            mycon.connectionclose();


        }

        public void Personellistele(string sword,string sorgu)
        {

            DBconnect mycon = new DBconnect();
            mycon.connectionopen();
            NpgsqlCommand comm = new NpgsqlCommand();
            comm.Connection = DBconnect.baglanti;

            if (sorgu=="bolum_id")
            {
                comm.CommandText = "SELECT * FROM personel WHERE bolum_id=@pad;";
                comm.Parameters.AddWithValue("@pad", Convert.ToInt32(sword));
            }
            else if (sorgu=="pozisyon")
            {
                comm.CommandText = "SELECT * FROM personel WHERE pozisyon=@pad;";
                comm.Parameters.AddWithValue("@pad", sword);
            }

            NpgsqlDataReader reader = comm.ExecuteReader();
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
                mylist.Add(reader.GetValue(x + 8).ToString());

            }

            mycon.connectionclose();

        }


    }
}

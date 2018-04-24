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
        public List<Personel> mylist = new List<Personel>();

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

        public DataGridView PersonelAra(string pad,string sad,DataGridView x)
        {
      /*      DBconnect mycon = new DBconnect();
            mycon.connectionopen();
          NpgsqlCommand command = new NpgsqlCommand();
            command.Connection = DBconnect.baglanti;
            command.CommandText = 
                "SELECT * FROM personel WHERE ad LIKE '@pad' " +
                "INTERSECT" +
                " SELECT * FROM personel WHERE ad LIKE '@sad'";
            command.Parameters.AddWithValue("@pad",pad);
            command.Parameters.AddWithValue("@sad",sad);
            NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter();
            DataSet ds = new DataSet();
            dataAdapter.SelectCommand = command;
   /*         dataAdapter.InsertCommand.Connection = DBconnect.baglanti;
            dataAdapter.InsertCommand.CommandText = 
                "SELECT * FROM personel WHERE ad LIKE '@pad' " +
                "INTERSECT" +
                " SELECT * FROM personel WHERE ad LIKE '@sad'";
            dataAdapter.InsertCommand.Parameters.AddWithValue("@pad",pad);
            dataAdapter.InsertCommand.Parameters.AddWithValue("@sad", sad);
            dataAdapter.Fill(ds);
            x.DataSource = ds;
            x.DataMember = ds.WriteXml(sad);
            mycon.connectionclose();*/
            return x;

        }


        public void GetData(string selectCommand,DataGridView dataGridView1,BindingSource bindingSource1)
        {
            try
            {
                DBconnect mycon = new DBconnect();
                // Create a new data adapter based on the specified query.
                SqlDataAdapter dataAdapter = new SqlDataAdapter(selectCommand, DBconnect.baglantiSatiri);

                // Create a command builder to generate SQL update, insert, and
                // delete commands based on selectCommand. These are used to
                // update the database.
                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(dataAdapter);

                // Populate a new data table and bind it to the BindingSource.
                DataTable table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
                bindingSource1.DataSource = table;

                // Resize the DataGridView columns to fit the newly loaded content.
                dataGridView1.AutoResizeColumns(
                    DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
            }
            catch (SqlException)
            {
                MessageBox.Show("To run this example, replace the value of the " +
                    "connectionString variable with a connection string that is " +
                    "valid for your system.");
            }
        }



    }
}

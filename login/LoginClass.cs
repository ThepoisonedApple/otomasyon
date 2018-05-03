using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using System.Windows.Forms;

namespace login
{
    class LoginClass
    {   


        public int LoginControl(string kad,string kpw)
        {
             
            DBconnect.connectionopen();
            string query = "select COUNT(kullanici_id) FROM kullanici WHERE (kullanici_adi='" + kad + "') AND (sifre='"+kpw+"');";
            NpgsqlCommand comm1 = new NpgsqlCommand(query, DBconnect.baglanti);
            Int32 count1 = Convert.ToInt32(comm1.ExecuteScalar());
            if (count1 == 0)
            {
                MessageBox.Show("Kullanıcı adı veya şifreyi yanlış girdiniz");
                DBconnect.connectionclose();
                return -1;
            }
            else
            {
                DBconnect.connectionclose();
                DBconnect.connectionopen();
                string logquery = "SELECT * FROM kullanici WHERE (kullanici_adi='" + kad + "') AND (sifre='" + kpw + "');";
                NpgsqlCommand comm2 = new NpgsqlCommand(logquery, DBconnect.baglanti);
                var yetki_kid = comm2.ExecuteReader();
                yetki_kid.Read();
                Form1.KID = yetki_kid["kullanici_id"].ToString();
                string x = yetki_kid["yetki_id"].ToString();
                Form1.YID =Convert.ToInt32(x);
                DBconnect.connectionclose();
                return Convert.ToInt32(x);
                
            }

        }
    }
}

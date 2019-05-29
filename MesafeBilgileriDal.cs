using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProLab2._3._3
{
    class MesafeBilgileriDal
    {
        SqlConnection _connection = new SqlConnection(@"server=MAMI\SQLEXPRESS;   initial catalog=KimyasalTicaret;   integrated security=true");
        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }
        public List<MesafeBilgileri> GetMesafeBilgileriTable()
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("select * from MesafeBilgileri", _connection);
            SqlDataReader reader = command.ExecuteReader();
            List<MesafeBilgileri> mesafeBilgileri = new List<MesafeBilgileri>();
            while (reader.Read())
            {
                MesafeBilgileri m_bilgileri = new MesafeBilgileri
                {
                    Sehirler = reader["Sehirler"].ToString(),
                    Kocaeli = Convert.ToInt32(reader["Kocaeli(km)"])
                };
                mesafeBilgileri.Add(m_bilgileri);
            }
            reader.Close();
            _connection.Close();
            return mesafeBilgileri;
        }
    }
}

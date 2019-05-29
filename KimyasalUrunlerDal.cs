using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProLab2._3._3
{
    class KimyasalUrunlerDal
    {
        SqlConnection _connection = new SqlConnection(@"server=MAMI\SQLEXPRESS;   initial catalog=KimyasalTicaret;   integrated security=true");
        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }
        public List<KimyasalUrunler> GetKimyasalUrunlerTable()
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("select * from KimyasalUrunler", _connection);
            SqlDataReader reader = command.ExecuteReader();
            List<KimyasalUrunler> k_urunler = new List<KimyasalUrunler>();
            while (reader.Read())
            {
                KimyasalUrunler kimyasalUrunler = new KimyasalUrunler
                {
                    UrunId = Convert.ToInt32(reader["UrunId"]),
                    UrunAdi = reader["UrunAdi"].ToString(),
                    UrunHammaddeleri = reader["UrunHammaddeleri"].ToString(),
                    HammaddeMiktari = Convert.ToInt32(reader["HammaddeMiktari"])
                };
                k_urunler.Add(kimyasalUrunler);
            }
            reader.Close();
            _connection.Close();
            return k_urunler;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProLab2._3._3
{
    class MusterilerDal
    {
        SqlConnection _connection = new SqlConnection(@"server=MAMI\SQLEXPRESS;   initial catalog=KimyasalTicaret;   integrated security=true");
        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }
        public List<Musteriler> GetMusterilerTable()
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("select * from Musteriler", _connection);
            SqlDataReader reader = command.ExecuteReader();
            List<Musteriler> musteriler = new List<Musteriler>();
            while (reader.Read())
            {
                Musteriler musteri = new Musteriler
                {
                    MusteriId = Convert.ToInt32(reader["MusteriId"]),
                    MusteriAdi = reader["MusteriAdi"].ToString(),
                    Adres = reader["Adres"].ToString(),
                    AlinanUrun = reader["AlinanUrun"].ToString()
                };
                musteriler.Add(musteri);
            }
            reader.Close();
            _connection.Close();
            return musteriler;
        }
        public void AddMusteri(Musteriler musteriler)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("insert into Musteriler values(@MusteriAdi,@Adres,@AlinanUrun)",_connection);
            command.Parameters.AddWithValue("@MusteriAdi", musteriler.MusteriAdi);
            command.Parameters.AddWithValue("@Adres", musteriler.Adres);
            command.Parameters.AddWithValue("@AlinanUrun", musteriler.AlinanUrun);
            command.ExecuteNonQuery();
            _connection.Close();
        }
    }
}

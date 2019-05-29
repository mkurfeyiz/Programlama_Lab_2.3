using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProLab2._3._3
{
    class TedarikciFirmalarDal
    {
        SqlConnection _connection = new SqlConnection(@"server=MAMI\SQLEXPRESS;   initial catalog=KimyasalTicaret;   integrated security=true");
        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }
        public List<TedarikciFirmalar> GetTedarikciFirmalarTable()
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("select * from TedarikciFirmalar", _connection);
            SqlDataReader reader = command.ExecuteReader();
            List<TedarikciFirmalar> t_firmalar = new List<TedarikciFirmalar>();
            while (reader.Read())
            {
                TedarikciFirmalar tedarikciFirmalar = new TedarikciFirmalar
                {
                    FirmaId = Convert.ToInt32(reader["FirmaId"]),
                    FirmaAdi = reader["FirmaAdi"].ToString(),
                    Ulke = reader["Ulke"].ToString(),
                    SehirMerkezi = reader["SehirMerkezi"].ToString(),
                    Hammadde = reader["Hammaddeler"].ToString(),
                    Miktar = Convert.ToInt32(reader["Miktar"]),
                    UretimTarihi = reader["UretimTarihi"].ToString(),
                    RafOmru = Convert.ToInt32(reader["RafOmru"]),
                    SatisFiyati = Convert.ToDecimal(reader["SatisFiyati"])
                };
                t_firmalar.Add(tedarikciFirmalar);
            }
            reader.Close();
            _connection.Close();
            return t_firmalar;
        }
        public void AddTedarikciFirma(TedarikciFirmalar t_firma)
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand(
                "insert into TedarikciFirmalar values(@FirmaAdi,@Ulke,@SehirMerkezi,@Hammadde,@Miktar,@UretimTarihi,@RafOmru,@SatisFiyati)",_connection);
            command.Parameters.AddWithValue("@FirmaAdi", t_firma.FirmaAdi);
            command.Parameters.AddWithValue("@Ulke", t_firma.Ulke);
            command.Parameters.AddWithValue("@SehirMerkezi", t_firma.SehirMerkezi);
            command.Parameters.AddWithValue("@Hammadde", t_firma.Hammadde);
            command.Parameters.AddWithValue("@Miktar", t_firma.Miktar);
            command.Parameters.AddWithValue("@UretimTarihi", t_firma.UretimTarihi);
            command.Parameters.AddWithValue("@RafOmru", t_firma.RafOmru);
            command.Parameters.AddWithValue("@SatisFiyati", t_firma.SatisFiyati);
            command.ExecuteNonQuery();
            _connection.Close();
        }
    }
}

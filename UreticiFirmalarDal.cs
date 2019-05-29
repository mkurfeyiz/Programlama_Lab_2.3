using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProLab2._3._3
{
    class UreticiFirmalarDal
    {
        SqlConnection _connection = new SqlConnection(@"server=MAMI\SQLEXPRESS;   initial catalog=KimyasalTicaret;   integrated security=true");
        private void ConnectionControl()
        {
            if (_connection.State == ConnectionState.Closed)
            {
                _connection.Open();
            }
        }
        public List<UreticiFirmalar> GetUreticiFirmalarTable()
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand("select * from UreticiFirmalar", _connection);
            SqlDataReader reader = command.ExecuteReader();
            List<UreticiFirmalar> ureticiFirmalar = new List<UreticiFirmalar>();
            while (reader.Read())
            {
                UreticiFirmalar u_firma = new UreticiFirmalar
                {
                    FirmaAdi = reader["FirmaAdi"].ToString(),
                    Sehir = reader["Sehir"].ToString(),
                    AlinanHammadde = reader["AlinanHammadde"].ToString(),
                    AlisMaliyeti = Convert.ToDecimal(reader["AlisMaliyeti"]),
                    StokDurumu = Convert.ToInt32(reader["StokDurumu"]),
                    GelistirilenMadde = reader["GelistirilenMadde"].ToString(),
                    Bilesenleri = reader["Bilesenleri"].ToString(),
                    BilesenMiktari = Convert.ToInt32(reader["BilesenMiktari"])
                };
                ureticiFirmalar.Add(u_firma);
            }
            reader.Close();
            _connection.Close();
            return ureticiFirmalar;
        }
        public List<TedarikciFirmalar> GetEnUcuzN()
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand(
                "select FirmaId,FirmaAdi,Hammaddeler,Miktar,SatisFiyati from TedarikciFirmalar t where t.Hammaddeler = 'N' and Miktar <> 0 and t.SatisFiyati <= all(select SatisFiyati from TedarikciFirmalar where Hammaddeler = 'N')", _connection);
            SqlDataReader reader = command.ExecuteReader();
            List<TedarikciFirmalar> t_firmalar = new List<TedarikciFirmalar>();
            while (reader.Read())
            {
                TedarikciFirmalar tedarikci = new TedarikciFirmalar
                {
                    FirmaId = Convert.ToInt32(reader["FirmaId"]),
                    FirmaAdi = reader["FirmaAdi"].ToString(),
                    Hammadde = reader["Hammaddeler"].ToString(),
                    Miktar = Convert.ToInt32(reader["Miktar"]),
                    SatisFiyati = Convert.ToDecimal(reader["SatisFiyati"])
                };
                t_firmalar.Add(tedarikci);
            }
            reader.Close();
            _connection.Close();
            return t_firmalar;
        }
        public List<TedarikciFirmalar> GetEnUcuzH()
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand(
                "select FirmaId,FirmaAdi,Hammaddeler,Miktar,SatisFiyati from TedarikciFirmalar t where t.Hammaddeler = 'H' and Miktar <> 0 and t.SatisFiyati <= all(select SatisFiyati from TedarikciFirmalar where Hammaddeler = 'H')", _connection);
            SqlDataReader reader = command.ExecuteReader();
            List<TedarikciFirmalar> t_firmalar = new List<TedarikciFirmalar>();
            while (reader.Read())
            {
                TedarikciFirmalar tedarikci = new TedarikciFirmalar
                {
                    FirmaId = Convert.ToInt32(reader["FirmaId"]),
                    FirmaAdi = reader["FirmaAdi"].ToString(),
                    Hammadde = reader["Hammaddeler"].ToString(),
                    Miktar = Convert.ToInt32(reader["Miktar"]),
                    SatisFiyati = Convert.ToDecimal(reader["SatisFiyati"])
                };
                t_firmalar.Add(tedarikci);
            }
            reader.Close();
            _connection.Close();
            return t_firmalar;
        }
        public List<TedarikciFirmalar> GetEnUcuzC()
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand(
                "select FirmaId,FirmaAdi,Hammaddeler,Miktar,SatisFiyati from TedarikciFirmalar t where t.Hammaddeler = 'C' and Miktar <> 0 and t.SatisFiyati <= all(select SatisFiyati from TedarikciFirmalar where Hammaddeler = 'C')", _connection);
            SqlDataReader reader = command.ExecuteReader();
            List<TedarikciFirmalar> t_firmalar = new List<TedarikciFirmalar>();
            while (reader.Read())
            {
                TedarikciFirmalar tedarikci = new TedarikciFirmalar
                {
                    FirmaId = Convert.ToInt32(reader["FirmaId"]),
                    FirmaAdi = reader["FirmaAdi"].ToString(),
                    Hammadde = reader["Hammaddeler"].ToString(),
                    Miktar = Convert.ToInt32(reader["Miktar"]),
                    SatisFiyati = Convert.ToDecimal(reader["SatisFiyati"])
                };
                t_firmalar.Add(tedarikci);
            }
            reader.Close();
            _connection.Close();
            return t_firmalar;
        }
        public List<TedarikciFirmalar> GetEnUcuzS()
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand(
                "select FirmaId,FirmaAdi,Hammaddeler,Miktar,SatisFiyati from TedarikciFirmalar t where t.Hammaddeler = 'S' and Miktar <> 0 and t.SatisFiyati <= all(select SatisFiyati from TedarikciFirmalar where Hammaddeler = 'S')", _connection);
            SqlDataReader reader = command.ExecuteReader();
            List<TedarikciFirmalar> t_firmalar = new List<TedarikciFirmalar>();
            while (reader.Read())
            {
                TedarikciFirmalar tedarikci = new TedarikciFirmalar
                {
                    FirmaId = Convert.ToInt32(reader["FirmaId"]),
                    FirmaAdi = reader["FirmaAdi"].ToString(),
                    Hammadde = reader["Hammaddeler"].ToString(),
                    Miktar = Convert.ToInt32(reader["Miktar"]),
                    SatisFiyati = Convert.ToDecimal(reader["SatisFiyati"])
                };
                t_firmalar.Add(tedarikci);
            }
            reader.Close();
            _connection.Close();
            return t_firmalar;
        }
        public List<TedarikciFirmalar> GetEnUcuzO()
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand(
                "select FirmaId,FirmaAdi,Hammaddeler,Miktar,SatisFiyati from TedarikciFirmalar t where t.Hammaddeler = 'O' and Miktar <> 0 and t.SatisFiyati <= all(select SatisFiyati from TedarikciFirmalar where Hammaddeler = 'O')", _connection);
            SqlDataReader reader = command.ExecuteReader();
            List<TedarikciFirmalar> t_firmalar = new List<TedarikciFirmalar>();
            while (reader.Read())
            {
                TedarikciFirmalar tedarikci = new TedarikciFirmalar
                {
                    FirmaId = Convert.ToInt32(reader["FirmaId"]),
                    FirmaAdi = reader["FirmaAdi"].ToString(),
                    Hammadde = reader["Hammaddeler"].ToString(),
                    Miktar = Convert.ToInt32(reader["Miktar"]),
                    SatisFiyati = Convert.ToDecimal(reader["SatisFiyati"])
                };
                t_firmalar.Add(tedarikci);
            }
            reader.Close();
            _connection.Close();
            return t_firmalar;
        }
        public List<TedarikciFirmalar> GetEnUcuzCl()
        {
            ConnectionControl();
            SqlCommand command = new SqlCommand(
                "select FirmaId,FirmaAdi,Hammaddeler,Miktar,SatisFiyati from TedarikciFirmalar t where t.Hammaddeler = 'Cl' and Miktar <> 0 and t.SatisFiyati <= all(select SatisFiyati from TedarikciFirmalar where Hammaddeler = 'Cl')", _connection);
            SqlDataReader reader = command.ExecuteReader();
            List<TedarikciFirmalar> t_firmalar = new List<TedarikciFirmalar>();
            while (reader.Read())
            {
                TedarikciFirmalar tedarikci = new TedarikciFirmalar
                {
                    FirmaId = Convert.ToInt32(reader["FirmaId"]),
                    FirmaAdi = reader["FirmaAdi"].ToString(),
                    Hammadde = reader["Hammaddeler"].ToString(),
                    Miktar = Convert.ToInt32(reader["Miktar"]),
                    SatisFiyati = Convert.ToDecimal(reader["SatisFiyati"])
                };
                t_firmalar.Add(tedarikci);
            }
            reader.Close();
            _connection.Close();
            return t_firmalar;
        }
    }
}

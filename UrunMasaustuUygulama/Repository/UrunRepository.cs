using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrunMasaustuUygulama.Dto;
using UrunMasaustuUygulama.Model;
using UrunMasaustuUygulama.Model.Repository;

namespace UrunMasaustuUygulama.Repository
{
    class UrunRepository : AbstractBaseRepository, IUrunRepository
    {
        public UrunRepository(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public void Add(Urun urun)
        {
            using (var connection = new MySqlConnection(connectionString))
            using (var command = new MySqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "INSERT INTO Urun(urun_adi, aciklama, fiyat, renk) VALUES (@id, @aciklama, @fiyat, @renk)";
                command.Parameters.Add("id", MySqlDbType.VarChar).Value = urun.UrunAdi;
                command.Parameters.Add("aciklama", MySqlDbType.VarChar).Value = urun.Aciklama;
                command.Parameters.Add("fiyat", MySqlDbType.Double).Value = urun.Fiyat;
                command.Parameters.Add("renk", MySqlDbType.VarChar).Value = urun.Renk;
                command.ExecuteNonQuery();
            }
        }

        public void Delete(ulong id)
        {
            using (var connection = new MySqlConnection(connectionString))
            using (var command = new MySqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "DELETE FROM Urun WHERE Urun.id = @id ";
                command.Parameters.AddWithValue("@id", id);
                command.ExecuteNonQuery();
            }
        }

        public void Edit(Urun urun)
        {
            using (var connection = new MySqlConnection(connectionString))
            using (var command = new MySqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"update Urun 
                                        set urun_adi=@urunAdi,aciklama=@aciklama, renk=@renk, fiyat=@fiyat
                                        where id=@id";
                command.Parameters.Add("@urunAdi", MySqlDbType.VarChar).Value = urun.UrunAdi;
                command.Parameters.Add("@aciklama", MySqlDbType.VarChar).Value = urun.Aciklama;
                command.Parameters.Add("@renk", MySqlDbType.VarChar).Value = urun.Renk;
                command.Parameters.Add("@fiyat", MySqlDbType.Double).Value = urun.Fiyat;
                command.Parameters.Add("@id", MySqlDbType.UInt64).Value = urun.Id;
                command.ExecuteNonQuery();
            }
        }

        public IEnumerable<Urun> GetAll()
        {
            var urunList = new List<Urun>();
            using(var connection = new MySqlConnection(connectionString))
            using(var command = new MySqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Urun";
                using (var reader = command.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        var urun = new Urun();
                        urun.Id = (ulong)reader[0];
                        urun.UrunAdi = reader[1].ToString();
                        urun.Aciklama = reader[2].ToString();
                        urun.Fiyat = (double)reader[3];
                        urun.Renk = reader[4].ToString();
                        urunList.Add(urun);
                    }
                }
            }
            return urunList;
        }


        public IEnumerable<Urun> GetByUrunAdi(string UrunAdi)
        {
            var urunList = new List<Urun>();
            using (var connection = new MySqlConnection(connectionString))
            using (var command = new MySqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.Parameters.AddWithValue("@urunAdi", "%" + UrunAdi + "%");
                command.CommandText = "SELECT * FROM Urun WHERE Urun.urun_adi LIKE @urunAdi";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var urun = new Urun();
                        urun.Id = (ulong)reader[0];
                        urun.UrunAdi = reader[1].ToString();
                        urun.Aciklama = reader[2].ToString();
                        urun.Fiyat = (double)reader[3];
                        urun.Renk = reader[4].ToString();
                        urunList.Add(urun);
                    }
                }
            }
            return urunList;
        }
        public IEnumerable<SatilanUrun> GetAllSatilanUrun()
        {
            var urunList = new List<SatilanUrun>();
            using (var connection = new MySqlConnection(connectionString))
            using (var command = new MySqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = @"SELECT u.urun_adi, SUM(sd.adet), SUM(sd.toplam_fiyat) 
                                        FROM siparis_detay sd 
                                        LEFT JOIN urun u ON u.id = sd.urun_id 
                                        GROUP BY u.urun_adi";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var urun = new SatilanUrun();
                        urun.UrunAdi = reader[0].ToString();
                        Console.WriteLine(reader[1].GetType());
                        urun.SatilanAdet = Decimal.ToInt32((decimal)reader[1]);
                        urun.ToplamFiyat = (decimal)reader[2];
                        urunList.Add(urun);
                    }
                }
            }
            return urunList;
        }
    }
}

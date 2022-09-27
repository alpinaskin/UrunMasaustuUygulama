using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UrunMasaustuUygulama.Dto;
using UrunMasaustuUygulama.Model;

namespace UrunMasaustuUygulama.Repository
{
    class MusteriRepository : AbstractBaseRepository, IMusteriRepository
    {
        public MusteriRepository(string sqlConnectionString)
        {
            this.connectionString = sqlConnectionString;
        }
        public IEnumerable<Musteri> GetAll()
        {
            var musteriList = new List<Musteri>();
            using (var connection = new MySqlConnection(connectionString))
            using (var command = new MySqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = "SELECT * FROM Musteri";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var musteri = new Musteri();
                        musteri.Id = (ulong)reader[0];
                        musteri.Ad = reader[1].ToString();
                        musteri.Soyad = reader[2].ToString();
                        musteri.Eposta = reader[3].ToString();
                        musteri.Telefon = reader[4].ToString();
                        musteriList.Add(musteri);
                    }
                }
            }
            return musteriList;
        }

        public IEnumerable<Musteri> GetByMusteriAdi(string musteriAdi)
        {
            var musteriList = new List<Musteri>();
            using (var connection = new MySqlConnection(connectionString))
            using (var command = new MySqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.Parameters.AddWithValue("@musteriAdi", "%" + musteriAdi + "%");
                command.CommandText = "SELECT * FROM Musteri WHERE Musteri.ad LIKE @musteriAdi";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var musteri = new Musteri();
                        musteri.Id = (ulong)reader[0];
                        musteri.Ad = reader[1].ToString();
                        musteri.Soyad= reader[2].ToString();
                        musteri.Eposta = reader[3].ToString();
                        musteri.Telefon = reader[4].ToString();
                        musteriList.Add(musteri);
                    }
                }
            }
            return musteriList;
        }

        public Musteri GetByMusteriId(ulong musteriId)
        {
            Musteri musteri = new Musteri();
            using (var connection = new MySqlConnection(connectionString))
            using (var command = new MySqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.Parameters.AddWithValue("@musteriId", musteriId);
                command.CommandText = "SELECT * FROM Musteri WHERE Musteri.id = @musteriId";
                musteri = (Musteri)command.ExecuteScalar();
            }
            return musteri;
        }

        public IEnumerable<MusteriSiparisTeslimat> GetMusteriSiparisByMusteriId(ulong musteriId)
        {
            var musteriSiparisTeslimatList = new List<MusteriSiparisTeslimat>();
            using (var connection = new MySqlConnection(connectionString))
            using (var command = new MySqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.Parameters.AddWithValue("@musteriId", musteriId);
                command.CommandText = @"SELECT
                                            u.urun_adi, sd.adet, tb.adres, tb.posta_kodu
                                        FROM
                                            Urun as u
                                        JOIN siparis_detay AS sd ON
                                            sd.urun_id = u.id
                                        JOIN teslimat_bilgileri AS tb ON
                                            tb.musteri_id = sd.musteri_id
                                        WHERE
                                            sd.musteri_id = @musteriId";
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var dto = new MusteriSiparisTeslimat();
                        dto.UrunAdi = reader[0].ToString();
                        dto.UrunAdet = (UInt16)reader[1];
                        dto.TeslimatAdres = reader[2].ToString();
                        dto.PostaKodu = reader[3].ToString();
                        musteriSiparisTeslimatList.Add(dto);
                    }
                }
            }
            return musteriSiparisTeslimatList;
        }
    }
}

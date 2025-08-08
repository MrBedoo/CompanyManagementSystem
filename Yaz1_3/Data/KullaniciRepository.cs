using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanyManagementSystem.Models;
using Npgsql;
using System.ComponentModel.DataAnnotations;
using CompanyManagementSystem;

namespace CompanyManagementSystem.Data
{
    internal class KullaniciRepository
    {

        public int RunInsertOrUpdate(Kullanici kullanici)
        {
            try
            {
                using (var conn = DbHelper.GetConnection())
                {
                    conn.Open();

                    if (kullanici.Id > 0)
                    {
                        // ID varsa, veritabanında var mı kontrol et
                        string kontrolQuery = "SELECT COUNT(*) FROM kullanici WHERE id = @id";
                        using (var kontrolCmd = new NpgsqlCommand(kontrolQuery, conn))
                        {
                            kontrolCmd.Parameters.AddWithValue("@id", kullanici.Id);
                            long count = (long)kontrolCmd.ExecuteScalar();

                            if (count > 0)
                            {
                                // Güncelle
                                string updateQuery = @"
                                UPDATE kullanici SET
                                    ad = @ad,
                                    soyad = @soyad,
                                    email = @email,
                                    dogum_tarihi = @DogumTarihi,
                                    cinsiyet = @cinsiyet,
                                    gelir = @gelir,
                                    sifre = @sifre,
                                    resim = @resim
                                WHERE id = @id";

                                using (var updateCmd = new NpgsqlCommand(updateQuery, conn))
                                {
                                    updateCmd.Parameters.AddWithValue("@id", kullanici.Id);
                                    updateCmd.Parameters.AddWithValue("@ad", kullanici.Ad);
                                    updateCmd.Parameters.AddWithValue("@soyad", kullanici.Soyad);
                                    updateCmd.Parameters.AddWithValue("@email", kullanici.Email);
                                    updateCmd.Parameters.AddWithValue("@DogumTarihi", kullanici.DogumTarihi);
                                    updateCmd.Parameters.AddWithValue("@cinsiyet", kullanici.Cinsiyet);
                                    updateCmd.Parameters.AddWithValue("@gelir", kullanici.Gelir);
                                    updateCmd.Parameters.AddWithValue("@sifre", kullanici.Sifre);
                                    updateCmd.Parameters.AddWithValue("@resim", (object)kullanici.Resim ?? DBNull.Value);

                                    updateCmd.ExecuteNonQuery();
                                    return 1;
                                }
                            }
                            else
                            {
                                return -1; // ID bulunamadı
                            }
                        }
                    }

                    // Yeni kayıt
                    string insertQuery = @"
                    INSERT INTO kullanici
                    (ad, soyad, email, dogum_tarihi, cinsiyet, gelir, sifre, kayit_zamani, resim)
                    VALUES
                    (@ad, @soyad, @email, @DogumTarihi, @cinsiyet, @gelir, @sifre, @KayitTarihi, @resim)";

                    using (var insertCmd = new NpgsqlCommand(insertQuery, conn))
                    {
                        insertCmd.Parameters.AddWithValue("@ad", kullanici.Ad);
                        insertCmd.Parameters.AddWithValue("@soyad", kullanici.Soyad);
                        insertCmd.Parameters.AddWithValue("@email", kullanici.Email);
                        insertCmd.Parameters.AddWithValue("@DogumTarihi", kullanici.DogumTarihi);
                        insertCmd.Parameters.AddWithValue("@cinsiyet", kullanici.Cinsiyet);
                        insertCmd.Parameters.AddWithValue("@gelir", kullanici.Gelir);
                        insertCmd.Parameters.AddWithValue("@sifre", kullanici.Sifre);
                        insertCmd.Parameters.AddWithValue("@KayitTarihi", DateTime.Now);
                        insertCmd.Parameters.AddWithValue("@resim", (object)kullanici.Resim ?? DBNull.Value);

                        insertCmd.ExecuteNonQuery();
                        return 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message);
                return -2;
                throw;
            }
        }


        public bool BaskaKullanicidaVarMi(Kullanici kullanici)
        {
            using var conn = DbHelper.GetConnection();
            conn.Open();

            string sql = @"
            SELECT COUNT(*) FROM kullanici
            WHERE (ad = @ad OR soyad = @soyad OR email = @email)
            AND id <> @id"; // Burada id farkı kontrolü var

            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ad", kullanici.Ad);
            cmd.Parameters.AddWithValue("@soyad", kullanici.Soyad);
            cmd.Parameters.AddWithValue("@email", kullanici.Email);
            cmd.Parameters.AddWithValue("@id", kullanici.Id);

            int count = Convert.ToInt32(cmd.ExecuteScalar());
            return count > 0;
        }



        public void sil(int id)
        {
            using var conn = DbHelper.GetConnection();
            conn.Open();

            using var cmd = new NpgsqlCommand("DELETE FROM Kullanici WHERE Id = @Id", conn);
            cmd.Parameters.AddWithValue("@Id", id);


            cmd.ExecuteNonQuery();
        }

        public List<Kullanici> Listele()
        {
            var liste = new List<Kullanici>();

            using var conn = DbHelper.GetConnection();
            conn.Open();

            using var cmd = new NpgsqlCommand("SELECT * FROM Kullanici", conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                var kullanici = new Kullanici
                {
                    Id = reader.GetInt32(reader.GetOrdinal("id")),
                    Ad = reader.GetString(reader.GetOrdinal("ad")),
                    Soyad = reader.GetString(reader.GetOrdinal("soyad")),
                    Email = reader.GetString(reader.GetOrdinal("email")),
                    DogumTarihi = reader.GetDateTime(reader.GetOrdinal("dogum_tarihi")),
                    Cinsiyet = reader.GetChar(reader.GetOrdinal("cinsiyet")),
                    Gelir = reader.GetDecimal(reader.GetOrdinal("gelir")),
                    Sifre = reader.GetString(reader.GetOrdinal("sifre")),
                    KayitTarihi = reader.GetDateTime(reader.GetOrdinal("kayit_zamani")),
                    Resim = reader.IsDBNull(reader.GetOrdinal("resim")) ? null : (byte[])reader["resim"]

                };

                liste.Add(kullanici);
            }


            return liste;
        }


        

        public int EmailVarMi(string email)
        {
            using var conn = DbHelper.GetConnection();
            conn.Open();

            using var cmd = new NpgsqlCommand("SELECT COUNT(*) FROM kullanici WHERE email = @Email", conn);
            cmd.Parameters.AddWithValue("@Email", email);

            int count = (int)cmd.ExecuteScalar();
            return count;
        }

        public int AdVarMi(string ad)
        {
            using var conn = DbHelper.GetConnection();
            conn.Open();

            using var cmd = new NpgsqlCommand("SELECT COUNT(*) FROM kullanici WHERE ad = @Ad", conn);
            cmd.Parameters.AddWithValue("@Ad", ad);

            int count = (int)cmd.ExecuteScalar();
            return count;

        }

        public int SoyadVarMi(string soyad)
        {

            using var conn = DbHelper.GetConnection();
            conn.Open();

            using var cmd = new NpgsqlCommand("SELECT COUNT(*) FROM kullanici WHERE soyad = @Soyad", conn);
            cmd.Parameters.AddWithValue("@Soyad", soyad);

            int count = (int)cmd.ExecuteScalar();
            return count;

        }





    }
}

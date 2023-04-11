using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Sisbro_LIB
{
    public class Sellers
    {
        #region Data Member
        private int idSeller;
        private string nama;
        private string email;
        private int noHp;
        private string alamat;
        private string password;
        #endregion

        #region Constructors
        public Sellers()
        {
            IdSeller = 0;
            Nama = "";
            Email = "";
            NoHp = 0;
            Alamat = "";
            Password = "";
        }
        public Sellers(int idSeller, string nama, string email, int noHp, string alamat, string password)
        {
            this.IdSeller = idSeller;
            this.Nama = nama;
            this.Email = email;
            this.NoHp = noHp;
            this.Alamat = alamat;
            this.Password = password;
        }
        #endregion

        #region Properties
        public int IdSeller { get => idSeller; set => idSeller = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Email { get => email; set => email = value; }
        public int NoHp { get => noHp; set => noHp = value; }
        public string Alamat { get => alamat; set => alamat = value; }
        public string Password { get => password; set => password = value; }
        #endregion

        #region Method
        public override string ToString()
        {
            return nama;
        }

        public static List<Sellers> BacaData(string kriteria, string nilai)
        {
            string sql;
            if (kriteria == "")
            {
                sql = "SELECT idSellers, nama, email, no_hp, alamat, password " +
                      "FROM sellers ";
            }
            else
            {
                sql = "SELECT idSellers, nama, email, no_hp, alamat, password " +
                      "FROM sellers " +
                      "WHERE " + kriteria + " like '%" + nilai + "%'";
            }

            MySqlDataReader hasil = Koneksi.AmbilData(sql);

            //buat list untuk menampung data
            List<Sellers> listSellers = new List<Sellers>();
            while (hasil.Read() == true) //selama masih ada data
            {
                //baca data dr MySqlDataReader dan simpan di objek
                Sellers sellers = new Sellers(int.Parse(hasil.GetValue(0).ToString()),
                    hasil.GetValue(1).ToString(),
                    hasil.GetValue(2).ToString(),
                    int.Parse(hasil.GetValue(3).ToString()),
                    hasil.GetValue(4).ToString(),
                    hasil.GetValue(5).ToString());

                listSellers.Add(sellers);
            }
            return listSellers;
        }

        public bool TambahData()
        {
            string sql = "INSERT INTO sellers(idSellers, nama, email, no_hp, alamat, password) VALUES ('" +
                         this.IdSeller + "', '" +
                         this.nama.Replace("'", "\\'") + "', '" +
                         this.Email.Replace("'", "\\'") + "', '" +
                         this.NoHp + "', '" +
                         this.Alamat.Replace("'", "\\'") + ", SHA2('" +
                         this.Password.Replace("'", "\\'") + "', 512);";

            bool result = Koneksi.ExecuteDML(sql);
            return result;
        }

        public bool UbahData()
        {
            string sql = "UPDATE sellers " +
                         "SET " +
                         "nama = '" + this.Nama.Replace("'", "\\'") + "', " +
                         "email = '" + this.Email.Replace("'", "\\'") + "', " +
                         "no_telepon = '" + this.NoHp + "', " +
                         "alamat = '" + this.Alamat.Replace("'", "\\'") + "', " +
                         "WHERE idUser = '" + this.IdSeller + "';";

            bool result = Koneksi.ExecuteDML(sql);
            return result;
        }

        public bool HapusData()
        {
            string sql = "DELETE FROM sellers WHERE idSellers='" + this.IdSeller + "'";
            bool result = Koneksi.ExecuteDML(sql);
            return true;
        }

        public bool UbahPassword(string password)
        {
            string sql = "UPDATE sellers " +
                         "SET password = SHA2('" + password.Replace("'", "\\'") + "', 512) " +
                         "WHERE idUser = '" + this.IdSeller + "';";
            bool result = Koneksi.ExecuteDML(sql);
            return result;
        }

        public static Sellers AmbilDataByKode(string idSellers)
        {
            string sql = "SELECT idSellers, nama, email, no_hp, alamat, password " +
                         "FROM sellers " +
                         "WHERE idSellers = '" + idSellers + "'";

            MySqlDataReader hasil = Koneksi.AmbilData(sql);

            if (hasil.Read())
            {
                Sellers sellers = new Sellers(int.Parse(hasil.GetValue(0).ToString()),
                                        hasil.GetValue(1).ToString(),
                                        hasil.GetValue(2).ToString(),
                                        int.Parse(hasil.GetValue(3).ToString()),
                                        hasil.GetValue(4).ToString(),
                                        hasil.GetValue(5).ToString());
                return sellers;
            }
            else
            {
                return null;
            }
        }
        public static bool CekPassword(Sellers sellers, string password)
        {
            string sql = "SELECT idSellers, nama, email, no_hp, alamat, password" +
                         "FROM sellers " +
                         "WHERE idSellers = '" + sellers.IdSeller + "' AND password = SHA2('" + password + "', 512);";

            MySqlDataReader hasil = Koneksi.AmbilData(sql);

            if (hasil.Read() == true)
            {
                return true;
            }
            return false;
        }

        public static Sellers CekLogin(string userName, string password)
        {
            string sql = "SELECT idSellers, nama, email, no_hp, alamat, password "
                          + " FROM sellers ";

            if (userName == "" || password == "")
            {
                throw new Exception("Username atau password tidak boleh kosong");
            }
            else
            {
                sql += " WHERE username ='" + userName + "' AND password = SHA2('" + password + "', 512);";
            }

            MySqlDataReader hasil = Koneksi.AmbilData(sql);

            if (hasil.Read() == true)
            {
                Sellers result = new Sellers(int.Parse(hasil.GetValue(0).ToString()),
                    hasil.GetValue(1).ToString(),
                    hasil.GetValue(2).ToString(),
                    int.Parse(hasil.GetValue(3).ToString()),
                    hasil.GetValue(4).ToString(),
                    hasil.GetValue(5).ToString());
                return result;
            }
            return null;
        }
        #endregion
    }
}

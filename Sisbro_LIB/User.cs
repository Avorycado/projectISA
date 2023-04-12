using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Sisbro_LIB
{
    public class User
    {
        #region DataMember
        private int idUser;
        private string nama;
        private string password;
        private string email;
        private int noHp;
        private string alamat;
        #endregion

        #region Constructors
        public User()
        {
            idUser = 0;
            nama = "";
            password = "";
            email = "";
            noHp = 0;
            alamat = "";
        }

        public User(int idUser, string nama, string password, string email, int noHp, string alamat)
        {
            this.IdUser = idUser;
            this.Nama = nama;
            this.Password = password;
            this.Email = email;
            this.NoHp = noHp;
            this.Alamat = alamat;
        }
        #endregion

        #region Properties
        public int IdUser { get => idUser; set => idUser = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Password { get => password; set => password = value; }
        public string Email { get => email; set => email = value; }
        public int NoHp { get => noHp; set => noHp = value; }
        public string Alamat { get => alamat; set => alamat = value; }
        #endregion

        #region Method
        public static int GenerateIdUser()
        {
            string sql = "SELECT MAX(idUser) " +
                         "FROM user " + ";";

            int hasilId = 0;
            MySqlDataReader hasil = Koneksi.AmbilData(sql);
            if (hasil.Read())
            {
                if (hasil.GetValue(0).ToString() != "")
                {
                    hasilId = int.Parse(hasil.GetValue(0).ToString()) + 1;
                }
                else
                {
                    hasilId = 1;
                }
            }
            return hasilId;
        }
        public override string ToString()
        {
            return nama;
        }

        public static List<User> BacaData(string kriteria, string nilai)
        {
            string sql;
            if (kriteria == "")
            {
                sql = "SELECT idUser, nama, password, email, no_hp, alamat " +
                      "FROM user ";
            }
            else
            {
                sql = "SELECT idUser, nama, password, email, no_hp, alamat " +
                      "FROM user " +
                      "WHERE " + kriteria + " like '%" + nilai + "%'";
            }

            MySqlDataReader hasil = Koneksi.AmbilData(sql);

            //buat list untuk menampung data
            List<User> listUser = new List<User>();
            while (hasil.Read() == true) //selama masih ada data
            {
                //baca data dr MySqlDataReader dan simpan di objek
                User user = new User(int.Parse(hasil.GetValue(0).ToString()), 
                    hasil.GetValue(1).ToString(), 
                    hasil.GetValue(2).ToString(), 
                    hasil.GetValue(3).ToString(), 
                    int.Parse(hasil.GetValue(4).ToString()),
                    hasil.GetValue(5).ToString());
                listUser.Add(user);
            }
            return listUser;
        }

        public bool TambahData()
        {
            string sql = "INSERT INTO user(idUser, nama, password, email, no_hp, alamat) VALUES ('" +
                         this.IdUser + "', '" +
                         this.Nama.Replace("'", "\\'") + "', SHA2('" +
                         this.Password.Replace("'", "\\'") + "', 512), '" +
                         this.Email.Replace("'", "\\'") + "', '" +
                         this.NoHp + "', '" +
                         this.Alamat.Replace("'", "\\'") + "');";

            bool result = Koneksi.ExecuteDML(sql);
            return result;
        }

        public bool UbahData()
        {
            string sql = "UPDATE user " +
                         "SET " +
                         "nama = '" + this.Nama.Replace("'", "\\'") + "', " +
                         "email = '" + this.Email.Replace("'", "\\'") + "', " +
                         "no_telepon = '" + this.NoHp + "', " +
                         "alamat = '" + this.Alamat.Replace("'", "\\'") + "', " +
                         "WHERE idUser = '" + this.IdUser + "';";

            bool result = Koneksi.ExecuteDML(sql);
            return result;
        }

        public bool HapusData()
        {
            string sql = "DELETE FROM user WHERE idUser='" + this.IdUser + "'";
            bool result = Koneksi.ExecuteDML(sql);  
            return true;
        }

        public bool UbahPassword(string password)
        {
            string sql = "UPDATE user " +
                         "SET password = SHA2('" + password.Replace("'", "\\'") + "', 512) " +
                         "WHERE idUser = '" + this.IdUser + "';";
            bool result = Koneksi.ExecuteDML(sql);
            return result;
        }

        public static User AmbilDataByKode(string idUser)
        {
            string sql = "SELECT idUser, nama, password, email, no_hp, alamat " +
                         "FROM user " +
                         "WHERE idUser = '" + idUser + "'";

            MySqlDataReader hasil = Koneksi.AmbilData(sql);

            if (hasil.Read())
            {
                User user = new User(int.Parse(hasil.GetValue(0).ToString()),
                                        hasil.GetValue(1).ToString(),
                                        hasil.GetValue(2).ToString(),
                                        hasil.GetValue(3).ToString(),
                                        int.Parse(hasil.GetValue(4).ToString()),
                                        hasil.GetValue(5).ToString());
                return user;
            }
            else
            {
                return null;
            }
        }

        public static bool CekPassword(User user, string password)
        {
            string sql = "SELECT idUser, nama, password, email, no_hp, alamat" +
                         "FROM user " +
                         "WHERE idUser = '" + user.IdUser + "' AND password = SHA2('" + password + "', 512);";

            MySqlDataReader hasil = Koneksi.AmbilData(sql);

            if (hasil.Read() == true)
            {
                return true;
            }
            return false;
        }

        public static User CekLogin(string userName, string password)
        {
            string sql = "SELECT idUser, nama, password, email, no_hp, alamat "
                          + " FROM user ";

            if (userName == "" || password == "")
            {
                throw new Exception("Username atau password tidak boleh kosong");
            }
            else
            {
                sql += " WHERE nama ='" + userName + "' AND password = SHA2('" + password + "', 512);";
            }

            MySqlDataReader hasil = Koneksi.AmbilData(sql);

            if (hasil.Read() == true)
            {
                User result = new User(int.Parse(hasil.GetValue(0).ToString()),
                                        hasil.GetValue(1).ToString(),
                                        hasil.GetValue(2).ToString(),
                                        hasil.GetValue(3).ToString(),
                                        int.Parse(hasil.GetValue(4).ToString()),
                                        hasil.GetValue(5).ToString());
                return result;
            }
            return null;
        }
        #endregion
    }
}

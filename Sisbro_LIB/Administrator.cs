using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Sisbro_LIB
{
    public class Administrator
    {
        #region Data Member
        private int idAdministrator;
        private string nama;
        private string email;
        private int noHp;
        private string password;
        #endregion

        #region Constructors
        public Administrator()
        {
            IdAdministrator = 0;
            Nama = "";
            Email = "";
            NoHp = 0;
            Password = "";
        }

        public Administrator(int idAdministrator, string nama, string email, int noHp, string password)
        {
            this.IdAdministrator = idAdministrator;
            this.Nama = nama;
            this.Email = email;
            this.NoHp = noHp;
            this.Password = password;
        }
        #endregion

        #region Properties
        public int IdAdministrator { get => idAdministrator; set => idAdministrator = value; }
        public string Nama { get => nama; set => nama = value; }
        public string Email { get => email; set => email = value; }
        public int NoHp { get => noHp; set => noHp = value; }
        public string Password { get => password; set => password = value; }
        #endregion

        #region Method
        public static List<Administrator> BacaData(string kriteria, string nilai)
        {
            string sql;
            if (kriteria == "")
            {
                sql = "SELECT idAdministrator, nama, email, no_hp, password " +
                      "FROM administrator ";
            }
            else
            {
                sql = "SELECT idAdministrator, nama, email, no_hp, password " +
                      "FROM administrator " +
                      "WHERE " + kriteria + " like '%" + nilai + "%'";
            }

            MySqlDataReader hasil = Koneksi.AmbilData(sql);

            //buat list untuk menampung data
            List<Administrator> listAdminitartor = new List<Administrator>();
            while (hasil.Read() == true) //selama masih ada data
            {
                //baca data dr MySqlDataReader dan simpan di objek
                Administrator administrator = new Administrator(int.Parse(hasil.GetValue(0).ToString()),
                    hasil.GetValue(1).ToString(),
                    hasil.GetValue(2).ToString(),
                    int.Parse(hasil.GetValue(3).ToString()),
                    hasil.GetValue(4).ToString());
                listAdminitartor.Add(administrator);
            }
            return listAdminitartor;
        }

        public bool TambahData()
        {
            string sql = "INSERT INTO administrator(idAdministrator, nama, email, no_hp, password) VALUES ('" +
                         this.IdAdministrator + "', '" +
                         this.Nama.Replace("'", "\\'") + "', '" +
                         this.Email.Replace("'", "\\'") + "', '" +
                         this.NoHp +  "', SHA2('" +
                         this.Password.Replace("'", "\\'") + "', 512), '" + "');";

            bool result = Koneksi.ExecuteDML(sql);
            return result;
        }

        public bool UbahData()
        {
            string sql = "UPDATE administrator " +
                         "SET " +
                         "nama = '" + this.Nama.Replace("'", "\\'") + "', " +
                         "email = '" + this.Email.Replace("'", "\\'") + "', " +
                         "no_telepon = '" + this.NoHp + "', " +
                         "WHERE idAdministrator = '" + this.IdAdministrator + "';";

            bool result = Koneksi.ExecuteDML(sql);
            return result;
        }
        public bool HapusData()
        {
            string sql = "DELETE FROM user WHERE idAdministrator='" + this.IdAdministrator + "'";
            bool result = Koneksi.ExecuteDML(sql);
            return true;
        }

        public bool UbahPassword(string password)
        {
            string sql = "UPDATE administrator " +
                         "SET password = SHA2('" + password.Replace("'", "\\'") + "', 512) " +
                         "WHERE idAdministrator = '" + this.IdAdministrator + "';";
            bool result = Koneksi.ExecuteDML(sql);
            return result;
        }

        public static Administrator AmbilDataByKode(string idadministrator)
        {
            string sql = "SELECT idadministrator, nama, email, no_hp, password " +
                         "FROM administrator " +
                         "WHERE idadministrator = '" + idadministrator + "'";

            MySqlDataReader hasil = Koneksi.AmbilData(sql);

            if (hasil.Read())
            {
                Administrator admin = new Administrator(int.Parse(hasil.GetValue(0).ToString()),
                                                 hasil.GetValue(1).ToString(),
                                                 hasil.GetValue(2).ToString(),
                                                 int.Parse(hasil.GetValue(3).ToString()),
                                                 hasil.GetValue(4).ToString());
                return admin;
            }
            else
            {
                return null;
            }
        }
        public static bool CekPassword(Administrator administrator, string password)
        {
            string sql = "SELECT idAdministrator, nama, email, no_hp, password" +
                         "FROM administrator " +
                         "WHERE idAdministrator = '" + administrator.IdAdministrator + "' AND password = SHA2('" + password + "', 512);";

            MySqlDataReader hasil = Koneksi.AmbilData(sql);

            if (hasil.Read() == true)
            {
                return true;
            }
            return false;
        }

        public static Administrator CekLogin(string userName, string password)
        {
            string sql = "SELECT idAdministrator, nama, email, no_hp, password "
                          + " FROM administrator ";

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
                Administrator result = new Administrator(int.Parse(hasil.GetValue(0).ToString()),
                                                 hasil.GetValue(1).ToString(),
                                                 hasil.GetValue(2).ToString(),
                                                 int.Parse(hasil.GetValue(3).ToString()),
                                                 hasil.GetValue(4).ToString());
                return result;
            }
            return null;
        }
        #endregion
    }
}

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

        #endregion
    }
}

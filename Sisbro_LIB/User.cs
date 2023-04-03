using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Sisbro_LIB;

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

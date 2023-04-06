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

        #endregion
    }
}

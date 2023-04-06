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

        #endregion
    }
}

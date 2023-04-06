using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Sisbro_LIB
{
    public class Category
    {
        #region Data Member
        private int idCategory;
        private string nama;
        #endregion

        #region Properties
        public int IdCategory { get => idCategory; set => idCategory = value; }
        public string Nama { get => nama; set => nama = value; }
        #endregion

        #region Method

        #endregion
    }
}

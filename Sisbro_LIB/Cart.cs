using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Sisbro_LIB
{
    public class Cart
    {
        #region Data Member
        private Product product;
        private Orders orders;
        #endregion

        #region Properties
        public Product Product { get => product; set => product = value; }
        public Orders Orders { get => orders; set => orders = value; }
        #endregion

        #region Method

        #endregion
    }
}

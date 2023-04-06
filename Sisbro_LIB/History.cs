using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Sisbro_LIB
{
    public class History
    {
        #region Data Member
        private int idHistory;
        private User user;
        private Orders orders;
        #endregion

        #region Properties
        public int IdHistory { get => idHistory; set => idHistory = value; }
        public User User { get => user; set => user = value; }
        public Orders Orders { get => orders; set => orders = value; }
        #endregion

        #region Method

        #endregion
    }
}

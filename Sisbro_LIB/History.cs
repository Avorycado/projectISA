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

        #region Constructors
        public History(int idHistory, User user, Orders orders)
        {
            this.IdHistory = idHistory;
            this.User = user;
            this.Orders = orders;
        }
        #endregion

        #region Properties
        public int IdHistory { get => idHistory; set => idHistory = value; }
        public User User { get => user; set => user = value; }
        public Orders Orders { get => orders; set => orders = value; }
        #endregion

        #region Method
        public static List<History> BacaData(string kriteria, string nilai)
        {
            string sql;
            if (kriteria == "")
            {
                sql = "SELECT idhistory, user_iduser, order_idorder " +
                      "FROM history ";
            }
            else
            {
                sql = "SELECT idhistory, user_iduser, order_idorder " +
                      "FROM history " +
                      "WHERE " + kriteria + " like '%" + nilai + "%'";
            }

            MySqlDataReader hasil = Koneksi.AmbilData(sql);

            //buat list untuk menampung data
            List<History> listHistory = new List<History>();
            while (hasil.Read() == true) //selama masih ada data
            {
                User user = User.AmbilDataByKode(hasil.GetValue(0).ToString());
                Orders order = Orders.AmbilDataByKode(int.Parse(hasil.GetValue(0).ToString()));
                //baca data dr MySqlDataReader dan simpan di objek
                History history = new History(int.Parse(hasil.GetValue(0).ToString()),
                                              user, order);
                listHistory.Add(history);
            }
            return listHistory;
        }
        #endregion
    }
}

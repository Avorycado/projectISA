using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Sisbro_LIB
{
    public class Orders
    {
        #region Data Member
        private int idOrders;
        private DateTime tanggalOrder;
        private double totalPrice;
        private string alamatPengiriman;
        private User user;
        private PaymentMethod paymentMethod;
        #endregion

        #region Properties
        public int IdOrders { get => idOrders; set => idOrders = value; }
        public DateTime TanggalOrder { get => tanggalOrder; set => tanggalOrder = value; }
        public double TotalPrice { get => totalPrice; set => totalPrice = value; }
        public string AlamatPengiriman { get => alamatPengiriman; set => alamatPengiriman = value; }
        public User User { get => user; set => user = value; }
        public PaymentMethod PaymentMethod { get => paymentMethod; set => paymentMethod = value; }
        #endregion

        #region Method

        #endregion
    }
}

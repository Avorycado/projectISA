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

        #region Constructors
        public Cart(Product product, Orders orders)
        {
            this.Product = product;
            this.Orders = orders;
        }
        #endregion


        #region Properties
        public Product Product { get => product; set => product = value; }
        public Orders Orders { get => orders; set => orders = value; }
        #endregion

        #region Method
        public static List<Cart> BacaData(string kriteria, string nilai)
        {
            string sql;
            if (kriteria == "")
            {
                sql = "SELECT product_idproduct, order_idorder " +
                      "FROM cart ";
            }
            else
            {
                sql = "SELECT product_idproduct, order_idorder " +
                      "FROM cart " +
                      "WHERE " + kriteria + " like '%" + nilai + "%'";
            }

            MySqlDataReader hasil = Koneksi.AmbilData(sql);

            //buat list untuk menampung data
            List<Cart> listCart = new List<Cart>();
            while (hasil.Read() == true) //selama masih ada data
            {
                Product product = Product.AmbilDataByKode(int.Parse(hasil.GetValue(0).ToString()));
                Orders orders = Orders.AmbilDataByKode(int.Parse(hasil.GetValue(0).ToString()));
                //baca data dr MySqlDataReader dan simpan di objek
                Cart cart = new Cart(product, orders);
                listCart.Add(cart);
            }
            return listCart;
        }
        #endregion
    }
}

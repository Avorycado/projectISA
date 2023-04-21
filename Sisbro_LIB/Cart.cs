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
        private int jumlahBarang;
        #endregion

        #region Constructors
        public Cart(Product product, Orders orders, int jumlahBarang)
        {
            this.Product = product;
            this.Orders = orders;
            this.JumlahBarang = jumlahBarang;
        }
        #endregion


        #region Properties
        public Product Product { get => Product; set => Product = value; }
        public Orders Orders { get => Orders; set => Orders = value; }
        public int JumlahBarang { get => jumlahBarang; set => jumlahBarang = value; }
        #endregion

        #region Method
        public static List<Cart> BacaData(string kriteria, string nilai)
        {
            string sql;
            if (kriteria == "")
            {
                sql = "SELECT c.product_idproduct, c.order_idorder, jumlahBarang " +
                      "FROM cart c inner join product p on c.product_idproduct=p.productid inner join order o on c.order_idorder=o.orderid ";
            }
            else
            {
                sql = "SELECT c.product_idproduct, c.order_idorder, jumlahBarang " +
                      "FROM cart c inner join product p on c.product_idproduct=p.productid inner join order o on c.order_idorder=o.orderid " +
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
                Cart cart = new Cart(product, orders, int.Parse(hasil.GetValue(2).ToString()));
                listCart.Add(cart);
            }
            return listCart;
        }
        public bool TambahData()
        {
            string sql = "INSERT INTO cart(product_idproduct, order_idorder, jumlahBarang) VALUES ('" +
                         this.Product.IdProduct + "', '" +
                         this.Orders.IdOrders + "', '" +
                         this.JumlahBarang + "');";

            bool result = Koneksi.ExecuteDML(sql);
            return result;
        }

        public bool UbahData()
        {
            string sql = "UPDATE cart " +
                         "SET " +
                         "jumlahBarang = '" + this.JumlahBarang + "';";

            bool result = Koneksi.ExecuteDML(sql);
            return result;
        }

        public bool HapusData()
        {
            string sql = "DELETE FROM cart WHERE idProduct='" + this.Product.IdProduct + "'";
            bool result = Koneksi.ExecuteDML(sql);
            return true;
        }
        #endregion
    }
}

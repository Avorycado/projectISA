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
        private int idCart;
        private User user;
        private Product product;
        private int jumlahBarang;
        #endregion

        #region Constructors
        public Cart(int idCart, User user, Product product, int jumlahBarang)
        {
            IdCart = idCart;
            User = user;
            Product = product;
            JumlahBarang = jumlahBarang;
        }
        #endregion


        #region Properties
        public int IdCart { get => idCart; set => idCart = value; }
        public User User { get => user; set => user = value; }
        public Product Product { get => product; set => product = value; }
        public int JumlahBarang { get => jumlahBarang; set => jumlahBarang = value; }
        #endregion

        #region Method
        public static List<Cart> BacaData(string kriteria, string nilai)
        {
            string sql;
            if (kriteria == "")
            {
                sql = "SELECT c.idcart, c.user_iduser, c.product_idproduct, c.jumlah " +
                      "FROM cart c inner join product p on c.product_idproduct=p.idproduct inner join user u on c.user_iduser=u.iduser";
            }
            else
            {
                sql = "SELECT c.idcart, c.user_iduser, c.product_idproduct, c.jumlah " +
                      "FROM cart c inner join product p on c.product_idproduct=p.idproduct inner join user u on c.user_iduser=u.iduser " +
                      "WHERE " + kriteria + " like '%" + nilai + "%'";
            }

            MySqlDataReader hasil = Koneksi.AmbilData(sql);

            //buat list untuk menampung data
            List<Cart> listCart = new List<Cart>();
            while (hasil.Read() == true) //selama masih ada data
            {
                Product product = Product.AmbilDataByKode(int.Parse(hasil.GetValue(2).ToString()));
                User user = User.AmbilDataByKode(hasil.GetString(1));
                //baca data dr MySqlDataReader dan simpan di objek
                Cart cart = new Cart(int.Parse(hasil.GetValue(0).ToString()), user, product, int.Parse(hasil.GetValue(3).ToString()));
                listCart.Add(cart);
            }
            return listCart;
        }
        public bool TambahData()
        {
            string sql = "INSERT INTO cart(idcart, user_iduser, product_idproduct, jumlah) VALUES ('" +
                         this.IdCart + "', '" +
                         this.User.IdUser+ "', '" +
                         this.Product.IdProduct + "', '" +
                         this.JumlahBarang + "');";

            bool result = Koneksi.ExecuteDML(sql);
            return result;
        }

        public bool UbahData()
        {
            string sql = "UPDATE cart " +
                         "SET " +
                         "jumlah = '" + this.JumlahBarang + "';";

            bool result = Koneksi.ExecuteDML(sql);
            return result;
        }

        public bool HapusData()
        {
            string sql = "DELETE FROM cart WHERE idProduct='" + this.Product.IdProduct + "'";
            bool result = Koneksi.ExecuteDML(sql);
            return true;
        }

        public static int GenerateIdCard()
        {
            string sql = "SELECT MAX(idcart) FROM cart;";

            int hasilId = 0;
            MySqlDataReader hasil = Koneksi.AmbilData(sql);
            if (hasil.Read())
            {
                if (hasil.GetValue(0).ToString() != "")
                {
                    hasilId = int.Parse(hasil.GetValue(0).ToString()) + 1;
                }
                else
                {
                    hasilId = 1;
                }
            }
            return hasilId;
        }
        #endregion
    }
}

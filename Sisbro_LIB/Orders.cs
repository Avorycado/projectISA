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
        private Product product;
        #endregion

        #region Constructors
        public Orders(int idOrders, DateTime tanggalOrder, double totalPrice, string alamatPengiriman, User user, PaymentMethod paymentMethod, Product product)
        {
            this.IdOrders = idOrders;
            this.TanggalOrder = tanggalOrder;
            this.TotalPrice = totalPrice;
            this.AlamatPengiriman = alamatPengiriman;
            this.User = user;
            this.PaymentMethod = paymentMethod;
            this.Product = product;
        }
        #endregion

        #region Properties
        public int IdOrders { get => idOrders; set => idOrders = value; }
        public DateTime TanggalOrder { get => tanggalOrder; set => tanggalOrder = value; }
        public double TotalPrice { get => totalPrice; set => totalPrice = value; }
        public string AlamatPengiriman { get => alamatPengiriman; set => alamatPengiriman = value; }
        public User User { get => user; set => user = value; }
        public PaymentMethod PaymentMethod { get => paymentMethod; set => paymentMethod = value; }
        public Product Product { get => product; set => product = value; }
        #endregion

        #region Method
        public static List<Orders> BacaData(string kriteria, string nilai)
        {
            string sql;
            if (kriteria == "")
            {
                sql = "SELECT o.idorder, o.tanggal_order, o.total_price, o.alamat_pengiriman, o.user_iduser, o.payment_method_idpayment_method, o.product_idproduct " +
                      "FROM `order` o INNER JOIN user u ON o.user_iduser=u.iduser INNER JOIN payment_method p ON o.payment_method_idpayment_method=p.idpayment_method INNER JOIN product po ON o.product_idproduct = po.idproduct" + ";";
            }
            else
            {
                sql = "SELECT o.idorder, o.tanggal_order, o.total_price, o.alamat_pengiriman, o.user_iduser, o.payment_method_idpayment_method, o.product_idproduct " +
                      "FROM `order` o INNER JOIN user u ON o.user_iduser=u.iduser INNER JOIN payment_method p ON o.payment_method_idpayment_method=p.idpayment_method INNER JOIN product po ON o.product_idproduct = po.idproduct" +
                      "WHERE " + kriteria + " like '%" + nilai + "%'";
            }

            MySqlDataReader hasil = Koneksi.AmbilData(sql);

            //buat list untuk menampung data
            List<Orders> listOrders = new List<Orders>();
            while (hasil.Read() == true) //selama masih ada data
            {
                User user = User.AmbilDataByKode(hasil.GetValue(4).ToString());
                PaymentMethod paymentMethod = PaymentMethod.AmbilDataByKode(hasil.GetValue(5).ToString());
                Product product = Product.AmbilDataByKode(int.Parse(hasil.GetValue(6).ToString()));
                //baca data dr MySqlDataReader dan simpan di objek
                //Orders orders = new Orders(int.Parse(hasil.GetValue(0).ToString()),
                //    (DateTime)hasil.GetValue(1),
                //    double.Parse(hasil.GetValue(2).ToString(), hasil.GetValue(3).ToString(), user, paymentMethod));
                Orders orders = new Orders(int.Parse(hasil.GetValue(0).ToString()), 
                                (DateTime)hasil.GetValue(1), 
                                double.Parse(hasil.GetValue(2).ToString()), 
                                hasil.GetValue(3).ToString(), 
                                user, 
                                paymentMethod, 
                                product);
                listOrders.Add(orders);
            }
            return listOrders;
        }
        public bool TambahData()
        {
            string sql = "INSERT INTO `order`(idOrder, tanggal_order, total_price, alamat_pengiriman, user_iduser, payment_method_idpayment_method, product_idproduct) VALUES ('" +
                         this.IdOrders + "', '" +
                         this.TanggalOrder.ToString("yyyy-MM-dd hh-mm-ss") + "', '" +
                         this.TotalPrice + "', '" +
                         this.AlamatPengiriman + "', '" +
                         this.User.IdUser + "', '" +
                         this.PaymentMethod.IdPaymentMethod + "', '" +
                         this.Product.IdProduct + "');";

            bool result = Koneksi.ExecuteDML(sql);
            return result;
        }

        public static List<Orders> AmbilData()
        {
            string sql = "SELECT o.idorder, o.tanggal_order, o.total_price, o.alamat_pengiriman, o.user_iduser, o.payment_method_idpayment_method, o.product_idproduct FROM `order` o " +
                "INNER JOIN user u ON o.user_iduser = u.iduser INNER JOIN payment_method pm ON o.payment_method_idpayment_method = pm.idpayment_method INNER JOIN product p ON o.product_idproduct = p.idproduct;";

            MySqlDataReader hasil = Koneksi.AmbilData(sql);

            //buat list untuk menampung data
            List<Orders> listOrders = new List<Orders>();
            while (hasil.Read() == true) //selama masih ada data
            {
                User user = User.AmbilDataByKode(hasil.GetValue(4).ToString());
                PaymentMethod paymentMethod = PaymentMethod.AmbilDataByKode(hasil.GetString(5));
                Product product = Product.AmbilDataByKode((int)hasil.GetValue(6));
                //baca data dr MySqlDataReader dan simpan di objek
                //Orders orders = new Orders(int.Parse(hasil.GetValue(0).ToString()),
                //    (DateTime)hasil.GetValue(1),
                //    double.Parse(hasil.GetValue(2).ToString(), hasil.GetValue(3).ToString(), user, paymentMethod));
                listOrders.Add(new Orders(int.Parse(hasil.GetValue(0).ToString()),
                                (DateTime)hasil.GetValue(1),
                                double.Parse(hasil.GetValue(2).ToString()),
                                hasil.GetValue(3).ToString(),
                                user,
                                paymentMethod,
                                product));
            }
            return listOrders;
        }
        //public bool UbahData()
        //{
        //    string sql = "UPDATE orders " +
        //                 "SET " +
        //                 "nama = '" + this.Nama.Replace("'", "\\'") + "', " +
        //                 "email = '" + this.Email.Replace("'", "\\'") + "', " +
        //                 "no_telepon = '" + this.NoHp + "', " +
        //                 "alamat = '" + this.Alamat.Replace("'", "\\'") + "', " +
        //                 "WHERE idUser = '" + this.IdUser + "';";

        //    bool result = Koneksi.ExecuteDML(sql);
        //    return result;
        //}

        public bool HapusData()
        {
            string sql = "DELETE FROM `order` WHERE idOrder='" + this.IdOrders + "'";
            bool result = Koneksi.ExecuteDML(sql);
            return true;
        }

        public static Orders AmbilDataByKode(int idOrders)
        {
            string sql = "SELECT o.idorder, o.tanggal_order, o.total_price, o.alamat_pengiriman, u.iduser, p.idpayment_method, o.product_idproduct " +
                          "FROM `order` o INNER JOIN user u ON o.user_iduser=u.iduser INNER JOIN payment_method p ON o.payment_method_idpayment_method=p.idpayment_method INNER JOIN product po ON o.product_idproduct = po.idproduct" + ";";

            MySqlDataReader hasil = Koneksi.AmbilData(sql);

            if (hasil.Read())
            {
                User user = User.AmbilDataByKode(hasil.GetValue(0).ToString());
                PaymentMethod paymentMethod = PaymentMethod.AmbilDataByKode(hasil.GetValue(0).ToString());
                Product product = Product.AmbilDataByKode(int.Parse(hasil.GetValue(6).ToString()));
                Orders orders = new Orders(int.Parse(hasil.GetValue(0).ToString()),
                                (DateTime)hasil.GetValue(1),
                                double.Parse(hasil.GetValue(2).ToString()),
                                hasil.GetValue(3).ToString(),
                                user,
                                paymentMethod,
                                product);
                return orders;
            }
            else
            {
                return null;
            }
        }
        public static int GenerateIdOrder()
        {
            string sql = "SELECT MAX(idorder) FROM `order`;";

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

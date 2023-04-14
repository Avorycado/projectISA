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

        #region Constructors
        public Orders(int idOrders, DateTime tanggalOrder, double totalPrice, string alamatPengiriman, User user, PaymentMethod paymentMethod)
        {
            this.IdOrders = idOrders;
            this.TanggalOrder = tanggalOrder;
            this.TotalPrice = totalPrice;
            this.AlamatPengiriman = alamatPengiriman;
            this.User = user;
            this.PaymentMethod = paymentMethod;
        }
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
        public static List<Orders> BacaData(string kriteria, string nilai)
        {
            string sql;
            if (kriteria == "")
            {
                sql = "SELECT o.idorder, o.tanggal_order, o.total_price, o.alamat_pengiriman, u.iduser, p.idpayment_method " +
                      "FROM orders o INNER JOIN user u ON o.user_iduser=u.iduser INNER JOIN payment_method p ON o.payment_method_idpayment_method=p.idpayment_method" + ";";
            }
            else
            {
                sql = "SELECT o.idorder, o.tanggal_order, o.total_price, o.alamat_pengiriman, u.iduser, p.idpayment_method " +
                      "FROM orders o INNER JOIN user u ON o.user_iduser=u.iduser INNER JOIN payment_method p ON o.payment_method_idpayment_method=p.idpayment_method" +
                      "WHERE " + kriteria + " like '%" + nilai + "%'";
            }

            MySqlDataReader hasil = Koneksi.AmbilData(sql);

            //buat list untuk menampung data
            List<Orders> listOrders = new List<Orders>();
            while (hasil.Read() == true) //selama masih ada data
            {
                User user = User.AmbilDataByKode(hasil.GetValue(0).ToString());
                PaymentMethod paymentMethod = PaymentMethod.AmbilDataByKode(hasil.GetValue(0).ToString());
                //baca data dr MySqlDataReader dan simpan di objek
                //Orders orders = new Orders(int.Parse(hasil.GetValue(0).ToString()),
                //    (DateTime)hasil.GetValue(1),
                //    double.Parse(hasil.GetValue(2).ToString(), hasil.GetValue(3).ToString(), user, paymentMethod));
                Orders orders = new Orders(int.Parse(hasil.GetValue(0).ToString()), 
                                (DateTime)hasil.GetValue(1), 
                                double.Parse(hasil.GetValue(2).ToString()), 
                                hasil.GetValue(3).ToString(), 
                                user, 
                                paymentMethod);
                listOrders.Add(orders);
            }
            return listOrders;
        }
        public bool TambahData()
        {
            string sql = "INSERT INTO orders(idOrder, tanggal_order, total_price, alamat_pengiriman, user_iduser, payment_method_idpayment_method) VALUES ('" +
                         this.IdOrders + "', '" +
                         this.TanggalOrder.ToString("yyyy-MM-dd hh-mm-ss") + "', '" +
                         this.TotalPrice + "', '" +
                         this.AlamatPengiriman + "', '" +
                         this.User.IdUser + "', '" +
                         this.PaymentMethod.IdPaymentMethod + "');";

            bool result = Koneksi.ExecuteDML(sql);
            return result;
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
            string sql = "DELETE FROM orders WHERE idOrder='" + this.IdOrders + "'";
            bool result = Koneksi.ExecuteDML(sql);
            return true;
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient; 

namespace Sisbro_LIB
{
    public class PaymentMethod
    {
        #region Data Member
        private int idPaymentMethod;
        private string nama;
        #endregion

        #region Constructors
        public PaymentMethod()
        {
            IdPaymentMethod = 0;
            Nama = "";
        }

        public PaymentMethod(int idPaymentMethod, string nama)
        {
            this.IdPaymentMethod = idPaymentMethod;
            this.Nama = nama;
        }
        #endregion

        #region Properties
        public int IdPaymentMethod { get => idPaymentMethod; set => idPaymentMethod = value; }
        public string Nama { get => nama; set => nama = value; }
        #endregion

        #region Method
        public static PaymentMethod AmbilDataByKode(string idPaymentMethod)
        {
            string sql = "SELECT idpayment_method, nama " +
                         "FROM payment_method " +
                         "WHERE idpayment_method = '" + idPaymentMethod + "'";

            MySqlDataReader hasil = Koneksi.AmbilData(sql);

            if (hasil.Read())
            {
                PaymentMethod payment = new PaymentMethod(int.Parse(hasil.GetValue(0).ToString()),
                                        hasil.GetValue(1).ToString());
                return payment;
            }
            else
            {
                return null;
            }
        }

        public static List<PaymentMethod> BacaData(string kriteria, string nilai)
        {
            string sql;
            if (kriteria == "")
            {
                sql = "SELECT idpayment_method, nama " +
                      "FROM payment_method ";
            }
            else
            {
                sql = "SELECT idpayment_method, nama " +
                      "FROM payment_method " +
                      "WHERE " + kriteria + " like '%" + nilai + "%'";
            }

            MySqlDataReader hasil = Koneksi.AmbilData(sql);

            //buat list untuk menampung data
            List<PaymentMethod> listPayment = new List<PaymentMethod>();
            while (hasil.Read() == true) //selama masih ada data
            {
                //baca data dr MySqlDataReader dan simpan di objek
                PaymentMethod payment = new PaymentMethod(int.Parse(hasil.GetValue(0).ToString()),
                                                hasil.GetValue(1).ToString());
                listPayment.Add(payment);
            }
            return listPayment ;
        }
        #endregion
    }
}

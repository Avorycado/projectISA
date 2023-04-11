using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Sisbro_LIB
{
    public class Product
    {
        #region Data Member
        private int idProduct;
        private string nama;
        private double harga;
        private string deskripsi;
        private int jumlah;
        private Category category;
        private Sellers sellers;
        private Administrator administrator;
        #endregion

        #region Constructors
        public Product(int idProduct, string nama, double harga, string deskripsi, int jumlah, Category category, Sellers sellers, Administrator administrator)
        {
            this.IdProduct = idProduct;
            this.Nama = nama;
            this.Harga = harga;
            this.Deskripsi = deskripsi;
            this.Jumlah = jumlah;
            this.Category = category;
            this.Sellers = sellers;
            this.Administrator = administrator;
        }
        #endregion

        #region Properties
        public int IdProduct { get => idProduct; set => idProduct = value; }
        public string Nama { get => nama; set => nama = value; }
        public double Harga { get => harga; set => harga = value; }
        public string Deskripsi { get => deskripsi; set => deskripsi = value; }
        public int Jumlah { get => jumlah; set => jumlah = value; }
        public Category Category { get => category; set => category = value; }
        public Sellers Sellers { get => sellers; set => sellers = value; }
        public Administrator Administrator { get => administrator; set => administrator = value; }
        #endregion

        #region Method
        public static Product AmbilDataByKode(int idproduct)
        {
            string sql = "SELECT idproduct, nama, harga, deskripsi, jumlah, category_idcategory, sellers_idsellers, administrator_idadministrator " +
                         "FROM product " +
                         "WHERE idproduct = '" + idproduct + "'";

            MySqlDataReader hasil = Koneksi.AmbilData(sql);
            while(hasil.Read() == true)
            {
                Category kategori = Category.AmbilDataByKode(hasil.GetValue(0).ToString());
                Sellers sellers = Sellers.AmbilDataByKode(hasil.GetValue(1).ToString());
                Administrator admin = Administrator.AmbilDataByKode(hasil.GetValue(2).ToString());
                if (hasil.Read())
                {
                    Product produk = new Product(int.Parse(hasil.GetValue(0).ToString()),
                                                     hasil.GetValue(1).ToString(),
                                                     double.Parse(hasil.GetValue(2).ToString()),
                                                     hasil.GetValue(3).ToString(),
                                                     int.Parse(hasil.GetValue(4).ToString()),
                                                     kategori, sellers, admin);
                    return produk;
                }
                else
                {
                    return null;
                }
            }
            return null;
        }
        #endregion
    }
}

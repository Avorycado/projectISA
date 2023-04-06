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

        #endregion
    }
}

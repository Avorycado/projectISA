using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Sisbro_LIB
{
    public class Riview
    {
        #region Data Member
        private int idRiview;
        private string deskripsi;
        private Product product;
        #endregion

        #region Constructors
        public Riview(int idRiview, string deskripsi, Product product)
        {
            this.IdRiview = idRiview;
            this.Deskripsi = deskripsi;
            this.Product = product;
        }
        #endregion

        #region Properties
        public int IdRiview { get => idRiview; set => idRiview = value; }
        public string Deskripsi { get => deskripsi; set => deskripsi = value; }
        public Product Product { get => product; set => product = value; }
        #endregion

        #region Method

        #endregion
    }
}

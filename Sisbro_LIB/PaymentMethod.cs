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

        #endregion
    }
}

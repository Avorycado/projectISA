using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Sisbro_LIB;

namespace Project_ISA
{
    public partial class FormVerifikasi : Form
    {
        public FormVerifikasi()
        {
            InitializeComponent();
        }
        public List<Product> listProduct = new List<Product>();
        public Product product;
        private void dataGridViewVerifikasi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormVerifikasi_Load(object sender, EventArgs e)
        {
            listProduct = Product.BacaData("", "");
            if(product.Status == "Unverified")
            {

            }
        }
    }
}

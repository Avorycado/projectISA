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
        public List<Product> listProduct2 = new List<Product>();
        public Product product;
        private void dataGridViewVerifikasi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormVerifikasi_Load(object sender, EventArgs e)
        {
            listProduct = Product.AmbilFoto();
            foreach (Product product in listProduct)
            {
                if (listProduct.Count > 0)
                {
                    if (product.Status == "Unverified")
                    {
                        listProduct2.Add(product);
                    }
                }
            }
            if (listProduct.Count > 0)
            {
                dataGridViewVerifikasi.DataSource = listProduct2;
                if (dataGridViewVerifikasi.ColumnCount == 10)
                {
                    DataGridViewButtonColumn bcol1 = new DataGridViewButtonColumn();
                    bcol1.HeaderText = "Aksi";
                    bcol1.Text = "Verifikasi";
                    bcol1.Name = "buttonVerifikasiGrid";
                    bcol1.UseColumnTextForButtonValue = true;
                    dataGridViewVerifikasi.Columns.Add(bcol1);
                }
            }
        }
    }
}

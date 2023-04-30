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
            try
            {
                int idProduct = int.Parse(dataGridViewVerifikasi.CurrentRow.Cells["idProduct"].Value.ToString());
                string nama = dataGridViewVerifikasi.CurrentRow.Cells["nama"].Value.ToString();
                double harga = double.Parse(dataGridViewVerifikasi.CurrentRow.Cells["harga"].Value.ToString());
                string deskripsi = dataGridViewVerifikasi.CurrentRow.Cells["deskripsi"].Value.ToString();
                int jumlah = int.Parse(dataGridViewVerifikasi.CurrentRow.Cells["jumlah"].Value.ToString());
                Category category = (Category)dataGridViewVerifikasi.CurrentRow.Cells["category"].Value;
                Sellers sellers = (Sellers)dataGridViewVerifikasi.CurrentRow.Cells["sellers"].Value;
                Administrator administrator = (Administrator)dataGridViewVerifikasi.CurrentRow.Cells["administrator"].Value;
                string foto = dataGridViewVerifikasi.CurrentRow.Cells["foto"].Value.ToString();
                string status = dataGridViewVerifikasi.CurrentRow.Cells["status"].Value.ToString();
                Product product = new Product(idProduct, nama, harga, deskripsi, jumlah, category, sellers, administrator, foto, status);

                listProduct = Product.AmbilFoto();
                if (listProduct != null)
                {
                    if (e.ColumnIndex == dataGridViewVerifikasi.Columns["buttonVerifikasiGrid"].Index && e.RowIndex >= 0)
                    {
                        try
                        {
                            if (product.Status == "Unverified")
                            {
                                DialogResult confirm = MessageBox.Show("Apakah anda yakin ingin memverifikasi pengajuan product '" + product.Nama +
                                                                             "'?", "Konfirmasi Verifikasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (confirm == DialogResult.Yes)
                                {
                                    product.Status = "Verified";
                                    if (product.UbahStatus())
                                    {
                                        MessageBox.Show("Data pengajuan product telah berhasil diverifikasi");
                                        this.FormVerifikasi_Load(sender, e);
                                    }
                                }
                            }
                            else
                            {
                                MessageBox.Show("Status produk anda belum aktif");
                            }
                        }
                        catch (Exception x)
                        {
                            MessageBox.Show(x.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                    }
                    else if (e.ColumnIndex == dataGridViewVerifikasi.Columns["buttonHapusGrid"].Index && e.RowIndex >= 0)
                    {
                        try
                        {
                            DialogResult deleteConfirm = MessageBox.Show("Apakah anda yakin ingin menghapus data produk '" + product.IdProduct +
                                                                         "'?", "Konfirmasi Hapus", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (deleteConfirm == DialogResult.Yes)
                            {
                                if (product.HapusData())
                                {
                                    MessageBox.Show("Data produk telah berhasil dihapus");
                                    this.FormVerifikasi_Load(sender, e);
                                }
                            }
                        }
                        catch (Exception x)
                        {
                            MessageBox.Show(x.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void FormVerifikasi_Load(object sender, EventArgs e)
        {
            listProduct2.Clear();
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
                        
            if (listProduct2.Count > 0)
            {
                dataGridViewVerifikasi.DataSource = listProduct2;
                //dataGridViewVerifikasi.Columns.Add("idProduct", "Id Product");
                //dataGridViewVerifikasi.Columns.Add("nama", "Nama");
                //dataGridViewVerifikasi.Columns.Add("harga", "Harga");
                //dataGridViewVerifikasi.Columns.Add("deskripsi", "Deskripsi");
                //dataGridViewVerifikasi.Columns.Add("jumlah", "Jumlah");
                //dataGridViewVerifikasi.Columns.Add("category_idcategory", "Category");
                //dataGridViewVerifikasi.Columns.Add("sellers_idsellers", "Sellers");
                //dataGridViewVerifikasi.Columns.Add("administrator_idadministrator", "Administrator");
                //dataGridViewVerifikasi.Columns.Add("foto_product", "Foto Product");
                //dataGridViewVerifikasi.Columns.Add("status", "Status");

                //foreach (Product product in listProduct2)
                //{
                //    dataGridViewVerifikasi.Rows.Add(product.IdProduct, product.Nama, product.Harga, product.Deskripsi,
                //                                    product.Jumlah, product.Category.Nama, product.Sellers.Nama,
                //                                    product.Administrator.Nama, product.Foto, product.Status);
                //}
                if (dataGridViewVerifikasi.ColumnCount <= 11)
                {
                    DataGridViewButtonColumn buttonVerifikasi = new DataGridViewButtonColumn();
                    buttonVerifikasi.HeaderText = "Aksi";
                    buttonVerifikasi.Text = "Verifikasi";
                    buttonVerifikasi.Name = "buttonVerifikasiGrid";
                    buttonVerifikasi.UseColumnTextForButtonValue = true;
                    dataGridViewVerifikasi.Columns.Add(buttonVerifikasi);

                    DataGridViewButtonColumn buttonDeleteColumn = new DataGridViewButtonColumn();
                    //tent judul header dari kolom tombol
                    buttonDeleteColumn.HeaderText = "Aksi";
                    //tent text dari tombol yg dibuat
                    buttonDeleteColumn.Text = "Hapus";
                    //tent nama dari tombol yg dibuat
                    buttonDeleteColumn.Name = "buttonHapusGrid";
                    buttonDeleteColumn.UseColumnTextForButtonValue = true;
                    dataGridViewVerifikasi.Columns.Add(buttonDeleteColumn);
                }
            }
            else
            {
                dataGridViewVerifikasi.DataSource = null;
                dataGridViewVerifikasi.Rows.Clear();
            }
        }
    }
}

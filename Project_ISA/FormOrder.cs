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
    public partial class FormOrder : Form
    {
        public FormOrder()
        {
            InitializeComponent();
        }

        public FormOrder(Product product1)
        {
            InitializeComponent();
            product = product1;
        }

        public User user;
        public Sellers sellers;
        public string namaProduct;
        public Product product;
        public List<PaymentMethod> listPayment = new List<PaymentMethod>();
        FormProduct formProduct;
        private void FormOrder_Load(object sender, EventArgs e)
        {
            FormUtama formUtama = (FormUtama)this.Owner;

            labelInfoToko.Text = "Info Seller: " + product.Sellers.Nama;

            labelAlamat.Text = "Alamat Pengiriman: " + formUtama.tmpUser.Alamat;
            //labelInfoToko.Text = formUtama.tmpProduct.Sellers.Nama;
            //string payment = comboBoxMetodePembayaran.Text;

            listBoxOrder.Items.Add(product.IdProduct);

            

            listPayment = PaymentMethod.BacaData("", "");

            comboBoxMetodePembayaran.DataSource = listPayment;
            comboBoxMetodePembayaran.DisplayMember = "Nama";
            comboBoxMetodePembayaran.DropDownStyle = ComboBoxStyle.DropDownList;


            //labelInfoToko.Text = sellers.Nama + "\n" + product.Nama + "\n" + product.Jumlah + " " + product.Harga;
        }

        private void buttonCheckOut_Click(object sender, EventArgs e)
        {
            try
            {
                FormUtama formUtama = (FormUtama)this.Owner;

                PaymentMethod paymentMethod = (PaymentMethod)comboBoxMetodePembayaran.SelectedItem;
                MessageBox.Show(paymentMethod.ToString());
                //Product product2 = Product.AmbilDataByKode(product.IdProduct);
                double total = product.Harga + 15000;

                Orders order = new Orders(Orders.GenerateIdOrder(), DateTime.Now, total, comboBoxInfoPengiriman.Text, formUtama.tmpUser, paymentMethod, product);

                if (order.TambahData())
                {
                    MessageBox.Show("Data order berhasil untuk ditambahkan!");
                    listBoxOrder.Items.Add(product);
                    this.DialogResult = DialogResult.OK;

                }
                else
                {
                    throw new Exception("Gagal untuk menambahkan data!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBoxInfoPengiriman_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBoxMetodePembayaran_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void labelAlamat_Click(object sender, EventArgs e)
        {

        }

        private void labelInfoToko_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}

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
       
        public User user;
        public PaymentMethod paymentMethod;
        public Sellers sellers;
        public double totalPrice;
        public string namaProduct;
        public Product product;
        public List<PaymentMethod> listPayment = new List<PaymentMethod>();
        private void FormOrder_Load(object sender, EventArgs e)
        {
            FormUtama formUtama = (FormUtama)this.Owner;

            labelAlamat.Text = "Alamat Pengiriman: " + formUtama.tmpUser.Alamat;
            labelInfoToko.Text = product.Sellers.Nama;
            string payment = comboBoxMetodePembayaran.Text;
            listPayment = PaymentMethod.BacaData("nama", payment);

            
            //labelInfoToko.Text = sellers.Nama + "\n" + product.Nama + "\n" + product.Jumlah + " " + product.Harga;
        }

        private void buttonCheckOut_Click(object sender, EventArgs e)
        {
            try
            {
                Orders order = new Orders(DateTime.Now, totalPrice,
                    comboBoxInfoPengiriman.Text, user,);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void comboBoxInfoPengiriman_SelectedIndexChanged(object sender, EventArgs e)
        {
            User pengirimanDipilih = (User)comboBoxInfoPengiriman.SelectedItem;
        }

        private void comboBoxMetodePembayaran_SelectedIndexChanged(object sender, EventArgs e)
        {
            PaymentMethod pembayaranDipilih = (PaymentMethod)comboBoxMetodePembayaran.SelectedItem;
        }

        private void labelAlamat_Click(object sender, EventArgs e)
        {

        }

        private void labelInfoToko_Click(object sender, EventArgs e)
        {

        }
    }
}

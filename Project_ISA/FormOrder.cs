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
        public Sellers sellers;
        public Product product;
        private void FormOrder_Load(object sender, EventArgs e)
        {
            FormUtama formUtama = (FormUtama)this.Owner;

            labelAlamat.Text = "Alamat Pengiriman: " + formUtama.tmpUser.Alamat;
            //labelInfoToko.Text = sellers.Nama + "\n" + product.Nama + "\n" + product.Jumlah + " " + product.Harga;
        }

        private void buttonCheckOut_Click(object sender, EventArgs e)
        {
            try
            {
                
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

    }
}

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
    public partial class FormAddPaymentMethods : Form
    {
        public FormAddPaymentMethods()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxPaymentMethod.Text != "" && textBoxPaymentMethod.Text != null)
                {
                    int id = PaymentMethod.GenerateIdProduct();
                    PaymentMethod.TambahData(id, textBoxPaymentMethod.Text);
                    MessageBox.Show("Metode pembayaran berhasil ditambahkan.", "Information");
                    textBoxPaymentMethod.Text = "";
                }
                else
                {
                    MessageBox.Show("Metode pembayaran tidak boleh kosong!.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error menambahkan metode pembayaran. Error Message : " + ex.Message,
                    "Failure");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxPaymentMethod.Text = "";
            textBoxPaymentMethod.Focus();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

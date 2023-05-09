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
    public partial class FormHistory : Form
    {
        FormUtama formUtama;
        public List<History> listHistory = new List<History>();
        public List<Orders> listOrder = new List<Orders>();
        public FormHistory()
        {
            InitializeComponent();
        }

        private void dataGridViewHistory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int idOrder = int.Parse(dataGridViewHistory.CurrentRow.Cells["idOrders"].Value.ToString());
                DateTime tanggal_order = (DateTime)dataGridViewHistory.CurrentRow.Cells["tanggalOrder"].Value;
                double totalPrice = double.Parse(dataGridViewHistory.CurrentRow.Cells["totalPrice"].Value.ToString());
                string alamatPengiriman = dataGridViewHistory.CurrentRow.Cells["alamatPengiriman"].Value.ToString();
                User user = (User)dataGridViewHistory.CurrentRow.Cells["user"].Value;
                PaymentMethod paymentMethod= (PaymentMethod)dataGridViewHistory.CurrentRow.Cells["paymentMethod"].Value;
                Product product = (Product)dataGridViewHistory.CurrentRow.Cells["product"].Value;
                Orders orders = new Orders(idOrder, tanggal_order, totalPrice, alamatPengiriman, user, paymentMethod, product);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormHistory_Load(object sender, EventArgs e)
        {
            //formUtama= (FormUtama)this.MdiParent;
            //dataGridViewHistory.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            listOrder = Orders.AmbilData();
            //MessageBox.Show(listOrder[1].Product.Nama.ToString());

            foreach(Orders o in listOrder)
            {
                MessageBox.Show(o.Product.ToString());
            }
            if (listOrder.Count > 0)
            {
                dataGridViewHistory.DataSource = listOrder;
            }
            else
            {
                dataGridViewHistory.DataSource = null;
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

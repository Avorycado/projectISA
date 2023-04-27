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
        public FormHistory()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int idHistory = int.Parse(dataGridView1.CurrentRow.Cells["idhistory"].Value.ToString());
            int idUser = int.Parse(dataGridView1.CurrentRow.Cells["user_iduser"].Value.ToString());
            int idOrder = int.Parse(dataGridView1.CurrentRow.Cells["order_idorder"].Value.ToString());
        }

        private void FormHistory_Load(object sender, EventArgs e)
        {
            //formUtama= (FormUtama)this.MdiParent;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            listHistory = History.BacaData("", "");
        }
    }
}

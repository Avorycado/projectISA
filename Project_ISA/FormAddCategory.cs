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
    public partial class FormAddCategory : Form
    {
        public FormAddCategory()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxCategory.Text != "" && textBoxCategory.Text != null)
                {
                    int id = Category.GenerateIdCategory();
                    Category.TambahData(id, textBoxCategory.Text);
                    MessageBox.Show("Category berhasil ditambahkan.", "Information");
                    textBoxCategory.Text = "";
                }
                else
                {
                    MessageBox.Show("Category tidak boleh kosong!.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error menambahkan Category. Error Message : " + ex.Message,
                    "Failure");
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxCategory.Text = "";
            textBoxCategory.Focus();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

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
    public partial class FormProfile : Form
    {
        public FormProfile()
        {
            InitializeComponent();
        }

        public User user;

        public void FormProfile_Load(object sender, EventArgs e)
        {
            FormUtama fu = (FormUtama)this.Owner;

            labelNama.Text = "Nama: " + user.Nama;
            labelEmail.Text = "Email: " + fu.tmpUser.Email;
            labelNoTelp.Text = "No. Telepon: " + fu.tmpUser.NoHp;
            labelAlamat.Text = "Alamat: " + fu.tmpUser.Alamat;
        }
    }
}

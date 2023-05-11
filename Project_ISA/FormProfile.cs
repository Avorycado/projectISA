using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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


        public void FormProfile_Load(object sender, EventArgs e)
        {
            FormUtama fu = (FormUtama)this.Owner;

            labelNama.Text = "Nama: " + fu.tmpUser.Nama;
            labelEmail.Text = "Email: " + fu.tmpUser.Email;
            labelNoTelp.Text = "No. Telepon: " + fu.tmpUser.NoHp;
            labelAlamat.Text = "Alamat: " + fu.tmpUser.Alamat;

            if(fu.tmpUser.Foto != "")
            {
                pictureBox1.BackgroundImage = Image.FromFile(fu.tmpUser.Foto);
                pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            }
            else
            {
                pictureBox1.BackgroundImage = null;
            }
        }

        private void buttonProfile_Click(object sender, EventArgs e)
        {
            FormUtama fu = (FormUtama)this.Owner;

            int size = -1;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                string file = openFileDialog1.FileName;
                try
                {
                    string text = File.ReadAllText(file);
                    size = text.Length;
                    pictureBox1.BackgroundImage = Image.FromFile(file);
                    pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;

                    fu.tmpUser.Foto = file;
                    if (fu.tmpUser.UpdateFoto())
                    {
                        MessageBox.Show("Foto Profile berhasil di update.");
                    }
                }
                catch (IOException)
                {
                }
            }
        }
    }
}

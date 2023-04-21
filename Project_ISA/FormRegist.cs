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
    public partial class FormRegist : Form
    {
        public FormRegist()
        {
            InitializeComponent();
        }
        private void labelClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonSignUp_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (checkBoxAgree.Checked == true)
                {
                    if (radioButtonPembeli.Checked == true)
                    {
                        User user = new User(int.Parse(textBoxId.Text), textBoxUsername.Text, textBoxPassword.Text, textBoxEmail.Text, int.Parse(textBoxNoTelp.Text), textBoxAlamat.Text);
                        //user.IdUser = int.Parse(textBoxId.Text);
                        //user.Nama = textBoxUsername.Text;
                        //user.Password = textBoxPassword.Text;
                        //user.Email = textBoxEmail.Text;
                        //user.NoHp = int.Parse(textBoxNoTelp.Text);
                        //user.Alamat = textBoxAlamat.Text;

                        if (user.TambahData())
                        {
                            DialogResult hasil = MessageBox.Show("Data berhasil disimpan", "Konfirmasi", MessageBoxButtons.OK);
                            if (hasil == DialogResult.OK)
                            {
                                this.Close();
                            }
                        }
                        else
                        {
                            throw new Exception("Tidak dapat menambahkan data");
                        }
                    }
                    else
                    {
                        Sellers seller = new Sellers(int.Parse(textBoxId.Text), textBoxUsername.Text, textBoxEmail.Text, int.Parse(textBoxNoTelp.Text),
                            textBoxAlamat.Text, textBoxPassword.Text);

                        if (seller.TambahData())
                        {
                            DialogResult hasil = MessageBox.Show("Data berhasil disimpan", "Konfirmasi", MessageBoxButtons.OK);
                            if (hasil == DialogResult.OK)
                            {
                                this.Close();
                            }
                        }
                        else
                        {
                            throw new Exception("Tidak dapat menambahkan data");
                        }

                    }
                }
                else
                {
                    MessageBox.Show("Setujui Term and Conditions");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormRegist_Load(object sender, EventArgs e)
        {
            if (radioButtonPembeli.Checked == true)
            {
                try
                {
                    int idBaru = User.GenerateIdUser();
                    textBoxId.Text = idBaru.ToString();

                    textBoxId.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                try
                {
                    int idBaru = Sellers.GenerateIdSeller();
                    textBoxId.Text = idBaru.ToString();

                    textBoxId.Enabled = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void radioButtonPembeli_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                int idBaru = User.GenerateIdUser();
                textBoxId.Text = idBaru.ToString();

                textBoxId.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void radioButtonPenjual_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                int idBaru = Sellers.GenerateIdSeller();
                textBoxId.Text = idBaru.ToString();

                textBoxId.Enabled = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

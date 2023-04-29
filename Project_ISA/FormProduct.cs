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
    public partial class FormProduct : Form
    {
        public FormProduct()
        {
            InitializeComponent();
        }

        PictureBox pbox;
        Product p;
        public List<Product> listProduct = new List<Product>();

        private void FormProduct_Load(object sender, EventArgs e)
        {
            listProduct = Product.AmbilFoto();
            MessageBox.Show(listProduct.Count().ToString());

            //List<string> poto = Product.AmbilFoto();

            List<Product> product = Product.AmbilFoto();

            //pbox.Image = Image.FromFile(@"C:\Users\satya\Pictures\hitam.jpeg");

            //MessageBox.Show(tableLayoutPanel1.ColumnCount.ToString());
            //MessageBox.Show(tableLayoutPanel1.RowCount.ToString());

            //tableLayoutPanel1.Controls.Add(pbox, 1, 1);


            int cols = 3; //Will come from database
            int rows = 3;
            //int rows = (int)Math.Round((double)poto.Count / cols); //Will come from database
            int colWidth;
            int rowHeight;

            colWidth = 100 / cols;
            if (100 % cols != 0)
                colWidth--;

            rowHeight = 100 / rows;
            if (100 % rows != 0)
                rowHeight--;


            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.ColumnStyles.Clear();
            tableLayoutPanel1.RowStyles.Clear();

            tableLayoutPanel1.ColumnCount = cols;

            int pmbt = 0;

            for (int i = 0; i < rows; i++)
            {
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, rowHeight));
                for (int j = 0; j < cols; j++)
                {
                    tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, colWidth));

                    if (pmbt < product.Count)
                    {
                        MessageBox.Show(product[pmbt].Status.ToString());
                        if (product[pmbt].Status == "Verified")
                        {
                            Panel pnl = new Panel();
                            pnl.Size = new Size(172, 225);
                            pnl.Anchor = AnchorStyles.Top;
                            pnl.BackColor = Color.Red;

                            pbox = new PictureBox();
                            pbox.Image = Image.FromFile(@"" + product[pmbt].Foto);
                            pbox.Size = new Size(90, 90);
                            pbox.Location = new Point(41, 17);
                            pbox.SizeMode = PictureBoxSizeMode.StretchImage;
                            //pbox.Anchor = AnchorStyles.Top;
                            pnl.Controls.Add(pbox);

                            Label lbel = new Label();
                            lbel.Text = product[pmbt].Nama;
                            lbel.Location = new Point(41, pbox.Height + 20);
                            lbel.Font = new Font(new FontFamily("Poppins"), lbel.Font.Size * 1.1f);
                            pnl.Controls.Add(lbel);

                            tableLayoutPanel1.Controls.Add(pnl, j, i);
                        }
                        //pbox = new PictureBox();
                        //pbox.Image = Image.FromFile(@"" + product[pmbt].Foto);
                        //pbox.Size = new Size(172, 125);
                        ////pbox.Dock = DockStyle.Fill;
                        //pbox.Anchor = AnchorStyles.Top;
                        //pbox.SizeMode = PictureBoxSizeMode.StretchImage;
                        //tableLayoutPanel1.Controls.Add(pbox, j, i);

                        //Label productName = new Label();
                        //productName.Text = product[pmbt].Nama;
                        //productName.Anchor = AnchorStyles.Bottom;
                        //tableLayoutPanel1.Controls.Add(productName, j, i);
                    }
                    pmbt++;

                }

            }
        }
    }
}

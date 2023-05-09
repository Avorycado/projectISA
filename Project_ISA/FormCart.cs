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
    public partial class FormCart : Form
    {
        public FormCart()
        {
            InitializeComponent();
        }

        PictureBox pbox;
        public List<Cart> listProduct = new List<Cart>();
        public int pmbt = 0;
        List<Panel> listPanel = new List<Panel>();

        public List<Product> product = Product.AmbilDataVerif();

        private void FormCart_Load(object sender, EventArgs e)
        {
            listProduct = Cart.BacaData("", "");

            int cols = 3; //Will come from database
            //int rows = 3;
            int rows = (int)Math.Ceiling((double)listProduct.Count / cols); //Will come from database
            int colWidth;
            int rowHeight;

            colWidth = 100 / cols;
            if (100 % cols != 0)
                colWidth--;

            rowHeight = 100 / rows;
            if (100 % rows != 0)
                rowHeight--;

            //MessageBox.Show(rows.ToString());
            int height = rows * 180;

            TableLayoutPanel tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.Parent = flowLayoutPanel1;
            tableLayoutPanel1.Size = new Size(670, height);

            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.ColumnStyles.Clear();
            tableLayoutPanel1.RowStyles.Clear();

            tableLayoutPanel1.ColumnCount = cols;


            for (int i = 0; i < rows; i++)
            {
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, rowHeight));
                for (int j = 0; j < cols; j++)
                {
                    tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, colWidth));

                    if (pmbt < listProduct.Count)
                    {
                        Panel pnl = new Panel();
                        pnl.Size = new Size(212, 171);
                        pnl.Anchor = AnchorStyles.Top;

                        pbox = new PictureBox();
                        pbox.Image = Image.FromFile(@"" + listProduct[pmbt].Product.Foto);
                        pbox.Size = new Size(202, 128);
                        pbox.Location = new Point(5, 23);
                        pbox.SizeMode = PictureBoxSizeMode.StretchImage;
                        //pbox.Anchor = AnchorStyles.Top;
                        pnl.Controls.Add(pbox);

                        Label nama = new Label();
                        nama.Text = listProduct[pmbt].Product.Nama;
                        nama.Location = new Point(5, 5);
                        //lbel.Font = new Font(new FontFamily("Poppins"), lbel.Font.Size * 1.1f);
                        pnl.Controls.Add(nama);

                        Label harga = new Label();
                        harga.Text = listProduct[pmbt].Product.Harga.ToString();
                        harga.Location = new Point(175, 5);
                        harga.BringToFront();
                        //lbel.Font = new Font(new FontFamily("Poppins"), lbel.Font.Size * 1.1f);
                        pnl.Controls.Add(harga);

                        Label co = new Label();
                        co.Text = "Check Out";
                        co.Location = new Point(150, 155);
                        co.Name = listPanel.Count.ToString();
                        co.Click += new EventHandler(Co_Click);
                        //lbel.Font = new Font(new FontFamily("Poppins"), lbel.Font.Size * 1.1f);
                        pnl.Controls.Add(co);

                        tableLayoutPanel1.Controls.Add(pnl, j, i);
                        listPanel.Add(pnl);
                    }
                    pmbt++;
                }
            }
        }

        private void Co_Click(object sender, EventArgs e)
        {
            Label a = sender as Label;
            //MessageBox.Show(listProduct[int.Parse(a.Name)].Nama.ToString());

            FormUtama formUtama = (FormUtama)this.Owner;

            FormOrder frm = new FormOrder(product[int.Parse(a.Name)]);
            frm.Owner = formUtama;
            frm.ShowDialog();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

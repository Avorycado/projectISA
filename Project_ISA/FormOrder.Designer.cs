namespace Project_ISA
{
    partial class FormOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxAlamat = new System.Windows.Forms.TextBox();
            this.dataGridViewOrder = new System.Windows.Forms.DataGridView();
            this.buttonCheckOut = new System.Windows.Forms.Button();
            this.comboBoxMetodePembayaran = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxInfoPengiriman = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelInfoToko = new System.Windows.Forms.Label();
            this.labelAlamat = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.HotPink;
            this.panel1.Controls.Add(this.textBoxAlamat);
            this.panel1.Controls.Add(this.dataGridViewOrder);
            this.panel1.Controls.Add(this.buttonCheckOut);
            this.panel1.Controls.Add(this.comboBoxMetodePembayaran);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboBoxInfoPengiriman);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.labelInfoToko);
            this.panel1.Controls.Add(this.labelAlamat);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(-8, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 498);
            this.panel1.TabIndex = 6;
            // 
            // textBoxAlamat
            // 
            this.textBoxAlamat.Location = new System.Drawing.Point(151, 62);
            this.textBoxAlamat.Multiline = true;
            this.textBoxAlamat.Name = "textBoxAlamat";
            this.textBoxAlamat.Size = new System.Drawing.Size(156, 58);
            this.textBoxAlamat.TabIndex = 61;
            // 
            // dataGridViewOrder
            // 
            this.dataGridViewOrder.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrder.Location = new System.Drawing.Point(15, 264);
            this.dataGridViewOrder.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewOrder.Name = "dataGridViewOrder";
            this.dataGridViewOrder.RowHeadersWidth = 51;
            this.dataGridViewOrder.RowTemplate.Height = 24;
            this.dataGridViewOrder.Size = new System.Drawing.Size(290, 184);
            this.dataGridViewOrder.TabIndex = 60;
            // 
            // buttonCheckOut
            // 
            this.buttonCheckOut.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheckOut.Location = new System.Drawing.Point(225, 451);
            this.buttonCheckOut.Margin = new System.Windows.Forms.Padding(2);
            this.buttonCheckOut.Name = "buttonCheckOut";
            this.buttonCheckOut.Size = new System.Drawing.Size(80, 26);
            this.buttonCheckOut.TabIndex = 59;
            this.buttonCheckOut.Text = "CheckOut";
            this.buttonCheckOut.UseVisualStyleBackColor = true;
            this.buttonCheckOut.Click += new System.EventHandler(this.buttonCheckOut_Click);
            // 
            // comboBoxMetodePembayaran
            // 
            this.comboBoxMetodePembayaran.FormattingEnabled = true;
            this.comboBoxMetodePembayaran.Location = new System.Drawing.Point(151, 224);
            this.comboBoxMetodePembayaran.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxMetodePembayaran.Name = "comboBoxMetodePembayaran";
            this.comboBoxMetodePembayaran.Size = new System.Drawing.Size(156, 21);
            this.comboBoxMetodePembayaran.TabIndex = 57;
            this.comboBoxMetodePembayaran.SelectedIndexChanged += new System.EventHandler(this.comboBoxMetodePembayaran_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 225);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(147, 19);
            this.label3.TabIndex = 56;
            this.label3.Text = "Metode Pembayaran : ";
            // 
            // comboBoxInfoPengiriman
            // 
            this.comboBoxInfoPengiriman.FormattingEnabled = true;
            this.comboBoxInfoPengiriman.Items.AddRange(new object[] {
            "JNE - Rp. 8000",
            "JNT - Rp. 10.000",
            "SiCepat - Rp. 12.000"});
            this.comboBoxInfoPengiriman.Location = new System.Drawing.Point(120, 178);
            this.comboBoxInfoPengiriman.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxInfoPengiriman.Name = "comboBoxInfoPengiriman";
            this.comboBoxInfoPengiriman.Size = new System.Drawing.Size(156, 21);
            this.comboBoxInfoPengiriman.TabIndex = 55;
            this.comboBoxInfoPengiriman.SelectedIndexChanged += new System.EventHandler(this.comboBoxInfoPengiriman_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 178);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 19);
            this.label2.TabIndex = 54;
            this.label2.Text = "Info Pengiriman : ";
            // 
            // labelInfoToko
            // 
            this.labelInfoToko.AutoSize = true;
            this.labelInfoToko.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfoToko.Location = new System.Drawing.Point(14, 129);
            this.labelInfoToko.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelInfoToko.Name = "labelInfoToko";
            this.labelInfoToko.Size = new System.Drawing.Size(73, 19);
            this.labelInfoToko.TabIndex = 53;
            this.labelInfoToko.Text = "Info Toko ";
            this.labelInfoToko.Click += new System.EventHandler(this.labelInfoToko_Click);
            // 
            // labelAlamat
            // 
            this.labelAlamat.AutoSize = true;
            this.labelAlamat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlamat.Location = new System.Drawing.Point(11, 63);
            this.labelAlamat.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAlamat.Name = "labelAlamat";
            this.labelAlamat.Size = new System.Drawing.Size(137, 19);
            this.labelAlamat.TabIndex = 51;
            this.labelAlamat.Text = "Alamat Pengiriman :  ";
            this.labelAlamat.Click += new System.EventHandler(this.labelAlamat_Click);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.DeepPink;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label6.Location = new System.Drawing.Point(8, -6);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(304, 50);
            this.label6.TabIndex = 50;
            this.label6.Text = "Order";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 493);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FormOrder";
            this.Text = "FormOrder";
            this.Load += new System.EventHandler(this.FormOrder_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelAlamat;
        private System.Windows.Forms.ComboBox comboBoxMetodePembayaran;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxInfoPengiriman;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelInfoToko;
        private System.Windows.Forms.Button buttonCheckOut;
        private System.Windows.Forms.DataGridView dataGridViewOrder;
        private System.Windows.Forms.TextBox textBoxAlamat;
    }
}
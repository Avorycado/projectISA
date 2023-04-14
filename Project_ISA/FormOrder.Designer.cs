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
            this.buttonCheckOut = new System.Windows.Forms.Button();
            this.comboBoxMetodePembayaran = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxInfoPengiriman = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelInfoToko = new System.Windows.Forms.Label();
            this.labelAlamat = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridViewOrder = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.HotPink;
            this.panel1.Controls.Add(this.dataGridViewOrder);
            this.panel1.Controls.Add(this.buttonCheckOut);
            this.panel1.Controls.Add(this.comboBoxMetodePembayaran);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboBoxInfoPengiriman);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.labelInfoToko);
            this.panel1.Controls.Add(this.labelAlamat);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Location = new System.Drawing.Point(-11, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(429, 565);
            this.panel1.TabIndex = 6;
            // 
            // buttonCheckOut
            // 
            this.buttonCheckOut.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheckOut.Location = new System.Drawing.Point(300, 521);
            this.buttonCheckOut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonCheckOut.Name = "buttonCheckOut";
            this.buttonCheckOut.Size = new System.Drawing.Size(107, 32);
            this.buttonCheckOut.TabIndex = 59;
            this.buttonCheckOut.Text = "CheckOut";
            this.buttonCheckOut.UseVisualStyleBackColor = true;
            this.buttonCheckOut.Click += new System.EventHandler(this.buttonCheckOut_Click);
            // 
            // comboBoxMetodePembayaran
            // 
            this.comboBoxMetodePembayaran.FormattingEnabled = true;
            this.comboBoxMetodePembayaran.Items.AddRange(new object[] {
            "SisBroPay",
            "COD",
            "Transfer Bank"});
            this.comboBoxMetodePembayaran.Location = new System.Drawing.Point(201, 241);
            this.comboBoxMetodePembayaran.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxMetodePembayaran.Name = "comboBoxMetodePembayaran";
            this.comboBoxMetodePembayaran.Size = new System.Drawing.Size(207, 24);
            this.comboBoxMetodePembayaran.TabIndex = 57;
            this.comboBoxMetodePembayaran.SelectedIndexChanged += new System.EventHandler(this.comboBoxMetodePembayaran_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 22);
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
            this.comboBoxInfoPengiriman.Location = new System.Drawing.Point(160, 185);
            this.comboBoxInfoPengiriman.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBoxInfoPengiriman.Name = "comboBoxInfoPengiriman";
            this.comboBoxInfoPengiriman.Size = new System.Drawing.Size(207, 24);
            this.comboBoxInfoPengiriman.TabIndex = 55;
            this.comboBoxInfoPengiriman.SelectedIndexChanged += new System.EventHandler(this.comboBoxInfoPengiriman_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 22);
            this.label2.TabIndex = 54;
            this.label2.Text = "Info Pengiriman : ";
            // 
            // labelInfoToko
            // 
            this.labelInfoToko.AutoSize = true;
            this.labelInfoToko.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfoToko.Location = new System.Drawing.Point(13, 124);
            this.labelInfoToko.Name = "labelInfoToko";
            this.labelInfoToko.Size = new System.Drawing.Size(91, 22);
            this.labelInfoToko.TabIndex = 53;
            this.labelInfoToko.Text = "Info Toko ";
            // 
            // labelAlamat
            // 
            this.labelAlamat.AutoSize = true;
            this.labelAlamat.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlamat.Location = new System.Drawing.Point(15, 78);
            this.labelAlamat.Name = "labelAlamat";
            this.labelAlamat.Size = new System.Drawing.Size(182, 22);
            this.labelAlamat.TabIndex = 51;
            this.labelAlamat.Text = "Alamat Pengiriman :  ";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.DeepPink;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LavenderBlush;
            this.label6.Location = new System.Drawing.Point(11, -7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(405, 62);
            this.label6.TabIndex = 50;
            this.label6.Text = "Order";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dataGridViewOrder
            // 
            this.dataGridViewOrder.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrder.Location = new System.Drawing.Point(20, 290);
            this.dataGridViewOrder.Name = "dataGridViewOrder";
            this.dataGridViewOrder.RowHeadersWidth = 51;
            this.dataGridViewOrder.RowTemplate.Height = 24;
            this.dataGridViewOrder.Size = new System.Drawing.Size(387, 226);
            this.dataGridViewOrder.TabIndex = 60;
            // 
            // FormOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 565);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
    }
}
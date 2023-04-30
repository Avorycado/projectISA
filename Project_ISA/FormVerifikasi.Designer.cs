
namespace Project_ISA
{
    partial class FormVerifikasi
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
            this.dataGridViewVerifikasi = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVerifikasi)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewVerifikasi
            // 
            this.dataGridViewVerifikasi.BackgroundColor = System.Drawing.Color.Pink;
            this.dataGridViewVerifikasi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVerifikasi.Location = new System.Drawing.Point(12, 36);
            this.dataGridViewVerifikasi.Name = "dataGridViewVerifikasi";
            this.dataGridViewVerifikasi.RowHeadersWidth = 51;
            this.dataGridViewVerifikasi.RowTemplate.Height = 24;
            this.dataGridViewVerifikasi.Size = new System.Drawing.Size(961, 341);
            this.dataGridViewVerifikasi.TabIndex = 1;
            this.dataGridViewVerifikasi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewVerifikasi_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "ACC PRODUCT";
            // 
            // FormVerifikasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepPink;
            this.ClientSize = new System.Drawing.Size(985, 399);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewVerifikasi);
            this.Name = "FormVerifikasi";
            this.Text = "FormVerifikasi";
            this.Load += new System.EventHandler(this.FormVerifikasi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVerifikasi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewVerifikasi;
        private System.Windows.Forms.Label label1;
    }
}
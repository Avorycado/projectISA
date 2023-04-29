
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVerifikasi)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewVerifikasi
            // 
            this.dataGridViewVerifikasi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVerifikasi.Location = new System.Drawing.Point(0, -1);
            this.dataGridViewVerifikasi.Name = "dataGridViewVerifikasi";
            this.dataGridViewVerifikasi.RowHeadersWidth = 51;
            this.dataGridViewVerifikasi.RowTemplate.Height = 24;
            this.dataGridViewVerifikasi.Size = new System.Drawing.Size(799, 341);
            this.dataGridViewVerifikasi.TabIndex = 1;
            this.dataGridViewVerifikasi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewVerifikasi_CellContentClick);
            // 
            // FormVerifikasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 340);
            this.Controls.Add(this.dataGridViewVerifikasi);
            this.Name = "FormVerifikasi";
            this.Text = "FormVerifikasi";
            this.Load += new System.EventHandler(this.FormVerifikasi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVerifikasi)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewVerifikasi;
    }
}
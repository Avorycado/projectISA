
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
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVerifikasi)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewVerifikasi
            // 
            this.dataGridViewVerifikasi.BackgroundColor = System.Drawing.Color.Pink;
            this.dataGridViewVerifikasi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVerifikasi.Location = new System.Drawing.Point(9, 29);
            this.dataGridViewVerifikasi.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewVerifikasi.Name = "dataGridViewVerifikasi";
            this.dataGridViewVerifikasi.RowHeadersWidth = 51;
            this.dataGridViewVerifikasi.RowTemplate.Height = 24;
            this.dataGridViewVerifikasi.Size = new System.Drawing.Size(721, 277);
            this.dataGridViewVerifikasi.TabIndex = 1;
            this.dataGridViewVerifikasi.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewVerifikasi_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(10, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "ACC PRODUCT";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(652, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // FormVerifikasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepPink;
            this.ClientSize = new System.Drawing.Size(739, 324);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridViewVerifikasi);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Button button1;
    }
}
namespace WFARakam_harfe_Cevirme
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtsayi = new System.Windows.Forms.TextBox();
            this.lblsonuc = new System.Windows.Forms.Label();
            this.btnCevir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtsayi
            // 
            this.txtsayi.Location = new System.Drawing.Point(27, 27);
            this.txtsayi.Name = "txtsayi";
            this.txtsayi.Size = new System.Drawing.Size(100, 20);
            this.txtsayi.TabIndex = 0;
            // 
            // lblsonuc
            // 
            this.lblsonuc.AutoSize = true;
            this.lblsonuc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblsonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsonuc.ForeColor = System.Drawing.Color.DarkRed;
            this.lblsonuc.Location = new System.Drawing.Point(27, 56);
            this.lblsonuc.Name = "lblsonuc";
            this.lblsonuc.Size = new System.Drawing.Size(2, 20);
            this.lblsonuc.TabIndex = 1;
            // 
            // btnCevir
            // 
            this.btnCevir.Location = new System.Drawing.Point(133, 25);
            this.btnCevir.Name = "btnCevir";
            this.btnCevir.Size = new System.Drawing.Size(90, 23);
            this.btnCevir.TabIndex = 2;
            this.btnCevir.Text = "Cevir";
            this.btnCevir.UseVisualStyleBackColor = true;
            this.btnCevir.Click += new System.EventHandler(this.btnCevir_Click);
            // 
            // Form1
            // 
            this.AcceptButton = this.btnCevir;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 85);
            this.Controls.Add(this.btnCevir);
            this.Controls.Add(this.lblsonuc);
            this.Controls.Add(this.txtsayi);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtsayi;
        private System.Windows.Forms.Label lblsonuc;
        private System.Windows.Forms.Button btnCevir;
    }
}


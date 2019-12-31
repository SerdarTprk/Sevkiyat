namespace Sevkiyat.UI.Forms
{
    partial class FormDriverList
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
            this.lstSoforListele = new System.Windows.Forms.ListBox();
            this.lblSoforListele = new System.Windows.Forms.Label();
            this.btnSoforGuncelle = new System.Windows.Forms.Button();
            this.btnSoforSil = new System.Windows.Forms.Button();
            this.btnSoforEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstSoforListele
            // 
            this.lstSoforListele.FormattingEnabled = true;
            this.lstSoforListele.Location = new System.Drawing.Point(12, 43);
            this.lstSoforListele.Name = "lstSoforListele";
            this.lstSoforListele.Size = new System.Drawing.Size(242, 303);
            this.lstSoforListele.TabIndex = 0;
            // 
            // lblSoforListele
            // 
            this.lblSoforListele.AutoSize = true;
            this.lblSoforListele.Location = new System.Drawing.Point(9, 10);
            this.lblSoforListele.Name = "lblSoforListele";
            this.lblSoforListele.Size = new System.Drawing.Size(65, 13);
            this.lblSoforListele.TabIndex = 1;
            this.lblSoforListele.Text = "Şoför Listele";
            // 
            // btnSoforGuncelle
            // 
            this.btnSoforGuncelle.Location = new System.Drawing.Point(12, 371);
            this.btnSoforGuncelle.Name = "btnSoforGuncelle";
            this.btnSoforGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnSoforGuncelle.TabIndex = 2;
            this.btnSoforGuncelle.Text = "Güncelle";
            this.btnSoforGuncelle.UseVisualStyleBackColor = true;
            this.btnSoforGuncelle.Click += new System.EventHandler(this.BtnSoforGuncelle_Click);
            // 
            // btnSoforSil
            // 
            this.btnSoforSil.Location = new System.Drawing.Point(179, 371);
            this.btnSoforSil.Name = "btnSoforSil";
            this.btnSoforSil.Size = new System.Drawing.Size(75, 23);
            this.btnSoforSil.TabIndex = 3;
            this.btnSoforSil.Text = "Sil";
            this.btnSoforSil.UseVisualStyleBackColor = true;
            this.btnSoforSil.Click += new System.EventHandler(this.BtnSoforSil_Click);
            // 
            // btnSoforEkle
            // 
            this.btnSoforEkle.Location = new System.Drawing.Point(179, 10);
            this.btnSoforEkle.Name = "btnSoforEkle";
            this.btnSoforEkle.Size = new System.Drawing.Size(75, 23);
            this.btnSoforEkle.TabIndex = 4;
            this.btnSoforEkle.Text = "Ekle";
            this.btnSoforEkle.UseVisualStyleBackColor = true;
            this.btnSoforEkle.Click += new System.EventHandler(this.BtnSoforEkle_Click);
            // 
            // FormDriverList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 408);
            this.Controls.Add(this.btnSoforEkle);
            this.Controls.Add(this.btnSoforSil);
            this.Controls.Add(this.btnSoforGuncelle);
            this.Controls.Add(this.lblSoforListele);
            this.Controls.Add(this.lstSoforListele);
            this.Name = "FormDriverList";
            this.Text = "Şoför Listele";
            this.Load += new System.EventHandler(this.FormDriverList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstSoforListele;
        private System.Windows.Forms.Label lblSoforListele;
        private System.Windows.Forms.Button btnSoforGuncelle;
        private System.Windows.Forms.Button btnSoforSil;
        private System.Windows.Forms.Button btnSoforEkle;
    }
}
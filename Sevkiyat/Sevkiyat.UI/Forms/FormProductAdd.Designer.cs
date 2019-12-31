namespace Sevkiyat.UI
{
    partial class FormProductAdd
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
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtAgırlık = new System.Windows.Forms.TextBox();
            this.lbl_pro_name = new System.Windows.Forms.Label();
            this.lbl_pro_type = new System.Windows.Forms.Label();
            this.lbl_weigh = new System.Windows.Forms.Label();
            this.btn_add = new System.Windows.Forms.Button();
            this.cmbProductType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbbBirimCinsi = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(133, 15);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(100, 20);
            this.txtProductName.TabIndex = 1;
            // 
            // txtAgırlık
            // 
            this.txtAgırlık.Location = new System.Drawing.Point(133, 86);
            this.txtAgırlık.Name = "txtAgırlık";
            this.txtAgırlık.Size = new System.Drawing.Size(100, 20);
            this.txtAgırlık.TabIndex = 3;
            // 
            // lbl_pro_name
            // 
            this.lbl_pro_name.AutoSize = true;
            this.lbl_pro_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_pro_name.Location = new System.Drawing.Point(9, 18);
            this.lbl_pro_name.Name = "lbl_pro_name";
            this.lbl_pro_name.Size = new System.Drawing.Size(102, 17);
            this.lbl_pro_name.TabIndex = 6;
            this.lbl_pro_name.Text = "ProductName :";
            // 
            // lbl_pro_type
            // 
            this.lbl_pro_type.AutoSize = true;
            this.lbl_pro_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_pro_type.Location = new System.Drawing.Point(9, 54);
            this.lbl_pro_type.Name = "lbl_pro_type";
            this.lbl_pro_type.Size = new System.Drawing.Size(97, 17);
            this.lbl_pro_type.TabIndex = 7;
            this.lbl_pro_type.Text = "ProductType :";
            // 
            // lbl_weigh
            // 
            this.lbl_weigh.AutoSize = true;
            this.lbl_weigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_weigh.Location = new System.Drawing.Point(9, 87);
            this.lbl_weigh.Name = "lbl_weigh";
            this.lbl_weigh.Size = new System.Drawing.Size(56, 17);
            this.lbl_weigh.TabIndex = 8;
            this.lbl_weigh.Text = "Weigh :";
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_add.Location = new System.Drawing.Point(157, 164);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 10;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.Btn_add_Click);
            // 
            // cmbProductType
            // 
            this.cmbProductType.FormattingEnabled = true;
            this.cmbProductType.Location = new System.Drawing.Point(133, 52);
            this.cmbProductType.Margin = new System.Windows.Forms.Padding(2);
            this.cmbProductType.Name = "cmbProductType";
            this.cmbProductType.Size = new System.Drawing.Size(100, 21);
            this.cmbProductType.TabIndex = 11;
            this.cmbProductType.SelectedIndexChanged += new System.EventHandler(this.cmbProductType_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(9, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 7;
            this.label1.Text = "BirimCinsi";
            // 
            // cbbBirimCinsi
            // 
            this.cbbBirimCinsi.FormattingEnabled = true;
            this.cbbBirimCinsi.Location = new System.Drawing.Point(133, 119);
            this.cbbBirimCinsi.Margin = new System.Windows.Forms.Padding(2);
            this.cbbBirimCinsi.Name = "cbbBirimCinsi";
            this.cbbBirimCinsi.Size = new System.Drawing.Size(100, 21);
            this.cbbBirimCinsi.TabIndex = 11;
            // 
            // FormProductAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 198);
            this.Controls.Add(this.cbbBirimCinsi);
            this.Controls.Add(this.cmbProductType);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.lbl_weigh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_pro_type);
            this.Controls.Add(this.lbl_pro_name);
            this.Controls.Add(this.txtAgırlık);
            this.Controls.Add(this.txtProductName);
            this.Name = "FormProductAdd";
            this.Text = "Product Add";
            this.Load += new System.EventHandler(this.FormProductAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtAgırlık;
        private System.Windows.Forms.Label lbl_pro_name;
        private System.Windows.Forms.Label lbl_pro_type;
        private System.Windows.Forms.Label lbl_weigh;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.ComboBox cmbProductType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbbBirimCinsi;
    }
}


namespace Sevkiyat.UI.Forms
{
    partial class FormProductUpdate
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
            this.cbbBirimCinsi = new System.Windows.Forms.ComboBox();
            this.cmbProductType = new System.Windows.Forms.ComboBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lbl_weigh = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_pro_type = new System.Windows.Forms.Label();
            this.lbl_pro_name = new System.Windows.Forms.Label();
            this.txtAgırlık = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cbbBirimCinsi
            // 
            this.cbbBirimCinsi.FormattingEnabled = true;
            this.cbbBirimCinsi.Location = new System.Drawing.Point(136, 120);
            this.cbbBirimCinsi.Margin = new System.Windows.Forms.Padding(2);
            this.cbbBirimCinsi.Name = "cbbBirimCinsi";
            this.cbbBirimCinsi.Size = new System.Drawing.Size(100, 21);
            this.cbbBirimCinsi.TabIndex = 19;
            // 
            // cmbProductType
            // 
            this.cmbProductType.FormattingEnabled = true;
            this.cmbProductType.Location = new System.Drawing.Point(136, 53);
            this.cmbProductType.Margin = new System.Windows.Forms.Padding(2);
            this.cmbProductType.Name = "cmbProductType";
            this.cmbProductType.Size = new System.Drawing.Size(100, 21);
            this.cmbProductType.TabIndex = 20;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.Location = new System.Drawing.Point(160, 165);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 31);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // lbl_weigh
            // 
            this.lbl_weigh.AutoSize = true;
            this.lbl_weigh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_weigh.Location = new System.Drawing.Point(12, 88);
            this.lbl_weigh.Name = "lbl_weigh";
            this.lbl_weigh.Size = new System.Drawing.Size(56, 17);
            this.lbl_weigh.TabIndex = 17;
            this.lbl_weigh.Text = "Weigh :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 122);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "BirimCinsi";
            // 
            // lbl_pro_type
            // 
            this.lbl_pro_type.AutoSize = true;
            this.lbl_pro_type.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_pro_type.Location = new System.Drawing.Point(12, 55);
            this.lbl_pro_type.Name = "lbl_pro_type";
            this.lbl_pro_type.Size = new System.Drawing.Size(97, 17);
            this.lbl_pro_type.TabIndex = 16;
            this.lbl_pro_type.Text = "ProductType :";
            // 
            // lbl_pro_name
            // 
            this.lbl_pro_name.AutoSize = true;
            this.lbl_pro_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_pro_name.Location = new System.Drawing.Point(12, 19);
            this.lbl_pro_name.Name = "lbl_pro_name";
            this.lbl_pro_name.Size = new System.Drawing.Size(102, 17);
            this.lbl_pro_name.TabIndex = 14;
            this.lbl_pro_name.Text = "ProductName :";
            // 
            // txtAgırlık
            // 
            this.txtAgırlık.Location = new System.Drawing.Point(136, 87);
            this.txtAgırlık.Name = "txtAgırlık";
            this.txtAgırlık.Size = new System.Drawing.Size(100, 20);
            this.txtAgırlık.TabIndex = 13;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(136, 16);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(100, 20);
            this.txtProductName.TabIndex = 12;
            // 
            // FormProductUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(251, 208);
            this.Controls.Add(this.cbbBirimCinsi);
            this.Controls.Add(this.cmbProductType);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lbl_weigh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_pro_type);
            this.Controls.Add(this.lbl_pro_name);
            this.Controls.Add(this.txtAgırlık);
            this.Controls.Add(this.txtProductName);
            this.Name = "FormProductUpdate";
            this.Text = "FormProductUpdate";
            this.Load += new System.EventHandler(this.FormProductUpdate_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbbBirimCinsi;
        private System.Windows.Forms.ComboBox cmbProductType;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lbl_weigh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_pro_type;
        private System.Windows.Forms.Label lbl_pro_name;
        private System.Windows.Forms.TextBox txtAgırlık;
        private System.Windows.Forms.TextBox txtProductName;
    }
}
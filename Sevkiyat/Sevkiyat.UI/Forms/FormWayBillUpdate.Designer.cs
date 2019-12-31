namespace Sevkiyat.UI
{
    partial class FormWayBillUpdate
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmb_sender = new System.Windows.Forms.ComboBox();
            this.lbl_sender = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.cmb_billType = new System.Windows.Forms.ComboBox();
            this.dtp_deliveryDate = new System.Windows.Forms.DateTimePicker();
            this.dtp_shipmentDate = new System.Windows.Forms.DateTimePicker();
            this.cmb_receiver = new System.Windows.Forms.ComboBox();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.cmb_vechile = new System.Windows.Forms.ComboBox();
            this.cmb_driver = new System.Windows.Forms.ComboBox();
            this.lbl_billType = new System.Windows.Forms.Label();
            this.lbl_deliveryDate = new System.Windows.Forms.Label();
            this.lbl_shipmentDate = new System.Windows.Forms.Label();
            this.lbl_receiver = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_vechile = new System.Windows.Forms.Label();
            this.lbl_driver = new System.Windows.Forms.Label();
            this.lblWaybillID = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cmbIrsaliyeID = new System.Windows.Forms.ComboBox();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.txtContactName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRAdress = new System.Windows.Forms.TextBox();
            this.txtRContactName = new System.Windows.Forms.TextBox();
            this.txtRPhone = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.nudPcount = new System.Windows.Forms.NumericUpDown();
            this.txtDesc = new System.Windows.Forms.TextBox();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPcount)).BeginInit();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader4,
            this.columnHeader3});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(11, 322);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(876, 204);
            this.listView1.TabIndex = 41;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ürün Adı";
            this.columnHeader1.Width = 743;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Miktar Cinsi";
            this.columnHeader4.Width = 283;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Adet";
            this.columnHeader3.Width = 161;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtAdress);
            this.groupBox2.Controls.Add(this.txtContactName);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtPhone);
            this.groupBox2.Location = new System.Drawing.Point(11, 90);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(377, 103);
            this.groupBox2.TabIndex = 40;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRAdress);
            this.groupBox1.Controls.Add(this.txtRContactName);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtRPhone);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(457, 91);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(377, 103);
            this.groupBox1.TabIndex = 39;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // cmb_sender
            // 
            this.cmb_sender.FormattingEnabled = true;
            this.cmb_sender.Location = new System.Drawing.Point(198, 66);
            this.cmb_sender.Name = "cmb_sender";
            this.cmb_sender.Size = new System.Drawing.Size(121, 21);
            this.cmb_sender.TabIndex = 38;
            // 
            // lbl_sender
            // 
            this.lbl_sender.AutoSize = true;
            this.lbl_sender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sender.Location = new System.Drawing.Point(11, 69);
            this.lbl_sender.Name = "lbl_sender";
            this.lbl_sender.Size = new System.Drawing.Size(78, 17);
            this.lbl_sender.TabIndex = 37;
            this.lbl_sender.Text = "Gönderici";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(767, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 25);
            this.button1.TabIndex = 36;
            this.button1.Text = "Kaydet";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_confirm
            // 
            this.btn_confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_confirm.Location = new System.Drawing.Point(793, 638);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(120, 25);
            this.btn_confirm.TabIndex = 35;
            this.btn_confirm.Text = "Confirm";
            this.btn_confirm.UseVisualStyleBackColor = true;
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_clear.Location = new System.Drawing.Point(38, 638);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(120, 25);
            this.btn_clear.TabIndex = 34;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            // 
            // cmb_billType
            // 
            this.cmb_billType.FormattingEnabled = true;
            this.cmb_billType.Items.AddRange(new object[] {
            "Entry",
            "Out"});
            this.cmb_billType.Location = new System.Drawing.Point(198, 42);
            this.cmb_billType.Name = "cmb_billType";
            this.cmb_billType.Size = new System.Drawing.Size(121, 21);
            this.cmb_billType.TabIndex = 33;
            // 
            // dtp_deliveryDate
            // 
            this.dtp_deliveryDate.Location = new System.Drawing.Point(629, 220);
            this.dtp_deliveryDate.Name = "dtp_deliveryDate";
            this.dtp_deliveryDate.Size = new System.Drawing.Size(121, 20);
            this.dtp_deliveryDate.TabIndex = 32;
            // 
            // dtp_shipmentDate
            // 
            this.dtp_shipmentDate.Location = new System.Drawing.Point(198, 220);
            this.dtp_shipmentDate.Name = "dtp_shipmentDate";
            this.dtp_shipmentDate.Size = new System.Drawing.Size(121, 20);
            this.dtp_shipmentDate.TabIndex = 31;
            // 
            // cmb_receiver
            // 
            this.cmb_receiver.FormattingEnabled = true;
            this.cmb_receiver.Location = new System.Drawing.Point(637, 69);
            this.cmb_receiver.Name = "cmb_receiver";
            this.cmb_receiver.Size = new System.Drawing.Size(121, 21);
            this.cmb_receiver.TabIndex = 30;
            // 
            // cmbProduct
            // 
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Location = new System.Drawing.Point(512, 255);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(248, 21);
            this.cmbProduct.TabIndex = 29;
            // 
            // cmb_vechile
            // 
            this.cmb_vechile.FormattingEnabled = true;
            this.cmb_vechile.Location = new System.Drawing.Point(198, 287);
            this.cmb_vechile.Name = "cmb_vechile";
            this.cmb_vechile.Size = new System.Drawing.Size(121, 21);
            this.cmb_vechile.TabIndex = 28;
            // 
            // cmb_driver
            // 
            this.cmb_driver.FormattingEnabled = true;
            this.cmb_driver.Location = new System.Drawing.Point(198, 255);
            this.cmb_driver.Name = "cmb_driver";
            this.cmb_driver.Size = new System.Drawing.Size(121, 21);
            this.cmb_driver.TabIndex = 27;
            // 
            // lbl_billType
            // 
            this.lbl_billType.AutoSize = true;
            this.lbl_billType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_billType.Location = new System.Drawing.Point(11, 42);
            this.lbl_billType.Name = "lbl_billType";
            this.lbl_billType.Size = new System.Drawing.Size(92, 17);
            this.lbl_billType.TabIndex = 26;
            this.lbl_billType.Text = "İrsaliye Tipi";
            // 
            // lbl_deliveryDate
            // 
            this.lbl_deliveryDate.AutoSize = true;
            this.lbl_deliveryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_deliveryDate.Location = new System.Drawing.Point(457, 220);
            this.lbl_deliveryDate.Name = "lbl_deliveryDate";
            this.lbl_deliveryDate.Size = new System.Drawing.Size(103, 17);
            this.lbl_deliveryDate.TabIndex = 25;
            this.lbl_deliveryDate.Text = "Ulaşım Tarihi";
            // 
            // lbl_shipmentDate
            // 
            this.lbl_shipmentDate.AutoSize = true;
            this.lbl_shipmentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_shipmentDate.Location = new System.Drawing.Point(11, 220);
            this.lbl_shipmentDate.Name = "lbl_shipmentDate";
            this.lbl_shipmentDate.Size = new System.Drawing.Size(113, 17);
            this.lbl_shipmentDate.TabIndex = 24;
            this.lbl_shipmentDate.Text = "Gönderi Tarihi";
            // 
            // lbl_receiver
            // 
            this.lbl_receiver.AutoSize = true;
            this.lbl_receiver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_receiver.Location = new System.Drawing.Point(457, 69);
            this.lbl_receiver.Name = "lbl_receiver";
            this.lbl_receiver.Size = new System.Drawing.Size(38, 17);
            this.lbl_receiver.TabIndex = 23;
            this.lbl_receiver.Text = "Alıcı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(458, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Ürün";
            // 
            // lbl_vechile
            // 
            this.lbl_vechile.AutoSize = true;
            this.lbl_vechile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_vechile.Location = new System.Drawing.Point(11, 287);
            this.lbl_vechile.Name = "lbl_vechile";
            this.lbl_vechile.Size = new System.Drawing.Size(41, 17);
            this.lbl_vechile.TabIndex = 22;
            this.lbl_vechile.Text = "Araç";
            // 
            // lbl_driver
            // 
            this.lbl_driver.AutoSize = true;
            this.lbl_driver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_driver.Location = new System.Drawing.Point(11, 255);
            this.lbl_driver.Name = "lbl_driver";
            this.lbl_driver.Size = new System.Drawing.Size(59, 17);
            this.lbl_driver.TabIndex = 20;
            this.lbl_driver.Text = "Sürücü";
            // 
            // lblWaybillID
            // 
            this.lblWaybillID.AutoSize = true;
            this.lblWaybillID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWaybillID.Location = new System.Drawing.Point(11, 9);
            this.lblWaybillID.Name = "lblWaybillID";
            this.lblWaybillID.Size = new System.Drawing.Size(105, 17);
            this.lblWaybillID.TabIndex = 44;
            this.lblWaybillID.Text = "İrsaliye kodu:";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.Location = new System.Drawing.Point(767, 287);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 25);
            this.btnDelete.TabIndex = 45;
            this.btnDelete.Text = "Seçili Ürünü Sil";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUpdate.Location = new System.Drawing.Point(767, 546);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(120, 25);
            this.btnUpdate.TabIndex = 46;
            this.btnUpdate.Text = "Güncelle";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cmbIrsaliyeID
            // 
            this.cmbIrsaliyeID.FormattingEnabled = true;
            this.cmbIrsaliyeID.Items.AddRange(new object[] {
            "Entry",
            "Out"});
            this.cmbIrsaliyeID.Location = new System.Drawing.Point(122, 5);
            this.cmbIrsaliyeID.Name = "cmbIrsaliyeID";
            this.cmbIrsaliyeID.Size = new System.Drawing.Size(266, 21);
            this.cmbIrsaliyeID.TabIndex = 47;
            this.cmbIrsaliyeID.SelectedIndexChanged += new System.EventHandler(this.cmbIrsaliyeID_SelectedIndexChanged);
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(187, 75);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.ReadOnly = true;
            this.txtAdress.Size = new System.Drawing.Size(147, 20);
            this.txtAdress.TabIndex = 56;
            // 
            // txtContactName
            // 
            this.txtContactName.Location = new System.Drawing.Point(187, 18);
            this.txtContactName.Name = "txtContactName";
            this.txtContactName.ReadOnly = true;
            this.txtContactName.Size = new System.Drawing.Size(147, 20);
            this.txtContactName.TabIndex = 51;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 55;
            this.label5.Text = "Adres";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(187, 44);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(147, 20);
            this.txtPhone.TabIndex = 52;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 54;
            this.label6.Text = "Telefon";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 53;
            this.label7.Text = "Contact Name";
            // 
            // txtRAdress
            // 
            this.txtRAdress.Location = new System.Drawing.Point(180, 75);
            this.txtRAdress.Name = "txtRAdress";
            this.txtRAdress.ReadOnly = true;
            this.txtRAdress.Size = new System.Drawing.Size(147, 20);
            this.txtRAdress.TabIndex = 62;
            // 
            // txtRContactName
            // 
            this.txtRContactName.Location = new System.Drawing.Point(180, 18);
            this.txtRContactName.Name = "txtRContactName";
            this.txtRContactName.ReadOnly = true;
            this.txtRContactName.Size = new System.Drawing.Size(147, 20);
            this.txtRContactName.TabIndex = 60;
            // 
            // txtRPhone
            // 
            this.txtRPhone.Location = new System.Drawing.Point(180, 49);
            this.txtRPhone.Name = "txtRPhone";
            this.txtRPhone.ReadOnly = true;
            this.txtRPhone.Size = new System.Drawing.Size(147, 20);
            this.txtRPhone.TabIndex = 61;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(19, 25);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 57;
            this.label10.Text = "Contact Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 51);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 58;
            this.label9.Text = "Telefon";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 59;
            this.label8.Text = "Adres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(598, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 51;
            this.label2.Text = "Açıklama";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(443, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "Ürün Sayısı";
            // 
            // nudPcount
            // 
            this.nudPcount.Location = new System.Drawing.Point(513, 280);
            this.nudPcount.Name = "nudPcount";
            this.nudPcount.Size = new System.Drawing.Size(79, 20);
            this.nudPcount.TabIndex = 49;
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(661, 282);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(100, 20);
            this.txtDesc.TabIndex = 48;
            // 
            // FormWayBillUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 583);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudPcount);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.cmbIrsaliyeID);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lblWaybillID);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cmb_sender);
            this.Controls.Add(this.lbl_sender);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.cmb_billType);
            this.Controls.Add(this.dtp_deliveryDate);
            this.Controls.Add(this.dtp_shipmentDate);
            this.Controls.Add(this.cmb_receiver);
            this.Controls.Add(this.cmbProduct);
            this.Controls.Add(this.cmb_vechile);
            this.Controls.Add(this.cmb_driver);
            this.Controls.Add(this.lbl_billType);
            this.Controls.Add(this.lbl_deliveryDate);
            this.Controls.Add(this.lbl_shipmentDate);
            this.Controls.Add(this.lbl_receiver);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_vechile);
            this.Controls.Add(this.lbl_driver);
            this.Name = "FormWayBillUpdate";
            this.Text = "FormWayBillUpdate";
            this.Load += new System.EventHandler(this.FormWayBillUpdate_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudPcount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmb_sender;
        private System.Windows.Forms.Label lbl_sender;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.ComboBox cmb_billType;
        private System.Windows.Forms.DateTimePicker dtp_deliveryDate;
        private System.Windows.Forms.DateTimePicker dtp_shipmentDate;
        private System.Windows.Forms.ComboBox cmb_receiver;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.ComboBox cmb_vechile;
        private System.Windows.Forms.ComboBox cmb_driver;
        private System.Windows.Forms.Label lbl_billType;
        private System.Windows.Forms.Label lbl_deliveryDate;
        private System.Windows.Forms.Label lbl_shipmentDate;
        private System.Windows.Forms.Label lbl_receiver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_vechile;
        private System.Windows.Forms.Label lbl_driver;
        private System.Windows.Forms.Label lblWaybillID;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cmbIrsaliyeID;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.TextBox txtContactName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtRAdress;
        private System.Windows.Forms.TextBox txtRContactName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRPhone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nudPcount;
        private System.Windows.Forms.TextBox txtDesc;
    }
}
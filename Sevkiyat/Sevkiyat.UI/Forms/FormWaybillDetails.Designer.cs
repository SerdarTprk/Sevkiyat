namespace Sevkiyat.UI.Forms
{
    partial class FormWaybillDetails
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
            this.lbl_sender = new System.Windows.Forms.Label();
            this.lbl_billType = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_deliveryDate = new System.Windows.Forms.Label();
            this.lbl_shipmentDate = new System.Windows.Forms.Label();
            this.lbl_receiver = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl_vechile = new System.Windows.Forms.Label();
            this.lbl_driver = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbIrsaliyeID = new System.Windows.Forms.ComboBox();
            this.lblSender = new System.Windows.Forms.Label();
            this.lblBillType = new System.Windows.Forms.Label();
            this.lblReceiver = new System.Windows.Forms.Label();
            this.lblDriver = new System.Windows.Forms.Label();
            this.lblDeliveryDate = new System.Windows.Forms.Label();
            this.lblVehicle = new System.Windows.Forms.Label();
            this.lblShipmentDate = new System.Windows.Forms.Label();
            this.txtAdress = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtContactName = new System.Windows.Forms.TextBox();
            this.txtRAdress = new System.Windows.Forms.TextBox();
            this.txtRPhone = new System.Windows.Forms.TextBox();
            this.txtRContactName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_sender
            // 
            this.lbl_sender.AutoSize = true;
            this.lbl_sender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sender.Location = new System.Drawing.Point(-112, 141);
            this.lbl_sender.Name = "lbl_sender";
            this.lbl_sender.Size = new System.Drawing.Size(60, 17);
            this.lbl_sender.TabIndex = 23;
            this.lbl_sender.Text = "Sender";
            // 
            // lbl_billType
            // 
            this.lbl_billType.AutoSize = true;
            this.lbl_billType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_billType.Location = new System.Drawing.Point(-112, 114);
            this.lbl_billType.Name = "lbl_billType";
            this.lbl_billType.Size = new System.Drawing.Size(71, 17);
            this.lbl_billType.TabIndex = 20;
            this.lbl_billType.Text = "Bill Type";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader4,
            this.columnHeader3});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(17, 321);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(876, 204);
            this.listView1.TabIndex = 43;
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
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtPhone);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(27, 89);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(377, 103);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtRAdress);
            this.groupBox1.Controls.Add(this.txtRContactName);
            this.groupBox1.Controls.Add(this.txtRPhone);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(467, 90);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(377, 103);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(24, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 17);
            this.label1.TabIndex = 39;
            this.label1.Text = "Sender";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(24, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 30;
            this.label2.Text = "Bill Type";
            // 
            // lbl_deliveryDate
            // 
            this.lbl_deliveryDate.AutoSize = true;
            this.lbl_deliveryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_deliveryDate.Location = new System.Drawing.Point(463, 208);
            this.lbl_deliveryDate.Name = "lbl_deliveryDate";
            this.lbl_deliveryDate.Size = new System.Drawing.Size(106, 17);
            this.lbl_deliveryDate.TabIndex = 29;
            this.lbl_deliveryDate.Text = "Delivery Date";
            // 
            // lbl_shipmentDate
            // 
            this.lbl_shipmentDate.AutoSize = true;
            this.lbl_shipmentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_shipmentDate.Location = new System.Drawing.Point(24, 208);
            this.lbl_shipmentDate.Name = "lbl_shipmentDate";
            this.lbl_shipmentDate.Size = new System.Drawing.Size(114, 17);
            this.lbl_shipmentDate.TabIndex = 28;
            this.lbl_shipmentDate.Text = "Shipment Date";
            // 
            // lbl_receiver
            // 
            this.lbl_receiver.AutoSize = true;
            this.lbl_receiver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_receiver.Location = new System.Drawing.Point(463, 68);
            this.lbl_receiver.Name = "lbl_receiver";
            this.lbl_receiver.Size = new System.Drawing.Size(72, 17);
            this.lbl_receiver.TabIndex = 27;
            this.lbl_receiver.Text = "Receiver";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(397, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "Ürün Listesi";
            // 
            // lbl_vechile
            // 
            this.lbl_vechile.AutoSize = true;
            this.lbl_vechile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_vechile.Location = new System.Drawing.Point(24, 261);
            this.lbl_vechile.Name = "lbl_vechile";
            this.lbl_vechile.Size = new System.Drawing.Size(61, 17);
            this.lbl_vechile.TabIndex = 26;
            this.lbl_vechile.Text = "Vechile";
            // 
            // lbl_driver
            // 
            this.lbl_driver.AutoSize = true;
            this.lbl_driver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_driver.Location = new System.Drawing.Point(24, 232);
            this.lbl_driver.Name = "lbl_driver";
            this.lbl_driver.Size = new System.Drawing.Size(52, 17);
            this.lbl_driver.TabIndex = 24;
            this.lbl_driver.Text = "Driver";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(227, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 17);
            this.label4.TabIndex = 30;
            this.label4.Text = "Irsaliye Seçiniz:";
            // 
            // cmbIrsaliyeID
            // 
            this.cmbIrsaliyeID.FormattingEnabled = true;
            this.cmbIrsaliyeID.Items.AddRange(new object[] {
            "Entry",
            "Out"});
            this.cmbIrsaliyeID.Location = new System.Drawing.Point(355, 8);
            this.cmbIrsaliyeID.Name = "cmbIrsaliyeID";
            this.cmbIrsaliyeID.Size = new System.Drawing.Size(320, 21);
            this.cmbIrsaliyeID.TabIndex = 37;
            this.cmbIrsaliyeID.SelectedIndexChanged += new System.EventHandler(this.cmbIrsaliyeID_SelectedIndexChanged);
            // 
            // lblSender
            // 
            this.lblSender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSender.Location = new System.Drawing.Point(142, 64);
            this.lblSender.Name = "lblSender";
            this.lblSender.Size = new System.Drawing.Size(151, 23);
            this.lblSender.TabIndex = 44;
            // 
            // lblBillType
            // 
            this.lblBillType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBillType.Location = new System.Drawing.Point(142, 34);
            this.lblBillType.Name = "lblBillType";
            this.lblBillType.Size = new System.Drawing.Size(151, 23);
            this.lblBillType.TabIndex = 44;
            // 
            // lblReceiver
            // 
            this.lblReceiver.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblReceiver.Location = new System.Drawing.Point(575, 68);
            this.lblReceiver.Name = "lblReceiver";
            this.lblReceiver.Size = new System.Drawing.Size(151, 23);
            this.lblReceiver.TabIndex = 44;
            // 
            // lblDriver
            // 
            this.lblDriver.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDriver.Location = new System.Drawing.Point(142, 232);
            this.lblDriver.Name = "lblDriver";
            this.lblDriver.Size = new System.Drawing.Size(151, 23);
            this.lblDriver.TabIndex = 44;
            // 
            // lblDeliveryDate
            // 
            this.lblDeliveryDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDeliveryDate.Location = new System.Drawing.Point(575, 209);
            this.lblDeliveryDate.Name = "lblDeliveryDate";
            this.lblDeliveryDate.Size = new System.Drawing.Size(151, 23);
            this.lblDeliveryDate.TabIndex = 44;
            // 
            // lblVehicle
            // 
            this.lblVehicle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblVehicle.Location = new System.Drawing.Point(142, 262);
            this.lblVehicle.Name = "lblVehicle";
            this.lblVehicle.Size = new System.Drawing.Size(151, 23);
            this.lblVehicle.TabIndex = 44;
            // 
            // lblShipmentDate
            // 
            this.lblShipmentDate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblShipmentDate.Location = new System.Drawing.Point(142, 202);
            this.lblShipmentDate.Name = "lblShipmentDate";
            this.lblShipmentDate.Size = new System.Drawing.Size(151, 23);
            this.lblShipmentDate.TabIndex = 44;
            // 
            // txtAdress
            // 
            this.txtAdress.Location = new System.Drawing.Point(175, 75);
            this.txtAdress.Name = "txtAdress";
            this.txtAdress.ReadOnly = true;
            this.txtAdress.Size = new System.Drawing.Size(147, 20);
            this.txtAdress.TabIndex = 50;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 49;
            this.label5.Text = "Adres";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 48;
            this.label6.Text = "Telefon";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 47;
            this.label7.Text = "Contact Name";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(175, 44);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(147, 20);
            this.txtPhone.TabIndex = 46;
            // 
            // txtContactName
            // 
            this.txtContactName.Location = new System.Drawing.Point(175, 18);
            this.txtContactName.Name = "txtContactName";
            this.txtContactName.ReadOnly = true;
            this.txtContactName.Size = new System.Drawing.Size(147, 20);
            this.txtContactName.TabIndex = 45;
            // 
            // txtRAdress
            // 
            this.txtRAdress.Location = new System.Drawing.Point(175, 74);
            this.txtRAdress.Name = "txtRAdress";
            this.txtRAdress.ReadOnly = true;
            this.txtRAdress.Size = new System.Drawing.Size(147, 20);
            this.txtRAdress.TabIndex = 56;
            // 
            // txtRPhone
            // 
            this.txtRPhone.Location = new System.Drawing.Point(175, 48);
            this.txtRPhone.Name = "txtRPhone";
            this.txtRPhone.ReadOnly = true;
            this.txtRPhone.Size = new System.Drawing.Size(147, 20);
            this.txtRPhone.TabIndex = 55;
            // 
            // txtRContactName
            // 
            this.txtRContactName.Location = new System.Drawing.Point(175, 17);
            this.txtRContactName.Name = "txtRContactName";
            this.txtRContactName.ReadOnly = true;
            this.txtRContactName.Size = new System.Drawing.Size(147, 20);
            this.txtRContactName.TabIndex = 54;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 53;
            this.label8.Text = "Adres";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(14, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 52;
            this.label9.Text = "Telefon";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(75, 13);
            this.label10.TabIndex = 51;
            this.label10.Text = "Contact Name";
            // 
            // FormWaybillDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 536);
            this.Controls.Add(this.lblShipmentDate);
            this.Controls.Add(this.lblDeliveryDate);
            this.Controls.Add(this.lblBillType);
            this.Controls.Add(this.lblReceiver);
            this.Controls.Add(this.lblVehicle);
            this.Controls.Add(this.lblDriver);
            this.Controls.Add(this.lblSender);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbIrsaliyeID);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_deliveryDate);
            this.Controls.Add(this.lbl_shipmentDate);
            this.Controls.Add(this.lbl_receiver);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_vechile);
            this.Controls.Add(this.lbl_driver);
            this.Controls.Add(this.lbl_sender);
            this.Controls.Add(this.lbl_billType);
            this.Name = "FormWaybillDetails";
            this.Text = "FormWaybillDetails";
            this.Load += new System.EventHandler(this.FormWaybillDetails_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_sender;
        private System.Windows.Forms.Label lbl_billType;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_deliveryDate;
        private System.Windows.Forms.Label lbl_shipmentDate;
        private System.Windows.Forms.Label lbl_receiver;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbl_vechile;
        private System.Windows.Forms.Label lbl_driver;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbIrsaliyeID;
        private System.Windows.Forms.Label lblSender;
        private System.Windows.Forms.Label lblBillType;
        private System.Windows.Forms.Label lblReceiver;
        private System.Windows.Forms.Label lblDriver;
        private System.Windows.Forms.Label lblDeliveryDate;
        private System.Windows.Forms.Label lblVehicle;
        private System.Windows.Forms.Label lblShipmentDate;
        private System.Windows.Forms.TextBox txtAdress;
        private System.Windows.Forms.TextBox txtContactName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRAdress;
        private System.Windows.Forms.TextBox txtRContactName;
        private System.Windows.Forms.TextBox txtRPhone;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
    }
}
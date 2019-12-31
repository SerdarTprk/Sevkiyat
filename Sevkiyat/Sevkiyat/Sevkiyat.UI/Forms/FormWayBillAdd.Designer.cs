namespace Sevkiyat.UI
{
    partial class FormWayBillAdd
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
            this.lbl_driver = new System.Windows.Forms.Label();
            this.lbl_vechile = new System.Windows.Forms.Label();
            this.lbl_receiver = new System.Windows.Forms.Label();
            this.lbl_shipmentDate = new System.Windows.Forms.Label();
            this.lbl_deliveryDate = new System.Windows.Forms.Label();
            this.lbl_billType = new System.Windows.Forms.Label();
            this.cmb_driver = new System.Windows.Forms.ComboBox();
            this.cmb_vechile = new System.Windows.Forms.ComboBox();
            this.cmb_receiver = new System.Windows.Forms.ComboBox();
            this.dtp_shipmentDate = new System.Windows.Forms.DateTimePicker();
            this.dtp_deliveryDate = new System.Windows.Forms.DateTimePicker();
            this.cmb_billType = new System.Windows.Forms.ComboBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.cmb_sender = new System.Windows.Forms.ComboBox();
            this.lbl_sender = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lbl_driver
            // 
            this.lbl_driver.AutoSize = true;
            this.lbl_driver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_driver.Location = new System.Drawing.Point(36, 356);
            this.lbl_driver.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_driver.Name = "lbl_driver";
            this.lbl_driver.Size = new System.Drawing.Size(69, 25);
            this.lbl_driver.TabIndex = 0;
            this.lbl_driver.Text = "Driver";
            // 
            // lbl_vechile
            // 
            this.lbl_vechile.AutoSize = true;
            this.lbl_vechile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_vechile.Location = new System.Drawing.Point(36, 404);
            this.lbl_vechile.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_vechile.Name = "lbl_vechile";
            this.lbl_vechile.Size = new System.Drawing.Size(84, 25);
            this.lbl_vechile.TabIndex = 1;
            this.lbl_vechile.Text = "Vechile";
            // 
            // lbl_receiver
            // 
            this.lbl_receiver.AutoSize = true;
            this.lbl_receiver.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_receiver.Location = new System.Drawing.Point(695, 70);
            this.lbl_receiver.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_receiver.Name = "lbl_receiver";
            this.lbl_receiver.Size = new System.Drawing.Size(96, 25);
            this.lbl_receiver.TabIndex = 3;
            this.lbl_receiver.Text = "Receiver";
            // 
            // lbl_shipmentDate
            // 
            this.lbl_shipmentDate.AutoSize = true;
            this.lbl_shipmentDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_shipmentDate.Location = new System.Drawing.Point(36, 302);
            this.lbl_shipmentDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_shipmentDate.Name = "lbl_shipmentDate";
            this.lbl_shipmentDate.Size = new System.Drawing.Size(154, 25);
            this.lbl_shipmentDate.TabIndex = 4;
            this.lbl_shipmentDate.Text = "Shipment Date";
            // 
            // lbl_deliveryDate
            // 
            this.lbl_deliveryDate.AutoSize = true;
            this.lbl_deliveryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_deliveryDate.Location = new System.Drawing.Point(683, 302);
            this.lbl_deliveryDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_deliveryDate.Name = "lbl_deliveryDate";
            this.lbl_deliveryDate.Size = new System.Drawing.Size(141, 25);
            this.lbl_deliveryDate.TabIndex = 5;
            this.lbl_deliveryDate.Text = "Delivery Date";
            // 
            // lbl_billType
            // 
            this.lbl_billType.AutoSize = true;
            this.lbl_billType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_billType.Location = new System.Drawing.Point(36, 27);
            this.lbl_billType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_billType.Name = "lbl_billType";
            this.lbl_billType.Size = new System.Drawing.Size(96, 25);
            this.lbl_billType.TabIndex = 6;
            this.lbl_billType.Text = "Bill Type";
            // 
            // cmb_driver
            // 
            this.cmb_driver.FormattingEnabled = true;
            this.cmb_driver.Location = new System.Drawing.Point(306, 356);
            this.cmb_driver.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_driver.Name = "cmb_driver";
            this.cmb_driver.Size = new System.Drawing.Size(180, 28);
            this.cmb_driver.TabIndex = 8;
            // 
            // cmb_vechile
            // 
            this.cmb_vechile.FormattingEnabled = true;
            this.cmb_vechile.Location = new System.Drawing.Point(306, 404);
            this.cmb_vechile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_vechile.Name = "cmb_vechile";
            this.cmb_vechile.Size = new System.Drawing.Size(180, 28);
            this.cmb_vechile.TabIndex = 9;
            // 
            // cmb_receiver
            // 
            this.cmb_receiver.FormattingEnabled = true;
            this.cmb_receiver.Location = new System.Drawing.Point(965, 70);
            this.cmb_receiver.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_receiver.Name = "cmb_receiver";
            this.cmb_receiver.Size = new System.Drawing.Size(180, 28);
            this.cmb_receiver.TabIndex = 10;
            // 
            // dtp_shipmentDate
            // 
            this.dtp_shipmentDate.Location = new System.Drawing.Point(306, 302);
            this.dtp_shipmentDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtp_shipmentDate.Name = "dtp_shipmentDate";
            this.dtp_shipmentDate.Size = new System.Drawing.Size(180, 26);
            this.dtp_shipmentDate.TabIndex = 11;
            // 
            // dtp_deliveryDate
            // 
            this.dtp_deliveryDate.Location = new System.Drawing.Point(953, 302);
            this.dtp_deliveryDate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtp_deliveryDate.Name = "dtp_deliveryDate";
            this.dtp_deliveryDate.Size = new System.Drawing.Size(180, 26);
            this.dtp_deliveryDate.TabIndex = 12;
            // 
            // cmb_billType
            // 
            this.cmb_billType.FormattingEnabled = true;
            this.cmb_billType.Items.AddRange(new object[] {
            "Entry",
            "Out"});
            this.cmb_billType.Location = new System.Drawing.Point(306, 27);
            this.cmb_billType.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_billType.Name = "cmb_billType";
            this.cmb_billType.Size = new System.Drawing.Size(180, 28);
            this.cmb_billType.TabIndex = 13;
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_clear.Location = new System.Drawing.Point(26, 796);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(180, 38);
            this.btn_clear.TabIndex = 14;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            // 
            // btn_confirm
            // 
            this.btn_confirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_confirm.Location = new System.Drawing.Point(1158, 796);
            this.btn_confirm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(180, 38);
            this.btn_confirm.TabIndex = 15;
            this.btn_confirm.Text = "Confirm";
            this.btn_confirm.UseVisualStyleBackColor = true;
            // 
            // cmb_sender
            // 
            this.cmb_sender.FormattingEnabled = true;
            this.cmb_sender.Location = new System.Drawing.Point(306, 65);
            this.cmb_sender.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmb_sender.Name = "cmb_sender";
            this.cmb_sender.Size = new System.Drawing.Size(180, 28);
            this.cmb_sender.TabIndex = 17;
            // 
            // lbl_sender
            // 
            this.lbl_sender.AutoSize = true;
            this.lbl_sender.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_sender.Location = new System.Drawing.Point(36, 69);
            this.lbl_sender.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_sender.Name = "lbl_sender";
            this.lbl_sender.Size = new System.Drawing.Size(82, 25);
            this.lbl_sender.TabIndex = 16;
            this.lbl_sender.Text = "Sender";
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(700, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(566, 159);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(41, 101);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(566, 159);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox1";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(1158, 404);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 38);
            this.button1.TabIndex = 15;
            this.button1.Text = "Confirm";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader4,
            this.columnHeader3});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(26, 459);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1312, 312);
            this.listView1.TabIndex = 19;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(683, 413);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ürün";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(775, 410);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(370, 28);
            this.comboBox1.TabIndex = 9;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Ürün Adı";
            this.columnHeader1.Width = 743;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Adet";
            this.columnHeader3.Width = 161;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Miktar Cinsi";
            this.columnHeader4.Width = 283;
            // 
            // FormWayBillAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1364, 850);
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
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.cmb_vechile);
            this.Controls.Add(this.cmb_driver);
            this.Controls.Add(this.lbl_billType);
            this.Controls.Add(this.lbl_deliveryDate);
            this.Controls.Add(this.lbl_shipmentDate);
            this.Controls.Add(this.lbl_receiver);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_vechile);
            this.Controls.Add(this.lbl_driver);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormWayBillAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create Waybill";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_driver;
        private System.Windows.Forms.Label lbl_vechile;
        private System.Windows.Forms.Label lbl_receiver;
        private System.Windows.Forms.Label lbl_shipmentDate;
        private System.Windows.Forms.Label lbl_deliveryDate;
        private System.Windows.Forms.Label lbl_billType;
        private System.Windows.Forms.ComboBox cmb_driver;
        private System.Windows.Forms.ComboBox cmb_vechile;
        private System.Windows.Forms.ComboBox cmb_receiver;
        private System.Windows.Forms.DateTimePicker dtp_shipmentDate;
        private System.Windows.Forms.DateTimePicker dtp_deliveryDate;
        private System.Windows.Forms.ComboBox cmb_billType;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.ComboBox cmb_sender;
        private System.Windows.Forms.Label lbl_sender;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
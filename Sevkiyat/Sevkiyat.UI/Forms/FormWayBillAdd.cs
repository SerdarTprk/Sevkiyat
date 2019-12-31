using Sevkiyat.UI.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sevkiyat.UI
{
    public partial class FormWayBillAdd : Form
    {
        

        List<WayBillDetail> _wayBillDetail;
        public FormWayBillAdd()
        {
            InitializeComponent();
        
            _wayBillDetail = new List<WayBillDetail>();
        }


        private void FormWayBillAdd_Load(object sender, EventArgs e)
        {
            WayBillComboLoad();
        }
        public void WayBillComboLoad()
        {
            cmb_billType.EnumLoad<WayBillType>();
            cmb_driver.Load<Driver>(Db.Context, "FirstName", "ID", u => u.IsDeleted == false, a => a.IsActive == true);
            cmb_receiver.Load<Payer>(Db.Context, "ContactName", "ID", u => u.IsDeleted == false, a => a.IsActive == true);
            cmb_sender.Load<Payer>(Db.Context, "ContactName", "ID", u => u.IsDeleted == false, a => a.IsActive == true);
            cmb_vechile.Load<Vehicle>(Db.Context, "Plate", "ID", u => u.IsDeleted == false, a => a.IsActive == true);
            cmbProduct.Load<Product>(Db.Context, "ProductName", "ID", u => u.IsDeleted == false, a => a.IsActive == true);
            listView1.Columns.Add("ÜrünAdı");
            listView1.Columns.Add("Miktar Tipi");
            listView1.Columns.Add("Adet");
        }
        private void btnListEkle_Click(object sender, EventArgs e)
        {
            WayBillDetail wayBillDetail = new WayBillDetail()
            {
                Product = (Product)cmbProduct.SelectedItem,
                Quantity = (short)nudPcount.Value,
                Description = txtDesc.ToString()
            };
            _wayBillDetail.Add(wayBillDetail);
            WayBillLoad();
        }
        private void WayBillLoad()
        {
            listView1.Items.Clear();
            foreach (var item in _wayBillDetail)
            {
                string[] subitems = { ((ProductQuantityPerUnit)item.Product.QuantityPerUnit).ToString(), item.Quantity.ToString() };
    
                listView1.Items.Add(item.Product.ProductName.ToString()).SubItems.AddRange(subitems);
             
            }
        }
        private void btnEkle_Click(object sender, EventArgs e)
        {
            WayBill wayBill = new WayBill();

            wayBill.ID = Guid.NewGuid();
            wayBill.DriverID = (Guid)cmb_driver.SelectedValue;
            wayBill.SenderID = (Guid)cmb_sender.SelectedValue;
            wayBill.ReceiverID = (Guid)cmb_receiver.SelectedValue;
            wayBill.VehicleID = (Guid)cmb_vechile.SelectedValue;
            wayBill.ShipmentDate = dtp_shipmentDate.Value;
            wayBill.DeliveryDate = dtp_deliveryDate.Value;
            wayBill.BillType = Convert.ToByte(cmb_billType.SelectedValue);
            wayBill.CreatedDate = DateTime.Now;
            wayBill.CreatedUserID = Session.CurrentUser.ID;
           

            foreach (var item in _wayBillDetail)
            {
                wayBill.WayBillDetails.Add(item);
            }
            Db.Context.WayBills.Add(wayBill);
            Db.Context.KontrolluKaydet();
            _wayBillDetail.Clear();
            WayBillLoad();
        }

        private void cmb_sender_SelectedIndexChanged(object sender, EventArgs e)
        {
            Payer payer = (Payer)cmb_sender.SelectedItem;
            txtAdress.Text = payer.Address.ToString();
            txtContactName.Text = payer.ContactName.ToString();
            txtPhone.Text = payer.Phone.ToString();


        }

        private void cmb_receiver_SelectedIndexChanged(object sender, EventArgs e)
        {
            Payer payer = (Payer)cmb_receiver.SelectedItem;
            txtRAdress.Text = payer.Address.ToString();
            txtRPhone.Text = payer.Phone.ToString();
            txtRContactName.Text = payer.ContactName.ToString();

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            _wayBillDetail.Clear();
            WayBillLoad();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }


        //CREATED USER - CREATED DATE 
        //BU 2 İRSALİYE KOLONU ELLE GİRİLMEYECEĞİ İÇİN FORMDA YOK
    }
}

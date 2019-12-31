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
    public partial class FormWayBillUpdate : Form
    {
        WayBill _wayBill;
        List<WayBillDetail> _wayBillDetail;
        public FormWayBillUpdate()
        {
            InitializeComponent();
            _wayBill = new WayBill();
            _wayBillDetail = new List<WayBillDetail>();
        }

        private void FormWayBillUpdate_Load(object sender, EventArgs e)
        {
            cmbIrsaliyeID.Load<WayBill>(Db.Context, "ID", "ID");
            WayBillComboLoad();

        }
        private  void WayBillComboLoad()
        {
            cmb_billType.EnumLoad<WayBillType>();
            cmb_driver.Load<Driver>(Db.Context, "FirstName", "ID", u => u.IsDeleted == false, a => a.IsActive == true);
            cmb_receiver.Load<Payer>(Db.Context, "ContactName", "ID", u => u.IsDeleted == false, a => a.IsActive == true);
            cmb_sender.Load<Payer>(Db.Context, "ContactName", "ID", u => u.IsDeleted == false, a => a.IsActive == true);
            cmb_vechile.Load<Vehicle>(Db.Context, "Plate", "ID", u => u.IsDeleted == false, a => a.IsActive == true);
            cmbProduct.Load<Product>(Db.Context, "ProductName", "ID", u => u.IsDeleted == false, a => a.IsActive == true);
            
        }
        private void SeciliCombo()
        {
            _wayBill = cmbIrsaliyeID.SelectedItem as WayBill;
            cmb_billType.SelectedValue =Convert.ToInt32(_wayBill.BillType);
            cmb_driver.SelectedValue = _wayBill.DriverID;
            cmb_receiver.SelectedValue = _wayBill.ReceiverID;
            cmb_sender.SelectedValue = _wayBill.SenderID;
            cmb_vechile.SelectedValue = _wayBill.VehicleID;
           _wayBillDetail = (from w in Db.Context.WayBillDetails where w.WaybillID == _wayBill.ID select w).ToList();
            WayBillLoad();
            cmbProduct.SelectedValue = _wayBillDetail.Select(p => p.ProductID);

        }
        private void Ekle()
        {
            WayBillDetail wayBillDetail = new WayBillDetail()
            {
                Product = (Product)cmbProduct.SelectedItem,
                Quantity = (short)nudPcount.Value,
                Description = Convert.ToString(txtDesc.Text)
            };
            _wayBillDetail.Add(wayBillDetail);
        }
            
        private void WayBillLoad()
        {
            listView1.Clear();
            listView1.Columns.Add("ÜrünAdı");
            listView1.Columns.Add("Miktar Tipi");
            listView1.Columns.Add("Adet");
          
            foreach (var item in _wayBillDetail)
            {
                string[] subitems = { ((ProductQuantityPerUnit)item.Product.QuantityPerUnit).ToString(), item.Quantity.ToString() };
                ListViewItem lstItem = new ListViewItem(item.Product.ProductName);
                lstItem.SubItems.AddRange(subitems);
                lstItem.Tag = item;
                listView1.Items.Add(lstItem);
            }
        }
        private void cmbIrsaliyeID_SelectedIndexChanged(object sender, EventArgs e)
        {
            SeciliCombo();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            _wayBillDetail.Remove(listView1.SelectedItems[0].Tag as WayBillDetail);
            WayBillLoad();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Ekle();
            WayBillLoad();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

            var query = (from wd in Db.Context.WayBillDetails where wd.WaybillID == _wayBill.ID select wd).ToList();
            foreach (var item in query)
            {
                _wayBill.WayBillDetails.Remove(item);
            }
            _wayBill.DriverID = (Guid)cmb_driver.SelectedValue;
            _wayBill.SenderID = (Guid)cmb_sender.SelectedValue;
            _wayBill.ReceiverID = (Guid)cmb_receiver.SelectedValue;
            _wayBill.VehicleID = (Guid)cmb_vechile.SelectedValue;
            _wayBill.ShipmentDate = dtp_shipmentDate.Value;
            _wayBill.DeliveryDate = dtp_deliveryDate.Value;
            _wayBill.BillType = Convert.ToByte(cmb_billType.SelectedValue);
            _wayBill.CreatedDate = DateTime.Now;
            _wayBill.CreatedUserID = Session.CurrentUser.ID;
            
            foreach (var item in _wayBillDetail)
            {
                _wayBill.WayBillDetails.Add(item);
            }
            Db.Context.KontrolluKaydet();
            _wayBillDetail.Clear();
            WayBillLoad();
            listView1.Items.Clear();
        }
    }
}

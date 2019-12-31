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

namespace Sevkiyat.UI.Forms
{
    public partial class FormWaybillDetails : Form
    {
        WayBill _wayBill;
        List<WayBillDetail> _wayBillDetail;
        public FormWaybillDetails()
        {
            InitializeComponent();
            _wayBill = new WayBill();
            
        }

        private void FormWaybillDetails_Load(object sender, EventArgs e)
        {
            cmbIrsaliyeID.Load<WayBill>(Db.Context,"ID","ID");
            
        }
       
        private void cmbIrsaliyeID_SelectedIndexChanged(object sender, EventArgs e)
        {
            _wayBillDetail = new List<WayBillDetail>();
            _wayBill = cmbIrsaliyeID.SelectedItem as WayBill;
            _wayBillDetail = (from w in Db.Context.WayBillDetails where w.WaybillID == _wayBill.ID select w).ToList();
            var Sender = (from d in Db.Context.Payers where d.ID == _wayBill.SenderID select d).SingleOrDefault();
            var Receiver = (from d in Db.Context.Payers where d.ID == _wayBill.ReceiverID select d).SingleOrDefault();
            lblBillType.Text = Enum.GetName(typeof(WayBillType), (int)_wayBill.BillType);
            lblSender.Text = Sender.CompanyName.ToString();
            lblReceiver.Text = Receiver.CompanyName.ToString();
            lblDriver.Text = (from d in Db.Context.Drivers where d.ID == _wayBill.DriverID select d.FirstName).SingleOrDefault().ToString();
            lblVehicle.Text = (from d in Db.Context.Vehicles where d.ID==_wayBill.VehicleID select d.Plate).SingleOrDefault().ToString();
            lblShipmentDate.Text = _wayBill.ShipmentDate.ToString();
            lblDeliveryDate.Text = _wayBill.DeliveryDate.ToString();
            txtAdress.Text = Sender.Address.ToString();
            txtContactName.Text = Sender.ContactName.ToString();
            txtPhone.Text = Sender.Phone.ToString();
            txtRAdress.Text = Receiver.Address.ToString();
            txtRContactName.Text = Receiver.Address.ToString();
            txtRPhone.Text = Receiver.Phone.ToString();

            foreach (var item in _wayBillDetail)
            {
                string[] subitems = { ((ProductQuantityPerUnit)item.Product.QuantityPerUnit).ToString(), item.Quantity.ToString() };
                listView1.Items.Add(item.Product.ProductName.ToString()).SubItems.AddRange(subitems);
            }
            
        }
    }
}

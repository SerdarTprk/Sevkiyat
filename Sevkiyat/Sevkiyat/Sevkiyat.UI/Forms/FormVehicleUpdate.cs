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
    public partial class FormVehicleUpdate : Form
    {
        public event EventHandler RecordUpdated;
        SevkiyatDBEntities _db;
        Vehicle _vehicle;
        public FormVehicleUpdate(Vehicle vehicle, SevkiyatDBEntities context)
        {
            InitializeComponent();
            _db = context;
            _vehicle = vehicle;
        }

        private void FormVehicleUpdate_Load(object sender, EventArgs e)
        {

            txtBrand.Text = _vehicle.Brand.ToString();
            txtModel.Text = _vehicle.Model.ToString();
            txtPlate.Text = _vehicle.Plate.ToString();
            nudCapacity.Value =(int) _vehicle.Capacity;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            _vehicle.Brand = txtBrand.Text;
            _vehicle.Model = txtModel.Text;
            _vehicle.Plate = txtPlate.Text;
            _vehicle.Capacity = (int)nudCapacity.Value;
            _db.KontrolluKaydet(RecordUpdated);
        }
    }
}

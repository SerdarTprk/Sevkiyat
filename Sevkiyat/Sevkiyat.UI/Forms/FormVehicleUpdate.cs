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
        public static event EventHandler RecordUpdated;
        Vehicle _vehicle;
        public FormVehicleUpdate(Vehicle vehicle, SevkiyatDBEntities context)
        {
            InitializeComponent();
            _vehicle = vehicle;
        }

        private void FormVehicleUpdate_Load(object sender, EventArgs e)
        {

            txtBrand.Text = _vehicle.Brand.ToString();
            txtModel.Text = _vehicle.Model.ToString();
            txtPlate.Text = _vehicle.Plate.ToString();
            nudCapacity.Value =(int) _vehicle.Capacity;
            chbAktif.Checked = (bool)_vehicle.IsActive;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            _vehicle.Brand = txtBrand.Text;
            _vehicle.Model = txtModel.Text;
            _vehicle.Plate = txtPlate.Text;
            _vehicle.Capacity = (int)nudCapacity.Value;
            _vehicle.IsActive = (bool?)chbAktif.Checked;
           
            Db.Context.KontrolluKaydet(RecordUpdated);
        }
    }
}

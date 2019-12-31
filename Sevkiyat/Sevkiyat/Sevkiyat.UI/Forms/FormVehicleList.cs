using Sevkiyat.UI.Forms;
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
    public partial class FormVehicleList : Form
    {
        SevkiyatDBEntities _db;
        Vehicle vehicle;
        public event EventHandler RecordDeleted;
        public FormVehicleList()
        {
            InitializeComponent();
            _db = new SevkiyatDBEntities();
            Load += ListReload;
        }
        private void ListReload(object sender, EventArgs e)
        {
            //ListeyiYuke();
            lstVehicles.Load<Vehicle>(_db, "Plate", "ID");

        }
        private void TxtPlate_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            this.MdiBroShow<FormVehicleAdd>();
            Helper.RecordReload += ListReload;
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            var ID = (Guid)lstVehicles.SelectedValue;
            vehicle = (from p in _db.Vehicles where p.ID == (Guid)ID select p).SingleOrDefault();
            _db.Vehicles.Remove(vehicle);
            _db.KontrolluKaydet(RecordDeleted);
            Helper.RecordReload += ListReload;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            vehicle = lstVehicles.SelectedItem as Vehicle;
            FormVehicleUpdate frm = new FormVehicleUpdate(vehicle,_db);
            Helper.RecordReload += ListReload;
            frm.MdiParent = this.MdiParent;
            frm.Show();
            frm.RecordUpdated += ListReload;
        }
    }
}

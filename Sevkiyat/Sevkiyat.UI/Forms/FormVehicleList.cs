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

        Vehicle vehicle;
        public event EventHandler RecordDeleted;
        public FormVehicleList()
        {
            InitializeComponent();
            Load += ListReload;
            FormVehicleAdd.KayitGirdim += ListReload;
            FormVehicleUpdate.RecordUpdated += ListReload;
            RecordDeleted += ListReload;
        }
        private void ListReload(object sender, EventArgs e)
        {
            lstVehicles.Load<Vehicle>(Db.Context, "Plate", "ID",u => u.IsDeleted == false, a => a.IsActive == true);

        }
        private void TxtPlate_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            this.MdiBroShow<FormVehicleAdd>();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            vehicle = lstVehicles.SelectedItem as Vehicle;
            vehicle.IsDeleted = true;
            Db.Context.KontrolluKaydet(RecordDeleted);
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            vehicle = lstVehicles.SelectedItem as Vehicle;
            this.MdiBroShow<FormVehicleUpdate, Vehicle>(vehicle);

        }

        private void FormVehicleList_Load(object sender, EventArgs e)
        {

        }
    }
}

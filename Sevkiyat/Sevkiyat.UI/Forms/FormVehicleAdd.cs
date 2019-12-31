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
    public partial class FormVehicleAdd : Form
    {

        public static event EventHandler KayitGirdim;
        public FormVehicleAdd()
        {
            InitializeComponent();

        }

        private void FormVehicleAdd_Load(object sender, EventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Vehicle vehicle = new Vehicle()
            {
                Brand = txtBrand.Text,
                ID = Guid.NewGuid(),
                Capacity = Convert.ToInt32(nudCapacity.Value),
                Model = txtModel.Text,
                Plate = txtPlate.Text,
                IsDeleted = false,
                IsActive = true
                           
            };
            Db.Context.Vehicles.Add(vehicle);
            Db.Context.KontrolluKaydet(KayitGirdim);
        }

        private void NudCapacity_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

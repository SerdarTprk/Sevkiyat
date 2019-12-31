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
        SevkiyatDBEntities _db;
        public event EventHandler KayitGirdim;
        public FormVehicleAdd()
        {
            InitializeComponent();
            _db = new SevkiyatDBEntities();
        }

        private void FormVehicleAdd_Load(object sender, EventArgs e)
        {

        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Vehicle vehicle = new Vehicle()
            {
                Brand=txtBrand.Text,
                ID= Guid.NewGuid(),
                Capacity=Convert.ToInt32(nudCapacity.Value),
                Model=txtModel.Text,
                Plate=txtPlate.Text,
            };
            _db.Vehicles.Add(vehicle);
            _db.KontrolluKaydet(KayitGirdim);
        }

        private void NudCapacity_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}

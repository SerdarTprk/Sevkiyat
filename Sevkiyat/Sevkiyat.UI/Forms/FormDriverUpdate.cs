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
    public partial class FormDriverUpdate : Form
    {
        public static event EventHandler RecordUpdated;
        Driver _drivers;
        public FormDriverUpdate(Driver driver)
        {
            InitializeComponent();
            _drivers = driver;
        }

        private void FormDriverUpdate_Load(object sender, EventArgs e)
        {
            txtTcNo.Text = _drivers.TcNo.ToString();
            txtFirstName.Text = _drivers.FirstName.ToString();
            txtLastName.Text = _drivers.LastName.ToString();
            txtPhone.Text = _drivers.Phone.ToString();
            dtpDogumTarihi.Value = _drivers.BirthDate.Value;
            chbAktif.Checked = (bool)_drivers.IsActive;

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            _drivers.TcNo = txtTcNo.Text ;
            _drivers.FirstName= txtFirstName.Text;
            _drivers.LastName= txtLastName.Text;
            _drivers.Phone = txtPhone.Text;
            _drivers.BirthDate = dtpDogumTarihi.Value;
            Db.Context.KontrolluKaydet(RecordUpdated);
        }
    }
}

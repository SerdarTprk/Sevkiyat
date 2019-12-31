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
        public event EventHandler RecordUpdated;
        SevkiyatDBEntities _db;
        Driver _drivers;
        public FormDriverUpdate(Driver driver, SevkiyatDBEntities context)
        {
            InitializeComponent();
            _db = context;
            _drivers = driver;
        }

        private void FormDriverUpdate_Load(object sender, EventArgs e)
        {
            txtTcNo.Text = _drivers.TcNo.ToString();
            txtFirstName.Text = _drivers.FirstName.ToString();
            txtLastName.Text = _drivers.LastName.ToString();
            txtPhone.Text = _drivers.Phone.ToString();
            dtpDogumTarihi.Value = _drivers.BirthDate.Value;

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            _drivers.TcNo = txtTcNo.Text ;
            _drivers.FirstName= txtFirstName.Text;
            _drivers.LastName= txtLastName.Text;
            _drivers.Phone = txtPhone.Text;
            _drivers.BirthDate = dtpDogumTarihi.Value;
            _db.KontrolluKaydet(RecordUpdated);
        }
    }
}

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
    public partial class FormDriverAdd : Form
    {
        SevkiyatDBEntities _db;
        public event EventHandler KayitGirdim;
        public FormDriverAdd()
        {
            InitializeComponent();
            _db = new SevkiyatDBEntities();
        }

        private void FormDriverAdd_Load(object sender, EventArgs e)
        {

        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTcKimlikNo.Text))
            {
                MessageBox.Show("TcNo Boş Geçilemez.");
                return;
            }

            Driver driver = new Driver()
            {
                ID = Guid.NewGuid(),
                TcNo = txtTcKimlikNo.Text,
                FirstName = txtAd.Text,
                LastName = txtSoyad.Text,
                Phone = txtTel.Text,
                BirthDate = dtpDogumTarihi.Value
            };

            _db.Drivers.Add(driver);
            _db.KontrolluKaydet(KayitGirdim);
        }
    }
}

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

        public static event EventHandler KayitGirdim;
        public FormDriverAdd()
        {
            InitializeComponent();
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
                BirthDate = dtpDogumTarihi.Value,
                IsActive = true,
                IsDeleted = false,

            };
            Db.Context.Drivers.Add(driver);
            Db.Context.KontrolluKaydet(KayitGirdim);
        }

        private void FormDriverAdd_Load(object sender, EventArgs e)
        {

        }
    }
}

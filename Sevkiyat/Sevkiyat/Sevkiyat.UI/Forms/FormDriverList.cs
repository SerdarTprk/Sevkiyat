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
    public partial class FormDriverList : Form
    {
        SevkiyatDBEntities _db;
        Driver driver;
        public event EventHandler RecordDeleted;
        public FormDriverList()
        {
            InitializeComponent();
            _db = new SevkiyatDBEntities();
            Load += ListReload;

        }

        private void FormDriverList_Load(object sender, EventArgs e)
        {

        }
        private void ListReload(object sender, EventArgs e)
        {
            //ListeyiYuke();
            lstSoforListele.Load<Driver>(_db, "FirstName", "ID");

        }

        private void BtnSoforEkle_Click(object sender, EventArgs e)
        {
            this.MdiBroShow<FormDriverAdd>();
            Helper.RecordReload += ListReload;
        }

        private void BtnSoforSil_Click(object sender, EventArgs e)
        {
            var ID = (Guid)lstSoforListele.SelectedValue;
            driver = (from p in _db.Drivers where p.ID == (Guid)ID select p).SingleOrDefault();
            _db.Drivers.Remove(driver);
            _db.KontrolluKaydet(RecordDeleted);
            Helper.RecordReload += ListReload;
        }

        private void BtnSoforGuncelle_Click(object sender, EventArgs e)
        {
            driver = lstSoforListele.SelectedItem as Driver;
            FormDriverUpdate frm = new FormDriverUpdate(driver, _db);
            Helper.RecordReload += ListReload;
            frm.MdiParent = this.MdiParent;
            frm.RecordUpdated += ListReload;
            frm.Show();
           
        }
    }
}

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
    public partial class FormPayersList : Form
    {
        public event EventHandler RecordDeleted;

        SevkiyatDBEntities _db;
        Payer payer;
        public FormPayersList()
        {
            InitializeComponent();
            _db = new SevkiyatDBEntities();
            Load += ListReload;
        }

        private void btnAddForm_Click(object sender, EventArgs e)
        {
            this.MdiBroShow<FormPayerAdd>();
            Helper.RecordReload += ListReload;

        }

        private void ListReload(object sender, EventArgs e)
        {
            //ListeyiYuke();
            lstPayer.Load<Payer>(_db, "CompanyName", "ID");

        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var ID = (Guid)lstPayer.SelectedValue;
            payer = (from p in _db.Payers where p.ID == (Guid)ID select p).SingleOrDefault();
            _db.Payers.Remove(payer);
            _db.KontrolluKaydet(RecordDeleted);
            Helper.RecordReload += ListReload;
        }

        private void BtnUpdateForm_Click(object sender, EventArgs e)
        {
            payer = lstPayer.SelectedItem as Payer;
            FormPayersUpdate frm = new FormPayersUpdate(payer, _db);
            Helper.RecordReload += ListReload;
            frm.MdiParent = this.MdiParent;
            frm.Show();
            frm.RecordUpdated += ListReload;
        }
    }
}

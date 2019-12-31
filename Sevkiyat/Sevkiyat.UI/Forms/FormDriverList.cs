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
    
        Driver driver;
        public event EventHandler RecordDeleted;
        public FormDriverList()
        {
            InitializeComponent();
            Load += ListReload;
            FormDriverAdd.KayitGirdim += ListReload;
            FormDriverUpdate.RecordUpdated += ListReload;
            
        }

        private void ListReload(object sender, EventArgs e)
        {
  
            lstSoforListele.Load<Driver>(Db.Context, "FirstName", "ID", u => u.IsActive == true, a => a.IsDeleted == false);

        }

        private void BtnSoforEkle_Click(object sender, EventArgs e)
        {
            this.MdiBroShow<FormDriverAdd>();
        }

        private void BtnSoforSil_Click(object sender, EventArgs e)
        {
            driver = lstSoforListele.SelectedItem as Driver;
            driver.IsDeleted = true;
            Db.Context.KontrolluKaydet(RecordDeleted);
          
        }

        private void BtnSoforGuncelle_Click(object sender, EventArgs e)
        {
            driver = lstSoforListele.SelectedItem as Driver;
            this.MdiBroShow<FormProductUpdate, Driver>(driver);
        }

        private void FormDriverList_Load(object sender, EventArgs e)
        {

        }
    }
}

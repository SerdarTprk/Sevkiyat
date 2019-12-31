using Sevkiyat.UI.Enums;
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
    public partial class FormPayersUpdate : Form
    {
        public static event EventHandler RecordUpdated;
   
        Payer _payer;
        public FormPayersUpdate(Payer payer)
        {
            InitializeComponent();
            _payer = payer;

        }
        private void ComboYukle()
        {
            cbbMusteriType.EnumLoad<PayerType>();
        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            _payer.Address=txtAddress.Text  ;
            _payer.City=txtAddress.Text  ;
            _payer.CompanyName=txtCompanyName.Text ;
            _payer.ContactName=txtContactName.Text  ;
            _payer.Phone=txtPhone.Text ;
            _payer.TypeID=Convert.ToByte(cbbMusteriType.SelectedValue) ;
            _payer.IsActive = chbAktif.Checked;
            Db.Context.KontrolluKaydet(RecordUpdated);
        }

        private void FormPayersUpdate_Load(object sender, EventArgs e)
        {
            ComboYukle();
            txtAddress.Text = _payer.Address.ToString();
            txtAddress.Text = _payer.City.ToString();
            txtCompanyName.Text = _payer.CompanyName.ToString();
            txtContactName.Text = _payer.ContactName.ToString();
            txtPhone.Text = _payer.Phone.ToString();
            cbbMusteriType.SelectedValue = (int)_payer.TypeID;
        }
    }
}

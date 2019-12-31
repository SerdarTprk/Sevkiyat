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
    public partial class FormPayerAdd : Form
    {
        SevkiyatDBEntities _db;
        public event EventHandler KayitGirdim;
        public FormPayerAdd()
        {
            InitializeComponent();
            _db = new SevkiyatDBEntities();
            Load += ComboYukle;
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void ComboYukle(object sender, EventArgs e)
        {
            cbbMusteriType.LoadHemCombo<PayerType>();
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Payer payer = new Payer()
            {
                ID = Guid.NewGuid(),
                City=txtCity.Text,
                CompanyName=txtCompanyName.Text,
                ContactName=txtContactName.Text,
                Address=txtAddress.Text,
                Phone=txtPhone.Text,
                TypeID=Convert.ToByte(cbbMusteriType.SelectedValue)
            };
            _db.Payers.Add(payer);
            _db.KontrolluKaydet(KayitGirdim);
        }
    }
}

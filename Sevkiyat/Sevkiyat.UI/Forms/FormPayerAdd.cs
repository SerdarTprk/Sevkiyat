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

        public static event EventHandler KayitGirdim;
        public FormPayerAdd()
        {
            InitializeComponent();
            Load += ComboYukle;
        }

        private void ComboYukle(object sender, EventArgs e)
        {
            cbbMusteriType.EnumLoad<PayerType>();
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            Payer payer = new Payer()
            {
                ID = Guid.NewGuid(),
                City = txtCity.Text,
                CompanyName = txtCompanyName.Text,
                ContactName = txtContactName.Text,
                Address = txtAddress.Text,
                Phone = txtPhone.Text,
                TypeID = Convert.ToByte(cbbMusteriType.SelectedValue),
                IsActive = true,
                IsDeleted = false,

            };
            Db.Context.Payers.Add(payer);
            Db.Context.KontrolluKaydet(KayitGirdim);
        }

        private void FormPayerAdd_Load(object sender, EventArgs e)
        {

        }
    }
}

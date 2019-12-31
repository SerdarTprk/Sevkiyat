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

namespace Sevkiyat.UI.Forms
{
    public partial class FormProductUpdate : Form
    {
        public static event EventHandler RecordUpdated;
    
        Product _product;
        public FormProductUpdate(Product product)
        {
            InitializeComponent();

            _product = product;
        }
    
        private void ComboLoad()
        {

            cmbProductType.EnumLoad<ProductType>();
            cbbBirimCinsi.EnumLoad<ProductQuantityPerUnit>();
        }
        private void BtnUpdate_Click(object sender, EventArgs e)
        {

            _product.ProductName = txtProductName.Text;
            _product.QuantityPerUnit = Convert.ToInt16(cbbBirimCinsi.SelectedValue);
            _product.ProductType = Convert.ToByte(cmbProductType.SelectedValue);
            _product.Weigh = Convert.ToInt32(txtAgırlık.Text);
            _product.IsActive = chbAktive.Checked;
            Db.Context.KontrolluKaydet(RecordUpdated);
             
        }

        private void FormProductUpdate_Load(object sender, EventArgs e)
        {
            ComboLoad();
            txtProductName.Text = _product.ProductName.ToString();
            txtAgırlık.Text = _product.Weigh.ToString();
            cbbBirimCinsi.SelectedValue = (int)_product.QuantityPerUnit;
            cmbProductType.SelectedValue = (int)_product.ProductType;

        }
    }
}

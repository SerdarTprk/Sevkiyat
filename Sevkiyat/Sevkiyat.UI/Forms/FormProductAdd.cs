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
    public partial class FormProductAdd : Form
    {
        
        public static event EventHandler KayitGirdim;
        public FormProductAdd()
        {
            InitializeComponent();
            Load += ComboYukle;
            
        }
        private void FormProductAdd_Load(object sender, EventArgs e)
        {
            

        }
        private void ComboYukle(object sender, EventArgs e)
        {
            cmbProductType.EnumLoad<ProductType>();
            cbbBirimCinsi.EnumLoad<ProductQuantityPerUnit>();
        }

        private void Btn_add_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                MessageBox.Show("Urun adi boş geçilemez.");
                return;
            }

            Product product = new Product()
            {
                ID = Guid.NewGuid(),
                ProductName = txtProductName.Text,
                QuantityPerUnit = Convert.ToInt16(cbbBirimCinsi.SelectedValue),
                ProductType = Convert.ToByte(cmbProductType.SelectedValue),
                Weigh = Convert.ToInt32(txtAgırlık.Text),
                IsActive = true,
                IsDeleted = false,
           
            };
            Db.Context.Products.Add(product);
            Db.Context.KontrolluKaydet(KayitGirdim);

        }

        private void cmbProductType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

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
        SevkiyatDBEntities _db;
        public event EventHandler KayitGirdim;
        public FormProductAdd()
        {
            InitializeComponent();
            _db = new SevkiyatDBEntities();
            Load += ComboYukle;
        }
        private void FormProductAdd_Load(object sender, EventArgs e)
        {
            

        }
        private void ComboYukle(object sender, EventArgs e)
        {
            cmbProductType.LoadHemCombo<ProductType>();
            cbbBirimCinsi.LoadHemCombo<ProductQuantityPerUnit>();
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
                Weigh = Convert.ToInt32(txtAgırlık.Text)

            };

            _db.Products.Add(product);
            _db.KontrolluKaydet(KayitGirdim);
            


        }
    }
}

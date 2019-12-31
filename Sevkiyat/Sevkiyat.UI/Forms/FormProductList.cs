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
    public partial class FormProductList : Form
    {
        
        Product product;
        public event EventHandler RecordDeleted;
        
        public FormProductList()
        {
            InitializeComponent();
            Load += ListReload;
            FormProductAdd.KayitGirdim += ListReload;
            FormProductUpdate.RecordUpdated += ListReload;
            RecordDeleted += ListReload;

        }
        private void BtnProductAdd_Click(object sender, EventArgs e)
        {
            this.MdiBroShow<FormProductAdd>();

        }
        private void ListReload(object sender, EventArgs e)
        {
            lstProducts.Load<Product>(Db.Context, "ProductName", "ID",u=> u.IsDeleted==false,a=> a.IsActive==true);
        }

        private void BtnProductDelete_Click(object sender, EventArgs e)
        {
            product = (Product)lstProducts.SelectedItem;
            product.IsDeleted = true;
            Db.Context.KontrolluKaydet(RecordDeleted);
        }

        private void BtnProductUpdate_Click(object sender, EventArgs e)
        {
            product = lstProducts.SelectedItem as Product;
            this.MdiBroShow<FormProductUpdate, Product>(product);
        }
        private void FormProductList_Load(object sender, EventArgs e)
        {

        }
    }
}

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
        SevkiyatDBEntities _db;
        Product product;
        public event EventHandler RecordDeleted;
        public FormProductList()
        {
            InitializeComponent();
            _db = new SevkiyatDBEntities();
            Load += ListReload;
        }

        private void BtnProductAdd_Click(object sender, EventArgs e)
        {
            this.MdiBroShow<FormProductAdd>();
            Helper.RecordReload+= ListReload;


        }
        private void ListReload(object sender, EventArgs e)
        {
            //ListeyiYuke();
            lstProducts.Load<Product>(_db, "ProductName", "ID");
            var sonuc = (from p in _db.Products select p).ToList();
            foreach (var item in sonuc)
            {
                ListViewItem lwi = new ListViewItem(item.ProductName);
                lwi.SubItems.Add(item.ProductType.ToString());
                lwi.SubItems.Add(item.QuantityPerUnit.ToString());
                lwi.SubItems.Add(item.Weigh.ToString());
                lsvProduct.Items.Add(lwi);
            }


        }

        private void BtnProductDelete_Click(object sender, EventArgs e)
        {
            // Product ID = (Product)lstProducts.SelectedItem;
            var ID = (Guid)lstProducts.SelectedValue;
            product = (from p in _db.Products where p.ID==(Guid)ID select p).SingleOrDefault();
            _db.Products.Remove(product);
            _db.KontrolluKaydet(RecordDeleted);
            Helper.RecordReload += ListReload;


        }

        private void BtnProductUpdate_Click(object sender, EventArgs e)
        {
            product = lstProducts.SelectedItem as Product;
            FormProductUpdate frm = new FormProductUpdate(product,_db);
            Helper.RecordReload += ListReload;
            frm.MdiParent = this.MdiParent;
            frm.Show();
            frm.RecordUpdated += ListReload;
             
        }

        private void FormProductList_Load(object sender, EventArgs e)
        {

        }
    }
}

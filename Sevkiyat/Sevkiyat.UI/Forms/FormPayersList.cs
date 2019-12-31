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

   
        Payer payer;
        public FormPayersList()
        {
            InitializeComponent();
    
            Load += ListReload;
            FormPayerAdd.KayitGirdim += ListReload;
            FormPayersUpdate.RecordUpdated += ListReload;
        }

        private void btnAddForm_Click(object sender, EventArgs e)
        {
            this.MdiBroShow<FormPayerAdd>();
        }

        private void ListReload(object sender, EventArgs e)
        {
            lstPayer.Load<Payer>(Db.Context, "CompanyName", "ID", u => u.IsDeleted == false, a => a.IsActive == true);
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            payer = lstPayer.SelectedItem as Payer;
            payer.IsDeleted = true;
            Db.Context.KontrolluKaydet(RecordDeleted);
        }

        private void BtnUpdateForm_Click(object sender, EventArgs e)
        {
            payer = lstPayer.SelectedItem as Payer;
            this.MdiBroShow<FormPayersUpdate, Payer>(payer);
        }
    }
}

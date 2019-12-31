using Sevkiyat.UI.Forms;
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
    public partial class FormMain : Form
    { 

        public FormMain()
        {
            InitializeComponent();
            
        }
        public void MainWinMenus()
        {
            if (Session.CurrentRole.RoleName=="Admin")
            {
                
            } 
        }

        private void irsaliyeOlusturToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MdiChildShow<FormWayBillAdd>();
        }

        private void urunEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MdiChildShow<FormProductAdd>();
        }

        private void aracEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MdiChildShow<FormVehicleAdd>();
        }

        private void aracListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MdiChildShow<FormVehicleList>();
        }

        private void soforEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MdiChildShow<FormDriverAdd>();
        }

        private void musteriEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MdiChildShow<FormPayerAdd>();
        }

        private void musteriListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MdiChildShow<FormPayersList>();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
  
        }

        private void tsbKullaniciDegistir_Click(object sender, EventArgs e)
        {
            this.MdiChildShow<FormLogin>();
        }

        private void UrunListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MdiChildShow<FormProductList>();
        }

        private void SoforListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MdiChildShow<FormDriverList>();
        }

        private void KullaniciEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MdiChildShow<FormUserAdd>();
        }

        private void KullaniciListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.MdiChildShow<FormUserList>();
        }
    }
}

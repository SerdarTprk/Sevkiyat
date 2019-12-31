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
    public partial class FormUserUpdate : Form
    {
        User _user;
        List<Role> roles;
        public FormUserUpdate(User user)
        {
            InitializeComponent();
            roles = new List<Role>();
            _user = user;
            
        }

        private void FormUserUpdate_Load(object sender, EventArgs e)
        {
           
            roles = _user.Roles.ToList();
            txtKullaniciAdi.Text = _user.UserName; ;
            cmbRoles.Load<Role>(Db.Context, "RoleName", "ID");
            ListReload();
         
        }
        private void ListReload()
        {
            lstRoles.DataSource = null;
            lstRoles.DataSource = roles;
            lstRoles.DisplayMember = "RoleName";
            lstRoles.ValueMember = "ID";
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            roles.Remove(lstRoles.SelectedItem as Role);
            ListReload();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            roles.Add(cmbRoles.SelectedItem as Role);
            ListReload();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            _user.Roles.Clear();
            foreach (var item in roles)
            {
                _user.Roles.Add(item);
            }
            Db.Context.KontrolluKaydet();
        }
    }
}

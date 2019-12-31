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
    public partial class FormUserAdd : Form
    {
        public event EventHandler RecordEnter;
        SevkiyatDBEntities _db;
        public FormUserAdd()
        {
            InitializeComponent();
            _db = new SevkiyatDBEntities();
        }

        private void FormUserAdd_Load(object sender, EventArgs e)
        {
            lstKullaniciTipi.DataSource = _db.Roles.ToList();
            lstKullaniciTipi.DisplayMember = "RoleName";
            lstKullaniciTipi.ValueMember = "ID";
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            User user = new User()
            {
                ID = Guid.NewGuid(),
                UserName = txtUserName.Text,
                Password = txtPassword.Text
            };
            _db.Users.Add(user);
            foreach ( Role i in lstKullaniciTipi.SelectedItems)
            {
                user.Roles.Add(i);
            }

            _db.KontrolluKaydet(RecordEnter);
        }
    }
}

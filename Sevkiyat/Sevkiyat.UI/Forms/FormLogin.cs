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
    public partial class FormLogin : Form
    {
        User user;
        SevkiyatDBEntities _db;
        public FormLogin()
        {
            InitializeComponent();
            _db = new SevkiyatDBEntities();
            user = new User();
            
        }

        private void btnGir_Click(object sender, EventArgs e)
        {
            var users = _db.Users.ToList();
            if (txtKullanici.Text=="" && txtParola.Text=="")
            {
                MessageBox.Show("Kullanıcı adı ve parola boş geçilemez");
                return;

            }
            Session.CurrentUser = _db.Users.Where(u => u.UserName == txtKullanici.Text && u.Password == txtParola.Text).SingleOrDefault();
            if (Session.CurrentUser==null)
            {
                MessageBox.Show("Kullanıcı Adı veya Parola Hatalı");
                return;
            }
            var sonuc = Session.CurrentUser.Roles.ToList();
            
            lstRoller.DataSource = sonuc;
            lstRoller.DisplayMember = "RoleName";
            lstRoller.ValueMember = "ID";
           
            
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void BtnDevamEt_Click(object sender, EventArgs e)
        {
            Session.CurrentRole = (Role)lstRoller.SelectedItem;
            FormMain frm = new FormMain();
            frm.Show();
            this.Hide();
        }
    }
}

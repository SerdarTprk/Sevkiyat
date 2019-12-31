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
    public partial class FormPasswordChange : Form
    {

        public FormPasswordChange()
        {
            InitializeComponent();


        }

        private void FormPasswordChange_Load(object sender, EventArgs e)
        {

        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (txtOldPassword.Text != Session.CurrentUser.Password.ToString())
            {
                MessageBox.Show("Eski şifre hatalı");
                return;
            }
            if (txtNewPassword2.Text == Session.CurrentUser.Password.ToString())
            {
                MessageBox.Show("Yeni şifre eski şifre ile aynı olamaz");
                return;


            }
            User user = (from u in Db.Context.Users where u.ID == Session.CurrentUser.ID select u).SingleOrDefault();
            user.Password = txtNewPassword2.Text;
            Db.Context.KontrolluKaydet();


        }
    }
}

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
    public partial class FormUserList : Form
    {
      
        User user;
        public FormUserList()
        {
            InitializeComponent();
       

        }

        private void FormUserList_Load(object sender, EventArgs e)
        {
            Payer payer = new Payer();
            lstUsers.Load<User>(Db.Context, "UserName", "ID", u => u.IsActive == true, a => a.IsDeleted == false);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            this.MdiBroShow<FormUserList>();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            user = (User)lstUsers.SelectedItem;
            user.IsDeleted = true;
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void BtnUpdate_Click_1(object sender, EventArgs e)
        {
            user = lstUsers.SelectedItem as User;
            this.MdiBroShow<FormUserUpdate,User>(user);
        }
    }
}

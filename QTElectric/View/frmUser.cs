using QTElectric.Common;
using QTElectric.DAO;
using QTElectric.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QTElectric.View
{
    public partial class frmUser : Form
    {
        public frmUser()
        {
            InitializeComponent();
            Load();

        }
        bool check = true;
        public void Insert()
        {
            User u = new User();
            u.user_name = txtUserName.Text;
            u.password = HashPassword.CreateMD5(txtPassword.Text);
            u.full_name = txtName.Text;
            u.gender = chkGender.Checked == true ? true : false;
            u.status = chkStatus.Checked == true ? true : false;
            u.email = txtEmail.Text;
            u.mobile = (txtPhone.Text);
            u.date_create = DateTime.Now;
            int result = UserDAO.Instance.Insert(u);
            if (result > 0)
            {
                MessageBox.Show("Insert succes", "Add New");
                Load();
                txtUid.Text = txtUserName.Text = txtName.Text = txtPhone.Text = txtEmail.Text = "";
                chkGender.Checked = chkStatus.Checked = false;
                check = true;
                button2.Text = "Lưu";
            }
        }
        public void Load()
        {
            dvgUser.DataSource = UserDAO.Instance.Get();
        }
        public void Update()
        {
            User u = new User();
            u.u_id = int.Parse(txtUid.Text);
            u.user_name = txtUserName.Text;
            u.password = txtPassword.Text == null ? lblpasshide.Text : HashPassword.CreateMD5(txtPassword.Text);
            u.status = chkStatus.Checked == true ? true : false;
            u.gender = chkGender.Checked == true ? true : false;
            u.full_name = txtName.Text;
            u.date_create = DateTime.Now;
            u.mobile = txtPhone.Text;
            u.email = txtEmail.Text;
            int result = UserDAO.Instance.Update(u);
            if (result > 0)
            {
                MessageBox.Show("Update success", "Update");
                Load();
            }
        }
        public void Delete()
        {
            int id = int.Parse(txtUid.Text);
            int result = UserDAO.Instance.Delete(id);
            if (result > 0)
            {
                MessageBox.Show("Delete success", "Delete");
                Load();
            }
        }
        public void Search(string search)
        {
            dvgUser.DataSource = UserDAO.Instance.Search(search);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (check)
            {
                Insert();
            }
            else
            {
                Update();
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (check)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa");
            }
            else
            {
                if (MessageBox.Show("Bạn có muốn xóa?", "Xóa", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    Delete();
                    button2.Text = "Lưu";
                    txtUid.Text = txtUserName.Text = txtName.Text = txtPhone.Text = txtEmail.Text = "";
                    chkGender.Checked = chkStatus.Checked = false;
                    check = true;
                }
            }

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Load();
            button2.Text = "Lưu";
            txtUid.Text = txtUserName.Text = txtPassword.Text = txtName.Text = txtPhone.Text = txtEmail.Text = "";
            chkGender.Checked = chkStatus.Checked = false;
            check = true;
        }

        private void dvgUser_SelectionChanged(object sender, EventArgs e)
        {
            if (dvgUser.SelectedRows.Count > 0)
            {
                check = false;
                txtUid.Text = dvgUser.SelectedCells[0].Value.ToString();
                txtUserName.Text = dvgUser.SelectedCells[1].Value.ToString();
                lblpasshide.Text = dvgUser.SelectedCells[2].Value.ToString();
                txtName.Text = dvgUser.SelectedCells[6].Value.ToString();
                txtPhone.Text = dvgUser.SelectedCells[3].Value.ToString();
                txtEmail.Text = dvgUser.SelectedCells[4].Value.ToString();
                chkGender.Checked = dvgUser.SelectedCells[7].Value.ToString() == "True";
                chkStatus.Checked = dvgUser.SelectedCells[5].Value.ToString() == "True";
                button2.Text = "Sửa";
            }
        }

        private void dvgUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            //private void btnSearch_Click(object sender, EventArgs e)
            //{

            //}
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String txtSearch = "";
            if (txtName.Text.Length > 0)
            {
                txtSearch = txtName.Text;
                Search(txtSearch);
                return;
            }
            else if (txtUserName.Text.Length > 0)
            {
                txtSearch = txtUserName.Text;
                Search(txtSearch);
                return;
            }
            else if (txtEmail.Text.Length > 0)
            {
                txtSearch = txtEmail.Text;
                Search(txtSearch);
                return;
            }
            else if (txtPhone.Text.Length > 0)
            {
                txtSearch = txtPhone.Text;
                Search(txtSearch);
                return;
            }
            else
            {
                MessageBox.Show("Mời bạn nhập từ khóa!");
                return;
            }
        }
    }
}

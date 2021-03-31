﻿using QTElectric.Common;
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

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {

        }
        public void Insert()
        {
            User u = new User();
            u.user_name = txtUserName.Text;
            u.password = HashPassword.CreateMD5(txtPassword.Text);
            u.full_name = txtName.Text;
            u.gender = chkGender.Checked == true ? true : false;
            u.status = chkStatus.Checked == true ? true : false;
            u.email = txtEmail.Text;
            u.mobile = char.Parse(txtPhone.Text);
            u.date_create = DateTime.Now;
            int result = UserDAO.Instance.Insert(u);
            if (result > 0)
            {
                MessageBox.Show("Insert succes", "Add New");
                Load();
            }
        }
        public void Load()
        {
            dvgUser.DataSource = UserDAO.Instance.Get();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Insert();
        }

        private void dvgUser_Click(object sender, EventArgs e)
        {

            txtUid.Text = dvgUser.SelectedCells[0].Value.ToString();
            txtUserName.Text = dvgUser.SelectedCells[1].Value.ToString();
            txtName.Text = dvgUser.SelectedCells[2].Value.ToString();
            txtPhone.Text = dvgUser.SelectedCells[3].Value.ToString();
            txtEmail.Text = dvgUser.SelectedCells[4].Value.ToString();
            chkGender.Checked = dvgUser.SelectedCells[7].Value.ToString() == "True";
            chkStatus.Checked = dvgUser.SelectedCells[5].Value.ToString() == "True";

        }
    }
}

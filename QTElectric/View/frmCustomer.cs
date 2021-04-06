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
    public partial class frmCustomer : Form
    {
        public frmCustomer()
        {
            InitializeComponent();
            Load();
        }
        bool check = true;
        public void Insert()
        {
            Customer cus = new Customer();
            cus.fullName = txtCusfullname.Text;
            cus.mobile = (txtCusphone.Text);
            cus.address = txtCusaddress.Text;
            cus.gender = cbCusgender.Checked == true ? true : false;
            cus.email = txtCusemail.Text;
            cus.status = cbCusstatus.Checked == true ? true : false;
            cus.date_create = DateTime.Now;
            int result = CustomerDAO.Instance.InsertCustomer(cus);
            if (result > 0)
            {
                MessageBox.Show("Add New Success");
                Load();
                check = true;
                btnSave.Text = "Lưu";
            }
        }
        public void Load()
        {
            dvgCus.DataSource = CustomerDAO.Instance.Get();
        }
        public void Update()
        {
            Customer cus = new Customer();
            cus.cus_id = int.Parse(txtCusid.Text);
            cus.fullName = txtCusfullname.Text;
            cus.mobile = txtCusphone.Text;
            cus.email = txtCusemail.Text;
            cus.address = txtCusaddress.Text;
            cus.date_create = DateTime.Now;
            cus.gender = cbCusgender.Checked == true ? true : false;
            cus.status = cbCusstatus.Checked == true ? true : false;
            int result = CustomerDAO.Instance.Update(cus);
            if (result > 0)
            {
                MessageBox.Show("Update success", "Update");
                Load();
            }
        }
        public void Delete()
        {
            int id = int.Parse(txtCusid.Text);
            int result = CustomerDAO.Instance.Delete(id);
            if (result > 0)
            {
                MessageBox.Show("Delete success", "Delete");
                Load();
                txtCusid.Text = txtCusfullname.Text = txtCusphone.Text = txtCusemail.Text = txtCusaddress.Text = "";
                cbCusgender.Checked = cbCusstatus.Checked = false;
            }
            {

            }
        }
        public void Search(string search)
        {
            dvgCus.DataSource = CustomerDAO.Instance.Search(search);
        }
        //private void button1_Click(object sender, EventArgs e)
        //{
        //    if (!ValidateChildren())
        //    {
        //        MessageBox.Show("vui lòng điền");
        //    }
        //    else
        //    {
        //        Insert();
        //    }

        //}

        private void txtCusfullname_Validating(object sender, CancelEventArgs e)
        {
            if (txtCusfullname.Text == "")
            {
                lblerfullname.Text = "* Vui lòng không để trống";
                return;
            }
            lblerfullname.Text = "";
        }

        private void txtCusemail_Validating(object sender, CancelEventArgs e)
        {
            if (txtCusemail.Text == "")
            {
                lbleremail.Text = "* Vui lòng không để trống";
                return;
            }
            lbleremail.Text = "";
        }

        private void txtCusphone_Validating(object sender, CancelEventArgs e)
        {
            if (txtCusphone.Text == "")
            {
                lblerphone.Text = "* Vui lòng không để trống";
                return;
            }
            lblerphone.Text = "";
        }

        private void txtCusaddress_Validating(object sender, CancelEventArgs e)
        {
            if (txtCusaddress.Text == "")
            {
                lbleraddress.Text = "* Vui lòng không để trống";
                return;
            }
            lbleraddress.Text = "";
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            Load();
            btnSave.Text = "Lưu";
            txtCusid.Text = txtCusfullname.Text = txtCusphone.Text = txtCusemail.Text = txtCusaddress.Text = "";
            cbCusgender.Checked = cbCusstatus.Checked = false;
            check = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (check)
            {
                //if (ValidateChildren())
                //{
                //    MessageBox.Show("vui lòng điền");
                //}
                //else
                //{
                    Insert();
                //}
            }
            else
            {
                Update();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
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
                    btnSave.Text = "Lưu";
                    txtCusid.Text = txtCusfullname.Text = txtCusphone.Text = txtCusemail.Text = txtCusaddress.Text = "";
                    cbCusgender.Checked = cbCusstatus.Checked = false;
                    check = true;
                }
            }


        }

        private void dvgCus_SelectionChanged(object sender, EventArgs e)
        {
            if (dvgCus.SelectedRows.Count > 0)
            {
                btnSave.Text = "Sửa";
                txtCusid.Text = dvgCus.SelectedCells[0].Value.ToString();
                txtCusfullname.Text = dvgCus.SelectedCells[1].Value.ToString();
                txtCusphone.Text = dvgCus.SelectedCells[2].Value.ToString();
                txtCusemail.Text = dvgCus.SelectedCells[3].Value.ToString();
                txtCusaddress.Text = dvgCus.SelectedCells[4].Value.ToString();
                cbCusgender.Checked = dvgCus.SelectedCells[5].Value.ToString() == "True" ? true : false;
                cbCusstatus.Checked = dvgCus.SelectedCells[6].Value.ToString() == "True" ? true : false;
                check = false;
            }
        }

        private void dvgCus_DoubleClick(object sender, EventArgs e)
        {
            string cusname = txtCusfullname.Text;
            frmOrder frmOrder = new frmOrder(cusname);
            frmOrder.ShowDialog();
            frmOrder.WindowState = FormWindowState.Maximized;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String txtSearch = "";
            if(txtCusfullname.Text.Length > 0)
            {
                txtSearch = txtCusfullname.Text;
                Search(txtSearch);
                return;
            }
            else if(txtCusemail.Text.Length > 0)
            {
                txtSearch = txtCusemail.Text;
                Search(txtSearch);
                return;
            }
            else if (txtCusphone.Text.Length > 0)
            {
                txtSearch = txtCusphone.Text;
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

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
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
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
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("vui lòng điền");
            }
            else
            {
                Insert();
            }

        }

        private void txtCusfullname_Validating(object sender, CancelEventArgs e)
        {
            if (txtCusfullname.Text == "")
            {
                lblerfullname.Text = "* Vui lòng không để trống";
                return;
            }
            lblerfullname.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void txtCusemail_Validating(object sender, CancelEventArgs e)
        {
            if (txtCusemail.Text == "")
            {
                lbleremail.Text = "* Vui lòng không để trống";
                return;
            }
            else
            {
                lbleremail.Text = "";
            }
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
    }
}

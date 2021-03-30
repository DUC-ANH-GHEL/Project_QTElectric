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
    public partial class frmCategory : Form
    {
        public frmCategory()
        {
            InitializeComponent();
            load();
            CenterToScreen();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn sửa không?", "Sửa", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Update();
            }

        }
        public void load()
        {
            dvgCategory.DataSource = CategoryDAO.Instance.Categories();
        }
        public void AddNew()
        {
            if (txtCname.Text == "")
            {
                txtCerror.Text = "* Vui lòng không để trống";
            }
            else
            {
                Category c = new Category();
                c.cat_name = txtCname.Text;
                c.status = cbCstatus.Checked == true ? true : false;
                c.date_ceate = DateTime.Now;
                int result = CategoryDAO.Instance.InsertCategory(c);
                if (result > 0)
                {

                    MessageBox.Show("Insert Success");
                    load();
                    txtCname.Text = "";
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AddNew();
        }

        private void dvgCategory_SelectionChanged(object sender, EventArgs e)
        {
            txtCid.Text = dvgCategory.SelectedCells[0].Value.ToString();
            txtCname.Text = dvgCategory.SelectedCells[1].Value.ToString();
            cbCstatus.Checked = dvgCategory.SelectedCells[2].Value.ToString().ToLower() == "true";
        }
        public void Update()
        {
            Category c = new Category();
            c.cat_id = int.Parse(txtCid.Text);
            c.cat_name = txtCname.Text;
            c.status = cbCstatus.Checked == true ? true : false;
            c.date_ceate = DateTime.Now;
            int result = CategoryDAO.Instance.UpdateCategory(c);
            if (result <= 0)
            {
                btnCsave.Visible = false;
            }
            else
            {
                MessageBox.Show("Update success");
                load();
            }
        }
        public void Delete()
        {
            int id = int.Parse(txtCid.Text);
            int result = CategoryDAO.Instance.DeleteCategory(id);
            if (result > 0)
            {
                MessageBox.Show("Delete success");
                load();
            }
            else
            {
                MessageBox.Show("Delete fail");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa?", "Xóa", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Delete();
            }
        }
    }
}

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
    public partial class frmType : Form
    {
        bool edit;
        public frmType()
        {
            InitializeComponent();
            load();
            loadCat();
            CenterToScreen();
        }
        public void load()
        {
            dgvType.DataSource = TypeDAO.Instance.Types();
        }
        public void loadCat()
        {
            cbxCat.DataSource = CategoryDAO.Instance.Categories();
            cbxCat.ValueMember = "cat_id";
            cbxCat.DisplayMember = "cat_name";
        }
        public void AddNew()
        {
            if (txtName.Text == "")
            {
                txtError.Text = "* Vui lòng không để trống";
            }
            else
            {
                DTO.Types c = new DTO.Types();
                c.type_name = txtName.Text;
                c.cat_id = int.Parse(cbxCat.SelectedValue.ToString());
                c.status = chkStatus.Checked == true ? true : false;
                c.date_create = DateTime.Now;
                int result = TypeDAO.Instance.Insert_Types(c);
                if (result > 0)
                {
                    MessageBox.Show("Insert Success");
                    load();
                    txtName.Text = "";
                    edit = false;
                    btnSave.Text = "Lưu";
                }
            }
        }
        public void Update()
        {
            DTO.Types c = new DTO.Types();
            c.type_id = int.Parse(txtId.Text);
            c.type_name = txtName.Text;
            c.cat_id = int.Parse(cbxCat.SelectedValue.ToString());
            c.status = chkStatus.Checked == true ? true : false;
            c.date_create = DateTime.Now;
            int result = TypeDAO.Instance.Update_Types(c);
            if (result <= 0)
            {
                btnSave.Visible = false;
            }
            else
            {
                MessageBox.Show("Update success");
                load();
            }
        }
        public void Delete()
        {
            int id = int.Parse(txtId.Text);
            int result = TypeDAO.Instance.Delete_Types(id);
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
        private void btnAddNew_Click_1(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtName.Text = "";
            cbxCat.SelectedIndex = 0;
            chkStatus.Checked = false;
            edit = false;
            btnSave.Text = "Lưu";
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (edit)
            {
                btnSave.Text = "Sửa";
                if (MessageBox.Show("Bạn có muốn sửa không?", "Sửa", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Update();
                }
            }
            else
            {
                AddNew();
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn xóa?", "Xóa", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                Delete();
            }
        }

        private void dgvType_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvType.SelectedRows.Count > 0)
            {
                txtId.Text = dgvType.SelectedCells[0].Value.ToString();
                txtName.Text = dgvType.SelectedCells[1].Value.ToString();
                cbxCat.SelectedValue = dgvType.SelectedCells[2].Value.ToString();
                chkStatus.Checked = dgvType.SelectedCells[3].Value.ToString() == "True";
                edit = true;
            }
        }
    }
}

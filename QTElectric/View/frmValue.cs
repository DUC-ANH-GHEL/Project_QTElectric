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
    public partial class frmValue : Form
    {
        bool edit;
        public frmValue()
        {
            InitializeComponent();
            load();
            loadType();
            CenterToScreen();
        }
        public void load()
        {
            dgvValue.DataSource = ValueDAO.Instance.Value();
        }
        public void loadType()
        {
            cbxType.DataSource = TypeDAO.Instance.Types();
            cbxType.ValueMember = "type_id";
            cbxType.DisplayMember = "type_name";
        }
        public void AddNew()
        {
            if (txtName.Text == "")
            {
                txtError.Text = "* Vui lòng không để trống";
            }
            else
            {
                Value c = new Value();
                c.val_name = txtName.Text;
                c.type_id = int.Parse(cbxType.SelectedValue.ToString());
                c.status = chkStatus.Checked == true ? true : false;
                c.date_ceate = DateTime.Now;
                int result = ValueDAO.Instance.InsertValue(c);
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
            Value c = new Value();
            c.val_id = int.Parse(txtId.Text);
            c.val_name = txtName.Text;
            c.type_id = int.Parse(cbxType.SelectedValue.ToString());
            c.status = chkStatus.Checked == true ? true : false;
            c.date_ceate = DateTime.Now;
            MessageBox.Show(c.val_name);
            int result = ValueDAO.Instance.UpdateValue(c);
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
            int result = ValueDAO.Instance.DeleteValue(id);
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
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            txtId.Text = "";
            txtName.Text = "";
            cbxType.SelectedIndex = 0;
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

        private void dgvValue_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvValue.SelectedRows.Count > 0)
            {
                txtId.Text = dgvValue.SelectedCells[0].Value.ToString();
                txtName.Text = dgvValue.SelectedCells[1].Value.ToString();
                cbxType.SelectedValue = dgvValue.SelectedCells[2].Value.ToString();
                chkStatus.Checked = dgvValue.SelectedCells[3].Value.ToString() == "True";
                edit = true;

            }
        }
    }
}

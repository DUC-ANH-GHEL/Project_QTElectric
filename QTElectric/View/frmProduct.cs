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
    public partial class frmProduct : Form
    {
        bool edit;
        public frmProduct()
        {
            InitializeComponent();
            load();
            LoadCat();
            LoadType();
            LoadValue();
            LoadDiff();
        }
        private void LoadCat()
        {
            DataTable result = CategoryDAO.Instance.Categories();
            cbCa.DataSource = result;
            cbCa.DisplayMember = "cat_name";
            cbCa.ValueMember = "cat_id";
        }
        private void LoadType()
        {
            if (cbCa.SelectedValue != null)
            {
                int cat_id = (int)cbCa.SelectedValue;
                DataTable result = TypeDAO.Instance.GetbyCat(cat_id);
                if (result.Rows.Count > 0)
                {
                    cbType.DataSource = result;
                    cbType.DisplayMember = "type_name";
                    cbType.ValueMember = "type_id";
                }
            }
        }
        private void LoadValue()
        {

            if (cbType.SelectedValue != null)
            {

                int type_id = (int)cbType.SelectedValue;
                cbValue.DataSource = ValueDAO.Instance.GetbyType(type_id);
                cbValue.DisplayMember = "val_name";
                cbValue.ValueMember = "val_id";
            }

        }
        private void LoadDiff()
        {
            if (cbValue.SelectedValue != null)
            {
                int val_id = (int)cbValue.SelectedValue;

                cbDiff.DataSource = DifferencedDAO.Instance.GetbyValues(val_id);
                cbDiff.DisplayMember = "diff_name";
                cbDiff.ValueMember = "diff_id";
            }
        }
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            load();
            txtSttbom.Text = "";
            cbxStatus.Checked = false;
            edit = false;
            btnPsave.Text = "Lưu";
        }
        public void load()
        {
            dvgProduct.DataSource = ProductDAO.Instance.Get();
        }
        public void AddNew()
        {
            //if (txtCname.Text == null)
            //{
            //    MessageBox.Show("* Vui lòng điền");
            //}
            //else
            //{
            Product p = new Product();
            p.cat_id = (int)cbCa.SelectedValue;
            p.type_id = (int)cbType.SelectedValue;
            p.val_id = (int)cbValue.SelectedValue;
            p.diff_id = (int)cbDiff.SelectedValue; // if dbDiff.selectedValue is null , it will have able to push execption, however diff_id not allow null so i think don't need carefully 
            p.status = cbxStatus.Checked == true ? true : false;
            p.date_create = DateTime.Now;
            object result = ProductDAO.Instance.Insert(p);
            if (result != null)
            {
                MessageBox.Show("Insert Success");
                load();
                edit = false;
                btnPsave.Text = "Lưu";
            }
            //}
        }




        public void Update()
        {
            Product p = new Product();
            p.pro_id = int.Parse(txtSttbom.Text);
            p.cat_id = (int)cbCa.SelectedValue;
            p.type_id = (int)cbType.SelectedValue;
            p.val_id = (int)cbValue.SelectedValue;
            p.diff_id = (int)cbDiff.SelectedValue;
            p.status = cbxStatus.Checked == true ? true : false;
            p.date_create = DateTime.Now;
            int result = ProductDAO.Instance.Update(p);
            if (result <= 0)
            {
                btnPsave.Visible = false;
            }
            else
            {
                MessageBox.Show("Update success");
                load();
            }
        }
        public void Delete()
        {
            int id = int.Parse(txtSttbom.Text);
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
        public void Search(string search)
        {
            dvgProduct.DataSource = CategoryDAO.Instance.Search(search);
        }


        private void dvgCategory_SelectionChanged(object sender, EventArgs e)
        {
            if (dvgProduct.SelectedRows.Count > 0)
            {
                btnPsave.Text = "Sửa";
                txtSttbom.Text = dvgProduct.SelectedCells[0].Value.ToString();
                cbCa.SelectedValue = dvgProduct.SelectedCells[1].Value.ToString();
                cbType.SelectedValue = dvgProduct.SelectedCells[2].Value.ToString();
                cbValue.SelectedValue = dvgProduct.SelectedCells[3].Value.ToString();
                cbDiff.SelectedValue = dvgProduct.SelectedCells[4].Value.ToString();
                cbxStatus.Checked = dvgProduct.SelectedCells[5].Value.ToString() == "True";
                edit = true;
            }
        }

        //private void btnSearch_Click(object sender, EventArgs e)
        //{
        //    string txtSearch = "";
        //    if (txtCname.Text.Length > 0)
        //    {
        //        txtSearch = txtCname.Text;
        //        Search(txtSearch);
        //        return;
        //    }
        //    else
        //    {
        //        MessageBox.Show("Mời bạn nhập từ khóa!");
        //        return;
        //    }
        //}

        private void btnPsave_Click(object sender, EventArgs e)
        {
            if (edit)
            {
                btnPsave.Text = "Sửa";
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
            if (!edit)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm cần xóa");
            }
            else
            {
                if (MessageBox.Show("Bạn có muốn xóa?", "Xóa", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    Delete();
                    txtSttbom.Text = "";
                    edit = false;
                    btnPsave.Text = "Lưu";
                }
            }
        }

        private void cbCa_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadType();
            LoadValue();
            LoadDiff();
        }

        private void cbCa_SelectedValueChanged(object sender, EventArgs e)
        {


        }

        private void cbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadValue();
            LoadDiff();
        }

        private void cbType_SelectedValueChanged(object sender, EventArgs e)
        {
            //LoadType();
        }

        private void cbValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDiff();
        }

        private void cbValue_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void cbDiff_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbDiff_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void dvgProduct_Click(object sender, EventArgs e)
        {
            //if (dvgProduct.SelectedRows.Count > 0)
            //{
            //    btnPsave.Text = "Sửa";
            //    txtSttbom.Text = dvgProduct.SelectedCells[0].Value.ToString();
            //    cbCa.SelectedValue = dvgProduct.SelectedCells[1].Value.ToString();
            //    cbType.SelectedValue = dvgProduct.SelectedCells[2].Value.ToString();
            //    cbValue.SelectedValue = dvgProduct.SelectedCells[3].Value.ToString();
            //    cbDiff.SelectedValue = dvgProduct.SelectedCells[4].Value.ToString();
            //    cbxStatus.Checked = dvgProduct.SelectedCells[5].Value.ToString() == "True";
            //    edit = true;
            //}
        }

        private void dvgProduct_SelectionChanged(object sender, EventArgs e)
        {
            if (dvgProduct.SelectedRows.Count > 0)
            {
                btnPsave.Text = "Sửa";
                txtSttbom.Text = dvgProduct.SelectedCells[0].Value.ToString();
                cbCa.SelectedValue = dvgProduct.SelectedCells[1].Value.ToString();
                cbType.SelectedValue = dvgProduct.SelectedCells[2].Value.ToString();
                cbValue.SelectedValue = dvgProduct.SelectedCells[3].Value.ToString();
                cbDiff.SelectedValue = dvgProduct.SelectedCells[4].Value.ToString();
                cbxStatus.Checked = dvgProduct.SelectedCells[5].Value.ToString() == "True";
                edit = true;
            }
        }
    }
}

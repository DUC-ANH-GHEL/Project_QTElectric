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
    public partial class frmDifferenced : Form
    {
        public frmDifferenced()
        {
            InitializeComponent();
            Loadcbx();
            Load();
        }
        bool check = true;
        public void Loadcbx()
        {
            DataTable result = DifferencedDAO.Instance.GetValues();
            cbxValue.DataSource = result;
            cbxValue.DisplayMember = "val_name";
            cbxValue.ValueMember = "val_id";
        }

        private void cbxValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            MessageBox.Show(cbxValue.Text);
        }
        public void Load()
        {
            dvgDiff.DataSource = DifferencedDAO.Instance.Get();
        }
        public void Insert()
        {
            Differenced diff = new Differenced()
            {
                diff_name = txtDname.Text,
                date_create = DateTime.Now,
                status = cbDstatus.Checked == true ? true : false,
                val_id = (int)cbxValue.SelectedValue
            };
            int result = DifferencedDAO.Instance.Insert(diff);
            if (result > 0)
            {
                MessageBox.Show("Insert success", "Add New");
                Load();
                check = true;
                button2.Text = "Lưu";
            }
        }
        public void Update()
        {
            Differenced diff = new Differenced()
            {

                diff_id = int.Parse(txtDid.Text),
                diff_name = txtDname.Text,
                date_create = DateTime.Now,
                status = cbDstatus.Checked == true ? true : false,
                val_id = (int)cbxValue.SelectedValue
            };
            int result = DifferencedDAO.Instance.Update(diff);
            if (result > 0)
            {
                MessageBox.Show("Update success", "Update");
                Load();
            }
        }
        public void Delete()
        {
            int id = int.Parse(txtDid.Text);
            int result = DifferencedDAO.Instance.Delete(id);
            if (result > 0)
            {
                MessageBox.Show("Delete success", "Delete");
                Load();
            }
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

        private void button1_Click(object sender, EventArgs e)
        {
            button2.Text = "Lưu";
            txtDid.Text = txtDname.Text = "";
            cbDstatus.Checked = false;
            check = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Delete();
            txtDid.Text = txtDname.Text = "";
            cbDstatus.Checked = false;
            check = true;
            button2.Text = "Lưu";
        }

        private void dvgDiff_SelectionChanged(object sender, EventArgs e)
        {
            if (dvgDiff.SelectedRows.Count > 0)
            {
                button2.Text = "Sửa";
                txtDid.Text = dvgDiff.SelectedCells[0].Value.ToString();
                txtDname.Text = dvgDiff.SelectedCells[1].Value.ToString();
                cbxValue.SelectedValue = dvgDiff.SelectedCells[2].Value.ToString();
                cbDstatus.Checked = dvgDiff.SelectedCells[3].Value.ToString() == "True" ? true : false;
                check = false;
            }
        }
    }
}

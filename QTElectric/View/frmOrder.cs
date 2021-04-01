using QTElectric.DAO;
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
    public partial class frmOrder : Form
    {
        public frmOrder()
        {
            InitializeComponent();
        }
        private void LoadCat()
        {
            cbxCat.DataSource = CategoryDAO.Instance.Categories();
            cbxCat.DisplayMember = "cat_name";
            cbxCat.ValueMember = "cat_id";
        }
        private void LoadType()
        {
            cbxType.DataSource = TypeDAO.Instance.Types();
            cbxType.DisplayMember = "type_name";
            cbxType.ValueMember = "type_id";
        }
        private void LoadValue()
        {
            cbxValue.DataSource = ValueDAO.Instance.Value();
            cbxValue.DisplayMember = "val_name";
            cbxValue.ValueMember = "val_id";
        }
        private void LoadDiff()
        {
            cbxDiff.DataSource = DifferencedDAO.Instance.Get();
            cbxDiff.DisplayMember = "diff_name";
            cbxDiff.ValueMember = "diff_id";
            MessageBox.Show("diff");
        }

        private void frmOrder_Load_1(object sender, EventArgs e)
        {
            LoadCat();
            LoadType();
            LoadValue();
            LoadDiff();
        }
    }
}

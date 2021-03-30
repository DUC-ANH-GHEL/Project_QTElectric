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
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Category c = new Category();
            c.cat_name = txtCname.Text;
            c.status = cbCstatus.Checked == true ? true : false;
            c.date_ceate = DateTime.Now;
            int result = CategoryDAO.Instance.InsertCategory(c);
            if (result > 0)
            {
                MessageBox.Show("Insert Success");
            }
        }
        public void load()
        {
            dvgCategory.DataSource = CategoryDAO.Instance.Categories();
        }


    }
}

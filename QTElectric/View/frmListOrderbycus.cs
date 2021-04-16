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
    public partial class frmListOrderbycus : Form
    {
        private List<Order> listo;
        public frmListOrderbycus(List<Order> list)
        {
            InitializeComponent();
            dvgListOrDetail.DataSource = list;
            this.listo = list;
        }

        private void dvgListOrDetail_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dvgListOrDetail_Click(object sender, EventArgs e)
        {
            Order orderbycus = new Order()
            {
                order_id = (int)dvgListOrDetail.SelectedCells[0].Value,
                order_name = dvgListOrDetail.SelectedCells[1].Value.ToString(),
                cus_id = (int)dvgListOrDetail.SelectedCells[2].Value,
                status = (bool)(dvgListOrDetail.SelectedCells[3].Value),
                date_create = (DateTime)dvgListOrDetail.SelectedCells[4].Value

            };
            frmOrder order = new frmOrder(orderbycus);
            order.ShowDialog();
        }
    }
}

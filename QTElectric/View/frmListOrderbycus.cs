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
            Orderbycus orderbycus = new Orderbycus()
            {
                or_id = (int)dvgListOrDetail.SelectedCells[0].Value,
                or_name = dvgListOrDetail.SelectedCells[1].Value.ToString(),
                cus_id = (int)dvgListOrDetail.SelectedCells[2].Value,
                status = (bool)(dvgListOrDetail.SelectedCells[3].Value),
                date_create = (DateTime)dvgListOrDetail.SelectedCells[4].Value

            };
            DataTable result = OrderDetailbyIdDAO.Instance.getOrderDetailbyId((int)dvgListOrDetail.SelectedCells[0].Value);
            OrderDetailbyId orderDetailbyId = new OrderDetailbyId()
            {
                fullName = (string)result.Rows[0]["fullName"],
                cat_name = (string)result.Rows[0]["cat_name"],
                type_name = (string)result.Rows[0]["type_name"],
                diff_name = (string)result.Rows[0]["diff_name"],
                val_name = (string)result.Rows[0]["val_name"],
                amount_in = (int)result.Rows[0]["amount_in"],
                date_create = (DateTime)result.Rows[0]["date_create"]
            };
            frmOrder order = new frmOrder(orderDetailbyId);
            order.ShowDialog();
        }
    }
}

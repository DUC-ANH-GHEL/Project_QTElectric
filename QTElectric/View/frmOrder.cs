using QRCoder;
using QTElectric.DAO;
using QTElectric.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BarcodeLib;
using Aspose.BarCode.Generation;
using Microsoft.VisualBasic;
using System.IO;
using System.Drawing.Printing;

namespace QTElectric.View
{
    public partial class frmOrder : Form
    {
        private List<OrderDetailbyId> listModelOrderDetail = new List<OrderDetailbyId>();
        private int cat_id;
        private int type_id;
        private int val_id;
        private int diff_id;
        private Order orderbyId;
        private int or_id;
        private int cus_id;
        private string fullName;
        private string or_name;
        private DateTime date_Order;
        private bool edit;

        BarcodeLib.Barcode code128;
        public frmOrder(Order order)
        {
            InitializeComponent();
            loadDataOrder(order);
            Load();
        }
        public frmOrder(Customer cus)
        {
            InitializeComponent();
            fullName = cus.fullName;
            cus_id = cus.cus_id;
            date_Order = DateTime.Now;
            Load();
        }
        private void Load()
        {
            LoadCat();
            LoadType();
            LoadValue();
            LoadDiff();
            code128 = new Barcode();
            txtcusname.Text = fullName;
            txtDateNow.Text = date_Order.ToString("dd/MM/yyyy");
        }
        private void loadDataOrder(Order order)
        {
            this.orderbyId = order;
            or_id = orderbyId.order_id;
            DataTable orderDetail = OrderDetailbyIdDAO.Instance.getOrderDetailbyId(orderbyId.order_id);
            for (int i = 0; i < orderDetail.Rows.Count; i++)
            {
                OrderDetailbyId orderDetailbyId = new OrderDetailbyId()
                {
                    or_detail_id = (int)orderDetail.Rows[i]["or_detail_id"],
                    pro_id = (int)orderDetail.Rows[i]["pro_id"],
                    cat_name = (string)orderDetail.Rows[i]["cat_name"].ToString(),
                    type_name = (string)orderDetail.Rows[i]["type_name"],
                    diff_name = (string)orderDetail.Rows[i]["diff_name"],
                    val_name = (string)orderDetail.Rows[i]["val_name"],
                    amount_in = (int)orderDetail.Rows[i]["amount_in"],
                    amount_out = (int)orderDetail.Rows[i]["amount_out"],
                    status = (int)orderDetail.Rows[i]["status"],
                    date_create = (DateTime)orderDetail.Rows[i]["date_create"]
                };
                listModelOrderDetail.Add(orderDetailbyId);
            }
            LoadDGVOrder(listModelOrderDetail);

            DataTable infoOrder = OrderDetailbyIdDAO.Instance.getInfobyId(orderbyId.order_id);
            for (int i = 0; i < infoOrder.Rows.Count; i++)
            {
                cus_id = (int)infoOrder.Rows[i]["cus_id"];
                fullName = (string)infoOrder.Rows[i]["fullName"];
                or_name = (string)infoOrder.Rows[i]["or_name"];
                date_Order = (DateTime)infoOrder.Rows[i]["date_create"];
            }
            txtOrderName.Text = or_name;
        }
        private void LoadDGVOrder(List<OrderDetailbyId> list)
        {
            dvgOrder.DataSource = list.ToList();
        }
        private void LoadCat()
        {
            cbxCat.DataSource = CategoryDAO.Instance.Categories();
            cbxCat.DisplayMember = "cat_name";
            cbxCat.ValueMember = "cat_id";
        }
        private void LoadType()
        {
            if (cbxCat.SelectedValue != null)
            {
                int cat_id = (int)cbxCat.SelectedValue;
                DataTable result = TypeDAO.Instance.GetbyCat(cat_id);
                if (result.Rows.Count > 0)
                {
                    cbxType.DataSource = result;
                    cbxType.DisplayMember = "type_name";
                    cbxType.ValueMember = "type_id";
                }
            }
        }
        private void LoadValue()
        {
            if (cbxType.SelectedValue != null)
            {
                int type_id = (int)cbxType.SelectedValue;
                cbxValue.DataSource = ValueDAO.Instance.GetbyType(type_id);
                cbxValue.DisplayMember = "val_name";
                cbxValue.ValueMember = "val_id";
            }
        }
        private void LoadDiff()
        {
            if (cbxValue.SelectedValue != null)
            {
                int val_id = (int)cbxValue.SelectedValue;

                cbxDiff.DataSource = DifferencedDAO.Instance.GetbyValues(val_id);
                cbxDiff.DisplayMember = "diff_name";
                cbxDiff.ValueMember = "diff_id";
            }
        }
        private void frmOrder_Load_1(object sender, EventArgs e)
        {
            txtDateNow.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }
        public void GetQrCode(string qrText)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(qrText, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);
        }

        private void cbxCat_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                cat_id = int.Parse(cbxCat.SelectedValue.ToString());
            }
            catch (Exception)
            {
                cat_id = 0;
            }
        }
        private void cbxType_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                type_id = int.Parse(cbxType.SelectedValue.ToString());
            }
            catch (Exception)
            {
                type_id = 0;
            }
        }
        private void cbxValue_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                val_id = int.Parse(cbxValue.SelectedValue.ToString());
            }
            catch (Exception)
            {
                val_id = 0;
            }
        }
        private void cbxDiff_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                diff_id = int.Parse(cbxDiff.SelectedValue.ToString());
            }
            catch (Exception)
            {
                diff_id = 0;
            }
        }
        private void cbxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadValue();
            LoadDiff();
        }
        private void cbxCat_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadType();
            LoadValue();
            LoadDiff();
        }
        private void cbxValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadDiff();
        }

        string textqr;
        private void btnQr_Click(object sender, EventArgs e)
        {
            textqr = cbxCat.SelectedValue + "-" + cbxType.SelectedValue + "-" + cbxValue.SelectedValue + "-" + cbxDiff.SelectedValue;
            Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            pictureBox3.Image = barcode.Draw(textqr, 50);
            Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            pictureBox2.Image = qrcode.Draw(textqr, 50);

        }
        private void printBarcode()
        {
            PrintDialog pd = new PrintDialog();
            PrintDocument doc = new PrintDocument();
            doc.PrintPage += Doc_PrintPage;
            pd.Document = doc;
            if (pd.ShowDialog() == DialogResult.OK)
            {
                doc.Print();
            }
        }
        private void Doc_PrintPage(object sender, PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(pictureBox3.Width, pictureBox3.Height);
            pictureBox3.DrawToBitmap(bm, new Rectangle(0, 0, pictureBox3.Width, pictureBox3.Height));
            e.Graphics.DrawImage(bm, 300, 100);
            Bitmap bm1 = new Bitmap(pictureBox2.Width, pictureBox2.Height);
            pictureBox2.DrawToBitmap(bm1, new Rectangle(0, 0, pictureBox2.Width, pictureBox2.Height));
            e.Graphics.DrawImage(bm1, 300, 400);
            bm1.Dispose();
            bm.Dispose();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtAmount.Text == "")
            {
                MessageBox.Show("Mời bạn nhập số lượng đơn hàng!");
                return;
            }
            object id_pro = ProductDAO.Instance.CheckProduct(cat_id, type_id, val_id, diff_id);
            if (id_pro == null)
            {
                id_pro = InsertPro(cat_id, type_id, val_id, diff_id);
            }
            // status 0: chưa đc thêm, 1: đã đc thêm, 2: chuẩn bị sửa
            if (edit)
            {
                foreach (OrderDetailbyId item in listModelOrderDetail)
                {
                    if(item.or_detail_id == int.Parse(txtId.Text))
                    {
                        item.pro_id = int.Parse(id_pro.ToString());
                        item.cat_name = cbxCat.Text;
                        item.type_name = cbxType.Text;
                        item.val_name = cbxValue.Text;
                        item.diff_name = cbxDiff.Text;
                        item.amount_in = (item.or_detail_id == 0) ? int.Parse(txtAmount.Text) : item.amount_in;
                        item.amount_out = (item.or_detail_id == 0) ? 0 : int.Parse(txtAmount.Text);
                        item.status = (item.or_detail_id == 0 ) ? 0 : 2;
                        item.date_create = DateTime.Now;
                        LoadDGVOrder(listModelOrderDetail);
                    }
                }
                edit = false;
                btnAdd.Text = "THÊM";
            }
            else
            {
                OrderDetailbyId model = new OrderDetailbyId();
                model.or_detail_id = 0;
                model.pro_id = int.Parse(id_pro.ToString());
                model.cat_name = cbxCat.Text;
                model.type_name = cbxType.Text;
                model.val_name = cbxValue.Text;
                model.diff_name = cbxDiff.Text;
                model.amount_in = int.Parse(txtAmount.Text);
                model.amount_out = 0;
                model.status = 0;
                model.date_create = DateTime.Now;

                listModelOrderDetail.Add(model);
                LoadDGVOrder(listModelOrderDetail);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtOrderName.Text == "")
            {
                MessageBox.Show("Mời bạn nhập tên đơn hàng!");
                return;
            }
            if (orderbyId == null)
            {
                // k.tra đơn hàng tồn tại chưa
                // nếu chưa thì thêm mới
                InsertOrder();
            }
            foreach (OrderDetailbyId item in listModelOrderDetail)
            {
                OrderDetail oDetail = new OrderDetail();
                oDetail.order_id = or_id;
                oDetail.pro_id = item.pro_id;
                oDetail.amount_in = item.amount_in;
                oDetail.amount_out = item.amount_out;
                oDetail.status = item.status;
                oDetail.date_create = item.date_create;
                if (item.status == 0)
                {
                    // thêm order detail
                    oDetail.status = 1;
                    InsertOrderDetail(oDetail);
                }
                else if (item.status == 2)
                {
                    // sửa order detail
                    // get id orderDetail
                    oDetail.status = 1;
                    oDetail.or_detail_id = item.or_detail_id;
                    UpdatetOrderDetail(oDetail);
                }
            }
        }
        private int InsertPro(int cat_id, int type_id, int val_id, int diff_id)
        {
            Product pro = new Product();
            pro.cat_id = cat_id;
            pro.type_id = type_id;
            pro.val_id = val_id;
            pro.diff_id = diff_id;
            pro.status = true;
            pro.date_create = DateTime.Now;
            object result = ProductDAO.Instance.Insert(pro);
            if (result != null)
            {
                MessageBox.Show("Thêm mới sản phấm thành công!");
                return int.Parse(result.ToString());
            }
            return 0;
        }
        private void InsertOrder()
        {
            Order o = new Order();
            o.cus_id = cus_id;
            o.order_name = txtOrderName.Text;
            o.status = true;
            o.date_create = DateTime.Now;
            object result = OrderDAO.Instance.InsertOrder(o);
            if (result != null)
            {
                or_id = int.Parse(result.ToString());
                MessageBox.Show("Đã tạo đơn hàng");
            }
        }
        private void InsertOrderDetail(OrderDetail oDetail)
        {
            int result = OrderDetailDAO.Instance.InsertOrderDetail(oDetail);
            if (result > 0)
            {
                MessageBox.Show("Lưu thông tin thành công");
            }
        }
        private void UpdatetOrderDetail(OrderDetail oDetail)
        {
            int result = OrderDetailDAO.Instance.UpdateOrderDetail(oDetail);
            if (result > 0)
            {
                MessageBox.Show("Lưu thông tin thành công");
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printBarcode();
        }

        private void dvgOrder_SelectionChanged(object sender, EventArgs e)
        {
            if (dvgOrder.SelectedRows.Count > 0)
            {
                txtId.Text = dvgOrder.SelectedCells[0].Value.ToString();
                cbxCat.Text = dvgOrder.SelectedCells[2].Value.ToString();
                cbxType.Text = dvgOrder.SelectedCells[3].Value.ToString();
                cbxValue.Text = dvgOrder.SelectedCells[5].Value.ToString();
                txtAmount.Text = dvgOrder.SelectedCells[6].Value.ToString();
                cbxDiff.Text = dvgOrder.SelectedCells[4].Value.ToString();
                edit = true;
                btnAdd.Text = "Sửa";
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            edit = false;
            txtId.Text = txtAmount.Text = "";
            btnAdd.Text = "THÊM";
        }
    }
}

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
        private List<OrderDetailbyId> listModelOrderDetail;
        private List<OrderDetail> listOrder;
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

        BarcodeLib.Barcode code128;
        public frmOrder(Order order)
        {
            InitializeComponent();
            loadData(order);
            LoadCat();
            LoadType();
            LoadValue();
            LoadDiff();
            code128 = new Barcode();

        }
        private void loadData(Order order)
        {
            this.orderbyId = order;
            DataTable orderDetail = OrderDetailbyIdDAO.Instance.getOrderDetailbyId(orderbyId.order_id);
            listModelOrderDetail = new List<OrderDetailbyId>();
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
            LoadOrder(listModelOrderDetail);

            DataTable infoOrder = OrderDetailbyIdDAO.Instance.getInfobyId(orderbyId.order_id);
            for (int i = 0; i < orderDetail.Rows.Count; i++)
            {
                cus_id = (int)infoOrder.Rows[i]["or_detail_id"];
                fullName = (string)orderDetail.Rows[i]["fullName"];
                or_name = (string)orderDetail.Rows[i]["or_name"];
                date_Order = (DateTime)orderDetail.Rows[i]["date_create"];
            }
            txtDateNow.Text = date_Order.ToString("dd/MM/yyyy");
            txtOrderName.Text = or_name;
            LoadOrder(list);
        }
        private void LoadOrder(List<OrderDetailbyId> list)
        {
            dvgOrder.DataSource = list;
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
        //public List<T> ConvertToList<T>(DataTable dt)
        //{
        //    var columnNames = dt.Columns.Cast<DataColumn>()
        //            .Select(c => c.ColumnName)
        //            .ToList();
        //    var properties = typeof(T).GetProperties();
        //    return dt.AsEnumerable().Select(row =>
        //    {
        //        var objT = Activator.CreateInstance<T>();
        //        foreach (var pro in properties)
        //        {
        //            if (columnNames.Contains(pro.Name))
        //            {
        //                PropertyInfo pI = objT.GetType().GetProperty(pro.Name);
        //                pro.SetValue(objT, row[pro.Name] == DBNull.Value ? null : Convert.ChangeType(row[pro.Name], pI.PropertyType));
        //            }
        //        }
        //        return objT;
        //    }).ToList();
        //}
        private void frmOrder_Load_1(object sender, EventArgs e)
        {
            txtDateNow.Text = DateTime.Now.ToString("dd/MM/yyyy");
            txtcusname.Text = fullName;
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
            if (txtId.Text == "")
            {
                MessageBox.Show("Mời bạn nhập mã đơn hàng!");
                return;
            }
            else if (txtAmount.Text == "")
            {
                MessageBox.Show("Mời bạn nhập số lượng đơn hàng!");
                return;
            }
            // status 0: chưa đc thêm, 1: đã đc thêm, 2: chuẩn bị sửa
            ModelOrder model = new ModelOrder();
            model.order_id = int.Parse(txtId.Text);
            model.cat_name = cbxCat.SelectedValue.ToString();
            model.type_name = cbxType.SelectedValue.ToString();
            model.value_name = cbxValue.SelectedValue.ToString();
            model.diff_name = cbxDiff.SelectedValue.ToString();
            model.amount_in = int.Parse(txtAmount.Text);
            model.amount_out = 0;
            model.status = 0;
            model.date_create = DateTime.Now;
            //listModelOrder.Add(model);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtOrderName.Text == "")
            {
                MessageBox.Show("Mời bạn nhập tên đơn hàng!");
                return;
            }
            if (true)
            {
                // k.tra đơn hàng tồn tại chưa
                // nếu chưa thì thêm mới
                InsertOrder();
            }
            foreach (OrderDetailbyId item in listModelOrderDetail)
            {
                object id_pro = ProductDAO.Instance.CheckProduct(int.Parse(item.cat_name), int.Parse(item.type_name), int.Parse(item.val_name), int.Parse(item.diff_name));
                if (id_pro == null)
                {
                    InsertPro(int.Parse(item.cat_name), int.Parse(item.type_name), int.Parse(item.val_name), int.Parse(item.diff_name));
                }

                OrderDetail oDetail = new OrderDetail();
                oDetail.order_id = or_id;
                oDetail.pro_id = int.Parse(id_pro.ToString());
                oDetail.amount_in = item.amount_in;
                oDetail.amount_out = item.amount_out;
                oDetail.status = 0;
                oDetail.date_create = DateTime.Now;
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
                    oDetail.or_detail_id = 1;
                    UpdatetOrderDetail(oDetail);
                }
            }
        }
        private void InsertPro(int cat_id, int type_id, int val_id, int diff_id)
        {
            Product pro = new Product();
            pro.cat_id = type_id;
            pro.type_id = type_id;
            pro.val_id = val_id;
            pro.diff_id = diff_id;
            pro.status = true;
            pro.date_create = DateTime.Now;
            int i = ProductDAO.Instance.Insert(pro);
            if (i > 0)
            {
                MessageBox.Show("Thêm mới sản phấm thành công!");
            }
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
    }
}

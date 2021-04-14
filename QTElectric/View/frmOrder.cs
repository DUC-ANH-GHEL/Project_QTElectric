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

namespace QTElectric.View
{
    public partial class frmOrder : Form
    {
        private List<ModelOrder> listModelOrder;
        private List<OrderDetail> listOrder;
        private int cat_id;
        private int type_id;
        private int val_id;
        private int diff_id;
        private Customer cus;
        private int or_id;

        BarcodeLib.Barcode code128;
        public frmOrder(Customer cus)
        {
            InitializeComponent();
            this.cus = cus;
            listModelOrder = new List<ModelOrder>();
            listOrder = new List<OrderDetail>();
            LoadCat();
            LoadType();
            LoadValue();
            LoadDiff();
            code128 = new Barcode();
        }
        private void LoadOrder()
        {            
            dvgOrder.DataSource = listModelOrder.ToList();
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
            txtcusname.Text = cus.fullName;
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
            LoadType();
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

        private void cbxDiff_SelectedIndexChanged(object sender, EventArgs e)
        {

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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Mời bạn nhập mã đơn hàng!");
                return;
            }else if (txtAmount.Text == "")
            {
                MessageBox.Show("Mời bạn nhập số lượng đơn hàng!");
                return;
            }
            ModelOrder model = new ModelOrder();
            model.order_id = txtId.Text;
            model.cat_name = cbxType.SelectedValue.ToString();
            model.type_name = cbxType.SelectedValue.ToString();
            model.value_name = cbxValue.SelectedValue.ToString();
            model.diff_name = cbxDiff.SelectedValue.ToString();
            model.amount_in = int.Parse(txtAmount.Text);
            model.amount_out = 0;
            model.date_create = DateTime.Now;
            listModelOrder.Add(model);
            LoadOrder();
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
                InsertOrder();
            }
            foreach (ModelOrder item in listModelOrder)
            {
                object id_pro = ProductDAO.Instance.CheckProduct(int.Parse(item.cat_name), int.Parse(item.type_name), int.Parse(item.value_name), int.Parse(item.diff_name));
                if (id_pro == null)
                {
                    MessageBox.Show("null");
                    InsertPro(int.Parse(item.cat_name), int.Parse(item.type_name), int.Parse(item.value_name), int.Parse(item.diff_name));
                }
                else
                {
                    MessageBox.Show("Not null: " + id_pro.ToString());
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
            o.cus_id = cus.cus_id;
            o.order_name = txtOrderName.Text;
            o.status = true;
            o.date_create = DateTime.Now;

            object result = OrderDAO.Instance.InsertOrder(o);
            if(result != null)
            {
                or_id = int.Parse(result.ToString());
                MessageBox.Show("Đã tạo đơn hàng");
            }
        }
    }
}

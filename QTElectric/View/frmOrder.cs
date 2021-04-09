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

namespace QTElectric.View
{
    public partial class frmOrder : Form
    {
        private List<ModelOrder> listOrder;
        private int cat_id;
        private int type_id;
        private int val_id;
        private int diff_id;
        private string cusname;

        BarcodeLib.Barcode code128;
        public frmOrder(string cusname)
        {
            InitializeComponent();
            txtcusname.Text = cusname;
            listOrder = new List<ModelOrder>();
            LoadCat();
            LoadType();
            LoadValue();
            LoadDiff();
            code128 = new Barcode();
        }
        public frmOrder()
        {
            InitializeComponent();
            listOrder = new List<ModelOrder>();
            LoadCat();
            LoadType();
            LoadValue();
            LoadDiff();
        }
        private void LoadOrder()
        {
            dvgOrder.DataSource = listOrder;
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
        }
        public void GetQrCode(string qrText)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(qrText, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);
        }

        public void Insert()
        {
            Product p = new Product()
            {
                cat_id = (int)cbxCat.SelectedValue,
                type_id = (int)cbxType.SelectedValue,
                val_id = (int)cbxValue.SelectedValue,
                diff_id = (int)cbxDiff.SelectedValue,
                qrname = textqr,

            };
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
            ModelOrder model = new ModelOrder();
            model.order_id = txtId.Text;
            model.cat_name = cbxType.SelectedValue.ToString();
            model.type_name = cbxType.SelectedValue.ToString();
            model.value_name = cbxValue.SelectedValue.ToString();
            model.diff_name = cbxDiff.SelectedValue.ToString();
            model.amount_in = int.Parse(txtAmount.Text);
            model.amount_out = 0;
            model.date_create = DateTime.Now;
            listOrder.Add(model);
            LoadOrder();
        }
    }
}

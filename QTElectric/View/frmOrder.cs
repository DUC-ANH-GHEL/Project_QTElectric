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

namespace QTElectric.View
{
    public partial class frmOrder : Form
    {
        private List<Category> listCat;
        private List<Types> listType;
        private List<Value> listVal;
        private List<Differenced> listDiff;
        public frmOrder()
        {
            InitializeComponent();
            listCat = new List<Category>();
            listType = new List<Types>();
            listVal = new List<Value>();
            listDiff = new List<Differenced>();
        }
        private void LoadCat(List<Category> listCat)
        {
            cbxCat.DataSource = listCat;
            cbxCat.DisplayMember = "cat_name";
            cbxCat.ValueMember = "cat_id";
        }
        private void LoadType(List<Types> listType)
        {
            cbxType.DataSource = listType;
            cbxType.DisplayMember = "type_name";
            cbxType.ValueMember = "type_id";
        }
        private void LoadValue(List<Value> listVal)
        {
            cbxValue.DataSource = listVal;
            cbxValue.DisplayMember = "val_name";
            cbxValue.ValueMember = "val_id";
        }
        private void LoadDiff(List<Differenced> listDiff)
        {
            cbxDiff.DataSource = listDiff;
            cbxDiff.DisplayMember = "diff_name";
            cbxDiff.ValueMember = "diff_id";
        }
        private static List<T> ConvertDataTable<T>(DataTable dt)
        {
            List<T> data = new List<T>();
            foreach (DataRow row in dt.Rows)
            {
                T item = GetItem<T>(row);
                data.Add(item);
            }
            return data;
        }
        private static T GetItem<T>(DataRow dr)
        {
            Type temp = typeof(T);
            T obj = Activator.CreateInstance<T>();

            foreach (DataColumn column in dr.Table.Columns)
            {
                foreach (PropertyInfo pro in temp.GetProperties())
                {
                    if (pro.Name == column.ColumnName)
                        pro.SetValue(obj, dr[column.ColumnName], null);
                    else
                        continue;
                }
            }
            return obj;
        }

        private void frmOrder_Load_1(object sender, EventArgs e)
        {
            listCat = ConvertDataTable<Category>(CategoryDAO.Instance.Categories());
            listType = ConvertDataTable<Types>(TypeDAO.Instance.Types());
            listVal = ConvertDataTable<Value>(ValueDAO.Instance.Value());
            listDiff = ConvertDataTable<Differenced>(DifferencedDAO.Instance.Get());
            LoadCat(listCat);
            LoadType(listType);
            LoadValue(listVal);
            LoadDiff(listDiff);
        }
        public void GetQrCode(string qrText)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(qrText, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var text = cbxCat.Text + cbxType.Text + cbxValue.Text + cbxDiff.Text;
            Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            pictureBox3.Image = barcode.Draw(text, 50);
            Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            pictureBox2.Image = qrcode.Draw(text, 50);
        }
    }
}

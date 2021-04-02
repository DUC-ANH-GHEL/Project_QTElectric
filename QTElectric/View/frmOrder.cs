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
        private int cat_id;
        private int type_id;
        private int val_id;
        private int diff_id;
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
        public List<T> ConvertToList<T>(DataTable dt)
        {
            var columnNames = dt.Columns.Cast<DataColumn>()
                    .Select(c => c.ColumnName)
                    .ToList();
            var properties = typeof(T).GetProperties();
            return dt.AsEnumerable().Select(row =>
            {
                var objT = Activator.CreateInstance<T>();
                foreach (var pro in properties)
                {
                    if (columnNames.Contains(pro.Name))
                    {
                        PropertyInfo pI = objT.GetType().GetProperty(pro.Name);
                        pro.SetValue(objT, row[pro.Name] == DBNull.Value ? null : Convert.ChangeType(row[pro.Name], pI.PropertyType));
                    }
                }
                return objT;
            }).ToList();
        }

        private void frmOrder_Load_1(object sender, EventArgs e)
        {
            listCat = ConvertToList<Category>(CategoryDAO.Instance.Categories());
            listType = ConvertToList<Types>(TypeDAO.Instance.Types());
            listVal = ConvertToList<Value>(ValueDAO.Instance.Value());
            listDiff = ConvertToList<Differenced>(DifferencedDAO.Instance.Get());
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
    }
}



//CREATE PROC GetByValues
//AS
//BEGIN
//SELECT  v.val_name, t.type_name, c.cat_name, d.diff_name 
//From [values] as v 
//    INNER JOIN tbl_types as t  ON v.val_id = t.type_id 
//    INNER JOIN tbl_category as c ON t.cat_id = c.cat_id 
//    INNER JOIN tbl_differenced as d ON v.val_id = d.val_id
//END
//GO

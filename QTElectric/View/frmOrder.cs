using QRCoder;
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
    public partial class frmOrder : Form
    {
        public frmOrder()
        {
            InitializeComponent();
            LoadCat();
            LoadType();
            LoadValue();
            LoadDiff();

        }
        private void LoadCat()
        {
            cbxCat.DataSource = CategoryDAO.Instance.Categories();
            cbxCat.DisplayMember = "cat_name";
            cbxCat.ValueMember = "cat_id";
        }
        private void LoadType()
        {
            int cat_id = (int)cbxCat.SelectedValue;
            cbxType.DataSource = TypeDAO.Instance.GetbyCat(cat_id);
            cbxType.DisplayMember = "type_name";
            cbxType.ValueMember = "type_id";
        }
        private void LoadValue()
        {
            cbxValue.DataSource = OrderDAO.Instance.Get();
            cbxValue.DisplayMember = "val_name";
            cbxValue.ValueMember = "type_name";
        }
        private void LoadDiff()
        {
            cbxDiff.DataSource = OrderDAO.Instance.Get();
            cbxDiff.DisplayMember = "diff_name";
            cbxDiff.ValueMember = "type_name";
        }

        private void frmOrder_Load_1(object sender, EventArgs e)
        {
            LoadCat();
            LoadType();
            LoadValue();
            LoadDiff();
        }
        public void GetQrCode(string qrText)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode(qrText, QRCodeGenerator.ECCLevel.Q);
            QRCode qrCode = new QRCode(qrCodeData);
            Bitmap qrCodeImage = qrCode.GetGraphic(20);
        }
        string textqr;
        private void button2_Click(object sender, EventArgs e)
        {
            textqr = cbxCat.Text + cbxType.Text + cbxValue.Text + cbxDiff.Text;
            Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            pictureBox3.Image = barcode.Draw(textqr, 50);
            Zen.Barcode.CodeQrBarcodeDraw qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            pictureBox2.Image = qrcode.Draw(textqr, 50);
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
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QTElectric
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            //using (var stream = File.OpenRead(".\\Img\\logo.ico"))
            //{
            //    if (stream == null)
            //    {
            //        MessageBox.Show("Không tìm thấy");
            //    }
            //    else
            //    {
            //        this.Icon = new Icon(stream);
            //    }

            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}

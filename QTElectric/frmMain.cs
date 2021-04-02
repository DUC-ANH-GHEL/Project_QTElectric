using QRCoder;
using QTElectric.Properties;
using QTElectric.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QTElectric
{
    public partial class frmMain : Form
    {
        Form frmParent;
        public frmMain(Form frmParent)
        {
            InitializeComponent();
            this.frmParent = frmParent;
            this.CenterToScreen();
            this.WindowState = FormWindowState.Maximized;
        }
        private void MdiLoadForm(Form f)
        {
            this.Text = f.Text;
            f.MdiParent = this;
            f.StartPosition = FormStartPosition.Manual;
            f.Dock = DockStyle.Fill;
            f.FormBorderStyle = FormBorderStyle.None;
            if (this.ActiveMdiChild != null)
            {
                Form current = this.ActiveMdiChild;
                if (current.Name != f.Name)
                {
                    current.Close();
                    f.Show();
                }
            }
            else
            {
                f.Show();
            }
        }
        private void loạiLinhKiệnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCategory frmChild = new frmCategory();
            MdiLoadForm(frmChild);
        }

        private void kiểuChânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmType frmChild = new frmType();
            MdiLoadForm(frmChild);
        }

        private void tênGiáTrịToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmValue frmChild = new frmValue();
            MdiLoadForm(frmChild);
        }

        private void saiSốToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDifferenced frmChild = new frmDifferenced();
            MdiLoadForm(frmChild);
        }

        private void tàiKhoảnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUser frmChild = new frmUser();
            MdiLoadForm(frmChild);
        }

        private void kháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCustomer frmChild = new frmCustomer();
            MdiLoadForm(frmChild);
        }

        private void đơnHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrder frmChild = new frmOrder();
            MdiLoadForm(frmChild);
        }

        private void btnUser_Click(object sender, EventArgs e)
        {
            tàiKhoảnToolStripMenuItem_Click(sender, e);
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            kháchHàngToolStripMenuItem_Click(sender, e);
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            đơnHàngToolStripMenuItem_Click(sender, e);
        }

        private void sảnPhẩmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProduct frmChild = new frmProduct();
            MdiLoadForm(frmChild);
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmParent.Close();
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin login = new frmLogin();
            login.ShowDialog();
            Settings.Default.Username = Settings.Default.Password = "";
            Settings.Default.Remember = false;
            Settings.Default.Save();
        }

    }
}

using QTElectric.Common;
using QTElectric.DAO;
using QTElectric.DTO;
using QTElectric.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QTElectric
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            Thread t = new Thread(new ThreadStart(startFrom));
            t.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            t.Abort();

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUsername.Text = Settings.Default.Username;
            txtPassword.Text = Settings.Default.Password;
            cbRemember.Checked = Settings.Default.Remember;
            //frmMain frm = new frmMain();
            //frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var userName = txtUsername.Text;
            var passWord = txtPassword.Text;
            var login = checkLogin(userName, HashPassword.CreateMD5(passWord));
            if (!(login is null))
            {
                if (login.status) // check trạng thái hoạt động
                {
                    frmMain main = new frmMain();
                    this.Hide();
                    main.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Account has been deactivated", "Status");
                }
                if (cbRemember.Checked)
                {
                    Settings.Default.Username = userName;
                    Settings.Default.Password = passWord;
                    Settings.Default.Remember = cbRemember.Checked;

                }
                else
                {
                    Settings.Default.Username = Settings.Default.Password = "";
                    Settings.Default.Remember = false;
                }
                Settings.Default.Save();

            }
            else
            {
                MessageBox.Show("User or Password incorrect");
            }
        }
        public void startFrom()
        {
            Application.Run(new frmSplashScreen());
        }
        public Login checkLogin(string userName, string passWord)
        {
            return LoginDAO.Instance.checkLogin(userName, passWord);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

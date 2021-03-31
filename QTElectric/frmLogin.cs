﻿using System;
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

            frmMain frm = new frmMain();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
        public void startFrom()
        {
            Application.Run(new frmSplashScreen());
        }
    }
}

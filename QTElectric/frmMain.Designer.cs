
namespace QTElectric
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.loạiLinhKiệnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kiểuChânToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tênGiáTrịToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saiSốToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.càiĐặtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tàiKhoảnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kháchHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.đơnHàngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnUser = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCustomer = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnOrder = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loạiLinhKiệnToolStripMenuItem,
            this.kiểuChânToolStripMenuItem,
            this.tênGiáTrịToolStripMenuItem,
            this.saiSốToolStripMenuItem,
            this.càiĐặtToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // loạiLinhKiệnToolStripMenuItem
            // 
            this.loạiLinhKiệnToolStripMenuItem.Name = "loạiLinhKiệnToolStripMenuItem";
            this.loạiLinhKiệnToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.loạiLinhKiệnToolStripMenuItem.Text = "Loại linh kiện";
            this.loạiLinhKiệnToolStripMenuItem.Click += new System.EventHandler(this.loạiLinhKiệnToolStripMenuItem_Click);
            // 
            // kiểuChânToolStripMenuItem
            // 
            this.kiểuChânToolStripMenuItem.Name = "kiểuChânToolStripMenuItem";
            this.kiểuChânToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.kiểuChânToolStripMenuItem.Text = "Kiểu chân";
            this.kiểuChânToolStripMenuItem.Click += new System.EventHandler(this.kiểuChânToolStripMenuItem_Click);
            // 
            // tênGiáTrịToolStripMenuItem
            // 
            this.tênGiáTrịToolStripMenuItem.Name = "tênGiáTrịToolStripMenuItem";
            this.tênGiáTrịToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.tênGiáTrịToolStripMenuItem.Text = "Tên/ Giá trị";
            this.tênGiáTrịToolStripMenuItem.Click += new System.EventHandler(this.tênGiáTrịToolStripMenuItem_Click);
            // 
            // saiSốToolStripMenuItem
            // 
            this.saiSốToolStripMenuItem.Name = "saiSốToolStripMenuItem";
            this.saiSốToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.saiSốToolStripMenuItem.Text = "Sai số";
            this.saiSốToolStripMenuItem.Click += new System.EventHandler(this.saiSốToolStripMenuItem_Click);
            // 
            // càiĐặtToolStripMenuItem
            // 
            this.càiĐặtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tàiKhoảnToolStripMenuItem,
            this.kháchHàngToolStripMenuItem,
            this.đơnHàngToolStripMenuItem});
            this.càiĐặtToolStripMenuItem.Name = "càiĐặtToolStripMenuItem";
            this.càiĐặtToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.càiĐặtToolStripMenuItem.Text = "Cài đặt";
            // 
            // tàiKhoảnToolStripMenuItem
            // 
            this.tàiKhoảnToolStripMenuItem.Name = "tàiKhoảnToolStripMenuItem";
            this.tàiKhoảnToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.tàiKhoảnToolStripMenuItem.Text = "Tài khoản";
            this.tàiKhoảnToolStripMenuItem.Click += new System.EventHandler(this.tàiKhoảnToolStripMenuItem_Click);
            // 
            // kháchHàngToolStripMenuItem
            // 
            this.kháchHàngToolStripMenuItem.Name = "kháchHàngToolStripMenuItem";
            this.kháchHàngToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.kháchHàngToolStripMenuItem.Text = "Khách hàng";
            this.kháchHàngToolStripMenuItem.Click += new System.EventHandler(this.kháchHàngToolStripMenuItem_Click);
            // 
            // đơnHàngToolStripMenuItem
            // 
            this.đơnHàngToolStripMenuItem.Name = "đơnHàngToolStripMenuItem";
            this.đơnHàngToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.đơnHàngToolStripMenuItem.Text = "Đơn hàng";
            this.đơnHàngToolStripMenuItem.Click += new System.EventHandler(this.đơnHàngToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnUser,
            this.toolStripSeparator1,
            this.btnCustomer,
            this.toolStripSeparator2,
            this.btnOrder});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(584, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnUser
            // 
            this.btnUser.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUser.Image = ((System.Drawing.Image)(resources.GetObject("btnUser.Image")));
            this.btnUser.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUser.Name = "btnUser";
            this.btnUser.Size = new System.Drawing.Size(23, 22);
            this.btnUser.Text = "Tài khoản";
            this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnCustomer
            // 
            this.btnCustomer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomer.Image")));
            this.btnCustomer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(23, 22);
            this.btnCustomer.Text = "Khách hàng";
            this.btnCustomer.Click += new System.EventHandler(this.btnCustomer_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnOrder
            // 
            this.btnOrder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOrder.Image = ((System.Drawing.Image)(resources.GetObject("btnOrder.Image")));
            this.btnOrder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(23, 22);
            this.btnOrder.Text = "Đơn hàng";
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loạiLinhKiệnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kiểuChânToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tênGiáTrịToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saiSốToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem càiĐặtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tàiKhoảnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kháchHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem đơnHàngToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnUser;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnCustomer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnOrder;
    }
}


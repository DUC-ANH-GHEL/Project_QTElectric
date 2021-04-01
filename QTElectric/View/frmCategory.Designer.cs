
namespace QTElectric.View
{
    partial class frmCategory
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCerror = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCsave = new System.Windows.Forms.Button();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.cbCstatus = new System.Windows.Forms.CheckBox();
            this.txtCname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dvgCategory = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCategory)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.txtCerror);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnCsave);
            this.panel1.Controls.Add(this.btnAddNew);
            this.panel1.Controls.Add(this.cbCstatus);
            this.panel1.Controls.Add(this.txtCname);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtCid);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(559, 118);
            this.panel1.TabIndex = 0;
            // 
            // txtCerror
            // 
            this.txtCerror.AutoSize = true;
            this.txtCerror.ForeColor = System.Drawing.Color.Red;
            this.txtCerror.Location = new System.Drawing.Point(73, 66);
            this.txtCerror.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.txtCerror.Name = "txtCerror";
            this.txtCerror.Size = new System.Drawing.Size(0, 13);
            this.txtCerror.TabIndex = 4;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(481, 74);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnCsave
            // 
            this.btnCsave.Location = new System.Drawing.Point(481, 37);
            this.btnCsave.Name = "btnCsave";
            this.btnCsave.Size = new System.Drawing.Size(75, 23);
            this.btnCsave.TabIndex = 3;
            this.btnCsave.Text = "Lưu";
            this.btnCsave.UseVisualStyleBackColor = true;
            this.btnCsave.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(481, 0);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(75, 23);
            this.btnAddNew.TabIndex = 3;
            this.btnAddNew.Text = "Thêm mới";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.button1_Click);
            // 
            // cbCstatus
            // 
            this.cbCstatus.AutoSize = true;
            this.cbCstatus.Location = new System.Drawing.Point(75, 83);
            this.cbCstatus.Name = "cbCstatus";
            this.cbCstatus.Size = new System.Drawing.Size(45, 17);
            this.cbCstatus.TabIndex = 2;
            this.cbCstatus.Text = "Còn";
            this.cbCstatus.UseVisualStyleBackColor = true;
            // 
            // txtCname
            // 
            this.txtCname.Location = new System.Drawing.Point(75, 37);
            this.txtCname.Name = "txtCname";
            this.txtCname.Size = new System.Drawing.Size(214, 20);
            this.txtCname.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Trạng thái";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên";
            // 
            // txtCid
            // 
            this.txtCid.Enabled = false;
            this.txtCid.Location = new System.Drawing.Point(75, 4);
            this.txtCid.Name = "txtCid";
            this.txtCid.Size = new System.Drawing.Size(214, 20);
            this.txtCid.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã";
            // 
            // dvgCategory
            // 
            this.dvgCategory.AllowUserToAddRows = false;
            this.dvgCategory.AllowUserToDeleteRows = false;
            this.dvgCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgCategory.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dvgCategory.Location = new System.Drawing.Point(13, 138);
            this.dvgCategory.Name = "dvgCategory";
            this.dvgCategory.ReadOnly = true;
            this.dvgCategory.RowHeadersWidth = 51;
            this.dvgCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgCategory.Size = new System.Drawing.Size(559, 211);
            this.dvgCategory.TabIndex = 1;
            this.dvgCategory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgCategory_CellClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "cat_id";
            this.Column1.HeaderText = "Mã";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "cat_name";
            this.Column2.HeaderText = "Tên";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "status";
            this.Column3.HeaderText = "Trạng thái";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "date_ceate";
            this.Column4.HeaderText = "Ngày nhập";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // frmCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.dvgCategory);
            this.Controls.Add(this.panel1);
            this.Name = "frmCategory";
            this.Text = "Loại linh kiện";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgCategory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCsave;
        private System.Windows.Forms.Button btnAddNew;
        private System.Windows.Forms.CheckBox cbCstatus;
        private System.Windows.Forms.TextBox txtCname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dvgCategory;
        private System.Windows.Forms.Label txtCerror;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}
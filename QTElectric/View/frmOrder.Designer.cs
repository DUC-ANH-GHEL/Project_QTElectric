
namespace QTElectric.View
{
    partial class frmOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>s
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnQr = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtcusname = new System.Windows.Forms.Label();
            this.txtDateNow = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.cbxDiff = new System.Windows.Forms.ComboBox();
            this.cbxValue = new System.Windows.Forms.ComboBox();
            this.cbxType = new System.Windows.Forms.ComboBox();
            this.cbxCat = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dvgOrder = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1582, 56);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(558, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "NHẬP - KIỂM LINH KIỆN";
            // 
            // panel4
            // 
            this.panel4.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.panel4.BackColor = System.Drawing.Color.LemonChiffon;
            this.panel4.Controls.Add(this.txtAmount);
            this.panel4.Controls.Add(this.txtId);
            this.panel4.Controls.Add(this.btnSave);
            this.panel4.Controls.Add(this.btnPrint);
            this.panel4.Controls.Add(this.btnQr);
            this.panel4.Controls.Add(this.btnAdd);
            this.panel4.Controls.Add(this.txtcusname);
            this.panel4.Controls.Add(this.txtDateNow);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Controls.Add(this.cbxDiff);
            this.panel4.Controls.Add(this.cbxValue);
            this.panel4.Controls.Add(this.cbxType);
            this.panel4.Controls.Add(this.cbxCat);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Location = new System.Drawing.Point(0, 58);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(678, 415);
            this.panel4.TabIndex = 3;
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(525, 245);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(121, 20);
            this.txtAmount.TabIndex = 5;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(39, 182);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(121, 20);
            this.txtId.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(476, 358);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 36);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "LƯU";
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Location = new System.Drawing.Point(359, 358);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 36);
            this.btnPrint.TabIndex = 9;
            this.btnPrint.Text = "IN";
            this.btnPrint.UseVisualStyleBackColor = false;
            // 
            // btnQr
            // 
            this.btnQr.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnQr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQr.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQr.ForeColor = System.Drawing.Color.White;
            this.btnQr.Location = new System.Drawing.Point(242, 358);
            this.btnQr.Name = "btnQr";
            this.btnQr.Size = new System.Drawing.Size(75, 36);
            this.btnQr.TabIndex = 8;
            this.btnQr.Text = "QR";
            this.btnQr.UseVisualStyleBackColor = false;
            this.btnQr.Click += new System.EventHandler(this.btnQr_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(125, 358);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 36);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "THÊM";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtcusname
            // 
            this.txtcusname.AutoSize = true;
            this.txtcusname.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcusname.Location = new System.Drawing.Point(422, 41);
            this.txtcusname.Name = "txtcusname";
            this.txtcusname.Size = new System.Drawing.Size(118, 23);
            this.txtcusname.TabIndex = 10;
            this.txtcusname.Text = "ten khach hang";
            // 
            // txtDateNow
            // 
            this.txtDateNow.AutoSize = true;
            this.txtDateNow.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateNow.Location = new System.Drawing.Point(422, 75);
            this.txtDateNow.Name = "txtDateNow";
            this.txtDateNow.Size = new System.Drawing.Size(90, 23);
            this.txtDateNow.TabIndex = 12;
            this.txtDateNow.Text = "01/01/2021";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(239, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 22);
            this.label10.TabIndex = 11;
            this.label10.Text = "Ngày nhập";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(239, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(143, 22);
            this.label9.TabIndex = 11;
            this.label9.Text = "Tên khách hàng";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.pictureBox3);
            this.panel5.Controls.Add(this.pictureBox2);
            this.panel5.Location = new System.Drawing.Point(36, 230);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(447, 100);
            this.panel5.TabIndex = 4;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(206, 2);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(237, 64);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(2, 2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(149, 94);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // cbxDiff
            // 
            this.cbxDiff.FormattingEnabled = true;
            this.cbxDiff.Location = new System.Drawing.Point(525, 308);
            this.cbxDiff.Name = "cbxDiff";
            this.cbxDiff.Size = new System.Drawing.Size(121, 21);
            this.cbxDiff.TabIndex = 6;
            this.cbxDiff.SelectedIndexChanged += new System.EventHandler(this.cbxDiff_SelectedIndexChanged);
            this.cbxDiff.SelectedValueChanged += new System.EventHandler(this.cbxDiff_SelectedValueChanged);
            // 
            // cbxValue
            // 
            this.cbxValue.FormattingEnabled = true;
            this.cbxValue.Location = new System.Drawing.Point(525, 182);
            this.cbxValue.Name = "cbxValue";
            this.cbxValue.Size = new System.Drawing.Size(121, 21);
            this.cbxValue.TabIndex = 4;
            this.cbxValue.SelectedIndexChanged += new System.EventHandler(this.cbxValue_SelectedIndexChanged);
            this.cbxValue.SelectedValueChanged += new System.EventHandler(this.cbxValue_SelectedValueChanged);
            // 
            // cbxType
            // 
            this.cbxType.FormattingEnabled = true;
            this.cbxType.Location = new System.Drawing.Point(362, 182);
            this.cbxType.Name = "cbxType";
            this.cbxType.Size = new System.Drawing.Size(121, 21);
            this.cbxType.TabIndex = 3;
            this.cbxType.SelectedIndexChanged += new System.EventHandler(this.cbxType_SelectedIndexChanged);
            this.cbxType.SelectedValueChanged += new System.EventHandler(this.cbxType_SelectedValueChanged);
            // 
            // cbxCat
            // 
            this.cbxCat.FormattingEnabled = true;
            this.cbxCat.Location = new System.Drawing.Point(199, 182);
            this.cbxCat.Name = "cbxCat";
            this.cbxCat.Size = new System.Drawing.Size(121, 21);
            this.cbxCat.TabIndex = 2;
            this.cbxCat.SelectedIndexChanged += new System.EventHandler(this.cbxCat_SelectedIndexChanged);
            this.cbxCat.SelectedValueChanged += new System.EventHandler(this.cbxCat_SelectedValueChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(544, 284);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 21);
            this.label8.TabIndex = 2;
            this.label8.Text = "Sai số %";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(544, 221);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 21);
            this.label7.TabIndex = 2;
            this.label7.Text = "Số lượng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(543, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 21);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tên/ Giá trị";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(380, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "Kiểu chân";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(205, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 21);
            this.label4.TabIndex = 2;
            this.label4.Text = "Loại linh kiện";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "STT Bom";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::QTElectric.Properties.Resources.logo_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(36, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(168, 128);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dvgOrder
            // 
            this.dvgOrder.AllowUserToAddRows = false;
            this.dvgOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dvgOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column5,
            this.Column2,
            this.Column3,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column4});
            this.dvgOrder.Location = new System.Drawing.Point(684, 58);
            this.dvgOrder.Name = "dvgOrder";
            this.dvgOrder.ReadOnly = true;
            this.dvgOrder.RowHeadersWidth = 51;
            this.dvgOrder.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgOrder.Size = new System.Drawing.Size(655, 415);
            this.dvgOrder.TabIndex = 10;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column1.DataPropertyName = "order_id";
            this.Column1.HeaderText = "STT Bom";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column5.DataPropertyName = "cat_name";
            this.Column5.HeaderText = "Loại linh kiện";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.DataPropertyName = "type_name";
            this.Column2.HeaderText = "Kiểu chân";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.DataPropertyName = "value_name";
            this.Column3.HeaderText = "Tên/ Giá trị";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column6.DataPropertyName = "diff_name";
            this.Column6.HeaderText = "Sai số";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column7.DataPropertyName = "amount_in";
            this.Column7.HeaderText = "Số lượng ban đầu";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column8.DataPropertyName = "amount_out";
            this.Column8.HeaderText = "Số lượng thực tế";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column4.DataPropertyName = "date_create";
            this.Column4.HeaderText = "Ngày nhập";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // frmOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(1342, 485);
            this.Controls.Add(this.dvgOrder);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "frmOrder";
            this.Text = "NHẬP - KIỂM LINH KIỆN";
            this.Load += new System.EventHandler(this.frmOrder_Load_1);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgOrder)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.ComboBox cbxDiff;
        private System.Windows.Forms.ComboBox cbxValue;
        private System.Windows.Forms.ComboBox cbxType;
        private System.Windows.Forms.ComboBox cbxCat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridView dvgOrder;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label txtcusname;
        private System.Windows.Forms.Label txtDateNow;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnQr;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
    }
}
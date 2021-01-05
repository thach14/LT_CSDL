namespace phunz
{
    partial class frmBanAn
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
            this.grbDanhSachBanAn = new System.Windows.Forms.GroupBox();
            this.grbQuanLyBanAn = new System.Windows.Forms.GroupBox();
            this.grbChiTiet = new System.Windows.Forms.GroupBox();
            this.dgvBanAn = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cbbStatus = new System.Windows.Forms.ComboBox();
            this.nmCapacity = new System.Windows.Forms.NumericUpDown();
            this.grbDanhSachBanAn.SuspendLayout();
            this.grbQuanLyBanAn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanAn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmCapacity)).BeginInit();
            this.SuspendLayout();
            // 
            // grbDanhSachBanAn
            // 
            this.grbDanhSachBanAn.Controls.Add(this.dgvBanAn);
            this.grbDanhSachBanAn.Location = new System.Drawing.Point(12, 12);
            this.grbDanhSachBanAn.Name = "grbDanhSachBanAn";
            this.grbDanhSachBanAn.Size = new System.Drawing.Size(554, 550);
            this.grbDanhSachBanAn.TabIndex = 0;
            this.grbDanhSachBanAn.TabStop = false;
            this.grbDanhSachBanAn.Text = "Danh sách bàn ăn";
            // 
            // grbQuanLyBanAn
            // 
            this.grbQuanLyBanAn.Controls.Add(this.nmCapacity);
            this.grbQuanLyBanAn.Controls.Add(this.cbbStatus);
            this.grbQuanLyBanAn.Controls.Add(this.txtName);
            this.grbQuanLyBanAn.Controls.Add(this.txtID);
            this.grbQuanLyBanAn.Controls.Add(this.button3);
            this.grbQuanLyBanAn.Controls.Add(this.btnSua);
            this.grbQuanLyBanAn.Controls.Add(this.btnThem);
            this.grbQuanLyBanAn.Controls.Add(this.label4);
            this.grbQuanLyBanAn.Controls.Add(this.label3);
            this.grbQuanLyBanAn.Controls.Add(this.label2);
            this.grbQuanLyBanAn.Controls.Add(this.label1);
            this.grbQuanLyBanAn.Location = new System.Drawing.Point(572, 12);
            this.grbQuanLyBanAn.Name = "grbQuanLyBanAn";
            this.grbQuanLyBanAn.Size = new System.Drawing.Size(405, 198);
            this.grbQuanLyBanAn.TabIndex = 1;
            this.grbQuanLyBanAn.TabStop = false;
            this.grbQuanLyBanAn.Text = "Quản lý";
            // 
            // grbChiTiet
            // 
            this.grbChiTiet.Location = new System.Drawing.Point(572, 216);
            this.grbChiTiet.Name = "grbChiTiet";
            this.grbChiTiet.Size = new System.Drawing.Size(405, 346);
            this.grbChiTiet.TabIndex = 2;
            this.grbChiTiet.TabStop = false;
            this.grbChiTiet.Text = "Chi tiết hóa đơn";
            // 
            // dgvBanAn
            // 
            this.dgvBanAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBanAn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBanAn.Location = new System.Drawing.Point(3, 18);
            this.dgvBanAn.MultiSelect = false;
            this.dgvBanAn.Name = "dgvBanAn";
            this.dgvBanAn.RowHeadersWidth = 51;
            this.dgvBanAn.RowTemplate.Height = 24;
            this.dgvBanAn.Size = new System.Drawing.Size(548, 529);
            this.dgvBanAn.TabIndex = 0;
            this.dgvBanAn.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBanAn_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "ID:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(179, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Trạng thái";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(179, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số chỗ ngồi";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(24, 125);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(150, 125);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(277, 125);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(64, 21);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(100, 22);
            this.txtID.TabIndex = 7;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(64, 57);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 22);
            this.txtName.TabIndex = 8;
            // 
            // cbbStatus
            // 
            this.cbbStatus.FormattingEnabled = true;
            this.cbbStatus.Items.AddRange(new object[] {
            "Trống",
            "Có người"});
            this.cbbStatus.Location = new System.Drawing.Point(258, 17);
            this.cbbStatus.Name = "cbbStatus";
            this.cbbStatus.Size = new System.Drawing.Size(99, 24);
            this.cbbStatus.TabIndex = 9;
            // 
            // nmCapacity
            // 
            this.nmCapacity.Location = new System.Drawing.Point(277, 54);
            this.nmCapacity.Name = "nmCapacity";
            this.nmCapacity.Size = new System.Drawing.Size(80, 22);
            this.nmCapacity.TabIndex = 10;
            // 
            // frmBanAn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 574);
            this.Controls.Add(this.grbChiTiet);
            this.Controls.Add(this.grbQuanLyBanAn);
            this.Controls.Add(this.grbDanhSachBanAn);
            this.Name = "frmBanAn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý bàn ăn";
            this.Load += new System.EventHandler(this.frmBanAn_Load);
            this.grbDanhSachBanAn.ResumeLayout(false);
            this.grbQuanLyBanAn.ResumeLayout(false);
            this.grbQuanLyBanAn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanAn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmCapacity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDanhSachBanAn;
        private System.Windows.Forms.DataGridView dgvBanAn;
        private System.Windows.Forms.GroupBox grbQuanLyBanAn;
        private System.Windows.Forms.GroupBox grbChiTiet;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.NumericUpDown nmCapacity;
        private System.Windows.Forms.ComboBox cbbStatus;
    }
}


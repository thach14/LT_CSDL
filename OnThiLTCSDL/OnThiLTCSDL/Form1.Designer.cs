namespace OnThiLTCSDL
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
            this.grbDSBanAn = new System.Windows.Forms.GroupBox();
            this.dgvBanAn = new System.Windows.Forms.DataGridView();
            this.grbQLBanAn = new System.Windows.Forms.GroupBox();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.nmCapacity = new System.Windows.Forms.NumericUpDown();
            this.cbbStatus = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtIDBanAn = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbChiTietHoaDon = new System.Windows.Forms.GroupBox();
            this.grbDSBanAn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanAn)).BeginInit();
            this.grbQLBanAn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmCapacity)).BeginInit();
            this.SuspendLayout();
            // 
            // grbDSBanAn
            // 
            this.grbDSBanAn.Controls.Add(this.dgvBanAn);
            this.grbDSBanAn.Location = new System.Drawing.Point(12, 12);
            this.grbDSBanAn.Name = "grbDSBanAn";
            this.grbDSBanAn.Size = new System.Drawing.Size(404, 483);
            this.grbDSBanAn.TabIndex = 0;
            this.grbDSBanAn.TabStop = false;
            this.grbDSBanAn.Text = "Danh sách bàn ăn";
            // 
            // dgvBanAn
            // 
            this.dgvBanAn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBanAn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBanAn.Location = new System.Drawing.Point(3, 18);
            this.dgvBanAn.Name = "dgvBanAn";
            this.dgvBanAn.RowHeadersWidth = 51;
            this.dgvBanAn.RowTemplate.Height = 24;
            this.dgvBanAn.Size = new System.Drawing.Size(398, 462);
            this.dgvBanAn.TabIndex = 0;
            // 
            // grbQLBanAn
            // 
            this.grbQLBanAn.Controls.Add(this.btnCapNhat);
            this.grbQLBanAn.Controls.Add(this.btnXoa);
            this.grbQLBanAn.Controls.Add(this.btnThem);
            this.grbQLBanAn.Controls.Add(this.nmCapacity);
            this.grbQLBanAn.Controls.Add(this.cbbStatus);
            this.grbQLBanAn.Controls.Add(this.txtName);
            this.grbQLBanAn.Controls.Add(this.txtIDBanAn);
            this.grbQLBanAn.Controls.Add(this.label4);
            this.grbQLBanAn.Controls.Add(this.label3);
            this.grbQLBanAn.Controls.Add(this.label2);
            this.grbQLBanAn.Controls.Add(this.label1);
            this.grbQLBanAn.Location = new System.Drawing.Point(431, 20);
            this.grbQLBanAn.Name = "grbQLBanAn";
            this.grbQLBanAn.Size = new System.Drawing.Size(425, 175);
            this.grbQLBanAn.TabIndex = 1;
            this.grbQLBanAn.TabStop = false;
            this.grbQLBanAn.Text = "Quản Lý Bàn Ăn";
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.Location = new System.Drawing.Point(303, 125);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhat.TabIndex = 5;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.UseVisualStyleBackColor = true;
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(171, 125);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(35, 125);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 5;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // nmCapacity
            // 
            this.nmCapacity.Location = new System.Drawing.Point(291, 59);
            this.nmCapacity.Name = "nmCapacity";
            this.nmCapacity.Size = new System.Drawing.Size(113, 22);
            this.nmCapacity.TabIndex = 4;
            // 
            // cbbStatus
            // 
            this.cbbStatus.FormattingEnabled = true;
            this.cbbStatus.Items.AddRange(new object[] {
            "Trống",
            "Có người"});
            this.cbbStatus.Location = new System.Drawing.Point(291, 31);
            this.cbbStatus.Name = "cbbStatus";
            this.cbbStatus.Size = new System.Drawing.Size(113, 24);
            this.cbbStatus.TabIndex = 3;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(82, 58);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(114, 22);
            this.txtName.TabIndex = 2;
            // 
            // txtIDBanAn
            // 
            this.txtIDBanAn.Location = new System.Drawing.Point(82, 30);
            this.txtIDBanAn.Name = "txtIDBanAn";
            this.txtIDBanAn.ReadOnly = true;
            this.txtIDBanAn.Size = new System.Drawing.Size(114, 22);
            this.txtIDBanAn.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(220, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Capacity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(220, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Status";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // grbChiTietHoaDon
            // 
            this.grbChiTietHoaDon.Location = new System.Drawing.Point(431, 201);
            this.grbChiTietHoaDon.Name = "grbChiTietHoaDon";
            this.grbChiTietHoaDon.Size = new System.Drawing.Size(404, 294);
            this.grbChiTietHoaDon.TabIndex = 2;
            this.grbChiTietHoaDon.TabStop = false;
            this.grbChiTietHoaDon.Text = "Chi tiết hóa đơn";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 548);
            this.Controls.Add(this.grbChiTietHoaDon);
            this.Controls.Add(this.grbQLBanAn);
            this.Controls.Add(this.grbDSBanAn);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản Lý Bàn Ăn";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grbDSBanAn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBanAn)).EndInit();
            this.grbQLBanAn.ResumeLayout(false);
            this.grbQLBanAn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmCapacity)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDSBanAn;
        private System.Windows.Forms.GroupBox grbQLBanAn;
        private System.Windows.Forms.GroupBox grbChiTietHoaDon;
        private System.Windows.Forms.DataGridView dgvBanAn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.NumericUpDown nmCapacity;
        private System.Windows.Forms.ComboBox cbbStatus;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtIDBanAn;
    }
}


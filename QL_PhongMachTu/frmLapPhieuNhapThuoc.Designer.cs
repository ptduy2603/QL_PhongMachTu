namespace QL_PhongMachTu
{
    partial class frmLapPhieuNhapThuoc
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.grbThongTinPhieuLapThuoc = new System.Windows.Forms.GroupBox();
            this.txtTongTien = new System.Windows.Forms.TextBox();
            this.dtpNgayLapPhieu = new System.Windows.Forms.DateTimePicker();
            this.txtMaPhieuNhapThuoc = new System.Windows.Forms.TextBox();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblNgayLap = new System.Windows.Forms.Label();
            this.lblMaPhieuNhapThuoc = new System.Windows.Forms.Label();
            this.grbThongTinThuoc = new System.Windows.Forms.GroupBox();
            this.txtDonGiaNhap = new System.Windows.Forms.TextBox();
            this.lblDonGiaNhap = new System.Windows.Forms.Label();
            this.nudSoLuongNhap = new System.Windows.Forms.NumericUpDown();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.lblTenThuoc = new System.Windows.Forms.Label();
            this.cboTenThuoc = new System.Windows.Forms.ComboBox();
            this.grbDanhSachPhieuNhapThuoc = new System.Windows.Forms.GroupBox();
            this.dgvDanhSachPhieuNhapThuoc = new System.Windows.Forms.DataGridView();
            this.grbDanhSachThuoc = new System.Windows.Forms.GroupBox();
            this.dgvDanhSachThuoc = new System.Windows.Forms.DataGridView();
            this.LoaiThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuongNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGiaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLapPhieu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnXemThongTinThuoc = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnXoa = new System.Windows.Forms.Button();
            this.grbThongTinPhieuLapThuoc.SuspendLayout();
            this.grbThongTinThuoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongNhap)).BeginInit();
            this.grbDanhSachPhieuNhapThuoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachPhieuNhapThuoc)).BeginInit();
            this.grbDanhSachThuoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachThuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1055, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lập Phiếu Nhập Thuốc";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grbThongTinPhieuLapThuoc
            // 
            this.grbThongTinPhieuLapThuoc.Controls.Add(this.txtTongTien);
            this.grbThongTinPhieuLapThuoc.Controls.Add(this.dtpNgayLapPhieu);
            this.grbThongTinPhieuLapThuoc.Controls.Add(this.txtMaPhieuNhapThuoc);
            this.grbThongTinPhieuLapThuoc.Controls.Add(this.lblTongTien);
            this.grbThongTinPhieuLapThuoc.Controls.Add(this.lblNgayLap);
            this.grbThongTinPhieuLapThuoc.Controls.Add(this.lblMaPhieuNhapThuoc);
            this.grbThongTinPhieuLapThuoc.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grbThongTinPhieuLapThuoc.Location = new System.Drawing.Point(6, 71);
            this.grbThongTinPhieuLapThuoc.Name = "grbThongTinPhieuLapThuoc";
            this.grbThongTinPhieuLapThuoc.Size = new System.Drawing.Size(761, 130);
            this.grbThongTinPhieuLapThuoc.TabIndex = 1;
            this.grbThongTinPhieuLapThuoc.TabStop = false;
            this.grbThongTinPhieuLapThuoc.Text = "Thông Tin Phiếu Nhập Thuốc";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Location = new System.Drawing.Point(518, 67);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.ReadOnly = true;
            this.txtTongTien.Size = new System.Drawing.Size(182, 30);
            this.txtTongTien.TabIndex = 5;
            // 
            // dtpNgayLapPhieu
            // 
            this.dtpNgayLapPhieu.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayLapPhieu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayLapPhieu.Location = new System.Drawing.Point(245, 67);
            this.dtpNgayLapPhieu.Name = "dtpNgayLapPhieu";
            this.dtpNgayLapPhieu.Size = new System.Drawing.Size(241, 30);
            this.dtpNgayLapPhieu.TabIndex = 4;
            // 
            // txtMaPhieuNhapThuoc
            // 
            this.txtMaPhieuNhapThuoc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtMaPhieuNhapThuoc.Location = new System.Drawing.Point(13, 67);
            this.txtMaPhieuNhapThuoc.Name = "txtMaPhieuNhapThuoc";
            this.txtMaPhieuNhapThuoc.ReadOnly = true;
            this.txtMaPhieuNhapThuoc.Size = new System.Drawing.Size(197, 30);
            this.txtMaPhieuNhapThuoc.TabIndex = 3;
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Location = new System.Drawing.Point(518, 41);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(86, 23);
            this.lblTongTien.TabIndex = 2;
            this.lblTongTien.Text = "Tổng Tiền";
            // 
            // lblNgayLap
            // 
            this.lblNgayLap.AutoSize = true;
            this.lblNgayLap.Location = new System.Drawing.Point(245, 41);
            this.lblNgayLap.Name = "lblNgayLap";
            this.lblNgayLap.Size = new System.Drawing.Size(131, 23);
            this.lblNgayLap.TabIndex = 1;
            this.lblNgayLap.Text = "Ngày Lập Phiếu";
            // 
            // lblMaPhieuNhapThuoc
            // 
            this.lblMaPhieuNhapThuoc.AutoSize = true;
            this.lblMaPhieuNhapThuoc.Location = new System.Drawing.Point(13, 41);
            this.lblMaPhieuNhapThuoc.Name = "lblMaPhieuNhapThuoc";
            this.lblMaPhieuNhapThuoc.Size = new System.Drawing.Size(83, 23);
            this.lblMaPhieuNhapThuoc.TabIndex = 0;
            this.lblMaPhieuNhapThuoc.Text = "Mã Phiếu";
            // 
            // grbThongTinThuoc
            // 
            this.grbThongTinThuoc.Controls.Add(this.txtDonGiaNhap);
            this.grbThongTinThuoc.Controls.Add(this.lblDonGiaNhap);
            this.grbThongTinThuoc.Controls.Add(this.nudSoLuongNhap);
            this.grbThongTinThuoc.Controls.Add(this.lblSoLuong);
            this.grbThongTinThuoc.Controls.Add(this.lblTenThuoc);
            this.grbThongTinThuoc.Controls.Add(this.cboTenThuoc);
            this.grbThongTinThuoc.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grbThongTinThuoc.Location = new System.Drawing.Point(8, 207);
            this.grbThongTinThuoc.Name = "grbThongTinThuoc";
            this.grbThongTinThuoc.Size = new System.Drawing.Size(759, 151);
            this.grbThongTinThuoc.TabIndex = 2;
            this.grbThongTinThuoc.TabStop = false;
            this.grbThongTinThuoc.Text = "Thông Tin Loại Thuốc";
            // 
            // txtDonGiaNhap
            // 
            this.txtDonGiaNhap.Location = new System.Drawing.Point(516, 82);
            this.txtDonGiaNhap.Name = "txtDonGiaNhap";
            this.txtDonGiaNhap.Size = new System.Drawing.Size(182, 30);
            this.txtDonGiaNhap.TabIndex = 5;
            this.txtDonGiaNhap.TextChanged += new System.EventHandler(this.txtDonGiaNhap_TextChanged);
            // 
            // lblDonGiaNhap
            // 
            this.lblDonGiaNhap.AutoSize = true;
            this.lblDonGiaNhap.Location = new System.Drawing.Point(516, 55);
            this.lblDonGiaNhap.Name = "lblDonGiaNhap";
            this.lblDonGiaNhap.Size = new System.Drawing.Size(119, 23);
            this.lblDonGiaNhap.TabIndex = 4;
            this.lblDonGiaNhap.Text = "Đơn Giá Nhập";
            // 
            // nudSoLuongNhap
            // 
            this.nudSoLuongNhap.Location = new System.Drawing.Point(243, 83);
            this.nudSoLuongNhap.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.nudSoLuongNhap.Name = "nudSoLuongNhap";
            this.nudSoLuongNhap.Size = new System.Drawing.Size(241, 30);
            this.nudSoLuongNhap.TabIndex = 3;
            this.nudSoLuongNhap.ValueChanged += new System.EventHandler(this.nudSoLuongNhap_ValueChanged);
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Location = new System.Drawing.Point(244, 55);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(130, 23);
            this.lblSoLuong.TabIndex = 2;
            this.lblSoLuong.Text = "Số Lượng Nhập";
            // 
            // lblTenThuoc
            // 
            this.lblTenThuoc.AutoSize = true;
            this.lblTenThuoc.Location = new System.Drawing.Point(11, 55);
            this.lblTenThuoc.Name = "lblTenThuoc";
            this.lblTenThuoc.Size = new System.Drawing.Size(88, 23);
            this.lblTenThuoc.TabIndex = 1;
            this.lblTenThuoc.Text = "Tên Thuốc";
            // 
            // cboTenThuoc
            // 
            this.cboTenThuoc.FormattingEnabled = true;
            this.cboTenThuoc.Location = new System.Drawing.Point(11, 83);
            this.cboTenThuoc.Name = "cboTenThuoc";
            this.cboTenThuoc.Size = new System.Drawing.Size(197, 31);
            this.cboTenThuoc.TabIndex = 0;
            // 
            // grbDanhSachPhieuNhapThuoc
            // 
            this.grbDanhSachPhieuNhapThuoc.Controls.Add(this.dgvDanhSachPhieuNhapThuoc);
            this.grbDanhSachPhieuNhapThuoc.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grbDanhSachPhieuNhapThuoc.Location = new System.Drawing.Point(8, 364);
            this.grbDanhSachPhieuNhapThuoc.Name = "grbDanhSachPhieuNhapThuoc";
            this.grbDanhSachPhieuNhapThuoc.Size = new System.Drawing.Size(451, 328);
            this.grbDanhSachPhieuNhapThuoc.TabIndex = 3;
            this.grbDanhSachPhieuNhapThuoc.TabStop = false;
            this.grbDanhSachPhieuNhapThuoc.Text = "Danh Sách Phiếu Nhập Thuốc";
            // 
            // dgvDanhSachPhieuNhapThuoc
            // 
            this.dgvDanhSachPhieuNhapThuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachPhieuNhapThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachPhieuNhapThuoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachPhieuNhapThuoc.Location = new System.Drawing.Point(3, 26);
            this.dgvDanhSachPhieuNhapThuoc.Name = "dgvDanhSachPhieuNhapThuoc";
            this.dgvDanhSachPhieuNhapThuoc.ReadOnly = true;
            this.dgvDanhSachPhieuNhapThuoc.RowHeadersWidth = 51;
            this.dgvDanhSachPhieuNhapThuoc.RowTemplate.Height = 29;
            this.dgvDanhSachPhieuNhapThuoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachPhieuNhapThuoc.Size = new System.Drawing.Size(445, 299);
            this.dgvDanhSachPhieuNhapThuoc.TabIndex = 0;
            // 
            // grbDanhSachThuoc
            // 
            this.grbDanhSachThuoc.Controls.Add(this.dgvDanhSachThuoc);
            this.grbDanhSachThuoc.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grbDanhSachThuoc.Location = new System.Drawing.Point(472, 364);
            this.grbDanhSachThuoc.Name = "grbDanhSachThuoc";
            this.grbDanhSachThuoc.Size = new System.Drawing.Size(567, 328);
            this.grbDanhSachThuoc.TabIndex = 4;
            this.grbDanhSachThuoc.TabStop = false;
            this.grbDanhSachThuoc.Text = "Danh Sách Thuốc";
            // 
            // dgvDanhSachThuoc
            // 
            this.dgvDanhSachThuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachThuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LoaiThuoc,
            this.SoLuongNhap,
            this.DonGiaNhap});
            this.dgvDanhSachThuoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachThuoc.Location = new System.Drawing.Point(3, 26);
            this.dgvDanhSachThuoc.Name = "dgvDanhSachThuoc";
            this.dgvDanhSachThuoc.ReadOnly = true;
            this.dgvDanhSachThuoc.RowHeadersWidth = 51;
            this.dgvDanhSachThuoc.RowTemplate.Height = 29;
            this.dgvDanhSachThuoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachThuoc.Size = new System.Drawing.Size(561, 299);
            this.dgvDanhSachThuoc.TabIndex = 0;
            this.dgvDanhSachThuoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachThuoc_CellClick);
            // 
            // LoaiThuoc
            // 
            this.LoaiThuoc.HeaderText = "Loại thuốc";
            this.LoaiThuoc.MinimumWidth = 6;
            this.LoaiThuoc.Name = "LoaiThuoc";
            this.LoaiThuoc.ReadOnly = true;
            // 
            // SoLuongNhap
            // 
            this.SoLuongNhap.HeaderText = "Số lượng nhập";
            this.SoLuongNhap.MinimumWidth = 6;
            this.SoLuongNhap.Name = "SoLuongNhap";
            this.SoLuongNhap.ReadOnly = true;
            // 
            // DonGiaNhap
            // 
            this.DonGiaNhap.HeaderText = "Đơn giá nhập";
            this.DonGiaNhap.MinimumWidth = 6;
            this.DonGiaNhap.Name = "DonGiaNhap";
            this.DonGiaNhap.ReadOnly = true;
            // 
            // btnLapPhieu
            // 
            this.btnLapPhieu.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLapPhieu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLapPhieu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLapPhieu.ForeColor = System.Drawing.Color.White;
            this.btnLapPhieu.Location = new System.Drawing.Point(790, 320);
            this.btnLapPhieu.Name = "btnLapPhieu";
            this.btnLapPhieu.Size = new System.Drawing.Size(249, 38);
            this.btnLapPhieu.TabIndex = 5;
            this.btnLapPhieu.Text = "Lập Phiếu";
            this.btnLapPhieu.UseVisualStyleBackColor = false;
            this.btnLapPhieu.Click += new System.EventHandler(this.btnLapPhieu_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(66, 710);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(388, 49);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(790, 200);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(112, 41);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(790, 262);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(112, 41);
            this.btnSua.TabIndex = 9;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(927, 263);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(112, 41);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnXemThongTinThuoc
            // 
            this.btnXemThongTinThuoc.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnXemThongTinThuoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXemThongTinThuoc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXemThongTinThuoc.ForeColor = System.Drawing.Color.White;
            this.btnXemThongTinThuoc.Location = new System.Drawing.Point(592, 710);
            this.btnXemThongTinThuoc.Name = "btnXemThongTinThuoc";
            this.btnXemThongTinThuoc.Size = new System.Drawing.Size(388, 49);
            this.btnXemThongTinThuoc.TabIndex = 11;
            this.btnXemThongTinThuoc.Text = "Xem Thông Tin Thuốc";
            this.btnXemThongTinThuoc.UseVisualStyleBackColor = false;
            this.btnXemThongTinThuoc.Click += new System.EventHandler(this.btnXemThongTinThuoc_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(927, 200);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(112, 41);
            this.btnXoa.TabIndex = 12;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // frmLapPhieuNhapThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1055, 771);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnXemThongTinThuoc);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnLapPhieu);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.grbDanhSachThuoc);
            this.Controls.Add(this.grbDanhSachPhieuNhapThuoc);
            this.Controls.Add(this.grbThongTinThuoc);
            this.Controls.Add(this.grbThongTinPhieuLapThuoc);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmLapPhieuNhapThuoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lập Phiếu Nhập Thuốc";
            this.Load += new System.EventHandler(this.frmLapPhieuNhapThuoc_Load);
            this.grbThongTinPhieuLapThuoc.ResumeLayout(false);
            this.grbThongTinPhieuLapThuoc.PerformLayout();
            this.grbThongTinThuoc.ResumeLayout(false);
            this.grbThongTinThuoc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuongNhap)).EndInit();
            this.grbDanhSachPhieuNhapThuoc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachPhieuNhapThuoc)).EndInit();
            this.grbDanhSachThuoc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachThuoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private GroupBox grbThongTinPhieuLapThuoc;
        private TextBox txtTongTien;
        private DateTimePicker dtpNgayLapPhieu;
        private TextBox txtMaPhieuNhapThuoc;
        private Label lblTongTien;
        private Label lblNgayLap;
        private Label lblMaPhieuNhapThuoc;
        private GroupBox grbThongTinThuoc;
        private TextBox txtDonGiaNhap;
        private Label lblDonGiaNhap;
        private NumericUpDown nudSoLuongNhap;
        private Label lblSoLuong;
        private Label lblTenThuoc;
        private ComboBox cboTenThuoc;
        private GroupBox grbDanhSachPhieuNhapThuoc;
        private GroupBox grbDanhSachThuoc;
        private Button btnLapPhieu;
        private Button btnThoat;
        private DataGridView dgvDanhSachPhieuNhapThuoc;
        private DataGridView dgvDanhSachThuoc;
        private Button btnThem;
        private Button btnSua;
        private Button btnReset;
        private DataGridViewTextBoxColumn LoaiThuoc;
        private DataGridViewTextBoxColumn SoLuongNhap;
        private DataGridViewTextBoxColumn DonGiaNhap;
        private Button btnXemThongTinThuoc;
        private ErrorProvider errorProvider;
        private Button btnXoa;
    }
}
﻿namespace QL_PhongMachTu
{
    partial class frmLapPhieuKham
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
            this.grbDanhSachBenhNhan = new System.Windows.Forms.GroupBox();
            this.dgvDanhSachBenhNhan = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.txtCachDung = new System.Windows.Forms.TextBox();
            this.txtDonVi = new System.Windows.Forms.TextBox();
            this.cboTenThuoc = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtGioiTinh = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtMaPhieuKham = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cboLoaiBenh = new System.Windows.Forms.ComboBox();
            this.txtTrieuChung = new System.Windows.Forms.TextBox();
            this.dtpNgayKham = new System.Windows.Forms.DateTimePicker();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtNamSinh = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtMaBenhNhan = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnThem = new System.Windows.Forms.Button();
            this.grbToaThuoc = new System.Windows.Forms.GroupBox();
            this.dgvToaThuoc = new System.Windows.Forms.DataGridView();
            this.TenThuoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonVi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CachDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnLapPhieu = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.txtSoLuongKhamBenh = new System.Windows.Forms.Label();
            this.btnLapHoaDon = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.grbDanhSachBenhNhan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachBenhNhan)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.grbToaThuoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvToaThuoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // grbDanhSachBenhNhan
            // 
            this.grbDanhSachBenhNhan.Controls.Add(this.dgvDanhSachBenhNhan);
            this.grbDanhSachBenhNhan.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.grbDanhSachBenhNhan.Location = new System.Drawing.Point(12, 489);
            this.grbDanhSachBenhNhan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbDanhSachBenhNhan.Name = "grbDanhSachBenhNhan";
            this.grbDanhSachBenhNhan.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbDanhSachBenhNhan.Size = new System.Drawing.Size(498, 292);
            this.grbDanhSachBenhNhan.TabIndex = 0;
            this.grbDanhSachBenhNhan.TabStop = false;
            this.grbDanhSachBenhNhan.Text = "Danh Sách Bệnh Nhân Trong Ngày";
            // 
            // dgvDanhSachBenhNhan
            // 
            this.dgvDanhSachBenhNhan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachBenhNhan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachBenhNhan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachBenhNhan.Location = new System.Drawing.Point(3, 25);
            this.dgvDanhSachBenhNhan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvDanhSachBenhNhan.Name = "dgvDanhSachBenhNhan";
            this.dgvDanhSachBenhNhan.ReadOnly = true;
            this.dgvDanhSachBenhNhan.RowHeadersWidth = 51;
            this.dgvDanhSachBenhNhan.RowTemplate.Height = 25;
            this.dgvDanhSachBenhNhan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachBenhNhan.Size = new System.Drawing.Size(492, 263);
            this.dgvDanhSachBenhNhan.TabIndex = 0;
            this.dgvDanhSachBenhNhan.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDanhSachBenhNhan_CellClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.txtGioiTinh);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.txtDiaChi);
            this.groupBox2.Controls.Add(this.txtNamSinh);
            this.groupBox2.Controls.Add(this.txtHoTen);
            this.groupBox2.Controls.Add(this.txtMaBenhNhan);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.groupBox2.Location = new System.Drawing.Point(14, 57);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(873, 430);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông Tin Bệnh Nhân";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(351, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Giới Tính";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.nudSoLuong);
            this.groupBox5.Controls.Add(this.txtCachDung);
            this.groupBox5.Controls.Add(this.txtDonVi);
            this.groupBox5.Controls.Add(this.cboTenThuoc);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Location = new System.Drawing.Point(14, 269);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox5.Size = new System.Drawing.Size(846, 155);
            this.groupBox5.TabIndex = 11;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Kê Thuốc";
            // 
            // nudSoLuong
            // 
            this.nudSoLuong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nudSoLuong.Location = new System.Drawing.Point(610, 80);
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.Size = new System.Drawing.Size(185, 34);
            this.nudSoLuong.TabIndex = 4;
            this.nudSoLuong.ValueChanged += new System.EventHandler(this.nudSoLuong_ValueChanged);
            // 
            // txtCachDung
            // 
            this.txtCachDung.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtCachDung.Location = new System.Drawing.Point(417, 80);
            this.txtCachDung.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCachDung.Name = "txtCachDung";
            this.txtCachDung.ReadOnly = true;
            this.txtCachDung.Size = new System.Drawing.Size(170, 34);
            this.txtCachDung.TabIndex = 3;
            // 
            // txtDonVi
            // 
            this.txtDonVi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDonVi.Location = new System.Drawing.Point(261, 80);
            this.txtDonVi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDonVi.Name = "txtDonVi";
            this.txtDonVi.ReadOnly = true;
            this.txtDonVi.Size = new System.Drawing.Size(138, 34);
            this.txtDonVi.TabIndex = 1;
            // 
            // cboTenThuoc
            // 
            this.cboTenThuoc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboTenThuoc.FormattingEnabled = true;
            this.cboTenThuoc.Location = new System.Drawing.Point(9, 80);
            this.cboTenThuoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboTenThuoc.Name = "cboTenThuoc";
            this.cboTenThuoc.Size = new System.Drawing.Size(226, 36);
            this.cboTenThuoc.TabIndex = 0;
            this.cboTenThuoc.TextChanged += new System.EventHandler(this.cboTenThuoc_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(417, 46);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(84, 20);
            this.label13.TabIndex = 3;
            this.label13.Text = "Cách Dùng";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(610, 46);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(75, 20);
            this.label12.TabIndex = 2;
            this.label12.Text = "Số Lượng";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(261, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 20);
            this.label11.TabIndex = 1;
            this.label11.Text = "Đơn Vị";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 46);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Tên Loại Thuốc";
            // 
            // txtGioiTinh
            // 
            this.txtGioiTinh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtGioiTinh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtGioiTinh.Location = new System.Drawing.Point(352, 63);
            this.txtGioiTinh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGioiTinh.Name = "txtGioiTinh";
            this.txtGioiTinh.ReadOnly = true;
            this.txtGioiTinh.Size = new System.Drawing.Size(94, 34);
            this.txtGioiTinh.TabIndex = 12;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.txtMaPhieuKham);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.cboLoaiBenh);
            this.groupBox4.Controls.Add(this.txtTrieuChung);
            this.groupBox4.Controls.Add(this.dtpNgayKham);
            this.groupBox4.Location = new System.Drawing.Point(14, 105);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox4.Size = new System.Drawing.Size(846, 156);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông Tin Phiếu Khám";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(41, 30);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(119, 20);
            this.label15.TabIndex = 15;
            this.label15.Text = "Mã Phiếu Khám";
            // 
            // txtMaPhieuKham
            // 
            this.txtMaPhieuKham.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtMaPhieuKham.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMaPhieuKham.Location = new System.Drawing.Point(41, 54);
            this.txtMaPhieuKham.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaPhieuKham.Name = "txtMaPhieuKham";
            this.txtMaPhieuKham.ReadOnly = true;
            this.txtMaPhieuKham.Size = new System.Drawing.Size(108, 34);
            this.txtMaPhieuKham.TabIndex = 14;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(509, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(144, 20);
            this.label9.TabIndex = 5;
            this.label9.Text = "Dự Đoán Loại Bệnh";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "Triệu Chứng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(509, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Ngày Khám";
            // 
            // cboLoaiBenh
            // 
            this.cboLoaiBenh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cboLoaiBenh.FormattingEnabled = true;
            this.cboLoaiBenh.Location = new System.Drawing.Point(509, 112);
            this.cboLoaiBenh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboLoaiBenh.Name = "cboLoaiBenh";
            this.cboLoaiBenh.Size = new System.Drawing.Size(286, 36);
            this.cboLoaiBenh.TabIndex = 2;
            // 
            // txtTrieuChung
            // 
            this.txtTrieuChung.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTrieuChung.Location = new System.Drawing.Point(41, 114);
            this.txtTrieuChung.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtTrieuChung.Name = "txtTrieuChung";
            this.txtTrieuChung.Size = new System.Drawing.Size(375, 34);
            this.txtTrieuChung.TabIndex = 1;
            this.txtTrieuChung.TextChanged += new System.EventHandler(this.txtTrieuChung_TextChanged);
            // 
            // dtpNgayKham
            // 
            this.dtpNgayKham.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayKham.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpNgayKham.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayKham.Location = new System.Drawing.Point(509, 50);
            this.dtpNgayKham.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpNgayKham.Name = "dtpNgayKham";
            this.dtpNgayKham.Size = new System.Drawing.Size(286, 34);
            this.dtpNgayKham.TabIndex = 0;
            this.dtpNgayKham.ValueChanged += new System.EventHandler(this.dtpNgayKham_ValueChanged);
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtDiaChi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtDiaChi.Location = new System.Drawing.Point(572, 63);
            this.txtDiaChi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.ReadOnly = true;
            this.txtDiaChi.Size = new System.Drawing.Size(287, 34);
            this.txtDiaChi.TabIndex = 5;
            // 
            // txtNamSinh
            // 
            this.txtNamSinh.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtNamSinh.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNamSinh.Location = new System.Drawing.Point(456, 63);
            this.txtNamSinh.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNamSinh.Name = "txtNamSinh";
            this.txtNamSinh.ReadOnly = true;
            this.txtNamSinh.Size = new System.Drawing.Size(111, 34);
            this.txtNamSinh.TabIndex = 4;
            // 
            // txtHoTen
            // 
            this.txtHoTen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtHoTen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtHoTen.Location = new System.Drawing.Point(134, 63);
            this.txtHoTen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.ReadOnly = true;
            this.txtHoTen.Size = new System.Drawing.Size(209, 34);
            this.txtHoTen.TabIndex = 2;
            // 
            // txtMaBenhNhan
            // 
            this.txtMaBenhNhan.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtMaBenhNhan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMaBenhNhan.Location = new System.Drawing.Point(16, 63);
            this.txtMaBenhNhan.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaBenhNhan.Name = "txtMaBenhNhan";
            this.txtMaBenhNhan.ReadOnly = true;
            this.txtMaBenhNhan.Size = new System.Drawing.Size(108, 34);
            this.txtMaBenhNhan.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(573, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 4;
            this.label6.Text = "Địa Chỉ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(455, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 3;
            this.label5.Text = "Năm Sinh";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Họ Và Tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã Bệnh Nhân";
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Location = new System.Drawing.Point(912, 326);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(128, 51);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // grbToaThuoc
            // 
            this.grbToaThuoc.Controls.Add(this.dgvToaThuoc);
            this.grbToaThuoc.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.grbToaThuoc.Location = new System.Drawing.Point(521, 489);
            this.grbToaThuoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbToaThuoc.Name = "grbToaThuoc";
            this.grbToaThuoc.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbToaThuoc.Size = new System.Drawing.Size(675, 292);
            this.grbToaThuoc.TabIndex = 0;
            this.grbToaThuoc.TabStop = false;
            this.grbToaThuoc.Text = "Toa Thuốc";
            // 
            // dgvToaThuoc
            // 
            this.dgvToaThuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvToaThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvToaThuoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenThuoc,
            this.DonVi,
            this.SoLuong,
            this.CachDung});
            this.dgvToaThuoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvToaThuoc.Location = new System.Drawing.Point(3, 25);
            this.dgvToaThuoc.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvToaThuoc.Name = "dgvToaThuoc";
            this.dgvToaThuoc.ReadOnly = true;
            this.dgvToaThuoc.RowHeadersWidth = 51;
            this.dgvToaThuoc.RowTemplate.Height = 25;
            this.dgvToaThuoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvToaThuoc.Size = new System.Drawing.Size(669, 263);
            this.dgvToaThuoc.TabIndex = 0;
            this.dgvToaThuoc.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvToaThuoc_CellClick);
            // 
            // TenThuoc
            // 
            this.TenThuoc.HeaderText = "Thuốc";
            this.TenThuoc.MinimumWidth = 6;
            this.TenThuoc.Name = "TenThuoc";
            this.TenThuoc.ReadOnly = true;
            // 
            // DonVi
            // 
            this.DonVi.HeaderText = "Đơn Vị";
            this.DonVi.MinimumWidth = 6;
            this.DonVi.Name = "DonVi";
            this.DonVi.ReadOnly = true;
            // 
            // SoLuong
            // 
            this.SoLuong.HeaderText = "Số Lượng";
            this.SoLuong.MinimumWidth = 6;
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            // 
            // CachDung
            // 
            this.CachDung.HeaderText = "Cách Dùng";
            this.CachDung.MinimumWidth = 6;
            this.CachDung.Name = "CachDung";
            this.CachDung.ReadOnly = true;
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1207, 53);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Lập Phiếu Khám Bệnh";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label14.Location = new System.Drawing.Point(897, 162);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(244, 32);
            this.label14.TabIndex = 5;
            this.label14.Text = "Số Lượt Khám Bệnh:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Location = new System.Drawing.Point(1068, 326);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(128, 51);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.Location = new System.Drawing.Point(912, 389);
            this.btnSua.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(128, 51);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnReset.ForeColor = System.Drawing.Color.White;
            this.btnReset.Location = new System.Drawing.Point(1068, 389);
            this.btnReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(128, 51);
            this.btnReset.TabIndex = 8;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnLapPhieu
            // 
            this.btnLapPhieu.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLapPhieu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLapPhieu.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLapPhieu.ForeColor = System.Drawing.Color.White;
            this.btnLapPhieu.Location = new System.Drawing.Point(912, 448);
            this.btnLapPhieu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLapPhieu.Name = "btnLapPhieu";
            this.btnLapPhieu.Size = new System.Drawing.Size(284, 43);
            this.btnLapPhieu.TabIndex = 9;
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
            this.btnThoat.Location = new System.Drawing.Point(638, 789);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(423, 43);
            this.btnThoat.TabIndex = 10;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // txtSoLuongKhamBenh
            // 
            this.txtSoLuongKhamBenh.AutoSize = true;
            this.txtSoLuongKhamBenh.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtSoLuongKhamBenh.Location = new System.Drawing.Point(1144, 158);
            this.txtSoLuongKhamBenh.Name = "txtSoLuongKhamBenh";
            this.txtSoLuongKhamBenh.Size = new System.Drawing.Size(52, 41);
            this.txtSoLuongKhamBenh.TabIndex = 11;
            this.txtSoLuongKhamBenh.Text = "40";
            this.txtSoLuongKhamBenh.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnLapHoaDon
            // 
            this.btnLapHoaDon.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLapHoaDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLapHoaDon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLapHoaDon.ForeColor = System.Drawing.Color.White;
            this.btnLapHoaDon.Location = new System.Drawing.Point(137, 789);
            this.btnLapHoaDon.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLapHoaDon.Name = "btnLapHoaDon";
            this.btnLapHoaDon.Size = new System.Drawing.Size(423, 43);
            this.btnLapHoaDon.TabIndex = 12;
            this.btnLapHoaDon.Text = "Lập Hóa Đơn";
            this.btnLapHoaDon.UseVisualStyleBackColor = false;
            this.btnLapHoaDon.Click += new System.EventHandler(this.btnLapHoaDon_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmLapPhieuKham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1207, 843);
            this.Controls.Add(this.btnLapHoaDon);
            this.Controls.Add(this.txtSoLuongKhamBenh);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnLapPhieu);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.grbToaThuoc);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.grbDanhSachBenhNhan);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmLapPhieuKham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lập Phiếu Khám Bệnh";
            this.Load += new System.EventHandler(this.frmLapPhieuKham_Load);
            this.grbDanhSachBenhNhan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachBenhNhan)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.grbToaThuoc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvToaThuoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox grbDanhSachBenhNhan;
        private GroupBox groupBox2;
        private GroupBox grbToaThuoc;
        private DataGridView dgvDanhSachBenhNhan;
        private DataGridView dgvToaThuoc;
        private Label lblTitle;
        private Label label3;
        private Label label2;
        private Label label5;
        private Label label6;
        private TextBox txtMaBenhNhan;
        private TextBox txtDiaChi;
        private TextBox txtNamSinh;
        private TextBox txtHoTen;
        private GroupBox groupBox4;
        private DateTimePicker dtpNgayKham;
        private TextBox txtTrieuChung;
        private ComboBox cboLoaiBenh;
        private Label label8;
        private Label label7;
        private Label label9;
        private GroupBox groupBox5;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private ComboBox cboTenThuoc;
        private Button btnThem;
        private TextBox txtCachDung;
        private TextBox txtDonVi;
        private Label label14;
        private Button btnXoa;
        private Button btnSua;
        private Button btnReset;
        private Button btnLapPhieu;
        private Button btnThoat;
        private NumericUpDown nudSoLuong;
        private Label label4;
        private TextBox txtGioiTinh;
        private Label label15;
        private TextBox txtMaPhieuKham;
        private Label txtSoLuongKhamBenh;
        private Button btnLapHoaDon;
        private ErrorProvider errorProvider;
        private DataGridViewTextBoxColumn TenThuoc;
        private DataGridViewTextBoxColumn DonVi;
        private DataGridViewTextBoxColumn SoLuong;
        private DataGridViewTextBoxColumn CachDung;
    }
}
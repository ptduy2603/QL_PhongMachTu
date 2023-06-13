namespace QL_PhongMachTu
{
    partial class frmHoaDon
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblHoTen = new System.Windows.Forms.Label();
            this.lblNgayKham = new System.Windows.Forms.Label();
            this.lblTienKham = new System.Windows.Forms.Label();
            this.lblTienThuoc = new System.Windows.Forms.Label();
            this.grbDonThuoc = new System.Windows.Forms.GroupBox();
            this.dgvDonThuoc = new System.Windows.Forms.DataGridView();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.lblHienTongTien = new System.Windows.Forms.Label();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            this.lblMaHoaDon = new System.Windows.Forms.Label();
            this.lblMaPhieuKham = new System.Windows.Forms.Label();
            this.txtMaHoaDon = new System.Windows.Forms.TextBox();
            this.txtMaPhieuKham = new System.Windows.Forms.TextBox();
            this.txtHoTen = new System.Windows.Forms.TextBox();
            this.txtNgayKham = new System.Windows.Forms.TextBox();
            this.txtTienKham = new System.Windows.Forms.TextBox();
            this.txtTienThuoc = new System.Windows.Forms.TextBox();
            this.grbDonThuoc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonThuoc)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(744, 54);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Thông Tin Hóa Đơn";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblHoTen
            // 
            this.lblHoTen.AutoSize = true;
            this.lblHoTen.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHoTen.Location = new System.Drawing.Point(16, 144);
            this.lblHoTen.Name = "lblHoTen";
            this.lblHoTen.Size = new System.Drawing.Size(87, 23);
            this.lblHoTen.TabIndex = 1;
            this.lblHoTen.Text = "Họ và Tên";
            // 
            // lblNgayKham
            // 
            this.lblNgayKham.AutoSize = true;
            this.lblNgayKham.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNgayKham.Location = new System.Drawing.Point(385, 144);
            this.lblNgayKham.Name = "lblNgayKham";
            this.lblNgayKham.Size = new System.Drawing.Size(100, 23);
            this.lblNgayKham.TabIndex = 2;
            this.lblNgayKham.Text = "Ngày Khám";
            // 
            // lblTienKham
            // 
            this.lblTienKham.AutoSize = true;
            this.lblTienKham.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTienKham.Location = new System.Drawing.Point(16, 201);
            this.lblTienKham.Name = "lblTienKham";
            this.lblTienKham.Size = new System.Drawing.Size(91, 23);
            this.lblTienKham.TabIndex = 3;
            this.lblTienKham.Text = "Tiền Khám";
            // 
            // lblTienThuoc
            // 
            this.lblTienThuoc.AutoSize = true;
            this.lblTienThuoc.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTienThuoc.Location = new System.Drawing.Point(385, 201);
            this.lblTienThuoc.Name = "lblTienThuoc";
            this.lblTienThuoc.Size = new System.Drawing.Size(94, 23);
            this.lblTienThuoc.TabIndex = 4;
            this.lblTienThuoc.Text = "Tiền Thuốc";
            // 
            // grbDonThuoc
            // 
            this.grbDonThuoc.Controls.Add(this.dgvDonThuoc);
            this.grbDonThuoc.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grbDonThuoc.Location = new System.Drawing.Point(13, 238);
            this.grbDonThuoc.Name = "grbDonThuoc";
            this.grbDonThuoc.Size = new System.Drawing.Size(719, 275);
            this.grbDonThuoc.TabIndex = 5;
            this.grbDonThuoc.TabStop = false;
            this.grbDonThuoc.Text = "Đơn Thuốc";
            // 
            // dgvDonThuoc
            // 
            this.dgvDonThuoc.AllowUserToAddRows = false;
            this.dgvDonThuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDonThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDonThuoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDonThuoc.Location = new System.Drawing.Point(3, 26);
            this.dgvDonThuoc.Name = "dgvDonThuoc";
            this.dgvDonThuoc.ReadOnly = true;
            this.dgvDonThuoc.RowHeadersWidth = 51;
            this.dgvDonThuoc.RowTemplate.Height = 29;
            this.dgvDonThuoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDonThuoc.Size = new System.Drawing.Size(713, 246);
            this.dgvDonThuoc.TabIndex = 0;
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTongTien.Location = new System.Drawing.Point(278, 526);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(150, 38);
            this.lblTongTien.TabIndex = 6;
            this.lblTongTien.Text = "Tổng Tiền:";
            // 
            // lblHienTongTien
            // 
            this.lblHienTongTien.AutoSize = true;
            this.lblHienTongTien.Font = new System.Drawing.Font("Segoe UI Semibold", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblHienTongTien.Location = new System.Drawing.Point(420, 525);
            this.lblHienTongTien.Name = "lblHienTongTien";
            this.lblHienTongTien.Size = new System.Drawing.Size(0, 38);
            this.lblHienTongTien.TabIndex = 7;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnThanhToan.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThanhToan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThanhToan.ForeColor = System.Drawing.Color.White;
            this.btnThanhToan.Location = new System.Drawing.Point(90, 574);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(256, 47);
            this.btnThanhToan.TabIndex = 8;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnDong
            // 
            this.btnDong.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnDong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDong.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDong.ForeColor = System.Drawing.Color.White;
            this.btnDong.Location = new System.Drawing.Point(393, 574);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(256, 47);
            this.btnDong.TabIndex = 9;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = false;
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // lblMaHoaDon
            // 
            this.lblMaHoaDon.AutoSize = true;
            this.lblMaHoaDon.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMaHoaDon.Location = new System.Drawing.Point(16, 87);
            this.lblMaHoaDon.Name = "lblMaHoaDon";
            this.lblMaHoaDon.Size = new System.Drawing.Size(109, 23);
            this.lblMaHoaDon.TabIndex = 10;
            this.lblMaHoaDon.Text = "Mã Hóa Đơn";
            // 
            // lblMaPhieuKham
            // 
            this.lblMaPhieuKham.AutoSize = true;
            this.lblMaPhieuKham.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMaPhieuKham.Location = new System.Drawing.Point(385, 87);
            this.lblMaPhieuKham.Name = "lblMaPhieuKham";
            this.lblMaPhieuKham.Size = new System.Drawing.Size(132, 23);
            this.lblMaPhieuKham.TabIndex = 11;
            this.lblMaPhieuKham.Text = "Mã Phiếu Khám";
            // 
            // txtMaHoaDon
            // 
            this.txtMaHoaDon.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtMaHoaDon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMaHoaDon.Location = new System.Drawing.Point(134, 79);
            this.txtMaHoaDon.Name = "txtMaHoaDon";
            this.txtMaHoaDon.ReadOnly = true;
            this.txtMaHoaDon.Size = new System.Drawing.Size(208, 34);
            this.txtMaHoaDon.TabIndex = 12;
            // 
            // txtMaPhieuKham
            // 
            this.txtMaPhieuKham.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtMaPhieuKham.Location = new System.Drawing.Point(523, 79);
            this.txtMaPhieuKham.Name = "txtMaPhieuKham";
            this.txtMaPhieuKham.ReadOnly = true;
            this.txtMaPhieuKham.Size = new System.Drawing.Size(208, 34);
            this.txtMaPhieuKham.TabIndex = 13;
            // 
            // txtHoTen
            // 
            this.txtHoTen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtHoTen.Location = new System.Drawing.Point(134, 140);
            this.txtHoTen.Name = "txtHoTen";
            this.txtHoTen.ReadOnly = true;
            this.txtHoTen.Size = new System.Drawing.Size(208, 34);
            this.txtHoTen.TabIndex = 14;
            // 
            // txtNgayKham
            // 
            this.txtNgayKham.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtNgayKham.Location = new System.Drawing.Point(523, 140);
            this.txtNgayKham.Name = "txtNgayKham";
            this.txtNgayKham.ReadOnly = true;
            this.txtNgayKham.Size = new System.Drawing.Size(208, 34);
            this.txtNgayKham.TabIndex = 15;
            // 
            // txtTienKham
            // 
            this.txtTienKham.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTienKham.Location = new System.Drawing.Point(134, 198);
            this.txtTienKham.Name = "txtTienKham";
            this.txtTienKham.ReadOnly = true;
            this.txtTienKham.Size = new System.Drawing.Size(208, 34);
            this.txtTienKham.TabIndex = 16;
            // 
            // txtTienThuoc
            // 
            this.txtTienThuoc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtTienThuoc.Location = new System.Drawing.Point(523, 198);
            this.txtTienThuoc.Name = "txtTienThuoc";
            this.txtTienThuoc.ReadOnly = true;
            this.txtTienThuoc.Size = new System.Drawing.Size(208, 34);
            this.txtTienThuoc.TabIndex = 17;
            // 
            // frmHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(744, 633);
            this.ControlBox = false;
            this.Controls.Add(this.txtTienThuoc);
            this.Controls.Add(this.txtTienKham);
            this.Controls.Add(this.txtNgayKham);
            this.Controls.Add(this.txtHoTen);
            this.Controls.Add(this.txtMaPhieuKham);
            this.Controls.Add(this.txtMaHoaDon);
            this.Controls.Add(this.lblMaPhieuKham);
            this.Controls.Add(this.lblMaHoaDon);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.lblHienTongTien);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.grbDonThuoc);
            this.Controls.Add(this.lblTienThuoc);
            this.Controls.Add(this.lblTienKham);
            this.Controls.Add(this.lblNgayKham);
            this.Controls.Add(this.lblHoTen);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông Tin Hóa Đơn";
            this.grbDonThuoc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDonThuoc)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitle;
        private Label lblHoTen;
        private Label lblNgayKham;
        private Label lblTienKham;
        private Label lblTienThuoc;
        private GroupBox grbDonThuoc;
        private Label lblTongTien;
        private Label lblHienTongTien;
        private Button btnThanhToan;
        private Button btnDong;
        private Label lblMaHoaDon;
        private Label lblMaPhieuKham;
        private TextBox txtMaHoaDon;
        private TextBox txtMaPhieuKham;
        private TextBox txtHoTen;
        private TextBox txtNgayKham;
        private TextBox txtTienKham;
        private TextBox txtTienThuoc;
        private DataGridView dgvDonThuoc;
    }
}
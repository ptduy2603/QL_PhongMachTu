namespace QL_PhongMachTu
{
    partial class frmThemTTBenhNhan
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            btnThem = new Button();
            btnXoa = new Button();
            btnSua = new Button();
            btnThoat = new Button();
            btnLapPhieu = new Button();
            taiKhoanBindingSource = new BindingSource(components);
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            chkNu = new CheckBox();
            chkNam = new CheckBox();
            txtDiaChi = new TextBox();
            txtSDT = new TextBox();
            txtTenBenhNhan = new TextBox();
            txtMaBenhNhan = new TextBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            groupBox2 = new GroupBox();
            dataGridView1 = new DataGridView();
            MaBenhNhan = new DataGridViewTextBoxColumn();
            HoTen = new DataGridViewTextBoxColumn();
            NamSinh = new DataGridViewTextBoxColumn();
            DienThoai = new DataGridViewTextBoxColumn();
            DiaChi = new DataGridViewTextBoxColumn();
            GioiTinh = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)taiKhoanBindingSource).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.MenuHighlight;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(923, 41);
            label1.TabIndex = 0;
            label1.Text = "Thông Tin Bệnh Nhân";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnThem
            // 
            btnThem.BackColor = SystemColors.MenuHighlight;
            btnThem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(533, 243);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(168, 69);
            btnThem.TabIndex = 1;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = SystemColors.MenuHighlight;
            btnXoa.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(743, 243);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(168, 69);
            btnXoa.TabIndex = 2;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            btnSua.BackColor = SystemColors.MenuHighlight;
            btnSua.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(533, 336);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(168, 69);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = SystemColors.MenuHighlight;
            btnThoat.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnThoat.ForeColor = Color.White;
            btnThoat.Location = new Point(743, 336);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(168, 69);
            btnThoat.TabIndex = 4;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnLapPhieu
            // 
            btnLapPhieu.BackColor = SystemColors.MenuHighlight;
            btnLapPhieu.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnLapPhieu.ForeColor = Color.White;
            btnLapPhieu.Location = new Point(533, 429);
            btnLapPhieu.Name = "btnLapPhieu";
            btnLapPhieu.Size = new Size(378, 63);
            btnLapPhieu.TabIndex = 5;
            btnLapPhieu.Text = "Lập Phiếu Khám Bệnh";
            btnLapPhieu.UseVisualStyleBackColor = false;
            btnLapPhieu.Click += btnLapPhieu_Click;
            // 
            // taiKhoanBindingSource
            // 
            taiKhoanBindingSource.DataSource = typeof(TaiKhoan);
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(chkNu);
            groupBox1.Controls.Add(chkNam);
            groupBox1.Controls.Add(txtDiaChi);
            groupBox1.Controls.Add(txtSDT);
            groupBox1.Controls.Add(txtTenBenhNhan);
            groupBox1.Controls.Add(txtMaBenhNhan);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox1.Location = new Point(17, 49);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(894, 179);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập Thông Tin Bệnh Nhân";
            groupBox1.Enter += groupBox1_Enter;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(166, 129);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(273, 27);
            textBox1.TabIndex = 21;
            // 
            // chkNu
            // 
            chkNu.AutoSize = true;
            chkNu.Location = new Point(748, 30);
            chkNu.Name = "chkNu";
            chkNu.Size = new Size(53, 24);
            chkNu.TabIndex = 4;
            chkNu.Text = "Nữ";
            chkNu.UseVisualStyleBackColor = true;
            chkNu.CheckedChanged += chkNu_CheckedChanged_1;
            // 
            // chkNam
            // 
            chkNam.AutoSize = true;
            chkNam.Location = new Point(609, 30);
            chkNam.Name = "chkNam";
            chkNam.Size = new Size(65, 24);
            chkNam.TabIndex = 3;
            chkNam.Text = "Nam";
            chkNam.UseVisualStyleBackColor = true;
            chkNam.CheckedChanged += chkNam_CheckedChanged;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(592, 129);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(273, 27);
            txtDiaChi.TabIndex = 6;
            // 
            // txtSDT
            // 
            txtSDT.Location = new Point(592, 76);
            txtSDT.Name = "txtSDT";
            txtSDT.Size = new Size(273, 27);
            txtSDT.TabIndex = 5;
            // 
            // txtTenBenhNhan
            // 
            txtTenBenhNhan.Location = new Point(166, 76);
            txtTenBenhNhan.Name = "txtTenBenhNhan";
            txtTenBenhNhan.Size = new Size(273, 27);
            txtTenBenhNhan.TabIndex = 1;
            // 
            // txtMaBenhNhan
            // 
            txtMaBenhNhan.Location = new Point(166, 23);
            txtMaBenhNhan.Name = "txtMaBenhNhan";
            txtMaBenhNhan.Size = new Size(273, 27);
            txtMaBenhNhan.TabIndex = 0;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(490, 136);
            label7.Name = "label7";
            label7.Size = new Size(58, 20);
            label7.TabIndex = 19;
            label7.Text = "Địa Chỉ";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(490, 83);
            label6.Name = "label6";
            label6.Size = new Size(84, 20);
            label6.TabIndex = 18;
            label6.Text = "Điện Thoại";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(490, 30);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 17;
            label5.Text = "Giới Tính";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(29, 136);
            label4.Name = "label4";
            label4.Size = new Size(77, 20);
            label4.TabIndex = 16;
            label4.Text = "Năm Sinh";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(29, 83);
            label3.Name = "label3";
            label3.Size = new Size(79, 20);
            label3.TabIndex = 15;
            label3.Text = "Họ Và Tên";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(29, 30);
            label2.Name = "label2";
            label2.Size = new Size(113, 20);
            label2.TabIndex = 14;
            label2.Text = "Mã Bệnh Nhân";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dataGridView1);
            groupBox2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            groupBox2.Location = new Point(17, 234);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(507, 266);
            groupBox2.TabIndex = 6;
            groupBox2.TabStop = false;
            groupBox2.Text = "Danh Sách Bệnh Nhân";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { MaBenhNhan, HoTen, NamSinh, DienThoai, DiaChi, GioiTinh });
            dataGridView1.Location = new Point(6, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(484, 223);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // MaBenhNhan
            // 
            MaBenhNhan.HeaderText = "Mã Bệnh Nhân";
            MaBenhNhan.MinimumWidth = 6;
            MaBenhNhan.Name = "MaBenhNhan";
            MaBenhNhan.ReadOnly = true;
            MaBenhNhan.Width = 90;
            // 
            // HoTen
            // 
            HoTen.HeaderText = "Họ Tên";
            HoTen.MinimumWidth = 6;
            HoTen.Name = "HoTen";
            HoTen.ReadOnly = true;
            HoTen.Width = 125;
            // 
            // NamSinh
            // 
            NamSinh.HeaderText = "Năm Sinh";
            NamSinh.MinimumWidth = 6;
            NamSinh.Name = "NamSinh";
            NamSinh.ReadOnly = true;
            NamSinh.Width = 125;
            // 
            // DienThoai
            // 
            DienThoai.HeaderText = "Điện Thoại";
            DienThoai.MinimumWidth = 6;
            DienThoai.Name = "DienThoai";
            DienThoai.ReadOnly = true;
            DienThoai.Width = 125;
            // 
            // DiaChi
            // 
            DiaChi.HeaderText = "Địa Chỉ";
            DiaChi.MinimumWidth = 6;
            DiaChi.Name = "DiaChi";
            DiaChi.ReadOnly = true;
            DiaChi.Width = 125;
            // 
            // GioiTinh
            // 
            GioiTinh.HeaderText = "Giới Tính";
            GioiTinh.MinimumWidth = 6;
            GioiTinh.Name = "GioiTinh";
            GioiTinh.ReadOnly = true;
            GioiTinh.Width = 125;
            // 
            // frmThemTTBenhNhan
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(923, 512);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnLapPhieu);
            Controls.Add(btnThoat);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(label1);
            MaximizeBox = false;
            Name = "frmThemTTBenhNhan";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Thêm Thông Tin Bệnh Nhân";
            Load += frmThemTTBenhNhan_Load;
            ((System.ComponentModel.ISupportInitialize)taiKhoanBindingSource).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnThem;
        private Button btnXoa;
        private Button btnSua;
        private Button btnThoat;
        private Button btnLapPhieu;
        private BindingSource taiKhoanBindingSource;
        private GroupBox groupBox1;
        private CheckBox chkNu;
        private CheckBox chkNam;
        private TextBox txtDiaChi;
        private TextBox txtSDT;
        private TextBox txtTenBenhNhan;
        private TextBox txtMaBenhNhan;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private TextBox textBox1;
        private DataGridViewTextBoxColumn MaBenhNhan;
        private DataGridViewTextBoxColumn HoTen;
        private DataGridViewTextBoxColumn NamSinh;
        private DataGridViewTextBoxColumn DienThoai;
        private DataGridViewTextBoxColumn DiaChi;
        private DataGridViewTextBoxColumn GioiTinh;
    }
}
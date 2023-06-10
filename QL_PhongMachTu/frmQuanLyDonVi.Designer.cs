namespace QL_PhongMachTu
{
    partial class frmQuanLyDonVi
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
            label1 = new Label();
            btnThoat = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            grbDanhSachTaiKhoan = new GroupBox();
            dvwDanhSachDonVi = new DataGridView();
            groupBox1 = new GroupBox();
            txtTenDonVi = new TextBox();
            txtMaDonVi = new TextBox();
            label3 = new Label();
            label2 = new Label();
            grbDanhSachTaiKhoan.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dvwDanhSachDonVi).BeginInit();
            groupBox1.SuspendLayout();
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
            label1.Size = new Size(771, 46);
            label1.TabIndex = 0;
            label1.Text = "Quản Lý Đơn Vị";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = SystemColors.MenuHighlight;
            btnThoat.Cursor = Cursors.Hand;
            btnThoat.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnThoat.ForeColor = Color.White;
            btnThoat.Location = new Point(638, 348);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(128, 59);
            btnThoat.TabIndex = 15;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            btnThoat.Click += btnThoat_Click;
            // 
            // btnSua
            // 
            btnSua.BackColor = SystemColors.MenuHighlight;
            btnSua.Cursor = Cursors.Hand;
            btnSua.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(486, 348);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(128, 59);
            btnSua.TabIndex = 14;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            btnSua.Click += btnSua_Click;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = SystemColors.MenuHighlight;
            btnXoa.Cursor = Cursors.Hand;
            btnXoa.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnXoa.ForeColor = Color.White;
            btnXoa.Location = new Point(638, 251);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(128, 59);
            btnXoa.TabIndex = 13;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            btnXoa.Click += btnXoa_Click;
            // 
            // btnThem
            // 
            btnThem.BackColor = SystemColors.MenuHighlight;
            btnThem.Cursor = Cursors.Hand;
            btnThem.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnThem.ForeColor = Color.White;
            btnThem.Location = new Point(486, 251);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(128, 59);
            btnThem.TabIndex = 12;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // grbDanhSachTaiKhoan
            // 
            grbDanhSachTaiKhoan.Controls.Add(dvwDanhSachDonVi);
            grbDanhSachTaiKhoan.Location = new Point(12, 201);
            grbDanhSachTaiKhoan.Name = "grbDanhSachTaiKhoan";
            grbDanhSachTaiKhoan.Size = new Size(465, 241);
            grbDanhSachTaiKhoan.TabIndex = 16;
            grbDanhSachTaiKhoan.TabStop = false;
            grbDanhSachTaiKhoan.Text = "Danh Sách Đơn Vị";
            // 
            // dvwDanhSachDonVi
            // 
            dvwDanhSachDonVi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dvwDanhSachDonVi.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dvwDanhSachDonVi.Dock = DockStyle.Fill;
            dvwDanhSachDonVi.Location = new Point(3, 23);
            dvwDanhSachDonVi.Name = "dvwDanhSachDonVi";
            dvwDanhSachDonVi.ReadOnly = true;
            dvwDanhSachDonVi.RowHeadersWidth = 51;
            dvwDanhSachDonVi.RowTemplate.Height = 29;
            dvwDanhSachDonVi.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dvwDanhSachDonVi.Size = new Size(459, 215);
            dvwDanhSachDonVi.TabIndex = 0;
            dvwDanhSachDonVi.CellClick += dvwDanhSachTaiKhoan_CellClick;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(txtTenDonVi);
            groupBox1.Controls.Add(txtMaDonVi);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 55);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(747, 149);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập Đơn Vị";
            // 
            // txtTenDonVi
            // 
            txtTenDonVi.BackColor = SystemColors.Menu;
            txtTenDonVi.Location = new Point(455, 88);
            txtTenDonVi.Name = "txtTenDonVi";
            txtTenDonVi.Size = new Size(231, 27);
            txtTenDonVi.TabIndex = 3;
            // 
            // txtMaDonVi
            // 
            txtMaDonVi.BackColor = SystemColors.Menu;
            txtMaDonVi.Location = new Point(31, 88);
            txtMaDonVi.Name = "txtMaDonVi";
            txtMaDonVi.Size = new Size(231, 27);
            txtMaDonVi.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(455, 35);
            label3.Name = "label3";
            label3.Size = new Size(139, 32);
            label3.TabIndex = 1;
            label3.Text = "Tên Đơn Vị";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(31, 35);
            label2.Name = "label2";
            label2.Size = new Size(135, 32);
            label2.TabIndex = 0;
            label2.Text = "Mã Đơn Vị";
            // 
            // frmQuanLyDonVi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(771, 442);
            Controls.Add(groupBox1);
            Controls.Add(grbDanhSachTaiKhoan);
            Controls.Add(btnThoat);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(label1);
            Name = "frmQuanLyDonVi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmQuanLyDonVi";
            Load += frmQuanLyDonVi_Load;
            grbDanhSachTaiKhoan.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dvwDanhSachDonVi).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btnThoat;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private GroupBox grbDanhSachTaiKhoan;
        private DataGridView dvwDanhSachDonVi;
        private GroupBox groupBox1;
        private TextBox txtTenDonVi;
        private TextBox txtMaDonVi;
        private Label label3;
        private Label label2;
    }
}
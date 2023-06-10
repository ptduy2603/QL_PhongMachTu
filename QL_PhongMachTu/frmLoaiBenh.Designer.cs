namespace QL_PhongMachTu
{
    partial class frmLoaiBenh
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
            gbxLoaiBenh = new GroupBox();
            dtvLoaiBenh = new DataGridView();
            btnThoat = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnThem = new Button();
            label1 = new Label();
            groupBox1 = new GroupBox();
            txtTenLoaiBenh = new TextBox();
            txtMaLoaiBenh = new TextBox();
            label3 = new Label();
            label2 = new Label();
            gbxLoaiBenh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtvLoaiBenh).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // gbxLoaiBenh
            // 
            gbxLoaiBenh.Controls.Add(dtvLoaiBenh);
            gbxLoaiBenh.Location = new Point(12, 205);
            gbxLoaiBenh.Name = "gbxLoaiBenh";
            gbxLoaiBenh.Size = new Size(465, 241);
            gbxLoaiBenh.TabIndex = 23;
            gbxLoaiBenh.TabStop = false;
            gbxLoaiBenh.Text = "Danh Sách Loại Bệnh";
            // 
            // dtvLoaiBenh
            // 
            dtvLoaiBenh.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtvLoaiBenh.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtvLoaiBenh.Dock = DockStyle.Fill;
            dtvLoaiBenh.Location = new Point(3, 23);
            dtvLoaiBenh.Name = "dtvLoaiBenh";
            dtvLoaiBenh.ReadOnly = true;
            dtvLoaiBenh.RowHeadersWidth = 51;
            dtvLoaiBenh.RowTemplate.Height = 29;
            dtvLoaiBenh.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dtvLoaiBenh.Size = new Size(459, 215);
            dtvLoaiBenh.TabIndex = 0;
            dtvLoaiBenh.CellClick += dtvLoaiBenh_CellClick;
            // 
            // btnThoat
            // 
            btnThoat.BackColor = SystemColors.MenuHighlight;
            btnThoat.Cursor = Cursors.Hand;
            btnThoat.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnThoat.ForeColor = Color.White;
            btnThoat.Location = new Point(638, 352);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(128, 59);
            btnThoat.TabIndex = 22;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;            // 
            // btnSua
            // 
            btnSua.BackColor = SystemColors.MenuHighlight;
            btnSua.Cursor = Cursors.Hand;
            btnSua.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSua.ForeColor = Color.White;
            btnSua.Location = new Point(486, 352);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(128, 59);
            btnSua.TabIndex = 21;
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
            btnXoa.Location = new Point(638, 255);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(128, 59);
            btnXoa.TabIndex = 20;
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
            btnThem.Location = new Point(486, 255);
            btnThem.Name = "btnThem";
            btnThem.Size = new Size(128, 59);
            btnThem.TabIndex = 19;
            btnThem.Text = "Thêm";
            btnThem.UseVisualStyleBackColor = false;
            btnThem.Click += btnThem_Click;
            // 
            // label1
            // 
            label1.BackColor = SystemColors.MenuHighlight;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(800, 46);
            label1.TabIndex = 18;
            label1.Text = "Quản Lý Loại Bệnh";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.White;
            groupBox1.Controls.Add(txtTenLoaiBenh);
            groupBox1.Controls.Add(txtMaLoaiBenh);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(12, 59);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(747, 149);
            groupBox1.TabIndex = 24;
            groupBox1.TabStop = false;
            groupBox1.Text = "Nhập Loại Bệnh";
            // 
            // txtTenLoaiBenh
            // 
            txtTenLoaiBenh.BackColor = SystemColors.Menu;
            txtTenLoaiBenh.Location = new Point(455, 88);
            txtTenLoaiBenh.Name = "txtTenLoaiBenh";
            txtTenLoaiBenh.Size = new Size(231, 27);
            txtTenLoaiBenh.TabIndex = 3;
            // 
            // txtMaLoaiBenh
            // 
            txtMaLoaiBenh.BackColor = SystemColors.Menu;
            txtMaLoaiBenh.Location = new Point(31, 88);
            txtMaLoaiBenh.Name = "txtMaLoaiBenh";
            txtMaLoaiBenh.Size = new Size(231, 27);
            txtMaLoaiBenh.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(455, 35);
            label3.Name = "label3";
            label3.Size = new Size(172, 32);
            label3.TabIndex = 1;
            label3.Text = "Tên Loại Bệnh";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(31, 35);
            label2.Name = "label2";
            label2.Size = new Size(168, 32);
            label2.TabIndex = 0;
            label2.Text = "Mã Loại Bệnh";
            // 
            // frmLoaiBenh
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            ControlBox = false;
            Controls.Add(gbxLoaiBenh);
            Controls.Add(btnThoat);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnThem);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "frmLoaiBenh";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Loại Bệnh";
            gbxLoaiBenh.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtvLoaiBenh).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gbxLoaiBenh;
        private DataGridView dtvLoaiBenh;
        private Button btnThoat;
        private Button btnSua;
        private Button btnXoa;
        private Button btnThem;
        private Label label1;
        private GroupBox groupBox1;
        private TextBox txtTenLoaiBenh;
        private TextBox txtMaLoaiBenh;
        private Label label3;
        private Label label2;
    }
}
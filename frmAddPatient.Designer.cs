namespace QL_PhongMachTu
{
    partial class frmAddPatient
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
            splitContainer1 = new SplitContainer();
            lblFrm = new Label();
            btnLuu = new Button();
            txtDiaChi = new TextBox();
            lblDiaChi = new Label();
            txtSdt = new TextBox();
            lblSdt = new Label();
            rdoNu = new RadioButton();
            rdoNam = new RadioButton();
            lblGioiTinh = new Label();
            lblNgaySinh = new Label();
            dtpNgaySinh = new DateTimePicker();
            lblTenBN = new Label();
            txtTenBN = new TextBox();
            txtMaBN = new TextBox();
            lblMaBN = new Label();
            btnThoat = new Button();
            btnLamTrong = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = SystemColors.MenuHighlight;
            splitContainer1.Panel1.Controls.Add(lblFrm);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(btnLamTrong);
            splitContainer1.Panel2.Controls.Add(btnThoat);
            splitContainer1.Panel2.Controls.Add(btnLuu);
            splitContainer1.Panel2.Controls.Add(txtDiaChi);
            splitContainer1.Panel2.Controls.Add(lblDiaChi);
            splitContainer1.Panel2.Controls.Add(txtSdt);
            splitContainer1.Panel2.Controls.Add(lblSdt);
            splitContainer1.Panel2.Controls.Add(rdoNu);
            splitContainer1.Panel2.Controls.Add(rdoNam);
            splitContainer1.Panel2.Controls.Add(lblGioiTinh);
            splitContainer1.Panel2.Controls.Add(lblNgaySinh);
            splitContainer1.Panel2.Controls.Add(dtpNgaySinh);
            splitContainer1.Panel2.Controls.Add(lblTenBN);
            splitContainer1.Panel2.Controls.Add(txtTenBN);
            splitContainer1.Panel2.Controls.Add(txtMaBN);
            splitContainer1.Panel2.Controls.Add(lblMaBN);
            splitContainer1.Size = new Size(931, 562);
            splitContainer1.SplitterDistance = 72;
            splitContainer1.TabIndex = 0;
            // 
            // lblFrm
            // 
            lblFrm.AutoSize = true;
            lblFrm.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lblFrm.Location = new Point(352, 20);
            lblFrm.Name = "lblFrm";
            lblFrm.Size = new Size(205, 32);
            lblFrm.TabIndex = 0;
            lblFrm.Text = "Thêm bệnh nhân";
            // 
            // btnLuu
            // 
            btnLuu.BackColor = SystemColors.MenuHighlight;
            btnLuu.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnLuu.ForeColor = SystemColors.ButtonHighlight;
            btnLuu.Location = new Point(156, 313);
            btnLuu.Name = "btnLuu";
            btnLuu.Size = new Size(156, 67);
            btnLuu.TabIndex = 13;
            btnLuu.Text = "Lưu";
            btnLuu.UseVisualStyleBackColor = false;
            // 
            // txtDiaChi
            // 
            txtDiaChi.Location = new Point(636, 210);
            txtDiaChi.Name = "txtDiaChi";
            txtDiaChi.Size = new Size(236, 31);
            txtDiaChi.TabIndex = 12;
            // 
            // lblDiaChi
            // 
            lblDiaChi.AutoSize = true;
            lblDiaChi.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblDiaChi.Location = new Point(552, 210);
            lblDiaChi.Name = "lblDiaChi";
            lblDiaChi.Size = new Size(78, 28);
            lblDiaChi.TabIndex = 11;
            lblDiaChi.Text = "Địa chỉ:";
            // 
            // txtSdt
            // 
            txtSdt.Location = new Point(636, 142);
            txtSdt.Name = "txtSdt";
            txtSdt.Size = new Size(236, 31);
            txtSdt.TabIndex = 10;
            // 
            // lblSdt
            // 
            lblSdt.AutoSize = true;
            lblSdt.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblSdt.Location = new Point(492, 139);
            lblSdt.Name = "lblSdt";
            lblSdt.Size = new Size(138, 28);
            lblSdt.TabIndex = 9;
            lblSdt.Text = "Số điện thoại:";
            // 
            // rdoNu
            // 
            rdoNu.AutoSize = true;
            rdoNu.Location = new Point(740, 73);
            rdoNu.Name = "rdoNu";
            rdoNu.Size = new Size(61, 29);
            rdoNu.TabIndex = 8;
            rdoNu.TabStop = true;
            rdoNu.Text = "Nữ";
            rdoNu.UseVisualStyleBackColor = true;
            // 
            // rdoNam
            // 
            rdoNam.AutoSize = true;
            rdoNam.Location = new Point(636, 75);
            rdoNam.Name = "rdoNam";
            rdoNam.Size = new Size(75, 29);
            rdoNam.TabIndex = 7;
            rdoNam.TabStop = true;
            rdoNam.Text = "Nam";
            rdoNam.UseVisualStyleBackColor = true;
            // 
            // lblGioiTinh
            // 
            lblGioiTinh.AutoSize = true;
            lblGioiTinh.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblGioiTinh.Location = new Point(535, 74);
            lblGioiTinh.Name = "lblGioiTinh";
            lblGioiTinh.Size = new Size(95, 28);
            lblGioiTinh.TabIndex = 6;
            lblGioiTinh.Text = "Giới tính:";
            // 
            // lblNgaySinh
            // 
            lblNgaySinh.AutoSize = true;
            lblNgaySinh.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblNgaySinh.Location = new Point(60, 210);
            lblNgaySinh.Name = "lblNgaySinh";
            lblNgaySinh.Size = new Size(108, 28);
            lblNgaySinh.TabIndex = 5;
            lblNgaySinh.Text = "Ngày sinh:";
            // 
            // dtpNgaySinh
            // 
            dtpNgaySinh.Location = new Point(174, 210);
            dtpNgaySinh.Name = "dtpNgaySinh";
            dtpNgaySinh.Size = new Size(264, 31);
            dtpNgaySinh.TabIndex = 4;
            // 
            // lblTenBN
            // 
            lblTenBN.AutoSize = true;
            lblTenBN.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblTenBN.Location = new Point(62, 142);
            lblTenBN.Name = "lblTenBN";
            lblTenBN.Size = new Size(106, 28);
            lblTenBN.TabIndex = 3;
            lblTenBN.Text = "Họ và tên:";
            // 
            // txtTenBN
            // 
            txtTenBN.Location = new Point(174, 142);
            txtTenBN.Name = "txtTenBN";
            txtTenBN.Size = new Size(264, 31);
            txtTenBN.TabIndex = 2;
            // 
            // txtMaBN
            // 
            txtMaBN.Location = new Point(174, 74);
            txtMaBN.Name = "txtMaBN";
            txtMaBN.Size = new Size(264, 31);
            txtMaBN.TabIndex = 1;
            // 
            // lblMaBN
            // 
            lblMaBN.AutoSize = true;
            lblMaBN.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            lblMaBN.Location = new Point(23, 74);
            lblMaBN.Name = "lblMaBN";
            lblMaBN.Size = new Size(150, 28);
            lblMaBN.TabIndex = 0;
            lblMaBN.Text = "Mã bệnh nhân:";
            // 
            // btnThoat
            // 
            btnThoat.BackColor = SystemColors.MenuHighlight;
            btnThoat.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnThoat.ForeColor = SystemColors.ButtonHighlight;
            btnThoat.Location = new Point(645, 313);
            btnThoat.Name = "btnThoat";
            btnThoat.Size = new Size(156, 67);
            btnThoat.TabIndex = 14;
            btnThoat.Text = "Thoát";
            btnThoat.UseVisualStyleBackColor = false;
            // 
            // btnLamTrong
            // 
            btnLamTrong.BackColor = SystemColors.MenuHighlight;
            btnLamTrong.Font = new Font("Segoe UI Variable Display", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnLamTrong.ForeColor = SystemColors.ButtonHighlight;
            btnLamTrong.Location = new Point(401, 313);
            btnLamTrong.Name = "btnLamTrong";
            btnLamTrong.Size = new Size(156, 67);
            btnLamTrong.TabIndex = 15;
            btnLamTrong.Text = "Làm trống\r\nbiểu mẫu";
            btnLamTrong.UseVisualStyleBackColor = false;
            // 
            // frmAddPatient
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(931, 562);
            Controls.Add(splitContainer1);
            Name = "frmAddPatient";
            Text = "frmAddPatient";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label lblFrm;
        private Label lblMaBN;
        private TextBox txtTenBN;
        private TextBox txtMaBN;
        private Label lblTenBN;
        private Label lblGioiTinh;
        private Label lblNgaySinh;
        private DateTimePicker dtpNgaySinh;
        private Label lblDiaChi;
        private TextBox txtSdt;
        private Label lblSdt;
        private RadioButton rdoNu;
        private RadioButton rdoNam;
        private TextBox txtDiaChi;
        private Button btnLuu;
        private Button btnLamTrong;
        private Button btnThoat;
    }
}
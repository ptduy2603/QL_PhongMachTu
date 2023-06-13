namespace QL_PhongMachTu
{
    partial class frmLapHoaDon
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
            this.grbDanhSachPhieuKham = new System.Windows.Forms.GroupBox();
            this.dgvDanhSachPhieuKham = new System.Windows.Forms.DataGridView();
            this.lblNgayLap = new System.Windows.Forms.Label();
            this.dtpNgayLap = new System.Windows.Forms.DateTimePicker();
            this.btnXemHoaDon = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grbDanhSachPhieuKham.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachPhieuKham)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(866, 67);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Lập Hóa Đơn Thanh Toán";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grbDanhSachPhieuKham
            // 
            this.grbDanhSachPhieuKham.Controls.Add(this.dgvDanhSachPhieuKham);
            this.grbDanhSachPhieuKham.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grbDanhSachPhieuKham.Location = new System.Drawing.Point(12, 140);
            this.grbDanhSachPhieuKham.Name = "grbDanhSachPhieuKham";
            this.grbDanhSachPhieuKham.Size = new System.Drawing.Size(846, 305);
            this.grbDanhSachPhieuKham.TabIndex = 2;
            this.grbDanhSachPhieuKham.TabStop = false;
            this.grbDanhSachPhieuKham.Text = "Danh Sách Phiếu Khám Trong Ngày";
            // 
            // dgvDanhSachPhieuKham
            // 
            this.dgvDanhSachPhieuKham.AllowUserToAddRows = false;
            this.dgvDanhSachPhieuKham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDanhSachPhieuKham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDanhSachPhieuKham.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDanhSachPhieuKham.Location = new System.Drawing.Point(3, 26);
            this.dgvDanhSachPhieuKham.Name = "dgvDanhSachPhieuKham";
            this.dgvDanhSachPhieuKham.ReadOnly = true;
            this.dgvDanhSachPhieuKham.RowHeadersWidth = 51;
            this.dgvDanhSachPhieuKham.RowTemplate.Height = 29;
            this.dgvDanhSachPhieuKham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDanhSachPhieuKham.Size = new System.Drawing.Size(840, 276);
            this.dgvDanhSachPhieuKham.TabIndex = 0;
            // 
            // lblNgayLap
            // 
            this.lblNgayLap.AutoSize = true;
            this.lblNgayLap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNgayLap.Location = new System.Drawing.Point(274, 91);
            this.lblNgayLap.Name = "lblNgayLap";
            this.lblNgayLap.Size = new System.Drawing.Size(101, 28);
            this.lblNgayLap.TabIndex = 3;
            this.lblNgayLap.Text = "Ngày Lập";
            // 
            // dtpNgayLap
            // 
            this.dtpNgayLap.CalendarFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dtpNgayLap.CustomFormat = "dd/MM/yyyy";
            this.dtpNgayLap.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.dtpNgayLap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayLap.Location = new System.Drawing.Point(381, 88);
            this.dtpNgayLap.Name = "dtpNgayLap";
            this.dtpNgayLap.Size = new System.Drawing.Size(250, 34);
            this.dtpNgayLap.TabIndex = 4;
            this.dtpNgayLap.ValueChanged += new System.EventHandler(this.dtpNgayLap_ValueChanged);
            // 
            // btnXemHoaDon
            // 
            this.btnXemHoaDon.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnXemHoaDon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXemHoaDon.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXemHoaDon.ForeColor = System.Drawing.Color.White;
            this.btnXemHoaDon.Location = new System.Drawing.Point(70, 466);
            this.btnXemHoaDon.Name = "btnXemHoaDon";
            this.btnXemHoaDon.Size = new System.Drawing.Size(324, 52);
            this.btnXemHoaDon.TabIndex = 5;
            this.btnXemHoaDon.Text = "Xem Hóa Đơn";
            this.btnXemHoaDon.UseVisualStyleBackColor = false;
            this.btnXemHoaDon.Click += new System.EventHandler(this.btnXemHoaDon_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(459, 466);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(324, 52);
            this.btnThoat.TabIndex = 6;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmLapHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(866, 538);
            this.ControlBox = false;
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXemHoaDon);
            this.Controls.Add(this.dtpNgayLap);
            this.Controls.Add(this.lblNgayLap);
            this.Controls.Add(this.grbDanhSachPhieuKham);
            this.Controls.Add(this.lblTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmLapHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lập Hóa Đơn Thanh Toán";
            this.Load += new System.EventHandler(this.frmLapHoaDon_Load);
            this.grbDanhSachPhieuKham.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhSachPhieuKham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblTitle;
        private GroupBox grbDanhSachPhieuKham;
        private Label lblNgayLap;
        private DateTimePicker dtpNgayLap;
        private DataGridView dgvDanhSachPhieuKham;
        private Button btnXemHoaDon;
        private Button btnThoat;
    }
}
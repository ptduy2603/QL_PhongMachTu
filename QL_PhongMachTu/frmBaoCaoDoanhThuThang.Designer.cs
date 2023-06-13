namespace QL_PhongMachTu
{
    partial class frmBaoCaoDoanhThuThang
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
            this.label1 = new System.Windows.Forms.Label();
            this.grbNgayLapBaoCao = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpNgayLapBaoCao = new System.Windows.Forms.DateTimePicker();
            this.grbKetQuaBaoCao = new System.Windows.Forms.GroupBox();
            this.dgvBaoCaoDoanhThu = new System.Windows.Forms.DataGridView();
            this.btnLapBaoCao = new System.Windows.Forms.Button();
            this.btnXuatBaoCao = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grbNgayLapBaoCao.SuspendLayout();
            this.grbKetQuaBaoCao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCaoDoanhThu)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(1054, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "Báo Cáo Doanh Thu Tháng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grbNgayLapBaoCao
            // 
            this.grbNgayLapBaoCao.Controls.Add(this.label2);
            this.grbNgayLapBaoCao.Controls.Add(this.dtpNgayLapBaoCao);
            this.grbNgayLapBaoCao.Location = new System.Drawing.Point(12, 52);
            this.grbNgayLapBaoCao.Name = "grbNgayLapBaoCao";
            this.grbNgayLapBaoCao.Size = new System.Drawing.Size(690, 118);
            this.grbNgayLapBaoCao.TabIndex = 1;
            this.grbNgayLapBaoCao.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(96, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tháng/Năm";
            // 
            // dtpNgayLapBaoCao
            // 
            this.dtpNgayLapBaoCao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpNgayLapBaoCao.CustomFormat = "MM/yyyy";
            this.dtpNgayLapBaoCao.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpNgayLapBaoCao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayLapBaoCao.Location = new System.Drawing.Point(255, 45);
            this.dtpNgayLapBaoCao.Name = "dtpNgayLapBaoCao";
            this.dtpNgayLapBaoCao.Size = new System.Drawing.Size(241, 39);
            this.dtpNgayLapBaoCao.TabIndex = 0;
            // 
            // grbKetQuaBaoCao
            // 
            this.grbKetQuaBaoCao.Controls.Add(this.dgvBaoCaoDoanhThu);
            this.grbKetQuaBaoCao.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grbKetQuaBaoCao.Location = new System.Drawing.Point(12, 176);
            this.grbKetQuaBaoCao.Name = "grbKetQuaBaoCao";
            this.grbKetQuaBaoCao.Size = new System.Drawing.Size(1030, 350);
            this.grbKetQuaBaoCao.TabIndex = 2;
            this.grbKetQuaBaoCao.TabStop = false;
            this.grbKetQuaBaoCao.Text = "Kết quả báo cáo";
            // 
            // dgvBaoCaoDoanhThu
            // 
            this.dgvBaoCaoDoanhThu.AllowUserToAddRows = false;
            this.dgvBaoCaoDoanhThu.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBaoCaoDoanhThu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaoCaoDoanhThu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBaoCaoDoanhThu.Location = new System.Drawing.Point(3, 26);
            this.dgvBaoCaoDoanhThu.Name = "dgvBaoCaoDoanhThu";
            this.dgvBaoCaoDoanhThu.ReadOnly = true;
            this.dgvBaoCaoDoanhThu.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvBaoCaoDoanhThu.RowHeadersWidth = 51;
            this.dgvBaoCaoDoanhThu.RowTemplate.Height = 29;
            this.dgvBaoCaoDoanhThu.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBaoCaoDoanhThu.Size = new System.Drawing.Size(1024, 321);
            this.dgvBaoCaoDoanhThu.TabIndex = 0;
            // 
            // btnLapBaoCao
            // 
            this.btnLapBaoCao.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLapBaoCao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLapBaoCao.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLapBaoCao.ForeColor = System.Drawing.Color.White;
            this.btnLapBaoCao.Location = new System.Drawing.Point(719, 88);
            this.btnLapBaoCao.Name = "btnLapBaoCao";
            this.btnLapBaoCao.Size = new System.Drawing.Size(160, 83);
            this.btnLapBaoCao.TabIndex = 3;
            this.btnLapBaoCao.Text = "Lập Báo Cáo";
            this.btnLapBaoCao.UseVisualStyleBackColor = false;
            this.btnLapBaoCao.Click += new System.EventHandler(this.btnLapBaoCao_Click);
            // 
            // btnXuatBaoCao
            // 
            this.btnXuatBaoCao.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnXuatBaoCao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXuatBaoCao.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnXuatBaoCao.ForeColor = System.Drawing.Color.White;
            this.btnXuatBaoCao.Location = new System.Drawing.Point(882, 88);
            this.btnXuatBaoCao.Name = "btnXuatBaoCao";
            this.btnXuatBaoCao.Size = new System.Drawing.Size(160, 83);
            this.btnXuatBaoCao.TabIndex = 4;
            this.btnXuatBaoCao.Text = "Xuất Báo Cáo";
            this.btnXuatBaoCao.UseVisualStyleBackColor = false;
            this.btnXuatBaoCao.Click += new System.EventHandler(this.btnXuatBaoCao_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(199, 547);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(640, 55);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmBaoCaoDoanhThuThang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 614);
            this.ControlBox = false;
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXuatBaoCao);
            this.Controls.Add(this.btnLapBaoCao);
            this.Controls.Add(this.grbKetQuaBaoCao);
            this.Controls.Add(this.grbNgayLapBaoCao);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frmBaoCaoDoanhThuThang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo Cáo Doanh Thu Tháng";
            this.grbNgayLapBaoCao.ResumeLayout(false);
            this.grbNgayLapBaoCao.PerformLayout();
            this.grbKetQuaBaoCao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCaoDoanhThu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private GroupBox grbNgayLapBaoCao;
        private GroupBox grbKetQuaBaoCao;
        private Button btnLapBaoCao;
        private Button btnXuatBaoCao;
        private Button btnThoat;
        private Label label2;
        private DateTimePicker dtpNgayLapBaoCao;
        private DataGridView dgvBaoCaoDoanhThu;
    }
}
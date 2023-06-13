namespace QL_PhongMachTu
{
    partial class frmBaoCaoSuDungThuoc
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
            this.grbNgayThang = new System.Windows.Forms.GroupBox();
            this.dtpNgayLapBaoCao = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.grbKetQuaBaoCao = new System.Windows.Forms.GroupBox();
            this.dgvBaoCaoSuDungThuoc = new System.Windows.Forms.DataGridView();
            this.btnLapBaoCao = new System.Windows.Forms.Button();
            this.btnXuatBaoCao = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.grbNgayThang.SuspendLayout();
            this.grbKetQuaBaoCao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCaoSuDungThuoc)).BeginInit();
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
            this.label1.Size = new System.Drawing.Size(1035, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Báo Cáo Sử Dụng Thuốc";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // grbNgayThang
            // 
            this.grbNgayThang.Controls.Add(this.dtpNgayLapBaoCao);
            this.grbNgayThang.Controls.Add(this.label2);
            this.grbNgayThang.Location = new System.Drawing.Point(12, 50);
            this.grbNgayThang.Name = "grbNgayThang";
            this.grbNgayThang.Size = new System.Drawing.Size(637, 118);
            this.grbNgayThang.TabIndex = 1;
            this.grbNgayThang.TabStop = false;
            // 
            // dtpNgayLapBaoCao
            // 
            this.dtpNgayLapBaoCao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtpNgayLapBaoCao.CustomFormat = "MM/yyyy";
            this.dtpNgayLapBaoCao.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dtpNgayLapBaoCao.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgayLapBaoCao.Location = new System.Drawing.Point(243, 47);
            this.dtpNgayLapBaoCao.Name = "dtpNgayLapBaoCao";
            this.dtpNgayLapBaoCao.Size = new System.Drawing.Size(281, 39);
            this.dtpNgayLapBaoCao.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(84, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 32);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tháng/Năm";
            // 
            // grbKetQuaBaoCao
            // 
            this.grbKetQuaBaoCao.Controls.Add(this.dgvBaoCaoSuDungThuoc);
            this.grbKetQuaBaoCao.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.grbKetQuaBaoCao.Location = new System.Drawing.Point(12, 174);
            this.grbKetQuaBaoCao.Name = "grbKetQuaBaoCao";
            this.grbKetQuaBaoCao.Size = new System.Drawing.Size(1012, 366);
            this.grbKetQuaBaoCao.TabIndex = 2;
            this.grbKetQuaBaoCao.TabStop = false;
            this.grbKetQuaBaoCao.Text = "Kết quả báo cáo";
            // 
            // dgvBaoCaoSuDungThuoc
            // 
            this.dgvBaoCaoSuDungThuoc.AllowUserToAddRows = false;
            this.dgvBaoCaoSuDungThuoc.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBaoCaoSuDungThuoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBaoCaoSuDungThuoc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvBaoCaoSuDungThuoc.Location = new System.Drawing.Point(3, 26);
            this.dgvBaoCaoSuDungThuoc.Name = "dgvBaoCaoSuDungThuoc";
            this.dgvBaoCaoSuDungThuoc.ReadOnly = true;
            this.dgvBaoCaoSuDungThuoc.RowHeadersWidth = 51;
            this.dgvBaoCaoSuDungThuoc.RowTemplate.Height = 29;
            this.dgvBaoCaoSuDungThuoc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBaoCaoSuDungThuoc.Size = new System.Drawing.Size(1006, 337);
            this.dgvBaoCaoSuDungThuoc.TabIndex = 0;
            // 
            // btnLapBaoCao
            // 
            this.btnLapBaoCao.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnLapBaoCao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLapBaoCao.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLapBaoCao.ForeColor = System.Drawing.Color.White;
            this.btnLapBaoCao.Location = new System.Drawing.Point(677, 80);
            this.btnLapBaoCao.Name = "btnLapBaoCao";
            this.btnLapBaoCao.Size = new System.Drawing.Size(157, 88);
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
            this.btnXuatBaoCao.Location = new System.Drawing.Point(864, 80);
            this.btnXuatBaoCao.Name = "btnXuatBaoCao";
            this.btnXuatBaoCao.Size = new System.Drawing.Size(157, 88);
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
            this.btnThoat.Location = new System.Drawing.Point(210, 560);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(622, 45);
            this.btnThoat.TabIndex = 5;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmBaoCaoSuDungThuoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 617);
            this.ControlBox = false;
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXuatBaoCao);
            this.Controls.Add(this.btnLapBaoCao);
            this.Controls.Add(this.grbKetQuaBaoCao);
            this.Controls.Add(this.grbNgayThang);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmBaoCaoSuDungThuoc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo sử dụng thuốc";
            this.grbNgayThang.ResumeLayout(false);
            this.grbNgayThang.PerformLayout();
            this.grbKetQuaBaoCao.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBaoCaoSuDungThuoc)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private GroupBox grbNgayThang;
        private GroupBox grbKetQuaBaoCao;
        private Button btnLapBaoCao;
        private Button btnXuatBaoCao;
        private Button btnThoat;
        private DateTimePicker dtpNgayLapBaoCao;
        private Label label2;
        private DataGridView dgvBaoCaoSuDungThuoc;
    }
}
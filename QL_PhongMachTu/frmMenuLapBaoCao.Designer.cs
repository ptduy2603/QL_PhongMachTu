namespace QL_PhongMachTu
{
    partial class frmMenuLapBaoCao
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
            this.btnBC_DoanhThuThang = new System.Windows.Forms.Button();
            this.btnBC_SuDungThuoc = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(673, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mời Bạn Lựa Chọn";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnBC_DoanhThuThang
            // 
            this.btnBC_DoanhThuThang.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnBC_DoanhThuThang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBC_DoanhThuThang.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBC_DoanhThuThang.ForeColor = System.Drawing.Color.White;
            this.btnBC_DoanhThuThang.Location = new System.Drawing.Point(44, 80);
            this.btnBC_DoanhThuThang.Name = "btnBC_DoanhThuThang";
            this.btnBC_DoanhThuThang.Size = new System.Drawing.Size(286, 142);
            this.btnBC_DoanhThuThang.TabIndex = 1;
            this.btnBC_DoanhThuThang.Text = "Lập Báo Cáo Doanh Thu Tháng";
            this.btnBC_DoanhThuThang.UseVisualStyleBackColor = false;
            this.btnBC_DoanhThuThang.Click += new System.EventHandler(this.btnBC_DoanhThuThang_Click);
            // 
            // btnBC_SuDungThuoc
            // 
            this.btnBC_SuDungThuoc.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnBC_SuDungThuoc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBC_SuDungThuoc.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBC_SuDungThuoc.ForeColor = System.Drawing.Color.White;
            this.btnBC_SuDungThuoc.Location = new System.Drawing.Point(346, 80);
            this.btnBC_SuDungThuoc.Name = "btnBC_SuDungThuoc";
            this.btnBC_SuDungThuoc.Size = new System.Drawing.Size(286, 142);
            this.btnBC_SuDungThuoc.TabIndex = 2;
            this.btnBC_SuDungThuoc.Text = "Lập Báo Cáo Sử Dụng Thuốc";
            this.btnBC_SuDungThuoc.UseVisualStyleBackColor = false;
            this.btnBC_SuDungThuoc.Click += new System.EventHandler(this.btnBC_SuDungThuoc_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnThoat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThoat.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnThoat.ForeColor = System.Drawing.Color.White;
            this.btnThoat.Location = new System.Drawing.Point(44, 246);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(588, 52);
            this.btnThoat.TabIndex = 3;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // frmMenuLapBaoCao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 320);
            this.ControlBox = false;
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnBC_SuDungThuoc);
            this.Controls.Add(this.btnBC_DoanhThuThang);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(691, 367);
            this.MinimumSize = new System.Drawing.Size(691, 367);
            this.Name = "frmMenuLapBaoCao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Lập Báo Cáo";
            this.ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Button btnBC_DoanhThuThang;
        private Button btnBC_SuDungThuoc;
        private Button btnThoat;
    }
}
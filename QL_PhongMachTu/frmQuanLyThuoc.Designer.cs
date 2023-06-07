namespace QL_PhongMachTu
{
    partial class frmQuanLyThuoc
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            groupBox1 = new GroupBox();
            dataGridView1 = new DataGridView();
            MaThuoc = new DataGridViewTextBoxColumn();
            TenThuoc = new DataGridViewTextBoxColumn();
            DonVi = new DataGridViewTextBoxColumn();
            GiaThuoc = new DataGridViewTextBoxColumn();
            CachDung = new DataGridViewTextBoxColumn();
            label6 = new Label();
            textBox5 = new TextBox();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = Color.CornflowerBlue;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.ControlLightLight;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(874, 34);
            label1.TabIndex = 0;
            label1.Text = "QUẢN LÝ THUỐC";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(33, 57);
            label2.Name = "label2";
            label2.Size = new Size(106, 28);
            label2.TabIndex = 1;
            label2.Text = "Mã Thuốc";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(33, 96);
            label3.Name = "label3";
            label3.Size = new Size(109, 28);
            label3.TabIndex = 2;
            label3.Text = "Tên Thuốc";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(33, 135);
            label4.Name = "label4";
            label4.Size = new Size(125, 28);
            label4.TabIndex = 3;
            label4.Text = "Đơn Vị Tính";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(33, 174);
            label5.Name = "label5";
            label5.Size = new Size(43, 28);
            label5.TabIndex = 4;
            label5.Text = "Giá";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 128, 255);
            button1.Cursor = Cursors.Hand;
            button1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ControlLightLight;
            button1.Location = new Point(12, 270);
            button1.Name = "button1";
            button1.Size = new Size(135, 57);
            button1.TabIndex = 5;
            button1.Text = "Thêm";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(128, 128, 255);
            button2.Cursor = Cursors.Hand;
            button2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.ControlLightLight;
            button2.Location = new Point(163, 270);
            button2.Name = "button2";
            button2.Size = new Size(135, 57);
            button2.TabIndex = 6;
            button2.Text = "Sửa";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(128, 128, 255);
            button3.Cursor = Cursors.Hand;
            button3.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.ControlLightLight;
            button3.Location = new Point(12, 348);
            button3.Name = "button3";
            button3.Size = new Size(135, 57);
            button3.TabIndex = 7;
            button3.Text = "Xóa";
            button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.FromArgb(128, 128, 255);
            button4.Cursor = Cursors.Hand;
            button4.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            button4.ForeColor = SystemColors.ControlLightLight;
            button4.Location = new Point(163, 348);
            button4.Name = "button4";
            button4.Size = new Size(135, 57);
            button4.TabIndex = 8;
            button4.Text = "Thoát";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(163, 55);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(135, 27);
            textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(163, 94);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(135, 27);
            textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(163, 133);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(135, 27);
            textBox3.TabIndex = 11;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(163, 172);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(135, 27);
            textBox4.TabIndex = 12;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dataGridView1);
            groupBox1.Location = new Point(327, 43);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(540, 362);
            groupBox1.TabIndex = 13;
            groupBox1.TabStop = false;
            groupBox1.Text = "Thông Tin Thuốc";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { MaThuoc, TenThuoc, DonVi, GiaThuoc, CachDung });
            dataGridView1.Location = new Point(6, 22);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(529, 334);
            dataGridView1.TabIndex = 0;
            // 
            // MaThuoc
            // 
            MaThuoc.HeaderText = "Mã Thuốc";
            MaThuoc.MinimumWidth = 6;
            MaThuoc.Name = "MaThuoc";
            MaThuoc.Width = 125;
            // 
            // TenThuoc
            // 
            TenThuoc.HeaderText = "Tên Thuốc";
            TenThuoc.MinimumWidth = 6;
            TenThuoc.Name = "TenThuoc";
            TenThuoc.Width = 130;
            // 
            // DonVi
            // 
            DonVi.HeaderText = "Đơn Vị Tính";
            DonVi.MinimumWidth = 6;
            DonVi.Name = "DonVi";
            DonVi.Width = 115;
            // 
            // GiaThuoc
            // 
            GiaThuoc.HeaderText = "Giá Thuốc";
            GiaThuoc.MinimumWidth = 6;
            GiaThuoc.Name = "GiaThuoc";
            GiaThuoc.Width = 125;
            // 
            // CachDung
            // 
            CachDung.HeaderText = "Cách Dùng";
            CachDung.MinimumWidth = 6;
            CachDung.Name = "CachDung";
            CachDung.Width = 125;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(33, 213);
            label6.Name = "label6";
            label6.Size = new Size(114, 28);
            label6.TabIndex = 14;
            label6.Text = "Cách Dùng";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(163, 214);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(135, 27);
            textBox5.TabIndex = 15;
            // 
            // frmQuanLyThuoc
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(874, 426);
            Controls.Add(textBox5);
            Controls.Add(label6);
            Controls.Add(groupBox1);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "frmQuanLyThuoc";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Quản Lý Thuốc";
            Load += frmQuanLyThuoc_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private GroupBox groupBox1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn MaThuoc;
        private DataGridViewTextBoxColumn TenThuoc;
        private DataGridViewTextBoxColumn DonVi;
        private DataGridViewTextBoxColumn GiaThuoc;
        private Label label6;
        private TextBox textBox5;
        private DataGridViewTextBoxColumn CachDung;
    }
}
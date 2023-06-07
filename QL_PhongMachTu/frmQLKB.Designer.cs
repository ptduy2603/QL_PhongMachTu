namespace QL_PhongMachTu
{
    partial class frmQLKB
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI", 23F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(787, 63);
            label1.TabIndex = 0;
            label1.Text = "Mời bạn lựa chọn";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click_1;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(87, 125);
            button1.Name = "button1";
            button1.Size = new Size(257, 115);
            button1.TabIndex = 1;
            button1.Text = "Thêm Thông Tin Bệnh Nhân";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Location = new Point(443, 125);
            button2.Name = "button2";
            button2.Size = new Size(257, 115);
            button2.TabIndex = 2;
            button2.Text = "Lập Phiếu Khám Bệnh";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(87, 246);
            button3.Name = "button3";
            button3.Size = new Size(257, 115);
            button3.TabIndex = 3;
            button3.Text = "Kê Toa Thuốc";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(87, 369);
            button4.Name = "button4";
            button4.Size = new Size(257, 115);
            button4.TabIndex = 4;
            button4.Text = "Kiểm Tra Hồ Sơ Bệnh Án";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(443, 246);
            button5.Name = "button5";
            button5.Size = new Size(257, 115);
            button5.TabIndex = 5;
            button5.Text = "Lập Hóa Đơn";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(443, 369);
            button6.Name = "button6";
            button6.Size = new Size(257, 115);
            button6.TabIndex = 6;
            button6.Text = "Thoát";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // frmQLKB
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(787, 565);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "frmQLKB";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Menu Quản Lý Khám Bệnh";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
    }
}
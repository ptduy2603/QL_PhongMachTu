﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_PhongMachTu
{
    public partial class frmMenuLapBaoCao : Form
    {
        public frmMenuLapBaoCao()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            frmMain fMain = new frmMain();
            fMain.Show();
            this.Close();
        }

        private void btnBC_SuDungThuoc_Click(object sender, EventArgs e)
        {
            frmBaoCaoSuDungThuoc fBaoCaoSuDungThuoc = new frmBaoCaoSuDungThuoc();
            fBaoCaoSuDungThuoc.Show();
            this.Close();
        }

        private void btnBC_DoanhThuThang_Click(object sender, EventArgs e)
        {
            frmBaoCaoDoanhThuThang fBaoCaoDoanhThuThang = new frmBaoCaoDoanhThuThang();
            fBaoCaoDoanhThuThang.Show();
            this.Close();
        }
    }
}

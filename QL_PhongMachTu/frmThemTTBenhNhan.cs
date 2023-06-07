using System;
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
    public partial class frmThemTTBenhNhan : Form
    {
        public frmThemTTBenhNhan()
        {
            InitializeComponent();
        }

        private void frmThemTTBenhNhan_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            frmQLKB QLKB = new frmQLKB();
            QLKB.Show();
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void chkNam_CheckedChanged(object sender, EventArgs e)
        {
            if (chkNam.Checked)
            {
                chkNu.Checked = false;
            }
            else
            {
                chkNu.Checked = true;
            }
        }

        private void chkNu_CheckedChanged_1(object sender, EventArgs e)
        {
            if (chkNu.Checked)
            {
                chkNam.Checked = false;
            }
            else
            {
                chkNam.Checked = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

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
    public partial class frmLapPhieuKham : Form
    {
        public frmLapPhieuKham()
        {
            InitializeComponent();
            this.ControlBox = false;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void frmLapPhieuKham_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmMain main = new frmMain();
            main.Show();
            this.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TodoApp
{
    public partial class BaoCaoThuChi : Form
    {
        public BaoCaoThuChi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            var f = new QuanLyChiTieu();
            f.ShowDialog();
        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            var f = new QuanLyThu();
            f.ShowDialog();
        }

        private void BaoCaoThuChi_Load(object sender, EventArgs e)
        {
            foreach (DataGridViewColumn column in dgvBaoCaoThuChi.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            // Đặt FillMode của Control đang chứa DataGridView thành DataGridViewAutoSizeColumnsMode.Fill
            dgvBaoCaoThuChi.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}

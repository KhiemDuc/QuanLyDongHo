using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace TodoApp
{
    public partial class QuanLySuKien : Form
    {
        ChiDAL chi = new ChiDAL();
        DataTable dt = new DataTable();
        private string _role;
        public QuanLySuKien()
        {
            InitializeComponent();
        }
        public QuanLySuKien(string role):this()
        {
            _role = role;
        }

        private void btnThietLapChi_Click(object sender, EventArgs e)
        {
            var f = new ThemSuaSuKien();
            f.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = ShowYesNoDialog("Bạn có muốn xóa sự kiện này không?");

            if (result == DialogResult.Yes)
            {
                Console.WriteLine("Bạn đã chọn 'Có'");
            }
            else if (result == DialogResult.No)
            {
                Console.WriteLine("Bạn đã chọn 'Không'");
            }
        }
        static DialogResult ShowYesNoDialog(string message)
        {
            return MessageBox.Show(message, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void dgvDanhSachThu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string MaSuKien = dgvDanhSachThu.Rows[e.RowIndex].Cells["MaSuKien"].Value.ToString();

            if (e.ColumnIndex == dgvDanhSachThu.Columns["Sua"].Index && e.RowIndex >= 0)
            {
                var sua = new ThemSuaSuKien("update", MaSuKien);
                sua.ShowDialog();
            }
        }

        private async void QuanLySuKien_Load(object sender, EventArgs e)
        {
            if(_role == "User")
            {
                dgvDanhSachThu.Columns["Sua"].Visible = false;
                dgvDanhSachThu.Columns["Xoa"].Visible = false;
                btnThietLapChi.Visible = false;
            }
            dt = await chi.DanhSachSuKien();
            Showdata(dt);
            foreach (DataGridViewColumn column in dgvDanhSachThu.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            // Đặt FillMode của Control đang chứa DataGridView thành DataGridViewAutoSizeColumnsMode.Fill
            dgvDanhSachThu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        void Showdata(DataTable dt)
        {
            dgvDanhSachThu.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                int rowIndex = dgvDanhSachThu.Rows.Add();
                dgvDanhSachThu.Rows[rowIndex].Cells["MaSuKien"].Value = row["MaGiaoDich"];
                dgvDanhSachThu.Rows[rowIndex].Cells["TenSuKien"].Value = row["TenChiTieu"];
                dgvDanhSachThu.Rows[rowIndex].Cells["NgayToChuc"].Value = ((DateTime)row["NgayChi"]).ToString("dd-MM-yyyy");
                dgvDanhSachThu.Rows[rowIndex].Cells["SoTien"].Value = row["SoTien"];
                dgvDanhSachThu.Rows[rowIndex].Cells["MoTa"].Value = row["MoTa"];
                dgvDanhSachThu.Rows[rowIndex].Cells["NguoiToChuc"].Value = row["Ten"];



            }
            dgvDanhSachThu.Columns["MaSuKien"].Visible = false;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

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
        SuKienDAL chi = new SuKienDAL();
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
            if(e.RowIndex >= 0)
            {
                string MaSuKien = dgvDanhSachSuKien.Rows[e.RowIndex].Cells["MaSuKien"].Value.ToString();
                if (e.ColumnIndex == dgvDanhSachSuKien.Columns["Sua"].Index)
                {
                    var sua = new ThemSuaSuKien("update", MaSuKien);
                    sua.ShowDialog();
                }
            }
        }

        private async void QuanLySuKien_Load(object sender, EventArgs e)
        {
            if(_role == "User")
            {
                dgvDanhSachSuKien.Columns["Sua"].Visible = false;
                dgvDanhSachSuKien.Columns["Xoa"].Visible = false;
                btnThietLapChi.Visible = false;
            }
            dt = await chi.DanhSachSuKien();
            Showdata(dt);
        }
        void Showdata(DataTable dt)
        {
            dgvDanhSachSuKien.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                int Sotien = 100000;
                int rowIndex = dgvDanhSachSuKien.Rows.Add();
                dgvDanhSachSuKien.Rows[rowIndex].Cells["MaSuKien"].Value = row["MaSuKien"];
                dgvDanhSachSuKien.Rows[rowIndex].Cells["TenSuKien"].Value = row["TenSuKien"];
                dgvDanhSachSuKien.Rows[rowIndex].Cells["NgayToChuc"].Value = ((DateTime)row["NgayToChuc"]).ToString("dd-MM-yyyy");
                dgvDanhSachSuKien.Rows[rowIndex].Cells["SoTien"].Value = Sotien.ToString("NO");
            }
            dgvDanhSachSuKien.Columns["MaSuKien"].Visible = false;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

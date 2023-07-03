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
    public partial class ChiTietKhoanThu : Form
    {
        private string _idThu;
        ThanhVien_ThuDAL thanhvienthu = new ThanhVien_ThuDAL();
        DataTable dt = new DataTable();
        public ChiTietKhoanThu()
        {
            InitializeComponent();
        }
        public ChiTietKhoanThu(string idThu):this()
        {
            _idThu = idThu;
        }

        private void dgvDanhSachThu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        void ShowDataThu(DataTable dt)
        {
            dgvDanhSachThu.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                int rowIndex = dgvDanhSachThu.Rows.Add();
                dgvDanhSachThu.Rows[rowIndex].Cells["MaThanhVien"].Value = row["MaThanhVien"];
                dgvDanhSachThu.Rows[rowIndex].Cells["TenKhoanThu"].Value = row["Ten"];
                dgvDanhSachThu.Rows[rowIndex].Cells["DanhMuc"].Value = (bool)row["TrangThai"] ? "Đã nộp" : "Chưa nộp";
                dgvDanhSachThu.Rows[rowIndex].Cells["DinhMuc"].Value = row["SoTien"];
                dgvDanhSachThu.Rows[rowIndex].Cells["MoTa"].Value = row["TenThu"];
                dgvDanhSachThu.Rows[rowIndex].Cells["NgayBatDauThu"].Value = (row["NgayThu"] != DBNull.Value) ? ((DateTime)row["NgayThu"]).ToString("dd-MM-yyyy") : "N/A";
            }
            dgvDanhSachThu.Columns["MaThanhVien"].Visible = false;
            dgvDanhSachThu.Columns["TenKhoanThu"].HeaderText = "Tên thành viên";
            dgvDanhSachThu.Columns["DanhMuc"].Visible = true;
            dgvDanhSachThu.Columns["DinhMuc"].HeaderText = "Số tiền";
            dgvDanhSachThu.Columns["MoTa"].HeaderText = "Tên loại thu";
            dgvDanhSachThu.Columns["NgayBatDauThu"].HeaderText = "Ngày thu tiền";
        }

        private void ChiTietKhoanThu_Load(object sender, EventArgs e)
        {
            Task<DataTable> danhsachnoptien = thanhvienthu.DanhSachThanhVienThu(_idThu);
            danhsachnoptien.ContinueWith(t =>
            {
                dt = t.Result;
                if (InvokeRequired)
                    Invoke(new Action(() =>
                    {
                        ShowDataThu(t.Result);
                    }));
            });
        }
    }
}

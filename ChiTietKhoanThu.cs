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
        private string _role;

        ThanhVien_ThuDAL thanhvienthu = new ThanhVien_ThuDAL();
        DataTable dt = new DataTable();
        public ChiTietKhoanThu()
        {
            InitializeComponent();
        }
        public ChiTietKhoanThu(string idThu, string role = "User"):this()
        {
            _idThu = idThu;
            _role = role;
        }

        private void dgvDanhSachThu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string MaGiaoDich = dgvDanhSachThuChiTiet.Rows[e.RowIndex].Cells["MaGiaoDich"].Value.ToString();
                if (e.ColumnIndex == dgvDanhSachThuChiTiet.Columns["Sua"].Index)
                {
                    var sua = new ThemSuaKhoanThuChiTiet(_role, MaGiaoDich,"update");
                    sua.ShowDialog();
                }
            }
        }
        void ShowDataThu(DataTable dt)
        {
            dgvDanhSachThuChiTiet.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                int rowIndex = dgvDanhSachThuChiTiet.Rows.Add();
                dgvDanhSachThuChiTiet.Rows[rowIndex].Cells["MaGiaoDichThu"].Value = row["MaGiaoDichThu"];
                dgvDanhSachThuChiTiet.Rows[rowIndex].Cells["TenThanhVien"].Value = row["Ten"];
                dgvDanhSachThuChiTiet.Rows[rowIndex].Cells["TrangThai"].Value = (bool)row["TrangThai"] ? "Đã nộp" : "Chưa nộp";
                dgvDanhSachThuChiTiet.Rows[rowIndex].Cells["SoTien"].Value = row["SoTien"];
                dgvDanhSachThuChiTiet.Rows[rowIndex].Cells["TenThu"].Value = row["TenThu"];
                dgvDanhSachThuChiTiet.Rows[rowIndex].Cells["NgayThu"].Value = (row["NgayThu"] != DBNull.Value) ? ((DateTime)row["NgayThu"]).ToString("dd-MM-yyyy") : "N/A";
            }
            dgvDanhSachThuChiTiet.Columns["MaGiaoDichThu"].Visible = false;
        }

        private void ChiTietKhoanThu_Load(object sender, EventArgs e)
        {
            Task<DataTable> danhsachnoptien = thanhvienthu.DanhSachChiTietKhoanThu(_idThu);
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

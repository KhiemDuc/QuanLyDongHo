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
    public partial class QuanLyChiTieu : Form
    {
        ChiDAL chi = new ChiDAL();
        DataTable dt = new DataTable();
        private string _role;
        public QuanLyChiTieu()
        {
            InitializeComponent();
        }
        public QuanLyChiTieu(string role):this()
        {
            _role = role;
        }

        private void btnThietLapChi_Click(object sender, EventArgs e)
        {
            var f = new ThemKhoaChiTongQuat("add",_role);
            f.ShowDialog();
        }

        private void dgvDanhSachThu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                string MaChi = dgvDanhSachChiTieu.Rows[e.RowIndex].Cells["MaChi"].Value.ToString();
                if (e.ColumnIndex == dgvDanhSachChiTieu.Columns["Sua"].Index)
                {
                    var sua = new ThemKhoaChiTongQuat("update", _role, MaChi);
                    sua.ShowDialog();
                }
                if (e.ColumnIndex == dgvDanhSachChiTieu.Columns["Xoa"].Index)
                {

                }
                if (e.ColumnIndex == dgvDanhSachChiTieu.Columns["ChiTiet"].Index)
                {
                    var chitiet = new ChiTietKhoanChi(MaChi);
                    chitiet.ShowDialog();
                }
            }    
        }

        private void QuanLyChiTieu_Load(object sender, EventArgs e)
        {
            if(_role == "User")
            {
                btnThietLapChi.Visible = false;
                dgvDanhSachChiTieu.Columns["Sua"].Visible = false;
                dgvDanhSachChiTieu.Columns["Xoa"].Visible = false;

            }
            LoadDanhSachChi();

        }
        void LoadDanhSachChi()
        {
            Task<DataTable> danhsachchi = chi.DanhSachKhoanChi();
            danhsachchi.ContinueWith(t =>
            {
                dt = t.Result;
                if (InvokeRequired)
                    Invoke(new Action(() =>
                    {
                        Showdata(t.Result);
                    }));
            });
        }
        void Showdata(DataTable dt)
        {
            dgvDanhSachChiTieu.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                int rowIndex = dgvDanhSachChiTieu.Rows.Add();
                dgvDanhSachChiTieu.Rows[rowIndex].Cells["MaChi"].Value = row["MaChiTieu"];
                dgvDanhSachChiTieu.Rows[rowIndex].Cells["TenKhoanChi"].Value = row["TenKhoanChi"];

                object ngayBatDauValue = row["NgayBatDau"];
                string ngayBatDauString = (ngayBatDauValue != DBNull.Value) ? ((DateTime)ngayBatDauValue).ToString("dd-MM-yyyy") : string.Empty;
                dgvDanhSachChiTieu.Rows[rowIndex].Cells["NgayBatDau"].Value = ngayBatDauString;

                object ngayKetThucValue = row["NgayKetThuc"];
                string ngayKetThucString = (ngayKetThucValue != DBNull.Value) ? ((DateTime)ngayKetThucValue).ToString("dd-MM-yyyy") : "";
                dgvDanhSachChiTieu.Rows[rowIndex].Cells["NgayKetThuc"].Value = ngayKetThucString;

                object tongSoTienValue = row["TongSoTien"];
                string tongSoTienString = (tongSoTienValue != DBNull.Value) ? Convert.ToString(tongSoTienValue) : "";
                dgvDanhSachChiTieu.Rows[rowIndex].Cells["SoTien"].Value = tongSoTienString;

            }
            dgvDanhSachChiTieu.Columns["MaChi"].Visible = false;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}

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
            var f = new ThemSuaKhoanChiTongQuat("add",_role);
            f._eLoadData += eLoadDanhSachChi;
            f.ShowDialog();
        }

        private void eLoadDanhSachChi(object sender, EventArgs e)
        {
            LoadDanhSachChi();
        }

        private void dgvDanhSachThu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                string MaChi = dgvDanhSachChiTieu.Rows[e.RowIndex].Cells["MaChi"].Value.ToString();
                if (e.ColumnIndex == dgvDanhSachChiTieu.Columns["Sua"].Index)
                {
                    var sua = new ThemSuaKhoanChiTongQuat("update", _role, MaChi);
                    sua._eLoadData += eLoadDanhSachChi;
                    sua.ShowDialog();
                }
                if (e.ColumnIndex == dgvDanhSachChiTieu.Columns["Xoa"].Index)
                {
                    DialogResult result = ShowYesNoDialog("Bạn có muốn xóa khoản chi này không?");

                    if (result == DialogResult.Yes)
                    {
                        Task<bool> xoaThu = chi.XoaKhoanChi(MaChi);
                        xoaThu.ContinueWith(x =>
                        {
                            if (x.IsFaulted)
                                MessageBox.Show("Có Lỗi");
                            if (x.Result)
                            {
                                MessageBox.Show("Xóa Khoản Chi Thành Công");
                                LoadDanhSachChi();
                            }    
                            else
                                MessageBox.Show("Xóa Khoản Chi Không Thành Công");
                        });
                    }
                    
                }
                if (e.ColumnIndex == dgvDanhSachChiTieu.Columns["ChiTiet"].Index)
                {
                    var chitiet = new ChiTietKhoanChi(MaChi,_role);
                    chitiet.LoadDataCallback += eLoadData;
                    chitiet.ShowDialog();
                }
            }    
        }

        private void eLoadData()
        {
            LoadDanhSachChi();
        }

        static DialogResult ShowYesNoDialog(string message)
        {
            return MessageBox.Show(message, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
            Task<float> tienChi = chi.TongDaChi(dtpNgayBatDau.Value, dtpNgayKetThuc.Value);

            Task<DataTable> danhsachchi = chi.DanhSachKhoanChi();

            Task.WhenAll(tienChi, danhsachchi).ContinueWith(t =>
            {
                dt = danhsachchi.Result;
                if (InvokeRequired)
                    Invoke(new Action(() =>
                    {
                        Showdata(danhsachchi.Result);
                        lblTongChiTieu.Text = "Tổng Chi Tiêu Là: "+ tienChi.Result.ToString("N0") + " VND";
                        
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
                dgvDanhSachChiTieu.Rows[rowIndex].Cells["TenKhoanChi"].Value = row["TenChiTieu"];

                object ngayBatDauValue = row["NgayBatDau"];
                string ngayBatDauString = (ngayBatDauValue != DBNull.Value) ? ((DateTime)ngayBatDauValue).ToString("dd-MM-yyyy") : string.Empty;
                dgvDanhSachChiTieu.Rows[rowIndex].Cells["NgayBatDau"].Value = ngayBatDauString;

                object ngayKetThucValue = row["NgayKetThuc"];
                string ngayKetThucString = (ngayKetThucValue != DBNull.Value) ? ((DateTime)ngayKetThucValue).ToString("dd-MM-yyyy") : "";
                dgvDanhSachChiTieu.Rows[rowIndex].Cells["NgayKetThuc"].Value = ngayKetThucString;

                object tongSoTienValue = row["TongSoTien"];
               
                int tongTienInt = (tongSoTienValue != DBNull.Value) ? (int)tongSoTienValue : 0;
                dgvDanhSachChiTieu.Rows[rowIndex].Cells["SoTien"].Value = tongTienInt.ToString("N0");

                object mota = row["MoTa"];
                string motaString = (mota != DBNull.Value) ? Convert.ToString(mota) : "";
                dgvDanhSachChiTieu.Rows[rowIndex].Cells["MoTa"].Value = motaString;

            }
            dgvDanhSachChiTieu.Columns["MaChi"].Visible = false;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DateTime fromDate = dtpNgayBatDau.Value; // Lấy giá trị từ control NgayBatDau
            DateTime toDate = dtpNgayKetThuc.Value; // Lấy giá trị từ control NgayKetThuc

            var filteredData = dt.Clone(); // Tạo bản sao của DataTable dt

            // Kiểm tra nếu DataTable dt chứa dữ liệu
            if (dt.Rows.Count > 0)
            {
                var rows = dt.AsEnumerable().Where(row =>
                {
                    DateTime? ngayBatDau = row["NgayBatDau"] as DateTime?;
                    DateTime ngayChi;

                    if (ngayBatDau != null)
                    {
                        ngayChi = ngayBatDau.Value;
                        // Tiếp tục xử lý với ngayChi đã được gán giá trị
                        // ...
                        return ngayChi >= fromDate && ngayChi <= toDate;
                    }
                    return false;

                });

                // Kiểm tra nếu có bản ghi thỏa mãn điều kiện
                if (rows.Any())
                {
                    filteredData = rows.CopyToDataTable();
                }
            }

            Showdata(filteredData);
        }
    }
}

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
        private string _loaiThu;
        private string _props;
        private DateTime _dayEnd;
        private DateTime _dayStart;


        public EventHandler eLoadData;

        ThanhVien_ThuDAL thanhvienthu = new ThanhVien_ThuDAL();
        DataTable dt = new DataTable();
        public ChiTietKhoanThu()
        {
            InitializeComponent();
        }
        public ChiTietKhoanThu(string idThu = "", string role = "User",string loaiThu = "Thu Định Mức",
            string props = "", DateTime dayStart = new DateTime(), DateTime dayEnd = new DateTime()) :this()
        {
            _idThu = idThu;
            _role = role;
            _loaiThu = loaiThu;
            _props = props;
            _dayStart = dayStart;
            _dayEnd = dayEnd;
        }

        private void eLoadThuChiTiet(object sender, EventArgs e)
        {
            LoadData();
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
                long SoTien = (long)row["SoTien"];
                dgvDanhSachThuChiTiet.Rows[rowIndex].Cells["SoTien"].Value = SoTien.ToString("N0");
                dgvDanhSachThuChiTiet.Rows[rowIndex].Cells["TenThu"].Value = row["TenThu"];
                dgvDanhSachThuChiTiet.Rows[rowIndex].Cells["NgayThu"].Value = (row["NgayThu"] != DBNull.Value) ? ((DateTime)row["NgayThu"]).ToString("dd-MM-yyyy") : "N/A";
            }
            dgvDanhSachThuChiTiet.Columns["MaGiaoDichThu"].Visible = false;
            if(_props == "BaoCao")
            {
                dgvDanhSachThuChiTiet.Columns["TrangThai"].Visible = false;
            }
        }

        private void ChiTietKhoanThu_Load(object sender, EventArgs e)
        {
            if(_role == "User")
            {
                dgvDanhSachThuChiTiet.Columns["Sua"].Visible = false;
            }
            LoadData();
        }
        void LoadData()
        {
            if(_props == "" )
            {
                Task<DataTable> danhsachnoptien = thanhvienthu.DanhSachChiTietKhoanThu(_idThu);
                danhsachnoptien.ContinueWith(t =>
                {
                    dt = t.Result;
                    long tongTien = dt.AsEnumerable().Sum(row => row.Field<long>("SoTien"));

                    if (InvokeRequired)
                        Invoke(new Action(() =>
                        {
                            ShowDataThu(t.Result);

                            lblTongThu.Text = "Tổng Số Tiền : " + tongTien.ToString("N0");
                        }));
                });
            }    
            if(_props == "BaoCao")
            {
                Task<DataTable> ds = thanhvienthu.DanhSachChiTietKhoanDaThu(_loaiThu,_dayStart,_dayEnd);
                ds.ContinueWith(t =>
                {
                    dt = t.Result;
                    long tongTien = dt.AsEnumerable().Sum(row => row.Field<long>("SoTien"));

                    if (InvokeRequired)
                        Invoke(new Action(() =>
                        {
                            ShowDataThu(t.Result);

                            lblTongThu.Text = "Tổng Số Tiền : " + tongTien.ToString("N0");
                        }));
                });
            }
        }

        private void ChiTietKhoanThu_FormClosed(object sender, FormClosedEventArgs e)
        {
            eLoadData?.Invoke(this, e);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvDanhSachThuChiTiet_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string MaGiaoDichThu = dgvDanhSachThuChiTiet.Rows[e.RowIndex].Cells["MaGiaoDichThu"].Value.ToString();

                if (e.ColumnIndex == dgvDanhSachThuChiTiet.Columns["Sua"].Index)
                {
                    var sua = new SuaKhoanThuChiTiet(_role, MaGiaoDichThu, _loaiThu);
                    sua.eLoadData += eLoadThuChiTiet;
                    sua.ShowDialog();
                }
            }
        }
    }
}

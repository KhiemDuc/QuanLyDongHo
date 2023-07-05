﻿using System;
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
    public partial class QuanLyThu : Form
    {
        ThuDAL thu = new ThuDAL();
        DataTable dt = new DataTable(); 
        ThanhVien_ThuDAL thanhvienthu = new ThanhVien_ThuDAL();
        private string _role;
        public QuanLyThu()
        {
            InitializeComponent();
        }
        public QuanLyThu(string role):this()
        {
            _role = role;
        }

        private void btnThietLapThu_Click(object sender, EventArgs e)
        {
            var thieplapthu = new ThemSuaKhoanThu("add");
            thieplapthu.ShowDialog();
        }

        private void QuanLyThu_Load(object sender, EventArgs e)
        {
            Task<float> tongThuDm = thu.TongDaThu(dtpNgayBatDau.Value, dtpNgayKetThuc.Value, 1);
            tongThuDm.ContinueWith(t =>
            {
                Invoke(new Action(() =>
                {
                    lblThuDinhMuc.Text += t.Result.ToString() + " VND";
                }));
            });
            if (_role == "User")
            {
                btnThietLapThu.Visible = false;
                btnQuyenGop.Visible = false;
                dgvDanhSachThu.Columns["Sua"].Visible = false;
                dgvDanhSachThu.Columns["Xoa"].Visible = false;
            }
            LoadDanhSachThu();
        }
        void LoadDanhSachThu()
        {
            Task<DataTable> danhsachthu = thu.DanhSachKhoanThu();
            danhsachthu.ContinueWith(t =>
            {
                dt = t.Result;
                if(InvokeRequired)
                Invoke(new Action(() =>
                {
                    Showdata(t.Result);
                }));
            });
        }
        void Showdata(DataTable dt)
        {
            dgvDanhSachThu.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                int rowIndex = dgvDanhSachThu.Rows.Add();
                dgvDanhSachThu.Rows[rowIndex].Cells["MaThu"].Value = row["MaThu"];
                dgvDanhSachThu.Rows[rowIndex].Cells["TenKhoanThu"].Value = row["TenThu"];
                dgvDanhSachThu.Rows[rowIndex].Cells["NgayBatDauThu"].Value = ((DateTime)row["NgayBatDauThu"]).ToString("dd-MM-yyyy");
                dgvDanhSachThu.Rows[rowIndex].Cells["DanhMuc"].Value = (bool)row["LoaiThu"] ? "Thu Định Mức" : "Quyên Góp";
                dgvDanhSachThu.Rows[rowIndex].Cells["DinhMuc"].Value = row["DinhMuc"];
                dgvDanhSachThu.Rows[rowIndex].Cells["MoTa"].Value = row["MoTa"];


            }
            dgvDanhSachThu.Columns["MaThu"].Visible = false;
        }

        private void dgvDanhSachThu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.ColumnIndex == dgvDanhSachThu.Columns["Sua"].Index && e.RowIndex >= 0)
            {
                string MaThu = dgvDanhSachThu.Rows[e.RowIndex].Cells["MaThu"].Value.ToString();
                var sua = new ThemSuaKhoanThu("update", MaThu);
                sua.ShowDialog();
            }
            if (e.ColumnIndex == dgvDanhSachThu.Columns["DongTien"].Index && e.RowIndex >= 0)
            {
                string MaThu = dgvDanhSachThu.Rows[e.RowIndex].Cells["MaThu"].Value.ToString();
                var f = new ChiTietKhoanThu(MaThu,_role);
                f.ShowDialog();
            }
            if (e.ColumnIndex == dgvDanhSachThu.Columns["Xoa"].Index && e.RowIndex >= 0)
            {
                string MaThu = dgvDanhSachThu.Rows[e.RowIndex].Cells["MaThu"].Value.ToString();
                DialogResult result = ShowYesNoDialog("Bạn có muốn xóa khoản thu này không?");

                if (result == DialogResult.Yes)
                {
                    Task<bool> xoaThu = thu.XoaKhoanThu(MaThu);
                    xoaThu.ContinueWith(x =>
                    {
                        if (x.IsFaulted)
                            MessageBox.Show("Có Lỗi");
                        if(x.Result)
                            MessageBox.Show("Xóa Thành Công");
                    });
                }
                else if (result == DialogResult.No)
                {
                    Console.WriteLine("Bạn đã chọn 'Không'");
                }
            }
        }
        static DialogResult ShowYesNoDialog(string message)
        {
            return MessageBox.Show(message, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void btnQuyenGop_Click(object sender, EventArgs e)
        {
            var quyenGop = new DongQuyenGop("add",_role);
            quyenGop.ShowDialog();
        }

        private void cmbDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = cmbDanhMuc.SelectedItem.ToString();
            if (selectedValue == "Tất Cả")
            {
                Showdata(dt);
            }
            else
            {
                var filteredData = dt.Clone();
                foreach (DataRow row in dt.Rows)
                {
                    var value = (bool)row["LoaiThu"] ? "Thu Định Mức" : "Quyên Góp";
                    if (value == selectedValue)
                    {
                        filteredData.Rows.Add(row.ItemArray);
                    }
                }
                Showdata(filteredData);

            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            DateTime fromDate = dtpNgayBatDau.Value; // Lấy giá trị từ control NgayBatDau
            DateTime toDate = dtpNgayKetThuc.Value; // Lấy giá trị từ control NgayKetThuc

            var filteredData = dt.Clone(); // Tạo bản sao của DataTable dt

            // Kiểm tra nếu DataTable dt chứa dữ liệu
            if (dt.Rows.Count > 0)
            {
                var rows = dt.AsEnumerable().Where(row =>
                {
                    DateTime ngayThu = Convert.ToDateTime(row["NgayBatDauThu"]);
                    return ngayThu >= fromDate && ngayThu <= toDate;
                });

                // Kiểm tra nếu có bản ghi thỏa mãn điều kiện
                if (rows.Any())
                {
                    filteredData = rows.CopyToDataTable();
                }
            }

            Showdata(filteredData);
        }

        private void dtpNgayBatDau_ValueChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

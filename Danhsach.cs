using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TodoApp
{
    public partial class Danhsach : Form
    {
        private string _role;
        ThanhVienDAL thanhvien = new ThanhVienDAL();
        DataTable dt = new DataTable();
        public Danhsach()
        {
            InitializeComponent();
        }
        public Danhsach(string role) : this()
        {
            _role = role;
        }
        private void Danhsach_Load(object sender, EventArgs e)
        {
            LoadData();
        }
        void LoadData()
        {
            Task<DataTable> data = thanhvien.GetInfoThanhVien();
            data.ContinueWith(t =>
            {
                dt = t.Result;
                Invoke(new Action(() =>
                {
                    if (dt != null)
                        ShowData(dt);
                }));
            });
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string selectedValue = txtSearch.Text;
            var filteredData = dt.Clone();
            foreach (DataRow row in dt.Rows)
            {

                if (row["Ten"].ToString().Contains(selectedValue))
                {
                    filteredData.Rows.Add(row.ItemArray);
                }
            }
            ShowData(filteredData);
        }
        void ShowData(DataTable data)
        {
            DanhSachThanhVien.Rows.Clear();
            foreach (DataRow row in data.Rows)
            {
                int rowIndex = DanhSachThanhVien.Rows.Add();
                DanhSachThanhVien.Rows[rowIndex].Cells["ID"].Value = row["MaThanhVien"];
                DanhSachThanhVien.Rows[rowIndex].Cells["HoTen"].Value = row["Ten"];
                DanhSachThanhVien.Rows[rowIndex].Cells["NgaySinh"].Value = ((DateTime)row["NgaySinh"]).ToString("dd-MM-yyyy");
                DanhSachThanhVien.Rows[rowIndex].Cells["GioiTinh"].Value = (bool)row["GioiTinh"] ? "Nam" : "Nữ";
                DanhSachThanhVien.Rows[rowIndex].Cells["HoTenCha"].Value = row["TenCha"];
                DanhSachThanhVien.Rows[rowIndex].Cells["HoTenMe"].Value = row["HoTenMe"];
                DanhSachThanhVien.Rows[rowIndex].Cells["Doi"].Value = row["Doi"];
                DanhSachThanhVien.Rows[rowIndex].Cells["TinhTrang"].Value = (bool)row["TrangThai"] ? "Còn Sống" : "Đã Mất";

            }
            DanhSachThanhVien.Columns["ID"].Visible = false;
        }

        private void DanhSachThanhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == DanhSachThanhVien.Columns["Delete"].Index && e.RowIndex >= 0)
            {
                string MaThanhVien = DanhSachThanhVien.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                DialogResult result = ShowYesNoDialog("Bạn có muốn xóa thành viên này không?");

                if (result == DialogResult.Yes)
                {
                    Task<bool> xoaThu = thanhvien.XoaThanhVien(MaThanhVien);
                    xoaThu.ContinueWith(x =>
                    {
                        if (x.IsFaulted)
                            MessageBox.Show("Có Lỗi");
                        if (x.Result)
                            MessageBox.Show("Xóa Thành Viên Thành Công");
                    });
                }
                else if (result == DialogResult.No)
                {
                    Console.WriteLine("Bạn đã chọn 'Không'");
                }
        

            }
            if (e.ColumnIndex == DanhSachThanhVien.Columns["ChiTiet"].Index && e.RowIndex >= 0)
            {
                string MaThanhVien = DanhSachThanhVien.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                var sua = new ThemThanhVien("update", _role, MaThanhVien);
                sua.ShowDialog();
            }
        }
        static DialogResult ShowYesNoDialog(string message)
        {
            return MessageBox.Show(message, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = cmbFilter.SelectedItem.ToString();
            if (selectedValue == "Tất cả")
            {
                ShowData(dt);
            }
            else
            {
                var filteredData = dt.Clone();
                foreach (DataRow row in dt.Rows)
                {
                    var value = row["Doi"].ToString();
                    if (value == selectedValue)
                    {
                        filteredData.Rows.Add(row.ItemArray);
                    }
                }
                ShowData(filteredData);

            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

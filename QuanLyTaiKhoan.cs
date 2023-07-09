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
    public partial class QuanLyTaiKhoan : Form
    {
        TaiKhoanDAL tk = new TaiKhoanDAL();
        private string _role = "";
        DataTable dt = new DataTable();
        public QuanLyTaiKhoan()
        {
            InitializeComponent();
        }
        public QuanLyTaiKhoan(string role):this()
        {
            _role = role;
        }
        private void DanhSachThanhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.ColumnIndex == DanhSachTaiKhoan.Columns["PhanQuyen"].Index && e.RowIndex >= 0)
            {
                string ID = DanhSachTaiKhoan.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                string name = DanhSachTaiKhoan.Rows[e.RowIndex].Cells["HoTen"].Value.ToString();
                string ChucVu = DanhSachTaiKhoan.Rows[e.RowIndex].Cells["ChucVu"].Value.ToString();


                var pq = new PhanQuyen(ID,name,ChucVu);
                pq.ShowDialog();
            }
            if (e.ColumnIndex == DanhSachTaiKhoan.Columns["CapTK"].Index && e.RowIndex >= 0)
            {
                string ID = DanhSachTaiKhoan.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                string name = DanhSachTaiKhoan.Rows[e.RowIndex].Cells["HoTen"].Value.ToString();

                var tk = new ThemSuaTaiKhoan(ID, name);
                tk.ShowDialog();
            }
        }

        private async void QuanLyTaiKhoan_Load(object sender, EventArgs e)
        {
            if(_role == "Admin")
            {
                DanhSachTaiKhoan.Columns["PhanQuyen"].Visible = false;
                dt = await tk.getInfoUserAsync();
            }
            else
            {
                dt = await tk.getInfoAllUserAsync();
            }

            if(dt != null)
                Showdata(dt);
            foreach (DataGridViewColumn column in DanhSachTaiKhoan.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            // Đặt FillMode của Control đang chứa DataGridView thành DataGridViewAutoSizeColumnsMode.Fill
            DanhSachTaiKhoan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        void Showdata(DataTable dt)
        {
            DanhSachTaiKhoan.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                int rowIndex = DanhSachTaiKhoan.Rows.Add();
                DanhSachTaiKhoan.Rows[rowIndex].Cells["ID"].Value = row["MaThanhVien"];
                DanhSachTaiKhoan.Rows[rowIndex].Cells["HoTen"].Value = row["Ten"];
                DanhSachTaiKhoan.Rows[rowIndex].Cells["TaiKhoan"].Value = row["User_Name"];
                DanhSachTaiKhoan.Rows[rowIndex].Cells["MatKhau"].Value = row["Password"];
                DanhSachTaiKhoan.Rows[rowIndex].Cells["ChucVu"].Value = row["Ten_ChucVu"];
            }
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = cmbFilter.SelectedItem.ToString() ?? "";
            if (selectedValue == "Tất cả")
            {
                Showdata(dt);
            }
            else
            {
                var filteredData = dt.Clone();
                foreach (DataRow row in dt.Rows)
                {
                    var value = row["Ten_ChucVu"].ToString();
                    if (value == selectedValue)
                    {
                        filteredData.Rows.Add(row.ItemArray);
                    }
                }
                Showdata(filteredData);

            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}

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
            var f = new ThemSuaKhoanChi("add");
            f.ShowDialog();
        }

        private void dgvDanhSachThu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvDanhSachThu.Columns["Sua"].Index && e.RowIndex >= 0)
            {
                string MaThu = dgvDanhSachThu.Rows[e.RowIndex].Cells["MaChi"].Value.ToString();
                var sua = new ThemSuaKhoanChi("update", MaThu);
                sua.ShowDialog();
            }
            if (e.ColumnIndex == dgvDanhSachThu.Columns["Xoa"].Index && e.RowIndex >= 0)
            {
                string MaThu = dgvDanhSachThu.Rows[e.RowIndex].Cells["MaChi"].Value.ToString();
                var sua = new ThemSuaKhoanChi("update", MaThu);
                sua.ShowDialog();
            }
        }

        private void QuanLyChiTieu_Load(object sender, EventArgs e)
        {
            if(_role == "User")
            {
                btnThietLapChi.Visible = false;
                dgvDanhSachThu.Columns["Sua"].Visible = false;
                dgvDanhSachThu.Columns["Xoa"].Visible = false;

            }
            LoadDanhSachChi();
            foreach (DataGridViewColumn column in dgvDanhSachThu.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }

            // Đặt FillMode của Control đang chứa DataGridView thành DataGridViewAutoSizeColumnsMode.Fill
            dgvDanhSachThu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

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
            dgvDanhSachThu.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                int rowIndex = dgvDanhSachThu.Rows.Add();
                dgvDanhSachThu.Rows[rowIndex].Cells["MaChi"].Value = row["MaChi"];
                dgvDanhSachThu.Rows[rowIndex].Cells["TenKhoanChi"].Value = row["TenChiTieu"];
                dgvDanhSachThu.Rows[rowIndex].Cells["NgayChi"].Value = ((DateTime)row["NgayChi"]).ToString("dd-MM-yyyy");
                dgvDanhSachThu.Rows[rowIndex].Cells["SoTien"].Value = row["SoTien"];
                dgvDanhSachThu.Rows[rowIndex].Cells["MoTa"].Value = row["MoTa"];


            }
            dgvDanhSachThu.Columns["MaChi"].Visible = false;
        }

        /*private void btnSearch_Click(object sender, EventArgs e)
        {
            string selectedValue = txtSearch.Text;
            var filteredData = dt.Clone();
            foreach (DataRow row in dt.Rows)
            {

                if (row["TenKhoanChi"].ToString().Contains(selectedValue))
                {
                    filteredData.Rows.Add(row.ItemArray);
                }
            }
            Showdata(filteredData);
        }*/

        private void cmbDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}

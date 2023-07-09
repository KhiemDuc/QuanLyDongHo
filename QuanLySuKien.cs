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
        SuKienDAL sk = new SuKienDAL();
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
            var f = new ThemSuaSuKien("add","",_role);
            f.eLoadData += LoadDataSk;
            f.ShowDialog();
        }

        private void LoadDataSk(object sender, EventArgs e)
        {
            LoadData();
        }

        static DialogResult ShowYesNoDialog(string message)
        {
            return MessageBox.Show(message, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void QuanLySuKien_Load(object sender, EventArgs e)
        {
            LoadData();   
        }
        void LoadData()
        {
            Task<DataTable> data = sk.DanhSachSuKien();
            data.ContinueWith(t =>
            {
                dt = t.Result;
                Invoke(new Action(() =>
                {
                    Showdata(t.Result);
                }));
            });
        }
        void Showdata(DataTable dt)
        {
            dgvDanhSachSuKien.Rows.Clear();
            foreach (DataRow row in dt.Rows)
            {
                int rowIndex = dgvDanhSachSuKien.Rows.Add();
                dgvDanhSachSuKien.Rows[rowIndex].Cells["MaSuKien"].Value = row["MaSuKien"];
                dgvDanhSachSuKien.Rows[rowIndex].Cells["TenSuKien"].Value = row["TenSuKien"];
                dgvDanhSachSuKien.Rows[rowIndex].Cells["NgayToChuc"].Value = ((DateTime)row["NgayToChuc"]).ToString("dd-MM-yyyy");
                dgvDanhSachSuKien.Rows[rowIndex].Cells["DiaDiem"].Value = row["DiaDiem"];
                dgvDanhSachSuKien.Rows[rowIndex].Cells["TenChiTieu"].Value = row["TenChiTieu"] ?? "Không Có";



                string MaChi = row["MaChiTieu"].ToString() ?? "";
                if(MaChi != String.Empty)
                    dgvDanhSachSuKien.Rows[rowIndex].Cells["MaChi"].Value = MaChi;
                else
                    dgvDanhSachSuKien.Rows[rowIndex].Cells["ChiTietChiTieu"].ReadOnly = true;
            }
            dgvDanhSachSuKien.Columns["MaSuKien"].Visible = false;
        }

        private void dgvDanhSachSuKien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 )
            {
                string MaSuKien = dgvDanhSachSuKien.Rows[e.RowIndex].Cells["MaSuKien"].Value.ToString();
                if(!dgvDanhSachSuKien.Rows[e.RowIndex].Cells["ChiTietChiTieu"].ReadOnly)
                {
                    string MaChi = dgvDanhSachSuKien.Rows[e.RowIndex].Cells["MaChi"].Value.ToString();
                    if (e.ColumnIndex == dgvDanhSachSuKien.Columns["ChiTietChiTieu"].Index)
                    {
                        var sua = new ChiTietKhoanChi(MaChi,"User");
                        sua.ShowDialog();
                    }
                }    

                if (e.ColumnIndex == dgvDanhSachSuKien.Columns["Sua"].Index)
                {
                    var sua = new ThemSuaSuKien("update", MaSuKien, _role);
                    sua.eLoadData += LoadDataSk;
                    sua.ShowDialog();
                }
                if (e.ColumnIndex == dgvDanhSachSuKien.Columns["Xoa"].Index)
                {
                    DialogResult result = ShowYesNoDialog("Bạn có muốn xóa sự kiện này không?");

                    if (result == DialogResult.Yes)
                    {
                        Task<bool> xoaSK = sk.XoaSuKien(MaSuKien);
                        xoaSK.ContinueWith(x =>
                        {
                            if (x.IsFaulted)
                                MessageBox.Show("Có Lỗi");
                            if (x.Result)
                            {
                                MessageBox.Show("Xóa Sự Kiện Thành Công");
                                
                            }
                            else
                                MessageBox.Show("Xóa Sự Kiện Không Thành Công");
                        });
                        LoadData();
                        
                    }
                }

            }
        }

        private void dgvDanhSachSuKien_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (_role == "User")
            {
                dgvDanhSachSuKien.Columns["Xoa"].Visible = false;
                btnThietLapChi.Visible = false;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string selectedValue = txtSearch.Text;
            var filteredData = dt.Clone();
            foreach (DataRow row in dt.Rows)
            {

                if (row["TenSuKien"].ToString().Contains(selectedValue))
                {
                    filteredData.Rows.Add(row.ItemArray);
                }
            }
            Showdata(filteredData);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string selectedValue = txtSearch.Text;
            var filteredData = dt.Clone();
            foreach (DataRow row in dt.Rows)
            {

                if (row["TenSuKien"].ToString().Contains(selectedValue))
                {
                    filteredData.Rows.Add(row.ItemArray);
                }
            }
            Showdata(filteredData);
        }
    }
}

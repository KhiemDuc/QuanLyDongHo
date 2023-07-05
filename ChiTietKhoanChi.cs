using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using DAL;

namespace TodoApp
{
    public partial class ChiTietKhoanChi : Form
    {
        private string _maChi;
        ChiDAL chi = new ChiDAL();
        public ChiTietKhoanChi()
        {
            InitializeComponent();
        }
        public ChiTietKhoanChi(string maChi): this()
        {
            _maChi = maChi;
        }

        private void btnThietLapChi_Click(object sender, EventArgs e)
        {
            var f = new ThemSuaKhoanChiChiTiet();
            f.ShowDialog();
        }

        private void ChiTietKhoanChi_Load(object sender, EventArgs e)
        {
            Task<SqlDataReader> thongtin = chi.LayThongTinKhoanChi(_maChi);
            thongtin.ContinueWith(t =>
            {
                if (t.IsFaulted)
                {

                }
                else if (t.Result != null)
                {
                    SqlDataReader reader = t.Result;
                    if (reader != null && reader.HasRows)
                    {
                        Invoke(new Action(() =>
                        {
                            ShowData(reader);
                        }));
                    }
                }

            });
        }
        void ShowData(SqlDataReader reader)
        {
            dgvDanhSachChiChiTiet.Rows.Clear();
            while (reader.Read())
            {
                int rowIndex = dgvDanhSachChiChiTiet.Rows.Add();
                dgvDanhSachChiChiTiet.Rows[rowIndex].Cells["MaGiaoDich"].Value = reader["MaChiTieu"];
                dgvDanhSachChiChiTiet.Rows[rowIndex].Cells["TenKhoanChi"].Value = reader["TenKhoanChi"];
                dgvDanhSachChiChiTiet.Rows[rowIndex].Cells["NgayChi"].Value = ((DateTime)reader["NgayChi"]).ToString("dd-MM-yyyy");
                dgvDanhSachChiChiTiet.Rows[rowIndex].Cells["SoTien"].Value = reader["SoTien"];
                dgvDanhSachChiChiTiet.Rows[rowIndex].Cells["TenThanhVien"].Value = reader["MaThanhVien"];
            }
            dgvDanhSachChiChiTiet.Columns["MaGiaoDich"].Visible = false;
        }


        private void dgvDanhSachThu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

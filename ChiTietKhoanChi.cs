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
        private string _role;
        private string _props;
        DateTime _dateStart;
        DateTime _dateEnd;



        public delegate void eLoadData();
        public eLoadData LoadDataCallback;


        ChiDAL chi = new ChiDAL();
        public ChiTietKhoanChi()
        {
            InitializeComponent();
        }
        public ChiTietKhoanChi(string maChi,string role, string props = "",DateTime dayStart = new DateTime(),DateTime dayEnd = new DateTime()) : this()
        {
            _maChi = maChi;
            _role = role;
            _dateStart = dayStart;
            _dateEnd = dayEnd;
            _props = props;
        }

        private void btnThietLapChi_Click(object sender, EventArgs e)
        {
            var f = new ThemSuaKhoanChiChiTiet("add","",_maChi);
            f.eLoadData += F_eLoadData;
            f.ShowDialog();
        }

        private void F_eLoadData(object sender, EventArgs e)
        {
            LoadData();
        }

        private void ChiTietKhoanChi_Load(object sender, EventArgs e)
        {
            if(_role == "User")
            {
                btnThietLapChi.Visible = false;
                dgvDanhSachChiChiTiet.Columns["Sua"].Visible = false;
                dgvDanhSachChiChiTiet.Columns["Xoa"].Visible = false;

            }
            LoadData();
        }
        void LoadData()
        {
            if(_props == "")
            {
                Task<SqlDataReader> thongtin = chi.DanhSachKhoanChiChiTiet(_maChi);
                thongtin.ContinueWith(t =>
                {
                    if (t.IsFaulted)
                    {
                        return;
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
            if(_props == "BaoCao")
            {
                Task<SqlDataReader> thongtin = chi.DanhSachKhoanDaChi(_dateStart, _dateEnd);
                thongtin.ContinueWith(t =>
                {
                    if (t.IsFaulted)
                    {
                        return;

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
        }
        void ShowData(SqlDataReader reader)
        {
            dgvDanhSachChiChiTiet.Rows.Clear();
            while (reader.Read())
            {
                int rowIndex = dgvDanhSachChiChiTiet.Rows.Add();
                dgvDanhSachChiChiTiet.Rows[rowIndex].Cells["MaGiaoDich"].Value = reader["MaGiaoDich"];
                dgvDanhSachChiChiTiet.Rows[rowIndex].Cells["TenKhoanChi"].Value = reader["TenKhoanChi"];
                dgvDanhSachChiChiTiet.Rows[rowIndex].Cells["NgayChi"].Value = ((DateTime)reader["NgayChi"]).ToString("dd-MM-yyyy");
                int SoTien = (int)reader["SoTien"];
                dgvDanhSachChiChiTiet.Rows[rowIndex].Cells["SoTien"].Value = SoTien.ToString("N0");
                dgvDanhSachChiChiTiet.Rows[rowIndex].Cells["TenThanhVien"].Value = reader["Ten"];
                dgvDanhSachChiChiTiet.Rows[rowIndex].Cells["MaThanhVien"].Value = reader["MaThanhVien"];
            }
            dgvDanhSachChiChiTiet.Columns["MaGiaoDich"].Visible = false;
            dgvDanhSachChiChiTiet.Columns["MaThanhVien"].Visible = false;

        }


        private void dgvDanhSachThu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                string MaGiaoDich = dgvDanhSachChiChiTiet.Rows[e.RowIndex].Cells["MaGiaoDich"].Value.ToString();
                if (e.ColumnIndex == dgvDanhSachChiChiTiet.Columns["Sua"].Index)
                {
                    var sua = new ThemSuaKhoanChiChiTiet("update",MaGiaoDich,_maChi);
                    sua.eLoadData += Sua_eLoadData;
                    sua.ShowDialog();
                }
                if (e.ColumnIndex == dgvDanhSachChiChiTiet.Columns["Xoa"].Index)
                {
                    DialogResult result = ShowYesNoDialog("Bạn có muốn xóa khoản chi này không?");

                    if (result == DialogResult.Yes)
                    {
                        Task<bool> xoaKhoanChiChiTiet = chi.XoaKhoanChiChiTiet(MaGiaoDich);
                        xoaKhoanChiChiTiet.ContinueWith(x =>
                        {
                            if (x.IsFaulted)
                                MessageBox.Show("Có Lỗi");
                            if (x.Result)
                                MessageBox.Show("Xóa Khoản Chi Thành Công");
                            else
                                MessageBox.Show("Xóa Khoản Chi Không Thành Công");
                        });
                    }
                }
            }
        }

        private void Sua_eLoadData(object sender, EventArgs e)
        {
            LoadData();
        }

        static DialogResult ShowYesNoDialog(string message)
        {
            return MessageBox.Show(message, "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
        }

        private void ChiTietKhoanChi_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (LoadDataCallback != null)
            {
                LoadDataCallback();
            }
        }
    }
}

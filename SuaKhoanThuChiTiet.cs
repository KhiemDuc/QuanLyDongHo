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
    public partial class SuaKhoanThuChiTiet : Form
    {
        private string _role;
        private string _maGiaoDich;
        private string _loaiThu;
        public EventHandler eLoadData;
        ThanhVien_ThuDAL chiTietThu = new ThanhVien_ThuDAL();

        public SuaKhoanThuChiTiet()
        {
            InitializeComponent();
        }
        public SuaKhoanThuChiTiet(string role, string maGiaoDich,string LoaiThu):this()
        {
            _role = role;
            _maGiaoDich = maGiaoDich;
            _loaiThu = LoaiThu;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            string input = txtSoTien.Text;
            long soTien;
            

            if (long.TryParse(input, out soTien))
            {
                // Chuyển đổi thành công, tiếp tục xử lý với giá trị soTien kiểu long
                Task<bool> suaChiTietThu = chiTietThu.SuaKhoanThuChiTiet(_maGiaoDich, dtpNgayThu.Value,(byte)cmbTrangThai.SelectedIndex,soTien);
                suaChiTietThu.ContinueWith(t =>
                {
                    if (t.IsFaulted)
                    {
                        MessageBox.Show("Có lỗi gì đó");
                    }
                    if (t.Result)
                    {
                        MessageBox.Show("Cập nhật khoản thu chi tiết thành công");
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật khoản thu chi tiết không thành công");
                    }
                });
                eLoadData?.Invoke(this, e);
            }
            else
            {
                soTien = 0;
            }

        }

        private void SuaKhoanThuChiTiet_Load(object sender, EventArgs e)
        {
            if (_loaiThu == "Thu Định Mức")
            {
                lblSoTien.Visible = false;
                txtSoTien.Visible = false;
            }
            else
            {
                cmbTrangThai.SelectedIndex = 0;
                cmbTrangThai.Enabled = false;

                txtSoTien.Visible = true;
                txtSoTien.Enabled = true;
            }
            if (_role == "User")
            {
                MessageBox.Show("Bạn không có đủ thẩm quyền");
            }
            else
            {
                Task<SqlDataReader> data = chiTietThu.ThongTinChiTietKhoanThuChiTiet(_maGiaoDich);
                data.ContinueWith(t =>
                {
                    SqlDataReader reader = t.Result;
                    if (reader != null && reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Invoke(new Action(() =>
                            {
                                txtTenThanhVien.Text = reader.GetString(reader.GetOrdinal("Ten"));
                                txtTenKhoanThu.Text = reader.GetString(reader.GetOrdinal("TenThu"));
                                
                                txtSoTien.Text = reader.IsDBNull(reader.GetOrdinal("SoTien")) ? "" 
                                    : reader.GetInt64(reader.GetOrdinal("SoTien")).ToString();
                                cmbTrangThai.SelectedIndex = reader.GetBoolean(reader.GetOrdinal("TrangThai")) ? 0:1;

                                int ngaySinhOrdinal = reader.GetOrdinal("NgayThu");
                                if (!reader.IsDBNull(ngaySinhOrdinal))
                                {
                                    dtpNgayThu.Value = reader.GetDateTime(ngaySinhOrdinal);
                                }

                            }));
                        }
                    }
                });
                
            }
        }
    }
}

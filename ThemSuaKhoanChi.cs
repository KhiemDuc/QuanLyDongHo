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
    
    public partial class ThemSuaKhoanChi : Form
    {
        ChiDAL chi = new ChiDAL();
        ThanhVienDAL thanhvien = new ThanhVienDAL();
        private string _type;
        private string _maChi;
        public ThemSuaKhoanChi()
        {
            InitializeComponent();
        }
        public ThemSuaKhoanChi(string type = "add", string machi = ""):this()
        {
            _type = type; ;
            _maChi = machi;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (_type == "add")
            {
                Task<bool> thietLapThu = chi.ThietLapKhoanChi(cmbThanhVien.Text, dtpBatDau.Value, txtSoTien.Text,
                   txtMota.Text);
                thietLapThu.ContinueWith(t =>
                {
                    if (t.IsFaulted)
                    {
                        MessageBox.Show("Thêm không thành công");
                    }
                    if (t.Result)
                    {
                        MessageBox.Show("Thêm thành công");
                    }
                    else
                        MessageBox.Show("Thêm không thành công");

                });
            }
            else if (_type == "update")
            {
                Task<bool> suathietLapThu = chi.SuaThietLapKhoanChi(_maChi, cmbThanhVien.Text, dtpBatDau.Value, txtSoTien.Text,
                    txtMota.Text);
                suathietLapThu.ContinueWith(t =>
                {
                    if (t.IsFaulted)
                    {
                        MessageBox.Show("Sửa không thành công");
                    }
                    if (t.Result)
                    {
                        MessageBox.Show("Sửa thành công");
                    }
                    else
                        MessageBox.Show("Sửa không thành công");

                });
            }
        }

        private void ThemSuaKhoanChi_Load(object sender, EventArgs e)
        {
            Task<DataTable> tenTv = thanhvien.DanhSachTen();
            tenTv.ContinueWith(t =>
            {
                Invoke(new Action(() =>
                {
                    cmbThanhVien.ValueMember = "MaThanhVien";
                    cmbThanhVien.DisplayMember = "Ten";
                    cmbThanhVien.DataSource = t.Result;
                }));
            });
            Task<DataTable> tenLoaiChi = chi.DanhSachLoaiChi();
            tenLoaiChi.ContinueWith(g =>
            {
                Invoke(new Action(() =>
                {
                    cmbLoaiChi.ValueMember = "MaChi";
                    cmbLoaiChi.DisplayMember = "LoaiChi";
                    cmbLoaiChi.DataSource = g.Result;
                }));
            });

            Task<DataTable> tenChi = chi.DanhSachKhoanChi();
            if(_type== "update")
            {
                btnThem.Text = "Lưu";
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
                            while (reader.Read())
                            {
                                Invoke(new Action(() =>
                                {
                                    txtKhoanChi.Text = reader.GetString(reader.GetOrdinal("TenChiTieu"));
                                    txtSoTien.Text = reader.GetInt32(reader.GetOrdinal("SoTien")).ToString();
                                    txtMota.Text = reader.IsDBNull(reader.GetOrdinal("MoTa")) ? "" :
                                                                        reader.GetString(reader.GetOrdinal("MoTa")).ToString(); ;
                                    dtpBatDau.Value = reader.GetDateTime(reader.GetOrdinal("NgayChi"));
                                    cmbThanhVien.SelectedValue = reader.GetInt32(reader.GetOrdinal("MaThanhVien")).ToString();
                                    cmbLoaiChi.SelectedValue = reader.GetInt32(reader.GetOrdinal("MaChi")).ToString();
                                }));
                            }
                        }
                    }

                });
            }

        }

        private void cmbThanhVien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnThemLoai_Click(object sender, EventArgs e)
        {
            var f = new ThemLoaiChi();
            f.ShowDialog();
        }
    }
}

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
    
    public partial class ThemSuaKhoanChiChiTiet : Form
    {
        ChiDAL chi = new ChiDAL();
        ThanhVienDAL thanhvien = new ThanhVienDAL();
        public event EventHandler eLoadData;


        private string _type;
        private string _maGiaoDich;
        private string _maChi;


        public ThemSuaKhoanChiChiTiet()
        {
            InitializeComponent();
        }
        public ThemSuaKhoanChiChiTiet(string type = "add", string maGiaoDich = "",string maChi = ""):this()
        {
            _type = type; ;
            _maGiaoDich = maGiaoDich;
            _maChi = maChi;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string input = txtSoTien.Text;
            long soTien;


            if (long.TryParse(input, out soTien))
            {
                if (_type == "add")
                {
                    Task<bool> thietLapChiChiTiet = chi.ThietLapKhoanChiChiTiet(txtKhoanChi.Text,_maChi,
                        cmbThanhVien.SelectedValue.ToString(),dtpNgayChi.Value, soTien);
                    thietLapChiChiTiet.ContinueWith(t =>
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
                        eLoadData?.Invoke(this, e);

                    });
                }
                else if (_type == "update")
                {
                
                        Task<bool> suathietLapThu = chi.SuaThietLapKhoanChiChiTiet(txtKhoanChi.Text, cmbThanhVien.SelectedValue.ToString(),
                        _maChi,dtpNgayChi.Value, soTien, _maGiaoDich);
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

                        eLoadData?.Invoke(this, e);
                    });
                }
            }
            else
            {
                MessageBox.Show("Số Tiền Phải Là Số");

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
            if(_type== "update")
            {
                btnThem.Text = "Lưu";
                Task<SqlDataReader> thongtin = chi.XemThongTinKhoanChiChiTiet(_maGiaoDich);
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
                                    txtKhoanChi.Text = reader.GetString(reader.GetOrdinal("TenKhoanChi"));
                                    txtSoTien.Text = reader.GetInt32(reader.GetOrdinal("SoTien")).ToString();
                                    dtpNgayChi.Value = reader.GetDateTime(reader.GetOrdinal("NgayChi"));
                                    cmbThanhVien.SelectedValue = reader.GetInt32(reader.GetOrdinal("MaThanhVien")).ToString();
                                    
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
    }
}

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
    public partial class ThemSuaKhoanChiTongQuat : Form
    {
        ChiDAL chi = new ChiDAL();
        SuKienDAL sk = new SuKienDAL();

        public EventHandler _eLoadData;
        private string _type;
        private string _role;
        private string _maChi;
        public ThemSuaKhoanChiTongQuat()
        {
            InitializeComponent();
        }
        public ThemSuaKhoanChiTongQuat(string type,string role,string maChi = "") : this()
        {
            _type = type;
            _role = role;
            _maChi = maChi;
        }

        private void ThemLoaiChi_Load(object sender, EventArgs e)
        {
            LoadThemSuKien();

            if (_role == "User")
            {
                MessageBox.Show("Bạn Không Có Quyền");
            }
            if(_type == "update")
            {
                btnThem.Text = "Lưu";
                Task<SqlDataReader> chitiet = chi.XemThongTinKhoanChi(_maChi);

                chitiet.ContinueWith(t =>
                {
                    SqlDataReader reader = t.Result;
                    if (reader != null && reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            Invoke(new Action(() =>
                            {
                                txtTenKhoanChi.Text = reader.GetString(reader.GetOrdinal("TenChiTieu"));
                                cbCheckSK.Checked = reader.IsDBNull(reader.GetOrdinal("MaSuKien")) ? false: true;
                                if (cbCheckSK.Checked)
                                {
                                    LoadSuaSuKien(reader.GetInt32(reader.GetOrdinal("MaSuKien")).ToString());

                                }   
                                int mota = reader.GetOrdinal("MoTa");
                                if (!reader.IsDBNull(mota))
                                {
                                    txtMota.Text = reader.GetString(mota);
                                }

                            }));
                        }
                    }
                });
            }
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maSuKien = panelSuKien.Visible ? cmbSuKien.SelectedValue.ToString(): "";

            if (_type == "add")
            {
                Task<bool> chiSK = chi.ThietLapKhoanChi(txtTenKhoanChi.Text, maSuKien,txtMota.Text);
                chiSK.ContinueWith(t =>
                {
                    if (t.IsFaulted)
                    {
                        MessageBox.Show("Có lỗi gì đó");
                    }
                    if (t.Result)
                    {
                        MessageBox.Show("Thêm khoản chi thành công");
                    }
                    else
                    {
                        MessageBox.Show("Thêm khoản chi không thành công");
                    }
                });
            }
            if (_type == "update")
            {
                Task<bool> chiSK = chi.SuaThietLapKhoanChi(_maChi,maSuKien, txtTenKhoanChi.Text,txtMota.Text);
                chiSK.ContinueWith(t =>
                {
                    if (t.IsFaulted)
                    {
                        MessageBox.Show("Có lỗi gì đó");
                    }
                    if (t.Result)
                    {
                        MessageBox.Show("Sửa khoản chi thành công");
                    }
                    else
                    {
                        MessageBox.Show("Sửa khoản chi không thành công");
                    }
                });
            }
            _eLoadData?.Invoke(this, e);
        }

        private void cbCheckSK_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCheckSK.Checked)
            {
                panelSuKien.Visible = true;
                
            }
            else
                panelSuKien.Visible = false;

        }
        void LoadSuaSuKien(string maSuKien)
        {
            Task<DataTable> DsSk = sk.DanhSachSuKienChuaCoKhoanChi(maSuKien);
            DsSk.ContinueWith(t =>
            {
                Invoke(new Action(() => {
                    cmbSuKien.ValueMember = "MaSuKien";
                    cmbSuKien.DisplayMember = "TenSuKien";
                    cmbSuKien.DataSource = DsSk.Result;
                }));
            });
        }
        void LoadThemSuKien()
        {
            Task<DataTable> DsSk = sk.DanhSachSuKienChuaCoKhoanChi();
            DsSk.ContinueWith(t =>
            {
                Invoke(new Action(() => {
                    cmbSuKien.ValueMember = "MaSuKien";
                    cmbSuKien.DisplayMember = "TenSuKien";
                    cmbSuKien.DataSource = DsSk.Result;
                }));
            });
            cmbSuKien.SelectedIndex = -1;
        }
    }
}

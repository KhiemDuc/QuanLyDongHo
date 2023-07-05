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
    public partial class ThemKhoaChiTongQuat : Form
    {
        ChiDAL chi = new ChiDAL();
        SuKienDAL sk = new SuKienDAL();
        private string _type;
        private string _role;
        private string _maChi;
        public ThemKhoaChiTongQuat()
        {
            InitializeComponent();
        }
        public ThemKhoaChiTongQuat(string type,string role,string maChi = "") : this()
        {
            _type = type;
            _role = role;
            _maChi = maChi;
        }

        private void ThemLoaiChi_Load(object sender, EventArgs e)
        {
            
            
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maSuKien = panelSuKien.Visible ? cmbSuKien.SelectedValue.ToString(): "";

            if (_type == "add")
            {
                Task<bool> chiSK = chi.ThietLapKhoanChi(txtTenKhoanChi.Text, maSuKien);
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
                Task<bool> chiSK = chi.SuaThietLapKhoanChi(_maChi,maSuKien, txtTenKhoanChi.Text);
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
        }

        private void cbCheckSK_CheckedChanged(object sender, EventArgs e)
        {
            if (cbCheckSK.Checked)
            {
                panelSuKien.Visible = true;
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
            else
                panelSuKien.Visible = false;

        }
    }
}

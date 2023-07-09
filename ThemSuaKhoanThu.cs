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
    public partial class ThemSuaKhoanThu : Form
    {
        ThuDAL thu = new ThuDAL();
        private string _type;
        private string _maThu;
        public EventHandler eLoadData;
        public ThemSuaKhoanThu()
        {
            InitializeComponent();
        }
        public ThemSuaKhoanThu(string type = "add",string maThu = ""):this()
        {
            _type = type;
            _maThu = maThu;
        }
        private void ThuChi_Load(object sender, EventArgs e)
        {

            if (_type == "update")
            {
                btnThem.Text = "Lưu";
                Task<SqlDataReader> thongtin = thu.LayThongTinKhoanThu(_maThu);
                thongtin.ContinueWith(t =>
                {
                    if (t.IsFaulted)
                    {

                    }
                    else if(t.Result != null)
                    {
                        SqlDataReader reader = t.Result;
                        if (reader != null && reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                Invoke(new Action(() =>
                                {
                                    txtTenKhoanThu.Text = reader.GetString(reader.GetOrdinal("TenThu"));
                                    txtDinhMuc.Text = reader.GetInt32(reader.GetOrdinal("DinhMuc")).ToString();
                                        txtMota.Text = reader.IsDBNull(reader.GetOrdinal("MoTa")) ? "" :
                                                                            reader.GetString(reader.GetOrdinal("MoTa")).ToString(); ;
                                    dtpBatDau.Value = reader.GetDateTime(reader.GetOrdinal("NgayBatDauThu"));
                                    cmbLoaiThu.SelectedIndex = reader.GetBoolean(reader.GetOrdinal("LoaiThu"))? 0: 1;

                                }));
                            }
                        }
                    }

                });
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(_type == "add")
            {
                Task<bool> thietLapThu = thu.ThietLapKhoanThu(txtTenKhoanThu.Text, dtpBatDau.Value, txtDinhMuc.Text,
                    (byte)cmbLoaiThu.SelectedIndex, txtMota.Text);
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
            else if(_type == "update")
            {
                Task<bool> suathietLapThu = thu.SuaThietLapKhoanThu(_maThu,txtTenKhoanThu.Text, dtpBatDau.Value, txtDinhMuc.Text,
                    (byte)cmbLoaiThu.SelectedIndex, txtMota.Text);
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
            eLoadData?.Invoke(this,e);
        }

        private void cmbLoaiThu_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLoaiThu.SelectedIndex == 1)
            {
                lblDinhMuc.Visible = false;
                txtDinhMuc.Visible = false;
            }
        }
    }
}

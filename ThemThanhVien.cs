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
using TodoApp.MyClass;

namespace TodoApp
{
    public partial class ThemThanhVien : Form
    {
        private string _type;
        private string _role;
        private string _updateforID;


        private ThanhVienDAL thanhvien = new ThanhVienDAL();
        

        public ThemThanhVien()
        {
            InitializeComponent();
        }
        public ThemThanhVien(string type = "add", string role= "Admin", string updateforID = ""):this()
        {
            _type = type;
            _role = role;
            _updateforID = updateforID;
        }

        private void Them_Load(object sender, EventArgs e)
        {
            if(_role == "User")
            {
                btnThem1.Enabled = false;
            }

            if (_type == "add")
            {
                btnThem1.Text = "Thêm";
                panelUpdate.Visible = false;


            }
            else if (_type == "update")
            {
                btnThem1.Text = "Lưu";
                panelUpdate.Visible= true;
                lblSDT.Visible = true;
                txtSDT.Visible = true;
                if (_updateforID != "")
                {
                    Task<SqlDataReader> chitiet = thanhvien.HienThiThanhVien(_updateforID);
                    chitiet.ContinueWith(c =>
                    {
                        if (c.Status == TaskStatus.RanToCompletion)
                        {
                            SqlDataReader reader = c.Result;
                            if (reader != null && reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    Invoke(new Action(() =>
                                    {
                                        txtHoten.Text = reader.GetString(reader.GetOrdinal("Ten"));
                                        cmbGioiTinh.SelectedIndex = reader.GetBoolean(reader.GetOrdinal("GioiTinh")) ? 0: 1;
                                        dtpNgaySinh.Value = reader.GetDateTime(reader.GetOrdinal("NgaySinh"));
                                        txtDiaChi.Text = reader.IsDBNull(reader.GetOrdinal("DiaChi")) ? "" : 
                                                                                   reader.GetString(reader.GetOrdinal("DiaChi"));

                                        if (reader.GetInt32(reader.GetOrdinal("Doi")) != 1)
                                            cmbDoi.SelectedItem = reader.GetInt32(reader.GetOrdinal("Doi")).ToString();
                                        else
                                        {
                                            cmbDoi.Items.Add("1");
                                            cmbDoi.SelectedItem="1";
                                        }
                                        if(reader.GetString(reader.GetOrdinal("TenCha")) != "Không Rõ")    
                                            cmbHoTenBo.SelectedItem = reader.GetString(reader.GetOrdinal("TenCha"));
                                        else
                                        {
                                            cmbHoTenBo.Items.Add("Không Rõ");
                                            cmbHoTenBo.SelectedItem = "Không Rõ";
                                        }
                                        txtHoTenMe.Text = reader.GetString(reader.GetOrdinal("HoTenMe"));
                                        txtDiaChi.Text = reader.GetString(reader.GetOrdinal("DiaChi"));
                                        cmbTrangthai.SelectedIndex = reader.GetBoolean(reader.GetOrdinal("TrangThai")) ? 0 : 1;
                                        cmbHonNhan.SelectedIndex = reader.GetBoolean(reader.GetOrdinal("TinhTrang_HonNhan")) ? 1 : 0;
                                        txtVoChong.Text = reader.IsDBNull(reader.GetOrdinal("HoTenVo/Chong")) ? "" :
                                                                            reader.GetString(reader.GetOrdinal("HoTenVo/Chong")).ToString();
                                        txtNgheNghiep.Text = reader.IsDBNull(reader.GetOrdinal("NgheNghiep")) ? "" :
                                                                            reader.GetString(reader.GetOrdinal("NgheNghiep")).ToString();
                                        txtThanhTuu.Text = reader.IsDBNull(reader.GetOrdinal("ThanhTuu")) ? "" :
                                                                            reader.GetString(reader.GetOrdinal("ThanhTuu")).ToString();
                                        txtSDT.Text = reader.IsDBNull(reader.GetOrdinal("SDT")) ?"" :
                                                                            reader.GetInt32(reader.GetOrdinal("SDT")).ToString();
                                        txtHocvan.Text = reader.IsDBNull(reader.GetOrdinal("HocVan")) ? "" :
                                                                            reader.GetString(reader.GetOrdinal("HocVan")).ToString();
                                        txtNoiAnTang.Text = reader.IsDBNull(reader.GetOrdinal("NoiAnTang")) ? "" :
                                                                            reader.GetString(reader.GetOrdinal("NoiAnTang")).ToString();
                                        if (!reader.IsDBNull(reader.GetOrdinal("NoiAnTang")))
                                            dtpNgayMat.Value = reader.GetDateTime(reader.GetOrdinal("Ngay_Mat"));
                                    }));
                                }
                            }
                            else
                            {
                                Console.WriteLine("Không tìm thấy dữ liệu.");
                            }
                            reader.Close();
                        }
                        else if (c.Status == TaskStatus.Faulted)
                        {
                            Console.WriteLine("Đã xảy ra lỗi: " + c.Exception.InnerException.Message);
                        }
                    });
                }

            }
            else if ( _type == "old")
            {
                panelUpdate.Visible = true;
                cmbHonNhan.SelectedIndex = 1;
                cmbHonNhan.Enabled = false;
                lblHoTenMe.Visible = false;
                lblBo.Visible = false;
                txtHoTenMe.Visible = false;
                cmbHoTenBo.Visible = false;
                cmbTrangthai.SelectedIndex=1;
                cmbTrangthai.Enabled = false;
                cmbDoi.SelectedIndex = -1;
                cmbDoi.Enabled = false;
                cmbGioiTinh.SelectedIndex = 0;
                cmbGioiTinh.Enabled = false;
            }
            

        }

        private void btnThem1_Click(object sender, EventArgs e)
        {
            if(_type == "add")
            {
                Task<bool> themthanhvien = thanhvien.ThemThanhVien(txtHoten.Text, dtpNgaySinh.Value, cmbHoTenBo.SelectedValue.ToString(), 
                    txtHoTenMe.Text, cmbDoi.SelectedItem.ToString(), (byte)cmbGioiTinh.SelectedIndex, txtDiaChi.Text);
                themthanhvien.ContinueWith(t =>
                {
                    if (t.IsFaulted)
                    {
                        MessageBox.Show("Thêm mới không thành công");

                    }
                    else
                    {
                        if (t.Result)
                            MessageBox.Show("Thêm mới thành công");
                        else
                            return;
                    }
                });
            }
            if(_type == "update")
            {
                if(cmbDoi.SelectedItem.ToString() == "1")
                {
                    lblSDT.Visible = false;
                    txtSDT.Visible = false;
                }
                string value = cmbHoTenBo.SelectedValue != null ? cmbHoTenBo.SelectedValue.ToString() : "Không Rõ";
                Task<bool> suathanhvien = thanhvien.SuaThanhVien(_updateforID,txtHoten.Text, dtpNgaySinh.Value, value,
                    txtHoTenMe.Text, cmbDoi.SelectedItem.ToString(), (byte)cmbGioiTinh.SelectedIndex, txtDiaChi.Text,
                    (byte)cmbHonNhan.SelectedIndex,txtVoChong.Text,txtSDT.Text,txtHocvan.Text, 
                    (byte)cmbTrangthai.SelectedIndex,txtNoiAnTang.Text, dtpNgayMat.Value,txtNgheNghiep.Text,txtThanhTuu.Text);
                suathanhvien.ContinueWith(t =>
                {
                    if (t.IsFaulted)
                    {
                        MyMessageBoxError.Message();
                    }
                    else
                    {
                        if (t.Result)
                            MessageBox.Show("Sửa thành công");
                        else
                            return;
                    }
                });
            }
            if (_type == "old")
            {
                Task<bool> themcuto = thanhvien.ThemCuTo(txtHoten.Text, dtpNgaySinh.Value, "Không Rõ",
                    "Không Rõ","1", (byte)cmbGioiTinh.SelectedIndex, txtDiaChi.Text,
                    (byte)cmbHonNhan.SelectedIndex, txtVoChong.Text,txtHocvan.Text,
                    (byte)cmbTrangthai.SelectedIndex, txtNoiAnTang.Text, dtpNgayMat.Value,txtNgheNghiep.Text,txtThanhTuu.Text);
                themcuto.ContinueWith(t =>
                {
                    if (t.IsFaulted)
                    {
                        MessageBox.Show("Thêm mới không thành công");

                    } 
                    else
                    {
                        if (t.Result)
                            MessageBox.Show("Thêm thành công");
                        else
                            return;
                    }
                });
            }
        }

        private void cmbHonNhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbHonNhan.SelectedIndex == 1)
            {
                lblVoChong.Visible = true;
                txtVoChong.Visible = true;
            }
            else
            {
                lblVoChong.Visible = false;
                txtVoChong.Visible = false;
            }
        }

        private void cmbTrangthai_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbTrangthai.SelectedIndex == 1)
            {
                panelMat.Visible = true;
            }
            else
            {
                panelMat.Visible = false;

            }
        }

        private void cmbDoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            int currentValue;
            if (int.TryParse(cmbDoi.SelectedItem.ToString(), out currentValue))
            {
                int newValue = currentValue - 1;

                Task<DataTable> DanhSachCha = thanhvien.DanhSachCha(newValue.ToString());
                DanhSachCha.ContinueWith(t =>
                {
                    Invoke(new Action(() => {
                        cmbHoTenBo.ValueMember = "MaThanhVien";
                        cmbHoTenBo.DisplayMember = "Ten";
                        cmbHoTenBo.DataSource = DanhSachCha.Result;
                    }));
                });
            }

        }

        private void panelUpdate_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbHoTenBo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

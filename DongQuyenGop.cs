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
    
    public partial class DongQuyenGop : Form
    {
        ThanhVienDAL thanhVien = new ThanhVienDAL();
        ThuDAL thu = new ThuDAL();
        ThanhVien_ThuDAL tvThu = new ThanhVien_ThuDAL();
        public EventHandler eLoadData;
        private string _type;
        private string _role;
        public DongQuyenGop()
        {
            InitializeComponent();
        }
        public DongQuyenGop(string type, string role):this()
        {
            _type = type;
            _role = role;
        }

        private void DongQuyenGop_Load(object sender, EventArgs e)
        {
            if(_role == "User")
            {
                MessageBox.Show("Bạn không có quyền");
                Close();
            }
            Task<DataTable> tVien = thanhVien.DanhSachTen();
            tVien.ContinueWith(_t =>
            {
                Invoke(new Action(() =>
                {
                    cmbThanhVien.DisplayMember = "Ten";
                    cmbThanhVien.ValueMember = "MaThanhVien";
                    cmbThanhVien.DataSource = _t.Result;
                }));
            });
            Task<DataTable> taiTro = thu.DanhSachKhoanThuTaiTro();
            taiTro.ContinueWith(_t =>
            {
                Invoke(new Action(() =>
                {
                    cmbQuyenGop.DisplayMember = "TenThu";
                    cmbQuyenGop.ValueMember = "MaThu";
                    cmbQuyenGop.DataSource = _t.Result;
                }));
            });

        }

        private void cmbThanhVien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if(_type == "add")
            {
                Task<bool> thuThanhVien = tvThu.DongQuyenGop(cmbThanhVien.SelectedValue.ToString(), cmbQuyenGop.SelectedValue.ToString(), 
                    dtpNgayThu.Value,txtSoTien.Text,1);
                thuThanhVien.ContinueWith(t =>
                {
                    if (t.IsFaulted)
                    {
                        MessageBox.Show("Có lỗi gì đó");
                    }
                    if (t.Result)
                    {
                        MessageBox.Show("Thêm khoản quyên góp thành công");
                    }
                    else
                    {
                        MessageBox.Show("Thêm khoản quyên góp không thành công");
                    }
                });
            }
            eLoadData?.Invoke(this, e);
        }
    }
}

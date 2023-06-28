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
    public partial class ThongTinCaNhan : Form
    {
        TaiKhoanDAL tk = new TaiKhoanDAL();
        DataTable dt = new DataTable();
        private string user_id;
        public ThongTinCaNhan()
        {
            InitializeComponent();
        }
        public ThongTinCaNhan(string id) : this()
        {
            user_id = id;
        }

        private void labelHeader_Click(object sender, EventArgs e)
        {

        }

        private void panelForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtFullName_Load(object sender, EventArgs e)
        {

        }

        private void customTextBox1_Load(object sender, EventArgs e)
        {

        }

        private async void ThongTinCaNhan_Load(object sender, EventArgs e)
        {
            dt = await tk.ThongTinCaNhan(user_id);
            var firstrow = dt.Rows[0];
            DataTable dtx = await tk.ThongTinCaNhan(firstrow["MaCha"].ToString());
            txtHoTen.Text = firstrow["Ten"].ToString();
            dtpDateofBirth.Value = (DateTime)firstrow["NgaySinh"];
            txtGioiTinh.Text = (bool)firstrow["GioiTinh"] ? "Nam" : "Nữ";
            txtHoTenBo.Text = dtx.Rows[0]["Ten"].ToString();
            txtHoTenMe.Text = firstrow["HoTenMe"].ToString();
            txtHocVan.Text = firstrow["HocVan"].ToString();
            txtNgheNghiep.Text = firstrow["NgheNghiep"].ToString();
            txtHonNhan.Text = (bool)firstrow["TinhTrang_HonNhan"] ? "Đã lập gia đình" : "Độc thân";
            if ((bool)firstrow["TinhTrang_HonNhan"])
            {
                txtVoChong.Text = firstrow["HoTenVo/Chong"].ToString();
                panelHonNhan.Visible = true;
            }

        }
    }
}

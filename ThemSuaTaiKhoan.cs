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
    public partial class ThemSuaTaiKhoan : Form
    {
        private string _id;
        private string _name;
        TaiKhoanDAL tk = new TaiKhoanDAL();
        DataTable dt = new DataTable();
        public ThemSuaTaiKhoan()
        {
            InitializeComponent();
        }
        public ThemSuaTaiKhoan(string id,string name):this()
        {
            _id = id;
            _name = name;
        }

        private async void btnThem_Click(object sender, EventArgs e)
        {
            foreach(DataRow row in dt.Rows)
            {
                if((string)row["User_Name"] == txtTaiKhoan.Text)
                {
                    lblValidate.Visible = true;
                    return;
                }
            }
            DialogResult result = MessageBox.Show("Bạn có muốn cấp tài khoản cho người này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                await tk.UpdateUser(txtTaiKhoan.Text,txtMatKhau.Text, _id);
                MessageBox.Show("Cấp tài khoản Thành Công");
                Close();
            }
            else if (result == DialogResult.No)
            {
                // Người dùng chọn No
                return;
            }
        }

        private async void ThemSuaTaiKhoan_Load(object sender, EventArgs e)
        {
            txtHoTen.Enabled = false;
            txtHoTen.Text = _name;

            dt = await tk.getInfoAllUserAsync();
            DataTable dtMat = new DataTable();
            dtMat = await tk.LayTaiKhoanMatKhau(_id);
            if(dtMat!= null)
            {
                DataRow firstRow = dtMat.Rows[0];
                txtTaiKhoan.Text = (string)firstRow["User_Name"];
                txtMatKhau.Text = (string)firstRow["Password"];
            }

        }

        private void lblValidate_Click(object sender, EventArgs e)
        {

        }
    }
}

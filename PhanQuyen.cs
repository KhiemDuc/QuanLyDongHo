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
using TodoApp.MyClass;

namespace TodoApp
{
    public partial class PhanQuyen : Form
    {
        private string _id;
        private string _name;
        TaiKhoanDAL _taiKhoanDAL= new TaiKhoanDAL();
        private string _chucvu;
        public PhanQuyen()
        {
            InitializeComponent();
        }
        public PhanQuyen(string id,string name,string chucvu):this()
        {
            _id = id;
            _name = name;  
            _chucvu = chucvu;
        }

        private void PhanQuyen_Load(object sender, EventArgs e)
        {
            txtHoTen.Text = _name;
            Task<DataTable> g = _taiKhoanDAL.DanhSachChucVu();
            List<ComboBoxItem> items = new List<ComboBoxItem>();
            g.ContinueWith(t =>
            {
                try
                {
                    for (int i = 0; i < t.Result.Rows.Count; i++)
                    {
                        ComboBoxItem item = new ComboBoxItem();
                        item.Value = t.Result.Rows[i]["Ten_ChucVu"].ToString();
                        item.ID = t.Result.Rows[i]["Ma_ChucVu"].ToString();
                        items.Add(item);
                    }
                    Invoke((Action)(() =>
                    {
                        cmbChucVu.DataSource = items;
                        cmbChucVu.DisplayMember = "Value";
                        cmbChucVu.ValueMember = "ID";
                        int index = cmbChucVu.FindStringExact(_chucvu);

                        // Kiểm tra nếu tìm thấy giá trị
                        if (index != -1)
                        {
                            // Chọn giá trị tương ứng trong ComboBox
                            cmbChucVu.SelectedIndex = index;
                        }
                    }));
                }
                catch
                {
                    return;
                }
            });
        }

        private async void btnThem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn phân quyền cho người này không?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                await _taiKhoanDAL.PhanQuyen(cmbChucVu.SelectedValue.ToString(), _id);
                MessageBox.Show("Phân Quyền Thành Công");
                Close();
            }
            else if (result == DialogResult.No)
            {
                // Người dùng chọn No
                MessageBox.Show("Bạn đã chọn No!");
            }
            
        }

        private void cmbChucVu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

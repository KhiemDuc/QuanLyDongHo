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
    public partial class ThemSuaSuKien : Form
    {
        ChiDAL chi = new ChiDAL();
        ThanhVienDAL thanhvien = new ThanhVienDAL();
        public ThemSuaSuKien()
        {
            InitializeComponent();
        }
        public string _type { get; }
        public string _maThu { get; }


        public ThemSuaSuKien(string type, string maThu):this()
        {
            _type = type;
            _maThu = maThu;
        }

        

        private void btnThem_Click(object sender, EventArgs e)
        {

        }

        private void ThemSuaSuKien_Load(object sender, EventArgs e)
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
        }
    }
}

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
        public DongQuyenGop()
        {
            InitializeComponent();
        }

        private void DongQuyenGop_Load(object sender, EventArgs e)
        {
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

        }

        private void cmbThanhVien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

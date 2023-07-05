using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TodoApp
{
    public partial class ThemSuaKhoanThuChiTiet : Form
    {
        private string _role;
        private string _maGiaoDich;
        private string _type;
        public ThemSuaKhoanThuChiTiet()
        {
            InitializeComponent();
        }
        public ThemSuaKhoanThuChiTiet(string role, string maGiaoDich, string type)
        {
            _role = role;
            _maGiaoDich = maGiaoDich;
            _type = type;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if(_type == "add")
            {

            }
            if(_type == "update")
            {

            }
        }
    }
}

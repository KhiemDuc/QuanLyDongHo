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
    public partial class Home : Form
    {
        private string _role;
        private string _id;
        private string _name;

        public Home()
        {
            InitializeComponent();
            flowLayoutPanel1.Size = flowLayoutPanel1.MinimumSize;
            flowLayoutPanel2.Size = flowLayoutPanel1.MinimumSize;
        }
        public Home(string role = "",string id = "",string name = "") : this()
        {
            _role = role;
            _id = id;
            _name = name;
        }
        
        private Form currentChildForm;
        private void OpenChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Dispose();
                currentChildForm.Close();
                
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.BringToFront();
            childForm.Dock = DockStyle.Fill;
            childForm.Show();
            panelContent.Controls.Add(childForm);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThemThanhVien("add"));  
            lblHeader.Text = btnThem.Text;
        }

        private void btnDanhsach_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Danhsach(_role));
            lblHeader.Text=btnDanhsach.Text;
        }

        private void Homead_Load(object sender, EventArgs e)
        {
            lblUserName.Text = _name;
            if(_role == "User")
            {
                btnThem.Enabled = false;
                btnTaoCuTo.Enabled = false;
                btnQLTK.Visible = false;
            }
            OpenChildForm(new AnhDongHo());
            
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Home_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Owner != null && !Owner.IsDisposed && !Owner.Disposing)
            {
                Owner.Show();
            }
        }

        private void btnCaygiapha_Click(object sender, EventArgs e)
        {

            OpenChildForm(new Caygiapha());
            lblHeader.Text = btnCaygiapha.Text;
        }

        private void btnTaoCuTo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThemThanhVien("old"));
            lblHeader.Text = btnTaoCuTo.Text;
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AnhDongHo());

        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyThu(_role));
            lblHeader.Text = btnThu.Text;

        }

        private void btnThongke_Click(object sender, EventArgs e)
        {
            OpenChildForm(new BaoCaoTC());
            lblHeader.Text = btnThongke.Text;

        }

        private void btnChi_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyChiTieu(_role));
            lblHeader.Text = btnChi.Text;

        }

        private void lblUserName_Click(object sender, EventArgs e)
        {
            var f = new ThongTinCaNhan();
            f.ShowDialog();
        }

        private void btnQuanLySuKien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLySuKien(_role));
            lblHeader.Text = btnQuanLySuKien.Text;
        }

        private void customButton1_Click_1(object sender, EventArgs e)
        {
            if(flowLayoutPanel1.Size == flowLayoutPanel1.MinimumSize)
            {
                flowLayoutPanel1.Size = new Size(flowLayoutPanel1.MaximumSize.Width,flowLayoutPanel1.MaximumSize.Height);
            }
            else
            {
                flowLayoutPanel1.Size = flowLayoutPanel1.MinimumSize;
            }

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            OpenChildForm(new AnhDongHo());
            lblHeader.Text = "Dòng Họ Nhà Nguyễn Đức";

        }

        private void btnThuChi_Click(object sender, EventArgs e)
        {
            if(flowLayoutPanel2.Size == flowLayoutPanel2.MinimumSize)
                flowLayoutPanel2.Size = new Size(flowLayoutPanel2.MaximumSize.Width, flowLayoutPanel2.MaximumSize.Height);
            else
                flowLayoutPanel2.Size = flowLayoutPanel2.MinimumSize;
        }

        private void btnQLTK_Click(object sender, EventArgs e)
        {
            OpenChildForm(new QuanLyTaiKhoan(_role));
            lblHeader.Text = btnQLTK.Text;
        }

        private void btnSetting_Click(object sender, EventArgs e)
        {
            var f = new ThongTinCaNhan(_id);
            f.ShowDialog();
        }

        
    }
}

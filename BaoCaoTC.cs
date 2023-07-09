using DAL;
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
    public partial class BaoCaoTC : Form
    {
        ThuDAL thuDAL = new ThuDAL();
        ChiDAL chiDAL = new ChiDAL();
        public BaoCaoTC()
        {
            InitializeComponent();
        }

        private void BaoCaoTC_Load(object sender, EventArgs e)
        {
            dtpStart.Value = dtpStart.MinDate;
            
        }
        private async void btnXem_Click(object sender, EventArgs e)
        {
            
            float thuDinhMuc = await thuDAL.TongDaThu(dtpStart.Value, dtpEnd.Value, 1);
            float thuTaiTro = await thuDAL.TongDaThu(dtpStart.Value, dtpEnd.Value, 0);
            float tienChi = await chiDAL.TongDaChi(dtpStart.Value, dtpEnd.Value);

            float tienDuKiTruoc = await thuDAL.TongDaThu(dtpStart.MinDate, dtpStart.Value, 1) 
                + await  thuDAL.TongDaThu(dtpStart.MinDate, dtpStart.Value, 0) 
                - await chiDAL.TongDaChi(dtpStart.MinDate, dtpStart.Value);

            lblThuDinhMuc.Text = thuDinhMuc.ToString("N0");
            lblTienTaiTro.Text = thuTaiTro.ToString("N0");
            lblTienDaChi.Text = tienChi.ToString("N0");
            lblTienConLai.Text = (thuDinhMuc + thuTaiTro - tienChi).ToString("N0");
            lblDuKiTruoc.Text = tienDuKiTruoc.ToString("N0");
            if (dtpStart.Value > dtpEnd.Value)
            {
                dtpEnd.Value = dtpStart.Value;
            }
            this.Refresh();
        }

        private void linklbChiTietThuDM_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linklbChiTietTaiTro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linklbChiTietChi_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}

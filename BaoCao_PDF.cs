using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TodoApp
{
    public partial class BaoCao_PDF : Form
    {
        public string ngayBDau, ngayKTthuc, DuKiTruoc, ThuDinhMuc, TienTaiTro, TienChiTieu, TienConLai;
        public BaoCao_PDF()
        {
            InitializeComponent();
        }

        private void btnPr_Click(object sender, EventArgs e)
        {
            Print(this.pnlPrint);
        }

        private void BaoCao_PDF_Load(object sender, EventArgs e)
        {
            lbngayht.Text = DateTime.Now.Day.ToString();
            lbthanght.Text = DateTime.Now.Month.ToString();
            lbnamht.Text = DateTime.Now.Year.ToString();
            nBD.Text = ngayBDau;
            nKT.Text = ngayKTthuc;
            lblDuKiTruoc.Text = DuKiTruoc;
            lblThuDinhMuc.Text = ThuDinhMuc;
            lblTienDaChi.Text = TienChiTieu;
            lblTienTaiTro.Text = TienTaiTro;
            lblTienConLai.Text = TienConLai;
        }
        private void Print(Panel pnl)
        {
            PrinterSettings ps = new PrinterSettings();
            pnlPrint = pnl;
            getprintArea(pnl);
            printPreviewDialog1.Document = printDocument1;
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printPreviewDialog1.ShowDialog();
        }
        private Bitmap memorying;

        private void getprintArea(Panel pnl)
        {
            memorying = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(memorying, new Rectangle(0, 0, pnl.Width, pnl.Height));

        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(memorying, (pagearea.Width / 2) - (this.pnlPrint.Width / 2), this.pnlPrint.Location.Y);
        }

    }
}
using DAL;
using LiveCharts.Wpf;
using LiveCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using System.Runtime.InteropServices;

namespace TodoApp
{
    public partial class BieuDoBaoCaoTaiChinh : Form
    {
        public BieuDoBaoCaoTaiChinh()
        {
            InitializeComponent();
        }
        ChiDAL chiDAL = new ChiDAL();
        ThuDAL thuDal = new ThuDAL();

        private async void BieuDoBaoCaoTaiChinh_Load(object sender, EventArgs e)
        {
            DateTime namBatDau = await thuDal.MinThoiGian();
            DateTime namKetThuc = await thuDal.MaxThoiGian();
            txtNamBatDau.Text = namBatDau.Year.ToString();
            txtNamKetThuc.Text = namKetThuc.Year.ToString();
            HienThiBieuDo(namKetThuc.Year - 4, namKetThuc.Year);
        }
        private void btnXem_Click(object sender, EventArgs e)
        {
            int namBatDau = int.Parse(txtNamBatDau.Text);
            int namKetThuc = int.Parse(txtNamKetThuc.Text);
            HienThiBieuDo(namBatDau, namKetThuc);
        }

        private void HienThiBieuDo(int nbd, int nkt)
        {
            loadDuLieuBieuDoCotThu(nbd, nkt);
            loadDuLieuBieuDoCotChi(nbd, nkt);
            loadDuLieuBieuDoCotQuyenGop(nbd, nkt);
            loadDuLieuBieuDoTungLoaiTien(nbd, nkt);
            loadDuLieuBieuDoDuongVaCot(nbd, nkt);
        }

        private async void loadDuLieuBieuDoDuongVaCot(int namBatDau, int namKetThuc)
        {
            ctsThuChiQG.Series.Clear();
            ctsThuChiQG.AxisX.Clear();
            ctsThuChiQG.AxisY.Clear();
            List<string> nam = new List<string>();
            SeriesCollection ThongTinTien = new SeriesCollection();
            ChartValues<double> valueThongTinChi = new ChartValues<double>(); ;
            ChartValues<double> valueThongTinThu = new ChartValues<double>(); ;
            ChartValues<double> valueQuyenGop = new ChartValues<double>();
            int soNam = namKetThuc - namBatDau;
            for (int i = 0; i <= soNam; i++)
            {
                var namNay = new DateTime(namBatDau, 1, 1);
                var namSau = new DateTime(namNay.Year + 1, 1, 1);
                var TienChiHienTai = await chiDAL.TongDaChi(namNay, namSau);
                valueThongTinChi.Add(TienChiHienTai);
                var TienThuHienTai = await thuDal.TongDaThu(namNay, namSau, 1);
                valueThongTinThu.Add(TienThuHienTai);
                var QuyenGopHienTai = await thuDal.TongDaThu(namNay, namSau, 0);
                valueQuyenGop.Add(QuyenGopHienTai);
                nam.Add(namNay.Year.ToString());
                namBatDau++;
            }
            LineSeries thongTinChi = new LineSeries
            {
                Title = "Tiền Chi",
                Stroke = Brushes.Red,
                Values = valueThongTinChi,
                LabelPoint = point => point.Y.ToString()
            };
            LineSeries thongTinThu = new LineSeries
            {
                Title = "Tiền Thu",
                Stroke = Brushes.Green,
                Values = valueThongTinThu,
                LabelPoint = point => point.Y.ToString()
            };
            LineSeries tienQuyenGop = new LineSeries
            {
                Title = "Tiền Quyên Góp",
                Stroke = Brushes.Blue,
                Values = valueQuyenGop,
                LabelPoint = point => point.Y.ToString()
            };

            var test = nam;
            ctsThuChiQG.AxisX.Add(new Axis
            {
                Title = "Năm",
                Labels = nam,
                FontSize = 13,
                Foreground = Brushes.Black
            });

            ctsThuChiQG.AxisY.Add(new Axis
            {
                Title = "Số tiền",
                FontSize = 13,
                Foreground = Brushes.Black
            });
            ThongTinTien.Add(thongTinChi);
            ThongTinTien.Add(thongTinThu);
            ThongTinTien.Add(tienQuyenGop);
            ctsThuChiQG.Series.AddRange(ThongTinTien);
            ctsThuChiQG.LegendLocation = LegendLocation.Bottom;
        }
        private async void loadDuLieuBieuDoTungLoaiTien(int namBatDau, int namKetThuc)
        {
            pieTCQG.Series.Clear();
            var namNay = new DateTime(namBatDau, 1, 1);
            var namSau = new DateTime(namKetThuc + 1, 1, 1);
            var tienThu = await thuDal.TongDaThu(namNay, namSau, 1);
            var tienQuyenGop = await thuDal.TongDaThu(namNay, namSau, 0);
            var tienChi = await chiDAL.TongDaChi(namNay, namSau);
            var tienConLai = tienThu + tienQuyenGop - tienChi;
            var valueChi = new ChartValues<double>();
            valueChi.Add(tienChi);
            var valueConLai = new ChartValues<double>();
            valueConLai.Add(tienConLai);
            PieSeries seriesTienChi = new PieSeries
            {
                Title = "Tiền Đã Chi",
                Values = valueChi,
                DataLabels = true, // Hiển thị nhãn
                LabelPoint = point => $"{point.Y:C}",
                Fill = System.Windows.Media.Brushes.Red// Dữ liệu của biểu đồ (tổng cộng là 100)
            };

            PieSeries seriesTienConLai = new PieSeries
            {
                Title = "TienConLai",
                Values = valueConLai,
                DataLabels = true, // Hiển thị nhãn
                LabelPoint = point => $"{point.Y:C}",
                Fill = System.Windows.Media.Brushes.Cyan// Dữ liệu của biểu đồ (tổng cộng là 100)
            };
            pieTCQG.Series.Add(seriesTienChi);
            pieTCQG.Series.Add(seriesTienConLai);
        }
        private async void loadDuLieuBieuDoCotQuyenGop(int namBatDau, int namKetThuc)
        {
            int soNam = namKetThuc - namBatDau;
            for (int i = 0; i <= soNam; i++)
            {
                var namNay = new DateTime(namBatDau, 1, 1);
                var namSau = new DateTime(namNay.Year + 1, 1, 1);
                var TienQuyenGopHienTai = await thuDal.TongDaThu(namNay, namSau, 0);

                chartQuyenGop.Series["TienQuyenGop"].Points.AddXY(namBatDau, TienQuyenGopHienTai);
                namBatDau++;
            }
        }


        private async void loadDuLieuBieuDoCotChi(int namBatDau, int namKetThuc)
        {
            int soNam = namKetThuc - namBatDau;
            for (int i = 0; i <= soNam; i++)
            {
                var namNay = new DateTime(namBatDau, 1, 1);
                var namSau = new DateTime(namNay.Year + 1, 1, 1);
                var TienChiHienTai = await chiDAL.TongDaChi(namNay, namSau);
                chartChi.Series["TienChi"].Points.AddXY(namBatDau, TienChiHienTai);
                namBatDau++;
            }
        }

        private async void loadDuLieuBieuDoCotThu(int namBatDau, int namKetThuc)
        {
            int soNam = namKetThuc - namBatDau;
            for (int i = 0; i <= soNam; i++)
            {
                var namNay = new DateTime(namBatDau, 1, 1);
                var namSau = new DateTime(namNay.Year + 1, 1, 1);
                var TienThuHienTai = await thuDal.TongDaThu(namNay, namSau, 1);

                chartThu.Series["TienThu"].Points.AddXY(namBatDau, TienThuHienTai);
                namBatDau++;
            }
        }

        private void txtNamBatDau_TextChanged(object sender, EventArgs e)
        {
            string text = txtNamBatDau.Text; // Lấy giá trị văn bản từ TextBox

            int number;
            bool success = int.TryParse(text, out number);

            if (!success)
            {
                MessageBox.Show("Không hợp lệ"); // Hiển thị thông báo "Không hợp lệ" nếu không phải số
                txtNamBatDau.Text = text; // Gán lại giá trị ban đầu cho TextBox
            }
        }

        private void txtNamKetThuc_TextChanged(object sender, EventArgs e)
        {
            string text = txtNamKetThuc.Text; // Lấy giá trị văn bản từ TextBox
            int number;
            bool success = int.TryParse(text, out number);
            if (!success)
            {
                MessageBox.Show("Không hợp lệ"); // Hiển thị thông báo "Không hợp lệ" nếu không phải số
                txtNamKetThuc.Text = text; // Gán lại giá trị ban đầu cho TextBox
            }
        }
    }
}
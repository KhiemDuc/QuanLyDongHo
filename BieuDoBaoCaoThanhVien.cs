using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using DAL;

namespace TodoApp
{
    public partial class BieuDoBaoCaoThanhVien : Form
    {
        ThanhVienDAL thanhvien = new ThanhVienDAL();
        private string connString = @"Data Source=LAPTOP-KKEAO781\SQLEXPRESS;Initial Catalog=""QuanLyDong Ho"";Integrated Security=True";

        public BieuDoBaoCaoThanhVien()
        {
            InitializeComponent();
        }

        private void BaoCaoThanhVien_Load(object sender, EventArgs e)
        {
             Task<string> tatca = thanhvien.TatCaThanhVien();
            tatca.ContinueWith(t =>
            {
                Invoke(new Action(() =>
                {
                    lblTongSoNguoi.Text = "Số thành viên trong cây gia phả là: " + t.Result;
                }));
            });

            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();

                for (int doi = 1; doi <= 7; doi++)
                {
                    string query = $"SELECT COUNT(*) FROM ThanhVien WHERE Doi = {doi}";

                    SqlCommand command = new SqlCommand(query, connection);
                    int count = (int)command.ExecuteScalar();

                    // Đưa dữ liệu vào Chart Control
                    chart1.Series["Series1"].Points.AddXY($"Doi {doi}", count);
                }
            }
            ChuaCoBangCap();
        }
        
        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        void ChuaCoBangCap()
        {

            string query = "SELECT COUNT(*) FROM ThanhVien";
            int totalMembers = 0;
            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                totalMembers = (int)command.ExecuteScalar();
            }

            // Lấy số lượng người có bằng cấp và tính phần trăm
            query = "SELECT COUNT(*) FROM ThanhVien WHERE HocVan IS NOT NULL";
            int withDegree = 0;

            using (SqlConnection connection = new SqlConnection(connString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                withDegree = (int)command.ExecuteScalar();
            }

            int withoutDegree = totalMembers - withDegree;
            double percentage = (double)withoutDegree / totalMembers;

            // Xóa series hiện có trong Chart1 (nếu có)
            chart2.Series.Clear();

            // Tạo Series mới
            Series series = new Series("Data");
            series.ChartType = SeriesChartType.Pie;

            // Thêm điểm dữ liệu vào Series
            series.Points.AddXY("Có bằng cấp", percentage);
            series.Points.AddXY("Không Có Bằng Cấp", 1 - percentage);

            // Định dạng hiển thị phần trăm
            series.Label = "#PERCENT{P0}";

            // Thêm Series vào Chart1
            chart2.Series.Add(series);
        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TodoApp
{
    
    public partial class AnhDongHo : Form
    {
        private string _role;
        private List<string> imagePaths = new List<string>();
        private string slideShowFolderPath = Path.Combine(Application.StartupPath, "SlideShow");
        private int currentIndex = 0;
        public AnhDongHo()
        {
            InitializeComponent();
        }
        public AnhDongHo(string role):this()
        {
            _role = role;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            currentIndex++;
            if (currentIndex >= imagePaths.Count)
            {
                currentIndex = 0;
            }

            // Hiển thị ảnh mới trong PictureBox
            string imagePath = imagePaths[currentIndex];
            pictureBox1.Image = Image.FromFile(imagePath);
        }

        private void AnhDongHo_Load(object sender, EventArgs e)
        {
            if(_role == "SA")
            {
                btnAddImg.Visible = true;
            }
            // Lấy danh sách đường dẫn tệp ảnh trong thư mục "SlideShow"
            string slideShowFolder = Path.Combine(Application.StartupPath, "SlideShow");
            if (Directory.Exists(slideShowFolder))
            {
                string[] files = Directory.GetFiles(slideShowFolder, "*.jpg");
                imagePaths.AddRange(files);
            }

            // Kiểm tra xem có ảnh nào trong danh sách không
            if (imagePaths.Count > 0)
            {
                // Chọn một ảnh ngẫu nhiên từ danh sách
                Random random = new Random();
                currentIndex = random.Next(imagePaths.Count);

                // Hiển thị ảnh đầu tiên trong PictureBox
                string imagePath = imagePaths[currentIndex];
                pictureBox1.Image = Image.FromFile(imagePath);
            }

            // Khởi tạo Timer và đặt thời gian chuyển đổi ảnh (vd: 3 giây)
            Timer timer = new Timer();
            timer.Interval = 3000;
            timer.Tick += timer1_Tick;
            timer.Start();
        }

        private void btnAddImg_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                foreach (string filePath in openFileDialog.FileNames)
                {
                    // Lấy tên tệp ảnh
                    string fileName = Path.GetFileName(filePath);

                    // Đường dẫn đến thư mục "SlideShow"
                    string destinationPath = Path.Combine(slideShowFolderPath, fileName);

                    // Di chuyển tệp ảnh vào thư mục "SlideShow"
                    File.Copy(filePath, destinationPath, true);
                }
            }
            MessageBox.Show("Bạn Nên Khởi Động Lại Ứng Dụng Để Hiển Thị Ảnh");
        }
    }
}

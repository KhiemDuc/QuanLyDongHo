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
using DAL;

namespace TodoApp
{
    public partial class ThemSuaSuKien : Form
    {
        SuKienDAL sk = new SuKienDAL();
        public EventHandler eLoadData;

        public ThemSuaSuKien()
        {
            InitializeComponent();
        }
        private string _type { get; set; }
        private string _maSuKien { get; set; }
        private string _role { get; set; }



        public ThemSuaSuKien(string type, string maSuKien,string role) :this()
        {
            _type = type;
            _maSuKien = maSuKien;
            _role = role;
        }

        

        private void btnThem_Click(object sender, EventArgs e)
        {
            Task<byte[]> anhSk = Task.Run(() => ImageToByteAsync(pbAnhSuKien.Image));
            anhSk.ContinueWith(t =>
            {
                if (_type == "add")
                {
                    Task<bool> themsukien = sk.ThemSuKien(txtTenSuKien.Text, dtpNgayToChuc.Value, txtDiaDiem.Text, t.Result);
                    themsukien.ContinueWith(th =>
                    {
                        if (th.IsFaulted)
                        {
                            MessageBox.Show("Có Lỗi");
                        }
                        if (th.Result)
                        {
                            MessageBox.Show("Thêm Sự Kiện Thành Công");
                        }
                        else
                        {
                            MessageBox.Show("Thêm Sự Kiện Không Thành Công");
                        }
                    });
                }
                if (_type == "update")
                {
                    Task<bool> suasukien = sk.SuaSuKien(_maSuKien, txtTenSuKien.Text, txtDiaDiem.Text, dtpNgayToChuc.Value, t.Result);
                    suasukien.ContinueWith(s =>
                    {
                        if (s.IsFaulted)
                        {
                            MessageBox.Show("Có Lỗi");
                        }
                        if (s.Result)
                        {
                            MessageBox.Show("Sửa Sự Kiện Thành Công");
                        }
                        else
                        {
                            MessageBox.Show("Sửa Sự Kiện Không Thành Công");
                        }
                    });
                }
                eLoadData?.Invoke(this, e);
            });
            
        }
        async Task<byte[]> ImageToByteAsync(Image img)
        {
            if (img == null)
            {
                return null;
            }
            using (MemoryStream m = new MemoryStream())
            {
                await Task.Run(() => img.Save(m, System.Drawing.Imaging.ImageFormat.Png));
                return m.ToArray();
            }
        }

        async Task<Image> ByteArrayToImageAsync(byte[] img)
        {
            if (img == null)
            {
                return null;
            }
            using (MemoryStream ms = new MemoryStream(img))
            {
                ImageConverter imageConverter = new ImageConverter();
                Image image = await Task.Run(() => (Image)imageConverter.ConvertFrom(img));
                return image;
            }
        }

        private void ThemSuaSuKien_Load(object sender, EventArgs e)
        {
            if(_type == "add")
            {
                if (_role == "User")
                {
                    MessageBox.Show("Bạn không đủ quyền");
                    Close();
                }
            }
            /*Task<DataTable> tenTv = thanhvien.DanhSachTen();
            tenTv.ContinueWith(t =>
            {
                Invoke(new Action(() =>
                {
                    cmbThanhVien.ValueMember = "MaThanhVien";
                    cmbThanhVien.DisplayMember = "Ten";
                    cmbThanhVien.DataSource = t.Result;
                }));
            });*/

            if(_type == "update")
            {
                if (_role == "User")
                {
                    btnThem.Visible = false;
                    this.Text = "Sửa Sự Kiện";
                }
                btnThem.Text = "Lưu";
                Task<DataTable> hienthiSK = sk.HienThiThongTinSuKien(_maSuKien);

                hienthiSK.ContinueWith(t =>
                {
                    DataTable dataTable = t.Result;
                    if (dataTable.Rows.Count > 0)
                    {
                        DataRow row = dataTable.Rows[0];
                        Invoke(new Action(() =>
                        {
                            txtTenSuKien.Text = row["TenSuKien"].ToString();
                            txtDiaDiem.Text = row["DiaDiem"].ToString();
                            dtpNgayToChuc.Value = (DateTime)row["NgayToChuc"];
                            
                        }));
                        byte[] anhSuKien = row["AnhSuKien"] as byte[];
                        if(anhSuKien != null)
                        {
                            Task<Image> anhSkTask = Task.Run(() => ByteArrayToImageAsync(anhSuKien));
                            anhSkTask.ContinueWith(anhtask =>
                            {
                                Image anhSk = anhtask.Result;
                                Invoke(new Action(() => {
                                    // Sử dụng ảnh được tải
                                    if (anhSk != null)
                                    {
                                        pbAnhSuKien.Image = anhSk;
                                    }
                                }));
                            });

                        }
                    }
                });
                
            }
        }

        private void pbAnhSuKien_Click(object sender, EventArgs e)
        {
            OpenFileDialog openImg = new OpenFileDialog();
            openImg.Filter = "Image Files (*.bmp, *.jpg, *.png, *.gif)|*.bmp;*.jpg;*.png;*.gif";

            if (openImg.ShowDialog() == DialogResult.OK)
            {
                pbAnhSuKien.Image = Image.FromFile(openImg.FileName);
                lblLinkAnh.Text = openImg.FileName;
            }
        }

        private void btnChonFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openImg = new OpenFileDialog();
            openImg.Filter = "Image Files (*.bmp, *.jpg, *.png, *.gif)|*.bmp;*.jpg;*.png;*.gif";

            if (openImg.ShowDialog() == DialogResult.OK)
            {
                pbAnhSuKien.Image = Image.FromFile(openImg.FileName);
                lblLinkAnh.Text = openImg.FileName;
                lblLinkAnh.Visible = true;
            }
        }
    }
}

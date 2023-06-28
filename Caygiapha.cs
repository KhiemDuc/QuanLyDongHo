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
using DAL;

namespace TodoApp
{
    public partial class Caygiapha : Form
    {
        ThanhVienDAL thanhvien = new ThanhVienDAL();

        public Caygiapha()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void Caygiapha_Load(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            HienThiTreeView();
        }
        private DataTable truyvan(string sql, SqlConnection con)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            return dt;
        }

        void HienThiTreeView()
        {
            string connString = @"Data Source=LAPTOP-KKEAO781\SQLEXPRESS;Initial Catalog=""QuanLyDong Ho"";Integrated Security=True"; ;
            SqlConnection con = new SqlConnection(connString);
            DataTable node = truyvan("SELECT Ten,[HoTenVo/Chong] From ThanhVien Where Doi = 1", con);
            for (int i = 0; i < node.Rows.Count; i++)
            {
                TreeNode root =  treeView1.Nodes.Add(node.Rows[i][0].ToString());
                if (!string.IsNullOrEmpty(node.Rows[i]["HoTenVo/Chong"].ToString()))
                {
                    root.Text += " (Vợ: " + node.Rows[i]["HoTenVo/Chong"].ToString()+")";
                }
                con.Open();
                dequy(con, root.Nodes);
                con.Close();
            }
        }

        void dequy(SqlConnection con, TreeNodeCollection nc, String filter = "A.Doi='2'")
        {
            DataTable node = truyvan("SELECT A.Ten, B.Ten,A.[HoTenVo/Chong] FROM ThanhVien A JOIN ThanhVien B ON A.MaCha = B.MaThanhVien WHERE " + filter, con);
            for (int i = 0; i < node.Rows.Count; i++)
            {
                TreeNode t = nc.Add(node.Rows[i][0].ToString());

                if (!string.IsNullOrEmpty(node.Rows[i]["HoTenVo/Chong"].ToString()))
                {
                    t.Text += " (Vợ: " + node.Rows[i]["HoTenVo/Chong"].ToString() + ")";
                }
                t.Tag = (t.Level + 1).ToString();
                dequy(con, t.Nodes, "B.Ten=N'" + node.Rows[i][0].ToString() + "'");
            }
        }
    }
        
}

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
using PagedList;

namespace TodoApp
{
    public partial class TodoList : Form
    {
        private readonly string _id;
        private readonly Todo data = new Todo();
        public DataTable cloneData;
        public TodoList()
        {
            InitializeComponent();

        }
        public TodoList(string id) : this()
        {
            _id = id;
            LoadData();
        }

        public void LoadData()
        {
            Task<DataTable> tableDatas = data.GetDataTableTodoAsync(_id);

            tableDatas.ContinueWith(t =>
            {
                try
                {
                    if (t.Result != null)
                    {
                        cloneData = t.Result.Clone();
                        cloneData.Rows.Clear();
                        cloneData = t.Result.Copy();
                    }
                }
                catch
                {
                    MessageBox.Show("Có lỗi gì đó, bạn nên đăng nhập lại");
                }
                finally
                {
                    Invoke(new Action(() =>
                    {
                        ShowListTodo(cloneData);
                    }));
                }
            });
        }
        private void ShowListTodo(DataTable data)
        {
            flowPanelListTask.Controls.Clear();
            for (int i = 0; i < data.Rows.Count; i++)
            {
                customControls.CustomTask taskControl = new customControls.CustomTask();
                taskControl.TaskName = data.Rows[i]["task_name"].ToString();
                taskControl.TaskDescription = data.Rows[i]["task_des"].ToString();
                taskControl.TaskState = data.Rows[i]["task_status"].ToString();
                taskControl.TaskEndDate = data.Rows[i]["end_date"].ToString();
                taskControl.DeleteTask_Click += btnDelete_Click;
                flowPanelListTask.Controls.Add(taskControl);
            }

        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addTodo = new addTodo(_id);
            addTodo.eLoadData += new EventHandler(ob_LoadData);
            addTodo.Show(this);
        }

        private void ob_LoadData(object sender, EventArgs e)
        {
            LoadData();
        }

        private void comboBox1_SelectedValueChanged(object sender, EventArgs e)
        {
            string selectedValue = comboBox1.SelectedItem.ToString();
            if (selectedValue == "All")
            {
                ShowListTodo(cloneData);
            }
            else
            {
                var filteredData = cloneData.Clone();
                foreach (DataRow row in cloneData.Rows)
                {
                    if (row["task_status"].ToString() == selectedValue)
                    {
                        filteredData.Rows.Add(row.ItemArray);
                    }
                }
                ShowListTodo(filteredData);

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {

            }
            else
            {
                var searchData = cloneData.Clone();
                foreach (DataRow row in cloneData.Rows)
                {
                    if (row["task_name"].ToString().Contains(txtSearch.Text) || row["task_des"].ToString().Contains(txtSearch.Text) || row["task_status"].ToString().Contains(txtSearch.Text))
                    {
                        searchData.Rows.Add(row.ItemArray);
                    }
                }

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Done Click");

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = comboBox2.SelectedItem.ToString();
            var searchData = cloneData.Clone();
            foreach (DataRow row in cloneData.Rows)
            {
                if (row["grop_name"].ToString() == selectedValue)
                {
                    searchData.Rows.Add(row.ItemArray);
                }

            }
            cloneData = searchData.Copy();

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (Owner != null && !Owner.IsDisposed && !Owner.Disposing && !Owner.Visible)
                Owner.Show();
            Close();
        }

        private void TodoList_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Owner != null && !Owner.IsDisposed && !Owner.Disposing && !Owner.Visible)
                Owner.Show();

        }

        private void flowPanelListTask_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

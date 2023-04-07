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
        private readonly string _username;
        private readonly string _email;
        private readonly string _id;
        private readonly Todo data = new Todo();
        public DataTable cloneData;
        public TodoList()
        {
            InitializeComponent();
            
        }
        public TodoList(string username,string id) : this()
        {
            _username = username;
            _id = id;
            lblUserName.Text = _username;
            lblEmail.Text = _email;
            LoadData();
            renameGridiewData();
        }

        public async void LoadData()
        {
            var tableDatas = await data.GetDataTableTodoAsync(_id);
            cloneData = tableDatas.Clone();
            cloneData.Rows.Clear();
            cloneData = tableDatas.Copy();
          
            gridDataTodo.DataSource = cloneData;   
        }
        public void renameGridiewData()
        {
            gridDataTodo.Columns["task_id"].Visible = false;
            gridDataTodo.Columns["task_name"].HeaderText = "Tên Công Việc";
            gridDataTodo.Columns["task_des"].HeaderText = "Tiêu đề";
            gridDataTodo.Columns["task_status"].HeaderText = "Trạng thái";
            gridDataTodo.Columns["start_date"].HeaderText = "Ngày bắt đầu";
            gridDataTodo.Columns["end_date"].HeaderText = "Ngày kết thúc";
            gridDataTodo.Columns["grop_name"].HeaderText = "Phân loại";
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
            if(selectedValue== "All")
            {
                gridDataTodo.DataSource = cloneData;
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
                gridDataTodo.DataSource = filteredData;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtSearch.Text == "")
            {
                gridDataTodo.DataSource = cloneData;
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
                gridDataTodo.DataSource = searchData;
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (gridDataTodo.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = gridDataTodo.SelectedRows[0];
                string task_id = selectedRow.Cells["task_id"].Value.ToString();
                await data.deleteToDo(task_id);
                LoadData();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = comboBox2.SelectedItem.ToString();
            var filteredData = cloneData.Clone();
            foreach (DataRow row in cloneData.Rows)
            {
                if (row["grop_name"].ToString() == selectedValue)
                {
                    filteredData.Rows.Add(row.ItemArray);
                }

            }
            gridDataTodo.DataSource = filteredData;
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


    }
}

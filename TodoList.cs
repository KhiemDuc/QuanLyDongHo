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
using System.Threading;

namespace TodoApp
{
    public partial class TodoList : Form
    {
        private readonly string _id;
        private readonly Todo data = new Todo();
        private readonly UserAccess user = new UserAccess();
        public DataTable cloneData;
        private CancellationTokenSource cts = new CancellationTokenSource();
        public TodoList()
        {
            InitializeComponent();

        }
        public TodoList(string id) : this()
        {
            _id = id;
            LoadUserNameAndMail(id);
            LoadData();
        }

        // Load Data
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
                    ShowListTodo(cloneData);
                    LoadGroupName(_id);
                }
            });
        }
        private void ShowListTodo(DataTable data)
        {
            if (InvokeRequired)
                Invoke(new Action(() =>
                {
                    flowPanelListTask.Controls.Clear();
                }));
            else
                flowPanelListTask.Controls.Clear();

            for (int i = 0; i < data.Rows.Count; i++)
            {
                customControls.CustomTask taskControl = new customControls.CustomTask();
                taskControl.TaskName = data.Rows[i]["task_name"].ToString();
                taskControl.TaskDescription = data.Rows[i]["task_des"].ToString();
                taskControl.TaskState = data.Rows[i]["task_status"].ToString();
                taskControl.TaskEndDate = data.Rows[i]["end_date"].ToString();
                taskControl.TaskID = data.Rows[i]["task_id"].ToString();
                taskControl.TaskGroup = data.Rows[i]["group_name"].ToString();
                taskControl.DeleteTask_Click += btnDelete_Click;

               if (InvokeRequired)
                    Invoke((Action)(() =>
                   {
                        flowPanelListTask.Controls.Add(taskControl);
                    }));
                else
                    flowPanelListTask.Controls.Add(taskControl);
            }

        }

        private void LoadGroupName(string id)
        {

            Task<DataTable> g = data.GetGroupNameAsync(id);
            g.ContinueWith(t =>
            {
                if (g.Status == TaskStatus.Faulted)
                {
                    return;
                }
                else
                {
                    for(int i = 0; i < t.Result.Rows.Count ; i++)
                    {
                        if (InvokeRequired)
                        {

                            Invoke((Action)(() =>
                            {
                                cmbGroup.Items.Add(t.Result.Rows[i]["group_name"].ToString());
                            }));
                            
                        }
                        else
                            cmbGroup.Items.Add(t.Result.Rows[i]["group_name"].ToString());
                    }
                }

            });
        }

        public void LoadUserNameAndMail(string id) {
            Task<List<string>> userAndEmail = user.GetUserNameAndEmail(id, cts.Token);
            userAndEmail.ContinueWith(t =>
            {
                Invoke((Action)(() =>
                {
                    lblUserName.Text = "@" + t.Result[0];
                }));

            });

        }

        private void ob_LoadData(object sender, EventArgs e)
        {
            LoadData();
        }


        // Action Add and Delete
        private void btnDelete_Click(object sender, MyEventArgs e)
        {
            DialogResult dialogResult 
                = MessageBox.Show("Bạn có muốn xóa công việc này chứ", "Xác nhận",MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                string id_Task = e.Id.ToString();
                Task delete = data.DeleteToDo(id_Task);
                delete.ContinueWith(t =>
                {
                    LoadData();
                });
            }
            else
            {
                return;
            }
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            var addTodo = new addTodo(_id);
            addTodo.eLoadData += new EventHandler(ob_LoadData);
            addTodo.Show(this);
        }


        // Filter and Search
        private void cmbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = cmbGroup.SelectedItem.ToString();
            if (selectedValue == "All")
            {
                ShowListTodo(cloneData);
                return;
            }
            else
            {
                var searchData = cloneData.Clone();
                foreach (DataRow row in cloneData.Rows)
                {
                    if (row["group_name"].ToString() == selectedValue)
                    {
                        searchData.Rows.Add(row.ItemArray);
                    }
                }

                ShowListTodo(searchData);
            }
        }

        private void cmbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedValue = cmbFilter.SelectedItem.ToString();
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
                ShowListTodo(cloneData);
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
                ShowListTodo(searchData);
            }
        }

        // Close and Logout
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
        
        private void DisposeGarbage()
        {
            cts?.Dispose();
            data.Dispose();
            user.Dispose();
            cloneData?.Dispose();
        }

        private void btnTaskBroad_Click(object sender, EventArgs e)
        {

        }
    }
}

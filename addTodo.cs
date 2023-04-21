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
using System.Threading;

namespace TodoApp
{
    public partial class addTodo : Form
    {
        private readonly Todo TodoTask = new Todo();
        private readonly string _id;
        public event EventHandler eLoadData;
        private CancellationTokenSource cts = new CancellationTokenSource();
        private Todo data = new Todo();
        public addTodo()
        {
            InitializeComponent();
        }
        public addTodo(string id) : this()
        {
            _id = id;
            LoadGroupName(id);

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

            var dateEnd = dtpEnd.Value.ToString("MM/dd/yyyy");
            var dateStart = dtpStart.Value.ToString("MM/dd/yyyy");

            Task Insert = TodoTask.InsertTodo(txtTaskName.Text, cmbGroup.SelectedValue.ToString(), txtDes.Text, 
                dateStart, dateEnd, cmbStatus.SelectedItem.ToString(), _id, cts.Token);
            Insert.ContinueWith(t =>
            {
                if (Insert.IsFaulted)
                {
                     Invoke(new Action(() =>
                   {
                        lblValidate.Text = "Có lỗi gì đó";
                    }));
                }
            });
            lblValidate.Visible = false;
            txtTaskName.Text = "";
            txtDes.Text = "";
            eLoadData?.Invoke(this, e);
        }

        private void LoadGroupName(string id)
        {

            Task<DataTable> g = data.GetGroupNameAsync(id);
            List<ComboBoxItem> items = new List<ComboBoxItem>();
            g.ContinueWith(t =>
            {
                if (g.Status == TaskStatus.Faulted)
                {
                    return;
                }
                else
                {
                    try
                    {
                        for (int i = 0; i < t.Result.Rows.Count; i++)
                        {
                            ComboBoxItem item = new ComboBoxItem();
                            item.Value = t.Result.Rows[i]["group_name"].ToString();
                            item.ID = t.Result.Rows[i]["group_id"].ToString();
                            items.Add(item);
                        }
                        cmbGroup.DataSource = items;
                        cmbGroup.DisplayMember = "Value";
                        cmbGroup.ValueMember = "ID";
                    }
                    catch
                    {
                        MessageBox.Show("Có lỗi gì đó, bạn nên đăng nhập lại");
                    }

                }

            });
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbDes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void validate()
        {
            var _tEmtyTaskName = string.IsNullOrWhiteSpace(txtTaskName.Text);
            
            if (cmbGroup.SelectedItem == null)
            {
                btnAdd.Enabled = false;
                lblValidateGroup.Visible = true;

            }

            lblValidateTaskName.Visible = _tEmtyTaskName;

            btnAdd.Enabled = !_tEmtyTaskName;

        }

        private void txtTaskName_TextChanged(object sender, EventArgs e)
        {
            validate();
        }

        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            var f = new addGroup(_id);
            f.eLoadData += new EventHandler(eLoadGroup);
            f.ShowDialog();

        }

        private void eLoadGroup(object sender, EventArgs e)
        {
            LoadGroupName(_id);
        }
    }
}

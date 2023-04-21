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
    public partial class addGroup : Form
    {
        private readonly string _id;
        private Todo _todo = new Todo();
        private CancellationTokenSource _cts = new CancellationTokenSource();
        public event EventHandler eLoadData;

        public addGroup()
        {
            InitializeComponent();
        }

        public addGroup(string id): this()
        {
            _id = id;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAddGroup_Click(object sender, EventArgs e)
        {
            Task<bool> tcheck = _todo.checkGroupNameAsync(_id, txtAddGroup.Text, _cts.Token);
            tcheck.ContinueWith(c =>
            {
                if (c.Status == TaskStatus.Faulted)
                {
                    return;
                }
                if (c.Result == false)
                {
                    Task addGroup = _todo.InsertGroup(_id, txtAddGroup.Text, _cts.Token);
                    addGroup.ContinueWith(a =>
                    {
                        if (a.Status == TaskStatus.Faulted)
                        {
                            lblvalidate.Text = "Tạo không thành công";
                            return;
                        }
                        else
                        {
                            lblvalidate.Text = "Tạo thành công";
                            lblvalidate.ForeColor = Color.Turquoise;
                            eLoadData?.Invoke(this, e);
                        }
                    });
                }
                else
                {
                    lblvalidate.Text = "Tên nhóm đã tồn tại";
                    return ;
                }
            },TaskScheduler.FromCurrentSynchronizationContext() );
        }

        private void validate()
        {
            var _tCheckTxtAddGroup = string.IsNullOrWhiteSpace(txtAddGroup.Text);
            btnAddGroup.Enabled = !_tCheckTxtAddGroup;
            lblvalidate.Text = _tCheckTxtAddGroup? "Không được để trống tên nhóm": String.Empty;
        }

        private void txtAddGroup_TextChanged(object sender, EventArgs e)
        {
            lblvalidate.Text = String.Empty;
            validate();
        }
    }
}

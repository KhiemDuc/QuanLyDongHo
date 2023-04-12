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

namespace TodoApp
{
    public partial class addTodo : Form
    {
        private readonly Todo Task = new Todo();
        private readonly string _id;
        public event EventHandler eLoadData;
        public addTodo()
        {
            InitializeComponent();
        }
        public addTodo(string id):this()
        {
            _id = id;
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtTaskName.Text == "" || txtDes.Text == "" || dtpEnd.Text == "" || String.IsNullOrWhiteSpace(cmbDes.SelectedItem.ToString()))
            {
                lblValidate.Text = "Không được để trống một trong các trường";
            }
            else 
            {
                var dateEnd = dtpEnd.Value.ToString("MM/dd/yyyy");
                var dateStart = dtpStart.Value.ToString("MM/dd/yyyy");
                //await Task.InsertTodo(txtTaskName.Text, txtDes.Text, dateStart, dateEnd, cmbDes.SelectedItem.ToString(), _id);
                lblValidate.Visible = false;
                txtTaskName.Text = "";
                txtDes.Text = "";
            }
            eLoadData?.Invoke(this, e);
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbDes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

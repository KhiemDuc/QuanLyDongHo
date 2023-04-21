using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TodoApp.customControls
{
    public partial class CustomTask : UserControl
    {
        private string taskName = "";
        private string taskDescription = "";
        private string taskState = "";
        private string taskEndDate = "";
        private string taskID = "";
        private string taskGroup = "";
        public event EventHandler<MyEventArgs> UpdateTask_Click;
        public event EventHandler<MyEventArgs> DeleteTask_Click;

        public CustomTask()
        {
            InitializeComponent();
        }
        public string TaskEndDate
        {
            get { return taskEndDate; }

            set
            {
                taskEndDate = value;
                lblEnd.Text = taskEndDate;
                this.Invalidate();
            }
        }
        public string TaskID
        {
            get { return taskID; }

            set
            {
                taskID = value;
            }
        }

        public string TaskName
        {
            get => taskName;

            set
            {
                taskName = value; 
                lblTaskName.Text = taskName; 
                this.Invalidate();
            }
        }
        public string TaskDescription 
        { 
            get => taskDescription;

            set
            {
                taskDescription = value;
                lblDes.Text = taskDescription;
                this.Invalidate();
            } 
        }
        public string TaskState 
        { 
            get => taskState;

            set
            {
                taskState = value;
                if(taskState == "In Progress") {
                    lblState.ForeColor = Color.Blue;
                    lblState.BackColor = Color.FromArgb(225, 247, 254);
                }
                else if(taskState == "Not started")
                {
                    lblState.ForeColor = Color.Red;
                    lblState.BackColor = Color.FromArgb(253, 234, 240);
                }
                else
                {
                    lblState.ForeColor = Color.FromArgb(120,206,28);
                    lblState.BackColor = Color.FromArgb(236, 253, 230);

                }
                lblState.Text = taskState;
                this.Invalidate();
            }
        }

        public string TaskGroup { 
            get => taskGroup; 
            set 
            { 
                taskGroup = value;
                lblGroup.Text = taskGroup;
                this.Invalidate();
            } 
        }

        //public int BorderSize
        //{
        //    get { return borderSize; }
        //    set
        //    {
        //        borderSize = value;
        //        this.Invalidate();
        //    }
        //}

        private void customButton1_Click(object sender, EventArgs e)
        {
            MyEventArgs arg = new MyEventArgs(taskID);
            UpdateTask_Click?.Invoke(this, arg);
        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            MyEventArgs arg = new MyEventArgs(taskID);
            DeleteTask_Click?.Invoke(this, arg);
        }
    }
}

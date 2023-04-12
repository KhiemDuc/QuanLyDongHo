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
        private int borderSize = 1;
        private int borderRadius = 5;
        private Color borderColor = Color.Black;
        public event EventHandler UpdateTask_Click;
        public event EventHandler DeleteTask_Click;

        public CustomTask()
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.Dpi;
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
                }
                else if(taskState == "Not started")
                {
                    lblState.ForeColor = Color.Red;
                }
                else
                {
                    lblState.ForeColor = Color.Turquoise;
                }
                lblState.Text = taskState;
                this.Invalidate();
            }
        }
        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }

        
        public int BorderRadius
        {
            get { return borderRadius; }
            set
            {
                borderRadius = value;
                this.Invalidate();
            }
        }

        
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }
        protected override void OnPaint(PaintEventArgs pevent)
        {
            base.OnPaint(pevent);


            Rectangle rectSurface = this.ClientRectangle;
            Rectangle rectBorder = Rectangle.Inflate(rectSurface, -borderSize, -borderSize);
            int smoothSize = 2;
            if (borderSize > 0)
                smoothSize = borderSize;

            if (borderRadius > 2)
            {
                using (GraphicsPath pathSurface = GetFigurePath(rectSurface, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
                using (Pen penSurface = new Pen(this.Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                    //Button surface
                    this.Region = new Region(pathSurface);
                    //Draw surface border for HD result
                    pevent.Graphics.DrawPath(penSurface, pathSurface);

                    //Button border                    
                    if (borderSize >= 1)
                        //Draw control border
                        pevent.Graphics.DrawPath(penBorder, pathBorder);
                }
            }

        }
        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;

            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        private void customButton1_Click(object sender, EventArgs e)
        {
            UpdateTask_Click?.Invoke(this, e);
        }

        private void customButton2_Click(object sender, EventArgs e)
        {
            DeleteTask_Click?.Invoke(this, e);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TodoApp.customControls
{
    public partial class CustomTextBox : UserControl
    {
        private int borderSize = 2;
        private bool underlinedStyle = false;
        private Color borderColor = Color.PaleVioletRed;
        private Color borderFocusColor = Color.Turquoise;
        private bool isFocused = false;
        private bool useSystemPasswordChar = false;
        private int maxLength = 1000;
        private bool isNotSpace = false;


        public event EventHandler _TextChanged;
        public event EventHandler _TextKeyPress;

        //Properties

        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }

        public bool UnderlinedStyle
        {
            get { return underlinedStyle; }
            set
            {
                underlinedStyle = value;
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
        public Color BorderFocusColor
        {
            get { return borderFocusColor; }
            set { borderFocusColor = value; }
        }

        public bool UseSystemPasswordChar { 
            get => useSystemPasswordChar; 
            set
            {

                useSystemPasswordChar = value;
                textBox2.UseSystemPasswordChar = useSystemPasswordChar;
            } 
        }

        public override string Text {
            get { 
                return textBox2.Text; 
            }
            set { 
                textBox2.Text = value; 
            }
        }

        public int MaxLength {
            get => maxLength; 
            set { 
                maxLength = value; 
                textBox2.MaxLength = maxLength;
            } 
        }

        public bool IsNotSpace { get => isNotSpace; set => isNotSpace = value; }

        // Contructor
        public CustomTextBox()
        {
            InitializeComponent();
        }

        public CustomTextBox(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
        //Method
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;

            //Draw border
            using (Pen penBorder = new Pen(borderColor, borderSize))
            {
                penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                if (isFocused) penBorder.Color = borderFocusColor;

                if (underlinedStyle) //Line Style
                    graph.DrawLine(penBorder, 0, this.Height - 0.5F, this.Width, this.Height - 0.5F);
                else //Normal Style
                    graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 1F);
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            isFocused = false;
            this.Invalidate();
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            isFocused = true;
            this.Invalidate();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (_TextChanged != null)
                _TextChanged?.Invoke(sender, e);
            if (isNotSpace)
            {
                (sender as TextBox).Text = Regex.Replace((sender as TextBox).Text, @"\s+", "");
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isNotSpace)
            {
                if (char.IsWhiteSpace(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            _TextKeyPress?.Invoke(sender, e);
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Management
{
    public partial class EllipseButton : UserControl
    {
        public EllipseButton()
        {
            InitializeComponent();
        }

        // 按钮边框色
        private Color intBorderColor = Color.Blue;
        public Color BorderColor
        {
            get { return intBorderColor; }
            set { intBorderColor = value; }
        }

        // 按钮背景色
        private Color intButtonBackColor = Color.White;
        public Color ButtonBackColor
        {
            get { return intButtonBackColor; }
            set { intButtonBackColor = value; }
        }

        // 鼠标悬停时边框色
        private Color intHoverBorderColor = Color.Red;
        public Color HoverBorderColor
        {
            get { return intHoverBorderColor; }
            set { intHoverBorderColor = value; }
        }

        // 鼠标悬停时背景色
        private Color intHoverBackColor = Color.SkyBlue;
        public Color HoverBackColor
        {
            get { return intHoverBackColor; }
            set { intHoverBackColor = value; }
        }

        // 按钮文本
        private string strCaption = null;
        public string Caption
        {
            get { return strCaption; }
            set { strCaption = value; }
        }

        // 鼠标悬停标志
        private bool bolMouseHoverFlag = false;

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            // 创建椭圆路径
            using (System.Drawing.Drawing2D.GraphicsPath path =
                        new System.Drawing.Drawing2D.GraphicsPath())
            {
                path.AddEllipse(0, 0, this.ClientSize.Width - 1, this.ClientSize.Height - 1);
                // 填充背景色
                using (SolidBrush b = new SolidBrush(
                            bolMouseHoverFlag ? this.HoverBackColor : this.ButtonBackColor))
                {
                    e.Graphics.FillPath(b, path);
                }
                // 绘制边框
                using (Pen p = new Pen(
                            bolMouseHoverFlag ? this.HoverBorderColor : this.BorderColor, 2))
                {
                    e.Graphics.DrawPath(p, path);
                }
            }
            if (this.Caption != null)
            {
                // 绘制文本
                using (StringFormat f = new StringFormat())
                {
                    // 水平居中对齐
                    f.Alignment = System.Drawing.StringAlignment.Center;
                    // 垂直居中对齐
                    f.LineAlignment = System.Drawing.StringAlignment.Center;
                    // 设置为单行文本
                    f.FormatFlags = System.Drawing.StringFormatFlags.NoWrap;
                    // 绘制文本
                    using (SolidBrush b = new SolidBrush(this.ForeColor))
                    {
                        e.Graphics.DrawString(
                            this.Caption,
                            this.Font,
                            b,
                            new System.Drawing.RectangleF(
                            0,
                            0,
                            this.ClientSize.Width,
                            this.ClientSize.Height),
                            f);
                    }
                }
            }
        }

        private bool CheckMouseHover(int x, int y)
        {
            using (System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                path.AddEllipse(0, 0, this.ClientSize.Width - 1, this.ClientSize.Height - 1);
                bool flag = path.IsVisible(x, y);
                if (flag != bolMouseHoverFlag)
                {
                    bolMouseHoverFlag = flag;
                    this.Invalidate();
                }
                return flag;
            }
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            this.CheckMouseHover(e.X, e.Y);
            base.OnMouseMove(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            this.CheckMouseHover(-1, -1);
            base.OnMouseLeave(e);
        }

        protected override void OnClick(EventArgs e)
        {
            Point p = System.Windows.Forms.Control.MousePosition;
            p = base.PointToClient(p);
            if (CheckMouseHover(p.X, p.Y))
            {
                base.OnClick(e);
            }
        }


    }
}

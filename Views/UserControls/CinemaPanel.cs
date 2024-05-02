using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cinema_Booking_Management_System.Extensions;

namespace Cinema_Booking_Management_System.UserControls
{
    public class CinemaPanel : Panel
    {
        private int _radius = 5;
        public int Radius
        {
            get { return _radius; }
            set
            {
                _radius = value;
                Invalidate();
            }
        }

        private SolidBrush _backgroundBrush = new SolidBrush(SystemColors.Control);
        private Color _backgroundColor = SystemColors.Control;
        public Color BackgroundColor
        {
            get { return _backgroundColor; }
            set
            {
                _backgroundBrush = new SolidBrush(_backgroundColor = value);
                Invalidate();
            }
        }

        private Color _borderColor = SystemColors.Control;
        private Pen _borderPen = new Pen(ControlPaint.Light(SystemColors.Control, 0.0f), 0);
        public Color BorderColor
        {
            get { return _borderColor; }
            set
            {
                _borderColor = value;
                _borderPen = new Pen(ControlPaint.Light(_borderColor, 0.0f), _borderWidth);
                Invalidate();
            }
        }

        private float _borderWidth = 1.0f;
        public float BorderWidth
        {
            get { return _borderWidth; }
            set
            {
                _borderWidth = value;
                _borderPen = new Pen(ControlPaint.Light(_borderColor, 0.0f), _borderWidth);
                Invalidate();
            }
        }

        private int _left = 10;
        public int paddingLeft
        {
            get { return _left; }
            set
            {
                _left = value;
                Invalidate();
            }
        }

        private int _right = 10;

        public int paddingRight
        {
            get { return _right; }
            set
            {
                _right = value;
                Invalidate();
            }
        }


        private int _top = 10;

        public int paddingTop
        {
            get { return _top; }
            set
            {
                _top = value;
                Invalidate();
            }
        }

        private int _bottom = 10;
        public int paddingBottom
        {
            get { return _bottom; }
            set
            {
                _bottom = value;
                Invalidate();
            }
        }

        private void drawBorder(Graphics g) =>
            g.DrawRoundedRectangle(_borderPen, _left + _borderWidth / 2, _top + _borderWidth / 2, Width - _right - _borderWidth, Height - _bottom - _borderWidth, _radius);

        private void drawBackground(Graphics g) =>
            g.FillRoundedRectangle(_backgroundBrush, _left, _top, Width - _right, Height - _bottom, _radius);

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            drawBorder(g);
            drawBackground(g);
        }
    }
}

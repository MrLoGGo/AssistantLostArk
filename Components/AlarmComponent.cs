using System.Drawing.Drawing2D;
using System.Drawing;
using System.Windows.Forms;

namespace AssistantLostArk
{
    public class AlarmControl : Control
    {
        #region --Переменные--
        private StringFormat SF = new StringFormat();
        #endregion
        #region --Свойства--
        public string TimeText { get; set; } = "00:00:00";
        public bool Checked { get; set; } = false;
        #endregion


        public AlarmControl()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.ResizeRedraw |
                ControlStyles.SupportsTransparentBackColor |
                ControlStyles.UserPaint, true);
            DoubleBuffered = true;

            Size = new Size(314, 66);
            Font = new Font("Palatino Linotype", 18F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(204)));
            ForeColor = Color.White;
            BackColor = Color.Black;

            SF.Alignment = StringAlignment.Center;
            SF.LineAlignment = StringAlignment.Center;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.HighQuality;//236

            g.Clear(Parent.BackColor);

            Rectangle rect = new Rectangle(0, 0, Width - 1, Height - 1);
            Rectangle rectForText = new Rectangle(0, 0, Width - 111, Height - 1);
            Rectangle checkBox = new Rectangle(Width - 21,(Height-10)/2,10,10);
            Rectangle checkBoxChecked = new Rectangle(Width - (21-2), (Height - 6) / 2, 6, 6);

            g.DrawRectangle(new Pen(BackColor), rect);
            g.FillRectangle(new SolidBrush(BackColor), rect);

            //g.DrawRectangle(new Pen(Color.White), squareCheckBox);
            g.DrawEllipse(new Pen(Color.White), checkBox);
            g.FillEllipse(new SolidBrush(Color.White), checkBox);

            if (Checked)
            {
                g.DrawEllipse(new Pen(Color.Black), checkBoxChecked);
                g.FillEllipse(new SolidBrush(Color.Black), checkBoxChecked);
            }
            else
            {
                g.DrawEllipse(new Pen(Color.White), checkBoxChecked);
                g.FillEllipse(new SolidBrush(Color.White), checkBoxChecked);
            }

            g.DrawString(this.TimeText, Font, new SolidBrush(ForeColor), rectForText, SF);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            if(Checked)
            {
                Checked = false;
            }
            else
            {
                Checked = true;
            }
            Invalidate();
        }
    }
}
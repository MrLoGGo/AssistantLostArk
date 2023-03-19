using System.Windows.Forms;

namespace AssistantLostArk
{
    internal class Time
    {
        private bool buttonStopDown = false;
        private byte s = 0, m = 0, h = 0;
        

        public void SetSMH(byte s, byte m, byte h)
        {
            this.s = s;
            this.m = m;
            this.h = h;
        }

        public byte[] GetSMH()
        {
            byte[] SMH = { s, m, h };
            return SMH;
        }
        public byte GetSMHForEnd()
        {
            return (byte)(s+m+h);
        }

        public byte GetS() { return s; }
        public byte GetM() { return m; }
        public byte GetH() { return h; }
        public bool GetButtonStopDown() { return buttonStopDown; }

        public void SetS(byte s) { this.s = s; }
        public void SetM(byte m) { this.m = m; }
        public void SetH(byte h) { this.h = h; }
        public void SetButtonStopDown(bool stop) { this.buttonStopDown = stop; }

        public void SetTimeInControl(MaskedTextBox timeLable, char unitOfTime)
        {
            if (unitOfTime == 's')
            {
                timeLable.Text = timeLable.Text.Remove(6, 2).Insert(6, s.ToString());
            }
            else if (unitOfTime == 'm')
            {
                timeLable.Text = timeLable.Text.Remove(3, 2).Insert(3, m.ToString());
            }
            else if (unitOfTime == 'h')
            {
                timeLable.Text = timeLable.Text.Remove(0, 2).Insert(0, h.ToString());
            }
        }
        public void SetTimeInControl(MaskedTextBox timeLable, char unitOfTime, bool one)
        {
            if (one)
            {
                if (unitOfTime == 's')
                {
                    timeLable.Text = timeLable.Text.Remove(6, 2).Insert(6, s.ToString()).Insert(6, "0");
                }
                else if (unitOfTime == 'm')
                {
                    timeLable.Text = timeLable.Text.Remove(3, 2).Insert(3, m.ToString()).Insert(3, "0");
                }
                else if (unitOfTime == 'h')
                {
                    timeLable.Text = timeLable.Text.Remove(0, 2).Insert(0, h.ToString()).Insert(0, "0");
                }
            }
            else
            {
                if (unitOfTime == 's')
                {
                    timeLable.Text = timeLable.Text.Remove(6, 2).Insert(6, s.ToString());
                }
                else if (unitOfTime == 'm')
                {
                    timeLable.Text = timeLable.Text.Remove(3, 2).Insert(3, m.ToString());
                }
                else if (unitOfTime == 'h')
                {
                    timeLable.Text = timeLable.Text.Remove(0, 2).Insert(0, h.ToString());
                }
            }
        }
    }
}

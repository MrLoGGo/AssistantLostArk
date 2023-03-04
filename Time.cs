using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssistantLostArk
{
    internal class Time
    {

        private byte s = 0, m = 0, h = 0;
        private bool buttonStopDown = false, timerStopClick = false, working = true;
        

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
        public void SetS(byte s) { this.s = s; }
        public void SetM(byte m) { this.m = m; }
        public void SetH(byte h) { this.h = h; }
        public void SetButtonStopDown(bool stop) { this.buttonStopDown = stop; }
        public void SetTimerStopClick(bool stop) { this.timerStopClick = stop; }
        public void SetWorking(bool working) { this.working = working; }

        public byte GetS() { return s; }
        public byte GetM() { return m; }
        public byte GetH() { return h; }
        public bool GetButtonStopDown() { return buttonStopDown; }
        public bool GetTimerStopClick() { return timerStopClick; }
        public bool GetWorking() { return working; }

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

        async static public void Stopwatch(MaskedTextBox stopwatchLable, Time timeForStopwatch)
        {
            if (timeForStopwatch.GetWorking())
            {

                timeForStopwatch.SetWorking(false);
                timeForStopwatch.SetButtonStopDown(false);
                stopwatchLable.Text = "00:00:00";
                timeForStopwatch.SetSMH(0, 0, 0);

                while (true)
                {
                    if (timeForStopwatch.GetButtonStopDown())
                    {
                        timeForStopwatch.SetS((byte)(timeForStopwatch.GetS() - 1));
                        if (timeForStopwatch.GetS() < 10)
                        {
                            timeForStopwatch.SetTimeInControl(stopwatchLable, 's', true);
                        }
                        else
                        {
                            timeForStopwatch.SetTimeInControl(stopwatchLable, 's');
                        }
                        timeForStopwatch.SetButtonStopDown(false);
                        return;
                    }
                    await Task.Delay(1000);

                    timeForStopwatch.SetS((byte)(timeForStopwatch.GetS() + 1));

                    if (timeForStopwatch.GetS() < 10)
                    {
                        timeForStopwatch.SetTimeInControl(stopwatchLable, 's', true);
                    }
                    else
                    {
                        timeForStopwatch.SetTimeInControl(stopwatchLable, 's');
                    }

                    if (timeForStopwatch.GetS() == 60)
                    {
                        timeForStopwatch.SetS(0);
                        timeForStopwatch.SetM((byte)(timeForStopwatch.GetM() + 1));
                        if (timeForStopwatch.GetM() < 10)
                        {
                            timeForStopwatch.SetTimeInControl(stopwatchLable, 's', true);
                            timeForStopwatch.SetTimeInControl(stopwatchLable, 'm', true);
                        }
                        else
                        {
                            timeForStopwatch.SetTimeInControl(stopwatchLable, 's', true);
                            timeForStopwatch.SetTimeInControl(stopwatchLable, 'm');
                        }
                    }
                    if (timeForStopwatch.GetM() == 60)
                    {
                        timeForStopwatch.SetM(0);
                        timeForStopwatch.SetH((byte)(timeForStopwatch.GetH() + 1));
                        if (timeForStopwatch.GetH() < 10)
                        {
                            timeForStopwatch.SetTimeInControl(stopwatchLable, 'm', true);
                            timeForStopwatch.SetTimeInControl(stopwatchLable, 'h', true);
                        }
                        else
                        {
                            timeForStopwatch.SetTimeInControl(stopwatchLable, 'm', true);
                            timeForStopwatch.SetTimeInControl(stopwatchLable, 'h');
                        }
                    }
                }
            }
        }
        static public void StopwatchStop(Time timeForStopwatch, MaskedTextBox stopwatchLable)
        {
            timeForStopwatch.SetButtonStopDown(true);
            timeForStopwatch.SetWorking(true);
        }

        async static public void Timer(MaskedTextBox timerLable, Time timeForTimer)
        {
            
            if (timerLable.Text != "00:00:00")
            {
                timeForTimer.SetTimerStopClick(false);
                if (!timeForTimer.GetButtonStopDown())
                {
                    {
                        try
                        {
                            timeForTimer.SetH(Convert.ToByte(timerLable.Text.Substring(0, 2)));
                        }
                        catch
                        {
                            timerLable.Text = timerLable.Text.Insert(0, "00");
                        }
                        try
                        {
                            timeForTimer.SetM(Convert.ToByte(timerLable.Text.Substring(3, 2)));
                        }
                        catch
                        {
                            timerLable.Text = timerLable.Text.Insert(3, "00");
                        }
                        try
                        {
                            timeForTimer.SetS(Convert.ToByte(timerLable.Text.Substring(6, 2)));
                        }
                        catch
                        {
                            timerLable.Text = timerLable.Text.Insert(6, "00");
                        }
                    }
                    timerLable.Enabled = false;
                    while (true)
                    {
                        if (timeForTimer.GetSMHForEnd() == 0 && timeForTimer.GetTimerStopClick() == false)
                        {
                            DataBank.ShowMessage = true;
                            timeForTimer.SetButtonStopDown(false);
                            timerLable.Enabled = true;
                            return;
                        }
                        else if (timeForTimer.GetSMHForEnd() == 0 && timeForTimer.GetTimerStopClick() == true)
                        {
                            timeForTimer.SetTimerStopClick(false);
                            DataBank.ShowMessage = false;
                            timeForTimer.SetButtonStopDown(false);
                            timerLable.Enabled = true;
                            return;
                        }
                        await Task.Delay(1000);
                        if (timeForTimer.GetS() != 0)
                        {
                            timeForTimer.SetS((byte)(timeForTimer.GetS() - 1));
                            if (timeForTimer.GetS() > 9)
                            {
                                timeForTimer.SetTimeInControl(timerLable, 's');
                            }
                            else
                            {
                                timeForTimer.SetTimeInControl(timerLable, 's', true);
                            }
                        }
                        else if (timeForTimer.GetM() != 0)
                        {
                            timeForTimer.SetM((byte)(timeForTimer.GetM() - 1));
                            timeForTimer.SetS(59);
                            if (timeForTimer.GetM() > 9)
                            {
                                timeForTimer.SetTimeInControl(timerLable, 'm');
                                timeForTimer.SetTimeInControl(timerLable, 's');
                            }
                            else
                            {

                                timeForTimer.SetTimeInControl(timerLable, 'm', true);
                                timeForTimer.SetTimeInControl(timerLable, 's');
                            }   
                        }
                        else if (timeForTimer.GetH() != 0)
                        {
                            timeForTimer.SetH((byte)(timeForTimer.GetH() - 1));
                            timeForTimer.SetM(59);
                            timeForTimer.SetS(59);
                            if (timeForTimer.GetH() > 9)
                            {
                                timeForTimer.SetTimeInControl(timerLable, 'h');
                                timeForTimer.SetTimeInControl(timerLable, 'm');
                                timeForTimer.SetTimeInControl(timerLable, 's');
                            }
                            else
                            {
                                timeForTimer.SetTimeInControl(timerLable, 'h', true);
                                timeForTimer.SetTimeInControl(timerLable, 'm');
                                timeForTimer.SetTimeInControl(timerLable, 's');
                            }
                        }
                        timeForTimer.SetButtonStopDown(false);
                    }
                }
                else
                {
                    timeForTimer.SetButtonStopDown(false);
                    Time.Timer(timerLable, timeForTimer);
                }
            }
        }
        static public void TimerStop(Time timeForTimer,MaskedTextBox timerLable)
        {
            timeForTimer.SetSMH(0, 0, 0);
            timeForTimer.SetButtonStopDown(true);
            timerLable.Enabled = true;
            timerLable.Text = "000000";
            timeForTimer.SetTimerStopClick(true);
        }
    }
}

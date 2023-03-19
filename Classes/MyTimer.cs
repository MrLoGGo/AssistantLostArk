using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssistantLostArk
{
    internal class MyTimer : Time
    {
        private bool StopClick = false;

        public bool GetStopClick() { return StopClick; }

        public void SetStopClick(bool stop) { this.StopClick = stop; }

        async static public void Run(MaskedTextBox timerLable, MyTimer myTimer)
        {

            if (timerLable.Text != "00:00:00")
            {
                myTimer.SetStopClick(false);
                if (!myTimer.GetButtonStopDown())
                {
                    {
                        try
                        {
                            myTimer.SetH(Convert.ToByte(timerLable.Text.Substring(0, 2)));
                        }
                        catch
                        {
                            timerLable.Text = timerLable.Text.Insert(0, "00");
                        }
                        try
                        {
                            myTimer.SetM(Convert.ToByte(timerLable.Text.Substring(3, 2)));
                        }
                        catch
                        {
                            timerLable.Text = timerLable.Text.Insert(3, "00");
                        }
                        try
                        {
                            myTimer.SetS(Convert.ToByte(timerLable.Text.Substring(6, 2)));
                        }
                        catch
                        {
                            timerLable.Text = timerLable.Text.Insert(6, "00");
                        }
                    }
                    timerLable.Enabled = false;
                    while (true)
                    {
                        if (myTimer.GetSMHForEnd() == 0 && myTimer.GetStopClick() == false)
                        {
                            DataBank.ShowMessage = true;
                            myTimer.SetButtonStopDown(false);
                            timerLable.Enabled = true;
                            return;
                        }
                        else if (myTimer.GetSMHForEnd() == 0 && myTimer.GetStopClick() == true)
                        {
                            myTimer.SetStopClick(false);
                            DataBank.ShowMessage = false;
                            myTimer.SetButtonStopDown(false);
                            timerLable.Enabled = true;
                            return;
                        }
                        await Task.Delay(1000);
                        if (myTimer.GetS() != 0)
                        {
                            myTimer.SetS((byte)(myTimer.GetS() - 1));
                            if (myTimer.GetS() > 9)
                            {
                                myTimer.SetTimeInControl(timerLable, 's');
                            }
                            else
                            {
                                myTimer.SetTimeInControl(timerLable, 's', true);
                            }
                        }
                        else if (myTimer.GetM() != 0)
                        {
                            myTimer.SetM((byte)(myTimer.GetM() - 1));
                            myTimer.SetS(59);
                            if (myTimer.GetM() > 9)
                            {
                                myTimer.SetTimeInControl(timerLable, 'm');
                                myTimer.SetTimeInControl(timerLable, 's');
                            }
                            else
                            {

                                myTimer.SetTimeInControl(timerLable, 'm', true);
                                myTimer.SetTimeInControl(timerLable, 's');
                            }
                        }
                        else if (myTimer.GetH() != 0)
                        {
                            myTimer.SetH((byte)(myTimer.GetH() - 1));
                            myTimer.SetM(59);
                            myTimer.SetS(59);
                            if (myTimer.GetH() > 9)
                            {
                                myTimer.SetTimeInControl(timerLable, 'h');
                                myTimer.SetTimeInControl(timerLable, 'm');
                                myTimer.SetTimeInControl(timerLable, 's');
                            }
                            else
                            {
                                myTimer.SetTimeInControl(timerLable, 'h', true);
                                myTimer.SetTimeInControl(timerLable, 'm');
                                myTimer.SetTimeInControl(timerLable, 's');
                            }
                        }
                        myTimer.SetButtonStopDown(false);
                    }
                }
                else
                {
                    myTimer.SetButtonStopDown(false);
                    MyTimer.Run(timerLable, myTimer);
                }
            }
        }
        static public void Stop(MyTimer myTimer, MaskedTextBox timerLable)
        {
            myTimer.SetSMH(0, 0, 0);
            myTimer.SetButtonStopDown(true);
            timerLable.Enabled = true;
            timerLable.Text = "000000";
            myTimer.SetStopClick(true);
        }
    }
}

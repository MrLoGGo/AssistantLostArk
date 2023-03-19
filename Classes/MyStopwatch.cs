using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssistantLostArk
{
    internal class MyStopwatch : Time
    {
        private bool working = true;

        public bool GetWorking() { return working; }

        public void SetWorking(bool working) { this.working = working; }

        async static public void Run(MaskedTextBox stopwatchLable, MyStopwatch myStopwatch)
        {
            if (myStopwatch.GetWorking())
            {

                myStopwatch.SetWorking(false);
                myStopwatch.SetButtonStopDown(false);
                stopwatchLable.Text = "00:00:00";
                myStopwatch.SetSMH(0, 0, 0);

                while (true)
                {
                    if (myStopwatch.GetButtonStopDown())
                    {
                        myStopwatch.SetS((byte)(myStopwatch.GetS() - 1));
                        if (myStopwatch.GetS() < 10)
                        {
                            myStopwatch.SetTimeInControl(stopwatchLable, 's', true);
                        }
                        else
                        {
                            myStopwatch.SetTimeInControl(stopwatchLable, 's');
                        }
                        myStopwatch.SetButtonStopDown(false);
                        return;
                    }
                    await Task.Delay(1000);

                    myStopwatch.SetS((byte)(myStopwatch.GetS() + 1));

                    if (myStopwatch.GetS() < 10)
                    {
                        myStopwatch.SetTimeInControl(stopwatchLable, 's', true);
                    }
                    else
                    {
                        myStopwatch.SetTimeInControl(stopwatchLable, 's');
                    }

                    if (myStopwatch.GetS() == 60)
                    {
                        myStopwatch.SetS(0);
                        myStopwatch.SetM((byte)(myStopwatch.GetM() + 1));
                        if (myStopwatch.GetM() < 10)
                        {
                            myStopwatch.SetTimeInControl(stopwatchLable, 's', true);
                            myStopwatch.SetTimeInControl(stopwatchLable, 'm', true);
                        }
                        else
                        {
                            myStopwatch.SetTimeInControl(stopwatchLable, 's', true);
                            myStopwatch.SetTimeInControl(stopwatchLable, 'm');
                        }
                    }
                    if (myStopwatch.GetM() == 60)
                    {
                        myStopwatch.SetM(0);
                        myStopwatch.SetH((byte)(myStopwatch.GetH() + 1));
                        if (myStopwatch.GetH() < 10)
                        {
                            myStopwatch.SetTimeInControl(stopwatchLable, 'm', true);
                            myStopwatch.SetTimeInControl(stopwatchLable, 'h', true);
                        }
                        else
                        {
                            myStopwatch.SetTimeInControl(stopwatchLable, 'm', true);
                            myStopwatch.SetTimeInControl(stopwatchLable, 'h');
                        }
                    }
                }
            }
        }
        static public void Stop(MyStopwatch myStopwatch)
        {
            myStopwatch.SetButtonStopDown(true);
            myStopwatch.SetWorking(true);
        }
    }
}

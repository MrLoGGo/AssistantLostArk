using AssistantLostArk.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AssistantLostArk
{
    public partial class MainForm : Form
    {
        /*ToolStrip toolStrip2 = new ToolStrip();
        ToolStripButton toolStripButton5 = new ToolStripButton();
        ToolStripButton toolStripButton6 = new ToolStripButton();
        MaskedTextBox timeLable = new MaskedTextBox();*/
        Time timeForStopwatch = new Time();
        Time timeForTimer = new Time();
        string page;
        string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "..\\..\\Resources\\EfonUnion.txt");
        byte countAlarmControlInMainAlarmPanel = 0, XAlarmControlInMainAlarmPanel = (359 - 314) / 2;

        Page mainMenuPage = new Page();
        Page mainPage = new Page();
        Page timerPage = new Page();
        Page stopwatchPage = new Page();
        Page alarmPage = new Page();
        Page efonUnionPage = new Page();
        Page argosPage = new Page();


        public MainForm()
        {
            InitializeComponent();

            this.Activate();

            mainMenuPage.SetPanel(ref panelMenu, "menu");
            mainPage.SetPanel(ref panelMain, "main");
            timerPage.SetPanel(ref panelTimerAndStopwatch, "timer");
            stopwatchPage.SetPanel(ref panelTimerAndStopwatch, "stopwatch");
            alarmPage.SetPanel(ref panelAlarm, "alarm");
            efonUnionPage.SetPanel(ref panelEfonUnion, "efonUnion");
            argosPage.SetPanel(ref panelArgos, "argos");

            ShowPage(mainMenuPage);

            SetStyle(ControlStyles.OptimizedDoubleBuffer |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.UserPaint, true);

            panelButtons.BackColor = System.Drawing.Color.Transparent;

            UpdateStyles();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            buttonOpenGameCenter.BackgroundImage = Properties.Resources.buttonDown;
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            buttonOpenGameCenter.BackgroundImage = Properties.Resources.buttonUp;
        }

        private void buttonOpenGameCenter_Click(object sender, EventArgs e)
        {
            Process.Start("C:\\Users\\logo1\\AppData\\Local\\GameCenter\\GameCenter.exe");
        }

        private void toolStripButtonGo_Click(object sender, EventArgs e)
        {
            switch (page)
            {
                case "stopwatch":
                    stopwatch();
                    break;
                case "timer":
                    timer();
                    break;
            }
        }
        private void toolStripButtonStop_Click(object sender, EventArgs e)
        {
            switch (page)
            {
                case "stopwatch":
                    stopwatchStop();
                    break;
                case "timer":
                    timerStop();
                    break;
            }
        }

        public void stopwatch()
        {
            Time.Stopwatch(stopwatchLable, timeForStopwatch);

        }
        public void stopwatchStop()
        {
            Time.StopwatchStop(timeForStopwatch, stopwatchLable);
        }

        async public void timer()
        {
            Time.Timer(timerLable, timeForTimer);
            while(true)
            {
                await Task.Delay(100);
                if(DataBank.ShowMessage && timeForTimer.GetSMHForEnd() == (byte)0)
                {
                    ShowMessage("alarm");
                    DataBank.ShowMessage = false;
                    break;
                }
                else if(timeForTimer.GetSMHForEnd() == (byte)0)
                {
                    break;
                }
            }
        }
        public void timerStop()
        {
            Time.TimerStop(timeForTimer, timerLable);
        }

        private void label1_Click(object sender, EventArgs e)
        {
        
            TestForm testForm = new TestForm();
            testForm.Show();

        }

        async private void buttonAdd_Click(object sender, EventArgs e)
        {
            ShowMessage("add");
            while (true)
            {
                await Task.Delay(100);
                if (DataBank.MessageFormClose == true)
                {
                    mainAlarmPanel.Controls.Add(new AlarmControl { TimeText = DataBank.Time });
                    mainAlarmPanel.Controls[countAlarmControlInMainAlarmPanel].Location = new Point(
                        XAlarmControlInMainAlarmPanel, 
                        mainAlarmPanel.Controls[countAlarmControlInMainAlarmPanel].Location.Y);
                    countAlarmControlInMainAlarmPanel++;
                    DataBank.MessageFormClose = false; 
                    break;
                }
            }
        }
        private void buttonMain_Click(object sender, EventArgs e)
        {

            ShowPage(mainPage);
        }
        private void buttonTimer_Click(object sender, EventArgs e)
        {
            ShowPage(timerPage);
            this.Text = "Timer";
            timerLable.Visible = true;
            stopwatchLable.Visible = false;
        }
        private void buttonStopwatch_Click(object sender, EventArgs e)
        {
            ShowPage(stopwatchPage);
            timerLable.Visible = false;
            stopwatchLable.Visible = true;
        }
        private void buttonAlarm_Click(object sender, EventArgs e)
        {
            ShowPage(alarmPage);
        }
        private void buttonEfonUnion_Click(object sender, EventArgs e)
        {

            ShowPage(efonUnionPage);

            this.BackgroundImage = Properties.Resources.EfonUnionBackgrount;
            textBoxEfonUnion.ScrollBars = ScrollBars.Both;

            using (StreamReader stream = new StreamReader(path))
            {
                textBoxEfonUnion.Text = stream.ReadToEnd();
            }
            /*using (StreamReader stream = new StreamReader(Resources.EfonUnion))
            {
                textBoxEfonUnion.Text = stream.ReadToEnd();
            }*/
            buttonSave.Select();
            /*this.Hide();
            EfonUnionForm efonUnionForm = new EfonUnionForm();
            efonUnionForm.StartPosition= FormStartPosition.Manual;
            efonUnionForm.Location = this.Location; 
            efonUnionForm.Show();*/
        }
        private void buttonArgos_Click(object sender, EventArgs e)
        {
            ShowPage(argosPage);
        }

        private void buttonMenu_Click(object sender, EventArgs e)
        {
            ShowPage(mainMenuPage);
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            using (StreamWriter stream = new StreamWriter(path))
            {
                stream.Write(textBoxEfonUnion.Text);
            }
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                ShowPage(mainMenuPage);
            }
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            List<int> indexesToRemove = new List<int>();
            foreach (AlarmControl ac in mainAlarmPanel.Controls)
            {
                if (ac.Checked)
                {
                    indexesToRemove.Add(mainAlarmPanel.Controls.IndexOf(ac));
                    countAlarmControlInMainAlarmPanel--;
                }
            }
            for(int i = 0; i < indexesToRemove.Count; i++)
            {
                mainAlarmPanel.Controls.RemoveAt(indexesToRemove[i]-i);
            }
        }

        private void textBoxEfonUnion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S && e.Control)
            {
                buttonSave.PerformClick();
            }
        }

        private void ShowPage(Page page)
        {
            this.page = page.ShowPanel();
            buttonMenu.BringToFront();
        }

        private void alarmControl1_Click(object sender, EventArgs e)
        {
        }

        public void ShowMessage(string page)
        {
            DataBank.Page = page;
            MessageForm message = new MessageForm();
            message.Show();
            message.StartPosition = FormStartPosition.CenterScreen;
            message.Location = new Point(this.Location.X + (this.Width - message.Width) / 2, (this.Location.Y + (this.Height - message.Height) / 2));
        }
    }
}

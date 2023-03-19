using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssistantLostArk
{
    public partial class MainForm : Form
    {
        MyStopwatch myStopwatch = new MyStopwatch();
        MyTimer myTimer = new MyTimer();
        string page;
        string path = CreateRef.CreateFile("EfonUnion.txt");
        byte XAlarmControlInMainAlarmPanel = (359 - 314) / 2;

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
            try{
                Process.Start("C:\\Users\\logo1\\AppData\\Local\\GameCenter\\GameCenter.exe");
            }catch
            {
                MessageBox.Show("У вас нет GameCenter, установите его и попробуйте еще раз.","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            MyStopwatch.Run(stopwatchLable, myStopwatch);
            
        }
        public void stopwatchStop()
        {
            MyStopwatch.Stop(myStopwatch);
        }

        async public void timer()
        {
            MyTimer.Run(timerLable, myTimer);
            while(true)
            {
                await Task.Delay(100);
                if(DataBank.ShowMessage && myTimer.GetSMHForEnd() == (byte)0)
                {
                    ShowMessage("alarm");
                    DataBank.ShowMessage = false;
                    break;
                }
                else if(myTimer.GetSMHForEnd() == (byte)0)
                {
                    break;
                }
            }
        }
        public void timerStop()
        {
            MyTimer.Stop(myTimer, timerLable);
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
                    mainAlarmPanel.Controls[DataBank.CountTimers].Location = new Point(
                        XAlarmControlInMainAlarmPanel, 
                        mainAlarmPanel.Controls[DataBank.CountTimers].Location.Y);
                    DataBank.CountTimers++;
                    AlarmForm alarmForm = new AlarmForm();
                    alarmForm.Show();
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
            textBoxEfonUnion.ScrollBars = ScrollBars.Both;

            using (StreamReader stream = new StreamReader(path))
            {
                textBoxEfonUnion.Text = stream.ReadToEnd();
            }

            buttonSave.Select();
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
                    DataBank.CountTimers--;
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssistantLostArk
{
    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        int s,m,h;
        bool buttonDown = true;

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            
        }/*
        public static void saveMainForm(MainForm main)
        {

        }*/
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            timerLable.Location = new Point(0,this.Height-timerLable.Height/2);
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
        }


        private void TimerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void Cmd(string str)
        {
            Process.Start(new ProcessStartInfo
            {
                FileName = "cmd",
                Arguments = $"/c {str}",
                UseShellExecute= false,
                CreateNoWindow= true
            });

        }
    }
}

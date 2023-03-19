using System;
using System.IO;
using System.IO.Compression;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssistantLostArk
{
    public partial class MessageForm : Form
    {

        Page addPage = new Page();
        Page alarmPage = new Page();
        public MessageForm()
        {
            InitializeComponent();
            addPage.SetPanel(ref panelAdd, "add");
            alarmPage.SetPanel(ref panelAlarm, "alarm");
            if (DataBank.Page == "add")
            {
                this.Text = "Добавить";
                addPage.SetPanel(ref panelAdd, "add");
                addPage.ShowPanel();
            }
            else if (DataBank.Page == "alarm")
            {
                this.Text = "Будильник";
                using (MemoryStream fileOut = new MemoryStream(Properties.Resources.Alarm))
                {
                    using (GZipStream gz = new GZipStream(fileOut, CompressionMode.Decompress))
                    {
                        new SoundPlayer(gz).Play();
                    }
                }
                alarmPage.SetPanel(ref panelAlarm, "alarm");
                alarmPage.ShowPanel();
            }
        }

        async private void AlarmWhile()
        {
            while (true)
            {
                await Task.Delay(10);
                using(MemoryStream fileOut = new MemoryStream(Properties.Resources.Alarm))
                {
                    using(GZipStream gz = new GZipStream(fileOut, CompressionMode.Decompress)) { 
                        new SoundPlayer(gz).Play();
                    }
                }
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
        }

        private void buttonAlarm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void alarmControlAdd1_Load(object sender, EventArgs e)
        {

        }

        private void MessageForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DataBank.MessageFormClose = true;
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataBank.Time = TimeBox.Text;

            this.Close();
        }
    }
}

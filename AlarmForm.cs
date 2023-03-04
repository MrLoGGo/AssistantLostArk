using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssistantLostArk
{
    public partial class AlarmForm : Form
    {
        List<Time> timers = new List<Time>();
        public AlarmForm()
        {
            InitializeComponent();
        }

        private void AlarmForm_Load(object sender, EventArgs e)
        {
            timers.Add(new Time());

        }
    }
}

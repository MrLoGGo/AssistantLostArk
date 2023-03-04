using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssistantLostArk
{
    internal class Page
    {
        private Panel panel;
        private string pagename;

        public void SetPanel(ref Panel panel, string page)
        {
            this.panel = panel;
            this.pagename = page;
        }

        public string ShowPanel()
        {
            panel.Dock = DockStyle.Fill;
            panel.BringToFront();
            return pagename;
        }
        public void PanelHide()
        {
            panel.Dock = DockStyle.None;
            panel.Size = new Size(0, 0);
        }
    }
}

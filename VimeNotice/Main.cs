using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VimeNotice.Properties;

namespace VimeNotice
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void настройкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings A = new Settings();
            A.ShowDialog();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About B = new About();
            B.ShowDialog();
        }

        private void добавитьИгрокаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddGuild C = new AddGuild();
            C.ShowDialog();
        }

        private void добавитьAPIKeyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            APIKey D = new APIKey();
            D.ShowDialog();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
        
        private void TrayNotify()
        {
            notifyIcon1.Icon = SystemIcons.Exclamation;
            notifyIcon1.BalloonTipTitle = "Balloon Tip Title";
            notifyIcon1.BalloonTipText = "Balloon Tip Text.";
            notifyIcon1.BalloonTipIcon = ToolTipIcon.Error;
            this.Click += new EventHandler(StartNotify);
        }

        private void StartNotify(object sender, EventArgs e)
        {
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(30);
        }
    }
}

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
            this.Show();
            WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            notifyIcon1.BalloonTipTitle = "VimeNotice";
            notifyIcon1.BalloonTipText = "Приложение продолжает работать";
            notifyIcon1.Text = "VimeNotice";
            if (Properties.Settings.Default.AutoStartInTray == true)
            {
                this.Hide();
                notifyIcon1.Visible = true;
            }
        }

        private void Main_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(1000);
            }
            else if (FormWindowState.Normal == this.WindowState)
              {  notifyIcon1.Visible = false; }

        }

        private void notifyIcon1_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            this.Show();
            WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
            WindowState = FormWindowState.Normal;
            notifyIcon1.Visible = false;
        }

        private void настройкиToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Settings A = new Settings();
            A.ShowDialog();
        }

        private void закрытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

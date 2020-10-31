using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VimeNotice.Properties;

namespace VimeNotice
{
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
            if (Properties.Settings.Default.AutoStart == true)
            {
                AutoStart.Checked = true;
            };
            if (Properties.Settings.Default.AutoStartInTray == true)
            {
             AutoStartInTray.Checked = true;
            };
            if (Properties.Settings.Default.DeleteTempFiles == true) 
            {
                DeleteTempFiles.Checked = true;
            };
            if (Properties.Settings.Default.NotifyEnabled == true) 
            {
                EnableNotify.Checked = true;
            };
            if (Properties.Settings.Default.NotifyOnDesktop == true) 
            {
                NotifyOnDesktop.Checked = true;
            };
            if (Properties.Settings.Default.PlayerAdded == true) 
            {
                PlayerAdded.Checked = true;
            };
            if (Properties.Settings.Default.PlayerKicked == true) 
            {
                PlayerKicked.Checked = true;
            };
            if (Properties.Settings.Default.LevelUp == true) 
            {
                LevelUp.Checked = true;
            };
            if (Properties.Settings.Default.PerkUpgraded == true) 
            {
                PerkUpgraded.Checked = true;
            };
            if (Properties.Settings.Default.OfficerAdded == true) 
            {
                OfficerAdded.Checked = true;
            };
            if (Properties.Settings.Default.OfficerRemoved == true) 
            {
                OfficerRemoved.Checked = true;
            };
            if (Properties.Settings.Default.CoinsAdd == true) 
            {
                CoinsAdd.Checked = true;
            };
            if (Properties.Settings.Default.PlayerLeaved == true) 
            {
                PlayerLeaved.Checked = true;
            };
            if (EnableNotify.Checked == false)
            {
                NotifyOnDesktop.Enabled = false;
                OfficerRemoved.Enabled = false;
                OfficerAdded.Enabled = false;
                CoinsAdd.Enabled = false;
                PlayerAdded.Enabled = false;
                PlayerLeaved.Enabled = false;
                PlayerKicked.Enabled = false;
                LevelUp.Enabled = false;
                PerkUpgraded.Enabled = false;
            }
            if (EnableNotify.Checked == true)
            {
                OfficerRemoved.Enabled = true;
                OfficerAdded.Enabled = true;
                CoinsAdd.Enabled = true;
                PlayerAdded.Enabled = true;
                PlayerLeaved.Enabled = true;
                PlayerKicked.Enabled = true;
                LevelUp.Enabled = true;
                PerkUpgraded.Enabled = true;
            }
                if (AutoStart.Checked == true)
                {
                    AutoStartInTray.Enabled = true;
                }
                if (AutoStart.Checked == false)
                {
                    AutoStartInTray.Enabled = false;
                }
            }
        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (EnableNotify.Checked == false)
            {
                NotifyOnDesktop.Enabled = false;
                OfficerRemoved.Enabled = false;
                OfficerAdded.Enabled = false;
                CoinsAdd.Enabled = false;
                PlayerAdded.Enabled = false;
                PlayerLeaved.Enabled = false;
                PlayerKicked.Enabled = false;
                LevelUp.Enabled = false;
                PerkUpgraded.Enabled = false;
            }
            if (EnableNotify.Checked == true)
            {
                OfficerRemoved.Enabled = true;
                OfficerAdded.Enabled = true;
                CoinsAdd.Enabled = true;
                PlayerAdded.Enabled = true;
                PlayerLeaved.Enabled = true;
                PlayerKicked.Enabled = true;
                LevelUp.Enabled = true;
                PerkUpgraded.Enabled = true;
            }
            if (EnableNotify.Checked == true) 
            {
                Properties.Settings.Default.NotifyEnabled = true;
                Properties.Settings.Default.Save();
            };
            if (EnableNotify.Checked == false)
            {
                Properties.Settings.Default.NotifyEnabled = false;
                Properties.Settings.Default.Save();
            }
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
                if (AutoStart.Checked == true)
                {
                AutoStartInTray.Enabled = true;
                }
                if (AutoStart.Checked == false)
                {
                AutoStartInTray.Enabled = false;
                }
            if (AutoStart.Checked == true)
            {
                Properties.Settings.Default.AutoStart = true;
                Properties.Settings.Default.Save();
                var key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run\", true);
                key.SetValue("VimeNotice", Application.ExecutablePath);
            };
                if (AutoStart.Checked == false)
            {
                Properties.Settings.Default.AutoStart = false;
                Properties.Settings.Default.Save();
                var key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Run\", true);
                key.DeleteValue("VimeNotice");
            }
        }
       

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (AutoStartInTray.Checked == true) 
                {
                    Properties.Settings.Default.AutoStartInTray = true;
                    Properties.Settings.Default.Save();
                };
                if (AutoStartInTray.Checked == false)
                {
                    Properties.Settings.Default.AutoStartInTray = false;
                    Properties.Settings.Default.Save();
                }
            }
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (DeleteTempFiles.Checked == true) 
                {
                    Properties.Settings.Default.DeleteTempFiles = true;
                    Properties.Settings.Default.Save();
                };
                if (DeleteTempFiles.Checked == false)
                {
                    Properties.Settings.Default.DeleteTempFiles = false;
                    Properties.Settings.Default.Save();
                }
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (NotifyOnDesktop.Checked == true) 
                {
                    Properties.Settings.Default.NotifyOnDesktop = true;
                    Properties.Settings.Default.Save();
                };
                if (NotifyOnDesktop.Checked == false)
                {
                    Properties.Settings.Default.NotifyOnDesktop = false;
                    Properties.Settings.Default.Save();
                }
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (PlayerAdded.Checked == true) 
                {
                    Properties.Settings.Default.PlayerAdded = true;
                    Properties.Settings.Default.Save();
                };
                if (PlayerAdded.Checked == false)
                {
                    Properties.Settings.Default.PlayerAdded = false;
                    Properties.Settings.Default.Save();
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (PlayerKicked.Checked == true) 
                {
                    Properties.Settings.Default.PlayerKicked = true;
                    Properties.Settings.Default.Save();
                };
                if (PlayerKicked.Checked == false)
                {
                    Properties.Settings.Default.PlayerKicked = false;
                    Properties.Settings.Default.Save();
                }
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (LevelUp.Checked == true) 
                {
                    Properties.Settings.Default.LevelUp = true;
                    Properties.Settings.Default.Save();
                };
                if (LevelUp.Checked == false)
                {
                    Properties.Settings.Default.LevelUp = false;
                    Properties.Settings.Default.Save();
                }
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (PerkUpgraded.Checked == true) 
                {
                    Properties.Settings.Default.PerkUpgraded = true;
                    Properties.Settings.Default.Save();
                };
                if (PerkUpgraded.Checked == false)
                {
                    Properties.Settings.Default.PerkUpgraded = false;
                    Properties.Settings.Default.Save();
                }
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (OfficerAdded.Checked == true) 
                {
                    Properties.Settings.Default.OfficerAdded = true;
                    Properties.Settings.Default.Save();
                };
                if (OfficerAdded.Checked == false)
                {
                    Properties.Settings.Default.OfficerAdded = false;
                    Properties.Settings.Default.Save();
                }
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (OfficerRemoved.Checked == true) 
                {
                    Properties.Settings.Default.OfficerRemoved = true;
                    Properties.Settings.Default.Save();
                };
                if (OfficerRemoved.Checked == false)
                {
                    Properties.Settings.Default.OfficerRemoved = false;
                    Properties.Settings.Default.Save();
                }
            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (CoinsAdd.Checked == true) 
                {
                    Properties.Settings.Default.CoinsAdd = true;
                    Properties.Settings.Default.Save();
                };
                if (CoinsAdd.Checked == false)
                {
                    Properties.Settings.Default.CoinsAdd = false;
                    Properties.Settings.Default.Save();
                }
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            {
                if (PlayerLeaved.Checked == true) 
                {
                    Properties.Settings.Default.PlayerLeaved = true;
                    Properties.Settings.Default.Save();
                };
                if (PlayerLeaved.Checked == false)
                {
                    Properties.Settings.Default.PlayerLeaved = false;
                    Properties.Settings.Default.Save();
                }
            }
        }

        void button1_Click(object sender, EventArgs e)
        {
            notifyIcon1.ShowBalloonTip(
              10000,
              "Новый ответ",
              "Поступил новый ответ на ваш вопрос на Toster.ru",
              ToolTipIcon.Info
            );
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }
    }
}

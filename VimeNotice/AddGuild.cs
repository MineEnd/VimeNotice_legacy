using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using VimeNotice.Properties;
using System.Security.Principal;

namespace VimeNotice
{
    public partial class AddGuild : Form
    {
        string Token = VimeNotice.Properties.Settings.Default.APIKey;
        public AddGuild()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                WebClient web = new WebClient();
                web.Proxy = new WebProxy();
                var reply = web.DownloadString("https://api.vimeworld.ru/guild/get?tag=" + textBox1.Text.ToString() + "&token=".ToString() +Token.ToString());
                if (reply.Contains("error"))
                {
                    label6.ForeColor = Color.Red;
                    label6.Text ="Гильдия не найдена.";
                } 
                else { 
                
                    label6.ForeColor = Color.Green;
                    label6.Text = "Гильдия была добавлена.";
                }
            }
            if (radioButton2.Checked)
            {
                WebClient web = new WebClient();
                web.Proxy = new WebProxy();
                var reply = web.DownloadString("https://api.vimeworld.ru/guild/get?name=" + textBox1.Text.ToString() + "&token=".ToString() + Token.ToString());
                if (reply.Contains("error"))
                {
                    label6.ForeColor = Color.Red;
                    label6.Text = "Гильдия не найдена.";
                }
                else
                {

                    label6.ForeColor = Color.Green;
                    label6.Text = "Гильдия была добавлена.";
                }
            }
            if (radioButton1.Checked)
            {
                WebClient web = new WebClient();
                web.Proxy = new WebProxy();
                var reply = web.DownloadString("https://api.vimeworld.ru/guild/get?id=" + textBox1.Text.ToString() + "&token=".ToString() + Token.ToString());
                if (reply.Contains("error"))
                {
                     label6.ForeColor = Color.Red;
                     label6.Text = "Гильдия не найдена.";
                }
                  else
                  {
                     label6.ForeColor = Color.Green;
                     label6.Text = "Гильдия была добавлена.";
                  }
                }
            
        }
    }
}

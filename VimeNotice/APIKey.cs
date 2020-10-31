using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VimeNotice.Properties;

namespace VimeNotice
{
    public partial class APIKey : Form
    {
        public APIKey()
        {
            InitializeComponent();
            textBox1.Text = Properties.Settings.Default.APIKey;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Token = VimeNotice.Properties.Settings.Default.APIKey;
            WebClient web = new WebClient();
            web.Proxy = new WebProxy();
            var reply = web.DownloadString("https://api.vimeworld.ru/online?token=" + Token.ToString());
            if (textBox1.Text = "clear")
            {
                Properties.Settings.Default.APIKey = null;
            }
            if (reply.Contains("error"))
            {
                Properties.Settings.Default.APIKey = textBox1.Text;
                label4.ForeColor = Color.Red;
                label4.Text = "Токен неккоректен и не был сохранён.";
            } else
            {
                Properties.Settings.Default.APIKey = textBox1.Text;
                Properties.Settings.Default.Save();
                label4.ForeColor = Color.Green;
                label4.Text = "Токен сохранён.";
            }
        }
    }
}

namespace VimeNotice
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DeleteTempFiles = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AutoStartInTray = new System.Windows.Forms.CheckBox();
            this.AutoStart = new System.Windows.Forms.CheckBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.PlayerLeaved = new System.Windows.Forms.CheckBox();
            this.CoinsAdd = new System.Windows.Forms.CheckBox();
            this.OfficerRemoved = new System.Windows.Forms.CheckBox();
            this.LevelUp = new System.Windows.Forms.CheckBox();
            this.PerkUpgraded = new System.Windows.Forms.CheckBox();
            this.OfficerAdded = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.EnableNotify = new System.Windows.Forms.CheckBox();
            this.NotifyOnDesktop = new System.Windows.Forms.CheckBox();
            this.PlayerAdded = new System.Windows.Forms.CheckBox();
            this.PlayerKicked = new System.Windows.Forms.CheckBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.helpProvider1 = new System.Windows.Forms.HelpProvider();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(492, 225);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.DeleteTempFiles);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.AutoStartInTray);
            this.tabPage1.Controls.Add(this.AutoStart);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(484, 199);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Основные";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // DeleteTempFiles
            // 
            this.DeleteTempFiles.AutoSize = true;
            this.DeleteTempFiles.Enabled = false;
            this.DeleteTempFiles.Location = new System.Drawing.Point(11, 107);
            this.DeleteTempFiles.Name = "DeleteTempFiles";
            this.DeleteTempFiles.Size = new System.Drawing.Size(252, 17);
            this.DeleteTempFiles.TabIndex = 2;
            this.DeleteTempFiles.Text = "Удалять ненужные файлы программы (WIP)";
            this.toolTip1.SetToolTip(this.DeleteTempFiles, "Удаление логов запросов к серверу, удаляется каждые 7 дней.");
            this.DeleteTempFiles.UseVisualStyleBackColor = true;
            this.DeleteTempFiles.CheckedChanged += new System.EventHandler(this.checkBox13_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Автозапуск";
            // 
            // AutoStartInTray
            // 
            this.AutoStartInTray.AutoSize = true;
            this.AutoStartInTray.Location = new System.Drawing.Point(11, 55);
            this.AutoStartInTray.Name = "AutoStartInTray";
            this.AutoStartInTray.Size = new System.Drawing.Size(120, 17);
            this.AutoStartInTray.TabIndex = 3;
            this.AutoStartInTray.Text = "Автозапуск в трее";
            this.AutoStartInTray.UseVisualStyleBackColor = true;
            this.AutoStartInTray.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // AutoStart
            // 
            this.AutoStart.AutoSize = true;
            this.AutoStart.Location = new System.Drawing.Point(11, 32);
            this.AutoStart.Name = "AutoStart";
            this.AutoStart.Size = new System.Drawing.Size(136, 17);
            this.AutoStart.TabIndex = 1;
            this.AutoStart.Text = "Включить автозапуск";
            this.AutoStart.UseVisualStyleBackColor = true;
            this.AutoStart.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.PlayerLeaved);
            this.tabPage2.Controls.Add(this.CoinsAdd);
            this.tabPage2.Controls.Add(this.OfficerRemoved);
            this.tabPage2.Controls.Add(this.LevelUp);
            this.tabPage2.Controls.Add(this.PerkUpgraded);
            this.tabPage2.Controls.Add(this.OfficerAdded);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.EnableNotify);
            this.tabPage2.Controls.Add(this.NotifyOnDesktop);
            this.tabPage2.Controls.Add(this.PlayerAdded);
            this.tabPage2.Controls.Add(this.PlayerKicked);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(484, 199);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Уведомления";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // PlayerLeaved
            // 
            this.PlayerLeaved.AutoSize = true;
            this.PlayerLeaved.Location = new System.Drawing.Point(210, 160);
            this.PlayerLeaved.Name = "PlayerLeaved";
            this.PlayerLeaved.Size = new System.Drawing.Size(161, 17);
            this.PlayerLeaved.TabIndex = 10;
            this.PlayerLeaved.Text = "Выход игроков из гильдии";
            this.PlayerLeaved.UseVisualStyleBackColor = true;
            this.PlayerLeaved.CheckedChanged += new System.EventHandler(this.checkBox12_CheckedChanged);
            // 
            // CoinsAdd
            // 
            this.CoinsAdd.AutoSize = true;
            this.CoinsAdd.Location = new System.Drawing.Point(210, 137);
            this.CoinsAdd.Name = "CoinsAdd";
            this.CoinsAdd.Size = new System.Drawing.Size(125, 17);
            this.CoinsAdd.TabIndex = 9;
            this.CoinsAdd.Text = "Зачисление койнов";
            this.CoinsAdd.UseVisualStyleBackColor = true;
            this.CoinsAdd.CheckedChanged += new System.EventHandler(this.checkBox11_CheckedChanged);
            // 
            // OfficerRemoved
            // 
            this.OfficerRemoved.AutoSize = true;
            this.OfficerRemoved.Location = new System.Drawing.Point(210, 114);
            this.OfficerRemoved.Name = "OfficerRemoved";
            this.OfficerRemoved.Size = new System.Drawing.Size(137, 17);
            this.OfficerRemoved.TabIndex = 8;
            this.OfficerRemoved.Text = "Удаление оффицеров";
            this.OfficerRemoved.UseVisualStyleBackColor = true;
            this.OfficerRemoved.CheckedChanged += new System.EventHandler(this.checkBox10_CheckedChanged);
            // 
            // LevelUp
            // 
            this.LevelUp.AutoSize = true;
            this.LevelUp.Location = new System.Drawing.Point(11, 137);
            this.LevelUp.Name = "LevelUp";
            this.LevelUp.Size = new System.Drawing.Size(124, 17);
            this.LevelUp.TabIndex = 7;
            this.LevelUp.Text = "Повышение уровня";
            this.LevelUp.UseVisualStyleBackColor = true;
            this.LevelUp.CheckedChanged += new System.EventHandler(this.checkBox9_CheckedChanged);
            // 
            // PerkUpgraded
            // 
            this.PerkUpgraded.AutoSize = true;
            this.PerkUpgraded.Location = new System.Drawing.Point(11, 160);
            this.PerkUpgraded.Name = "PerkUpgraded";
            this.PerkUpgraded.Size = new System.Drawing.Size(121, 17);
            this.PerkUpgraded.TabIndex = 6;
            this.PerkUpgraded.Text = "Улучшение перков";
            this.PerkUpgraded.UseVisualStyleBackColor = true;
            this.PerkUpgraded.CheckedChanged += new System.EventHandler(this.checkBox8_CheckedChanged);
            // 
            // OfficerAdded
            // 
            this.OfficerAdded.AutoSize = true;
            this.OfficerAdded.Location = new System.Drawing.Point(210, 91);
            this.OfficerAdded.Name = "OfficerAdded";
            this.OfficerAdded.Size = new System.Drawing.Size(150, 17);
            this.OfficerAdded.TabIndex = 5;
            this.OfficerAdded.Text = "Добавление оффицеров";
            this.OfficerAdded.UseVisualStyleBackColor = true;
            this.OfficerAdded.CheckedChanged += new System.EventHandler(this.checkBox7_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Виды уведомлений";
            // 
            // EnableNotify
            // 
            this.EnableNotify.AutoSize = true;
            this.EnableNotify.Location = new System.Drawing.Point(11, 16);
            this.EnableNotify.Name = "EnableNotify";
            this.EnableNotify.Size = new System.Drawing.Size(145, 17);
            this.EnableNotify.TabIndex = 3;
            this.EnableNotify.Text = "Включить уведомления";
            this.EnableNotify.UseVisualStyleBackColor = true;
            this.EnableNotify.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // NotifyOnDesktop
            // 
            this.NotifyOnDesktop.AutoSize = true;
            this.NotifyOnDesktop.Enabled = false;
            this.NotifyOnDesktop.Location = new System.Drawing.Point(11, 39);
            this.NotifyOnDesktop.Name = "NotifyOnDesktop";
            this.NotifyOnDesktop.Size = new System.Drawing.Size(222, 17);
            this.NotifyOnDesktop.TabIndex = 2;
            this.NotifyOnDesktop.Text = "Уведомления на рабочем столе  (WIP)";
            this.NotifyOnDesktop.UseVisualStyleBackColor = true;
            this.NotifyOnDesktop.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // PlayerAdded
            // 
            this.PlayerAdded.AutoSize = true;
            this.PlayerAdded.Location = new System.Drawing.Point(11, 91);
            this.PlayerAdded.Name = "PlayerAdded";
            this.PlayerAdded.Size = new System.Drawing.Size(155, 17);
            this.PlayerAdded.TabIndex = 1;
            this.PlayerAdded.Text = "Заход игроков в гильдию";
            this.PlayerAdded.UseVisualStyleBackColor = true;
            this.PlayerAdded.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // PlayerKicked
            // 
            this.PlayerKicked.AutoSize = true;
            this.PlayerKicked.Location = new System.Drawing.Point(11, 114);
            this.PlayerKicked.Name = "PlayerKicked";
            this.PlayerKicked.Size = new System.Drawing.Size(178, 17);
            this.PlayerKicked.TabIndex = 0;
            this.PlayerKicked.Text = "Изгнание игроков из гильдии";
            this.PlayerKicked.UseVisualStyleBackColor = true;
            this.PlayerKicked.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(484, 199);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Отладка";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // toolTip1
            // 
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(153, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(324, 17);
            this.label3.TabIndex = 5;
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 225);
            this.Controls.Add(this.tabControl1);
            this.Name = "Settings";
            this.Text = "Настройки";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox AutoStartInTray;
        private System.Windows.Forms.CheckBox AutoStart;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.CheckBox EnableNotify;
        private System.Windows.Forms.CheckBox NotifyOnDesktop;
        private System.Windows.Forms.CheckBox PlayerAdded;
        private System.Windows.Forms.CheckBox PlayerKicked;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.CheckBox DeleteTempFiles;
        private System.Windows.Forms.CheckBox PlayerLeaved;
        private System.Windows.Forms.CheckBox CoinsAdd;
        private System.Windows.Forms.CheckBox OfficerRemoved;
        private System.Windows.Forms.CheckBox LevelUp;
        private System.Windows.Forms.CheckBox PerkUpgraded;
        private System.Windows.Forms.CheckBox OfficerAdded;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.HelpProvider helpProvider1;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label3;
    }
}
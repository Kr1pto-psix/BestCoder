﻿namespace BestCoder
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Minlab = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SecLab = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.settingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.motivationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idleTimeText = new System.Windows.Forms.ToolStripTextBox();
            this.redactorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToStartupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.relaxTimeText = new System.Windows.Forms.ToolStripTextBox();
            this.aboutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.notesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Minlab
            // 
            this.Minlab.AutoSize = true;
            this.Minlab.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Minlab.Location = new System.Drawing.Point(74, 68);
            this.Minlab.Name = "Minlab";
            this.Minlab.Size = new System.Drawing.Size(127, 91);
            this.Minlab.TabIndex = 0;
            this.Minlab.Text = "00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(207, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 91);
            this.label2.TabIndex = 1;
            this.label2.Text = ":";
            // 
            // SecLab
            // 
            this.SecLab.AutoSize = true;
            this.SecLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecLab.Location = new System.Drawing.Point(274, 68);
            this.SecLab.Name = "SecLab";
            this.SecLab.Size = new System.Drawing.Size(127, 91);
            this.SecLab.TabIndex = 2;
            this.SecLab.Text = "00";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(142, 51);
            this.button1.TabIndex = 3;
            this.button1.Text = "Start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(290, 198);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 54);
            this.button2.TabIndex = 4;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingToolStripMenuItem,
            this.aboutToolStripMenuItem1,
            this.notesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(499, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // settingToolStripMenuItem
            // 
            this.settingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.motivationToolStripMenuItem,
            this.timeToolStripMenuItem,
            this.redactorToolStripMenuItem,
            this.addToStartupToolStripMenuItem,
            this.timeToToolStripMenuItem});
            this.settingToolStripMenuItem.Name = "settingToolStripMenuItem";
            this.settingToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingToolStripMenuItem.Text = "Settings";
            // 
            // motivationToolStripMenuItem
            // 
            this.motivationToolStripMenuItem.Name = "motivationToolStripMenuItem";
            this.motivationToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.motivationToolStripMenuItem.Text = "motivational phrases";
            this.motivationToolStripMenuItem.Click += new System.EventHandler(this.motivationToolStripMenuItem_Click);
            // 
            // timeToolStripMenuItem
            // 
            this.timeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.idleTimeText});
            this.timeToolStripMenuItem.Name = "timeToolStripMenuItem";
            this.timeToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.timeToolStripMenuItem.Text = "idle time";
            // 
            // idleTimeText
            // 
            this.idleTimeText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.idleTimeText.Name = "idleTimeText";
            this.idleTimeText.Size = new System.Drawing.Size(180, 23);
            this.idleTimeText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.idleTimeText_KeyPress);
            this.idleTimeText.TextChanged += new System.EventHandler(this.idleTimeText_TextChanged);
            // 
            // redactorToolStripMenuItem
            // 
            this.redactorToolStripMenuItem.Name = "redactorToolStripMenuItem";
            this.redactorToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.redactorToolStripMenuItem.Text = "redactor";
            this.redactorToolStripMenuItem.Click += new System.EventHandler(this.redactorToolStripMenuItem_Click);
            // 
            // addToStartupToolStripMenuItem
            // 
            this.addToStartupToolStripMenuItem.Name = "addToStartupToolStripMenuItem";
            this.addToStartupToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.addToStartupToolStripMenuItem.Text = "add to startup";
            this.addToStartupToolStripMenuItem.Click += new System.EventHandler(this.addToStartupToolStripMenuItem_Click);
            // 
            // timeToToolStripMenuItem
            // 
            this.timeToToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.relaxTimeText});
            this.timeToToolStripMenuItem.Name = "timeToToolStripMenuItem";
            this.timeToToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.timeToToolStripMenuItem.Text = "Time to relax (min)";
            this.timeToToolStripMenuItem.Click += new System.EventHandler(this.timeToToolStripMenuItem_Click);
            // 
            // relaxTimeText
            // 
            this.relaxTimeText.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.relaxTimeText.Name = "relaxTimeText";
            this.relaxTimeText.Size = new System.Drawing.Size(180, 23);
            this.relaxTimeText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.relaxTimeText_KeyPress);
            this.relaxTimeText.TextChanged += new System.EventHandler(this.relaxTimeText_TextChanged);
            // 
            // aboutToolStripMenuItem1
            // 
            this.aboutToolStripMenuItem1.Name = "aboutToolStripMenuItem1";
            this.aboutToolStripMenuItem1.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem1.Text = "About";
            this.aboutToolStripMenuItem1.Click += new System.EventHandler(this.aboutToolStripMenuItem1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft PhagsPa", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Work time:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // timer2
            // 
            this.timer2.Interval = 60000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // notesToolStripMenuItem
            // 
            this.notesToolStripMenuItem.Name = "notesToolStripMenuItem";
            this.notesToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.notesToolStripMenuItem.Text = "Notes";
            this.notesToolStripMenuItem.Click += new System.EventHandler(this.notesToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 281);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SecLab);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Minlab);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Best Coder";
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Minlab;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label SecLab;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem settingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem motivationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redactorToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStripMenuItem timeToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox idleTimeText;
        private System.Windows.Forms.ToolStripMenuItem addToStartupToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ToolStripMenuItem timeToToolStripMenuItem;
        private System.Windows.Forms.ToolStripTextBox relaxTimeText;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem notesToolStripMenuItem;
    }
}


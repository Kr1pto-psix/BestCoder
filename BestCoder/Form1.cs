using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace BestCoder
{
    public partial class Form1 : Form
    {
        Motivation motivationPhrases = new Motivation();
        Kicks kicks;
        int idleTime = 0;
        bool motivation = false;
        String redactorexe = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Programs\\Microsoft VS Code\\Code.exe";
        bool relax = false;
        int RelaxTime = 0;
        int min = 0;
        int sec = 0;
        int relaxTimeTimer = 0;
        int timeToMotivation = 60;
        int curentidletime = 0;
        public Form1()
        {
            InitializeComponent();
            relax = Properties.Settings.Default.relax;
            if (relax == false)
            this.relaxTimeText.Enabled = false;
            if (Properties.Settings.Default.RelaxTime == 0)
                this.relaxTimeText.Text = "0";
            if(Properties.Settings.Default.idleTime == 0)
                this.idleTimeText.Text = "20";
            if(Properties.Settings.Default.redactorPath != "") 
                redactorexe = Properties.Settings.Default.redactorPath;
            idleTime = Properties.Settings.Default.idleTime;
            RelaxTime = Properties.Settings.Default.RelaxTime;
            motivation = Properties.Settings.Default.motivation;
            motivationToolStripMenuItem.Checked = this.motivation;
            addToStartupToolStripMenuItem.Checked = Properties.Settings.Default.addToStartup;
            timeToToolStripMenuItem.Checked = relax;
            this.relaxTimeText.Text = RelaxTime.ToString();
            this.idleTimeText.Text = this.idleTime.ToString();

            notifyIcon1.BalloonTipTitle = "Best coder";
            notifyIcon1.BalloonTipText = "best coder is collapsed";
            notifyIcon1.Text = "Bast coder";
            this.button2.Enabled = false;
            Debug.WriteLine(Path.GetFileName(redactorexe));
            this.kicks = new Kicks(this.redactorexe);
            timer2.Start();
            
        }

      
        private void motivationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool buf = motivationToolStripMenuItem.Checked;
            motivationToolStripMenuItem.Checked = !buf;
            this.motivation = !buf;
            Properties.Settings.Default.motivation = motivation;
            Properties.Settings.Default.Save();
            Debug.WriteLine($"motivation {this.motivation}");
        }

        private void addToStartupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool buf = addToStartupToolStripMenuItem.Checked;
            addToStartupToolStripMenuItem.Checked = !buf;
            addToSetup(!buf);
            Properties.Settings.Default.addToStartup = !buf;
            Properties.Settings.Default.Save();
        }

        private void addToSetup(bool yesOrno)
        {
            string appName = System.Diagnostics.Process.GetCurrentProcess().MainModule.FileName;
            string exePath = Environment.GetCommandLineArgs()[0];
            if (yesOrno)
            {
                using (RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true))
                {
                    if (rk.GetValue(appName) == null)
                    {
                        rk.SetValue(appName, exePath);
                    }
                }
            }
            else
            {
                using (RegistryKey rk = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true))
                {
                    if (rk.GetValue(appName) != null)
                    {
                       rk.DeleteValue(appName);
                    }
                }
            }
        }

        private void redactorToolStripMenuItem_Click(object sender, EventArgs e)
        {

            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.ProgramFiles);
            openFileDialog1.Multiselect = false;
            openFileDialog1.FileName = "Editor.exe";
            openFileDialog1.Filter = "Exe Files (.exe)|*.exe";
            if (this.openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                this.redactorexe = openFileDialog1.FileName;
                Properties.Settings.Default.redactorPath = this.redactorexe; 
                Properties.Settings.Default.Save();
                this.kicks = new Kicks(this.redactorexe);
            }
           
        }

        private void timeToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool buf = timeToToolStripMenuItem.Checked;
            timeToToolStripMenuItem.Checked = !buf;
            this.relax = !buf;

            this.relaxTimeText.Enabled = !buf;
            if (!buf)
            {
                this.relaxTimeText.Text = "20";
            }
            else
                this.relaxTimeText.Text = "0";
            Properties.Settings.Default.relax = !buf;
            Properties.Settings.Default.Save();
            Debug.WriteLine($"relax {this.relax}");
        }

        private void relaxTimeText_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
           
        }

        private void idleTimeText_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8)
            {
                e.Handled = true;
            }
        }

        private void idleTimeText_TextChanged(object sender, EventArgs e)
        {
            if(this.idleTimeText.Text == "0")
            {
                this.idleTime = 1;
                this.idleTimeText.Text = "1";
            }
            else
            {
                if (this.idleTimeText.Text != "")
                    this.idleTime = Int32.Parse(this.idleTimeText.Text);
                else
                {
                    this.idleTime = 1;
                    
                }

            }
            Properties.Settings.Default.idleTime = this.idleTime;
            Properties.Settings.Default.Save();
            
        }

        private void relaxTimeText_TextChanged(object sender, EventArgs e)
        {
            if (this.relaxTimeText.Text == "0")
            {
                this.RelaxTime = 1;
                this.relaxTimeText.Text = "1";
            }
            else
            {
                if (this.relaxTimeText.Text != "")
                {
                    this.RelaxTime = Int32.Parse(this.relaxTimeText.Text);
                }
                else
                {
                    this.RelaxTime = 1;
                }
            }
            Properties.Settings.Default.RelaxTime = this.RelaxTime;
            Properties.Settings.Default.Save();
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
            notifyIcon1.Visible = false;
            WindowState = FormWindowState.Normal;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                notifyIcon1.Visible = true;
                notifyIcon1.ShowBalloonTip(1000);

            }
            else if(FormWindowState.Normal == this.WindowState)
            {
                notifyIcon1.Visible = false;
            }
            

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            sec++;
            if (sec <= 59)
            {
                if(sec <=9)
                    this.SecLab.Text = "0"+ sec.ToString();
                else
                    this.SecLab.Text = sec.ToString();
            }
            else
            {
                sec = 0;
                min++;
                if(min <=9)
                    this.Minlab.Text = "0" + min.ToString();
                else
                    this.Minlab.Text = min.ToString();

                this.SecLab.Text = "0" + sec.ToString();
                this.relaxTimeTimer++;

                if (motivation)
                {
                    this.timeToMotivation--;
                    Properties.Settings.Default.timeToMotivation = timeToMotivation;
                    Properties.Settings.Default.Save();

                    if (timeToMotivation == 0)
                    {
                        timeToMotivation = 60;
                        this.motivationPhrases.notifyMotivationUser();
                    }
                }
                
                if(this.relaxTimeTimer == RelaxTime)
                {
                    this.relaxTimeTimer = 0;
                    if (relax)
                    {
                        if (MessageBox.Show("Do you wanna relax?", "it's time to relax", MessageBoxButtons.YesNo) == DialogResult.Yes)
                        {
                            this.timer1.Stop();
                            this.button1.Text = "Start";
                        }
                    }
                    
                    
                }
            }

            if (!Redactor.rdactorIsOpen(this.redactorexe))
            {
                this.timer1.Stop();
                MessageBox.Show("Уже уходишь? Ладно, но код сам себя не напишит", "Message", MessageBoxButtons.OK);
                Redactor.closeRedactor(this.redactorexe);
                this.button1.Text = "Start";
            }




        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (!Redactor.rdactorIsOpen(this.redactorexe))
            {
                MessageBox.Show("Ты наверное перепутал, ты же хочешь покодить не так ли, дак какова у тебя не открыт твой редактор? \n Я открою его тебе", "Message",MessageBoxButtons.OK);
                Redactor.openRedactor(this.redactorexe);
            }

            this.button2.Enabled = true;
            if (this.timer1.Enabled)
            {
                this.timer1.Stop();
                this.button1.Text = "Start";
                
            }
            else
            {
                this.timer1.Start();
                this.button1.Text = "Stop";

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.min = 0;
            this.sec = 0;
            this.SecLab.Text = "0" + sec.ToString();
            this.Minlab.Text = "0" + min.ToString();

            //kicks.mem2();
            //for (int i = 0; i < 4; i++)
            //{
            //    this.motivationPhrases.notifyMotivationUser();

            //}


        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (!Redactor.rdactorIsOpen(this.redactorexe))
            {
                curentidletime++;
                if (this.curentidletime == idleTime)
                {
                    curentidletime = 0;
                    if (this.WindowState == FormWindowState.Minimized)
                    {
                        this.Show();
                        notifyIcon1.Visible = false;
                        WindowState = FormWindowState.Normal;
                    }

                    this.kicks.runRandomKiks();
                    

                   
                }
            }
            
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.ShowDialog();
        }
    }
}

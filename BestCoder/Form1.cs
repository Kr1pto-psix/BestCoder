using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace BestCoder
{
    public partial class Form1 : Form
    {
        
        int idleTime = 0;
        bool motivation = false;
        String redactorexe = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + "\\Programs\\Microsoft VS Code\\Code.exe";
        bool relax = false;
        int RelaxTime = 0;

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

            redactorexe = Properties.Settings.Default.redactorPath;
            idleTime = Properties.Settings.Default.idleTime;
            RelaxTime = Properties.Settings.Default.RelaxTime;
            motivation = Properties.Settings.Default.motivation;
            motivationToolStripMenuItem.Checked = this.motivation;
            addToStartupToolStripMenuItem.Checked = Properties.Settings.Default.addToStartup;
            timeToToolStripMenuItem.Checked = relax;
            this.relaxTimeText.Text = RelaxTime.ToString();
            this.idleTimeText.Text = this.idleTime.ToString();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm about = new AboutForm();
            about.ShowDialog();
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
            if (this.idleTimeText.Text != "")
                this.idleTime = Int32.Parse(this.idleTimeText.Text);
            else
            {
                this.idleTime = 0;
            }
            Properties.Settings.Default.idleTime = this.idleTime;
            Properties.Settings.Default.Save();
            Debug.WriteLine("idle Time" + idleTime);
        }

        private void relaxTimeText_TextChanged(object sender, EventArgs e)
        {
            if(this.relaxTimeText.Text != "")
            {
                this.RelaxTime = Int32.Parse(this.relaxTimeText.Text);
                Debug.WriteLine("relaxTime " + this.RelaxTime);
            }
            else
            {
                this.RelaxTime = 0;
            }
            Properties.Settings.Default.RelaxTime = this.RelaxTime;
            Properties.Settings.Default.Save();
        }
    }
}

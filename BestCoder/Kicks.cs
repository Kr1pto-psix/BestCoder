using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using System.Drawing;
using System.Threading;
using System.IO;
using System.Windows.Forms;
using System.Resources;
namespace BestCoder
{
    internal class Kicks
    {
        private MemForm memForm = new MemForm(); 
        string redactorPach = string.Empty;
        public Kicks(string redactorPach)
        {
            this.redactorPach = redactorPach;  
        }
        public void mem1()
        {
            memForm = new MemForm();
            memForm.setImage(Properties.Resources._1626763285199243018);
            Size resolution = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Size;
            memForm.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            memForm.Location = new Point(resolution.Width - 10, resolution.Height / 2);
            memForm.Visible = true;
            memForm.TopMost = true;
            memForm.Show();
            for (int i = resolution.Width + 20; i > (resolution.Width - memForm.Width - 10); i--)
            {
                memForm.Location = new Point(i, (resolution.Height / 2));
                Cursor.Position = new Point(i + memForm.Width / 2, (resolution.Height / 2));
                Task.Delay(2).Wait();
            }
            

        }
        public void mem2()
        {
            if(MessageBox.Show("Я открою редактор кода для тебя?", "Вы не ахуели?",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                MessageBox.Show("Окей спасибо что начал заниматся :)", "xD", MessageBoxButtons.OK);
                Redactor.openRedactor(this.redactorPach);
            }
            else
            {
                MessageBox.Show("Блять, зачем я спрашивал", "?", MessageBoxButtons.OK);
                Redactor.openRedactor(this.redactorPach);
            }
            
        }

        public void runRandomKiks()
        {
            mem1();
            mem2();
        }





    }
}

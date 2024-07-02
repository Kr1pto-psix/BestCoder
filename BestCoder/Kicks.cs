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
using Windows.ApplicationModel.Activation;
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
        public void mem3()
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=dQw4w9WgXcQ");
        }
        public void mem5()
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=yFNieGc0H6g");
        }
        public void mem4()
        {
            for(int i= 0; i < 20; i++)
            {
                Code code= new Code();
                code.Location = new Point(i *42, i * 42);
                code.Show();
            }
        }
        public void mem6()
        {
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=9MnS0QJ2Nok");
        }

        public void Button_Click(object sender, EventArgs e)
        {
            this.memForm.Close();
        }
        public void mem8()
        {
            System.Diagnostics.Process.Start("https://youtu.be/QMbx0dTWJIQ?si=QLAhavPg7nlKF0EZ");
        }
        public void mem7()
        {
            memForm = new MemForm();
            memForm.setImage(Properties.Resources._64afd224cddf46d3a38eeef8);
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
        public void runRandomKiks()
        {
            Random random = new Random();
            int val = random.Next(1, 8);
            switch (val) {
                case 1: mem1();
                    break;
                case 2: mem2();
                    break;
                case 3: mem3();
                    break;
                case 4: mem4();
                    break;
                case 5: mem5();
                    break;
                case 6: mem6();
                    break;
                case 7: mem7();
                    break;
                case 8: mem8();
                    break;
            }

        }





    }
}

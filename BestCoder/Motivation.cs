using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;




using Microsoft.Toolkit.Uwp.Notifications;
namespace BestCoder
{
    internal class Motivation
    {
        Random random = new Random();
        
        private string getRandomString()
        {
            string context = Properties.Resources.motivation;
            string[] lines = context.Split(new[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            int NumStr = this.random.Next(0, lines.Length);
            return lines[NumStr];
        }

        public void notifyMotivationUser()
        {
            new ToastContentBuilder()
            .AddText("Мотивационая фраза")
            .AddText(getRandomString())
            .Show();
        }

    }
}

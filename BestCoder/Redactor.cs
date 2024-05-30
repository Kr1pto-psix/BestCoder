using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BestCoder
{
    internal class Redactor
    {
        public static bool rdactorIsOpen(string redactorPath)
        {
            return Process.GetProcessesByName(Path.GetFileNameWithoutExtension(redactorPath)).Any();
        }
        public static void openRedactor(string redactorPath)
        {
            if (!rdactorIsOpen(redactorPath))
            {
                Process.Start(redactorPath);
            }
           
        }
        public static void closeRedactor(string redactorPath)
        {
            foreach (Process proc in Process.GetProcessesByName(Path.GetFileNameWithoutExtension(redactorPath))) 
            {
                proc.Kill();
            }

        }
    }
}

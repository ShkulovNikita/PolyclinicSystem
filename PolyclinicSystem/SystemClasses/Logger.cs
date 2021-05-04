using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PolyclinicSystem
{
    static public class Logger
    {
        static public void ActivateLogger()
        {
            Directory.CreateDirectory("logs");
        }

        static public void WriteLog(string message)
        {
            string currentDate = DateTime.Today.ToString("dd.MM.yyyy");
            using (StreamWriter sw = new StreamWriter("./logs/" + currentDate + ".log", true, System.Text.Encoding.UTF8))
            {
                sw.WriteLine("----------------------------");
                sw.WriteLine(DateTime.Now);
                sw.WriteLine(message);
            }
        }

        static public void WriteLog(Exception message)
        {
            string currentDate = DateTime.Today.ToString("dd.MM.yyyy");
            using (StreamWriter sw = new StreamWriter("./logs/" + currentDate + ".log", true, System.Text.Encoding.UTF8))
            {
                sw.WriteLine("----------------------------");
                sw.WriteLine(DateTime.Now);
                sw.WriteLine(message.ToString());
            }
        }
    }
}

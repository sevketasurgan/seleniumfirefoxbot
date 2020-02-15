using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FirefoxSeleniumBot
{
    class FakeLocates:Form1
    {
        public string locats()
        {
           
            Random rand = new Random();
            string[] pdfFiles = Directory.GetFiles(@"C:\\Users\sevke\Source\Repos\FirefoxSeleniumBot\bin\Debug\locations", "*.json").Select(Path.GetFileName).ToArray();
            int d = rand.Next(0, pdfFiles.Length);
            string newfake = pdfFiles[d].ToString();
            return newfake;



        }
      












    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO; 

namespace InstagramBot
{
    public static class SaveSettings
    {
        public static void SaveCustumSetting(this string setting , string fileName)
        {
            if (!File.Exists(fileName))
            {
                using (FileStream file = File.Create(fileName))
                {
                    StreamWriter stream = new StreamWriter(file);
                    stream.WriteLine(setting);
                    stream.Close(); 
                }
            }
            else
            {
                using(StreamWriter stream = new StreamWriter(fileName))
                {
                    stream.WriteLine(setting);
                    stream.Close();
                }
            }
            

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics; 

namespace InstagramBot
{
    public class RunFile
    {
        public RunFile()
        {
            try
            {
                Process.Start("Instabotpy.py");
            }
            catch (Exception ex)
            {

                throw;
            }
            finally
            {

            }
        }
    }
}

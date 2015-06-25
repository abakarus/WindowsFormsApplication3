using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication3
{
    class Functions
    {
        public static string DataRoot
        {
            get
            {
                return Directory.GetDirectoryRoot(Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName)) + @"\data";
            }
        }
    }
}

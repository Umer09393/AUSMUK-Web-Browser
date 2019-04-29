using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication6
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Singleton singleton = Singleton.getInstance();
            singleton.RunApp();

     //       Application.EnableVisualStyles();
     //       Application.SetCompatibleTextRenderingDefault(false);
     //       Application.Run(new Form1());

            
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YoutubeApisDemo
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new frmInitializers(new frmHome(), "Initializing Components..."));
            Application.Run(new frmDownloads("https://www.youtube.com/watch?v=hhSttje4Dx4"));
        }
    }
}

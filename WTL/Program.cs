using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
    

namespace WTL
{
    static class Program
    {
        public static Timer lt;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static void Launch()
        {
            Process.Start("steam://rungameid/236390");
            lt = new Timer();
            //t.Interval = 600000;
            lt.Interval = 5000;
            lt.Tick += new EventHandler(timer_Tick);
            lt.Start();
        }

        static void timer_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("FFFF");
            lt.Stop();
        }
    }
}

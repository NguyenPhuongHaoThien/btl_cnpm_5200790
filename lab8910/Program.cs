using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapLonCNPM
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        private static string strConn = "";
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            strConn = ConfigurationManager.ConnectionStrings["MyConn"].ConnectionString;
            Application.Run(new MainForm());
        }

        public static string GetCon()
        {
            return strConn;
        }
    }
}

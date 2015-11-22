using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sudou_stock
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            winLogin l = new winLogin();
            if(l.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new Main());
            }
            
        }
    }
}

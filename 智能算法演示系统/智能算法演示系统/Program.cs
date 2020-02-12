using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 智能算法演示系统
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
            //Application.Run(new 智能算法演示系统());
            Frm_Login login = new Frm_Login();

            //切换登录界面到主程序界面
            login.ShowDialog();
            if (login.DialogResult == DialogResult.OK)
            {
                login.Dispose();
                Application.Run(new Frm_MainForm());
            }
            else if (login.DialogResult == DialogResult.Cancel)
            {
                login.Dispose();
                return;
            }

            


        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PLM系统工具集成
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
            Application.Run(new PlmToolsForm());
        }
    }
}

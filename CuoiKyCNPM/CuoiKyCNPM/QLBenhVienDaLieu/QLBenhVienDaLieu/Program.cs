﻿using System;
using System.Windows.Forms;

namespace QLBenhVienDaLieu
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BS_Kham_Benh("0987654321"));
        }
    }
}

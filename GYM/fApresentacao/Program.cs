﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace fApresentacao
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
            //Application.Run(new frmTelaSplash());
            //Application.Run(new frmCadLivros());
            //Application.Run(new frmMenu());
            Application.Run(new frmCadAluno());
            //Application.Run(new frmLogin());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CustomFilterBank_Test
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
            //Application.Run(new SharpenerForm());
            //Application.Run(new ConvolutionForm());
            Application.Run(new KassWitkinFilterBankForm());
            //Application.Run(new MainForm());
            //Application.Run(new OverlayTestForm());
        }
    }
}

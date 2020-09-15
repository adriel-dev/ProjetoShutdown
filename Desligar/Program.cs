using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desligar
{
    class Program
    {
        public static Form1 form1;
        /// <summary>
        /// Ponto de entrada principal para o aplicativo.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetCompatibleTextRenderingDefault(false);
            form1 = new Form1();
            Application.EnableVisualStyles();
            Application.Run(form1);
        }
    }
}

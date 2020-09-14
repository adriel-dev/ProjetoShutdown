using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desligar
{
    public class Operacoes
    {

        public void consoleWritter(String comando)
        {
            Process processo = new Process();
            processo.StartInfo.FileName = "cmd.exe";
            processo.StartInfo.UseShellExecute = false;
            processo.StartInfo.RedirectStandardInput = true;
            processo.StartInfo.RedirectStandardOutput = true;
            processo.Start();
            processo.StandardInput.WriteLine(comando);
            processo.StandardInput.Flush();
            processo.StandardInput.Close();
            processo.WaitForExit();
        }

        public void abrirAviso()
        {

        }
    }
}

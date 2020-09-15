using Desligar.SecondaryForms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desligar
{
    public static class Operacoes
    {
        public static void consoleWritter(String comando)
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

        public static void abrirAviso()
        {
            Form1 formAtivo = Program.form1;
            FormAviso formAviso = new FormAviso();
            formAviso.TopLevel = false;
            formAviso.FormBorderStyle = FormBorderStyle.None;
            formAviso.Dock = DockStyle.Fill;
            formAtivo.panelFormSecundario.Controls.Add(formAviso);
            formAtivo.panelFormSecundario.Tag = formAviso;
            formAviso.BringToFront();
            formAviso.Show();

            /* childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelFormSecundario.Controls.Add(childForm);
            this.panelFormSecundario.Tag = childForm;
            childForm.BringToFront();
            childForm.Show(); */
        }
    }
}

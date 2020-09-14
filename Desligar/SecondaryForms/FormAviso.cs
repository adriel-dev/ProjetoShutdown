using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desligar.SecondaryForms
{
    public partial class FormAviso : Form
    {
        string comando = "shutdown -a";
        public FormAviso()
        {
            InitializeComponent();
        }

        private void btnCancelar_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.Red;
        }

        private void btnCancelar_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackColor = Color.White;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            consoleWritter();
            this.Close();
        }

        private void consoleWritter()
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
    }
}

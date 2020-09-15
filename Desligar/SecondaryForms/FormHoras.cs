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
    public partial class FormHoras : Form
    {
        int tempo;
        string comando = "shutdown -s -t";

        public FormHoras()
        {
            InitializeComponent();
        }

        private void FormHoras_Load(object sender, EventArgs e)
        {
            carregarCor();
        }

        void carregarCor()
        {
            foreach(Control btns in this.Controls)
            {
                if(btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = Color.FromArgb(28, 34, 209);
                    btn.ForeColor = Color.White;
                }
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            tempo = Convert.ToInt32(numericUpDown1.Value);
            tempo = (tempo * 60) * 60;
            comando = "shutdown -s -t " + tempo;
            Operacoes.consoleWritter(comando);
            Operacoes.abrirAviso();
        }
    }
}

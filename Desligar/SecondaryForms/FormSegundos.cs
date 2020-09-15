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
    public partial class FormSegundos : Form
    {
        int tempo;
        string comando = "shutdown -s -t";

        public FormSegundos()
        {
            InitializeComponent();
        }

        private void FormSegundos_Load(object sender, EventArgs e)
        {
            carregarCor();
        }

        void carregarCor()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = Color.FromArgb(209, 28, 28);
                    btn.ForeColor = Color.White;
                }
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            tempo = Convert.ToInt32(numericUpDown1.Value);
            comando = "shutdown -s -t " + tempo;
            Operacoes.consoleWritter(comando);
            Operacoes.abrirAviso();
        }
    }
}

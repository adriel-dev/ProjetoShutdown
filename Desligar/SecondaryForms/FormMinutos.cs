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
    public partial class FormMinutos : Form
    {
        int tempo;
        string comando = "shutdown -s -t";
        Operacoes operacoes;

        public FormMinutos()
        {
            InitializeComponent();
        }

        private void FormMinutos_Load(object sender, EventArgs e)
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
                    btn.BackColor = Color.FromArgb(209, 155, 28);
                    btn.ForeColor = Color.White;
                }
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            operacoes = new Operacoes();
            tempo = Convert.ToInt32(numericUpDown1.Value);
            tempo = tempo * 60;
            comando = "shutdown -s -t " + tempo;
            operacoes.consoleWritter(comando);
            abrirFormAviso(new SecondaryForms.FormAviso(), (Button)sender);
        }

        private void abrirFormAviso(Form childForm, Button btnSender)
        {
            childForm.TopLevel = false;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}

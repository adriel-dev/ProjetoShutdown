using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desligar
{
    public partial class Form1 : Form
    {
        Button btnAtual;
        Form formAtivo;
        public Form1()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void ativarBotao(Button sender)
        {
            if(sender != null)
            {
                if(btnAtual != sender)
                {
                    btnAtual = sender;

                    desativarBotao(sender);

                    if (sender.Text.Equals("Hora(s)"))
                    {
                        btnHoras.BackColor = Color.FromArgb(28, 34, 209);
                        btnHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    }
                    else if (sender.Text.Equals("Minuto(s)"))
                    {
                        btnMinutos.BackColor = Color.FromArgb(209, 155, 28);
                        btnMinutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    }
                    else if (sender.Text.Equals("Segundo(s)"))
                    {
                        btnSegundos.BackColor = Color.FromArgb(209, 28, 28);
                        btnSegundos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    }
                    else
                    {

                    }
                }
            }
        }

        private void desativarBotao(Button sender)
        {
            foreach (Control btnAnterior in panelMenu.Controls)
            {
                if (btnAnterior.GetType() == typeof(Button))
                {
                    btnAnterior.BackColor = Color.FromArgb(41, 41, 65);
                    btnAnterior.ForeColor = Color.White;
                    btnAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void abrirFormSecundario(Form childForm, Button btnSender)
        {
            if (formAtivo != null)
            {
                formAtivo.Close();
            }
            ativarBotao(btnSender);
            formAtivo = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelFormSecundario.Controls.Add(childForm);
            this.panelFormSecundario.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        private void btnFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnFechar_MouseEnter(object sender, EventArgs e)
        {
            btnFechar.BackColor = Color.Red;
        }

        private void btnFechar_MouseLeave(object sender, EventArgs e)
        {
            btnFechar.BackColor = Color.FromArgb(51, 51, 75);
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnHoras_Click(object sender, EventArgs e)
        {
            abrirFormSecundario(new SecondaryForms.FormHoras(), (Button)sender);
        }

        private void btnMinutos_Click(object sender, EventArgs e)
        {
            abrirFormSecundario(new SecondaryForms.FormMinutos(), (Button)sender);
        }

        private void btnSegundos_Click(object sender, EventArgs e)
        {
            abrirFormSecundario(new SecondaryForms.FormSegundos(), (Button)sender);
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.github.com/adriel-dev");
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }   
}

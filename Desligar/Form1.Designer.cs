namespace Desligar
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelMenu = new System.Windows.Forms.Panel();
            this.lblVersion = new System.Windows.Forms.Label();
            this.btnSegundos = new System.Windows.Forms.Button();
            this.btnMinutos = new System.Windows.Forms.Button();
            this.btnHoras = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.linkLabel = new System.Windows.Forms.LinkLabel();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.btnMinimizar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.panelFormSecundario = new System.Windows.Forms.Panel();
            this.lblSeta = new System.Windows.Forms.Label();
            this.lblTexto = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.panelFormSecundario.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(65)))));
            this.panelMenu.Controls.Add(this.lblVersion);
            this.panelMenu.Controls.Add(this.btnSegundos);
            this.panelMenu.Controls.Add(this.btnMinutos);
            this.panelMenu.Controls.Add(this.btnHoras);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(125, 208);
            this.panelMenu.TabIndex = 0;
            // 
            // lblVersion
            // 
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblVersion.Location = new System.Drawing.Point(3, 192);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(18, 7);
            this.lblVersion.TabIndex = 4;
            this.lblVersion.Text = "v2.0";
            // 
            // btnSegundos
            // 
            this.btnSegundos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSegundos.FlatAppearance.BorderSize = 0;
            this.btnSegundos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSegundos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSegundos.ForeColor = System.Drawing.Color.White;
            this.btnSegundos.Location = new System.Drawing.Point(0, 132);
            this.btnSegundos.Name = "btnSegundos";
            this.btnSegundos.Size = new System.Drawing.Size(125, 47);
            this.btnSegundos.TabIndex = 3;
            this.btnSegundos.Text = "Segundo(s)";
            this.btnSegundos.UseVisualStyleBackColor = true;
            this.btnSegundos.Click += new System.EventHandler(this.btnSegundos_Click);
            // 
            // btnMinutos
            // 
            this.btnMinutos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMinutos.FlatAppearance.BorderSize = 0;
            this.btnMinutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinutos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinutos.ForeColor = System.Drawing.Color.White;
            this.btnMinutos.Location = new System.Drawing.Point(0, 85);
            this.btnMinutos.Name = "btnMinutos";
            this.btnMinutos.Size = new System.Drawing.Size(125, 47);
            this.btnMinutos.TabIndex = 2;
            this.btnMinutos.Text = "Minuto(s)";
            this.btnMinutos.UseVisualStyleBackColor = true;
            this.btnMinutos.Click += new System.EventHandler(this.btnMinutos_Click);
            // 
            // btnHoras
            // 
            this.btnHoras.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHoras.FlatAppearance.BorderSize = 0;
            this.btnHoras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoras.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoras.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnHoras.Location = new System.Drawing.Point(0, 38);
            this.btnHoras.Name = "btnHoras";
            this.btnHoras.Size = new System.Drawing.Size(125, 47);
            this.btnHoras.TabIndex = 1;
            this.btnHoras.Text = "Hora(s)";
            this.btnHoras.UseVisualStyleBackColor = true;
            this.btnHoras.Click += new System.EventHandler(this.btnHoras_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(65)))));
            this.panelLogo.Controls.Add(this.linkLabel);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(125, 38);
            this.panelLogo.TabIndex = 0;
            // 
            // linkLabel
            // 
            this.linkLabel.AutoSize = true;
            this.linkLabel.LinkColor = System.Drawing.Color.CornflowerBlue;
            this.linkLabel.Location = new System.Drawing.Point(36, 13);
            this.linkLabel.Name = "linkLabel";
            this.linkLabel.Size = new System.Drawing.Size(53, 13);
            this.linkLabel.TabIndex = 0;
            this.linkLabel.TabStop = true;
            this.linkLabel.Text = "adriel-dev";
            this.linkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(41)))), ((int)(((byte)(65)))));
            this.panelTitleBar.Controls.Add(this.btnMinimizar);
            this.panelTitleBar.Controls.Add(this.btnFechar);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(125, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(343, 38);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // btnMinimizar
            // 
            this.btnMinimizar.FlatAppearance.BorderSize = 0;
            this.btnMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnMinimizar.Location = new System.Drawing.Point(242, 3);
            this.btnMinimizar.Name = "btnMinimizar";
            this.btnMinimizar.Size = new System.Drawing.Size(45, 32);
            this.btnMinimizar.TabIndex = 1;
            this.btnMinimizar.Text = "__";
            this.btnMinimizar.UseVisualStyleBackColor = true;
            this.btnMinimizar.Click += new System.EventHandler(this.btnMinimizar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.FlatAppearance.BorderSize = 0;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFechar.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnFechar.Location = new System.Drawing.Point(293, 3);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(47, 32);
            this.btnFechar.TabIndex = 0;
            this.btnFechar.Text = "X";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            this.btnFechar.MouseEnter += new System.EventHandler(this.btnFechar_MouseEnter);
            this.btnFechar.MouseLeave += new System.EventHandler(this.btnFechar_MouseLeave);
            // 
            // panelFormSecundario
            // 
            this.panelFormSecundario.Controls.Add(this.lblSeta);
            this.panelFormSecundario.Controls.Add(this.lblTexto);
            this.panelFormSecundario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelFormSecundario.Location = new System.Drawing.Point(125, 38);
            this.panelFormSecundario.Name = "panelFormSecundario";
            this.panelFormSecundario.Size = new System.Drawing.Size(343, 170);
            this.panelFormSecundario.TabIndex = 2;
            // 
            // lblSeta
            // 
            this.lblSeta.AutoSize = true;
            this.lblSeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeta.Location = new System.Drawing.Point(145, 81);
            this.lblSeta.Name = "lblSeta";
            this.lblSeta.Size = new System.Drawing.Size(28, 13);
            this.lblSeta.TabIndex = 1;
            this.lblSeta.Text = "<-----";
            // 
            // lblTexto
            // 
            this.lblTexto.AccessibleDescription = "";
            this.lblTexto.AutoSize = true;
            this.lblTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTexto.Location = new System.Drawing.Point(87, 47);
            this.lblTexto.Name = "lblTexto";
            this.lblTexto.Size = new System.Drawing.Size(162, 20);
            this.lblTexto.TabIndex = 0;
            this.lblTexto.Text = "Selecione uma opção";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 208);
            this.Controls.Add(this.panelFormSecundario);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Desligar";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelFormSecundario.ResumeLayout(false);
            this.panelFormSecundario.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnSegundos;
        private System.Windows.Forms.Button btnMinutos;
        private System.Windows.Forms.Button btnHoras;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Button btnMinimizar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.LinkLabel linkLabel;
        private System.Windows.Forms.Label lblSeta;
        private System.Windows.Forms.Label lblTexto;
        public System.Windows.Forms.Panel panelFormSecundario;
    }
}


namespace PI
{
    partial class frmPartida
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblPartida = new System.Windows.Forms.Label();
            this.lblIdPartida = new System.Windows.Forms.Label();
            this.lblIdJogadorUm = new System.Windows.Forms.Label();
            this.txtIdJogadorUm = new System.Windows.Forms.TextBox();
            this.lstCartas = new System.Windows.Forms.ListBox();
            this.btnMostrarCartas = new System.Windows.Forms.Button();
            this.blbSenhaJogadorUm = new System.Windows.Forms.Label();
            this.txtSenhaJogadorUm = new System.Windows.Forms.TextBox();
            this.lblIdJogadorSorteado = new System.Windows.Forms.Label();
            this.lblIdSorteado = new System.Windows.Forms.Label();
            this.lblValorCarta = new System.Windows.Forms.Label();
            this.tmrIniciarAutomacao = new System.Windows.Forms.Timer(this.components);
            this.btnIniciarAutomacao = new System.Windows.Forms.Button();
            this.lblVez = new System.Windows.Forms.Label();
            this.lblVezTitulo = new System.Windows.Forms.Label();
            this.lxtStatusRodadaTitulo = new System.Windows.Forms.Label();
            this.lblStatusRodada = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(8, 235);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(64, 28);
            this.btnVoltar.TabIndex = 0;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblPartida
            // 
            this.lblPartida.AutoSize = true;
            this.lblPartida.Location = new System.Drawing.Point(65, 7);
            this.lblPartida.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPartida.Name = "lblPartida";
            this.lblPartida.Size = new System.Drawing.Size(10, 13);
            this.lblPartida.TabIndex = 1;
            this.lblPartida.Text = ".";
            // 
            // lblIdPartida
            // 
            this.lblIdPartida.AutoSize = true;
            this.lblIdPartida.Location = new System.Drawing.Point(12, 7);
            this.lblIdPartida.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdPartida.Name = "lblIdPartida";
            this.lblIdPartida.Size = new System.Drawing.Size(57, 13);
            this.lblIdPartida.TabIndex = 2;
            this.lblIdPartida.Text = "ID Partida:";
            // 
            // lblIdJogadorUm
            // 
            this.lblIdJogadorUm.AutoSize = true;
            this.lblIdJogadorUm.Location = new System.Drawing.Point(15, 58);
            this.lblIdJogadorUm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdJogadorUm.Name = "lblIdJogadorUm";
            this.lblIdJogadorUm.Size = new System.Drawing.Size(68, 13);
            this.lblIdJogadorUm.TabIndex = 3;
            this.lblIdJogadorUm.Text = "ID jogador 1:";
            // 
            // txtIdJogadorUm
            // 
            this.txtIdJogadorUm.Location = new System.Drawing.Point(103, 54);
            this.txtIdJogadorUm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtIdJogadorUm.Name = "txtIdJogadorUm";
            this.txtIdJogadorUm.Size = new System.Drawing.Size(76, 20);
            this.txtIdJogadorUm.TabIndex = 4;
            // 
            // lstCartas
            // 
            this.lstCartas.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lstCartas.FormattingEnabled = true;
            this.lstCartas.Location = new System.Drawing.Point(9, 266);
            this.lstCartas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstCartas.Name = "lstCartas";
            this.lstCartas.Size = new System.Drawing.Size(145, 238);
            this.lstCartas.TabIndex = 32;
            // 
            // btnMostrarCartas
            // 
            this.btnMostrarCartas.Location = new System.Drawing.Point(36, 512);
            this.btnMostrarCartas.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnMostrarCartas.Name = "btnMostrarCartas";
            this.btnMostrarCartas.Size = new System.Drawing.Size(89, 32);
            this.btnMostrarCartas.TabIndex = 33;
            this.btnMostrarCartas.Text = "Mostrar Cartas";
            this.btnMostrarCartas.UseVisualStyleBackColor = true;
            this.btnMostrarCartas.Click += new System.EventHandler(this.btnMostrarCartas_Click);
            // 
            // blbSenhaJogadorUm
            // 
            this.blbSenhaJogadorUm.AutoSize = true;
            this.blbSenhaJogadorUm.Location = new System.Drawing.Point(15, 81);
            this.blbSenhaJogadorUm.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.blbSenhaJogadorUm.Name = "blbSenhaJogadorUm";
            this.blbSenhaJogadorUm.Size = new System.Drawing.Size(88, 13);
            this.blbSenhaJogadorUm.TabIndex = 34;
            this.blbSenhaJogadorUm.Text = "Senha jogador 1:";
            // 
            // txtSenhaJogadorUm
            // 
            this.txtSenhaJogadorUm.Location = new System.Drawing.Point(103, 76);
            this.txtSenhaJogadorUm.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSenhaJogadorUm.Name = "txtSenhaJogadorUm";
            this.txtSenhaJogadorUm.Size = new System.Drawing.Size(76, 20);
            this.txtSenhaJogadorUm.TabIndex = 35;
            // 
            // lblIdJogadorSorteado
            // 
            this.lblIdJogadorSorteado.AutoSize = true;
            this.lblIdJogadorSorteado.Location = new System.Drawing.Point(14, 32);
            this.lblIdJogadorSorteado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdJogadorSorteado.Name = "lblIdJogadorSorteado";
            this.lblIdJogadorSorteado.Size = new System.Drawing.Size(103, 13);
            this.lblIdJogadorSorteado.TabIndex = 38;
            this.lblIdJogadorSorteado.Text = "ID jogador sorteado:";
            // 
            // lblIdSorteado
            // 
            this.lblIdSorteado.AutoSize = true;
            this.lblIdSorteado.Location = new System.Drawing.Point(116, 32);
            this.lblIdSorteado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdSorteado.Name = "lblIdSorteado";
            this.lblIdSorteado.Size = new System.Drawing.Size(10, 13);
            this.lblIdSorteado.TabIndex = 39;
            this.lblIdSorteado.Text = ".";
            // 
            // lblValorCarta
            // 
            this.lblValorCarta.AutoSize = true;
            this.lblValorCarta.Location = new System.Drawing.Point(655, 136);
            this.lblValorCarta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblValorCarta.Name = "lblValorCarta";
            this.lblValorCarta.Size = new System.Drawing.Size(10, 13);
            this.lblValorCarta.TabIndex = 45;
            this.lblValorCarta.Text = ".";
            // 
            // tmrIniciarAutomacao
            // 
            this.tmrIniciarAutomacao.Interval = 15000;
            this.tmrIniciarAutomacao.Tick += new System.EventHandler(this.tmrIniciarAutomacao_Tick);
            // 
            // btnIniciarAutomacao
            // 
            this.btnIniciarAutomacao.Location = new System.Drawing.Point(8, 205);
            this.btnIniciarAutomacao.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnIniciarAutomacao.Name = "btnIniciarAutomacao";
            this.btnIniciarAutomacao.Size = new System.Drawing.Size(114, 25);
            this.btnIniciarAutomacao.TabIndex = 46;
            this.btnIniciarAutomacao.Text = "Iniciar Automação";
            this.btnIniciarAutomacao.UseVisualStyleBackColor = true;
            this.btnIniciarAutomacao.Click += new System.EventHandler(this.btnIniciarAutomacao_Click);
            // 
            // lblVez
            // 
            this.lblVez.AutoSize = true;
            this.lblVez.Location = new System.Drawing.Point(44, 119);
            this.lblVez.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVez.Name = "lblVez";
            this.lblVez.Size = new System.Drawing.Size(10, 13);
            this.lblVez.TabIndex = 47;
            this.lblVez.Text = ".";
            // 
            // lblVezTitulo
            // 
            this.lblVezTitulo.AutoSize = true;
            this.lblVezTitulo.Location = new System.Drawing.Point(15, 119);
            this.lblVezTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVezTitulo.Name = "lblVezTitulo";
            this.lblVezTitulo.Size = new System.Drawing.Size(28, 13);
            this.lblVezTitulo.TabIndex = 48;
            this.lblVezTitulo.Text = "Vez:";
            // 
            // lxtStatusRodadaTitulo
            // 
            this.lxtStatusRodadaTitulo.AutoSize = true;
            this.lxtStatusRodadaTitulo.Location = new System.Drawing.Point(15, 154);
            this.lxtStatusRodadaTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lxtStatusRodadaTitulo.Name = "lxtStatusRodadaTitulo";
            this.lxtStatusRodadaTitulo.Size = new System.Drawing.Size(91, 13);
            this.lxtStatusRodadaTitulo.TabIndex = 49;
            this.lxtStatusRodadaTitulo.Text = "Status da rodada:";
            // 
            // lblStatusRodada
            // 
            this.lblStatusRodada.AutoSize = true;
            this.lblStatusRodada.Location = new System.Drawing.Point(102, 154);
            this.lblStatusRodada.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblStatusRodada.Name = "lblStatusRodada";
            this.lblStatusRodada.Size = new System.Drawing.Size(10, 13);
            this.lblStatusRodada.TabIndex = 50;
            this.lblStatusRodada.Text = ".";
            // 
            // frmPartida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(973, 560);
            this.Controls.Add(this.lblStatusRodada);
            this.Controls.Add(this.lxtStatusRodadaTitulo);
            this.Controls.Add(this.lblVezTitulo);
            this.Controls.Add(this.lblVez);
            this.Controls.Add(this.btnIniciarAutomacao);
            this.Controls.Add(this.lblValorCarta);
            this.Controls.Add(this.lblIdSorteado);
            this.Controls.Add(this.lblIdJogadorSorteado);
            this.Controls.Add(this.txtSenhaJogadorUm);
            this.Controls.Add(this.blbSenhaJogadorUm);
            this.Controls.Add(this.btnMostrarCartas);
            this.Controls.Add(this.lstCartas);
            this.Controls.Add(this.txtIdJogadorUm);
            this.Controls.Add(this.lblIdJogadorUm);
            this.Controls.Add(this.lblIdPartida);
            this.Controls.Add(this.lblPartida);
            this.Controls.Add(this.btnVoltar);
            this.Name = "frmPartida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Partida";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblPartida;
        private System.Windows.Forms.Label lblIdPartida;
        private System.Windows.Forms.Label lblIdJogadorUm;
        private System.Windows.Forms.TextBox txtIdJogadorUm;
        private System.Windows.Forms.ListBox lstCartas;
        private System.Windows.Forms.Button btnMostrarCartas;
        private System.Windows.Forms.Label blbSenhaJogadorUm;
        private System.Windows.Forms.TextBox txtSenhaJogadorUm;
        private System.Windows.Forms.Label lblIdJogadorSorteado;
        private System.Windows.Forms.Label lblIdSorteado;
        private System.Windows.Forms.Label lblValorCarta;
        private System.Windows.Forms.Timer tmrIniciarAutomacao;
        private System.Windows.Forms.Button btnIniciarAutomacao;
        private System.Windows.Forms.Label lblVez;
        private System.Windows.Forms.Label lblVezTitulo;
        private System.Windows.Forms.Label lxtStatusRodadaTitulo;
        private System.Windows.Forms.Label lblStatusRodada;
    }
}
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
            this.txtMeuId = new System.Windows.Forms.TextBox();
            this.btnMostrarCartas = new System.Windows.Forms.Button();
            this.blbSenhaJogadorUm = new System.Windows.Forms.Label();
            this.txtMinhaSenha = new System.Windows.Forms.TextBox();
            this.lblIdJogadorSorteado = new System.Windows.Forms.Label();
            this.lblIdSorteado = new System.Windows.Forms.Label();
            this.lblValorCarta = new System.Windows.Forms.Label();
            this.tmrIniciarAutomacao = new System.Windows.Forms.Timer(this.components);
            this.btnIniciarAutomacao = new System.Windows.Forms.Button();
            this.lblVez = new System.Windows.Forms.Label();
            this.lblVezTitulo = new System.Windows.Forms.Label();
            this.lxtStatusRodadaTitulo = new System.Windows.Forms.Label();
            this.lblStatusRodada = new System.Windows.Forms.Label();
            this.lstJogadas = new System.Windows.Forms.ListBox();
            this.btnJogadas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(30, 605);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(135, 39);
            this.btnVoltar.TabIndex = 0;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblPartida
            // 
            this.lblPartida.AutoSize = true;
            this.lblPartida.Location = new System.Drawing.Point(87, 9);
            this.lblPartida.Name = "lblPartida";
            this.lblPartida.Size = new System.Drawing.Size(10, 16);
            this.lblPartida.TabIndex = 1;
            this.lblPartida.Text = ".";
            // 
            // lblIdPartida
            // 
            this.lblIdPartida.AutoSize = true;
            this.lblIdPartida.Location = new System.Drawing.Point(16, 9);
            this.lblIdPartida.Name = "lblIdPartida";
            this.lblIdPartida.Size = new System.Drawing.Size(69, 16);
            this.lblIdPartida.TabIndex = 2;
            this.lblIdPartida.Text = "ID Partida:";
            // 
            // lblIdJogadorUm
            // 
            this.lblIdJogadorUm.AutoSize = true;
            this.lblIdJogadorUm.Location = new System.Drawing.Point(20, 71);
            this.lblIdJogadorUm.Name = "lblIdJogadorUm";
            this.lblIdJogadorUm.Size = new System.Drawing.Size(49, 16);
            this.lblIdJogadorUm.TabIndex = 3;
            this.lblIdJogadorUm.Text = "Meu ID";
            // 
            // txtMeuId
            // 
            this.txtMeuId.Location = new System.Drawing.Point(75, 65);
            this.txtMeuId.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMeuId.Name = "txtMeuId";
            this.txtMeuId.Size = new System.Drawing.Size(100, 22);
            this.txtMeuId.TabIndex = 4;
            // 
            // btnMostrarCartas
            // 
            this.btnMostrarCartas.Location = new System.Drawing.Point(30, 562);
            this.btnMostrarCartas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnMostrarCartas.Name = "btnMostrarCartas";
            this.btnMostrarCartas.Size = new System.Drawing.Size(135, 39);
            this.btnMostrarCartas.TabIndex = 33;
            this.btnMostrarCartas.Text = "Mostrar Cartas";
            this.btnMostrarCartas.UseVisualStyleBackColor = true;
            this.btnMostrarCartas.Click += new System.EventHandler(this.btnMostrarCartas_Click);
            // 
            // blbSenhaJogadorUm
            // 
            this.blbSenhaJogadorUm.AutoSize = true;
            this.blbSenhaJogadorUm.Location = new System.Drawing.Point(20, 100);
            this.blbSenhaJogadorUm.Name = "blbSenhaJogadorUm";
            this.blbSenhaJogadorUm.Size = new System.Drawing.Size(83, 16);
            this.blbSenhaJogadorUm.TabIndex = 34;
            this.blbSenhaJogadorUm.Text = "Minha senha";
            // 
            // txtMinhaSenha
            // 
            this.txtMinhaSenha.Location = new System.Drawing.Point(109, 94);
            this.txtMinhaSenha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMinhaSenha.Name = "txtMinhaSenha";
            this.txtMinhaSenha.Size = new System.Drawing.Size(100, 22);
            this.txtMinhaSenha.TabIndex = 35;
            // 
            // lblIdJogadorSorteado
            // 
            this.lblIdJogadorSorteado.AutoSize = true;
            this.lblIdJogadorSorteado.Location = new System.Drawing.Point(19, 39);
            this.lblIdJogadorSorteado.Name = "lblIdJogadorSorteado";
            this.lblIdJogadorSorteado.Size = new System.Drawing.Size(130, 16);
            this.lblIdJogadorSorteado.TabIndex = 38;
            this.lblIdJogadorSorteado.Text = "ID jogador sorteado:";
            // 
            // lblIdSorteado
            // 
            this.lblIdSorteado.AutoSize = true;
            this.lblIdSorteado.Location = new System.Drawing.Point(155, 39);
            this.lblIdSorteado.Name = "lblIdSorteado";
            this.lblIdSorteado.Size = new System.Drawing.Size(10, 16);
            this.lblIdSorteado.TabIndex = 39;
            this.lblIdSorteado.Text = ".";
            // 
            // lblValorCarta
            // 
            this.lblValorCarta.AutoSize = true;
            this.lblValorCarta.Location = new System.Drawing.Point(873, 167);
            this.lblValorCarta.Name = "lblValorCarta";
            this.lblValorCarta.Size = new System.Drawing.Size(10, 16);
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
            this.btnIniciarAutomacao.Location = new System.Drawing.Point(30, 519);
            this.btnIniciarAutomacao.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnIniciarAutomacao.Name = "btnIniciarAutomacao";
            this.btnIniciarAutomacao.Size = new System.Drawing.Size(135, 39);
            this.btnIniciarAutomacao.TabIndex = 46;
            this.btnIniciarAutomacao.Text = "Iniciar Automação";
            this.btnIniciarAutomacao.UseVisualStyleBackColor = true;
            this.btnIniciarAutomacao.Click += new System.EventHandler(this.btnIniciarAutomacao_Click);
            // 
            // lblVez
            // 
            this.lblVez.AutoSize = true;
            this.lblVez.Location = new System.Drawing.Point(59, 146);
            this.lblVez.Name = "lblVez";
            this.lblVez.Size = new System.Drawing.Size(10, 16);
            this.lblVez.TabIndex = 47;
            this.lblVez.Text = ".";
            // 
            // lblVezTitulo
            // 
            this.lblVezTitulo.AutoSize = true;
            this.lblVezTitulo.Location = new System.Drawing.Point(20, 146);
            this.lblVezTitulo.Name = "lblVezTitulo";
            this.lblVezTitulo.Size = new System.Drawing.Size(33, 16);
            this.lblVezTitulo.TabIndex = 48;
            this.lblVezTitulo.Text = "Vez:";
            // 
            // lxtStatusRodadaTitulo
            // 
            this.lxtStatusRodadaTitulo.AutoSize = true;
            this.lxtStatusRodadaTitulo.Location = new System.Drawing.Point(20, 190);
            this.lxtStatusRodadaTitulo.Name = "lxtStatusRodadaTitulo";
            this.lxtStatusRodadaTitulo.Size = new System.Drawing.Size(113, 16);
            this.lxtStatusRodadaTitulo.TabIndex = 49;
            this.lxtStatusRodadaTitulo.Text = "Status da rodada:";
            // 
            // lblStatusRodada
            // 
            this.lblStatusRodada.AutoSize = true;
            this.lblStatusRodada.Location = new System.Drawing.Point(136, 190);
            this.lblStatusRodada.Name = "lblStatusRodada";
            this.lblStatusRodada.Size = new System.Drawing.Size(10, 16);
            this.lblStatusRodada.TabIndex = 50;
            this.lblStatusRodada.Text = ".";
            // 
            // lstJogadas
            // 
            this.lstJogadas.FormattingEnabled = true;
            this.lstJogadas.ItemHeight = 16;
            this.lstJogadas.Location = new System.Drawing.Point(1100, 513);
            this.lstJogadas.Name = "lstJogadas";
            this.lstJogadas.Size = new System.Drawing.Size(185, 164);
            this.lstJogadas.TabIndex = 51;
            // 
            // btnJogadas
            // 
            this.btnJogadas.Location = new System.Drawing.Point(1100, 474);
            this.btnJogadas.Name = "btnJogadas";
            this.btnJogadas.Size = new System.Drawing.Size(185, 33);
            this.btnJogadas.TabIndex = 52;
            this.btnJogadas.Text = "Exibir Jogadas";
            this.btnJogadas.UseVisualStyleBackColor = true;
            this.btnJogadas.Click += new System.EventHandler(this.btnJogadas_Click);
            // 
            // frmPartida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1297, 689);
            this.Controls.Add(this.btnJogadas);
            this.Controls.Add(this.lstJogadas);
            this.Controls.Add(this.lblStatusRodada);
            this.Controls.Add(this.lxtStatusRodadaTitulo);
            this.Controls.Add(this.lblVezTitulo);
            this.Controls.Add(this.lblVez);
            this.Controls.Add(this.btnIniciarAutomacao);
            this.Controls.Add(this.lblValorCarta);
            this.Controls.Add(this.lblIdSorteado);
            this.Controls.Add(this.lblIdJogadorSorteado);
            this.Controls.Add(this.txtMinhaSenha);
            this.Controls.Add(this.blbSenhaJogadorUm);
            this.Controls.Add(this.btnMostrarCartas);
            this.Controls.Add(this.txtMeuId);
            this.Controls.Add(this.lblIdJogadorUm);
            this.Controls.Add(this.lblIdPartida);
            this.Controls.Add(this.lblPartida);
            this.Controls.Add(this.btnVoltar);
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.TextBox txtMeuId;
        private System.Windows.Forms.Button btnMostrarCartas;
        private System.Windows.Forms.Label blbSenhaJogadorUm;
        private System.Windows.Forms.TextBox txtMinhaSenha;
        private System.Windows.Forms.Label lblIdJogadorSorteado;
        private System.Windows.Forms.Label lblIdSorteado;
        private System.Windows.Forms.Label lblValorCarta;
        private System.Windows.Forms.Timer tmrIniciarAutomacao;
        private System.Windows.Forms.Button btnIniciarAutomacao;
        private System.Windows.Forms.Label lblVez;
        private System.Windows.Forms.Label lblVezTitulo;
        private System.Windows.Forms.Label lxtStatusRodadaTitulo;
        private System.Windows.Forms.Label lblStatusRodada;
        private System.Windows.Forms.ListBox lstJogadas;
        private System.Windows.Forms.Button btnJogadas;
    }
}
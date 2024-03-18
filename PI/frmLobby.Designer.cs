namespace PI
{
    partial class frmLobby
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
            this.lstPartida = new System.Windows.Forms.ListBox();
            this.lblIdPartida = new System.Windows.Forms.Label();
            this.lblNomePartida = new System.Windows.Forms.Label();
            this.lblDataPartida = new System.Windows.Forms.Label();
            this.lstJogadores = new System.Windows.Forms.ListBox();
            this.lblVersao = new System.Windows.Forms.Label();
            this.txtNomeGrupo = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtNomePartida02 = new System.Windows.Forms.TextBox();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.lblNomeGrupo = new System.Windows.Forms.Label();
            this.btnListarPartidas = new System.Windows.Forms.Button();
            this.btnCriarPartida = new System.Windows.Forms.Button();
            this.btnEntrarPartida = new System.Windows.Forms.Button();
            this.txtIdJogador = new System.Windows.Forms.TextBox();
            this.txtSenhaJogador = new System.Windows.Forms.TextBox();
            this.lblIdJogador = new System.Windows.Forms.Label();
            this.lblSenhaJogador = new System.Windows.Forms.Label();
            this.lblNomePartida02 = new System.Windows.Forms.Label();
            this.lblSenhaPartida = new System.Windows.Forms.Label();
            this.lblNomeGrupo02 = new System.Windows.Forms.Label();
            this.btnIniciarPartida = new System.Windows.Forms.Button();
            this.txtNomeJogador = new System.Windows.Forms.TextBox();
            this.lblNomeJogador = new System.Windows.Forms.Label();
            this.lblJogadorSorteado = new System.Windows.Forms.Label();
            this.lblIdSorteado = new System.Windows.Forms.Label();
            this.lblNomeSorteado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstPartida
            // 
            this.lstPartida.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lstPartida.FormattingEnabled = true;
            this.lstPartida.Location = new System.Drawing.Point(9, 56);
            this.lstPartida.Margin = new System.Windows.Forms.Padding(2);
            this.lstPartida.Name = "lstPartida";
            this.lstPartida.Size = new System.Drawing.Size(146, 238);
            this.lstPartida.TabIndex = 2;
            this.lstPartida.SelectedIndexChanged += new System.EventHandler(this.lstPartida_SelectedIndexChanged);
            // 
            // lblIdPartida
            // 
            this.lblIdPartida.AutoSize = true;
            this.lblIdPartida.Location = new System.Drawing.Point(7, 300);
            this.lblIdPartida.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdPartida.Name = "lblIdPartida";
            this.lblIdPartida.Size = new System.Drawing.Size(18, 13);
            this.lblIdPartida.TabIndex = 3;
            this.lblIdPartida.Text = "ID";
            // 
            // lblNomePartida
            // 
            this.lblNomePartida.AutoSize = true;
            this.lblNomePartida.Location = new System.Drawing.Point(7, 313);
            this.lblNomePartida.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomePartida.Name = "lblNomePartida";
            this.lblNomePartida.Size = new System.Drawing.Size(86, 13);
            this.lblNomePartida.TabIndex = 4;
            this.lblNomePartida.Text = "Nome da Partida";
            // 
            // lblDataPartida
            // 
            this.lblDataPartida.AutoSize = true;
            this.lblDataPartida.Location = new System.Drawing.Point(7, 326);
            this.lblDataPartida.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDataPartida.Name = "lblDataPartida";
            this.lblDataPartida.Size = new System.Drawing.Size(30, 13);
            this.lblDataPartida.TabIndex = 5;
            this.lblDataPartida.Text = "Data";
            // 
            // lstJogadores
            // 
            this.lstJogadores.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lstJogadores.FormattingEnabled = true;
            this.lstJogadores.Location = new System.Drawing.Point(159, 56);
            this.lstJogadores.Margin = new System.Windows.Forms.Padding(2);
            this.lstJogadores.Name = "lstJogadores";
            this.lstJogadores.Size = new System.Drawing.Size(145, 238);
            this.lstJogadores.TabIndex = 6;
            // 
            // lblVersao
            // 
            this.lblVersao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblVersao.AutoSize = true;
            this.lblVersao.Location = new System.Drawing.Point(635, 344);
            this.lblVersao.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(10, 13);
            this.lblVersao.TabIndex = 7;
            this.lblVersao.Text = ".";
            // 
            // txtNomeGrupo
            // 
            this.txtNomeGrupo.Enabled = false;
            this.txtNomeGrupo.Location = new System.Drawing.Point(405, 95);
            this.txtNomeGrupo.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomeGrupo.Name = "txtNomeGrupo";
            this.txtNomeGrupo.Size = new System.Drawing.Size(76, 20);
            this.txtNomeGrupo.TabIndex = 8;
            this.txtNomeGrupo.Text = "Berlim";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(405, 71);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(2);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(76, 20);
            this.txtSenha.TabIndex = 9;
            // 
            // txtNomePartida02
            // 
            this.txtNomePartida02.Location = new System.Drawing.Point(405, 47);
            this.txtNomePartida02.Margin = new System.Windows.Forms.Padding(2);
            this.txtNomePartida02.Name = "txtNomePartida02";
            this.txtNomePartida02.Size = new System.Drawing.Size(76, 20);
            this.txtNomePartida02.TabIndex = 10;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(119, 303);
            this.btnAtualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(75, 36);
            this.btnAtualizar.TabIndex = 12;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // lblNomeGrupo
            // 
            this.lblNomeGrupo.AutoSize = true;
            this.lblNomeGrupo.Location = new System.Drawing.Point(585, 12);
            this.lblNomeGrupo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNomeGrupo.Name = "lblNomeGrupo";
            this.lblNomeGrupo.Size = new System.Drawing.Size(70, 13);
            this.lblNomeGrupo.TabIndex = 13;
            this.lblNomeGrupo.Text = "Grupo: Berlim";
            // 
            // btnListarPartidas
            // 
            this.btnListarPartidas.Location = new System.Drawing.Point(9, 12);
            this.btnListarPartidas.Name = "btnListarPartidas";
            this.btnListarPartidas.Size = new System.Drawing.Size(76, 36);
            this.btnListarPartidas.TabIndex = 14;
            this.btnListarPartidas.Text = "Listar Partidas";
            this.btnListarPartidas.UseVisualStyleBackColor = true;
            this.btnListarPartidas.Click += new System.EventHandler(this.btnListarPartidas_Click);
            // 
            // btnCriarPartida
            // 
            this.btnCriarPartida.Location = new System.Drawing.Point(309, 118);
            this.btnCriarPartida.Name = "btnCriarPartida";
            this.btnCriarPartida.Size = new System.Drawing.Size(75, 36);
            this.btnCriarPartida.TabIndex = 15;
            this.btnCriarPartida.Text = "Criar Partida";
            this.btnCriarPartida.UseVisualStyleBackColor = true;
            this.btnCriarPartida.Click += new System.EventHandler(this.btnCriarPartida_Click);
            // 
            // btnEntrarPartida
            // 
            this.btnEntrarPartida.Location = new System.Drawing.Point(309, 180);
            this.btnEntrarPartida.Name = "btnEntrarPartida";
            this.btnEntrarPartida.Size = new System.Drawing.Size(75, 35);
            this.btnEntrarPartida.TabIndex = 16;
            this.btnEntrarPartida.Text = "Entrar";
            this.btnEntrarPartida.UseVisualStyleBackColor = true;
            this.btnEntrarPartida.Click += new System.EventHandler(this.btnEntrarPartida_Click);
            // 
            // txtIdJogador
            // 
            this.txtIdJogador.Location = new System.Drawing.Point(404, 226);
            this.txtIdJogador.Name = "txtIdJogador";
            this.txtIdJogador.Size = new System.Drawing.Size(76, 20);
            this.txtIdJogador.TabIndex = 17;
            // 
            // txtSenhaJogador
            // 
            this.txtSenhaJogador.Location = new System.Drawing.Point(404, 252);
            this.txtSenhaJogador.Name = "txtSenhaJogador";
            this.txtSenhaJogador.Size = new System.Drawing.Size(76, 20);
            this.txtSenhaJogador.TabIndex = 18;
            // 
            // lblIdJogador
            // 
            this.lblIdJogador.AutoSize = true;
            this.lblIdJogador.Location = new System.Drawing.Point(339, 229);
            this.lblIdJogador.Name = "lblIdJogador";
            this.lblIdJogador.Size = new System.Drawing.Size(59, 13);
            this.lblIdJogador.TabIndex = 19;
            this.lblIdJogador.Text = "ID Jogador";
            // 
            // lblSenhaJogador
            // 
            this.lblSenhaJogador.AutoSize = true;
            this.lblSenhaJogador.Location = new System.Drawing.Point(321, 249);
            this.lblSenhaJogador.Name = "lblSenhaJogador";
            this.lblSenhaJogador.Size = new System.Drawing.Size(79, 13);
            this.lblSenhaJogador.TabIndex = 20;
            this.lblSenhaJogador.Text = "Senha Jogador";
            // 
            // lblNomePartida02
            // 
            this.lblNomePartida02.AutoSize = true;
            this.lblNomePartida02.Location = new System.Drawing.Point(311, 54);
            this.lblNomePartida02.Name = "lblNomePartida02";
            this.lblNomePartida02.Size = new System.Drawing.Size(85, 13);
            this.lblNomePartida02.TabIndex = 21;
            this.lblNomePartida02.Text = "Nome da partida";
            // 
            // lblSenhaPartida
            // 
            this.lblSenhaPartida.AutoSize = true;
            this.lblSenhaPartida.Location = new System.Drawing.Point(311, 78);
            this.lblSenhaPartida.Name = "lblSenhaPartida";
            this.lblSenhaPartida.Size = new System.Drawing.Size(88, 13);
            this.lblSenhaPartida.TabIndex = 22;
            this.lblSenhaPartida.Text = "Senha da partida";
            // 
            // lblNomeGrupo02
            // 
            this.lblNomeGrupo02.AutoSize = true;
            this.lblNomeGrupo02.Location = new System.Drawing.Point(311, 102);
            this.lblNomeGrupo02.Name = "lblNomeGrupo02";
            this.lblNomeGrupo02.Size = new System.Drawing.Size(80, 13);
            this.lblNomeGrupo02.TabIndex = 23;
            this.lblNomeGrupo02.Text = "Nome do grupo";
            // 
            // btnIniciarPartida
            // 
            this.btnIniciarPartida.Location = new System.Drawing.Point(406, 278);
            this.btnIniciarPartida.Name = "btnIniciarPartida";
            this.btnIniciarPartida.Size = new System.Drawing.Size(75, 35);
            this.btnIniciarPartida.TabIndex = 24;
            this.btnIniciarPartida.Text = "Iniciar Partida";
            this.btnIniciarPartida.UseVisualStyleBackColor = true;
            this.btnIniciarPartida.Click += new System.EventHandler(this.btnIniciarPartida_Click);
            // 
            // txtNomeJogador
            // 
            this.txtNomeJogador.Location = new System.Drawing.Point(405, 161);
            this.txtNomeJogador.Name = "txtNomeJogador";
            this.txtNomeJogador.Size = new System.Drawing.Size(76, 20);
            this.txtNomeJogador.TabIndex = 25;
            // 
            // lblNomeJogador
            // 
            this.lblNomeJogador.AutoSize = true;
            this.lblNomeJogador.Location = new System.Drawing.Point(311, 164);
            this.lblNomeJogador.Name = "lblNomeJogador";
            this.lblNomeJogador.Size = new System.Drawing.Size(76, 13);
            this.lblNomeJogador.TabIndex = 26;
            this.lblNomeJogador.Text = "Nome Jogador";
            // 
            // lblJogadorSorteado
            // 
            this.lblJogadorSorteado.AutoSize = true;
            this.lblJogadorSorteado.Location = new System.Drawing.Point(502, 35);
            this.lblJogadorSorteado.Name = "lblJogadorSorteado";
            this.lblJogadorSorteado.Size = new System.Drawing.Size(85, 13);
            this.lblJogadorSorteado.TabIndex = 27;
            this.lblJogadorSorteado.Text = "Jogador Sortedo";
            // 
            // lblIdSorteado
            // 
            this.lblIdSorteado.AutoSize = true;
            this.lblIdSorteado.Location = new System.Drawing.Point(502, 56);
            this.lblIdSorteado.Name = "lblIdSorteado";
            this.lblIdSorteado.Size = new System.Drawing.Size(10, 13);
            this.lblIdSorteado.TabIndex = 28;
            this.lblIdSorteado.Text = ".";
            // 
            // lblNomeSorteado
            // 
            this.lblNomeSorteado.AutoSize = true;
            this.lblNomeSorteado.Location = new System.Drawing.Point(502, 74);
            this.lblNomeSorteado.Name = "lblNomeSorteado";
            this.lblNomeSorteado.Size = new System.Drawing.Size(10, 13);
            this.lblNomeSorteado.TabIndex = 29;
            this.lblNomeSorteado.Text = ".";
            // 
            // frmLobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(666, 366);
            this.Controls.Add(this.lblNomeSorteado);
            this.Controls.Add(this.lblIdSorteado);
            this.Controls.Add(this.lblJogadorSorteado);
            this.Controls.Add(this.lblNomeJogador);
            this.Controls.Add(this.txtNomeJogador);
            this.Controls.Add(this.btnIniciarPartida);
            this.Controls.Add(this.lblNomeGrupo02);
            this.Controls.Add(this.lblSenhaPartida);
            this.Controls.Add(this.lblNomePartida02);
            this.Controls.Add(this.lblSenhaJogador);
            this.Controls.Add(this.lblIdJogador);
            this.Controls.Add(this.txtSenhaJogador);
            this.Controls.Add(this.txtIdJogador);
            this.Controls.Add(this.btnEntrarPartida);
            this.Controls.Add(this.btnCriarPartida);
            this.Controls.Add(this.btnListarPartidas);
            this.Controls.Add(this.lblNomeGrupo);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.txtNomePartida02);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtNomeGrupo);
            this.Controls.Add(this.lblVersao);
            this.Controls.Add(this.lstJogadores);
            this.Controls.Add(this.lblDataPartida);
            this.Controls.Add(this.lblNomePartida);
            this.Controls.Add(this.lblIdPartida);
            this.Controls.Add(this.lstPartida);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmLobby";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lobby";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstPartida;
        private System.Windows.Forms.Label lblIdPartida;
        private System.Windows.Forms.Label lblNomePartida;
        private System.Windows.Forms.Label lblDataPartida;
        private System.Windows.Forms.ListBox lstJogadores;
        private System.Windows.Forms.Label lblVersao;
        private System.Windows.Forms.TextBox txtNomeGrupo;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtNomePartida02;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Label lblNomeGrupo;
        private System.Windows.Forms.Button btnListarPartidas;
        private System.Windows.Forms.Button btnCriarPartida;
        private System.Windows.Forms.Button btnEntrarPartida;
        private System.Windows.Forms.TextBox txtIdJogador;
        private System.Windows.Forms.TextBox txtSenhaJogador;
        private System.Windows.Forms.Label lblIdJogador;
        private System.Windows.Forms.Label lblSenhaJogador;
        private System.Windows.Forms.Label lblNomePartida02;
        private System.Windows.Forms.Label lblSenhaPartida;
        private System.Windows.Forms.Label lblNomeGrupo02;
        private System.Windows.Forms.Button btnIniciarPartida;
        private System.Windows.Forms.TextBox txtNomeJogador;
        private System.Windows.Forms.Label lblNomeJogador;
        private System.Windows.Forms.Label lblJogadorSorteado;
        private System.Windows.Forms.Label lblIdSorteado;
        private System.Windows.Forms.Label lblNomeSorteado;
    }
}


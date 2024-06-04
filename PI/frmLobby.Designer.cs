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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLobby));
            this.lstPartida = new System.Windows.Forms.ListBox();
            this.lstJogadores = new System.Windows.Forms.ListBox();
            this.lblVersao = new System.Windows.Forms.Label();
            this.txtNomeGrupo = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtNomePartida = new System.Windows.Forms.TextBox();
            this.lblNomeGrupo = new System.Windows.Forms.Label();
            this.btnListarPartidas = new System.Windows.Forms.Button();
            this.btnCriarPartida = new System.Windows.Forms.Button();
            this.btnEntrarPartida = new System.Windows.Forms.Button();
            this.txtIdJogador = new System.Windows.Forms.TextBox();
            this.txtSenhaJogador = new System.Windows.Forms.TextBox();
            this.lblIdJogador = new System.Windows.Forms.Label();
            this.lblSenhaJogador = new System.Windows.Forms.Label();
            this.lblNomePartida = new System.Windows.Forms.Label();
            this.lblSenhaPartida = new System.Windows.Forms.Label();
            this.lblNomeGrupo02 = new System.Windows.Forms.Label();
            this.btnIniciarPartida = new System.Windows.Forms.Button();
            this.txtNomeJogador = new System.Windows.Forms.TextBox();
            this.lblNomeJogador = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblIdPartida = new System.Windows.Forms.Label();
            this.txtIdPartida = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstPartida
            // 
            this.lstPartida.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lstPartida.FormattingEnabled = true;
            this.lstPartida.ItemHeight = 16;
            this.lstPartida.Location = new System.Drawing.Point(16, 66);
            this.lstPartida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstPartida.Name = "lstPartida";
            this.lstPartida.Size = new System.Drawing.Size(286, 292);
            this.lstPartida.TabIndex = 2;
            this.lstPartida.SelectedIndexChanged += new System.EventHandler(this.lstPartida_SelectedIndexChanged);
            // 
            // lstJogadores
            // 
            this.lstJogadores.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lstJogadores.FormattingEnabled = true;
            this.lstJogadores.ItemHeight = 16;
            this.lstJogadores.Location = new System.Drawing.Point(308, 66);
            this.lstJogadores.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstJogadores.Name = "lstJogadores";
            this.lstJogadores.Size = new System.Drawing.Size(192, 292);
            this.lstJogadores.TabIndex = 6;
            // 
            // lblVersao
            // 
            this.lblVersao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblVersao.AutoSize = true;
            this.lblVersao.Location = new System.Drawing.Point(992, 426);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(10, 16);
            this.lblVersao.TabIndex = 7;
            this.lblVersao.Text = ".";
            // 
            // txtNomeGrupo
            // 
            this.txtNomeGrupo.Enabled = false;
            this.txtNomeGrupo.Location = new System.Drawing.Point(628, 149);
            this.txtNomeGrupo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomeGrupo.Name = "txtNomeGrupo";
            this.txtNomeGrupo.Size = new System.Drawing.Size(100, 22);
            this.txtNomeGrupo.TabIndex = 8;
            this.txtNomeGrupo.Text = "Berlim";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(628, 119);
            this.txtSenha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(100, 22);
            this.txtSenha.TabIndex = 9;
            // 
            // txtNomePartida
            // 
            this.txtNomePartida.Location = new System.Drawing.Point(628, 92);
            this.txtNomePartida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNomePartida.Name = "txtNomePartida";
            this.txtNomePartida.Size = new System.Drawing.Size(100, 22);
            this.txtNomePartida.TabIndex = 10;
            // 
            // lblNomeGrupo
            // 
            this.lblNomeGrupo.AutoSize = true;
            this.lblNomeGrupo.Location = new System.Drawing.Point(924, 16);
            this.lblNomeGrupo.Name = "lblNomeGrupo";
            this.lblNomeGrupo.Size = new System.Drawing.Size(88, 16);
            this.lblNomeGrupo.TabIndex = 13;
            this.lblNomeGrupo.Text = "Grupo: Berlim";
            // 
            // btnListarPartidas
            // 
            this.btnListarPartidas.Location = new System.Drawing.Point(12, 16);
            this.btnListarPartidas.Margin = new System.Windows.Forms.Padding(4);
            this.btnListarPartidas.Name = "btnListarPartidas";
            this.btnListarPartidas.Size = new System.Drawing.Size(101, 44);
            this.btnListarPartidas.TabIndex = 14;
            this.btnListarPartidas.Text = "Listar Partidas";
            this.btnListarPartidas.UseVisualStyleBackColor = true;
            this.btnListarPartidas.Click += new System.EventHandler(this.btnListarPartidas_Click);
            // 
            // btnCriarPartida
            // 
            this.btnCriarPartida.Location = new System.Drawing.Point(503, 181);
            this.btnCriarPartida.Margin = new System.Windows.Forms.Padding(4);
            this.btnCriarPartida.Name = "btnCriarPartida";
            this.btnCriarPartida.Size = new System.Drawing.Size(100, 44);
            this.btnCriarPartida.TabIndex = 15;
            this.btnCriarPartida.Text = "Criar Partida";
            this.btnCriarPartida.UseVisualStyleBackColor = true;
            this.btnCriarPartida.Click += new System.EventHandler(this.btnCriarPartida_Click);
            // 
            // btnEntrarPartida
            // 
            this.btnEntrarPartida.Location = new System.Drawing.Point(503, 258);
            this.btnEntrarPartida.Margin = new System.Windows.Forms.Padding(4);
            this.btnEntrarPartida.Name = "btnEntrarPartida";
            this.btnEntrarPartida.Size = new System.Drawing.Size(100, 43);
            this.btnEntrarPartida.TabIndex = 16;
            this.btnEntrarPartida.Text = "Entrar";
            this.btnEntrarPartida.UseVisualStyleBackColor = true;
            this.btnEntrarPartida.Click += new System.EventHandler(this.btnEntrarPartida_Click);
            // 
            // txtIdJogador
            // 
            this.txtIdJogador.Location = new System.Drawing.Point(630, 306);
            this.txtIdJogador.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdJogador.Name = "txtIdJogador";
            this.txtIdJogador.Size = new System.Drawing.Size(100, 22);
            this.txtIdJogador.TabIndex = 17;
            // 
            // txtSenhaJogador
            // 
            this.txtSenhaJogador.Location = new System.Drawing.Point(630, 336);
            this.txtSenhaJogador.Margin = new System.Windows.Forms.Padding(4);
            this.txtSenhaJogador.Name = "txtSenhaJogador";
            this.txtSenhaJogador.Size = new System.Drawing.Size(100, 22);
            this.txtSenhaJogador.TabIndex = 18;
            // 
            // lblIdJogador
            // 
            this.lblIdJogador.AutoSize = true;
            this.lblIdJogador.Location = new System.Drawing.Point(545, 312);
            this.lblIdJogador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIdJogador.Name = "lblIdJogador";
            this.lblIdJogador.Size = new System.Drawing.Size(74, 16);
            this.lblIdJogador.TabIndex = 19;
            this.lblIdJogador.Text = "ID Jogador";
            // 
            // lblSenhaJogador
            // 
            this.lblSenhaJogador.AutoSize = true;
            this.lblSenhaJogador.Location = new System.Drawing.Point(519, 342);
            this.lblSenhaJogador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSenhaJogador.Name = "lblSenhaJogador";
            this.lblSenhaJogador.Size = new System.Drawing.Size(100, 16);
            this.lblSenhaJogador.TabIndex = 20;
            this.lblSenhaJogador.Text = "Senha Jogador";
            // 
            // lblNomePartida
            // 
            this.lblNomePartida.AutoSize = true;
            this.lblNomePartida.Location = new System.Drawing.Point(503, 98);
            this.lblNomePartida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomePartida.Name = "lblNomePartida";
            this.lblNomePartida.Size = new System.Drawing.Size(108, 16);
            this.lblNomePartida.TabIndex = 21;
            this.lblNomePartida.Text = "Nome da partida";
            // 
            // lblSenhaPartida
            // 
            this.lblSenhaPartida.AutoSize = true;
            this.lblSenhaPartida.Location = new System.Drawing.Point(503, 125);
            this.lblSenhaPartida.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSenhaPartida.Name = "lblSenhaPartida";
            this.lblSenhaPartida.Size = new System.Drawing.Size(110, 16);
            this.lblSenhaPartida.TabIndex = 22;
            this.lblSenhaPartida.Text = "Senha da partida";
            // 
            // lblNomeGrupo02
            // 
            this.lblNomeGrupo02.AutoSize = true;
            this.lblNomeGrupo02.Location = new System.Drawing.Point(503, 155);
            this.lblNomeGrupo02.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeGrupo02.Name = "lblNomeGrupo02";
            this.lblNomeGrupo02.Size = new System.Drawing.Size(101, 16);
            this.lblNomeGrupo02.TabIndex = 23;
            this.lblNomeGrupo02.Text = "Nome do grupo";
            // 
            // btnIniciarPartida
            // 
            this.btnIniciarPartida.Location = new System.Drawing.Point(630, 378);
            this.btnIniciarPartida.Margin = new System.Windows.Forms.Padding(4);
            this.btnIniciarPartida.Name = "btnIniciarPartida";
            this.btnIniciarPartida.Size = new System.Drawing.Size(100, 43);
            this.btnIniciarPartida.TabIndex = 24;
            this.btnIniciarPartida.Text = "Iniciar Partida";
            this.btnIniciarPartida.UseVisualStyleBackColor = true;
            this.btnIniciarPartida.Click += new System.EventHandler(this.btnIniciarPartida_Click);
            // 
            // txtNomeJogador
            // 
            this.txtNomeJogador.Location = new System.Drawing.Point(628, 234);
            this.txtNomeJogador.Margin = new System.Windows.Forms.Padding(4);
            this.txtNomeJogador.Name = "txtNomeJogador";
            this.txtNomeJogador.Size = new System.Drawing.Size(100, 22);
            this.txtNomeJogador.TabIndex = 25;
            // 
            // lblNomeJogador
            // 
            this.lblNomeJogador.AutoSize = true;
            this.lblNomeJogador.Location = new System.Drawing.Point(506, 240);
            this.lblNomeJogador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNomeJogador.Name = "lblNomeJogador";
            this.lblNomeJogador.Size = new System.Drawing.Size(98, 16);
            this.lblNomeJogador.TabIndex = 26;
            this.lblNomeJogador.Text = "Nome Jogador";
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Todas",
            "Abertas",
            "Jogando",
            "Encerradas"});
            this.cmbStatus.Location = new System.Drawing.Point(120, 26);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(121, 24);
            this.cmbStatus.TabIndex = 31;
            // 
            // lblIdPartida
            // 
            this.lblIdPartida.AutoSize = true;
            this.lblIdPartida.Location = new System.Drawing.Point(503, 69);
            this.lblIdPartida.Name = "lblIdPartida";
            this.lblIdPartida.Size = new System.Drawing.Size(84, 16);
            this.lblIdPartida.TabIndex = 32;
            this.lblIdPartida.Text = "ID da partida";
            // 
            // txtIdPartida
            // 
            this.txtIdPartida.Location = new System.Drawing.Point(628, 63);
            this.txtIdPartida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIdPartida.Name = "txtIdPartida";
            this.txtIdPartida.Size = new System.Drawing.Size(100, 22);
            this.txtIdPartida.TabIndex = 33;
            // 
            // frmLobby
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PI.Properties.Resources.lobby_2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 451);
            this.Controls.Add(this.txtIdPartida);
            this.Controls.Add(this.lblIdPartida);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.lblNomeJogador);
            this.Controls.Add(this.txtNomeJogador);
            this.Controls.Add(this.btnIniciarPartida);
            this.Controls.Add(this.lblNomeGrupo02);
            this.Controls.Add(this.lblSenhaPartida);
            this.Controls.Add(this.lblNomePartida);
            this.Controls.Add(this.lblSenhaJogador);
            this.Controls.Add(this.lblIdJogador);
            this.Controls.Add(this.txtSenhaJogador);
            this.Controls.Add(this.txtIdJogador);
            this.Controls.Add(this.btnEntrarPartida);
            this.Controls.Add(this.btnCriarPartida);
            this.Controls.Add(this.btnListarPartidas);
            this.Controls.Add(this.lblNomeGrupo);
            this.Controls.Add(this.txtNomePartida);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtNomeGrupo);
            this.Controls.Add(this.lblVersao);
            this.Controls.Add(this.lstJogadores);
            this.Controls.Add(this.lstPartida);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmLobby";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lobby";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox lstPartida;
        private System.Windows.Forms.ListBox lstJogadores;
        private System.Windows.Forms.Label lblVersao;
        private System.Windows.Forms.TextBox txtNomeGrupo;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtNomePartida;
        private System.Windows.Forms.Label lblNomeGrupo;
        private System.Windows.Forms.Button btnListarPartidas;
        private System.Windows.Forms.Button btnCriarPartida;
        private System.Windows.Forms.Button btnEntrarPartida;
        private System.Windows.Forms.TextBox txtIdJogador;
        private System.Windows.Forms.TextBox txtSenhaJogador;
        private System.Windows.Forms.Label lblIdJogador;
        private System.Windows.Forms.Label lblSenhaJogador;
        private System.Windows.Forms.Label lblNomePartida;
        private System.Windows.Forms.Label lblSenhaPartida;
        private System.Windows.Forms.Label lblNomeGrupo02;
        private System.Windows.Forms.Button btnIniciarPartida;
        private System.Windows.Forms.TextBox txtNomeJogador;
        private System.Windows.Forms.Label lblNomeJogador;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblIdPartida;
        private System.Windows.Forms.TextBox txtIdPartida;
    }
}


namespace PI
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lstPartida = new System.Windows.Forms.ListBox();
            this.lblIdPartida = new System.Windows.Forms.Label();
            this.lblNomePartida = new System.Windows.Forms.Label();
            this.lblDataPartida = new System.Windows.Forms.Label();
            this.lstJogadores = new System.Windows.Forms.ListBox();
            this.lblVersao = new System.Windows.Forms.Label();
            this.txtNomeGrupo = new System.Windows.Forms.TextBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.txtPlayers = new System.Windows.Forms.TextBox();
            this.btnInserir = new System.Windows.Forms.Button();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(12, 12);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(83, 47);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Partidas";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lstPartida
            // 
            this.lstPartida.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lstPartida.FormattingEnabled = true;
            this.lstPartida.ItemHeight = 16;
            this.lstPartida.Location = new System.Drawing.Point(12, 65);
            this.lstPartida.Name = "lstPartida";
            this.lstPartida.Size = new System.Drawing.Size(232, 292);
            this.lstPartida.TabIndex = 2;
            this.lstPartida.SelectedIndexChanged += new System.EventHandler(this.lstPartida_SelectedIndexChanged);
            // 
            // lblIdPartida
            // 
            this.lblIdPartida.AutoSize = true;
            this.lblIdPartida.Location = new System.Drawing.Point(9, 369);
            this.lblIdPartida.Name = "lblIdPartida";
            this.lblIdPartida.Size = new System.Drawing.Size(20, 16);
            this.lblIdPartida.TabIndex = 3;
            this.lblIdPartida.Text = "ID";
            // 
            // lblNomePartida
            // 
            this.lblNomePartida.AutoSize = true;
            this.lblNomePartida.Location = new System.Drawing.Point(9, 385);
            this.lblNomePartida.Name = "lblNomePartida";
            this.lblNomePartida.Size = new System.Drawing.Size(109, 16);
            this.lblNomePartida.TabIndex = 4;
            this.lblNomePartida.Text = "Nome da Partida";
            // 
            // lblDataPartida
            // 
            this.lblDataPartida.AutoSize = true;
            this.lblDataPartida.Location = new System.Drawing.Point(9, 401);
            this.lblDataPartida.Name = "lblDataPartida";
            this.lblDataPartida.Size = new System.Drawing.Size(36, 16);
            this.lblDataPartida.TabIndex = 5;
            this.lblDataPartida.Text = "Data";
            // 
            // lstJogadores
            // 
            this.lstJogadores.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lstJogadores.FormattingEnabled = true;
            this.lstJogadores.ItemHeight = 16;
            this.lstJogadores.Location = new System.Drawing.Point(250, 65);
            this.lstJogadores.Name = "lstJogadores";
            this.lstJogadores.Size = new System.Drawing.Size(192, 292);
            this.lstJogadores.TabIndex = 6;
            this.lstJogadores.SelectedIndexChanged += new System.EventHandler(this.lstJogadores_SelectedIndexChanged);
            // 
            // lblVersao
            // 
            this.lblVersao.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblVersao.AutoSize = true;
            this.lblVersao.Location = new System.Drawing.Point(9, 425);
            this.lblVersao.Name = "lblVersao";
            this.lblVersao.Size = new System.Drawing.Size(0, 16);
            this.lblVersao.TabIndex = 7;
            // 
            // txtNomeGrupo
            // 
            this.txtNomeGrupo.Location = new System.Drawing.Point(448, 75);
            this.txtNomeGrupo.Name = "txtNomeGrupo";
            this.txtNomeGrupo.Size = new System.Drawing.Size(100, 22);
            this.txtNomeGrupo.TabIndex = 8;
            this.txtNomeGrupo.Text = "Nome";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(448, 103);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(100, 22);
            this.txtSenha.TabIndex = 9;
            this.txtSenha.Text = "senha";
            // 
            // txtPlayers
            // 
            this.txtPlayers.Location = new System.Drawing.Point(448, 131);
            this.txtPlayers.Name = "txtPlayers";
            this.txtPlayers.Size = new System.Drawing.Size(100, 22);
            this.txtPlayers.TabIndex = 10;
            this.txtPlayers.Text = "jogadores";
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(448, 159);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(100, 44);
            this.btnInserir.TabIndex = 11;
            this.btnInserir.Text = "Salvar";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Location = new System.Drawing.Point(448, 209);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(100, 44);
            this.btnAtualizar.TabIndex = 12;
            this.btnAtualizar.Text = "Atualizar";
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(709, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 16);
            this.label1.TabIndex = 13;
            this.label1.Text = "Grupo: Berlim";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAtualizar);
            this.Controls.Add(this.btnInserir);
            this.Controls.Add(this.txtPlayers);
            this.Controls.Add(this.txtSenha);
            this.Controls.Add(this.txtNomeGrupo);
            this.Controls.Add(this.lblVersao);
            this.Controls.Add(this.lstJogadores);
            this.Controls.Add(this.lblDataPartida);
            this.Controls.Add(this.lblNomePartida);
            this.Controls.Add(this.lblIdPartida);
            this.Controls.Add(this.lstPartida);
            this.Controls.Add(this.btnSalvar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ListBox lstPartida;
        private System.Windows.Forms.Label lblIdPartida;
        private System.Windows.Forms.Label lblNomePartida;
        private System.Windows.Forms.Label lblDataPartida;
        private System.Windows.Forms.ListBox lstJogadores;
        private System.Windows.Forms.Label lblVersao;
        private System.Windows.Forms.TextBox txtNomeGrupo;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.TextBox txtPlayers;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.Label label1;
    }
}


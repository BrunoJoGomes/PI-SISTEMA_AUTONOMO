﻿namespace PI
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
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblPartida = new System.Windows.Forms.Label();
            this.lblIdPartida = new System.Windows.Forms.Label();
            this.lblIdJogadorUm = new System.Windows.Forms.Label();
            this.txtIdJogadorUm = new System.Windows.Forms.TextBox();
            this.lblIdJogadorDois = new System.Windows.Forms.Label();
            this.txtIdJogadorDois = new System.Windows.Forms.TextBox();
            this.lstCartas = new System.Windows.Forms.ListBox();
            this.btnMostrarCartas = new System.Windows.Forms.Button();
            this.blbSenhaJogadorUm = new System.Windows.Forms.Label();
            this.txtSenhaJogadorUm = new System.Windows.Forms.TextBox();
            this.lblSenhaJogadorDois = new System.Windows.Forms.Label();
            this.txtSenhaJogadorDois = new System.Windows.Forms.TextBox();
            this.lblIdJogadorSorteado = new System.Windows.Forms.Label();
            this.lblIdSorteado = new System.Windows.Forms.Label();
            this.grpJogar = new System.Windows.Forms.GroupBox();
            this.grpApostar = new System.Windows.Forms.GroupBox();
            this.btnJogar = new System.Windows.Forms.Button();
            this.btnApostar = new System.Windows.Forms.Button();
            this.lblIdJogadorJogando = new System.Windows.Forms.Label();
            this.txtIdJogadorJogando = new System.Windows.Forms.TextBox();
            this.txtSenhaJogadorJogando = new System.Windows.Forms.TextBox();
            this.lblSenhaJogadorJogando = new System.Windows.Forms.Label();
            this.txtPosicaoCarta = new System.Windows.Forms.TextBox();
            this.lblPosicaoCarta = new System.Windows.Forms.Label();
            this.txtCartaApostada = new System.Windows.Forms.TextBox();
            this.lblCartaApostada = new System.Windows.Forms.Label();
            this.grpJogar.SuspendLayout();
            this.grpApostar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(13, 398);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(85, 34);
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
            this.lblIdJogadorUm.Location = new System.Drawing.Point(20, 72);
            this.lblIdJogadorUm.Name = "lblIdJogadorUm";
            this.lblIdJogadorUm.Size = new System.Drawing.Size(83, 16);
            this.lblIdJogadorUm.TabIndex = 3;
            this.lblIdJogadorUm.Text = "ID jogador 1:";
            // 
            // txtIdJogadorUm
            // 
            this.txtIdJogadorUm.Location = new System.Drawing.Point(137, 66);
            this.txtIdJogadorUm.Name = "txtIdJogadorUm";
            this.txtIdJogadorUm.Size = new System.Drawing.Size(100, 22);
            this.txtIdJogadorUm.TabIndex = 4;
            // 
            // lblIdJogadorDois
            // 
            this.lblIdJogadorDois.AutoSize = true;
            this.lblIdJogadorDois.Location = new System.Drawing.Point(20, 163);
            this.lblIdJogadorDois.Name = "lblIdJogadorDois";
            this.lblIdJogadorDois.Size = new System.Drawing.Size(83, 16);
            this.lblIdJogadorDois.TabIndex = 5;
            this.lblIdJogadorDois.Text = "ID jogador 2:";
            // 
            // txtIdJogadorDois
            // 
            this.txtIdJogadorDois.Location = new System.Drawing.Point(137, 158);
            this.txtIdJogadorDois.Name = "txtIdJogadorDois";
            this.txtIdJogadorDois.Size = new System.Drawing.Size(100, 22);
            this.txtIdJogadorDois.TabIndex = 6;
            // 
            // lstCartas
            // 
            this.lstCartas.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lstCartas.FormattingEnabled = true;
            this.lstCartas.ItemHeight = 16;
            this.lstCartas.Location = new System.Drawing.Point(308, 9);
            this.lstCartas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstCartas.Name = "lstCartas";
            this.lstCartas.Size = new System.Drawing.Size(192, 292);
            this.lstCartas.TabIndex = 32;
            // 
            // btnMostrarCartas
            // 
            this.btnMostrarCartas.Location = new System.Drawing.Point(339, 319);
            this.btnMostrarCartas.Name = "btnMostrarCartas";
            this.btnMostrarCartas.Size = new System.Drawing.Size(119, 40);
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
            this.blbSenhaJogadorUm.Size = new System.Drawing.Size(109, 16);
            this.blbSenhaJogadorUm.TabIndex = 34;
            this.blbSenhaJogadorUm.Text = "Senha jogador 1:";
            // 
            // txtSenhaJogadorUm
            // 
            this.txtSenhaJogadorUm.Location = new System.Drawing.Point(137, 94);
            this.txtSenhaJogadorUm.Name = "txtSenhaJogadorUm";
            this.txtSenhaJogadorUm.Size = new System.Drawing.Size(100, 22);
            this.txtSenhaJogadorUm.TabIndex = 35;
            // 
            // lblSenhaJogadorDois
            // 
            this.lblSenhaJogadorDois.AutoSize = true;
            this.lblSenhaJogadorDois.Location = new System.Drawing.Point(20, 196);
            this.lblSenhaJogadorDois.Name = "lblSenhaJogadorDois";
            this.lblSenhaJogadorDois.Size = new System.Drawing.Size(109, 16);
            this.lblSenhaJogadorDois.TabIndex = 36;
            this.lblSenhaJogadorDois.Text = "Senha jogador 2:";
            // 
            // txtSenhaJogadorDois
            // 
            this.txtSenhaJogadorDois.Location = new System.Drawing.Point(137, 190);
            this.txtSenhaJogadorDois.Name = "txtSenhaJogadorDois";
            this.txtSenhaJogadorDois.Size = new System.Drawing.Size(100, 22);
            this.txtSenhaJogadorDois.TabIndex = 37;
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
            // grpJogar
            // 
            this.grpJogar.Controls.Add(this.txtPosicaoCarta);
            this.grpJogar.Controls.Add(this.lblPosicaoCarta);
            this.grpJogar.Controls.Add(this.txtSenhaJogadorJogando);
            this.grpJogar.Controls.Add(this.lblSenhaJogadorJogando);
            this.grpJogar.Controls.Add(this.txtIdJogadorJogando);
            this.grpJogar.Controls.Add(this.lblIdJogadorJogando);
            this.grpJogar.Controls.Add(this.btnJogar);
            this.grpJogar.Location = new System.Drawing.Point(520, 12);
            this.grpJogar.Name = "grpJogar";
            this.grpJogar.Size = new System.Drawing.Size(262, 172);
            this.grpJogar.TabIndex = 40;
            this.grpJogar.TabStop = false;
            this.grpJogar.Text = "Jogar";
            // 
            // grpApostar
            // 
            this.grpApostar.Controls.Add(this.txtCartaApostada);
            this.grpApostar.Controls.Add(this.lblCartaApostada);
            this.grpApostar.Controls.Add(this.btnApostar);
            this.grpApostar.Location = new System.Drawing.Point(520, 190);
            this.grpApostar.Name = "grpApostar";
            this.grpApostar.Size = new System.Drawing.Size(262, 141);
            this.grpApostar.TabIndex = 41;
            this.grpApostar.TabStop = false;
            this.grpApostar.Text = "Apostar";
            // 
            // btnJogar
            // 
            this.btnJogar.Location = new System.Drawing.Point(77, 134);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(85, 32);
            this.btnJogar.TabIndex = 0;
            this.btnJogar.Text = "Jogar";
            this.btnJogar.UseVisualStyleBackColor = true;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // btnApostar
            // 
            this.btnApostar.Location = new System.Drawing.Point(77, 93);
            this.btnApostar.Name = "btnApostar";
            this.btnApostar.Size = new System.Drawing.Size(85, 32);
            this.btnApostar.TabIndex = 1;
            this.btnApostar.Text = "Apostar";
            this.btnApostar.UseVisualStyleBackColor = true;
            this.btnApostar.Click += new System.EventHandler(this.btnApostar_Click);
            // 
            // lblIdJogadorJogando
            // 
            this.lblIdJogadorJogando.AutoSize = true;
            this.lblIdJogadorJogando.Location = new System.Drawing.Point(7, 26);
            this.lblIdJogadorJogando.Name = "lblIdJogadorJogando";
            this.lblIdJogadorJogando.Size = new System.Drawing.Size(73, 16);
            this.lblIdJogadorJogando.TabIndex = 1;
            this.lblIdJogadorJogando.Text = "ID jogador:";
            // 
            // txtIdJogadorJogando
            // 
            this.txtIdJogadorJogando.Location = new System.Drawing.Point(112, 20);
            this.txtIdJogadorJogando.Name = "txtIdJogadorJogando";
            this.txtIdJogadorJogando.Size = new System.Drawing.Size(100, 22);
            this.txtIdJogadorJogando.TabIndex = 2;
            // 
            // txtSenhaJogadorJogando
            // 
            this.txtSenhaJogadorJogando.Location = new System.Drawing.Point(112, 57);
            this.txtSenhaJogadorJogando.Name = "txtSenhaJogadorJogando";
            this.txtSenhaJogadorJogando.Size = new System.Drawing.Size(100, 22);
            this.txtSenhaJogadorJogando.TabIndex = 4;
            // 
            // lblSenhaJogadorJogando
            // 
            this.lblSenhaJogadorJogando.AutoSize = true;
            this.lblSenhaJogadorJogando.Location = new System.Drawing.Point(7, 63);
            this.lblSenhaJogadorJogando.Name = "lblSenhaJogadorJogando";
            this.lblSenhaJogadorJogando.Size = new System.Drawing.Size(99, 16);
            this.lblSenhaJogadorJogando.TabIndex = 3;
            this.lblSenhaJogadorJogando.Text = "Senha jogador:";
            // 
            // txtPosicaoCarta
            // 
            this.txtPosicaoCarta.Location = new System.Drawing.Point(112, 91);
            this.txtPosicaoCarta.Name = "txtPosicaoCarta";
            this.txtPosicaoCarta.Size = new System.Drawing.Size(100, 22);
            this.txtPosicaoCarta.TabIndex = 6;
            // 
            // lblPosicaoCarta
            // 
            this.lblPosicaoCarta.AutoSize = true;
            this.lblPosicaoCarta.Location = new System.Drawing.Point(7, 97);
            this.lblPosicaoCarta.Name = "lblPosicaoCarta";
            this.lblPosicaoCarta.Size = new System.Drawing.Size(95, 16);
            this.lblPosicaoCarta.TabIndex = 5;
            this.lblPosicaoCarta.Text = "Posição Carta:";
            // 
            // txtCartaApostada
            // 
            this.txtCartaApostada.Location = new System.Drawing.Point(112, 35);
            this.txtCartaApostada.Name = "txtCartaApostada";
            this.txtCartaApostada.Size = new System.Drawing.Size(100, 22);
            this.txtCartaApostada.TabIndex = 8;
            // 
            // lblCartaApostada
            // 
            this.lblCartaApostada.AutoSize = true;
            this.lblCartaApostada.Location = new System.Drawing.Point(7, 41);
            this.lblCartaApostada.Name = "lblCartaApostada";
            this.lblCartaApostada.Size = new System.Drawing.Size(95, 16);
            this.lblCartaApostada.TabIndex = 7;
            this.lblCartaApostada.Text = "Posição Carta:";
            // 
            // frmPartida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 450);
            this.Controls.Add(this.grpApostar);
            this.Controls.Add(this.grpJogar);
            this.Controls.Add(this.lblIdSorteado);
            this.Controls.Add(this.lblIdJogadorSorteado);
            this.Controls.Add(this.txtSenhaJogadorDois);
            this.Controls.Add(this.lblSenhaJogadorDois);
            this.Controls.Add(this.txtSenhaJogadorUm);
            this.Controls.Add(this.blbSenhaJogadorUm);
            this.Controls.Add(this.btnMostrarCartas);
            this.Controls.Add(this.lstCartas);
            this.Controls.Add(this.txtIdJogadorDois);
            this.Controls.Add(this.lblIdJogadorDois);
            this.Controls.Add(this.txtIdJogadorUm);
            this.Controls.Add(this.lblIdJogadorUm);
            this.Controls.Add(this.lblIdPartida);
            this.Controls.Add(this.lblPartida);
            this.Controls.Add(this.btnVoltar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmPartida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Partida";
            this.grpJogar.ResumeLayout(false);
            this.grpJogar.PerformLayout();
            this.grpApostar.ResumeLayout(false);
            this.grpApostar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Label lblPartida;
        private System.Windows.Forms.Label lblIdPartida;
        private System.Windows.Forms.Label lblIdJogadorUm;
        private System.Windows.Forms.TextBox txtIdJogadorUm;
        private System.Windows.Forms.Label lblIdJogadorDois;
        private System.Windows.Forms.TextBox txtIdJogadorDois;
        private System.Windows.Forms.ListBox lstCartas;
        private System.Windows.Forms.Button btnMostrarCartas;
        private System.Windows.Forms.Label blbSenhaJogadorUm;
        private System.Windows.Forms.TextBox txtSenhaJogadorUm;
        private System.Windows.Forms.Label lblSenhaJogadorDois;
        private System.Windows.Forms.TextBox txtSenhaJogadorDois;
        private System.Windows.Forms.Label lblIdJogadorSorteado;
        private System.Windows.Forms.Label lblIdSorteado;
        private System.Windows.Forms.GroupBox grpJogar;
        private System.Windows.Forms.GroupBox grpApostar;
        private System.Windows.Forms.Label lblIdJogadorJogando;
        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.Button btnApostar;
        private System.Windows.Forms.TextBox txtSenhaJogadorJogando;
        private System.Windows.Forms.Label lblSenhaJogadorJogando;
        private System.Windows.Forms.TextBox txtIdJogadorJogando;
        private System.Windows.Forms.TextBox txtPosicaoCarta;
        private System.Windows.Forms.Label lblPosicaoCarta;
        private System.Windows.Forms.TextBox txtCartaApostada;
        private System.Windows.Forms.Label lblCartaApostada;
    }
}
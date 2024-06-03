using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;
using MagicTrickServer;

namespace PI
{
    public partial class frmLobby : Form
    {
        public string nomeDoGrupo = "Berlim";
        private string meuId;
        private string minhaSenha;
        private string idMatch;
        private string idDrawn;
        string[] infoPartidas;


        Partida partida = new Partida();
        Jogador jogador = new Jogador();


        public frmLobby()
        {
            InitializeComponent();
            lblVersao.Text = Jogo.Versao;
            cmbStatus.SelectedIndex = 0;



        }

        private void btnCriarPartida_Click(object sender, EventArgs e)
        {
            partida.nomeDaPartida = txtNomePartida.Text;
            partida.senhaDaPartida = txtSenha.Text;
            partida.CriarPartida(nomeDoGrupo);
            txtIdPartida.Text = partida.idDaPartida;
        }

        private void lstPartida_SelectedIndexChanged(object sender, EventArgs e)
        {

            string partida = lstPartida.SelectedItem.ToString();
            infoPartidas = partida.Split(',');
            string dataPartida = infoPartidas[2];

            txtIdPartida.Text = infoPartidas[0];
            txtNomePartida.Text = infoPartidas[1];


            string retorno = Jogo.ListarJogadores(Convert.ToInt32(txtIdPartida.Text));
            if (partida.Substring(0, 4) == "ERRO")
            {
                MessageBox.Show("Ocorreu um erro! \n" + partida.Substring(5), "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                retorno = retorno.Replace("\r", "");
                string[] players = retorno.Split('\n');

                lstJogadores.Items.Clear();
                for (int i = 0; i < players.Length; i++)
                {
                    lstJogadores.Items.Add(players[i]);
                }
            }
        }

        private void btnListarPartidas_Click(object sender, EventArgs e)
        {
            string retorno = "-1";
            switch (cmbStatus.SelectedIndex){
                case 0: retorno = Jogo.ListarPartidas("T");
                    break;
                case 1:
                    retorno = Jogo.ListarPartidas("A");
                    break;
                case 2:
                    retorno = Jogo.ListarPartidas("J");
                    break;
                case 3:
                    retorno = Jogo.ListarPartidas("E");
                    break;
            }

            if (retorno.Substring(0,4) == "ERRO")
            {
                MessageBox.Show("Ocorreu um erro! \n" + retorno.Substring(5), "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                retorno = retorno.Replace("\r", "");
                string[] partidas = retorno.Split('\n');

                lstPartida.Items.Clear();
                for (int i = 0; i < partidas.Length - 1; i++)
                {
                    lstPartida.Items.Add(partidas[i]);
                }
            }
        }


        private void btnEntrarPartida_Click(object sender, EventArgs e)
        {

            jogador.nomeDoJogador = txtNomeJogador.Text;
            partida.idDaPartida = txtIdPartida.Text;
            partida.nomeDaPartida = txtNomePartida.Text;
            partida.senhaDaPartida = txtSenha.Text;
            jogador.EntrarNaPartida(Convert.ToInt32(partida.idDaPartida),partida.senhaDaPartida);
            txtIdJogador.Text = jogador.idDoJogador;
            txtSenhaJogador.Text = jogador.senhaDoJogador;
           
        }

        private void btnIniciarPartida_Click(object sender, EventArgs e)
        {
            frmPartida formPartida = new frmPartida();
            if (infoPartidas[3] == "A")
            {

                string jogadorSorteado = Jogo.IniciarPartida(Convert.ToInt32(txtIdJogador.Text), txtSenhaJogador.Text);


                idDrawn = jogadorSorteado;

                idMatch = txtIdPartida.Text;

                meuId = jogador.idDoJogador;
                minhaSenha = jogador.senhaDoJogador;
                formPartida.idPartida = idMatch;
                formPartida.meuId = meuId;
                formPartida.minhaSenha = minhaSenha;
                formPartida.idJogadorSorteado = idDrawn;
                formPartida.AtualizarTela();
                formPartida.ShowDialog();

            }
            else if (infoPartidas[3] == "J")
            {
                meuId = jogador.idDoJogador;
                minhaSenha = jogador.senhaDoJogador;
                formPartida.idPartida = partida.idDaPartida;
                formPartida.meuId = meuId;
                formPartida.minhaSenha = minhaSenha;
                formPartida.idJogadorSorteado = idDrawn;
                formPartida.AtualizarTela();
                formPartida.ShowDialog();
            }
        }
    }
}

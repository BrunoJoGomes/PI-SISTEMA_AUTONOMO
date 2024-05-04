using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MagicTrickServer;

namespace PI
{
    public partial class frmLobby : Form
    {
        public string nomeDoGrupo = "Berlim";
        //public int idPartida;
        //public string senhaPartida;
        private string idPlayerOne;
        private string idPlayerTwo;
        private string passwordPlayerOne;
        private string passwordPlayerTwo;
        private string idMatch;
        private string idDrawn;
        List<string> senhas = new List<string>();

        Partida partida = new Partida();
        Jogador jogador = new Jogador();


        public frmLobby()
        {
            InitializeComponent();
            lblVersao.Text = Jogo.Versao;

        }

        int[] idJogadores = new int[4];

        private void btnCriarPartida_Click(object sender, EventArgs e)
        {

            
            
            partida.nomeDaPartida = txtNomePartida02.Text;
            partida.senhaDaPartida = txtSenha.Text;
            partida.CriarPartida(nomeDoGrupo);
            //lblIdPartida.Text = partida.idDaPartida;
            //idPartida = Convert.ToInt32(partida.idDaPartida);
            //senhaPartida = partida.senhaDaPartida;
            //lblNomePartida.Text = partida.nomeDaPartida;
            //lblSenhaPartida.Text = partida.senhaDaPartida;


        }

        private void lstPartida_SelectedIndexChanged(object sender, EventArgs e)
        {
            string partida = lstPartida.SelectedItem.ToString();
            string[] infoPartidas = partida.Split(',');
            string dataPartida = infoPartidas[2];

            lblIdPartida.Text = infoPartidas[0];
            lblNomePartida.Text = infoPartidas[1];
            lblDataPartida.Text = infoPartidas[2];

            string retorno = Jogo.ListarJogadores(Convert.ToInt32(lblIdPartida.Text));
            if (partida.Substring(0, 3) == "ERRO")
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

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            string retorno = Jogo.ListarPartidas("T");
            if (retorno.Substring(0, 3) == "ERRO")
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

        private void btnListarPartidas_Click(object sender, EventArgs e)
        {
            string retorno = Jogo.ListarPartidas("T");
            if (retorno.Substring(0,3) == "ERRO")
            {
                MessageBox.Show("Ocorreu um erro! \n" + retorno.Substring(5), "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                retorno = retorno.Replace("\r", "");
                //retorno  = retorno.Substring(0, retorno.Length - 1);
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
            jogador.EntrarNaPartida(Convert.ToInt32(partida.idDaPartida),partida.senhaDaPartida);
            txtIdJogador.Text = jogador.idDoJogador;
            txtSenhaJogador.Text = jogador.senhaDoJogador;
           
        }

        private void btnIniciarPartida_Click(object sender, EventArgs e)
        {
            //INSTANCIA DO NOVO FORMS
            frmPartida formPartida = new frmPartida();

            string jogadorSorteado = Jogo.IniciarPartida(Convert.ToInt32(txtIdJogador.Text),txtSenhaJogador.Text);

            string retorno = Jogo.ListarJogadores(Convert.ToInt32(partida.idDaPartida));
            retorno = retorno.Replace("\r", "");
            string[] players = retorno.Split('\n');

            lblIdSorteado.Text = jogadorSorteado;
            idDrawn = lblIdSorteado.Text;

            string substring;
            for (int i = 0; i < players.Length - 1; i++)
            {
                substring = players[i].Substring(0, 4);

                if ( substring == jogadorSorteado)
                {
                    lblNomeSorteado.Text = players[i].Substring(5);
                }
            }

            idMatch = lblIdPartida.Text;
            string[] idJogadores = new string[2];
            for (int i = 0; i < players.Length - 1; i++)
            {
                idJogadores[i] = players[i].Substring(0,4);
                            
            }

            //idPlayerOne = idJogadores[0];
            //idPlayerTwo = idJogadores[1];
            //passwordPlayerOne = senhas[0];
            //passwordPlayerTwo = senhas[1];
            idPlayerOne = jogador.idDoJogador;
            passwordPlayerOne = jogador.senhaDoJogador;
            formPartida.idPartida = idMatch;
            formPartida.idJogadorUm = idPlayerOne;
            formPartida.senhaJogadorUm = passwordPlayerOne;
            formPartida.idJogadorDois = idPlayerTwo;
            formPartida.senhaJogadorDois = passwordPlayerTwo;
            formPartida.idJogadorSorteado = idDrawn;
            formPartida.AtualizarTela();
            formPartida.ShowDialog();

        }

        
    }
}

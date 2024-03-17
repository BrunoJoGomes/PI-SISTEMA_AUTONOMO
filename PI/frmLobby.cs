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
        public frmLobby()
        {
            InitializeComponent();
            lblVersao.Text = Jogo.Versao;
        }


        private void lstPartida_SelectedIndexChanged(object sender, EventArgs e)
        {
            string partida = lstPartida.SelectedItem.ToString();
            string[] infoPartidas = partida.Split(',');

            int idPartida = Convert.ToInt32(infoPartidas[0]);
            string nomePartida = infoPartidas[1];
            string dataPartida = infoPartidas[2];

            lblIdPartida.Text = idPartida.ToString();
            lblNomePartida.Text = nomePartida;
            lblDataPartida.Text = dataPartida;

            string retorno = Jogo.ListarJogadores(idPartida);
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

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            string retorno = Jogo.ListarPartidas("T");
            if (retorno.Substring(0, 4) == "ERRO")
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
            if (retorno.Substring(0, 4) == "ERRO")
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

        private void btnCriarPartida_Click(object sender, EventArgs e)
        {   
            string player = txtPlayers.Text;
            string senha = txtSenha.Text;
            string grupo = txtNomeGrupo.Text;
            string retorno = Jogo.CriarPartida(player, senha, grupo);
            if (retorno.Substring(0, 4) == "ERRO")
            {
                MessageBox.Show("Ocorreu um erro! \n" + retorno.Substring(5), "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Grupo salvo", "SUCESSO");
            }
        }

        private void btnEntrarPartida_Click(object sender, EventArgs e)
        {
            int idPartida = Convert.ToInt32(lblIdPartida.Text);
            string player = txtPlayers.Text;
            string senha = txtSenha.Text;
            string partida = Jogo.EntrarPartida(idPartida, player, senha);
            if (partida.Substring(0,4) == "ERRO")
            {
                MessageBox.Show("Ocorreu um erro! \n" + partida.Substring(5), "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                partida = partida.Replace("\r", "");
                string[] informacoes = partida.Split(',');
                txtIdJogador.Text = informacoes[0];
                txtSenhaJogador.Text = informacoes[1];
            }
           
        }

        private void btnIniciarPartida_Click(object sender, EventArgs e)
        {
            frmPartida formPartida = new frmPartida();
            formPartida.Show();
        }
    }
}

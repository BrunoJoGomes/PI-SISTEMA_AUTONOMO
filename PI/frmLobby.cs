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

        int[] idJogadores = new int[4];

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

        private void btnCriarPartida_Click(object sender, EventArgs e)
        {   
            string partida = txtNomePartida02.Text;
            string senha = txtSenha.Text;
            string grupo = txtNomeGrupo.Text;
            string retorno = Jogo.CriarPartida(partida, senha, grupo);
            if (retorno.Substring(0, 3) == "ERRO")
            {
                MessageBox.Show("Ocorreu um erro! \n" + retorno.Substring(5), "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Grupo salvo", "SUCESSO!");
            }
        }

        private void btnEntrarPartida_Click(object sender, EventArgs e)
        {
            int idPartida = Convert.ToInt32(lblIdPartida.Text);
            string jogador = txtNomeJogador.Text;
            string senha = txtSenha.Text;
            string partida = Jogo.EntrarPartida(idPartida, jogador, senha);
            if (partida.Substring(0, 3) == "ERRO")
            {
                MessageBox.Show("Ocorreu um erro! \n" + partida.Substring(5), "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                partida = partida.Replace("\r", "");
                string[] informacoes = partida.Split(',');
                txtIdJogador.Text = informacoes[0];
                txtSenhaJogador.Text = informacoes[1];
                //idJogadores = 
            }
           
        }

        private void btnIniciarPartida_Click(object sender, EventArgs e)
        {
            //INSTANCIA DO NOVO FORMS
            //frmPartida formPartida = new frmPartida();
            //formPartida.Show();

            int idJogador = Convert.ToInt32(txtIdJogador.Text);
            string senhaJogador = txtSenhaJogador.Text;
            string jogadorSorteado = Jogo.IniciarPartida(idJogador, senhaJogador);

            int idPartida = Convert.ToInt32(lblIdPartida.Text);
            string retorno = Jogo.ListarJogadores(idPartida);
            retorno = retorno.Replace("\r", "");
            string[] players = retorno.Split('\n');

            lblIdSorteado.Text = jogadorSorteado;
            //int inicio = 0;
            //int fim = 3;

            //string substring;
            //for (int i = 0; i < 4; i++)
            //{
            //    substring = players[i].Substring(inicio, fim);
            //    //MessageBox.Show(players[i].Substring(inicio, fim) + "\n");

            //    if (substring == jogadorSorteado)
            //    {
            //        lblNomeSorteado.Text = players[i];
            //    }
            //}

        }
    }
}

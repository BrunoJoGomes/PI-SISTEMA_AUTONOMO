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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblVersao.Text = Jogo.Versao;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string retorno = Jogo.ListarPartidas("T");
            retorno = retorno.Replace("\r", "");            
            //retorno  = retorno.Substring(0, retorno.Length - 1);
            string[] partidas = retorno.Split('\n');

            lstPartida.Items.Clear();
            for (int i = 0; i < partidas.Length - 1; i++)
            {
                lstPartida.Items.Add(partidas[i]);
            }
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
            retorno = retorno.Replace("\n", "");
            string[] players = retorno.Split('\n');

            lstJogadores.Items.Clear();
            for (int i = 0; i < players.Length; i++)
            {
                lstJogadores.Items.Add(players[i]);
            }



        }

        private void lstJogadores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            string player = txtPlayers.Text;
            string senha = txtSenha.Text;
            string grupo = txtNomeGrupo.Text;
            string retorno = Jogo.CriarPartida(grupo, senha, player);

            MessageBox.Show("Grupo salvo");
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            string retorno = Jogo.ListarPartidas("T");
            retorno = retorno.Replace("\r", "");
            string[] partidas = retorno.Split('\n');

            lstPartida.Items.Clear();
            for (int i = 0; i < partidas.Length - 1; i++)
            {
                lstPartida.Items.Add(partidas[i]);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

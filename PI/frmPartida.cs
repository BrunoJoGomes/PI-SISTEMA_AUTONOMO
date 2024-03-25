using MagicTrickServer;
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
    public partial class frmPartida : Form
    {
        public string idJogadorUm { get; set; }
        public string idJogadorDois { get; set; }
        public string senhaJogadorUm { get; set; }
        public string senhaJogadorDois { get; set; }
        public string idPartida { get; set; }
        public string idJogadorSorteado { get; set; }

        public frmPartida()
        {
            InitializeComponent();
            frmLobby frmLobby = new frmLobby();
            
        }

        public void AtualizarTela()
        {
            lblPartida.Text = idPartida;
            txtIdJogadorUm.Text = idJogadorUm;
            txtSenhaJogadorUm.Text = senhaJogadorUm;
            txtIdJogadorDois.Text = idJogadorDois; 
            txtSenhaJogadorDois.Text = senhaJogadorDois;
            lblIdSorteado.Text = idJogadorSorteado;

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMostrarCartas_Click(object sender, EventArgs e)
        {
            Console.WriteLine(lblPartida.Text);
            int idpartida = Convert.ToInt32(lblPartida.Text);
            string retorno = Jogo.ConsultarMao(idpartida);

            retorno = retorno.Replace("\r", "");
            string[] cartas = retorno.Split('\n');

            lstCartas.Items.Clear();
            for (int i = 0; i < cartas.Length - 1; i++)
            {
                lstCartas.Items.Add(cartas[i]);
            }
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            int idJogadorJogando = Convert.ToInt32(txtIdJogadorJogando.Text);
            string senhaJogadorJogando = txtSenhaJogadorJogando.Text;
            int posicaoCartaJogada = Convert.ToInt32(txtPosicaoCarta.Text);

            string valorCarta = Jogo.Jogar(idJogadorJogando, senhaJogadorJogando, posicaoCartaJogada);
            MessageBox.Show("Valor da carta jogada: " + valorCarta);
        }

        private void btnApostar_Click(object sender, EventArgs e)
        {
            int idJogadorApostando = Convert.ToInt32(txtIdJogadorJogando.Text);
            string senhaJogadorApostando = txtSenhaJogadorJogando.Text;
            int cartaApostada = Convert.ToInt32(txtCartaApostada.Text);

            string valorCartaApostada = Jogo.Apostar(idJogadorApostando, senhaJogadorApostando, cartaApostada);
            if (valorCartaApostada == "0")
            {
                MessageBox.Show("Pulou a aposta!");
            }
            else
            {
                MessageBox.Show("Carta Apostada: " + valorCartaApostada);
            }
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MagicTrickServer;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;


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

        public string idDaPartida;


        Carta carta1 = new Carta();
        Carta carta2 = new Carta();
        Carta carta3 = new Carta();
        Carta carta4 = new Carta();
        Carta carta5 = new Carta();
        Carta carta6 = new Carta();
        Carta carta7 = new Carta();
        Carta carta8 = new Carta();
        Carta carta9 = new Carta();
        Carta carta10 = new Carta();
        Carta carta11 = new Carta();
        Carta carta12 = new Carta();

        


        List<Carta> listaDeCartas = new List<Carta>();

        List<Carta> listaDeCartasJogadas = new List<Carta>();

        string informacoes;
        string[] dadosRodada;
        string statusPartida;
        string idJogadorDaVez;
        string numRodada;
        string statusRodada;
        

        public frmPartida()
        {
            InitializeComponent();
            frmLobby frmLobby = new frmLobby();
            listaDeCartas.Add(null);
            listaDeCartas.Add(carta1);
            listaDeCartas.Add(carta2);
            listaDeCartas.Add(carta3);
            listaDeCartas.Add(carta4);
            listaDeCartas.Add(carta5);
            listaDeCartas.Add(carta6);
            listaDeCartas.Add(carta7);
            listaDeCartas.Add(carta8);
            listaDeCartas.Add(carta9);
            listaDeCartas.Add(carta10);
            listaDeCartas.Add(carta11);
            listaDeCartas.Add(carta12);

        }

        public void AtualizarTela()
        {
            lblPartida.Text = idPartida;
            idDaPartida = idPartida;
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

        string[] cartas = new string[24];


        private void btnMostrarCartas_Click(object sender, EventArgs e)
        {
            Console.WriteLine(lblPartida.Text);
            int idpartida = Convert.ToInt32(lblPartida.Text);
            string retorno = Jogo.ConsultarMao(idpartida);
            AtualizarCampos();


            retorno = retorno.Replace("\r", "");
            cartas = retorno.Split('\n');

            string[] naipes = new string[13];

            for (int i = 1; i <= 12; i++)
            {
                if (i <= 9)
                {
                    naipes[i] = cartas[i-1].Substring(8);
                }
                else
                {
                    naipes[i] = cartas[i-1].Substring(9);
                }
            }

            for(int i = 1; i <= 12; i++)
            {
                if (i == 1)
                {
                    listaDeCartas[i].naipe = naipes[i];
                    Console.WriteLine($"Carta {i} = naipe {listaDeCartas[i].naipe}");
                    listaDeCartas[i].Top = 360;
                    listaDeCartas[i].Left = 190;
                    listaDeCartas[i].posicao = i;
                    listaDeCartas[i].DescobrirImagem();
                    this.Controls.Add(listaDeCartas[i]);
                }
                else
                {
                    listaDeCartas[i].naipe = naipes[i];
                    Console.WriteLine($"Carta {i} = naipe {listaDeCartas[i].naipe}");
                    listaDeCartas[i].Top = 360;
                    listaDeCartas[i].posicao = i;
                    //listaDeCartas[i].Left = listaDeCartas[0].Width + 60;
                    listaDeCartas[i].DescobrirImagem();
                    //this.Controls.Add(listaDeCartas[i]);
                }
            }

            listaDeCartas[2].Left = listaDeCartas[1].Width + 200;
            listaDeCartas[3].Left = listaDeCartas[1].Width + 260;
            listaDeCartas[4].Left = listaDeCartas[1].Width + 320;
            listaDeCartas[5].Left = listaDeCartas[1].Width + 380;
            listaDeCartas[6].Left = listaDeCartas[1].Width + 440;
            listaDeCartas[7].Left = listaDeCartas[1].Width + 500;
            listaDeCartas[8].Left = listaDeCartas[1].Width + 560;
            listaDeCartas[9].Left = listaDeCartas[1].Width + 620;
            listaDeCartas[10].Left = listaDeCartas[1].Width + 680;
            listaDeCartas[11].Left = listaDeCartas[1].Width + 740;
            listaDeCartas[12].Left = listaDeCartas[1].Width + 800;

            for (int i = 2; i <= 12; i++)
            {
                this.Controls.Add(listaDeCartas[i]);
            }

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


            Carta cartaJogada = listaDeCartas[posicaoCartaJogada - 1];
            cartaJogada.Top = 100;
            cartaJogada.Left = 750;
            lblValorCarta.Text = valorCarta;

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

        int rodada = 1;
        int pontuacaoAnterior = 0;
        int pontuacaoAtual = 0;
        private void Automacao()
        {
            AtualizarCampos();
            pontuacaoAnterior = pontuacaoAtual;
            pontuacaoAtual = Pontuacao();


            if (ConsultarVez())
            {
                
                int idJogadorJogando = Convert.ToInt32(idJogadorUm);
                string senhaJogadorJogando = senhaJogadorUm;
                string informacoes = Jogo.ExibirJogadas2(Convert.ToInt32(idDaPartida));
                // [0] ROUND
                // [1] Id do Jogador
                // [2] Naipe 
                // [3] Valor
                // [4] Posição
                Console.WriteLine(informacoes);
                string[] infos = informacoes.Split(',');

                if (rodada == 1)
                {
                    Console.WriteLine("Eu começo!");
                    int posicaoCartaJogada = 6;
                    string valorCarta = Jogo.Jogar(idJogadorJogando, senhaJogadorJogando, posicaoCartaJogada);
                    MessageBox.Show("Valor da carta jogada: " + valorCarta);


                    Carta cartaJogada = listaDeCartas[posicaoCartaJogada];
                    listaDeCartasJogadas.Add(cartaJogada);
                    cartaJogada.Top = 100;
                    cartaJogada.Left = 750;
                    listaDeCartas[posicaoCartaJogada] = null;
                    lblValorCarta.Text = valorCarta;

                    AtualizarCampos();
                    int idJogadorApostando = Convert.ToInt32(idJogadorUm);
                    string senhaJogadorApostando = senhaJogadorUm;
                    txtCartaApostada.Text = "0";
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


                    rodada++;

                }
                else //Quando é a vez do bot mas não é a primeira jogada da partida
                {

                    
                    AtualizarCampos();
                    //// [0] ROUND
                    //// [1] Id do Jogador
                    //// [2] Naipe 
                    //// [3] Valor
                    //// [4] Posição
                    for (int i = 0; i < infos.Length; i++)
                    {
                        Console.WriteLine(infos[i]);
                    }

                    if (pontuacaoAtual == pontuacaoAnterior) //Bot não ganhou ou ainda pode ganhar
                    {
                        int posicao = ComparaNaipes(listaDeCartas, infos);
                        Console.WriteLine(posicao);

                        txtPosicaoCarta.Text = posicao.ToString();
                        string valorCarta = Jogo.Jogar(idJogadorJogando, senhaJogadorJogando, posicao);
                        MessageBox.Show("Valor da carta jogada: " + valorCarta);

                        Carta cartaJogada = listaDeCartas[posicao];
                        listaDeCartasJogadas.Add(cartaJogada);
                        cartaJogada.Top = 100;
                        cartaJogada.Left = 750;
                        listaDeCartas[posicao] = null;
                        lblValorCarta.Text = valorCarta;

                        AtualizarCampos();

                        int idJogadorApostando = Convert.ToInt32(idJogadorUm);
                        string senhaJogadorApostando = senhaJogadorUm;
                        txtCartaApostada.Text = "0";
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
                    else //bot ganhou ultima rodada, pode escolher qualquer carta para jogar
                    {
                        MessageBox.Show("Eu escolho a carta agora!");
                    }

                }
                AtualizarCampos();
            }
            else
            {
                rodada++;
            }
        }


        public int Pontuacao()
        {
            string dados = Jogo.ListarJogadores2(Convert.ToInt32(idPartida));
            string[] dadosPontuacao = dados.Split(',');

            for (int i = 0; i < dadosPontuacao.Length; i++)
            {
                Console.WriteLine($"DADOS: {dadosPontuacao[i]}");
                Console.WriteLine($"Pontuação atual: {dadosPontuacao[dadosPontuacao.Length - 5]}");
            }

            return Convert.ToInt32(dadosPontuacao[dadosPontuacao.Length-5]);
        }

        public int ComparaNaipes(List<Carta> cartas, string[] naipe)
        {
            Console.WriteLine($"Naipe jogado pelo adversário é {naipe[naipe.Length-3]}");
            for (int i = 1; i <= 12; i++)
            {
                if (cartas[i] != null)
                {
                    if (cartas[i].naipe.ToString() == naipe[naipe.Length - 3])
                    {
                        Console.WriteLine($"Comparação de naipe: {cartas[i].naipe} = {naipe[naipe.Length - 3]}, posição {i}");

                        return i;
                    }
                }

            }
            return -1;
        }

        private void AtualizarCampos()
        {
            
            informacoes = Jogo.VerificarVez2(Convert.ToInt32(idDaPartida));
            dadosRodada = informacoes.Split(',');
            statusPartida = dadosRodada[0];
            idJogadorDaVez = dadosRodada[1];
            numRodada = dadosRodada[2];
            statusRodada = dadosRodada[3];
            lblVez.Text = idJogadorDaVez;
            lblStatusRodada.Text = "";
            lblStatusRodada.Text = statusRodada;
        }

        public bool ConsultarVez()
        {
            informacoes = Jogo.VerificarVez2(Convert.ToInt32(idDaPartida));
            dadosRodada = informacoes.Split(',');
            idJogadorDaVez = dadosRodada[1];
            if (idJogadorDaVez == idJogadorUm)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void tmrIniciarAutomacao_Tick(object sender, EventArgs e)
        {
            tmrIniciarAutomacao.Enabled = false;
            Automacao();
            tmrIniciarAutomacao.Enabled = true;
        }

        private void btnIniciarAutomacao_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Automação iniciada");
            tmrIniciarAutomacao.Enabled = true;
        }
    }
}

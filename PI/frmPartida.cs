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

        string informacoes;
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
            informacoes = Jogo.VerificarVez2(idpartida);
            statusPartida = informacoes.Substring(0);
            idJogadorDaVez = informacoes.Substring(2, 3);
            numRodada = informacoes.Substring(5,1);
            statusRodada = informacoes.Substring(8,1);
            lblVez.Text = idJogadorDaVez;
            lblStatusRodada.Text = statusRodada;
            txtIdJogadorJogando.Text = idJogadorUm;
            txtSenhaJogadorJogando.Text = senhaJogadorUm;





            retorno = retorno.Replace("\r", "");
            cartas = retorno.Split('\n');

            string[] naipes = new string[13];

            for (int i = 1; i <= 12; i++)
            {
                if (i <= 9)
                {
                    naipes[i] = cartas[i-1].Substring(7);
                }
                else
                {
                    naipes[i] = cartas[i-1].Substring(8);
                }
            }


            //carta1.naipe = cartas[0].Substring(7);
            ////carta1.naipe = "O"; 
            //carta1.Top = 360;
            //carta1.Left = 190;
            //carta1.DescobrirImagem();

            //foreach(Carta carta in listaDeCartas)
            //{
            //    carta.naipe = naipes[i];
            //}

            for(int i = 1; i <= 12; i++)
            {
                if (i == 1)
                {
                    listaDeCartas[i].naipe = naipes[i];
                    listaDeCartas[i].Top = 360;
                    listaDeCartas[i].Left = 190;
                    listaDeCartas[i].posicao = i;
                    listaDeCartas[i].DescobrirImagem();
                    this.Controls.Add(listaDeCartas[i]);
                }
                else
                {
                    listaDeCartas[i].naipe = naipes[i];
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

            //MessageBox.Show(carta1.naipe);
            //MessageBox.Show(carta1.Top.ToString());
            //MessageBox.Show(carta1.Left.ToString());


            //string[] naipes = new string[24];

            //for(int i = 0; i < 10; i++)
            //{
            //    naipes[i] = cartas[i].Substring(8);
            //}


            //string[] cartasJogador1 = new string[12];
            //string[] cartasJogador2 = new string[12];

            //for(int i = 0; i < 12; i++)
            //{
            //    cartasJogador1[i] = cartas[i];
            //}

            //for (int i = 12; i < 24; i++)
            //{
            //    cartasJogador2[i] = cartas[i];
            //}




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
        private void ConsultarVez()
        {
            AtualizarCampos();
            if (idJogadorDaVez == txtIdJogadorJogando.Text) 
            {
                //txtIdJogadorJogando.Text = txtIdJogadorUm.Text.Substring(0, 3);
                //txtSenhaJogadorJogando.Text = txtSenhaJogadorUm.Text;
                //txtPosicaoCarta.Text = "0";
                //int idJogadorJogando = Convert.ToInt32(txtIdJogadorJogando.Text.Substring(0, 3));
                //string senhaJogadorJogando = txtSenhaJogadorJogando.Text;
                ////int posicaoCartaJogada = Convert.ToInt32(txtPosicaoCarta.Text);
                int idJogadorJogando = Convert.ToInt32(txtIdJogadorJogando.Text);
                string senhaJogadorJogando = txtSenhaJogadorJogando.Text;
                if (rodada == 1)
                {
                    txtPosicaoCarta.Text = "6";
                    int posicaoCartaJogada = Convert.ToInt32(txtPosicaoCarta.Text);
                    string valorCarta = Jogo.Jogar(idJogadorJogando, senhaJogadorJogando, posicaoCartaJogada);
                    MessageBox.Show("Valor da carta jogada: " + valorCarta);


                    Carta cartaJogada = listaDeCartas[posicaoCartaJogada];
                    cartaJogada.Top = 100;
                    cartaJogada.Left = 750;
                    lblValorCarta.Text = valorCarta;
                    int idJogadorApostando = Convert.ToInt32(txtIdJogadorJogando.Text);
                    string senhaJogadorApostando = txtSenhaJogadorJogando.Text;
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
                else
                {
                    string informacoes = Jogo.ExibirJogadas2(Convert.ToInt32(idDaPartida));
                    // [0] ROUND
                    // [1] Id do Jogador
                    // [2] Naipe 
                    // [3] Valor
                    // [4] Posição
                    string[] infos = informacoes.Split(',');

                    
                        for(int i = 1; i <= 12; i++)
                        {
                            
                            if (listaDeCartas[i].naipe == infos[2])
                            {
                                
                                txtPosicaoCarta.Text = i.ToString();
                                int posicaoCartaJogada = Convert.ToInt32(txtPosicaoCarta.Text);
                                string valorCarta = Jogo.Jogar(idJogadorJogando, senhaJogadorJogando, posicaoCartaJogada);
                                MessageBox.Show("Valor da carta jogada: " + valorCarta);


                                Carta cartaJogada = listaDeCartas[posicaoCartaJogada];
                                cartaJogada.Top = 100;
                                cartaJogada.Left = 750;
                                lblValorCarta.Text = valorCarta;
                                int idJogadorApostando = Convert.ToInt32(txtIdJogadorJogando.Text);
                                string senhaJogadorApostando = txtSenhaJogadorJogando.Text;
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
                        }



                    //string valorCarta = Jogo.Jogar(idJogadorJogando, senhaJogadorJogando, posicaoCartaJogada);
                    //MessageBox.Show("Valor da carta jogada: " + valorCarta);


                    //Carta cartaJogada = listaDeCartas[posicaoCartaJogada - 1];
                    //cartaJogada.Top = 100;
                    //cartaJogada.Left = 750;
                    //lblValorCarta.Text = valorCarta;
                    rodada++;
                }





                //string valorCarta = Jogo.Jogar(idJogadorJogando, senhaJogadorJogando,1);
                //MessageBox.Show("Valor da carta jogada: " + valorCarta);


                //Panel cartaJogada = paineis[posicaoCartaJogada - 1];
                //Panel cartaJogada = paineis[0];
                //cartaJogada.Top = 100;
                //cartaJogada.Left = 750;
                //lblValorCarta.Text = valorCarta;

                AtualizarCampos();

                //int idJogadorApostando = Convert.ToInt32(txtIdJogadorJogando.Text);
                //string senhaJogadorApostando = txtSenhaJogadorJogando.Text;
                //txtCartaApostada.Text = "0";
                //int cartaApostada = Convert.ToInt32(txtCartaApostada.Text);

                //string valorCartaApostada = Jogo.Apostar(idJogadorApostando, senhaJogadorApostando, cartaApostada);
                //if (valorCartaApostada == "0")
                //{
                //    MessageBox.Show("Pulou a aposta!");
                //}
                //else
                //{
                //    MessageBox.Show("Carta Apostada: " + valorCartaApostada);
                //}


                //AtualizarCampos();
            }
            
        }

        private void AtualizarCampos()
        {
            
            informacoes = Jogo.VerificarVez2(Convert.ToInt32(idDaPartida));
            statusPartida = informacoes.Substring(0);
            idJogadorDaVez = informacoes.Substring(2, 4);
            numRodada = informacoes.Substring(5, 1);
            statusRodada = informacoes.Substring(8, 1);
            lblVez.Text = idJogadorDaVez;
            lblStatusRodada.Text = statusRodada;

        }

        private void tmrIniciarAutomacao_Tick(object sender, EventArgs e)
        {
            ConsultarVez();
            //AtualizarCampos();
            
        }

        private void btnIniciarAutomacao_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Automação iniciada");
            tmrIniciarAutomacao.Enabled = true;
        }
    }
}

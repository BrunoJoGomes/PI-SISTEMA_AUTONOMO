using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
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
       

        public string meuId { get; set; }
        public string minhaSenha { get; set; }
        public string idPartida { get; set; }
        public string idJogadorSorteado { get; set; }

        public string idDaPartida;


        string[] adversario = new string[3];
        string[] adversario2 = new string[3];
        string[] adversario3 = new string[3];





        List<Carta> minhaListaDeCartas = new List<Carta>();

        List<Carta> listaDeCartasAdversario = new List<Carta>();

        List<Carta> listaDeCartasAdversario2 = new List<Carta>();

        List<Carta> listaDeCartasAdversario3 = new List<Carta>();


        string informacoes;
        string[] dadosRodada;
        string statusPartida;
        string idJogadorDaVez;
        string numRodada;
        string statusRodada;


        string[] vetorJogadores;



        public frmPartida()
        {
            InitializeComponent();
            frmLobby frmLobby = new frmLobby();

        }

        public void AtualizarTela()
        {
            lblPartida.Text = idPartida;
            idDaPartida = idPartida;
            txtMeuId.Text = meuId;
            txtMinhaSenha.Text = minhaSenha;
            lblIdSorteado.Text = idJogadorSorteado;

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        string[] cartas = new string[48];


        private void btnMostrarCartas_Click(object sender, EventArgs e)
        {
            int idpartida = Convert.ToInt32(idPartida);
            AtualizarCampos();

            string jogadores = Jogo.ListarJogadores(idpartida);
            vetorJogadores = jogadores.Split('\n');

            

            //Caso tenham 2 jogadores
            if (vetorJogadores.Length <= 3)
            {

                List<string> idJogadorAdversario = new List<string>();
                

                foreach (string jogador in vetorJogadores)
                {
                    if (jogador.StartsWith(meuId) != true)
                    {
                        idJogadorAdversario.Add(jogador);
                    }
                }

                //ID, Nome, Pontuação
                adversario = idJogadorAdversario[0].Split(',');
                lblAdversario.Text = adversario[1];

                for (int i = 0; i < adversario.Length; i++)
                {
                    Console.WriteLine($"Dados adversario: {adversario[i]}");
                }

                for (int i = 0; i < 13; i++)
                {
                    if(i == 0)
                    {
                        minhaListaDeCartas.Add(null);
                    }
                    else
                    {
                        minhaListaDeCartas.Add(new Carta());
                    }
                }

                for (int i = 0; i < 13; i++)
                {
                    if (i == 0)
                    {
                        listaDeCartasAdversario.Add(null);
                    }
                    else
                    {
                        listaDeCartasAdversario.Add(new Carta());
                    }
                }
                
                List<Label> lista = new List<Label>();

                //Label lbl1 = new Label();
                //lbl1.Location.X =
                Label lbl1 = new Label();
                lbl1.Location = new Point(350,360);
                lbl1.Height = 16;
                lbl1.Width = 10;
                lbl1.Text = "10";
                lbl1.Visible = true;
                //lbl1.Location.X = 500;
                Controls.Add(lbl1);


                string retorno = Jogo.ConsultarMao(idpartida);


                retorno = retorno.Replace("\r", "");
                cartas = retorno.Split('\n');

                for (int i = 0; i < cartas.Length; i++)
                {
                    Console.WriteLine(cartas[i]);
                }

                List<string> maoDeCartas = new List<string>();
                maoDeCartas.Add(null);

                List<string> maoDeCartasAdversario = new List<string>();
                maoDeCartasAdversario.Add(null);

                foreach (string item in cartas)
                {
                    if (item.StartsWith(meuId))
                    {
                        maoDeCartas.Add(item);
                    }
                    else
                    {
                        maoDeCartasAdversario.Add(item);
                    }
                }

                for (int i = 1; i < maoDeCartas.Count; i++)
                {
                    Console.WriteLine($"Mão de cartas {maoDeCartas[i]} posição {i}");

                }


                for (int i = 1; i < minhaListaDeCartas.Count; i++) //Percorre lista de cartas
                {

                    minhaListaDeCartas[i].naipe = maoDeCartas[i].Substring(maoDeCartas[i].Length - 1);
                    Console.WriteLine($"O naipe da posição {i} é {minhaListaDeCartas[i].naipe}");
                }

                for (int i = 1; i < listaDeCartasAdversario.Count; i++) //Percorre lista de cartas adversario
                {

                    listaDeCartasAdversario[i].naipe = maoDeCartasAdversario[i].Substring(maoDeCartas[i].Length - 1);
                    Console.WriteLine($"O naipe da posição {i} é {listaDeCartasAdversario[i].naipe}");
                }


                for (int i = 1; i < minhaListaDeCartas.Count; i++)
                {
                    if (i == 1)
                    {
                        Console.WriteLine($"Carta {i} = naipe {minhaListaDeCartas[i].naipe}");
                        minhaListaDeCartas[i].Left = 350;
                        minhaListaDeCartas[i].posicao = i;
                        minhaListaDeCartas[i].DescobrirImagem();
                        this.Controls.Add(minhaListaDeCartas[i]);
                    }
                    else if (i == 7)
                    {
                        Console.WriteLine($"Carta {i} = naipe {minhaListaDeCartas[i].naipe}");
                        minhaListaDeCartas[i].posicao = i;
                        minhaListaDeCartas[i].Left = 350;
                        minhaListaDeCartas[i].DescobrirImagem();
                        this.Controls.Add(minhaListaDeCartas[i]);
                    }
                    else
                    {
                        Console.WriteLine($"Carta {i} = naipe {minhaListaDeCartas[i].naipe}");
                        minhaListaDeCartas[i].posicao = i;
                        minhaListaDeCartas[i].Left = minhaListaDeCartas[i - 1].Left + 60;
                        minhaListaDeCartas[i].DescobrirImagem();
                        this.Controls.Add(minhaListaDeCartas[i]);
                    }
                }

                for (int i = 1; i < minhaListaDeCartas.Count; i++)
                {
                    if (i <= 6)
                    {
                        minhaListaDeCartas[i].Top = 360;
                    }
                    else
                    {
                        minhaListaDeCartas[i].Top = 460;
                    }

                }

                for (int i = 1; i < listaDeCartasAdversario.Count; i++)
                {
                    if (i == 1)
                    {
                        Console.WriteLine($"Carta {i} = naipe {listaDeCartasAdversario[i].naipe}");
                        listaDeCartasAdversario[i].Left = 350;
                        listaDeCartasAdversario[i].posicao = i;
                        listaDeCartasAdversario[i].DescobrirImagem();
                        this.Controls.Add(listaDeCartasAdversario[i]);
                    }
                    else if (i == 7)
                    {
                        Console.WriteLine($"Carta {i} = naipe {listaDeCartasAdversario[i].naipe}");
                        listaDeCartasAdversario[i].posicao = i;
                        listaDeCartasAdversario[i].Left = 350;
                        listaDeCartasAdversario[i].DescobrirImagem();
                        this.Controls.Add(listaDeCartasAdversario[i]);
                    }
                    else
                    {
                        Console.WriteLine($"Carta {i} = naipe {listaDeCartasAdversario[i].naipe}");
                        listaDeCartasAdversario[i].posicao = i;
                        listaDeCartasAdversario[i].Left = listaDeCartasAdversario[i - 1].Left + 60;
                        listaDeCartasAdversario[i].DescobrirImagem();
                        this.Controls.Add(listaDeCartasAdversario[i]);
                    }
                }

                for (int i = 1; i < listaDeCartasAdversario.Count; i++)
                {
                    if (i <= 6)
                    {
                        listaDeCartasAdversario[i].Top = 40;
                    }
                    else
                    {
                        listaDeCartasAdversario[i].Top = 140;
                    }

                }
            }
            else
            {
                List<string> idJogadorAdversario = new List<string>();


                foreach (string jogador in vetorJogadores)
                {
                    if (jogador.StartsWith(meuId) != true)
                    {
                        idJogadorAdversario.Add(jogador);
                    }
                }

                adversario = idJogadorAdversario[0].Split(',');
                adversario2 = idJogadorAdversario[1].Split(',');
                adversario3 = idJogadorAdversario[2].Split(',');

                lblAdversario.Text = adversario[1];
                lblAdversario2.Text = adversario2[1];
                lblAdversario3.Text = adversario3[1];

                for (int i = 0; i < adversario.Length; i++)
                {
                    Console.WriteLine($"Dados adversario: {adversario[i]}");
                }

                for (int i = 0; i < adversario2.Length; i++)
                {
                    Console.WriteLine($"Dados adversario: {adversario2[i]}");
                }

                for (int i = 0; i < adversario3.Length; i++)
                {
                    Console.WriteLine($"Dados adversario: {adversario3[i]}");
                }

                for (int i = 0; i < 15; i++)
                {
                    if (i == 0)
                    {
                        minhaListaDeCartas.Add(null);
                    }
                    else
                    {
                        minhaListaDeCartas.Add(new Carta());
                    }
                }

                for (int i = 0; i < 15; i++)
                {
                    if (i == 0)
                    {
                        listaDeCartasAdversario.Add(null);
                    }
                    else
                    {
                        listaDeCartasAdversario.Add(new Carta());
                    }
                }

                for (int i = 0; i < 15; i++)
                {
                    if (i == 0)
                    {
                        listaDeCartasAdversario2.Add(null);
                    }
                    else
                    {
                        listaDeCartasAdversario2.Add(new Carta());
                    }
                }

                for (int i = 0; i < 15; i++)
                {
                    if (i == 0)
                    {
                        listaDeCartasAdversario3.Add(null);
                    }
                    else
                    {
                        listaDeCartasAdversario3.Add(new Carta());
                    }
                }


                string retorno = Jogo.ConsultarMao(idpartida);


                retorno = retorno.Replace("\r", "");
                cartas = retorno.Split('\n');

                for (int i = 0; i < cartas.Length; i++)
                {
                    Console.WriteLine(cartas[i]);
                }

                List<string> maoDeCartas = new List<string>();
                maoDeCartas.Add(null);

                List<string> maoDeCartasAdversario = new List<string>();
                maoDeCartasAdversario.Add(null);

                List<string> maoDeCartasAdversario2 = new List<string>();
                maoDeCartasAdversario2.Add(null);

                List<string> maoDeCartasAdversario3 = new List<string>();
                maoDeCartasAdversario3.Add(null);

                foreach (string item in cartas)
                {
                    if (item.StartsWith(meuId))
                    {
                        maoDeCartas.Add(item);
                    }
                    else if (item.StartsWith(adversario[0]))
                    {
                        maoDeCartasAdversario.Add(item);
                    }
                    else if (item.StartsWith(adversario2[0]))
                    {
                        maoDeCartasAdversario2.Add(item);
                    }
                    else
                    {
                        maoDeCartasAdversario3.Add(item);
                    }
                }

                for (int i = 1; i < maoDeCartas.Count; i++)
                {
                    Console.WriteLine($"Mão de cartas {maoDeCartas[i]} posição {i}");

                }


                for (int i = 1; i < minhaListaDeCartas.Count; i++) //Percorre lista de cartas
                {

                    minhaListaDeCartas[i].naipe = maoDeCartas[i].Substring(maoDeCartas[i].Length - 1);
                    Console.WriteLine($"O naipe da posição {i} é {minhaListaDeCartas[i].naipe}");
                }

                for (int i = 1; i < listaDeCartasAdversario.Count; i++) //Percorre lista de cartas adversario
                {

                    listaDeCartasAdversario[i].naipe = maoDeCartasAdversario[i].Substring(maoDeCartasAdversario[i].Length - 1);
                    Console.WriteLine($"O naipe da posição {i} é {listaDeCartasAdversario[i].naipe}");
                }

                for (int i = 1; i < listaDeCartasAdversario2.Count; i++) //Percorre lista de cartas adversario
                {

                    listaDeCartasAdversario2[i].naipe = maoDeCartasAdversario2[i].Substring(maoDeCartasAdversario2[i].Length - 1);
                    Console.WriteLine($"O naipe da posição {i} é {listaDeCartasAdversario2[i].naipe}");
                }

                for (int i = 1; i < listaDeCartasAdversario3.Count; i++) //Percorre lista de cartas adversario
                {

                    listaDeCartasAdversario3[i].naipe = maoDeCartasAdversario3[i].Substring(maoDeCartasAdversario3[i].Length - 1);
                    Console.WriteLine($"O naipe da posição {i} é {listaDeCartasAdversario3[i].naipe}");
                }


                for (int i = 1; i < minhaListaDeCartas.Count; i++)
                {
                    if (i == 1)
                    {
                        Console.WriteLine($"Carta {i} = naipe {minhaListaDeCartas[i].naipe}");
                        minhaListaDeCartas[i].Left = 350;
                        minhaListaDeCartas[i].posicao = i;
                        minhaListaDeCartas[i].DescobrirImagem();
                        this.Controls.Add(minhaListaDeCartas[i]);
                    }
                    else if (i == 8)
                    {
                        Console.WriteLine($"Carta {i} = naipe {minhaListaDeCartas[i].naipe}");
                        minhaListaDeCartas[i].posicao = i;
                        minhaListaDeCartas[i].Left = 350;
                        minhaListaDeCartas[i].DescobrirImagem();
                        this.Controls.Add(minhaListaDeCartas[i]);
                    }
                    else
                    {
                        Console.WriteLine($"Carta {i} = naipe {minhaListaDeCartas[i].naipe}");
                        minhaListaDeCartas[i].posicao = i;
                        minhaListaDeCartas[i].Left = minhaListaDeCartas[i - 1].Left + 60;
                        minhaListaDeCartas[i].DescobrirImagem();
                        this.Controls.Add(minhaListaDeCartas[i]);
                    }
                }

                for (int i = 1; i < minhaListaDeCartas.Count; i++)
                {
                    if (i <= 7)
                    {
                        minhaListaDeCartas[i].Top = 360;
                    }
                    else
                    {
                        minhaListaDeCartas[i].Top = 440;
                    }

                }

                for (int i = 1; i < listaDeCartasAdversario.Count; i++)
                {
                    if (i == 1)
                    {
                        Console.WriteLine($"Carta {i} = naipe {listaDeCartasAdversario[i].naipe}");
                        listaDeCartasAdversario[i].Left = 350;
                        listaDeCartasAdversario[i].posicao = i;
                        listaDeCartasAdversario[i].DescobrirImagem();
                        this.Controls.Add(listaDeCartasAdversario[i]);
                    }
                    else if (i == 8)
                    {
                        Console.WriteLine($"Carta {i} = naipe {listaDeCartasAdversario[i].naipe}");
                        listaDeCartasAdversario[i].posicao = i;
                        listaDeCartasAdversario[i].Left = 350;
                        listaDeCartasAdversario[i].DescobrirImagem();
                        this.Controls.Add(listaDeCartasAdversario[i]);
                    }
                    else
                    {
                        Console.WriteLine($"Carta {i} = naipe {listaDeCartasAdversario[i].naipe}");
                        listaDeCartasAdversario[i].posicao = i;
                        listaDeCartasAdversario[i].Left = listaDeCartasAdversario[i - 1].Left + 60;
                        listaDeCartasAdversario[i].DescobrirImagem();
                        this.Controls.Add(listaDeCartasAdversario[i]);
                    }
                }

                for (int i = 1; i < listaDeCartasAdversario.Count; i++)
                {
                    if (i <= 7)
                    {
                        listaDeCartasAdversario[i].Top = 20;
                    }
                    else
                    {
                        listaDeCartasAdversario[i].Top = 100;
                    }

                }

                for (int i = 1; i < listaDeCartasAdversario2.Count; i++)
                {
                    if (i == 1)
                    {
                        Console.WriteLine($"Carta {i} = naipe {listaDeCartasAdversario2[i].naipe}");
                        listaDeCartasAdversario2[i].Left = 50;
                        listaDeCartasAdversario2[i].posicao = i;
                        listaDeCartasAdversario2[i].DescobrirImagem();
                        this.Controls.Add(listaDeCartasAdversario2[i]);
                    }
                    else if (i == 8)
                    {
                        Console.WriteLine($"Carta {i} = naipe {listaDeCartasAdversario2[i].naipe}");
                        listaDeCartasAdversario2[i].posicao = i;
                        listaDeCartasAdversario2[i].Left = 50;
                        listaDeCartasAdversario2[i].DescobrirImagem();
                        this.Controls.Add(listaDeCartasAdversario2[i]);
                    }
                    else
                    {
                        Console.WriteLine($"Carta {i} = naipe {listaDeCartasAdversario2[i].naipe}");
                        listaDeCartasAdversario2[i].posicao = i;
                        listaDeCartasAdversario2[i].Left = listaDeCartasAdversario2[i - 1].Left + 60;
                        listaDeCartasAdversario2[i].DescobrirImagem();
                        this.Controls.Add(listaDeCartasAdversario2[i]);
                    }
                }

                for (int i = 1; i < listaDeCartasAdversario2.Count; i++)
                {
                    if (i <= 7)
                    {
                        listaDeCartasAdversario2[i].Top = 180;
                    }
                    else
                    {
                        listaDeCartasAdversario2[i].Top = 260;
                    }

                }

                for (int i = 1; i < listaDeCartasAdversario3.Count; i++)
                {
                    if (i == 1)
                    {
                        Console.WriteLine($"Carta {i} = naipe {listaDeCartasAdversario3[i].naipe}");
                        listaDeCartasAdversario3[i].Left = 650;
                        listaDeCartasAdversario3[i].posicao = i;
                        listaDeCartasAdversario3[i].DescobrirImagem();
                        this.Controls.Add(listaDeCartasAdversario3[i]);
                    }
                    else if (i == 8)
                    {
                        Console.WriteLine($"Carta {i} = naipe {listaDeCartasAdversario3[i].naipe}");
                        listaDeCartasAdversario3[i].posicao = i;
                        listaDeCartasAdversario3[i].Left = 650;
                        listaDeCartasAdversario3[i].DescobrirImagem();
                        this.Controls.Add(listaDeCartasAdversario3[i]);
                    }
                    else
                    {
                        Console.WriteLine($"Carta {i} = naipe {listaDeCartasAdversario3[i].naipe}");
                        listaDeCartasAdversario3[i].posicao = i;
                        listaDeCartasAdversario3[i].Left = listaDeCartasAdversario3[i - 1].Left + 60;
                        listaDeCartasAdversario3[i].DescobrirImagem();
                        this.Controls.Add(listaDeCartasAdversario3[i]);
                    }
                }

                for (int i = 1; i < listaDeCartasAdversario3.Count; i++)
                {
                    if (i <= 7)
                    {
                        listaDeCartasAdversario3[i].Top = 180;
                    }
                    else
                    {
                        listaDeCartasAdversario3[i].Top = 260;
                    }

                }
            }

        }

        int pontuacaoAnterior = 0;
        int pontuacaoAtual = 0;
        int posicaoCarta = 1;
        int posicaoVencedor = 0;

        private void Automacao()
        {
            


            AtualizarCampos();
            pontuacaoAnterior = pontuacaoAtual;
            pontuacaoAtual = Pontuacao();
            string retornoJogadas = Jogo.ExibirJogadas2(Convert.ToInt32(idPartida), 1);
            retornoJogadas = retornoJogadas.Replace('\r', ' ');

            if (retornoJogadas != "")
            {
                string[] rodadas = retornoJogadas.Split('\n');
                string[] ultimaRodada = rodadas[rodadas.Length - 2].Split(',');
                for (int i = 0; i < ultimaRodada.Length; i++)
                {
                    Console.WriteLine($"Vetor ultima rodada {ultimaRodada[i]}");
                }
            }

            //if (retornoJogadas != "")
            //{
            //    retornoJogadas = retornoJogadas.Replace('\r', ' ');
            //    string[] jogadas = retornoJogadas.Split('\n');
            //    string[] ultimaJogada;
            //    if (jogadas[jogadas.Length - 2].StartsWith(idJogadorUm) == false)
            //    {
            //        //Round, Id, Naipe, Valor, Posição
            //        ultimaJogada = jogadas[jogadas.Length - 2].Split(',');
            //        for (int i = 0; i < ultimaJogada.Length; i++)
            //        {
            //            Console.WriteLine($"Dados ultima jogada {ultimaJogada[i]}");
            //        }
            //        if (ultimaJogada[1] == adversario[0] && listaDeCartasAdversario[Convert.ToInt32(ultimaJogada[4])].valor == null)
            //        {

            //            listaDeCartasAdversario[Convert.ToInt32(ultimaJogada[4])].valor = ultimaJogada[3];
            //            listaDeCartasAdversario[Convert.ToInt32(ultimaJogada[4])].VirarImagem();
            //            Console.WriteLine(listaDeCartasAdversario[Convert.ToInt32(ultimaJogada[4])].valor);
            //        }
            //        else if (ultimaJogada[1] == adversario2[0] && listaDeCartasAdversario2[Convert.ToInt32(ultimaJogada[4])].naipe == null)
            //        {

            //            listaDeCartasAdversario2[Convert.ToInt32(ultimaJogada[4])].valor = ultimaJogada[3];
            //            listaDeCartasAdversario2[Convert.ToInt32(ultimaJogada[4])].VirarImagem();
            //            Console.WriteLine(listaDeCartasAdversario2[Convert.ToInt32(ultimaJogada[4])].valor);
            //        }
            //        else
            //        {

            //            listaDeCartasAdversario3[Convert.ToInt32(ultimaJogada[4])].valor = ultimaJogada[3];
            //            listaDeCartasAdversario3[Convert.ToInt32(ultimaJogada[4])].VirarImagem();
            //            Console.WriteLine(listaDeCartasAdversario3[Convert.ToInt32(ultimaJogada[4])].valor);
            //        }
            //    }
            //}


            if (ConsultarVez())
            {
                
                int idJogadorJogando = Convert.ToInt32(meuId);
                string senhaJogadorJogando = minhaSenha;


                if (retornoJogadas == "") //bot começa jogando
                {
                    
                    //if (vetorJogadores.Length <= 3)
                    //{
                    //    posicaoVencedor += 2;
                    //}
                    //else
                    //{
                    posicaoVencedor += 4;
                    //}


                    Console.WriteLine("Eu começo!");
                    
                    string valorCarta = Jogo.Jogar(idJogadorJogando, senhaJogadorJogando, minhaListaDeCartas.Count-1);
                    MessageBox.Show("Valor da carta jogada: " + valorCarta);
                    minhaListaDeCartas[minhaListaDeCartas.Count - 1].valor = valorCarta;
                    minhaListaDeCartas[minhaListaDeCartas.Count - 1].VirarImagem();
                    lblValorCarta.Text = valorCarta;

                    AtualizarCampos();
                    //int idJogadorApostando = Convert.ToInt32(idJogadorUm);
                    //string senhaJogadorApostando = senhaJogadorUm;
                    //int cartaApostada = 0;

                    //string valorCartaApostada = Jogo.Apostar(idJogadorApostando, senhaJogadorApostando, cartaApostada);
                    //if (valorCartaApostada == "0")
                    //{
                    //    MessageBox.Show("Pulou a aposta!");
                    //}
                    //else
                    //{
                    //    MessageBox.Show("Carta Apostada: " + valorCartaApostada);
                    //}


                }
                else //Quando é a vez do bot mas não é a primeira jogada da partida
                {


                    AtualizarCampos();
                    //// [0] ROUND
                    //// [1] Id do Jogador
                    //// [2] Naipe 
                    //// [3] Valor
                    //// [4] Posição

                    if (pontuacaoAtual == pontuacaoAnterior) //Bot não ganhou ou ainda pode ganhar
                    {


                        string informacoes = Jogo.ExibirJogadas(Convert.ToInt32(idDaPartida));
                        //Console.WriteLine(informacoes);
                        informacoes = informacoes.Replace('\r', ' ');
                        string[] infos = informacoes.Split('\n');
                     
                        //string[] ultimaJogada = infos[infos.Length - 2].Split(',');
                        string[] dadosVencedor = infos[posicaoVencedor].Split(',');
                        List<string> jogadasRodada = new List<string>();

                        //Naipe jogado pelo ultimo vencedor
                        string naipeJogado = dadosVencedor[2];
                        int valorJogado = Convert.ToInt32(dadosVencedor[3]);

                        Console.WriteLine($" Naipe jogado pelo ultimo vencedor é: {naipeJogado}");

                        string valorCarta;

                        if (vetorJogadores.Length <= 3)
                        {
                            posicaoVencedor += 2;
                        }
                        else
                        {
                            posicaoVencedor += 4;
                        }

                        //for (int i = infos.Length-2; i >= posicaoVencedor; i--)
                        //{
                        //    if (Convert.ToInt32(infos[i].Substring(9)) > valorJogado && infos[i].Substring(7,1) == naipeJogado)
                        //    {
                        //        valorJogado = Convert.ToInt32(infos[i].Substring(9));
                        //    }
                        //    Console.WriteLine($"Naipes jogados na rodada: {infos[i].Substring(7, 1)}");
                        //    Console.WriteLine($"Valores jogados na rodada: {infos[i].Substring(9)}");
                        //}



                        int posicao = ComparaNaipes3(minhaListaDeCartas, naipeJogado);
                        if (posicao == -1)
                        {
                            posicao = ComparaNaipes3(minhaListaDeCartas, "C");
                            if(posicao == -1) //Não encontrou nem o naipe jogado, nem o coração
                            {
                                posicao = ChecaPosicao2(minhaListaDeCartas,1);
                                Console.WriteLine(posicao);
                                valorCarta = Jogo.Jogar(idJogadorJogando, senhaJogadorJogando, posicao);
                                MessageBox.Show("Valor da carta jogada: " + valorCarta);
                                minhaListaDeCartas[posicao].valor = valorCarta;
                                minhaListaDeCartas[posicao].VirarImagem();
                                lblValorCarta.Text = valorCarta;
                            }
                            else //Encontrou um coração
                            {
                                Console.WriteLine(posicao);
                                valorCarta = Jogo.Jogar(idJogadorJogando, senhaJogadorJogando, posicao);
                                MessageBox.Show("Valor da carta jogada: " + valorCarta);
                                minhaListaDeCartas[posicao].valor = valorCarta;
                                minhaListaDeCartas[posicao].VirarImagem();
                                lblValorCarta.Text = valorCarta;
                            }


                        }
                        else
                        {
                            Console.WriteLine(posicao);
                            valorCarta = Jogo.Jogar(idJogadorJogando, senhaJogadorJogando, posicao);
                            MessageBox.Show("Valor da carta jogada: " + valorCarta);
                            minhaListaDeCartas[posicao].valor = valorCarta;
                            minhaListaDeCartas[posicao].VirarImagem();
                            lblValorCarta.Text = valorCarta;
                        }

                        AtualizarCampos();

                        //string retorno = Jogo.ExibirJogadas2(Convert.ToInt32(idPartida), 1);
                        //retorno = retorno.Replace('\r', ' ');
                        //string[] ultimaRodada;

                        //string[] rodadas = retornoJogadas.Split('\n');
                        //ultimaRodada = rodadas[rodadas.Length - 1].Split(',');


                        //if (Convert.ToInt32(ultimaRodada[0]) == 7)
                        //{
                        //    if ()
                        //}

                        //int idJogadorApostando = Convert.ToInt32(idJogadorUm);
                        //string senhaJogadorApostando = senhaJogadorUm;
                        //int cartaApostada = 0;
                        //string valorCartaApostada = Jogo.Apostar(idJogadorApostando, senhaJogadorApostando, cartaApostada);
                        //if (valorCartaApostada == "0")
                        //{
                        //    MessageBox.Show("Pulou a aposta!");
                        //}
                        //else
                        //{
                        //    MessageBox.Show("Carta Apostada: " + valorCartaApostada);
                        //}

                    }
                    else //bot ganhou ultima rodada, pode escolher qualquer carta para jogar
                    {
                        //if (vetorJogadores.Length <= 3)
                        //{
                        //    posicaoVencedor += 2;
                        //}
                        //else
                        //{
                        posicaoVencedor += 4;
                        //}
                        int posicao = ChecaPosicao(minhaListaDeCartas,minhaListaDeCartas.Count-1);
                        //if (posicao == -1)
                        //{
                            
                            //posicao = ComparaNaipes2(minhaListaDeCartas, "E");
                            //Console.WriteLine(posicao);
                            //string valorCarta = Jogo.Jogar(idJogadorJogando, senhaJogadorJogando, posicao);
                            //MessageBox.Show("Valor da carta jogada: " + valorCarta);
                            //minhaListaDeCartas[posicao].valor = valorCarta;
                            //minhaListaDeCartas[posicao].VirarImagem();
                            //lblValorCarta.Text = valorCarta;

                            //AtualizarCampos();

                            //int idJogadorApostando = Convert.ToInt32(idJogadorUm);
                            //string senhaJogadorApostando = senhaJogadorUm;
                            //int cartaApostada = 0;
                            //string valorCartaApostada = Jogo.Apostar(idJogadorApostando, senhaJogadorApostando, cartaApostada);
                            //if (valorCartaApostada == "0")
                            //{
                            //    MessageBox.Show("Pulou a aposta!");
                            //}
                            //else
                            //{
                            //    MessageBox.Show("Carta Apostada: " + valorCartaApostada);
                            //}
                        //}
                        //else
                        //{
                            Console.WriteLine(posicao);
                            string valorCarta = Jogo.Jogar(idJogadorJogando, senhaJogadorJogando, posicao);
                            MessageBox.Show("Valor da carta jogada: " + valorCarta);
                            minhaListaDeCartas[posicao].valor = valorCarta;
                            minhaListaDeCartas[posicao].VirarImagem();
                            lblValorCarta.Text = valorCarta;

                            AtualizarCampos();

                            //int idJogadorApostando = Convert.ToInt32(idJogadorUm);
                            //string senhaJogadorApostando = senhaJogadorUm;
                            //int cartaApostada = 0;
                            //string valorCartaApostada = Jogo.Apostar(idJogadorApostando, senhaJogadorApostando, cartaApostada);
                            //if (valorCartaApostada == "0")
                            //{
                            //    MessageBox.Show("Pulou a aposta!");
                            //}
                            //else
                            //{
                            //    MessageBox.Show("Carta Apostada: " + valorCartaApostada);
                            //}
                        //}
                    }

                }
                AtualizarCampos();


                //string retorno = Jogo.ExibirJogadas2(Convert.ToInt32(idPartida), 1);

                //string[] ultimaRodada = new string[6];
                //if (retorno != "")
                //{
                //    retorno = retorno.Replace('\r', ' ');
                    

                //    string[] rodadas = retornoJogadas.Split('\n');
                //    ultimaRodada = rodadas[rodadas.Length - 2].Split(',');

                //    for (int i = 0; i < ultimaRodada.Length; i++)
                //    {
                //        Console.WriteLine($"Vetor ultima rodada {ultimaRodada[i]} posição {i}");
                //    }
                //}


                //if (Convert.ToInt32(ultimaRodada[0]) == 7)
                //{
                //    int posicao = ChecaValor(minhaListaDeCartas,Pontuacao());
                //    if(posicao == -1)
                //    {
                //        posicao = ChecaValor(minhaListaDeCartas, Pontuacao()-1);
                //        string valorCartaApostada = Jogo.Apostar(Convert.ToInt32(idJogadorUm), senhaJogadorUm, cartaApostada);
                //        MessageBox.Show("Carta Apostada: " + valorCartaApostada);

                //    }
                //    else
                //    {
                //        cartaApostada = ChecaPosicao2(minhaListaDeCartas,posicao);
                //        if(cartaApostada == -1)
                //        {
                //            cartaApostada = ChecaPosicao(minhaListaDeCartas, posicao);
                //        }
                //        string valorCartaApostada = Jogo.Apostar(Convert.ToInt32(idJogadorUm), senhaJogadorUm, cartaApostada);
                //        MessageBox.Show("Carta Apostada: " + valorCartaApostada);
                //    }
                //}
                //else
                //{

                if(numRodada == "7")
                {
                    int posicao = ChecaValor(minhaListaDeCartas, Pontuacao());
                    if (posicao == -1)
                    {
                        posicao = ChecaValor(minhaListaDeCartas, Pontuacao() + 1);
                        string valorCartaApostada = Jogo.Apostar(Convert.ToInt32(meuId), minhaSenha, posicao);
                        MessageBox.Show("Carta Apostada: " + valorCartaApostada);
                        minhaListaDeCartas[posicao].valor = valorCartaApostada;
                        minhaListaDeCartas[posicao].VirarImagem();
                        lblValorCarta.Text = valorCartaApostada;

                    }
                    else
                    {
                        int cartaApostada = ChecaPosicao2(minhaListaDeCartas, posicao);
                        if (cartaApostada == -1)
                        {
                            cartaApostada = ChecaPosicao(minhaListaDeCartas, posicao);
                        }
                        string valorCartaApostada = Jogo.Apostar(Convert.ToInt32(meuId), minhaSenha, cartaApostada);
                        MessageBox.Show("Carta Apostada: " + valorCartaApostada);
                        minhaListaDeCartas[posicao].valor = valorCartaApostada;
                        minhaListaDeCartas[posicao].VirarImagem();
                        lblValorCarta.Text = valorCartaApostada;
                    }
                }
                else
                {
                    string valorCartaApostada = Jogo.Apostar(Convert.ToInt32(meuId), minhaSenha, 0);
                    if (valorCartaApostada == "0")
                    {
                        MessageBox.Show("Pulou a aposta!");
                    }
                    else
                    {
                        MessageBox.Show("Carta Apostada: " + valorCartaApostada);
                    }
                }

                //}


            }

        }


        public int Pontuacao()
        {
            string dados = Jogo.ListarJogadores2(Convert.ToInt32(idPartida));
            dados = dados.Replace('\r',' ');
            string[] dadosPontuacaoJogadores = dados.Split('\n');

            int tamanhoVetor = dadosPontuacaoJogadores.Length;

            string[] dadosPontuacao = new string[4];

            foreach (string item in dadosPontuacaoJogadores)
            {
                if (item.StartsWith(meuId))
                {
                    dadosPontuacao = item.Split(',');

                }
            }

            Console.WriteLine($"Pontuação atual: {dadosPontuacao[dadosPontuacao.Length - 1]}");
            return Convert.ToInt32(dadosPontuacao[dadosPontuacao.Length-1]);
        }

        public int ComparaNaipes(List<Carta> cartas, string naipe)
        {
            Console.WriteLine($"Naipe jogado pelo adversário ganhador {naipe}");
            for (int i = 1; i <= minhaListaDeCartas.Count; i++)
            {
                if (cartas[i].valor == null)
                {
                    if (cartas[i].naipe.ToString() == naipe)
                    {
                        Console.WriteLine($"Comparação de naipe: {cartas[i].naipe} = {naipe}, posição {i}");

                        return i;
                    }
                }

            }
            return -1;
        }


        public int ComparaNaipes3(List<Carta> cartas, string naipe)
        {
            Console.WriteLine($"Naipe jogado pelo adversário ganhador {naipe}");
            for (int i = cartas.Count-1; i >= 1; i--)
            {
                Console.WriteLine($"Naipe final {cartas[i].naipe}");
                if (cartas[i].valor == null)
                {
                    if (cartas[i].naipe.ToString() == naipe)
                    {
                        Console.WriteLine($"Comparação de naipe: {cartas[i].naipe} = {naipe}, posição {i}");

                        return i;
                    }
                }

            }
            return -1;
        }

        ////Procura na lista com base na posição e no naipe
        //public int ComparaNaipes3(List<Carta> cartas, string naipe, int posicao)
        //{
        //    for (int i = posicao; i <= minhaListaDeCartas.Count; i++)
        //    {
        //        if (cartas[posicao].valor == null && cartas[posicao].naipe.ToString() == naipe)
        //        {

        //            return posicao;
        //        }
        //    }

        //    return -1;

        //}


        public int ChecaValor(List<Carta> cartas, int valor) 
        {
            for(int i = 1; i <= cartas.Count-1; i++)
            {
                if (Convert.ToInt32(cartas[i].valor) == valor)
                {
                    return i;
                }
            }

            return -1;
        }

        //Procura com base na posicao (final pro começo)
        public int ChecaPosicao(List<Carta> cartas, int posicao)
        {

            Console.WriteLine("Entrei na função checa posição");

            for (int i = posicao; i >= 1; i--)
            {
                if (cartas[i].valor == null)
                {
                    Console.WriteLine($"A posição que irei retornar é {posicao}");
                    return i;
                }
            }
            return -1;

        }

        //Procura com base na posicao (Começo pro final)
        public int ChecaPosicao2(List<Carta> cartas, int posicao)
        {
            Console.WriteLine("Entrei na função checha posição 2");
            for (int i = posicao; i <= cartas.Count-1; i++)
            {
                if (cartas[i].valor == null)
                {
                    Console.WriteLine($"A posição que irei retornar é {posicao}");
                    return i;
                }
            }
            return -1;
        }






        public int ComparaNaipes2(List<Carta> cartas, string naipe)
        {
            for (int i = 1; i < minhaListaDeCartas.Count; i++)
            {
                if (cartas[i] != null)
                {
                    if (cartas[i].naipe.ToString() == naipe)
                    { 
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
            statusRodada = dadosRodada[3].Substring(0,1);
            lblVez.Text = idJogadorDaVez;
            lblStatusRodada.Text = statusRodada;
        }

        public bool ConsultarVez()
        {
            informacoes = Jogo.VerificarVez2(Convert.ToInt32(idDaPartida));
            dadosRodada = informacoes.Split(',');
            idJogadorDaVez = dadosRodada[1];
            if (idJogadorDaVez == meuId)
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

        private void btnJogadas_Click(object sender, EventArgs e)
        {
            string retorno = Jogo.ExibirJogadas2(Convert.ToInt32(idPartida),1);
            if (retorno == "")
            {
                lstJogadas.Items.Add("Não há jogadas");
            }
            else if (retorno.Substring(0, 4) == "ERRO")
            {
                MessageBox.Show("Ocorreu um erro! \n" + retorno.Substring(5), "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                retorno = retorno.Replace("\r", "");
                string[] jogadas = retorno.Split('\n');

                lstJogadas.Items.Clear();
                for (int i = 0; i < jogadas.Length; i++)
                {
                    lstJogadas.Items.Add(jogadas[i]);
                }
            }
        }
    }
}

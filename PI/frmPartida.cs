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
            AtualizarCampos();
        }

        int pontuacaoAnterior = 0;
        int pontuacaoAtual = 0;
        int posicaoVencedor = 0;
        int round = 0;
        int rodadaAnterior = 0;


        private void Automacao()
        {

            AtualizarCampos();

            if (statusPartida == "E" || statusPartida == "F")
            {
                string resultado = Jogo.ListarJogadores2(Convert.ToInt32(idDaPartida));
                resultado = resultado.Replace("\r", "");
                resultado = resultado.Substring(0, resultado.Length - 1);

                string[] jogadores = resultado.Split('\n');

                int pontuacao = -99;
                string nome = "";
                foreach (string jogador in jogadores)
                {
                    string[] dadosJogador = jogador.Split('\n');
                    if (pontuacao == -99 || pontuacao < Convert.ToInt32(dadosJogador[2]))
                    {
                        nome = dadosJogador[1];
                        pontuacao = Convert.ToInt32(dadosJogador[2]);
                    }
                }


                MessageBox.Show($"O vencedor foi {nome}, com a pontuação: {pontuacao}");
                tmrIniciarAutomacao.Stop();
                return;
            }

            if (rodadaAnterior != Convert.ToInt32(numRodada) && Convert.ToInt32(numRodada) == 1)
            {
                InstanciaCartas();
                pontuacaoAnterior = 0;
                pontuacaoAtual = 0;
                posicaoVencedor = 0;
                round += 1;
            }
            rodadaAnterior = Convert.ToInt32(numRodada);

            string retornoJogadas = Jogo.ExibirJogadas2(Convert.ToInt32(idPartida), round);
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


            if (retornoJogadas != "")
            {
                retornoJogadas = retornoJogadas.Replace('\r', ' ');
                string[] jogadas = retornoJogadas.Split('\n');

                string[] ultimaJogada;
                if (jogadas[jogadas.Length - 2].StartsWith(meuId) == false)
                {
                    //Round, Id, Naipe, Valor, Posição
                    ultimaJogada = jogadas[jogadas.Length - 2].Split(',');
                    for (int i = 0; i < ultimaJogada.Length; i++)
                    {
                        Console.WriteLine($"Dados ultima jogada {ultimaJogada[i]}");
                    }
                    if (ultimaJogada[1] == adversario[0] && listaDeCartasAdversario[Convert.ToInt32(ultimaJogada[4])].valor == null)
                    {

                        listaDeCartasAdversario[Convert.ToInt32(ultimaJogada[4])].valor = ultimaJogada[3];
                        listaDeCartasAdversario[Convert.ToInt32(ultimaJogada[4])].VirarImagem();
                        Console.WriteLine(listaDeCartasAdversario[Convert.ToInt32(ultimaJogada[4])].valor);
                        Label lbl1 = new Label();
                        lbl1.AutoSize = false;
                        lbl1.TextAlign = ContentAlignment.MiddleCenter;
                        lbl1.Dock = DockStyle.Fill;
                        lbl1.Text = ultimaJogada[3];
                        lbl1.Font = new Font("Modern No. 20", 15);
                        listaDeCartasAdversario[Convert.ToInt32(ultimaJogada[4])].Controls.Add(lbl1);
                    }
                    else if (ultimaJogada[1] == adversario2[0] && listaDeCartasAdversario2[Convert.ToInt32(ultimaJogada[4])].valor == null)
                    {

                        listaDeCartasAdversario2[Convert.ToInt32(ultimaJogada[4])].valor = ultimaJogada[3];
                        listaDeCartasAdversario2[Convert.ToInt32(ultimaJogada[4])].VirarImagem();
                        Console.WriteLine(listaDeCartasAdversario2[Convert.ToInt32(ultimaJogada[4])].valor);
                        Label lbl1 = new Label();
                        lbl1.AutoSize = false;
                        lbl1.TextAlign = ContentAlignment.MiddleCenter;
                        lbl1.Dock = DockStyle.Fill;
                        lbl1.Text = ultimaJogada[3];
                        lbl1.Font = new Font("Modern No. 20", 15);
                        listaDeCartasAdversario2[Convert.ToInt32(ultimaJogada[4])].Controls.Add(lbl1);
                    }
                    else if (ultimaJogada[1] == adversario3[0] && listaDeCartasAdversario3[Convert.ToInt32(ultimaJogada[4])].valor == null)
                    {

                        listaDeCartasAdversario3[Convert.ToInt32(ultimaJogada[4])].valor = ultimaJogada[3];
                        listaDeCartasAdversario3[Convert.ToInt32(ultimaJogada[4])].VirarImagem();
                        Console.WriteLine(listaDeCartasAdversario3[Convert.ToInt32(ultimaJogada[4])].valor);
                        Label lbl1 = new Label();
                        lbl1.AutoSize = false;
                        lbl1.TextAlign = ContentAlignment.MiddleCenter;
                        lbl1.Dock = DockStyle.Fill;
                        lbl1.Text = ultimaJogada[3];
                        lbl1.Font = new Font("Modern No. 20", 15);
                        listaDeCartasAdversario3[Convert.ToInt32(ultimaJogada[4])].Controls.Add(lbl1);
                    }
                }
            }


            if (ConsultarVez())
            {

                int idJogadorJogando = Convert.ToInt32(meuId);
                string senhaJogadorJogando = minhaSenha;


                if (retornoJogadas == "") //bot começa jogando
                {
                    posicaoVencedor += 4;
                    string valorCarta = Jogo.Jogar(idJogadorJogando, senhaJogadorJogando, minhaListaDeCartas.Count - 1);
                    minhaListaDeCartas[minhaListaDeCartas.Count - 1].valor = valorCarta;
                    minhaListaDeCartas[minhaListaDeCartas.Count - 1].VirarImagem();
                    Label lbl1 = new Label();
                    lbl1.AutoSize = false;
                    lbl1.TextAlign = ContentAlignment.MiddleCenter;
                    lbl1.Dock = DockStyle.Fill;
                    lbl1.Font = new Font("Modern No. 20", 15);
                    lbl1.Text = valorCarta;
                    minhaListaDeCartas[minhaListaDeCartas.Count - 1].Controls.Add(lbl1);

                    AtualizarCampos();


                }
                else //Quando é a vez do bot mas não é a primeira jogada da partida
                {


                    AtualizarCampos();
                    //// [0] ROUND
                    //// [1] Id do Jogador
                    //// [2] Naipe 
                    //// [3] Valor
                    //// [4] Posição

                    pontuacaoAnterior = pontuacaoAtual;
                    pontuacaoAtual = Pontuacao();
                    if (pontuacaoAtual == pontuacaoAnterior) //Bot não ganhou ou ainda pode ganhar
                    {


                        string informacoes = Jogo.ExibirJogadas(Convert.ToInt32(idDaPartida));
                        informacoes = informacoes.Replace('\r', ' ');
                        string[] infos = informacoes.Split('\n');
                        string[] dadosVencedor = infos[posicaoVencedor].Split(',');

                        posicaoVencedor += 4;
                        //Naipe jogado pelo ultimo vencedor
                        string naipeJogado = dadosVencedor[2];
                        string valorCarta;

                        int posicao = ComparaNaipes3(minhaListaDeCartas, naipeJogado);
                        if (posicao == -1)
                        {
                            posicao = ComparaNaipes3(minhaListaDeCartas, "C");
                            if (posicao == -1) //Não encontrou nem o naipe jogado, nem o coração
                            {
                                posicao = ChecaPosicao2(minhaListaDeCartas, 1);
                                Console.WriteLine(posicao);
                                valorCarta = Jogo.Jogar(idJogadorJogando, senhaJogadorJogando, posicao);
                                minhaListaDeCartas[posicao].valor = valorCarta;
                                minhaListaDeCartas[posicao].VirarImagem();
                                Label lbl1 = new Label();
                                lbl1.AutoSize = false;
                                lbl1.TextAlign = ContentAlignment.MiddleCenter;
                                lbl1.Dock = DockStyle.Fill;
                                lbl1.Font = new Font("Modern No. 20", 15);
                                lbl1.Text = valorCarta;
                                minhaListaDeCartas[posicao].Controls.Add(lbl1);
                            }
                            else //Encontrou um coração
                            {
                                Console.WriteLine(posicao);
                                valorCarta = Jogo.Jogar(idJogadorJogando, senhaJogadorJogando, posicao);
                                minhaListaDeCartas[posicao].valor = valorCarta;
                                minhaListaDeCartas[posicao].VirarImagem();
                                Label lbl1 = new Label();
                                lbl1.AutoSize = false;
                                lbl1.TextAlign = ContentAlignment.MiddleCenter;
                                lbl1.Dock = DockStyle.Fill;
                                lbl1.Font = new Font("  ", 15);
                                lbl1.Text = valorCarta;
                                minhaListaDeCartas[posicao].Controls.Add(lbl1);
                            }


                        }
                        else
                        {
                            Console.WriteLine(posicao);
                            valorCarta = Jogo.Jogar(idJogadorJogando, senhaJogadorJogando, posicao);
                            minhaListaDeCartas[posicao].valor = valorCarta;
                            minhaListaDeCartas[posicao].VirarImagem();
                            Label lbl1 = new Label();
                            lbl1.AutoSize = false;
                            lbl1.TextAlign = ContentAlignment.MiddleCenter;
                            lbl1.Dock = DockStyle.Fill;
                            lbl1.Font = new Font("Modern No. 20", 15);
                            lbl1.Text = valorCarta;
                            minhaListaDeCartas[posicao].Controls.Add(lbl1);
                        }

                        AtualizarCampos();


                    }
                    else //bot ganhou ultima rodada, pode escolher qualquer carta para jogar
                    {
                        posicaoVencedor += 4;
                        int posicao = ChecaPosicao(minhaListaDeCartas, minhaListaDeCartas.Count - 1);

                        string valorCarta = Jogo.Jogar(idJogadorJogando, senhaJogadorJogando, posicao);
                        minhaListaDeCartas[posicao].valor = valorCarta;
                        minhaListaDeCartas[posicao].VirarImagem();
                        Label lbl1 = new Label();
                        lbl1.AutoSize = false;
                        lbl1.TextAlign = ContentAlignment.MiddleCenter;
                        lbl1.Dock = DockStyle.Fill;
                        lbl1.Font = new Font("Modern No. 20", 15);
                        lbl1.Text = valorCarta;
                        minhaListaDeCartas[posicao].Controls.Add(lbl1);
                        AtualizarCampos();
                    }
                }
                AtualizarCampos();

                if (numRodada == "7")
                {
                    int posicao;
                    if (pontuacaoAtual <= 7)
                    {
                        posicao = ChecaPosicao(minhaListaDeCartas, 7);
                        if (posicao == -1)
                        {
                            posicao = ChecaPosicao2(minhaListaDeCartas, 7);
                            string valorCartaApostada = Jogo.Apostar(Convert.ToInt32(meuId), minhaSenha, posicao);
                            minhaListaDeCartas[posicao].valor = valorCartaApostada;
                            minhaListaDeCartas[posicao].VirarImagem();
                            Label lbl1 = new Label();
                            lbl1.AutoSize = false;
                            lbl1.TextAlign = ContentAlignment.MiddleCenter;
                            lbl1.Dock = DockStyle.Fill;
                            lbl1.Font = new Font("Modern No. 20", 15);
                            lbl1.Text = valorCartaApostada;
                            minhaListaDeCartas[posicao].Controls.Add(lbl1);
                            lblMinhaCartaApostada.Text = valorCartaApostada;
                        }
                        else
                        {
                            string valorCartaApostada = Jogo.Apostar(Convert.ToInt32(meuId), minhaSenha, posicao);
                            minhaListaDeCartas[posicao].valor = valorCartaApostada;
                            minhaListaDeCartas[posicao].VirarImagem();
                            Label lbl1 = new Label();
                            lbl1.AutoSize = false;
                            lbl1.TextAlign = ContentAlignment.MiddleCenter;
                            lbl1.Dock = DockStyle.Fill;
                            lbl1.Font = new Font("Modern No. 20", 15);
                            lbl1.Text = valorCartaApostada;
                            minhaListaDeCartas[posicao].Controls.Add(lbl1);
                            lblMinhaCartaApostada.Text = valorCartaApostada;
                        }
                    }
                    else
                    {
                        posicao = ChecaPosicao2(minhaListaDeCartas, 7);
                        if (posicao == -1)
                        {
                            posicao = ChecaPosicao(minhaListaDeCartas, 7);
                            string valorCartaApostada = Jogo.Apostar(Convert.ToInt32(meuId), minhaSenha, posicao);
                            minhaListaDeCartas[posicao].valor = valorCartaApostada;
                            minhaListaDeCartas[posicao].VirarImagem();
                            Label lbl1 = new Label();
                            lbl1.AutoSize = false;
                            lbl1.TextAlign = ContentAlignment.MiddleCenter;
                            lbl1.Dock = DockStyle.Fill;
                            lbl1.Font = new Font("Modern No. 20", 15);
                            lbl1.Text = valorCartaApostada;
                            minhaListaDeCartas[posicao].Controls.Add(lbl1);
                            lblMinhaCartaApostada.Text = valorCartaApostada;
                        }
                        else
                        {
                            string valorCartaApostada = Jogo.Apostar(Convert.ToInt32(meuId), minhaSenha, posicao);
                            minhaListaDeCartas[posicao].valor = valorCartaApostada;
                            minhaListaDeCartas[posicao].VirarImagem();
                            Label lbl1 = new Label();
                            lbl1.AutoSize = false;
                            lbl1.TextAlign = ContentAlignment.MiddleCenter;
                            lbl1.Dock = DockStyle.Fill;
                            lbl1.Text = valorCartaApostada;
                            lbl1.Font = new Font("Modern No. 20", 15);
                            minhaListaDeCartas[posicao].Controls.Add(lbl1);
                            lblMinhaCartaApostada.Text = valorCartaApostada;
                        }
                    }
                }
                else if (Convert.ToInt32(numRodada) < 7)
                {
                    Jogo.Apostar(Convert.ToInt32(meuId), minhaSenha, 0);
                }
            }
            AtualizarCampos();
        }


        public int Pontuacao()
        {
            string dados = Jogo.ListarJogadores2(Convert.ToInt32(idPartida));
            dados = dados.Replace('\r', ' ');
            string[] dadosPontuacaoJogadores = dados.Split('\n');

            string[] dadosPontuacao = new string[4];

            foreach (string item in dadosPontuacaoJogadores)
            {
                if (item.StartsWith(meuId))
                {
                    dadosPontuacao = item.Split(',');

                }
            }

            return Convert.ToInt32(dadosPontuacao[dadosPontuacao.Length - 1]);
        }

        public int ComparaNaipes(List<Carta> cartas, string naipe)
        {
            for (int i = 1; i <= minhaListaDeCartas.Count; i++)
            {
                if (cartas[i].valor == null)
                {
                    if (cartas[i].naipe.ToString() == naipe)
                    {
                        return i;
                    }
                }

            }
            return -1;
        }


        public int ComparaNaipes3(List<Carta> cartas, string naipe)
        {
            for (int i = cartas.Count - 1; i >= 1; i--)
            {
                if (cartas[i].valor == null)
                {
                    if (cartas[i].naipe.ToString() == naipe)
                    {
                        return i;
                    }
                }
            }
            return -1;
        }


        public int ChecaValor(List<Carta> cartas, int valor)
        {
            for (int i = 1; i <= cartas.Count - 1; i++)
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
            for (int i = posicao; i >= 1; i--)
            {
                if (cartas[i].valor == null)
                {
                    return i;
                }
            }
            return -1;

        }

        //Procura com base na posicao (Começo pro final)
        public int ChecaPosicao2(List<Carta> cartas, int posicao)
        {
            for (int i = posicao; i <= cartas.Count - 1; i++)
            {
                if (cartas[i].valor == null)
                {
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
            statusRodada = dadosRodada[3].Substring(0, 1);
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
            tmrIniciarAutomacao.Enabled = true;
        }


        public void InstanciaCartas()
        {
            string jogadores = Jogo.ListarJogadores(Convert.ToInt32(idPartida));
            vetorJogadores = jogadores.Split('\n');

            for (int i = 1; i < minhaListaDeCartas.Count; i++)
            {
                this.Controls.Remove(minhaListaDeCartas[i]);
                this.Controls.Remove(listaDeCartasAdversario[i]);
                this.Controls.Remove(listaDeCartasAdversario2[i]);
                this.Controls.Remove(listaDeCartasAdversario3[i]);
            }

            minhaListaDeCartas.Clear();
            listaDeCartasAdversario.Clear();
            listaDeCartasAdversario2.Clear();
            listaDeCartasAdversario3.Clear();

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

                for (int i = 0; i < 13; i++)
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


                string retorno = Jogo.ConsultarMao(Convert.ToInt32(idPartida));


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

                for (int i = 1; i < minhaListaDeCartas.Count; i++) //Percorre lista de cartas
                {

                    minhaListaDeCartas[i].naipe = maoDeCartas[i].Substring(maoDeCartas[i].Length - 1);
                }

                for (int i = 1; i < listaDeCartasAdversario.Count; i++) //Percorre lista de cartas adversario
                {

                    listaDeCartasAdversario[i].naipe = maoDeCartasAdversario[i].Substring(maoDeCartas[i].Length - 1);
                }


                for (int i = 1; i < minhaListaDeCartas.Count; i++)
                {
                    if (i == 1)
                    {
                        minhaListaDeCartas[i].Left = 350;
                        minhaListaDeCartas[i].posicao = i;
                        minhaListaDeCartas[i].DescobrirImagem();
                        this.Controls.Add(minhaListaDeCartas[i]);
                    }
                    else if (i == 7)
                    {
                        minhaListaDeCartas[i].posicao = i;
                        minhaListaDeCartas[i].Left = 350;
                        minhaListaDeCartas[i].DescobrirImagem();
                        this.Controls.Add(minhaListaDeCartas[i]);
                    }
                    else
                    {
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
                        listaDeCartasAdversario[i].Left = 350;
                        listaDeCartasAdversario[i].posicao = i;
                        listaDeCartasAdversario[i].DescobrirImagem();
                        this.Controls.Add(listaDeCartasAdversario[i]);
                    }
                    else if (i == 7)
                    {
                        listaDeCartasAdversario[i].posicao = i;
                        listaDeCartasAdversario[i].Left = 350;
                        listaDeCartasAdversario[i].DescobrirImagem();
                        this.Controls.Add(listaDeCartasAdversario[i]);
                    }
                    else
                    {
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


                string retorno = Jogo.ConsultarMao(Convert.ToInt32(idPartida));
                string retornoCemiterio = Jogo.ExibirJogadas2(Convert.ToInt32(idPartida));

                retorno = retorno.Replace("\r", "");

                if (retorno.Length > 0)
                {
                    retorno = retorno.Substring(0, retorno.Length - 1);
                }

                retornoCemiterio = retornoCemiterio.Replace("\r", "");

                if (retornoCemiterio.Length > 0)
                {
                    retornoCemiterio = retornoCemiterio.Substring(0, retornoCemiterio.Length - 1);
                }

                cartas = retorno.Split('\n');
                string[] cartasCemiterio = retornoCemiterio.Split('\n');

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

                if (retornoCemiterio.Length > 0)
                {
                    foreach (string carta in cartasCemiterio)
                    {
                        string[] dadosCarta = carta.Split(',');

                        if (dadosCarta[1] == adversario[0] && maoDeCartasAdversario.Count < 15)
                        {
                            maoDeCartasAdversario.Insert(Convert.ToInt32(dadosCarta[4]), $"{dadosCarta[1]},{dadosCarta[4]},{dadosCarta[2]}");
                        }
                        else if (dadosCarta[1] == adversario2[0] && maoDeCartasAdversario2.Count < 15)
                        {
                            maoDeCartasAdversario2.Insert(Convert.ToInt32(dadosCarta[4]), $"{dadosCarta[1]},{dadosCarta[4]},{dadosCarta[2]}");
                        }
                        else if (dadosCarta[1] == adversario3[0] && maoDeCartasAdversario3.Count < 15)
                        {
                            maoDeCartasAdversario3.Insert(Convert.ToInt32(dadosCarta[4]), $"{dadosCarta[1]},{dadosCarta[4]},{dadosCarta[2]}");
                        }
                    }
                }

                for (int i = 1; i < minhaListaDeCartas.Count; i++) //Percorre lista de cartas
                {
                    minhaListaDeCartas[i].naipe = maoDeCartas[i].Substring(maoDeCartas[i].Length - 1);
                }

                for (int i = 1; i < listaDeCartasAdversario.Count; i++) //Percorre lista de cartas adversario
                {
                    listaDeCartasAdversario[i].naipe = maoDeCartasAdversario[i].Substring(maoDeCartasAdversario[i].Length - 1);
                }

                for (int i = 1; i < listaDeCartasAdversario2.Count; i++) //Percorre lista de cartas adversario
                {
                    listaDeCartasAdversario2[i].naipe = maoDeCartasAdversario2[i].Substring(maoDeCartasAdversario2[i].Length - 1);
                }

                for (int i = 1; i < listaDeCartasAdversario3.Count; i++) //Percorre lista de cartas adversario
                {
                    listaDeCartasAdversario3[i].naipe = maoDeCartasAdversario3[i].Substring(maoDeCartasAdversario3[i].Length - 1);
                }


                for (int i = 1; i < minhaListaDeCartas.Count; i++)
                {
                    if (i == 1)
                    {
                        minhaListaDeCartas[i].Left = 350;
                        minhaListaDeCartas[i].posicao = i;
                        minhaListaDeCartas[i].DescobrirImagem();
                        this.Controls.Add(minhaListaDeCartas[i]);
                    }
                    else if (i == 8)
                    {
                        minhaListaDeCartas[i].posicao = i;
                        minhaListaDeCartas[i].Left = 350;
                        minhaListaDeCartas[i].DescobrirImagem();
                        this.Controls.Add(minhaListaDeCartas[i]);
                    }
                    else
                    {
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
                        listaDeCartasAdversario[i].Left = 350;
                        listaDeCartasAdversario[i].posicao = i;
                        listaDeCartasAdversario[i].DescobrirImagem();
                        this.Controls.Add(listaDeCartasAdversario[i]);
                    }
                    else if (i == 8)
                    {
                        listaDeCartasAdversario[i].posicao = i;
                        listaDeCartasAdversario[i].Left = 350;
                        listaDeCartasAdversario[i].DescobrirImagem();
                        this.Controls.Add(listaDeCartasAdversario[i]);
                    }
                    else
                    {
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
                        listaDeCartasAdversario2[i].Left = 50;
                        listaDeCartasAdversario2[i].posicao = i;
                        listaDeCartasAdversario2[i].DescobrirImagem();
                        this.Controls.Add(listaDeCartasAdversario2[i]);
                    }
                    else if (i == 8)
                    {
                        listaDeCartasAdversario2[i].posicao = i;
                        listaDeCartasAdversario2[i].Left = 50;
                        listaDeCartasAdversario2[i].DescobrirImagem();
                        this.Controls.Add(listaDeCartasAdversario2[i]);
                    }
                    else
                    {
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
                        listaDeCartasAdversario3[i].Left = 650;
                        listaDeCartasAdversario3[i].posicao = i;
                        listaDeCartasAdversario3[i].DescobrirImagem();
                        this.Controls.Add(listaDeCartasAdversario3[i]);
                    }
                    else if (i == 8)
                    {
                        listaDeCartasAdversario3[i].posicao = i;
                        listaDeCartasAdversario3[i].Left = 650;
                        listaDeCartasAdversario3[i].DescobrirImagem();
                        this.Controls.Add(listaDeCartasAdversario3[i]);
                    }
                    else
                    {
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
    }
}

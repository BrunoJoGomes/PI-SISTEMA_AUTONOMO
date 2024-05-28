using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
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
        

        public frmPartida()
        {
            InitializeComponent();
            frmLobby frmLobby = new frmLobby();

        }

        public void AtualizarTela()
        {
            lblPartida.Text = idPartida;
            idDaPartida = idPartida;
            txtIdJogadorUm.Text = idJogadorUm;
            txtSenhaJogadorUm.Text = senhaJogadorUm;
            lblIdSorteado.Text = idJogadorSorteado;

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        string[] cartas = new string[48];


        private void btnMostrarCartas_Click(object sender, EventArgs e)
        {
            int idpartida = Convert.ToInt32(lblPartida.Text);
            AtualizarCampos();

            string jogadores = Jogo.ListarJogadores(idpartida);
            string[] vetorJogadores = jogadores.Split('\n');


            //Caso tenham 2 jogadores
            if (vetorJogadores.Length <= 3)
            {

                string idJogador;
                string[] adversario1 = new string[4];

                //foreach (string jogador in vetorJogadores)
                //{
                //    if (jogador.StartsWith(idJogadorUm) != true)
                //    {
                //        adversario1 = jogador.Split(',');
                //        idJogador = vetorJogadores[i];
                //        Console.WriteLine($"id adversario {idJogador}");
                //    }
                //}

                //for (int i = 0; i < vetorJogadores.Length; i++)
                //{
                //    if (vetorJogadores[i].StartsWith(idJogadorUm) != true)
                //    {
                //        adversario1[] 
                //        idJogador = vetorJogadores[i];
                //        Console.WriteLine($"id adversario {idJogador}");
                //    }
                //}

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

                Carta carta13 = new Carta();
                Carta carta14 = new Carta();
                Carta carta15 = new Carta();
                Carta carta16 = new Carta();
                Carta carta17 = new Carta();
                Carta carta18 = new Carta();
                Carta carta19 = new Carta();
                Carta carta20 = new Carta();
                Carta carta21 = new Carta();
                Carta carta22 = new Carta();
                Carta carta23 = new Carta();
                Carta carta24 = new Carta();


                minhaListaDeCartas.Add(null);
                minhaListaDeCartas.Add(carta1);
                minhaListaDeCartas.Add(carta2);
                minhaListaDeCartas.Add(carta3);
                minhaListaDeCartas.Add(carta4);
                minhaListaDeCartas.Add(carta5);
                minhaListaDeCartas.Add(carta6);
                minhaListaDeCartas.Add(carta7);
                minhaListaDeCartas.Add(carta8);
                minhaListaDeCartas.Add(carta9);
                minhaListaDeCartas.Add(carta10);
                minhaListaDeCartas.Add(carta11);
                minhaListaDeCartas.Add(carta12);

                listaDeCartasAdversario.Add(null);
                listaDeCartasAdversario.Add(carta13);
                listaDeCartasAdversario.Add(carta14);
                listaDeCartasAdversario.Add(carta15);
                listaDeCartasAdversario.Add(carta16);
                listaDeCartasAdversario.Add(carta17);
                listaDeCartasAdversario.Add(carta18);
                listaDeCartasAdversario.Add(carta19);
                listaDeCartasAdversario.Add(carta20);
                listaDeCartasAdversario.Add(carta21);
                listaDeCartasAdversario.Add(carta22);
                listaDeCartasAdversario.Add(carta23);
                listaDeCartasAdversario.Add(carta24);

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
                    if (item.StartsWith(idJogadorUm))
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



                //for(int i = 1; i <= cartas.Length; i++)
                //{
                //    if (cartas[i-1].StartsWith(idJogadorUm))
                //    {
                //        minhaListaDeCartas[i].naipe = cartas[i-1].Substring(cartas[i-1].Length - 1);
                //    }

                //}

                //for (int i = 1; i <= cartas.Length; i++)
                //{
                //    if (cartas[i - 1].StartsWith(idJogadorUm) != true)
                //    {
                //        listaDeCartasAdversario[i].naipe = cartas[i - 1].Substring(cartas[i - 1].Length - 1);
                //    }

                //}









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
                string[] idJogadores = new string[3];

                Console.WriteLine($"Tamanho do vetor de jogadores {vetorJogadores.Length}");

                for (int i = 1; i < vetorJogadores.Length; i++)
                {
                    if (vetorJogadores[i].StartsWith(idJogadorUm) != true)
                    {
                        idJogadores[i] = vetorJogadores[i];
                        Console.WriteLine($"id adversarios {idJogadores[i]}");
                    }
                }

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
                Carta carta13 = new Carta();
                Carta carta14 = new Carta();

                Carta carta15 = new Carta();
                Carta carta16 = new Carta();
                Carta carta17 = new Carta();
                Carta carta18 = new Carta();
                Carta carta19 = new Carta();
                Carta carta20 = new Carta();
                Carta carta21 = new Carta();
                Carta carta22 = new Carta();
                Carta carta23 = new Carta();
                Carta carta24 = new Carta();
                Carta carta25 = new Carta();
                Carta carta26 = new Carta();
                Carta carta27 = new Carta();
                Carta carta28 = new Carta();

                Carta carta29 = new Carta();
                Carta carta30 = new Carta();
                Carta carta31 = new Carta();
                Carta carta32 = new Carta();
                Carta carta33 = new Carta();
                Carta carta34 = new Carta();
                Carta carta35 = new Carta();
                Carta carta36 = new Carta();
                Carta carta37 = new Carta();
                Carta carta38 = new Carta();
                Carta carta39 = new Carta();
                Carta carta40 = new Carta();
                Carta carta41 = new Carta();
                Carta carta42 = new Carta();

                Carta carta43 = new Carta();
                Carta carta44 = new Carta();
                Carta carta45 = new Carta();
                Carta carta46 = new Carta();
                Carta carta47 = new Carta();
                Carta carta48 = new Carta();
                Carta carta49 = new Carta();
                Carta carta50 = new Carta();
                Carta carta51 = new Carta();
                Carta carta52 = new Carta();
                Carta carta53 = new Carta();
                Carta carta54 = new Carta();
                Carta carta55 = new Carta();
                Carta carta56 = new Carta();

                minhaListaDeCartas.Add(null);
                minhaListaDeCartas.Add(carta1);
                minhaListaDeCartas.Add(carta2);
                minhaListaDeCartas.Add(carta3);
                minhaListaDeCartas.Add(carta4);
                minhaListaDeCartas.Add(carta5);
                minhaListaDeCartas.Add(carta6);
                minhaListaDeCartas.Add(carta7);
                minhaListaDeCartas.Add(carta8);
                minhaListaDeCartas.Add(carta9);
                minhaListaDeCartas.Add(carta10);
                minhaListaDeCartas.Add(carta11);
                minhaListaDeCartas.Add(carta12);
                minhaListaDeCartas.Add(carta13);
                minhaListaDeCartas.Add(carta14);

                listaDeCartasAdversario.Add(null);
                listaDeCartasAdversario.Add(carta15);
                listaDeCartasAdversario.Add(carta16);
                listaDeCartasAdversario.Add(carta17);
                listaDeCartasAdversario.Add(carta18);
                listaDeCartasAdversario.Add(carta19);
                listaDeCartasAdversario.Add(carta20);
                listaDeCartasAdversario.Add(carta21);
                listaDeCartasAdversario.Add(carta22);
                listaDeCartasAdversario.Add(carta23);
                listaDeCartasAdversario.Add(carta24);
                listaDeCartasAdversario.Add(carta25);
                listaDeCartasAdversario.Add(carta26);
                listaDeCartasAdversario.Add(carta27);
                listaDeCartasAdversario.Add(carta28);

                listaDeCartasAdversario2.Add(null);
                listaDeCartasAdversario2.Add(carta29);
                listaDeCartasAdversario2.Add(carta30);
                listaDeCartasAdversario2.Add(carta31);
                listaDeCartasAdversario2.Add(carta32);
                listaDeCartasAdversario2.Add(carta33);
                listaDeCartasAdversario2.Add(carta34);
                listaDeCartasAdversario2.Add(carta35);
                listaDeCartasAdversario2.Add(carta36);
                listaDeCartasAdversario2.Add(carta37);
                listaDeCartasAdversario2.Add(carta38);
                listaDeCartasAdversario2.Add(carta39);
                listaDeCartasAdversario2.Add(carta40);
                listaDeCartasAdversario2.Add(carta41);
                listaDeCartasAdversario2.Add(carta42);

                listaDeCartasAdversario3.Add(null);
                listaDeCartasAdversario3.Add(carta43);
                listaDeCartasAdversario3.Add(carta44);
                listaDeCartasAdversario3.Add(carta45);
                listaDeCartasAdversario3.Add(carta46);
                listaDeCartasAdversario3.Add(carta47);
                listaDeCartasAdversario3.Add(carta48);
                listaDeCartasAdversario3.Add(carta49);
                listaDeCartasAdversario3.Add(carta50);
                listaDeCartasAdversario3.Add(carta51);
                listaDeCartasAdversario3.Add(carta52);
                listaDeCartasAdversario3.Add(carta53);
                listaDeCartasAdversario3.Add(carta54);
                listaDeCartasAdversario3.Add(carta55);
                listaDeCartasAdversario3.Add(carta56);

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
                    if (item.StartsWith(idJogadorUm))
                    {
                        maoDeCartas.Add(item);
                    }
                    else if (item.StartsWith(idJogadores[0]))
                    {
                        maoDeCartasAdversario.Add(item);
                    }
                    else if (item.StartsWith(idJogadores[1]))
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





                //for(int i = 1; i <= cartas.Length; i++)
                //{
                //    if (cartas[i-1].StartsWith(idJogadorUm))
                //    {
                //        minhaListaDeCartas[i].naipe = cartas[i-1].Substring(cartas[i-1].Length - 1);
                //    }

                //}

                //for (int i = 1; i <= cartas.Length; i++)
                //{
                //    if (cartas[i - 1].StartsWith(idJogadorUm) != true)
                //    {
                //        listaDeCartasAdversario[i].naipe = cartas[i - 1].Substring(cartas[i - 1].Length - 1);
                //    }

                //}

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
                        listaDeCartasAdversario2[i].Top = 40;
                    }
                    else
                    {
                        listaDeCartasAdversario2[i].Top = 140;
                    }

                }

                for (int i = 1; i < listaDeCartasAdversario2.Count; i++)
                {
                    if (i == 1)
                    {
                        Console.WriteLine($"Carta {i} = naipe {listaDeCartasAdversario2[i].naipe}");
                        listaDeCartasAdversario2[i].Left = 350;
                        listaDeCartasAdversario2[i].posicao = i;
                        listaDeCartasAdversario2[i].DescobrirImagem();
                        this.Controls.Add(listaDeCartasAdversario2[i]);
                    }
                    else if (i == 7)
                    {
                        Console.WriteLine($"Carta {i} = naipe {listaDeCartasAdversario2[i].naipe}");
                        listaDeCartasAdversario2[i].posicao = i;
                        listaDeCartasAdversario2[i].Left = 350;
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
                    if (i <= 6)
                    {
                        listaDeCartasAdversario2[i].Top = 80;
                    }
                    else
                    {
                        listaDeCartasAdversario2[i].Top = 180;
                    }

                }

                for (int i = 1; i < listaDeCartasAdversario3.Count; i++)
                {
                    if (i == 1)
                    {
                        Console.WriteLine($"Carta {i} = naipe {listaDeCartasAdversario3[i].naipe}");
                        listaDeCartasAdversario3[i].Left = 350;
                        listaDeCartasAdversario3[i].posicao = i;
                        listaDeCartasAdversario3[i].DescobrirImagem();
                        this.Controls.Add(listaDeCartasAdversario3[i]);
                    }
                    else if (i == 7)
                    {
                        Console.WriteLine($"Carta {i} = naipe {listaDeCartasAdversario3[i].naipe}");
                        listaDeCartasAdversario3[i].posicao = i;
                        listaDeCartasAdversario3[i].Left = 350;
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
                    if (i <= 6)
                    {
                        listaDeCartasAdversario3[i].Top = 160;
                    }
                    else
                    {
                        listaDeCartasAdversario3[i].Top = 260;
                    }

                }
            }



            lstCartas.Items.Clear();
            for (int i = 0; i < cartas.Length - 1; i++)
            {
                lstCartas.Items.Add(cartas[i]);
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


            if (ConsultarVez())
            {
                
                int idJogadorJogando = Convert.ToInt32(idJogadorUm);
                string senhaJogadorJogando = senhaJogadorUm;


                if (idJogadorSorteado == idJogadorUm) //bot começa jogando
                {
                    posicaoVencedor += 4;
                    Console.WriteLine("Eu começo!");
                    int posicaoCartaJogada = 6;
                    string valorCarta = Jogo.Jogar(idJogadorJogando, senhaJogadorJogando, posicaoCartaJogada);
                    MessageBox.Show("Valor da carta jogada: " + valorCarta);
                    //Carta cartaJogada = listaDeCartas[posicaoCartaJogada];
                    //listaDeCartasJogadas.Add(cartaJogada);
                    //cartaJogada.valor = valorCarta;
                    //cartaJogada.VirarImagem();
                    //cartaJogada.Top = 100;
                    //cartaJogada.Left = 750;
                    minhaListaDeCartas[posicaoCartaJogada].valor = valorCarta;
                    minhaListaDeCartas[posicaoCartaJogada].VirarImagem();
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


                    idJogadorSorteado = "0";

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
                        string informacoes = Jogo.ExibirJogadas2(Convert.ToInt32(idDaPartida));
                        Console.WriteLine(informacoes);
                        informacoes = informacoes.Replace('\r', ' ');
                        string[] infos = informacoes.Split('\n');
                        //string[] ultimaJogada = infos[infos.Length - 2].Split(',');
                        string[] dadosVencedor = infos[posicaoVencedor].Split(',');
                        posicaoVencedor += 4;

                        

                        //for (int i = 0; i < ultimaJogada.Length; i++)
                        //{
                        //    Console.WriteLine($"Vetor ultima jogada {ultimaJogada[i]} posição {i}");
                        //}
                        //for (int i = 0; i < infos.Length; i++)
                        //{
                        //    //Console.WriteLine(infos[i]);
                        //}

                        //Console.WriteLine($"O round atual é {ultimaJogada[0]}");

                        //int round = Convert.ToInt32(ultimaJogada[0]);

                        //string jogadasRound = Jogo.ExibirJogadas(Convert.ToInt32(idDaPartida));
                        //Console.WriteLine($"Jogadas no round {jogadasRound}");
                        //jogadasRound = jogadasRound.Replace('\r', ' ');
                        //string[] jogadas = jogadasRound.Split(',');

                        //Naipe jogado pelo ultimo vencedor
                        string naipeJogado = dadosVencedor[2];
                        int posicao = ComparaNaipes(minhaListaDeCartas, naipeJogado);
                        if (posicao == -1)
                        {
                            posicao = ComparaNaipes2(minhaListaDeCartas, "C");
                            Console.WriteLine(posicao);

                            txtPosicaoCarta.Text = posicao.ToString();
                            string valorCarta = Jogo.Jogar(idJogadorJogando, senhaJogadorJogando, posicao);
                            MessageBox.Show("Valor da carta jogada: " + valorCarta);

                            //Carta cartaJogada = listaDeCartas[posicao];
                            //listaDeCartasJogadas.Add(cartaJogada);
                            //cartaJogada.valor = valorCarta;
                            //cartaJogada.VirarImagem();
                            ////cartaJogada.Top = 100;
                            ////cartaJogada.Left = 750;
                            //listaDeCartas[posicao] = null;
                            minhaListaDeCartas[posicao].valor = valorCarta;
                            minhaListaDeCartas[posicao].VirarImagem();
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
                        else
                        {
                            Console.WriteLine(posicao);

                            txtPosicaoCarta.Text = posicao.ToString();
                            string valorCarta = Jogo.Jogar(idJogadorJogando, senhaJogadorJogando, posicao);
                            MessageBox.Show("Valor da carta jogada: " + valorCarta);

                            //Carta cartaJogada = listaDeCartas[posicao];
                            //listaDeCartasJogadas.Add(cartaJogada);
                            //cartaJogada.valor = valorCarta;
                            //cartaJogada.VirarImagem();
                            //cartaJogada.Top = 100;
                            //cartaJogada.Left = 750;
                            minhaListaDeCartas[posicao].valor = valorCarta;
                            minhaListaDeCartas[posicao].VirarImagem();
                            //listaDeCartas[posicao] = null;
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
                        
                        
                    }
                    else //bot ganhou ultima rodada, pode escolher qualquer carta para jogar
                    {
                        posicaoVencedor += 4;
                        int posicao = ComparaNaipes2(minhaListaDeCartas, "O");
                        if (posicao == -1)
                        {
                            
                            posicao = ComparaNaipes2(minhaListaDeCartas, "E");
                            Console.WriteLine(posicao);

                            txtPosicaoCarta.Text = posicao.ToString();
                            string valorCarta = Jogo.Jogar(idJogadorJogando, senhaJogadorJogando, posicao);
                            MessageBox.Show("Valor da carta jogada: " + valorCarta);

                            //Carta cartaJogada = listaDeCartas[posicao];
                            //listaDeCartasJogadas.Add(cartaJogada);
                            //cartaJogada.valor = valorCarta;
                            //cartaJogada.VirarImagem();
                            //cartaJogada.Top = 100;
                            //cartaJogada.Left = 750;
                            //listaDeCartas[posicao] = null;
                            minhaListaDeCartas[posicao].valor = valorCarta;
                            minhaListaDeCartas[posicao].VirarImagem();
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
                        else
                        {
                            Console.WriteLine(posicao);

                            txtPosicaoCarta.Text = posicao.ToString();
                            string valorCarta = Jogo.Jogar(idJogadorJogando, senhaJogadorJogando, posicao);
                            MessageBox.Show("Valor da carta jogada: " + valorCarta);

                            //Carta cartaJogada = listaDeCartas[posicao];
                            //listaDeCartasJogadas.Add(cartaJogada);
                            //cartaJogada.valor = valorCarta;
                            //cartaJogada.VirarImagem();
                            //cartaJogada.Top = 100;
                            //cartaJogada.Left = 750;
                            //listaDeCartas[posicao] = null;
                            minhaListaDeCartas[posicao].valor = valorCarta;
                            minhaListaDeCartas[posicao].VirarImagem();
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
                    }

                }
                AtualizarCampos();
            }

        }


        public int Pontuacao()
        {
            string dados = Jogo.ListarJogadores2(Convert.ToInt32(idPartida));
            //Console.WriteLine(dados);
            dados = dados.Replace('\r',' ');
            string[] dadosPontuacaoJogadores = dados.Split('\n');

            int tamanhoVetor = dadosPontuacaoJogadores.Length;
            //Console.WriteLine($"Tamanho vetor: {tamanhoVetor}");
            //Console.WriteLine($"Dados jogador 1: {dadosPontuacaoJogadores[tamanhoVetor - 3]}");
            //Console.WriteLine($"Dados jogador 2: {dadosPontuacaoJogadores[1]}");

            string[] dadosPontuacao = new string[4];

            foreach (string item in dadosPontuacaoJogadores)
            {
                if (item.StartsWith(idJogadorUm))
                {
                    dadosPontuacao = item.Split(',');

                }
            }

            //Console.WriteLine($"Tamanho do vetor dadosPontuacao {dadosPontuacao.Length}");
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

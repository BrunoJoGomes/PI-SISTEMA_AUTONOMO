using MagicTrickServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI
{
    public class Jogador
    {
        public string nomeDoJogador;
        public string senhaDoJogador;
        public string idDoJogador;
        public List<Carta> cartas = new List<Carta>();

        //public Jogador(string nomeDoJogador)
        //{
        //    this.nomeDoJogador = nomeDoJogador;
        //}

        public void EntrarNaPartida(int idDaPartida, string senhaDaPartida)
        {
            string retorno = Jogo.EntrarPartida(idDaPartida, nomeDoJogador, senhaDaPartida);
            if (retorno.Substring(0, 3) == "ERRO")
            {
                MessageBox.Show("Ocorreu um erro! \n" + retorno.Substring(5), "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                retorno = retorno.Replace("\r", "");
                retorno = retorno.Replace("\n", "");
                this.idDoJogador = retorno.Substring(0, 4);
                this.senhaDoJogador = retorno.Substring(5);
            }
            
        }

        //public void JogarCarta(Carta carta)
        //{

        //}


    }
}

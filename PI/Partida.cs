using MagicTrickServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PI
{
    public class Partida
    {
        public string nomeDaPartida;
        public string senhaDaPartida;
        public string idDaPartida;
        public string statusDaPartida;
        public string dataDaPartida;

        //public Partida(string nomeDaPartida, string senhaDaPartida) 
        //{
        //    this.nomeDaPartida = nomeDaPartida;
        //    this.senhaDaPartida = senhaDaPartida;
        //}    

        public void CriarPartida(string nomeDoGrupo)
        {
            this.idDaPartida = Jogo.CriarPartida(nomeDaPartida, senhaDaPartida, nomeDoGrupo);
            if (idDaPartida.Substring(0, 3) == "ERRO")
            {
                MessageBox.Show("Ocorreu um erro! \n" + idDaPartida.Substring(5), "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Grupo salvo", "SUCESSO!");
            }
        }
    }
}

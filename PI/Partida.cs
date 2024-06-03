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

        public void CriarPartida(string nomeDoGrupo)
        {
            string retorno = Jogo.CriarPartida(nomeDaPartida, senhaDaPartida, nomeDoGrupo);
            if (retorno.Substring(0, 2) == "ER")
            {
                MessageBox.Show("Ocorreu um erro! \n" + retorno.Substring(5), "ERRO!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                this.idDaPartida = retorno;
            }
        }
    }
}

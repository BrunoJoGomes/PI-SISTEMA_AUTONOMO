using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace PI
{
    public class Carta : Panel
    {
        public string naipe;
        public string valor;
        public int posicao;

        public void DescobrirImagem()
        {
            if (this.naipe == "O")
            {
                this.BackgroundImage = Properties.Resources.Ouros1;
                this.BackColor = Color.Transparent;
                this.BackgroundImageLayout = ImageLayout.Stretch;
                this.Height = 70;
                this.Width = 50;
            }
            else if (this.naipe == "E")
            {
                this.BackgroundImage = Properties.Resources.Espadas1;
                this.BackColor = Color.Transparent;
                this.BackgroundImageLayout = ImageLayout.Stretch;
                this.Height = 70;
                this.Width = 50;
            }
            else if (this.naipe == "C")
            {
                this.BackgroundImage = Properties.Resources.Copas1;
                this.BackColor = Color.Transparent;
                this.BackgroundImageLayout = ImageLayout.Stretch;
                this.Height = 70;
                this.Width = 50;
            }
            else if (this.naipe == "S")
            {
                this.BackgroundImage = Properties.Resources.Estrela1;
                this.BackColor = Color.Transparent;
                this.BackgroundImageLayout = ImageLayout.Stretch;
                this.Height = 70;
                this.Width = 50;
            }
            else if (this.naipe == "L")
            {
                this.BackgroundImage = Properties.Resources.Lua1;
                this.BackColor = Color.Transparent;
                this.BackgroundImageLayout = ImageLayout.Stretch;
                this.Height = 70;
                this.Width = 50;
            }
            else if (this.naipe == "P")
            {
                this.BackgroundImage = Properties.Resources.Paus1;
                this.BackColor = Color.Transparent;
                this.BackgroundImageLayout = ImageLayout.Stretch;
                this.Height = 70;
                this.Width = 50;
            }
            else
            {
                this.BackgroundImage = Properties.Resources.Triângulo1;
                this.BackColor = Color.Transparent;
                this.BackgroundImageLayout = ImageLayout.Stretch;
                this.Height = 70;
                this.Width = 50;

            }

        
        }

        public void VirarImagem()
        {
            if (this.naipe == "O")
            {
                this.BackgroundImage = Properties.Resources.Ouros2;
            }
            else if (this.naipe == "E")
            {
                this.BackgroundImage = Properties.Resources.Espadas2;
            }
            else if (this.naipe == "C")
            {
                this.BackgroundImage = Properties.Resources.Copas2;
            }
            else if (this.naipe == "S")
            {
                this.BackgroundImage = Properties.Resources.Estrela2;
            }
            else if (this.naipe == "L")
            {
                this.BackgroundImage = Properties.Resources.Lua2;
            }
            else if (this.naipe == "P")
            {
                this.BackgroundImage = Properties.Resources.Paus2;
            }
            else
            {
                this.BackgroundImage = Properties.Resources.Triângulo2;

            }


        }
    }
}

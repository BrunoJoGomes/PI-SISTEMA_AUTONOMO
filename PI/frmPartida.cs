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

        
        Panel pnlCarta1 = new Panel();
        Panel pnlCarta2 = new Panel();
        Panel pnlCarta3 = new Panel();
        Panel pnlCarta4 = new Panel();
        Panel pnlCarta5 = new Panel();
        Panel pnlCarta6 = new Panel();
        Panel pnlCarta7 = new Panel();
        Panel pnlCarta8 = new Panel();
        Panel pnlCarta9 = new Panel();
        Panel pnlCarta10 = new Panel();
        Panel pnlCarta11 = new Panel();
        Panel pnlCarta12 = new Panel();
        Panel pnlCarta13 = new Panel();
        Panel pnlCarta14 = new Panel();
        Panel pnlCarta15 = new Panel();
        Panel pnlCarta16 = new Panel();
        Panel pnlCarta17 = new Panel();
        Panel pnlCarta18 = new Panel();
        Panel pnlCarta19 = new Panel();
        Panel pnlCarta20 = new Panel();
        Panel pnlCarta21 = new Panel();
        Panel pnlCarta22 = new Panel();
        Panel pnlCarta23 = new Panel();
        Panel pnlCarta24 = new Panel();

        List<Panel> paineis = new List<Panel>();
        

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

        string[] cartas = new string[24];


        private void btnMostrarCartas_Click(object sender, EventArgs e)
        {
            Console.WriteLine(lblPartida.Text);
            int idpartida = Convert.ToInt32(lblPartida.Text);
            string retorno = Jogo.ConsultarMao(idpartida);

            retorno = retorno.Replace("\r", "");
            cartas = retorno.Split('\n');

            lstCartas.Items.Clear();
            for (int i = 0; i < cartas.Length - 1; i++)
            {
                lstCartas.Items.Add(cartas[i]);
            }

            
            pnlCarta1.Left = 190;
            pnlCarta1.Top = 360;
            pnlCarta1.Height = 70;
            pnlCarta1.Width = 50;

            pnlCarta2.Left = pnlCarta1.Width + 200;
            pnlCarta2.Top = 360;
            pnlCarta2.Height = 70;
            pnlCarta2.Width = 50;

            pnlCarta3.Left = pnlCarta1.Width + 260;
            pnlCarta3.Top = 360;
            pnlCarta3.Height = 70;
            pnlCarta3.Width = 50;

            pnlCarta4.Left = pnlCarta1.Width + 320;
            pnlCarta4.Top = 360;
            pnlCarta4.Height = 70;
            pnlCarta4.Width = 50;

            pnlCarta5.Left = pnlCarta1.Width + 380;
            pnlCarta5.Top = 360;
            pnlCarta5.Height = 70;
            pnlCarta5.Width = 50;

            pnlCarta6.Left = pnlCarta1.Width + 440;
            pnlCarta6.Top = 360;
            pnlCarta6.Height = 70;
            pnlCarta6.Width = 50;

            pnlCarta7.Left = pnlCarta1.Width + 500;
            pnlCarta7.Top = 360;
            pnlCarta7.Height = 70;
            pnlCarta7.Width = 50;

            pnlCarta8.Left = pnlCarta1.Width + 560;
            pnlCarta8.Top = 360;
            pnlCarta8.Height = 70;
            pnlCarta8.Width = 50;

            pnlCarta9.Left = pnlCarta1.Width + 620;
            pnlCarta9.Top = 360;
            pnlCarta9.Height = 70;
            pnlCarta9.Width = 50;

            pnlCarta10.Left = pnlCarta1.Width + 680;
            pnlCarta10.Top = 360;
            pnlCarta10.Height = 70;
            pnlCarta10.Width = 50;

            pnlCarta11.Left = pnlCarta1.Width + 740;
            pnlCarta11.Top = 360;
            pnlCarta11.Height = 70;
            pnlCarta11.Width = 50;

            pnlCarta12.Left = pnlCarta1.Width + 800;
            pnlCarta12.Top = 360;
            pnlCarta12.Height = 70;
            pnlCarta12.Width = 50;

            pnlCarta13.Left = 190;
            pnlCarta13.Top = 470;
            pnlCarta13.Height = 70;
            pnlCarta13.Width = 50;

            pnlCarta14.Left = pnlCarta13.Width + 200;
            pnlCarta14.Top = 470;
            pnlCarta14.Height = 70;
            pnlCarta14.Width = 50;

            pnlCarta15.Left = pnlCarta13.Width + 260;
            pnlCarta15.Top = 470;
            pnlCarta15.Height = 70;
            pnlCarta15.Width = 50;

            pnlCarta16.Left = pnlCarta13.Width + 320;
            pnlCarta16.Top = 470;
            pnlCarta16.Height = 70;
            pnlCarta16.Width = 50;

            pnlCarta17.Left = pnlCarta13.Width + 380;
            pnlCarta17.Top = 470;
            pnlCarta17.Height = 70;
            pnlCarta17.Width = 50;

            pnlCarta18.Left = pnlCarta13.Width + 440;
            pnlCarta18.Top = 470;
            pnlCarta18.Height = 70;
            pnlCarta18.Width = 50;

            pnlCarta19.Left = pnlCarta13.Width + 500;
            pnlCarta19.Top = 470;
            pnlCarta19.Height = 70;
            pnlCarta19.Width = 50;

            pnlCarta20.Left = pnlCarta13.Width + 560;
            pnlCarta20.Top = 470;
            pnlCarta20.Height = 70;
            pnlCarta20.Width = 50;

            pnlCarta21.Left = pnlCarta13.Width + 620;
            pnlCarta21.Top = 470;
            pnlCarta21.Height = 70;
            pnlCarta21.Width = 50;

            pnlCarta22.Left = pnlCarta13.Width + 680;
            pnlCarta22.Top = 470;
            pnlCarta22.Height = 70;
            pnlCarta22.Width = 50;

            pnlCarta23.Left = pnlCarta13.Width + 740;
            pnlCarta23.Top = 470;
            pnlCarta23.Height = 70;
            pnlCarta23.Width = 50;

            pnlCarta24.Left = pnlCarta13.Width + 800;
            pnlCarta24.Top = 470;
            pnlCarta24.Height = 70;
            pnlCarta24.Width = 50;


            if (cartas[0].Substring(7) == "O")
            {
                pnlCarta1.BackgroundImage = Properties.Resources.Ouros1;
                pnlCarta1.BackColor = Color.Transparent;
                pnlCarta1.BackgroundImageLayout = ImageLayout.Stretch;
                this.Controls.Add(pnlCarta1);
            }
            else if (cartas[0].Substring(7) == "E")
            {
                pnlCarta1.BackgroundImage = Properties.Resources.Espadas1;
                pnlCarta1.BackColor = Color.Transparent;
                pnlCarta1.BackgroundImageLayout = ImageLayout.Stretch;
                this.Controls.Add(pnlCarta1);
            }
            else
            {
                
               pnlCarta1.BackgroundImage = Properties.Resources.Copas1;
               pnlCarta1.BackColor = Color.Transparent;
               pnlCarta1.BackgroundImageLayout = ImageLayout.Stretch;
               this.Controls.Add(pnlCarta1);
            }

            if (cartas[1].Substring(7) == "O")
            {
                pnlCarta2.BackgroundImage = Properties.Resources.Ouros1;
                pnlCarta2.BackColor = Color.Transparent;
                pnlCarta2.BackgroundImageLayout = ImageLayout.Stretch;
                this.Controls.Add(pnlCarta2);
            }
            else if (cartas[1].Substring(7) == "E")
            {
                pnlCarta2.BackgroundImage = Properties.Resources.Espadas1;
                pnlCarta2.BackColor = Color.Transparent;
                pnlCarta2.BackgroundImageLayout = ImageLayout.Stretch;
                this.Controls.Add(pnlCarta2);
            }
            else
            {

                pnlCarta2.BackgroundImage = Properties.Resources.Copas1;
                pnlCarta2.BackColor = Color.Transparent;
                pnlCarta2.BackgroundImageLayout = ImageLayout.Stretch;
                this.Controls.Add(pnlCarta2);
            }

            if (cartas[2].Substring(7) == "O")
            {
                pnlCarta3.BackgroundImage = Properties.Resources.Ouros1;
                pnlCarta3.BackColor = Color.Transparent;
                pnlCarta3.BackgroundImageLayout = ImageLayout.Stretch;
                this.Controls.Add(pnlCarta3);
            }
            else if (cartas[2].Substring(7) == "E")
            {
                pnlCarta3.BackgroundImage = Properties.Resources.Espadas1;
                pnlCarta3.BackColor = Color.Transparent;
                pnlCarta3.BackgroundImageLayout = ImageLayout.Stretch;
                this.Controls.Add(pnlCarta3);
            }
            else
            {

                pnlCarta3.BackgroundImage = Properties.Resources.Copas1;
                pnlCarta3.BackColor = Color.Transparent;
                pnlCarta3.BackgroundImageLayout = ImageLayout.Stretch;
                this.Controls.Add(pnlCarta3);
            }

            if (cartas[3].Substring(7) == "O")
            {
                pnlCarta4.BackgroundImage = Properties.Resources.Ouros1;
                pnlCarta4.BackColor = Color.Transparent;
                pnlCarta4.BackgroundImageLayout = ImageLayout.Stretch;
                this.Controls.Add(pnlCarta4);
            }
            else if (cartas[3].Substring(7) == "E")
            {
                pnlCarta4.BackgroundImage = Properties.Resources.Espadas1;
                pnlCarta4.BackColor = Color.Transparent;
                pnlCarta4.BackgroundImageLayout = ImageLayout.Stretch;
                this.Controls.Add(pnlCarta4);
            }
            else
            {

                pnlCarta4.BackgroundImage = Properties.Resources.Copas1;
                pnlCarta4.BackColor = Color.Transparent;
                pnlCarta4.BackgroundImageLayout = ImageLayout.Stretch;
                this.Controls.Add(pnlCarta4);
            }

            if (cartas[4].Substring(7) == "O")
            {
                pnlCarta5.BackgroundImage = Properties.Resources.Ouros1;
                pnlCarta5.BackColor = Color.Transparent;
                pnlCarta5.BackgroundImageLayout = ImageLayout.Stretch;
                this.Controls.Add(pnlCarta5);
            }
            else if (cartas[4].Substring(7) == "E")
            {
                pnlCarta5.BackgroundImage = Properties.Resources.Espadas1;
                pnlCarta5.BackColor = Color.Transparent;
                pnlCarta5.BackgroundImageLayout = ImageLayout.Stretch;
                this.Controls.Add(pnlCarta5);
            }
            else
            {

                pnlCarta5.BackgroundImage = Properties.Resources.Copas1;
                pnlCarta5.BackColor = Color.Transparent;
                pnlCarta5.BackgroundImageLayout = ImageLayout.Stretch;
                this.Controls.Add(pnlCarta5);
            }

            if (cartas[5].Substring(7) == "O")
            {
                pnlCarta6.BackgroundImage = Properties.Resources.Ouros1;
                pnlCarta6.BackColor = Color.Transparent;
                pnlCarta6.BackgroundImageLayout = ImageLayout.Stretch;
                this.Controls.Add(pnlCarta6);
            }
            else if (cartas[5].Substring(7) == "E")
            {
                pnlCarta6.BackgroundImage = Properties.Resources.Espadas1;
                pnlCarta6.BackColor = Color.Transparent;
                pnlCarta6.BackgroundImageLayout = ImageLayout.Stretch;
                this.Controls.Add(pnlCarta6);
            }
            else
            {

                pnlCarta6.BackgroundImage = Properties.Resources.Copas1;
                pnlCarta6.BackColor = Color.Transparent;
                pnlCarta6.BackgroundImageLayout = ImageLayout.Stretch;
                this.Controls.Add(pnlCarta6);
            }

            if (cartas[6].Substring(7) == "O")
            {
                pnlCarta7.BackgroundImage = Properties.Resources.Ouros1;
                pnlCarta7.BackColor = Color.Transparent;
                pnlCarta7.BackgroundImageLayout = ImageLayout.Stretch;
                this.Controls.Add(pnlCarta7);
            }
            else if (cartas[6].Substring(7) == "E")
            {
                pnlCarta7.BackgroundImage = Properties.Resources.Espadas1;
                pnlCarta7.BackColor = Color.Transparent;
                pnlCarta7.BackgroundImageLayout = ImageLayout.Stretch;
                this.Controls.Add(pnlCarta7);
            }
            else
            {

                pnlCarta7.BackgroundImage = Properties.Resources.Copas1;
                pnlCarta7.BackColor = Color.Transparent;
                pnlCarta7.BackgroundImageLayout = ImageLayout.Stretch;
                this.Controls.Add(pnlCarta7);
            }

            if (cartas[7].Substring(7) == "O")
            {
                pnlCarta8.BackgroundImage = Properties.Resources.Ouros1;
                pnlCarta8.BackColor = Color.Transparent;
                pnlCarta8.BackgroundImageLayout = ImageLayout.Stretch;
                this.Controls.Add(pnlCarta8);
            }
            else if (cartas[7].Substring(7) == "E")
            {
                pnlCarta8.BackgroundImage = Properties.Resources.Espadas1;
                pnlCarta8.BackColor = Color.Transparent;
                pnlCarta8.BackgroundImageLayout = ImageLayout.Stretch;
                this.Controls.Add(pnlCarta8);
            }
            else
            {

                pnlCarta8.BackgroundImage = Properties.Resources.Copas1;
                pnlCarta8.BackColor = Color.Transparent;
                pnlCarta8.BackgroundImageLayout = ImageLayout.Stretch;
                this.Controls.Add(pnlCarta8);
            }

            if (cartas[8].Substring(7) == "O")
            {
                pnlCarta9.BackgroundImage = Properties.Resources.Ouros1;
                pnlCarta9.BackColor = Color.Transparent;
                pnlCarta9.BackgroundImageLayout = ImageLayout.Stretch;
                this.Controls.Add(pnlCarta9);
            }
            else if (cartas[8].Substring(7) == "E")
            {
                pnlCarta9.BackgroundImage = Properties.Resources.Espadas1;
                pnlCarta9.BackColor = Color.Transparent;
                pnlCarta9.BackgroundImageLayout = ImageLayout.Stretch;
                this.Controls.Add(pnlCarta9);
            }
            else
            {

                pnlCarta9.BackgroundImage = Properties.Resources.Copas1;
                pnlCarta9.BackColor = Color.Transparent;
                pnlCarta9.BackgroundImageLayout = ImageLayout.Stretch;
                this.Controls.Add(pnlCarta9);
            }

            if (cartas[9].Substring(8) == "O")
            {
                pnlCarta10.BackgroundImage = Properties.Resources.Ouros1;
                pnlCarta10.BackColor = Color.Transparent;
                pnlCarta10.BackgroundImageLayout = ImageLayout.Stretch;
                this.Controls.Add(pnlCarta10);
            }
            else if (cartas[9].Substring(8) == "E")
            {
                pnlCarta10.BackgroundImage = Properties.Resources.Espadas1;
                pnlCarta10.BackColor = Color.Transparent;
                pnlCarta10.BackgroundImageLayout = ImageLayout.Stretch;
                this.Controls.Add(pnlCarta10);
            }
            else
            {

                pnlCarta10.BackgroundImage = Properties.Resources.Copas1;
                pnlCarta10.BackColor = Color.Transparent;
                pnlCarta10.BackgroundImageLayout = ImageLayout.Stretch;
                this.Controls.Add(pnlCarta10);
            }

            if (cartas[10].Substring(8) == "O")
            {
                pnlCarta11.BackgroundImage = Properties.Resources.Ouros1;
                pnlCarta11.BackColor = Color.Transparent;
                pnlCarta11.BackgroundImageLayout = ImageLayout.Stretch;
                this.Controls.Add(pnlCarta11);
            }
            else if (cartas[10].Substring(8) == "E")
            {
                pnlCarta11.BackgroundImage = Properties.Resources.Espadas1;
                pnlCarta11.BackColor = Color.Transparent;
                pnlCarta11.BackgroundImageLayout = ImageLayout.Stretch;
                this.Controls.Add(pnlCarta11);
            }
            else
            {

                pnlCarta11.BackgroundImage = Properties.Resources.Copas1;
                pnlCarta11.BackColor = Color.Transparent;
                pnlCarta11.BackgroundImageLayout = ImageLayout.Stretch;
                this.Controls.Add(pnlCarta11);
            }

            if (cartas[11].Substring(8) == "O")
            {
                pnlCarta12.BackgroundImage = Properties.Resources.Ouros1;
                pnlCarta12.BackColor = Color.Transparent;
                pnlCarta12.BackgroundImageLayout = ImageLayout.Stretch;
                this.Controls.Add(pnlCarta12);
            }
            else if (cartas[11].Substring(8) == "E")
            {
                pnlCarta12.BackgroundImage = Properties.Resources.Espadas1;
                pnlCarta12.BackColor = Color.Transparent;
                pnlCarta12.BackgroundImageLayout = ImageLayout.Stretch;
                this.Controls.Add(pnlCarta12);
            }
            else
            {

                pnlCarta12.BackgroundImage = Properties.Resources.Copas1;
                pnlCarta12.BackColor = Color.Transparent;
                pnlCarta12.BackgroundImageLayout = ImageLayout.Stretch;
                this.Controls.Add(pnlCarta12);
            }

            if (cartas[12].Substring(7) == "O")
            {
                pnlCarta13.BackgroundImage = Properties.Resources.Ouros1;
                pnlCarta13.BackColor = Color.Transparent;
                pnlCarta13.BackgroundImageLayout = ImageLayout.Stretch;
                this.Controls.Add(pnlCarta13);
            }
            else if (cartas[12].Substring(7) == "E")
            {
                pnlCarta13.BackgroundImage = Properties.Resources.Espadas1;
                pnlCarta13.BackColor = Color.Transparent;
                pnlCarta13.BackgroundImageLayout = ImageLayout.Stretch;
                this.Controls.Add(pnlCarta13);
            }
            else
            {

                pnlCarta13.BackgroundImage = Properties.Resources.Copas1;
                pnlCarta13.BackColor = Color.Transparent;
                pnlCarta13.BackgroundImageLayout = ImageLayout.Stretch;
                this.Controls.Add(pnlCarta13);
            }

            if (cartas[13].Substring(7) == "O")
            {
                pnlCarta14.BackgroundImage = Properties.Resources.Ouros1;
                pnlCarta14.BackColor = Color.Transparent;
                pnlCarta14.BackgroundImageLayout = ImageLayout.Stretch;
                this.Controls.Add(pnlCarta14);
            }
            else if (cartas[13].Substring(7) == "E")
            {
                pnlCarta14.BackgroundImage = Properties.Resources.Espadas1;
                pnlCarta14.BackColor = Color.Transparent;
                pnlCarta14.BackgroundImageLayout = ImageLayout.Stretch;
                this.Controls.Add(pnlCarta14);
            }
            else
            {

                pnlCarta14.BackgroundImage = Properties.Resources.Copas1;
                pnlCarta14.BackColor = Color.Transparent;
                pnlCarta14.BackgroundImageLayout = ImageLayout.Stretch;
                this.Controls.Add(pnlCarta14);
            }

            if (cartas[14].Substring(7) == "O")
            {
                pnlCarta15.BackgroundImage = Properties.Resources.Ouros1;
                pnlCarta15.BackColor = Color.Transparent;
                pnlCarta15.BackgroundImageLayout = ImageLayout.Stretch;
                this.Controls.Add(pnlCarta15);
            }
            else if (cartas[14].Substring(7) == "E")
            {
                pnlCarta15.BackgroundImage = Properties.Resources.Espadas1;
                pnlCarta15.BackColor = Color.Transparent;
                pnlCarta15.BackgroundImageLayout = ImageLayout.Stretch;
                this.Controls.Add(pnlCarta15);
            }
            else
            {

                pnlCarta15.BackgroundImage = Properties.Resources.Copas1;
                pnlCarta15.BackColor = Color.Transparent;
                pnlCarta15.BackgroundImageLayout = ImageLayout.Stretch;
                this.Controls.Add(pnlCarta15);
            }

            if (cartas[15].Substring(7) == "O")
            {
                pnlCarta16.BackgroundImage = Properties.Resources.Ouros1;
                pnlCarta16.BackColor = Color.Transparent;
                pnlCarta16.BackgroundImageLayout = ImageLayout.Stretch;
                this.Controls.Add(pnlCarta16);
            }
            else if (cartas[15].Substring(7) == "E")
            {
                pnlCarta16.BackgroundImage = Properties.Resources.Espadas1;
                pnlCarta16.BackColor = Color.Transparent;
                pnlCarta16.BackgroundImageLayout = ImageLayout.Stretch;
                this.Controls.Add(pnlCarta16);
            }
            else
            {

                pnlCarta16.BackgroundImage = Properties.Resources.Copas1;
                pnlCarta16.BackColor = Color.Transparent;
                pnlCarta16.BackgroundImageLayout = ImageLayout.Stretch;
                this.Controls.Add(pnlCarta16);
            }

            if (cartas[16].Substring(7) == "O")
            {
                pnlCarta17.BackgroundImage = Properties.Resources.Ouros1;
                pnlCarta17.BackColor = Color.Transparent;
                pnlCarta17.BackgroundImageLayout = ImageLayout.Stretch;
                this.Controls.Add(pnlCarta17);
            }
            else if (cartas[16].Substring(7) == "E")
            {
                pnlCarta17.BackgroundImage = Properties.Resources.Espadas1;
                pnlCarta17.BackColor = Color.Transparent;
                pnlCarta17.BackgroundImageLayout = ImageLayout.Stretch;
                this.Controls.Add(pnlCarta17);
            }
            else
            {

                pnlCarta17.BackgroundImage = Properties.Resources.Copas1;
                pnlCarta17.BackColor = Color.Transparent;
                pnlCarta17.BackgroundImageLayout = ImageLayout.Stretch;
                this.Controls.Add(pnlCarta17);
            }

            if (cartas[17].Substring(7) == "O")
            {
                pnlCarta18.BackgroundImage = Properties.Resources.Ouros1;
                pnlCarta18.BackColor = Color.Transparent;
                pnlCarta18.BackgroundImageLayout = ImageLayout.Stretch;
                this.Controls.Add(pnlCarta18);
            }
            else if (cartas[17].Substring(7) == "E")
            {
                pnlCarta18.BackgroundImage = Properties.Resources.Espadas1;
                pnlCarta18.BackColor = Color.Transparent;
                pnlCarta18.BackgroundImageLayout = ImageLayout.Stretch;
                this.Controls.Add(pnlCarta18);
            }
            else
            {

                pnlCarta18.BackgroundImage = Properties.Resources.Copas1;
                pnlCarta18.BackColor = Color.Transparent;
                pnlCarta18.BackgroundImageLayout = ImageLayout.Stretch;
                this.Controls.Add(pnlCarta18);
            }

            if (cartas[18].Substring(7) == "O")
            {
                pnlCarta19.BackgroundImage = Properties.Resources.Ouros1;
                pnlCarta19.BackColor = Color.Transparent;
                pnlCarta19.BackgroundImageLayout = ImageLayout.Stretch;
                this.Controls.Add(pnlCarta19);
            }
            else if (cartas[18].Substring(7) == "E")
            {
                pnlCarta19.BackgroundImage = Properties.Resources.Espadas1;
                pnlCarta19.BackColor = Color.Transparent;
                pnlCarta19.BackgroundImageLayout = ImageLayout.Stretch;
                this.Controls.Add(pnlCarta19);
            }
            else
            {

                pnlCarta19.BackgroundImage = Properties.Resources.Copas1;
                pnlCarta19.BackColor = Color.Transparent;
                pnlCarta19.BackgroundImageLayout = ImageLayout.Stretch;
                this.Controls.Add(pnlCarta19);
            }

            if (cartas[19].Substring(7) == "O")
            {
                pnlCarta20.BackgroundImage = Properties.Resources.Ouros1;
                pnlCarta20.BackColor = Color.Transparent;
                pnlCarta20.BackgroundImageLayout = ImageLayout.Stretch;
                this.Controls.Add(pnlCarta20);
            }
            else if (cartas[19].Substring(7) == "E")
            {
                pnlCarta20.BackgroundImage = Properties.Resources.Espadas1;
                pnlCarta20.BackColor = Color.Transparent;
                pnlCarta20.BackgroundImageLayout = ImageLayout.Stretch;
                this.Controls.Add(pnlCarta20);
            }
            else
            {

                pnlCarta20.BackgroundImage = Properties.Resources.Copas1;
                pnlCarta20.BackColor = Color.Transparent;
                pnlCarta20.BackgroundImageLayout = ImageLayout.Stretch;
                this.Controls.Add(pnlCarta20);
            }

            if (cartas[20].Substring(7) == "O")
            {
                pnlCarta21.BackgroundImage = Properties.Resources.Ouros1;
                pnlCarta21.BackColor = Color.Transparent;
                pnlCarta21.BackgroundImageLayout = ImageLayout.Stretch;
                this.Controls.Add(pnlCarta21);
            }
            else if (cartas[20].Substring(7) == "E")
            {
                pnlCarta21.BackgroundImage = Properties.Resources.Espadas1;
                pnlCarta21.BackColor = Color.Transparent;
                pnlCarta21.BackgroundImageLayout = ImageLayout.Stretch;
                this.Controls.Add(pnlCarta21);
            }
            else
            {

                pnlCarta21.BackgroundImage = Properties.Resources.Copas1;
                pnlCarta21.BackColor = Color.Transparent;
                pnlCarta21.BackgroundImageLayout = ImageLayout.Stretch;
                this.Controls.Add(pnlCarta21);
            }

            if (cartas[21].Substring(8) == "O")
            {
                pnlCarta22.BackgroundImage = Properties.Resources.Ouros1;
                pnlCarta22.BackColor = Color.Transparent;
                pnlCarta22.BackgroundImageLayout = ImageLayout.Stretch;
                this.Controls.Add(pnlCarta22);
            }
            else if (cartas[21].Substring(8) == "E")
            {
                pnlCarta22.BackgroundImage = Properties.Resources.Espadas1;
                pnlCarta22.BackColor = Color.Transparent;
                pnlCarta22.BackgroundImageLayout = ImageLayout.Stretch;
                this.Controls.Add(pnlCarta22);
            }
            else
            {

                pnlCarta22.BackgroundImage = Properties.Resources.Copas1;
                pnlCarta22.BackColor = Color.Transparent;
                pnlCarta22.BackgroundImageLayout = ImageLayout.Stretch;
                this.Controls.Add(pnlCarta22);
            }

            if (cartas[22].Substring(8) == "O")
            {
                pnlCarta23.BackgroundImage = Properties.Resources.Ouros1;
                pnlCarta23.BackColor = Color.Transparent;
                pnlCarta23.BackgroundImageLayout = ImageLayout.Stretch;
                this.Controls.Add(pnlCarta23);
            }
            else if (cartas[22].Substring(8) == "E")
            {
                pnlCarta23.BackgroundImage = Properties.Resources.Espadas1;
                pnlCarta23.BackColor = Color.Transparent;
                pnlCarta23.BackgroundImageLayout = ImageLayout.Stretch;
                this.Controls.Add(pnlCarta23);
            }
            else
            {

                pnlCarta23.BackgroundImage = Properties.Resources.Copas1;
                pnlCarta23.BackColor = Color.Transparent;
                pnlCarta23.BackgroundImageLayout = ImageLayout.Stretch;
                this.Controls.Add(pnlCarta23);
            }

            if (cartas[23].Substring(8) == "O")
            {
                pnlCarta24.BackgroundImage = Properties.Resources.Ouros1;
                pnlCarta24.BackColor = Color.Transparent;
                pnlCarta24.BackgroundImageLayout = ImageLayout.Stretch;
                this.Controls.Add(pnlCarta24);
            }
            else if (cartas[23].Substring(8) == "E")
            {
                pnlCarta24.BackgroundImage = Properties.Resources.Espadas1;
                pnlCarta24.BackColor = Color.Transparent;
                pnlCarta24.BackgroundImageLayout = ImageLayout.Stretch;
                this.Controls.Add(pnlCarta24);
            }
            else
            {

                pnlCarta24.BackgroundImage = Properties.Resources.Copas1;
                pnlCarta24.BackColor = Color.Transparent;
                pnlCarta24.BackgroundImageLayout = ImageLayout.Stretch;
                this.Controls.Add(pnlCarta24);
            }

            paineis.Add(pnlCarta1);
            paineis.Add(pnlCarta2);
            paineis.Add(pnlCarta3);
            paineis.Add(pnlCarta4);
            paineis.Add(pnlCarta5);
            paineis.Add(pnlCarta6);
            paineis.Add(pnlCarta7);
            paineis.Add(pnlCarta8);
            paineis.Add(pnlCarta9);
            paineis.Add(pnlCarta10);
            paineis.Add(pnlCarta11);
            paineis.Add(pnlCarta12);
            paineis.Add(pnlCarta13);
            paineis.Add(pnlCarta14);
            paineis.Add(pnlCarta15);
            paineis.Add(pnlCarta16);
            paineis.Add(pnlCarta17);
            paineis.Add(pnlCarta18);
            paineis.Add(pnlCarta19);
            paineis.Add(pnlCarta20);
            paineis.Add(pnlCarta21);
            paineis.Add(pnlCarta22);
            paineis.Add(pnlCarta23);
            paineis.Add(pnlCarta24);

            

        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            int idJogadorJogando = Convert.ToInt32(txtIdJogadorJogando.Text);
            string senhaJogadorJogando = txtSenhaJogadorJogando.Text;
            int posicaoCartaJogada = Convert.ToInt32(txtPosicaoCarta.Text);

            string valorCarta = Jogo.Jogar(idJogadorJogando, senhaJogadorJogando, posicaoCartaJogada);
            MessageBox.Show("Valor da carta jogada: " + valorCarta);

            
            Panel cartaJogada = paineis[posicaoCartaJogada - 1];
            cartaJogada.Top = 100;
            cartaJogada.Left = 750;
            lblValorCarta.Text = valorCarta;

            //Panel pnlCartaJogada = new Panel();
            //pnlCartaJogada.Left = 100;
            //pnlCartaJogada.Top = 50;
            //pnlCartaJogada.Height = 70;
            //pnlCartaJogada.Width = 50;

            //if (cartas[posicaoCartaJogada].Substring(7) == "O")
            //{
            //    pnlCartaJogada.BackgroundImage = Properties.Resources.Ouros1;
            //    pnlCartaJogada.BackColor = Color.Transparent;
            //    pnlCartaJogada.BackgroundImageLayout = ImageLayout.Stretch;
            //    this.Controls.Add(pnlCartaJogada);
            //}
            //else if (cartas[posicaoCartaJogada-1].Substring(7) == "E")
            //{
            //    pnlCartaJogada.BackgroundImage = Properties.Resources.Espadas1;
            //    pnlCartaJogada.BackColor = Color.Transparent;
            //    pnlCartaJogada.BackgroundImageLayout = ImageLayout.Stretch;
            //    this.Controls.Add(pnlCartaJogada);
            //}
            //else
            //{

            //    pnlCartaJogada.BackgroundImage = Properties.Resources.Copas1;
            //    pnlCartaJogada.BackColor = Color.Transparent;
            //    pnlCartaJogada.BackgroundImageLayout = ImageLayout.Stretch;
            //    this.Controls.Add(pnlCartaJogada);
            //}
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pedra_Papel_Tesoura
{
    public partial class Form1 : Form
    {
        Image[] imgMaq = new Image[] { 
            Properties.Resources.Pedra, Properties.Resources.Papel, 
            Properties.Resources.Tesoura
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ClickJogada(object sender, EventArgs e)
        {
            Button bt = (Button)sender;
            PicJogador.Image = bt.BackgroundImage;
            Jogada jogadaJog = RetornaJogadaJog(Convert.ToInt32(bt.Tag));
            Jogada jogadaMaq = RetornaJogadaMaq();
            Resultado result = Ganhador(jogadaJog, jogadaMaq);
            if (result == Resultado.VenceMaq)
            {
                LbPtmaq.Text = (int.Parse(LbPtmaq.Text) + 1).ToString();
            }
            else if (result == Resultado.VenceJog)
            {
                LbPtJog.Text = (int.Parse(LbPtJog.Text) + 1).ToString();
            }
        }

        private Resultado Ganhador(Jogada Jog, Jogada Maq)
        {
            if (Jog == Jogada.Pedra)
            {
                if (Maq == Jogada.Papel)
                {
                    return Resultado.VenceMaq;
                }else if (Maq == Jogada.Tesoura)
                {
                    return Resultado.VenceJog;
                }
            }else if (Jog == Jogada.Papel)
            {
                if (Maq == Jogada.Pedra)
                {
                    return Resultado.VenceJog;
                }
                else if (Maq == Jogada.Tesoura)
                {
                    return Resultado.VenceMaq;
                }
            }
            else
            {
                if (Maq == Jogada.Pedra)
                {
                    return Resultado.VenceMaq;
                }
                else if (Maq == Jogada.Papel)
                {
                    return Resultado.VenceJog;
                }
            }
            return Resultado.Empate;
        }

        private Jogada RetornaJogadaJog(int escolha)
        {
            return (Jogada)escolha;
        }

        private Jogada RetornaJogadaMaq()
        {
            Random num = new Random();
            int escolha = num.Next(3);
            PicMaq.Image = imgMaq[escolha];
            return (Jogada)escolha;
        }
    }
    enum Jogada
    {
        Pedra = 0, Papel = 1, Tesoura = 2
    }
    enum Resultado
    {
        VenceJog, VenceMaq, Empate
    }
}

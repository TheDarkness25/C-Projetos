using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Threading;

namespace Jogo_Memória
{
    public partial class Form1 : Form
    {
        int jogadas = 0;
        int click = 0;
        int encontradas = 0;
        Image[] img = new Image[9];
        int tag;
        List<string> lista = new List<string>();
        int[] TagsCompare = new int[2];
        public Form1()
        {
            InitializeComponent();
            Inicio();
        }
       private void Inicio()
        {
            foreach (PictureBox item in Controls.OfType<PictureBox>()) {
                tag = int.Parse(string.Format("{0}", item.Tag));
                img[tag] = item.Image;
                item.Image = Properties.Resources.Simbolo_Batman;
                item.Enabled = true;
            }
            RandomCards();
        }

        private void RandomCards()
        {
            foreach (PictureBox item in Controls.OfType<PictureBox>())
            {
                Random rdn = new Random();
                int[] xP = { 33, 158, 283, 408, 533, 658 };
                int[] yP = { 59, 218, 380 };
                Repete:
                var x = xP[rdn.Next(0, xP.Length)];
                var y = xP[rdn.Next(0, yP.Length)];
                string verifica = x.ToString() + y.ToString();
                if (lista.Contains(verifica))
                {
                    goto Repete;
                }
                else
                {
                    item.Location = new Point(x, y);
                    lista.Add(verifica);   
                }
            }
        }

        private void imgClick_Click(object sender, EventArgs e)
        {
            bool par = false;
            PictureBox pic = (PictureBox) sender;
            click++;
            tag = int.Parse(String.Format("{0}", pic.Tag));
            pic.Image = img[tag];
            pic.Refresh();
            if (click == 1)
            {
                TagsCompare[0] = int.Parse(String.Format("{0}", pic.Tag));
            }
            else if (click == 2)
            {
                jogadas++;
                lblJogadas.Text = "Jogadas: " + jogadas.ToString();
                TagsCompare[1] = int.Parse(String.Format("{0}", pic.Tag));
                par = checagemPares();
                Desvirar(par);
            }
        }
        private bool checagemPares()
        {
            click = 0;
            if (TagsCompare[0] == TagsCompare[1])
            {
                return true;
            }
            else
            {
                return false;   
            }
        }

        private void Desvirar(bool check)
        {
            Thread.Sleep(500);
            foreach (PictureBox item in Controls.OfType<PictureBox>())
            {
                if (int.Parse(String.Format("{0}", item.Tag)) == TagsCompare[0] || int.Parse(String.Format("{0}", item.Tag)) == TagsCompare[1])
                {
                    if (check == true)
                    {
                        item.Enabled = false;
                        encontradas++;
                    }
                    else
                    {
                        item.Image = Properties.Resources.Simbolo_Batman;
                        item.Refresh();
                    }
                }
            }
            Final();
        }

        private void Final()
        {
            if (encontradas == img.Length * 2)
            {
                MessageBox.Show($"Parabéns, você encontrou todos os pares de Gotham!!");
                DialogResult msg = MessageBox.Show("Jogar novamente?", "Caixa de Pergunta", MessageBoxButtons.YesNo);
                if (msg == DialogResult.Yes)
                {
                    click = 0;
                    jogadas = 0;
                    encontradas = 0;
                    lista.Clear();
                    Inicio();
                }
                else if(msg == DialogResult.No)
                {
                    MessageBox.Show("Obrigado por jogar os pares de Gotham!");
                    Application.Exit(); 
                }
            }
        }
    }
}

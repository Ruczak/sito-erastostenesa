using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SitoErastostenesa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Sito(bool[] tab, int n)
        {
            for (int i = 2; i * i <= n; i++) //przeszukujemy kolejnych kandydatów na pierwsze 
            {
                if (tab[i]) {
                    for (int j = i * i; j <= n; j += i)
                        tab[j] = false;
                }
            }
        }

        private void btnPrzesiej_Click(object sender, EventArgs e)
        {
            int n = int.Parse(tbZakres.Text);

            if (n > 50) return;

            bool[] tab = new bool[n+1];

            for (int i = 2; i <= n; i++)
                tab[i] = true;

            Sito(tab, n); //przesianie liczb 

            string wynik = $"Kolejne liczby pierwsze z przedziału [2..{n}]: ";

            for (int i = 2; i <= n; i++)
                if (tab[i])
                    wynik += $"{i} ";

            lblTablica.Text = wynik;

            PokarzSchemat();
        }

        private void PokarzSchemat()
        {

        }
    }
}

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
        private int[] _liczbyPierwsze;
        private List<ObjLiczba> _obiekty = new List<ObjLiczba>();
        private List<Label> _zasady = new List<Label>();
        private int _yPosition = 0;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Sito(bool[] tab, int n)
        {
            for (int i = 2; i * i <= n; i++)
            {
                if (tab[i]) {
                    for (int j = i * i; j <= n; j += i)
                    {
                        tab[j] = false;
                        if (generujSchemat.Checked) _obiekty.Where(obj => obj.Liczba == j).FirstOrDefault().SkreslonaPrzez = i;
                    }

                    Random random = new Random(Guid.NewGuid().GetHashCode());

                    Label lblLegenda = new Label();
                    lblLegenda.Location = new Point(13, _yPosition);
                    lblLegenda.Width = 180;
                    lblLegenda.AutoSize = false;
                    lblLegenda.Text += $"Skreślone przez liczbę: {i}; \r\n";
                    lblLegenda.ForeColor = Color.FromArgb(random.Next(0,255), random.Next(0, 255), random.Next(0, 255));
                    _zasady.Add(lblLegenda);

                    _yPosition += 23;
                }
            }
        }

        private void btnPrzesiej_Click(object sender, EventArgs e)
        {
            pnlObiekty.Controls.Clear();

            lblTablica.Text = string.Empty;

            int n = int.Parse(tbZakres.Text);

            bool[] tab = new bool[n+1];

            for (int i = 2; i <= n; i++)
                tab[i] = true;

            if (generujSchemat.Checked) _obiekty = GenerujObiekty(n);

            pnlLegenda.Controls.Clear();
            _yPosition = 0;

            Sito(tab, n);

            _liczbyPierwsze = LiczbyPierwsze(tab, n);

            lblTablica.Text = $"Kolejne liczby pierwsze z przedziału [2..{n}]: {string.Join(", ", _liczbyPierwsze)}";
            pnlLegenda.Location = new Point(13, lblTablica.Location.Y + lblTablica.Height + 10);

            if (generujSchemat.Checked) PokazSchemat(n);
        }

        private int[] LiczbyPierwsze(bool[] tab, int n)
        {
            List<int> wynik = new List<int>();

            for (int i = 2; i <= n; i++) { 
                if (tab[i])
                {
                    wynik.Add(i);
                }
            }

            return wynik.ToArray();
        }

        private List<ObjLiczba> GenerujObiekty(int n)
        {
            List<ObjLiczba> obiekty = new List<ObjLiczba>();

            for (int i = 2; i <= n; i++)
            {
                ObjLiczba obiekt = new ObjLiczba(i, 0);
                obiekt.Location = new Point(((i -1 ) % 10 ) * 30, ((i - 1)/ 10) * 30);
                obiekty.Add(obiekt);
            }

            return obiekty;
        }

        private void PokazSchemat(int n)
        {
            foreach (var zasada in _zasady)
            {
                pnlLegenda.Controls.Add(zasada);
            }

            foreach (var obiekt in _obiekty)
            {
                if (obiekt.SkreslonaPrzez != 0)
                {
                    obiekt.BackColor = pnlLegenda.Controls.Cast<Control>().ToList().Where(obj => obj.Text.Contains(obiekt.SkreslonaPrzez.ToString())).FirstOrDefault().ForeColor;
                }
                pnlObiekty.Controls.Add(obiekt);
            }
        }
    }
}

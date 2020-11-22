using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace SitoErastostenesa
{
    public class ObjLiczba : Label
    {
        public ObjLiczba(int liczba, int skreslonaPrzez) : base()
        {
            Liczba = liczba;
            SkreslonaPrzez = skreslonaPrzez;

            Width = 30;
            Height = 30;
            Font = new Font("Microsoft Sans Serif", 8.25F);
            Text = liczba.ToString();
            TextAlign = ContentAlignment.MiddleCenter;
        }

        public int Liczba { get; set; }
        public int SkreslonaPrzez { get; set; }
    }
}

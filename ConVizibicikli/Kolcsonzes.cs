using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConVizibicikli
{
    internal class Kolcsonzes
    {
        string nev;
        char jazon;
        int eOra;
        int ePerc;
        int vOra;
        int vPerc;

        public Kolcsonzes(string nev, char jazon, int eora, int eperc, int vora, int vperc)
        {
            this.nev = nev;
            this.jazon = jazon;
            this.eOra = eora;
            this.ePerc = eperc;
            this.vOra = vora;
            this.vPerc = vperc;
        }

        public string Nev { get => nev; }
        public char JAzon { get => jazon; }
        public int EOra { get => eOra; }
        public int EPerc { get => ePerc; }
        public int VOra { get => vOra; }
        public int VPerc { get => vPerc; }
    }
}

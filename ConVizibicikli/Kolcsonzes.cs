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
        
        public int IdoHossz()
        {
            return VOra * 60 + VPerc - (eOra * 60 + ePerc);
        } 

        public Kolcsonzes(string csvSor)
        {
            var mezok = csvSor.Split(';');
            this.nev = mezok[0];
            this.jazon = mezok[1][0];
            this.eOra = int.Parse(mezok[2]);
            this.ePerc = int.Parse(mezok[3]);
            this.vOra = int.Parse(mezok[4]);
            this.vPerc = int.Parse(mezok[2]);
        }

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

using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Tartaly
    {
        string nev;
        int a;
        int b;
        int c;
        double aktLiter;

        public Tartaly(string nev, int a, int b, int c)
        {
            this.nev = nev;
            this.a = a;
            this.b = b;
            this.c = c;
            this.aktLiter = 0;
        }
        public Tartaly(String nev)
        {
            this.nev = nev;
            this.a = 10;
            this.b = 10;
            this.c = 10;
            this.aktLiter = 0;
        }
        public double Terfogat
        {
            get { return this.a * this.b * this.c; }
        }
        public void DuplazMeretet()
        {
            this.a *= 2;
        }
        public void TeljesLeengedes()
        {
            this.aktLiter = 0;
        }
        public double Toltottseg
        {
            get { return this.aktLiter / (Terfogat / 100); }
        }
        public void Tolt(double hozzaad)
        {
            if (this.aktLiter +hozzaad > Terfogat)
            {
                Console.WriteLine("Túlcsordulás! Ennyit nem lehet hozzáadni!");
            }
            else
            {
                this.aktLiter += hozzaad;
            }
            /*
            try
            {
                if ( this.aktLiter + hozzaad <= Terfogat)
                {

                }
            }
            catch (Exception)
            {
                Console.WriteLine("Túlcsordulás! Ennyit nem lehet hozzáadni!");
            }
            */
        }
        public string Info()
        {
            return String.Format("{0}: {1} cm3 = ({6} liter), töltöttsege:{2}%, ({7}" +
            "liter), méretei:{3}x{4}x{5} cm", this.nev, this.Terfogat,
            this.Toltottseg * 100, this.a, this.b, this.c, this.Terfogat / 1000, this.aktLiter);
        }
    }
}

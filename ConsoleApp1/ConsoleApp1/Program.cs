using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp1;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tartaly nagytartaly, literes;
            nagytartaly = new Tartaly("nagytartaly", 500, 200, 120);
            literes = new Tartaly("literes", 10, 10, 10);
            Console.WriteLine(nagytartaly.Info());
            nagytartaly.Tolt(12500);
            nagytartaly.Tolt(5680);
            Console.WriteLine(nagytartaly.Info());
            Console.WriteLine();
            Console.WriteLine(literes.Info());
            literes.DuplazMeretet();
            literes.Tolt(0.56);
            Console.WriteLine(literes.Info());
            literes.TeljesLeengedes();
            literes.Tolt(1.6);
            Console.WriteLine(literes.Info());
        }
    }
}

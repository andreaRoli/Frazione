using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frazione
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Frazione f = Frazione.Parse("16/12");
            int Num = 16;
            int Den = 12;

            f.Semplifica(ref Num, ref Den);

            Console.WriteLine("La frazione semplificata è {0}", f.ToString());
            Console.ReadLine();
        }
    }
}

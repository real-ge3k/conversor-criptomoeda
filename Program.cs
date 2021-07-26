using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor_de_moeda
{
    class Program
    {
        static void Main(string[] args)
        {
            Repeat play = new Repeat();
            play.conversor();
           
            Console.WriteLine("Quer repetir? (S/N)");
            string resp = Console.ReadLine();
            if (resp == "S" || resp == "s")
            {
                Console.Clear();
                Repeat repeat = new Repeat();
                repeat.conversor();
            }
            else if (resp == "N" || resp == "n")
                Console.WriteLine("OBRIGADO POR USAR O NOSSO PROGRAMA.");
            else
                Console.WriteLine("[ERRO] -  Verique o dado de entrada.");
            Console.ReadLine();
        }

    }
}

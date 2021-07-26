using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor_de_moeda
{
    class Repeat
    {
        public void conversor()
        {
            const float câmbio = 0.0016f;
            // Partindo do pressuposto que um kwanza angolano equivale à 0,0016 dollar americano 
            // Dados de entrada: valor
            // Processamento: dolarAmericano = valor * cambioAtual
            // Saida: dolarAmericano

            Console.WriteLine("------------------------------------------------------\t");
            Console.WriteLine("------------------------------------------------------\t");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n               [KWANZA PARA DOLLAR] \n");
            Console.ResetColor();
            Console.WriteLine("------------------------------------------------------\t");
            Console.WriteLine("------------------------------------------------------\t");
            try
            {
                Console.Write("\nInsira o valor.\n");
                decimal valor = decimal.Parse(Console.ReadLine());
                decimal dollar = valor * Convert.ToDecimal(câmbio);
                Console.BackgroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Equivalente a Dollar: ${0}", dollar);
                Console.ResetColor();
                Console.WriteLine("\nDados de moeda fornecidos pela Morningstar e de criptomoeda fornecidos pela coinbase.");
            }
            catch(Exception ee)
            {
                Console.WriteLine(ee.Message);
            }
        }
    }
}

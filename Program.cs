using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Lix3ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valor = LerValorPositivo("Digite um valor positivo: ");
            Console.WriteLine($"Valor informado: {valor}");
        }

        static double LerValorPositivo(string mensagem)
        {
            double valor;
            do
            {
                Console.Write(mensagem);
                string entrada = Console.ReadLine();
                if (!double.TryParse(entrada, out valor) || valor <= 0)
                {
                    Console.WriteLine("Valor inválido. Por favor, digite um número positivo.");
                }
            } while (valor <= 0);

            return valor;
        }
    }
}
       
                
            

           

      
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LISTA3EX2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int primeiroValor, segundoValor;

            Console.Write("Digite o primeiro valor: ");
            primeiroValor = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo valor (maior que o primeiro): ");
            segundoValor = int.Parse(Console.ReadLine());

            while (segundoValor <= primeiroValor)
            {
                Console.WriteLine("O segundo valor deve ser maior que o primeiro. Tente novamente.");
                Console.Write("Digite o segundo valor: ");
                segundoValor = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"Primeiro valor: {primeiroValor}");
            Console.WriteLine($"Segundo valor: {segundoValor}");
            Console.WriteLine("Pressione qualquer tecla para sair...");
            Console.ReadKey();
        }
    }
}
        
   
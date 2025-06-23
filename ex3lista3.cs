using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista3ex3
{
    internal class Program
    {
        static void Main(string[] args)
  
        {
            string sexo;
            do
            {
                Console.Write("Digite o sexo do usuário (F/M): ");
                sexo = Console.ReadLine().Trim().ToUpper();
                if (sexo != "F" && sexo != "M")
                {
                    Console.WriteLine("Entrada inválida. Por favor, digite apenas 'F' ou 'M'.");
                }
            } while (sexo != "F" && sexo != "M");

            Console.WriteLine($"Sexo informado: {sexo}");
            // Aguarda o usuário pressionar uma tecla antes de fechar
            Console.ReadKey();
        }
    }
}
     
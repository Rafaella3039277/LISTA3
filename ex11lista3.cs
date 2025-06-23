using System;
using System.Collections.Generic;

namespace lista3ex11

{
    internal class Program
    {
        static void Main(string[] args)
            {
                int n;
                do
                {
                    Console.Write("Digite a quantidade de números (positivo e menor que 20): ");
                    if (!int.TryParse(Console.ReadLine(), out n) || n <= 0 || n >= 20)
                    {
                        Console.WriteLine("Valor inválido! Digite um número positivo menor que 20.");
                    }
                } while (n <= 0 || n >= 20);

                var valores = new List<double>();
                for (int i = 0; i < n; i++)
                {
                }
            }
        }
    }

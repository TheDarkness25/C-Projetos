using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parte_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Usando o While e For:
            //While:
            Console.WriteLine("Digite um número inteiro: ");
            int n1 = int.Parse(Console.ReadLine());
            int fat = 1;
            int resultado = 1;
            while (fat <= n1)
            {
                resultado *= fat;
                fat++;
            }
            Console.WriteLine($"O fatorial de {n1} tem o valor de {resultado}");
            Console.WriteLine();
            Console.WriteLine($"Os números pares antecessores de {n1} são: ");
            while (n1 > 0)
            {
                if (n1 % 2 == 0)
                {
                    Console.WriteLine(n1);
                }
                n1--;
            }
            Console.WriteLine();
            //Usando o For:
            Console.WriteLine("Digite mais um número inteiro: ");
            int n2 = int.Parse(Console.ReadLine());
            int soma = 0;
            for (int i = 0;i < n2;i++)
            {
                soma += i;
                
            }
            Console.WriteLine($"A somas dos números positivos antecessores a {n2} é {soma}");
            Console.WriteLine();
            //Usando o Do While:
            int n3;
            do
            {
                Console.WriteLine("Digite um número inteiro ou 0 para encerrar");
                n3 = int.Parse(Console.ReadLine());
                int total = 0;
                int res = n3;
                while (res > 0)
                {
                    total += res;
                    res--;
                }
                Console.WriteLine($"A somatória dos números até {n3} tem o valor de {total}");
            }
            while (n3 != 0);
            Console.WriteLine("Programa encerrado!");    
            Console.WriteLine();
        }
    }
}

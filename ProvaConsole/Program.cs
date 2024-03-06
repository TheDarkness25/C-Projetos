using System;

namespace ProvaConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero: ");
            int num = int.Parse(Console.ReadLine());
            while (num > 0)
            {
                if(num == 1)
                {
                    Console.Write($"Antecessor é igual a 0   Fatorial igual a 1");
                }
                else
                {
                    int aux = num - 1;
                    int fat = 1;
                    while (aux > 0)
                    {
                        for (int i = aux; i > 0; i--)
                        {
                            Console.Write($"Antecessor é igual a {aux}   ");
                            for (int j = 1; j <= aux; j++)
                            {
                                fat *= j; 
                            }
                            Console.Write($"Fatorial igual a {fat}");
                            Console.WriteLine();
                            fat = 1;
                            aux--;
                        }
                    }
                }
                Console.WriteLine();
                Console.WriteLine("Digite um numero: ");
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("FIM DO PROGRAMA");
        }
    }
}

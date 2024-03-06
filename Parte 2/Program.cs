using System;

namespace Parte_02
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Utilização de Ifs e de Switch:
            //Primeiro com Ifs:
            float n1 = 0f;
            float n2 = 0f;
            float n3 = 0f;
            string nome;
            Console.WriteLine("Digite o nome do(a) aluno(a): ");
            nome = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Digite a primeira nota: ");
            n1 = float.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Digite a segunda nota: ");
            n2 = float.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Digite a terceira nota: ");
            n3 = float.Parse(Console.ReadLine());
            Console.WriteLine();
            float media = (n1 + n2 + n3) / 3;
            if (media < 6)
            {
                Console.WriteLine($"O(a) aluno(a) {nome} obteve a média de {media:F2} e por isso está reprovado(a).");
            }
            else
            {
                if (media < 8)
                {
                    Console.WriteLine($"O(a) aluno(a) {nome} obteve a média de {media:F2} portanto foi aprovado com um bom aprendizado(a).");
                }
                else
                {
                    Console.WriteLine($"O(a) aluno(a) {nome} obteve a média de {media:F2} portanto foi aprovado com um ótimo aprendizado(a).");
                }
            }
            //Agora com o Switch:
            Console.WriteLine();
            Console.WriteLine("Digite um valor inteiro: ");
            int val = int.Parse(Console.ReadLine());
            int pi = 0;
            if (val % 2 == 0)
            {
                pi = 1;
            }
            else
            {
                pi = 0;
            }
            switch (pi)
            {
                case 1: Console.WriteLine($"O número {val} é par.");
                    break;
                case 0: Console.WriteLine($"O número {val} é ímpar.");
                    break;
                default: Console.WriteLine($"Número ou caracter ínvalido");
                    break;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a palavra: ");
            string palavra = Console.ReadLine();
            string[] resultado = new string[palavra.Length];
            string[] errado = new string[7];

            //checar verifica se todas as posições preenchidas são letras
            sbyte erros = 0, acertos = 0, checar = 0, a = 0;
            Console.Clear();

            Console.WriteLine("Digite uma letra: ");
            while (erros != 7 && checar != resultado.Length)
            {
                char letra = char.Parse(Console.ReadLine());
                //Index of verifica a ocorrencia de letra na palavra
                int ocorrencias = palavra.IndexOf(letra);
                if (ocorrencias == -1)
                {
                    erros++;
                    errado[a] = letra.ToString();
                    a++;

                }
                else
                {
                    acertos++;


                    for (int i = 0; i < palavra.Length; i++)
                    {
                        if (palavra[i].ToString() == letra.ToString())
                        {
                            resultado[i] = letra.ToString();

                            if (resultado[i] != null && resultado[i] != "_")
                            {
                                checar++;
                            }
                        }
                        else if (resultado[i] is null)
                        {
                            resultado[i] = "_";
                        }
                    }
                }
                //imprimindo o vetor
                //para cada ocorrencia do vetor resultado faça:
                foreach (string item in resultado)
                {
                    Console.Write(item);
                }
                Console.WriteLine();

                if (erros == 7)
                {
                    Console.WriteLine("Perdeu");
                    //Console.WriteLine("", errado[0]);
                    foreach (string item in errado)
                    {
                        Console.Write(item);
                    }
                    Console.WriteLine();
                    Console.ReadLine();
                }
                else if (checar == resultado.Length)
                {
                    Console.WriteLine("Ganhou");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Erros:{0}, Acertos:{1} ", erros, acertos);
                }
            }


        }
    }
}

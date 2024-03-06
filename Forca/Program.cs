using System;

namespace JogoDaForcaConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            int acertos = 0, erros = 0; string palavra;
            Console.WriteLine("---------------------- Forca - FATEC-SP C# - Rafael Venticinque ---------------------------\n\n");
            Console.WriteLine("Digite uma palavra");
            palavra = Console.ReadLine();
            char[] letras = palavra.ToCharArray();
            char[] forca = palavra.ToCharArray();
            char[] digitados = new char[7];
            char letra;
            int tam = palavra.Length;
            int count = 0, e = 0;
            for (int i = 0; i < palavra.Length; i++)
            {
                if (letras[i] == ' ')
                {
                    forca[i] = ' ';
                    tam--;
                }
                else
                    forca[i] = '_';
            }
            Console.Clear();
            do
            {
                Console.WriteLine("---------------------- Forca - FATEC-SP C# Rafael Venticinque ---------------------------\n\n");
                Console.Write(" ________\n" +
                                     "|        |\n" +
                                     "|        |\n" +
                                     "|\n" +
                                     "|\n" +
                                     "|\n" +
                                     "|\n" +
                                     "|\n" +
                                     "|\n\n");
                Console.SetCursorPosition(2, Console.CursorTop - 2);
                for (int i = 0; i < palavra.Length; i++)
                    Console.Write(forca[i] + " ");
                Console.WriteLine("\n");
                Console.WriteLine("Letras erradas digitadas: ");
                for (int d = 0; d < 7;d++)
                {
                    Console.Write(digitados[d] + " ");
                }
                Console.WriteLine("\n\n\nDigite uma letra");
                letra = Char.Parse(Console.ReadLine());
                for (int i = 0; i < palavra.Length; i++)
                {
                    if (i == 0)
                    {
                        count = palavra.Length;
                    }
                    if (letra == forca[i])
                    {
                        Console.WriteLine($"\n A letra {letra} já foi digitada -- Aperte Enter");
                        Console.ReadKey();
                        break;
                    }
                    else
                    {
                        if (letra == letras[i])
                        {
                            forca[i] = letra;
                            acertos++;
                            count--;
                        }
                        else
                        {
                            if ((count == palavra.Length) && (i == palavra.Length - 1))
                            {
                                erros++;
                                digitados[e] = letra;
                                e++;
                            }
                        }
                    }
                }
                Console.Clear();
            } while ((acertos < tam) && (erros < 7));
            if (acertos == tam)
            {
                Console.WriteLine("Você acertou!!");
                Console.WriteLine("acertos = " + acertos);
                Console.WriteLine("erros = " + erros);
                Console.WriteLine("palavra.Length = " + palavra.Length);
            }
            else
            {
                Console.WriteLine("Você perdeu, tente novamente");
                Console.WriteLine("acertos = " + acertos);
                Console.WriteLine("erros = " + erros);
                Console.WriteLine("palavra.Length = " + palavra.Length);
            }

        }
    }
}


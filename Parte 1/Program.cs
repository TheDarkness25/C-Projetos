using System;
using System.Globalization;

namespace Parte_01
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Usando o console.WriteLine:
            string produto1 = "Computador Dell";
            string produto2 = "Computador Acer";
            string nome = "Rafael Soncini Venticinque";
            byte idade = 20;
            int codigo = 5839;
            char sexo = 'M';
            float preco1 = 7500.40f;
            double preco2 = 8650.90;
            double media = (preco1 + preco2) / 2;
            Console.WriteLine("Produtos: ");
            Console.WriteLine($"{produto1}, cujo preço é R$: {preco1:F2}");
            Console.WriteLine($"{produto2}, cujo preço é R$: {preco2:F2}");
            Console.WriteLine();
            Console.WriteLine($"Registro: {nome} possui {idade} anos de idade, código {codigo} e é do sexo {sexo}.");    
            Console.WriteLine();
            Console.WriteLine($"A média dos preços é de R$: {media}");
            Console.WriteLine($"Quem em notação internacional equivale a {media.ToString("F2", CultureInfo.InvariantCulture)}");    
        }
    }
}

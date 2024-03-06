using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = new List<int>();

            Console.WriteLine("Digite 3 números:");
			
            while (list.Count < 3)
                list.Add(Convert.ToInt32(Console.ReadLine()));

            var retorno = string.Empty;

            foreach (int item in list.OrderBy(_ => _).ToList())
                retorno = $"{retorno} {item}";

            Console.WriteLine($"\n{retorno.Trim()}");

            retorno = string.Empty;

            foreach (int item in list.OrderByDescending(_ => _).ToList())
                retorno = $"{retorno} {item}";

            Console.WriteLine($"\n{retorno.Trim()}");
        }
    }
}

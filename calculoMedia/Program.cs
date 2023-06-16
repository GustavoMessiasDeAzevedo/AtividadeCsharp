using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculoMedia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=========================");
            Console.WriteLine("|  ::Calcular Média ::  |");
            Console.WriteLine("=========================");


            for (int d = 0; d< 1; d++)
            {
                double n, media = 0, media_final;
                for (int i = 0; i < 4; i++)
                {
                    Console.Write($"Digite um numero {i + 1}: ");
                    n = Convert.ToDouble(Console.ReadLine());
                    media += n;
                };
                media_final = media;
                Console.WriteLine("==========");
                Console.WriteLine($"|   {media_final / 4}   |");
                Console.WriteLine("==========");

            }
        }
    }
}

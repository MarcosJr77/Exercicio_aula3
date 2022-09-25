using System;

namespace Ex_aula3_c
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor : ");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());
            int n4 = int.Parse(Console.ReadLine());
            int n5 = int.Parse(Console.ReadLine());

            //Menor
            if (n1 < n2 && n1 < n3 && n1 < n3 && n1 < n5)
            {
                Console.WriteLine("Menor valor é: {0}", n1);
            }else if (n2 < n1 && n2 < n3 && n2 < n3 && n2 < n5)
            {
                Console.WriteLine("Menor valor é: {0}", n2);
            }else if (n3 < n1 && n3 < n2 && n3 < n4 && n3 < n5)
            {
                Console.WriteLine("Menor valor é: {0}", n3);
            }else if (n4 < n1 && n4 < n2 && n4 < n3 && n4 < n5)
            {
                Console.WriteLine("Menor valor é: {0}", n4);
            }else
                Console.WriteLine("Menor valor é: {0}", n5);

            //Maior
            if (n1 > n2 && n1 > n3 && n1 > n3 && n1 > n5)
            {
                Console.WriteLine("Maior valor é: {0}", n1);
            }
            else if (n2 > n1 && n2 > n3 && n2 > n3 && n2 > n5)
            {
                Console.WriteLine("Maior valor é: {0}", n2);
            }
            else if (n3 > n1 && n3 > n2 && n3 > n4 && n3 > n5)
            {
                Console.WriteLine("Maior valor é: {0}", n3);
            }
            else if (n4 > n1 && n4 > n2 && n4 > n3 && n4 > n5)
            {
                Console.WriteLine("Maior valor é: {0}", n4);
            }
            else
                Console.WriteLine("Maior valor é: {0}", n5);
        }
    }
}

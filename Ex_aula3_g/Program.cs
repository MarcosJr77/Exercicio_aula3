namespace Ex_aula3_g {
    internal class Program {
        static void Main(string[] args) {
            int i = 1;
            Console.WriteLine("Digite o numero de um até 9: ");
            int n1 = int.Parse(Console.ReadLine());
            if (n1 > 0 && n1 < 10)
            {
                for (; i < 10; i++)
                {
                    int tabuada = n1 * i;
                    Console.WriteLine("{0} x {1} = {2}", n1, i, tabuada);
                }
            }else
            {
                Console.WriteLine("Número Inválido");
            }

            //if (n1 > 0 && n1 < 10)
            //{
            //    while (i < 10)
            //    {
            //        int tabuada1 = n1 * i;
            //        i++;
            //        Console.WriteLine("{0} x {1} = {2}", n1, i, tabuada1);
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Número Inválido");
            //}
        }
    }
}
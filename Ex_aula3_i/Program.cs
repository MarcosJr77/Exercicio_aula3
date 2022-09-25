namespace Ex_aula3_i
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double i, num;
            Console.WriteLine("Fatorial\n");
            Console.WriteLine("Digite um número: ");
            num = double.Parse(Console.ReadLine());

            double fatorial = num;
            for (i = num - 1; i >=1; i--) 
            {
                Console.WriteLine("{0} * {1}",fatorial,i);

                fatorial = fatorial * i; //ex:5! =  5*4*3*2*1 = 120
            }
            Console.WriteLine("Fatorial de {0} é {1}", num, fatorial);

        }
    }
}
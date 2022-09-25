namespace Ex_aula3_d
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite 3 números: ");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            if (n1 > n2 && n1 > n3 && n2 > n3){
                Console.WriteLine("{0} {1} {2}", n3, n2, n1);
            }else if (n1 > n2 && n1 > n3 && n3 > n2){
                Console.WriteLine("{0} {1} {2}", n2, n3, n1);
            }else if (n2 > n1 && n2 > n3 && n1 > n3){
                Console.WriteLine("{0} {1} {2}", n3, n1, n2);
            }else if (n2 > n1 && n2 > n3 && n3 > n1){
                Console.WriteLine("{0} {1} {2}", n1, n3, n2);
            }else if (n3 > n1 && n3 > n2 && n1 > n2){
                Console.WriteLine("{0} {1} {2}", n2, n1, n3);
            }else{
                Console.WriteLine("{0} {1} {2}", n1, n2, n3);
            }
        }
    }
}
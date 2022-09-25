namespace Ex_aula3_j {
    internal class Program {
        static void Main(string[] args) {
            int i = 1;
            int div = 0;
            Console.WriteLine("Digite um número inteiro: ");
            int n1 = int.Parse(Console.ReadLine());

            
            for (; i < n1; i++) {
                if (n1 % i == 0) { //divisivel
                    div++;
                }
            }
            if (div == 2) {
                Console.WriteLine("Número é primo");
            } else
                Console.WriteLine("Número não é primo");
        }
    }
}
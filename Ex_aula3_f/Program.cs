namespace Ex_aula3_f {
    internal class Program {
        static void Main(string[] args) {
            float altura, peso;
            double mc;
            Console.WriteLine("Calcule seu índice de massa corporal\n");
            Console.WriteLine("Diigite sua altura:");
            altura = float.Parse(Console.ReadLine());
            Console.WriteLine("Diigite seu peso:");
            peso = float.Parse(Console.ReadLine());

            mc = peso / (altura*altura);

            if (mc <=18.5) {
                Console.WriteLine("Faixa de peso: {0:F2} - abaixo do peso normal.", mc);
    
            }else if(mc >18.5 | mc <= 25) {
                Console.WriteLine("Faixa de peso: {0:F2} - peso normal.", mc);
            }else if (mc >25 | mc <= 30) {
                Console.WriteLine("Faixa de peso: {0:F2} - peso acima do normal.", mc);
            }else
                Console.WriteLine("Faixa de peso: {0:F2} - abaixo do peso normal.", mc);
        }
    }
}
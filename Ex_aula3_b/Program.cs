namespace Ex_aula3_b {
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite as 4 notas do aluno: ");
            float n1 = float.Parse(Console.ReadLine());
            float n2 = float.Parse(Console.ReadLine());
            float n3 = float.Parse(Console.ReadLine());
            float n4 = float.Parse(Console.ReadLine());

            double media = (n1 + n1 + n2 + n3 + n4) / 4;
            if (media >= 7) {
                Console.WriteLine("Aprovado média: {0:F1}", media);
            } else {
                Console.WriteLine("Digite a nota do exame: ");
                float exame = float.Parse(Console.ReadLine());
                double nvmedia = (media + exame) / 2;
                if (nvmedia >= 5) {
                    Console.WriteLine("Aprovado média: {0:F1}", nvmedia);
                } else {
                    Console.WriteLine("Reprovado média: {0:F1}", nvmedia);
                }
            }
        }
    }
}
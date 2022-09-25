namespace Ex_aula3_e
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a nota do aluno entre 0 a 10: ");
            float nota =float.Parse(Console.ReadLine());

            if (nota <= 1.9){
                Console.WriteLine("Sua nota é E.");
            }else if (nota <= 4.9){
                Console.WriteLine("Sua nota é D.");
            }else if (nota <= 6.9){
                Console.WriteLine("Sua nota é C.");
            }else if (nota <= 8.9){
                Console.WriteLine("Sua nota é B.");
            }else
                Console.WriteLine("Sua nota é A.");          
        }
    }
}
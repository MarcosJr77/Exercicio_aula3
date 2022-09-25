using System;

namespace Ex_aula3_h
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<char> listResposta = new List<char>();

            char resposta= ' ';
            while ( resposta != '-')
            {
                Console.Clear();
                Console.WriteLine("O - Ótimo");
                Console.WriteLine("B - Bom");
                Console.WriteLine("R - Regular");
                Console.WriteLine("U - Ruim");
                Console.WriteLine(" - Sair");
                Console.WriteLine();
                Console.WriteLine("Opção");
                resposta = char.Parse(Console.ReadLine().ToUpper());

                if (resposta == 'O' || resposta =='B' || resposta == 'R' || resposta == 'U')
                {
                    listResposta.Add(resposta);
                }
                int bom = 0, otimo = 0, regular = 0, ruim = 0, total = 0; ;
                foreach ( char respostaAtual in listResposta)
                {
                    total++;
                    switch (respostaAtual)
                    {
                        case 'B':
                            bom++;
                            break;
                        case 'O':
                            otimo++;
                            break;
                        case 'R':
                            break;
                        case 'U':
                            ruim++;
                            break;
                    }
                }
                Console.WriteLine($"Total de resposta = {total}");
                Console.WriteLine($"===========================");
                Console.WriteLine($" ótimo teve...{otimo}... resposta");
                Console.WriteLine($"Bom teve....{bom}.... repsosta");
                Console.WriteLine($"Regular teve....{regular}.... repsosta");
                Console.WriteLine($"Ruim teve....{ruim}.... repsosta");
                Console.WriteLine($"===========================");
                Console.WriteLine($" ótimo teve...{(((float)otimo / (float)total) * 100).ToString("F1")}%... resposta");
                Console.WriteLine($"Bom teve....{(((float)bom / (float)total) * 100)}%.... repsosta");
                Console.WriteLine($"Regular teve....{(((float)regular / (float)total) * 100)}%.... repsosta");
                Console.WriteLine($"Ruim teve....{(((float)ruim / (float)total) * 100)}%.... repsosta");
                int soma_ob = otimo + bom;
                int soma_ru = regular + ruim;
                if (soma_ob > soma_ru)
                {
                    Console.WriteLine($" Soma de Otimos e bons ({soma_ob} é maior que a somados regulares e ruins({soma_ru} )");

                }

            }
        }
    }
}

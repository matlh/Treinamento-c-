using System;
using Jogo_de_dados;

namespace Jogo
{
    public class Dados
    {
        public static void Main()
        {
            string Jogador1, Jogador2;
            long[] Rodada = new long[2];
            int NumeroDeRodadas = 0;
            
            do
            {
                Console.WriteLine("Digite o nome do primeiro Jogador");
                Jogador1 = Console.ReadLine();

                Console.WriteLine("\nDigite o nome do primeiro Jogador");
                Jogador2 = Console.ReadLine();

                if (Jogador1 == Jogador2)
                Console.WriteLine("\nOs dois nomes não podem ser iguais\n");
            } while(Jogador1 == Jogador2);

            Jogador J1 = new Jogador(Jogador1);
            Jogador J2 = new Jogador(Jogador2);
            
            Console.WriteLine("\nJogo iniciado\n");

            do
            {
                Console.WriteLine($"\n{NumeroDeRodadas + 1}ª Rodada\n");

                Rodada[0] = J1.Rodada();
                Rodada[1] = J2.Rodada();
                Console.WriteLine($"\n{J1.Nome} tirou {Rodada[0]}\n\n{J2.Nome} tirou {Rodada[1]}\n");

                if (Rodada[0] > Rodada[1])
                Console.WriteLine($"\n{J1.Nome} Venceu a {NumeroDeRodadas + 1}ª rodada\n");
                else if (Rodada[1] > Rodada[0])
                Console.WriteLine($"\n{J2.Nome} Venceu a {NumeroDeRodadas + 1}ª rodada\n");
                else
                Console.WriteLine("\nA rodada foi um empate\n");

                J1.Pontuacao = J1.Pontuacao + Rodada[0];
                J2.Pontuacao = J2.Pontuacao + Rodada[1];

                Console.WriteLine($"\nPlacar\n{J1.Nome}: {J1.Pontuacao} pontos\n{J2.Nome}: {J2.Pontuacao} pontos");

                Console.ReadKey();
                
                NumeroDeRodadas++;

            }while(NumeroDeRodadas < 4);


        }
    }
}

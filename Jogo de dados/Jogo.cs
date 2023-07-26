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
                Console.WriteLine("Digite o nome do primeiro Jogador\n");
                Jogador1 = Console.ReadLine();
                Marcador.Divisao(100);

                Console.WriteLine("\nDigite o nome do segundo Jogador\n");
                Jogador2 = Console.ReadLine();
                Marcador.Divisao(100);

                if (Jogador1 == Jogador2)
                {
                    Console.WriteLine("\nOs dois nomes não podem ser iguais\n");
                    Marcador.Divisao(100, 2);
                }
                

            } while(Jogador1 == Jogador2);

            Jogador J1 = new Jogador(Jogador1);
            Jogador J2 = new Jogador(Jogador2);
            
            
            Console.WriteLine("\nJogo iniciado\n");
            

            Marcador.Divisao(100);
            Console.WriteLine("Pressione qualquer tecla para iniciar a primeira rodada");
            Marcador.Divisao(100, 3);
            Console.ReadKey();

            do
            {
                Marcador.Divisao(100);
                Console.WriteLine($"{NumeroDeRodadas + 1}ª Rodada\n");

                Rodada[0] = J1.Rodada();
                Rodada[1] = J2.Rodada();
                Console.WriteLine($"\n{J1.Nome} tirou {Rodada[0]}\n\n{J2.Nome} tirou {Rodada[1]}\n");

                if (Rodada[0] > Rodada[1])
                {
                    Console.WriteLine($"\n{J1.Nome} Venceu a {NumeroDeRodadas + 1}ª rodada\n");
                    Marcador.Divisao(100);
                }
                
                else if (Rodada[1] > Rodada[0])
                {
                    Console.WriteLine($"\n{J2.Nome} Venceu a {NumeroDeRodadas + 1}ª rodada");
                    Marcador.Divisao(100);
                }
                
                else
                {
                    Console.WriteLine("\nA rodada foi um empate\n");
                    Marcador.Divisao(100);
                }
                

                J1.Pontuacao = J1.Pontuacao + Rodada[0];
                J2.Pontuacao = J2.Pontuacao + Rodada[1];

                Console.WriteLine($"\nPlacar\n\n{J1.Nome}: {J1.Pontuacao} pontos\n{J2.Nome}: {J2.Pontuacao} pontos\n");

                NumeroDeRodadas++;

                if (NumeroDeRodadas < 3)
                {
                    Marcador.Divisao(100);
                    Console.WriteLine("Pressione qualquer tecla para iniciar a proxima rodada");
                    Marcador.Divisao(100,2);
                    Console.ReadKey();
                }
                
                else
                {
                    Marcador.Divisao(100);
                    Console.WriteLine("Pressione qualquer tecla para finalizar o jogo");
                    Marcador.Divisao(100,2);
                    Console.ReadKey();
                }

            }while(NumeroDeRodadas < 3);

            if (J1.Pontuacao > J2.Pontuacao)
            Console.WriteLine($"\n{J1.Nome} venceu o jogo\n");

            else if (J2.Pontuacao > J1.Pontuacao)
            Console.WriteLine($"\n{J2.Nome} venceu o jogo\n");

            else
            Console.WriteLine("\nO jogo ficou empatado\n");
        }
    }
}

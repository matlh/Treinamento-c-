using System;
using Jogo_de_dados;

namespace Jogo
{
    public class Dados
    {
        public static void Main()
        {
            Console.WriteLine("Digite o nome do primeiro jogador");
            Jogador J1 = new Jogador(Console.ReadLine());

            Console.WriteLine("Digite o nome do segundo jogador");
            Jogador J2 = new Jogador(Console.ReadLine());

            J1.Ponto();
            J1.Ponto();
            J1.Ponto();
            J1.Ponto();

            Console.WriteLine($"Nome do jogador 1 é: {J1.Nome}\n Pontuação do Jogador 1 é: {J1.Pontuacao}");
        }
    }
}

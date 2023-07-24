using System;
using Jogo_de_dados;

namespace Jogo
{
    public class Dados
    {
        public static void Main()
        {
            string Jogador1, Jogador2;
            
            do
            {
                Console.WriteLine("Digite o nome do primeiro Jogador");
                Jogador1 = Console.ReadLine();

                Console.WriteLine("Digite o nome do primeiro Jogador");
                Jogador2 = Console.ReadLine();

                if (Jogador1 == Jogador2)
                Console.WriteLine("Os dois nomes não podem ser iguais\n");
            } while(Jogador1 == Jogador2);

            Jogador J1 = new Jogador(Jogador1);
            Jogador J2 = new Jogador(Jogador2);
            
            Console.WriteLine("Jogo iniciado\n");


        }
    }
}

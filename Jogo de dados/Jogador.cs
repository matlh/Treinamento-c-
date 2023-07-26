using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Jogo_de_dados
{
    public class Jogador
    {
       public string Nome;
       public long Pontuacao = 0;

       public Jogador (string Nome)
       {
            this.Nome = Nome;
       }
       public long Rodada()
       {
          Random Numero = new Random(); 
          return Numero.NextInt64(1, 6);
       }
    }

   public class Marcador
   {
      byte NumMarcador = 0;

      public static void Divisao(byte NumMarcador, byte Espaco = 0)
      {
         string Caracteres = "*";

         for (int i = 0; i < NumMarcador; i++)
         {
            Caracteres = Caracteres + "*";
         }

         switch (Espaco)
         {
            case 0:
            Console.WriteLine(Caracteres);
            break;

            case 1:
            Console.WriteLine($"{Caracteres}\n");
            break;

            case 2:
            Console.WriteLine($"{Caracteres}\n\n");
            break;

            case 3:
            Console.WriteLine($"{Caracteres}\n\n\n");
            break;

            case 4:
            Console.WriteLine($"{Caracteres}\n\n\n\n");
            break;

            case 5:
            Console.WriteLine($"{Caracteres}\n\n\n\n\n");
            break;

            default:
            Console.WriteLine(Caracteres);
            break;
         }
      }
   }

}
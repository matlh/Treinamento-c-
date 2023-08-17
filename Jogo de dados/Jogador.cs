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
}
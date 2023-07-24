using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Jogo_de_dados
{
    public class Jogador
    {
       public string Nome;
       public int Pontuacao = 0;

       public Jogador (string Nome)
       {
            this.Nome = Nome;
       }
       
       public void Ponto()
       {
            Pontuacao++;
       }
    }
}
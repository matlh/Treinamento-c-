using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Soma_e_média
{
    public class Operacoes
    {
        public static decimal Soma (decimal[] Array)
        {
            decimal a = 0;

            for (byte i = 0; i < Array.Length; i++)
            {
                a = a + Array[i];
            }
            return a;
        }

        public static decimal Media (decimal[] Array, byte n)
        {
            decimal b = Operacoes.Soma(Array)/n;
            return b;
        }
    }
}
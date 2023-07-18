using System;
using Soma_e_média;

namespace SomaEMedia
{
    public class SomaEMedia
    {
        public static void Main()
        {
            
            decimal[] Numeros = new decimal[9]; 

            System.Console.WriteLine ("Digite a qunatidade de valores para cálculo de média e soma: ");
            byte n = byte.Parse(System.Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                System.Console.WriteLine ($"Digite o {i+1}° número: ");
                Numeros [i] = decimal.Parse(Console.ReadLine());
            }

            Console.WriteLine($"A soma dos números é: {Operacoes.Soma(Numeros)}\nA média é: {Operacoes.Media(Numeros, n)}");

        }

    }
}
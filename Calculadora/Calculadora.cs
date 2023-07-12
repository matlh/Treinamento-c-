using System;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;

namespace Calculadora{

    public class Calculadora {

        public static void Main(){

           string Operacao = "null";
           byte x;
           decimal y = 0;

            do{
                
                do{
                    Console.WriteLine("\nDigite:\n 1 - Soma a + b\n 2 - Subtração a - b\n 3 - Divisão a / b \n 4 - Multiplicação a * b\n 5 - Potenciação a ^ b\n 6 - Radiciação Raiz de a indice b");
                    x = byte.Parse(Console.ReadLine());

                    if (x > 6 || x == 0)
                    Console.WriteLine("\nOperão invalida\n");

                } while(x > 6 || x == 0);

                Console.WriteLine("\nDigite o número a: \n");
                decimal a = decimal.Parse(Console.ReadLine());

                Console.WriteLine("\nDigite o número b: \n");
                decimal b = decimal.Parse(Console.ReadLine());

                double c = Decimal.ToDouble(a), d =  Decimal.ToDouble(b), e = Decimal.ToDouble(y);

                switch (x){

                    case 1:
                    Operacao = "Soma";
                    y = a + b;
                    break;

                    case 2:
                    Operacao = "Subtração";
                    y = a - b;
                    break;

                    case 3:
                    Operacao = "Divisão";
                    y = a / b;
                    break;

                    case 4:
                    Operacao = "Multiplicação";
                    y = a * b;
                    break;

                    case 5:
                    Operacao = "Potenciação";
                    e = Math.Pow(c,d);
                    break;

                    case 6:
                    Operacao = "Radiciação";
                    e = Math.Pow(c,1 / d);
                    break;
                }

            if (x > 4 & x < 7)
            Console.WriteLine($"\nO resultado da {Operacao} é:\n{e}\n");
            
            else
            Console.WriteLine($"\nO resultado da {Operacao} é:\n\n{y}\n");

            } while(true);
        }
    }
}

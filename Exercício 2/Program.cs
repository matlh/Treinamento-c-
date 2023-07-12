using System;

namespace DIO
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());

            //Digite o seu código aqui
            do{
                 if(x % 2 == 0)
                    Console.WriteLine($"{x + ( x + 2 ) + ( x + 4 ) + ( x + 6 ) + ( x + 8 )}");
                  else
                    Console.WriteLine($"{( x + 1 ) + ( x + 3 ) + ( x + 5 ) + ( x + 7 ) + ( x + 9 )}"); 
                  x = int.Parse(Console.ReadLine());  
            }
            while (x != 0);
        }
      }
    }

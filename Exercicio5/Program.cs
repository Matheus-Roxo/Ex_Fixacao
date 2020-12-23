using System;

namespace Exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tabuada do 1 ao 10!");
                for(var left = 0; left <=10; left++){
                    for (var rigth = 0; rigth <= 10; rigth++){
                    Console.WriteLine(+left+" x "+rigth+" = "+left * rigth);
                    }
                    Console.WriteLine();
            }
        }
    }
}

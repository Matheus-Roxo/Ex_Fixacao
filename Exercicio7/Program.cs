using System;

namespace Exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
             int[] numeros = new int [15];

            for(int i = 0; i < numeros.Length; i++){

                Console.Write($"Digite o {i+1}º número: ");
                numeros[i] = int.Parse(Console.ReadLine());

            }


            for(int i = numeros.Length -1; i >= 0; i--){

                Console.WriteLine($"{i+1}º número: {numeros[i]}");

        }
        }
    }
}

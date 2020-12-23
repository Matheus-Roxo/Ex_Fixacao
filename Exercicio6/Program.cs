using System;

namespace Exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = new string [10];

            string mensagem = "Nome não encontrado";

            Console.WriteLine("Escreva 10 nomes");

            for(int i = 0; i < nomes.Length; i++) {

                System.Console.Write($"{i+1}º nome: ");
                nomes[i] = Console.ReadLine();

            }

            System.Console.Write("Digite o nome que você deseja consultar: ");
            string procurandoNome = Console.ReadLine();

            for(int i = 0; i < nomes.Length; i++) {

               if(nomes[i] == procurandoNome){
                   mensagem = "Nome encontrado";
                   
               }
            }

            System.Console.WriteLine(mensagem);
        }
    }
}

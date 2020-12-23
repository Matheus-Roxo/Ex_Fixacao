using System;

namespace Exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Digite o ano atual:");
            int anoAtual = int.Parse(Console.ReadLine());;


            Console.WriteLine("Digite a sua data de nascimento: ");
            int nascimento = int.Parse(Console.ReadLine());

            
            int validacao = anoAtual - nascimento;


            if(validacao == 18){
                Console.WriteLine("Você precisa votar esse ano.");
            if(validacao > 16){
                Console.WriteLine("Caso já tenha titulo de eleitor o seu voto é opcional");
                }  
            } else {
                Console.WriteLine("Você ainda não podera votar esse ano.");
            }


        }
    }
}


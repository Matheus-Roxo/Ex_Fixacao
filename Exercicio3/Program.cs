using System;

namespace Exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o nome do produto desejado: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite a quantidade desejada do produto: ");
            int quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o preço do produto: ");
            float preco = float.Parse(Console.ReadLine());

            TotalAPagar(quantidade,preco);

            float TotalAPagar(int quantidade, float preco){

                float total = quantidade * preco;
                
                float desconto;

                if(quantidade <= 5){
                    desconto = 0.02f;
                }

                else if(quantidade <= 10){
                    desconto = 0.03f;
                }

                else{
                    desconto = 0.05f;
                }

                float valorDesconto = total * desconto;
                float totalDesconto = total - valorDesconto;

                Console.WriteLine($"O valor do produto é de: {total}");

                Console.WriteLine($"Você recebera R${valorDesconto} de desconto");

                Console.WriteLine($"O valor total com desconto é de R${totalDesconto}");

                return totalDesconto;
            }

        }
    }
}


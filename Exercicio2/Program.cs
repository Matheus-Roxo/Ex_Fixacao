using System;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {

            double litroGasolina = 5.3;
            
            double litroAlcool = 4.9;

            Console.WriteLine("Opções:");
            Console.WriteLine(" (1) Álcool");
            Console.WriteLine(" (2) Gasolina");
            string tipoCombustivel = Console.ReadLine();

            while(tipoCombustivel.ToUpper() != "1" && tipoCombustivel.ToUpper() != "2"){
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine("Essa não é uma opção valida.");
                Console.ResetColor();
                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Console.WriteLine("Opções");
                Console.WriteLine(" (1) Álcool");
                Console.WriteLine(" (2) Gasolina");
            }

            Console.Write("Quantos litros você deseja?");
            double litros = double.Parse(Console.ReadLine());

            
            switch(tipoCombustivel.ToUpper()){

                case "1":
                    CalcularPrecoDoAlcool(litroAlcool, litros);
                    break;

                case "2":
                    CalcularPrecoDaGasolina(litroGasolina, litros);
                    break;

                default:
                    break;
            }
        }

        static void CalcularPrecoDaGasolina(double litroGasolina, double litros){

            double valor = 0;

            double desconto1 = (litroGasolina * litros) * 0.04;

            double desconto2 = (litroGasolina * litros) * 0.06;

            switch(litros){

                case double n when n <= 20:
                    valor = (litroGasolina * litros) - desconto1;
                    break;

                case double n when n > 20:
                    valor = (litroGasolina * litros) - desconto2;
                    break;

                default:
                    break;
            }

            System.Console.WriteLine($"O valor total a ser pago pelo combustível é de R${valor}");
        }

        static void CalcularPrecoDoAlcool(double litroAlcool, double litros){

            double valor = 0;
            
            double desconto1 = (litroAlcool * litros) * 0.03;

            double desconto2 = (litroAlcool * litros) * 0.05;

            switch(litros){

                case double n when n <= 20:
                    valor = (litroAlcool * litros) - desconto1;
                    break;

                case double n when n > 20:
                    valor = (litroAlcool * litros) - desconto2;
                    break;

                default:
                    break;
            }

            System.Console.WriteLine($"O valor a ser pago pelo combustível é de R${valor}");

        }
    }
}

using System;

namespace Menu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Menu");

             int resultado1;
             int resultado2;
             int resultado;
             string opcao;

            Console.WriteLine("Digite o primeiro numero");
            resultado1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero");
            resultado2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite uma das opcoes");
            Console.WriteLine("1- Soma de dois números");
            Console.WriteLine("2- subtração do primeiro pelo segundo");
            Console.WriteLine("3- subtração do segundo pelo primeiro");
            Console.WriteLine("4- multiplicação dos dois números");
            Console.WriteLine("5- divisão do primeiro pelo segundo");
            Console.WriteLine("6- divisão do segundo pelo primeiro");
            opcao = Console.ReadLine();

             switch (opcao){
                case"1":
                resultado = resultado1+resultado2;
                Console.WriteLine($"Resultado será de {resultado}");
                break;

                case"2":
                resultado = resultado1-resultado2;
                Console.WriteLine($"Resultado será de {resultado}");
                break;

                case"3":
                resultado = resultado2-resultado1;
                Console.WriteLine($"Resultado será de {resultado}");
                break;

                case"4":
                resultado = resultado1*resultado2;
                Console.WriteLine($"Resultado será de {resultado}");
                break;

                case"5":
                resultado = resultado1/resultado2;
                Console.WriteLine($"Resultado será de {resultado}");
                break;

                case"6":
                resultado = resultado2/resultado1;
                Console.WriteLine($"Resultado será de {resultado}");
                break;
            }
        }
    }
}

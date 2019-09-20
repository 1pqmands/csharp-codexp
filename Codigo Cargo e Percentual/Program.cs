using System;

namespace Codigo_Cargo_e_Percentual
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Codigo Cargo e Percentual");

            Console.WriteLine("Digite seu nome");
            Console.ReadLine();

            Console.WriteLine("Digite seu salário");
            Console.WriteLine();
            
            Console.WriteLine("Digite o numero correspondente ao cargo");
            Console.WriteLine();
 
            Console.WriteLine("Digite uma das opcoes");
            Console.WriteLine("----------------------");
            Console.WriteLine("( 1 ) - Escriturário");
            Console.WriteLine("( 2 ) - Secretário");
            Console.WriteLine("( 3 ) - Caixa");
            Console.WriteLine("( 4 ) - Gerente");
            Console.WriteLine("( 5 ) - Diretor");
            Console.WriteLine("----------------------");

            string resposta = Console.ReadLine();
            
            switch(resposta){
              case "1":
              Console.WriteLine("O percentual é 50%");
              break;
              
              case "2":
              Console.WriteLine("O percentual é 35%");
              break;

              case "3":
              Console.WriteLine("O percentual é 20%");
              break;

              case "4":
              Console.WriteLine("O percentual é 10%");
              break;

              case "5":
              Console.WriteLine("Não tem aumento");
              break;

            }

        }
    }
}

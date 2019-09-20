using System;

namespace Menu2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercicio2");

            Console.WriteLine("Digite o primeiro numero");
            int resultado1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo numero");
            int resultado2 = int.Parse(Console.ReadLine());

            if (resultado1%2==0){
                Console.WriteLine("numero par");
            }else{
                Console.WriteLine("numero impar");
            }

            if (resultado2%2==0){
                Console.WriteLine("numero par");
            }else{
                Console.WriteLine("numero impar");
            }
            if (resultado1>resultado2)
            {
                Console.WriteLine($"valor 1 que é{resultado1} é maior que valor 2 que é {resultado2}");
            }
            else
            { Console.WriteLine($"valor 1 que é{resultado1} é menor que valor 2 que é {resultado2}");
            }
        }
    }
}

using System;

namespace Entrada_cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Entrada Cinema");

            Console.WriteLine("Digite a sua idade");
            int idade = int.Parse(Console.ReadLine());

            if (idade <= 18 || idade>= 60){
                //resultado verdadeiro
                Console.WriteLine("Você tem direito a meia entrada");
            }else{
                 //resultado falso
                 Console.WriteLine("Você não tem direito a Meia Entrada");
            }
            
        }
    }
}

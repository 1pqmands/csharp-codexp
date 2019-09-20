using System;

namespace idade_categoria
{
    class Program
    {
        static void Main(string[] args)
        {
         

            Console.WriteLine("Categoria de idade");
            int idade = int.Parse(Console.ReadLine());

           if (idade <=7) {
                Console.WriteLine("infantil A");
           } else if (idade <=10) {
             Console.WriteLine("infantil B");
           } 
           else if (idade <=13) {
                Console.WriteLine("Juvenil A");
           }
           else if (idade <=17) {
                Console.WriteLine("Juvenil B");
           } 
           else if (idade >=18) {
               Console.WriteLine("Adulto");
           }
           
        }
    }
}

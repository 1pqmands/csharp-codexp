using System;

namespace Calculo_de_média
{
    class Program
    {
        static void Main(string[] args)
        {
            //  aqui é onde iremos inserir o codigo

            Console.WriteLine("Calculadora de Médias");
            
            Console.WriteLine("Digite a primeira nota");
            int n1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a segunda nota");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite a terceira nota");
            int n3 = int.Parse(Console.ReadLine());
  
            float soma = (n1+n2+n3);
            float media = soma/3;
            
            //float media = (float)(n1+n2+n3)/3;

            Console.WriteLine($"A média é de: {media}");


        }
    }
}

using System;

namespace exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Ano de nascimento e atual");
            Console.WriteLine("----------------");

            Console.WriteLine("Ano atual");
            int AnoAtual = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite seu ano de nascimento");
            int NascimentoAno = int.Parse(Console.ReadLine());

            int idade = (AnoAtual-NascimentoAno);
            Console.WriteLine($"sua idade : {idade}");
            int ctz;
            ctz = idade*365;
            Console.WriteLine("");
            int final = ctz/7;
            
            Console.WriteLine($"Você tem {final} semanas vividas"); 
        }
    }
}

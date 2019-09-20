using System;

namespace exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.WriteLine("Conversão de idade");
          Console.WriteLine("----------------");

          Console.WriteLine("Digite a sua idade");
          int idade = int.Parse(Console.ReadLine());
   
         int idadeDias = idade*365;
         int idadeMeses = idade*12;
         int idadeHoras = idade*24;
         int IdadeMinutos = idade*60;

         Console.WriteLine($"Idade em dias: {IdadeDias} , Idade em meses: {IdadeMeses} , Idade em horas: {IdadeHoras} Idade em minutos");
        }
    }
}

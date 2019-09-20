using System;

namespace Exercicio_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Reajuste de salário");
            //entrada de dados

            float salarioAtual;

            Console.WriteLine("Digite seu salário");
            salarioAtual = float.Parse(Console.ReadLine());
            
            float valor = (salarioAtual*30)/100; 
            float resultado = valor+salarioAtual;

            if(resultado<=998) {
                Console.WriteLine($"recebe o reajuste de {resultado}");
            }else{
                Console.WriteLine("não recebe reajuste");
            }

        }
    }
}

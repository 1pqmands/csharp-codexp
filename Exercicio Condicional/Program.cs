using System;

namespace Exercicio_Condicional
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("App de média escolar");

            //entrada de dados
            Console.WriteLine("Digite o seu nome");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite a nota 1");
            float nota1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite a nota 2");
            float nota2 = float.Parse(Console.ReadLine());

            //processamento
            float media = (nota1+nota2)/2;
            
            string resultado;

            if(media>=7){
                resultado = "Aprovado"; //atribui o valor
            }else{
                resultado = "Reprovado";
            }
            
            Console.WriteLine($"O aluno {nome} com a média {media} está {resultado}");

            //Console.WriteLine($"Seu nome é") 
        }
    }
}

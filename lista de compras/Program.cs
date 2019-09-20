using System;

namespace lista_de_compras
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista de compras");
            
            string[] nomes = new string[6];

            int contador = 0;
            while(contador < 6){
                  Console.WriteLine("Digite o produto");
                  nomes[contador] = Console.ReadLine();
                  contador++;
            }//fim do while
            Console.WriteLine("");
            
            contador = 0;
            while(contador < 6){
                   Console.WriteLine($" Sua lista de frutas é {nomes[contador]}");
                   contador++;
            }
        }
    }
}

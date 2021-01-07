using System;

namespace _19_11___Vetores_arrays_e_foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array"); //Eu esqueci de mandar essa atividade quando estava no meu computador, agora tenho que fazer denovo.
            
            string[] nome = new string [3];
            int[] idades = new int[3];

            for(var i = 0; i < 3; i++)
            {
                Console.WriteLine($"Insira o {i+1}º nome");
                nome[i] = Console.ReadLine();
                Console.WriteLine("Insira a idade");
                idades[i] = int.Parse(Console.ReadLine());

            }
                Console.WriteLine("Informações cadastradas");
            for(var i = 0; i < 3; i++){
                Console.WriteLine("nome "+nome[i]);
                Console.WriteLine("idade: "+idades[i]+" anos");
                Console.WriteLine("-------");
            }
                
        }
    }
}

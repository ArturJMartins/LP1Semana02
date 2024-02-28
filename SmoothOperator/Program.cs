using System;

namespace SmoothOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insere número inteiro não-negativo: ");
            string usuario = Console.ReadLine();

            byte n = byte.Parse(usuario);
            
            Console.WriteLine(--n);
            Console.WriteLine(++n);
        }
    }
}

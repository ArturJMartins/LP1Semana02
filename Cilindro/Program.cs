using System;



namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Insira a altura do cilindro: ");
            float a = float.Parse(Console.ReadLine());

            Console.WriteLine("Insira o raio do cilindro: ");
            float r = float.Parse(Console.ReadLine());

            float volume = MathF.PI * MathF.Pow(r,2) * a;
            float areaDaSuperficie = 2 * MathF.PI * r * (r + a);

            Console.WriteLine($"O volume do cilindro é {volume}.");
            Console.WriteLine("A área de superfície do cilindro é " + 
            $"{areaDaSuperficie}.");
        }
    }
}

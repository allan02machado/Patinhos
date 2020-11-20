using System;

namespace Patinhos
{
    class Program
    {
        static void Main(string[] args)
        {
            int duckzin;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Five little ducks - The Wiggles");
            Console.ResetColor();

            Console.WriteLine("Digite a quantidade de patinhos deseja na música ");
            Console.Write("(Mínimo 2): ");
            duckzin = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            for(int i = duckzin; i>0; i -= 1)
            {
                Console.WriteLine($"{i} " + "Patinhos foram passear");
                Console.WriteLine("Além das montanhas");
                Console.WriteLine("Para brincar");
                Console.WriteLine("A mamãe gritou: Quá, quá, quá, quá");
                Console.WriteLine("Mas só " + (i - 1) + " patinhos voltaram de lá");
                Console.WriteLine();
            }
            Console.WriteLine("A mamãe patinha foi procurar");
            Console.WriteLine("Além das montanhas");
            Console.WriteLine("Na beira do mar");
            Console.WriteLine("A mamãe gritou: Quá, qua, qua, qua");
            Console.WriteLine($"E os " + duckzin + " patinhos voltaram de lá");
        }
    }
}

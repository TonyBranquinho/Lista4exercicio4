using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite um numero");
            int n = int.Parse(Console.ReadLine());

            double divisao = 0;
            for (int i = 0; i < n; i++) {
                string[] vet = Console.ReadLine().Split(' ');
                double a = double.Parse(vet[0]);
                double b = double.Parse(vet[1]);

                if (b == 0) {
                    Console.WriteLine("Divisao impossvel");
                }
                else {
                    divisao = a / b;
                    Console.WriteLine(divisao);

                }

            }
        }
    }
}
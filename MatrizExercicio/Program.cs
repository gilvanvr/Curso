using System;

namespace MatrizExercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Informe a quantidade de linhas: ");
            int m = int.Parse(Console.ReadLine());

            Console.Write("Informe a quantidade de colunas: ");
            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, n];

            for (int i = 0; i < m; i++)
            {
                string[] valores = Console.ReadLine().Split(" ");
                for (int j = 0; j < n; j++)
                {
                    matriz[i, j] = int.Parse(valores[j]);
                }
            }

            Console.Write("Informe um número pertencente a matriz: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matriz[i, j] == num)
                    {
                        Console.WriteLine("\nPosition: " + i + ", " + j);

                        if ((j - 1) >= 0)
                            Console.WriteLine("Left: " + matriz[i, (j - 1)]);

                        if ((j + 1) < n)
                            Console.WriteLine("Right: " + matriz[i, (j + 1)]);

                        if ((i - 1) >= 0)
                            Console.WriteLine("Up: " + matriz[(i - 1), j]);

                        if ((i + 1) < m)
                            Console.WriteLine("Down: " + matriz[(i + 1), (j)]);
                    }
                }
            }
        }
    }
}

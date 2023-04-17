namespace task05
{
    internal class Program
    {
        static void Main(string[] args)
        {

                double[,] matrizA = new double[2, 3];
                double[,] matrizB = new double[2, 3];
                // Matriz Auxilar para somar as outras duas
                double[,] matrizSoma = new double[2, 3];


                // Leitura da Primeira matriz
                for (int i = 0; i < matrizA.GetLength(0); i++)
                {
                    for (int j = 0; j < matrizA.GetLength(1); j++)
                    {
                        Console.WriteLine($"Digite o elemento [{i}, {j}] da matriz A:");
                        matrizA[i, j] = double.Parse(Console.ReadLine());
                    }
                }
                
                // Leitura da Segunda matriz
                for (int i = 0; i < matrizB.GetLength(0); i++)
                {
                    for (int j = 0; j < matrizB.GetLength(1); j++)
                    {
                        Console.WriteLine($"Digite o elemento [{i}, {j}] da matriz B:");
                        matrizB[i, j] = double.Parse(Console.ReadLine());
                    }
                }

                // Matriz de Soma
                for(int i = 0; i < matrizSoma.GetLength(0); i++)
                {
                   for(int j = 0; j < matrizSoma.GetLength(1); j++)
                    {
                        matrizSoma[i, j] = matrizA[i, j] + matrizB[i, j];
                    }
                }

                // Impressão da matriz soma
                Console.WriteLine("Matriz Soma:");
                for (int i = 0; i < matrizSoma.GetLength(0); i++)
                {
                    for (int j = 0; j < matrizSoma.GetLength(1); j++)
                    {
                        Console.Write($"{matrizSoma[i, j]} | ");
                    }
                    Console.WriteLine();
                }
            }
        }
 }
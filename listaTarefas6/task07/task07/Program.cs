namespace task07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrizA = new int[3, 3];
            int[,] matrizB = new int[3, 3];
            int[,] matrizC = new int[3, 3];
            Random random = new Random();

            // Leitura da Matriz A com números Aleatórios
            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)
                {
                    matrizA[i, j] = random.Next(0, 50);
                }
            }

            // Leitura da Matriz B com números Aleatórios
            for (int i = 0; i < matrizB.GetLength(0); i++)
            {
                for (int j = 0; j < matrizB.GetLength(1); j++)
                {
                    matrizB[i, j] = random.Next(0, 50);
                }
            }

            // Leitura da Matriz C sendo a subtração da A e B
            for (int i = 0; i < matrizC.GetLength(0); i++)
            {
                for (int j = 0; j < matrizC.GetLength(1); j++)
                {
                    matrizC[i, j] = matrizA[i, j] - matrizB[i, j];
                }
            }

            // Saída da Matriz C
            Console.WriteLine("Matriz C:");
            for (int i = 0; i < matrizC.GetLength(0); i++)
            {
                for (int j = 0; j < matrizC.GetLength(1); j++)
                {
                    Console.Write("{0} ", matrizC[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}

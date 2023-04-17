namespace task10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrizA = new int[4, 4];
            int[,] matrizB = new int[4, 4];
            int somaA = 0, somaB = 0;

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

            // Calcula a média dos elementos das matrizes A e B

            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)
                {
                    somaA += matrizA[i, j];
                    somaB += matrizB[i, j];
                }
            }

            // Tirando a média das Matrizes
            double mediaA = (double)somaA / (matrizA.GetLength(0) * matrizA.GetLength(1));
            double mediaB = (double)somaB / (matrizB.GetLength(0) * matrizB.GetLength(1));
            
            // Abaixo,em cima ou na média
            int abaixoMediaA = 0;
            int acimaMediaA = 0;
            int naMediaA = 0;
            int abaixoMediaB = 0;
            int acimaMediaB = 0;
            int naMediaB = 0;

            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)
                {
                    // Verificando A
                    if (matrizA[i, j] < mediaA)
                    {
                        abaixoMediaA++;
                    }
                    else if (matrizA[i, j] > mediaA)
                    {
                        acimaMediaA++;
                    }
                    else
                    {
                        naMediaA++;
                    }

                    // Verificando B
                    if (matrizB[i, j] < mediaB)
                    {
                        abaixoMediaB++;
                    }
                    else if (matrizB[i, j] > mediaB)
                    {
                        acimaMediaB++;
                    }
                    else
                    {
                        naMediaB++;
                    }
                }
            }

            Console.WriteLine("Matriz A:");
            Console.WriteLine($"Média: {mediaA}");
            Console.WriteLine($"Abaixo da média: {abaixoMediaA}");
            Console.WriteLine($"Acima da média: {acimaMediaA}");
            Console.WriteLine($"Na média: {naMediaA}");

            Console.WriteLine("Matriz B:");
            Console.WriteLine($"Média: {mediaB}");
            Console.WriteLine($"Abaixo da média: {abaixoMediaB}");
        }
    }
}

//10) Leia duas matrizes A e B de 4x4 elementos, calcule a média dos mesmos, em seguida,
// diga quantos dos elementos lidos estão abaixo, acima e na média.
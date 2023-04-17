namespace task14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrizA = new int[5, 5];
            bool diagonaisIguais = false;
            Random random = new Random();

            // Leitura da Matriz A com números Aleatórios
            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)
                {
                    matrizA[i, j] = random.Next(0, 50);
                }
            }

            // Verificando se elas possuem elementos iguais
            for(int i = 0; i < matrizA.GetLength(0); i++)
            {
                if (matrizA[i, i] == matrizA[i, matrizA.GetLength(0) - i - 1])
                {
                    diagonaisIguais = true;
                }
                else
                {
                    diagonaisIguais = false;
                }
            }

            // Saída da Matriz
            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)
                {
                    Console.Write(matrizA[i, j] + " ");
                }
                Console.WriteLine();
            }

            if(diagonaisIguais)
            {
                Console.WriteLine("As diagonais, principal e secundária, possuem elementos iguais.");
            }
            else
            {
                Console.WriteLine("As diagonais, principal e secundária, NÃO possuem elementos iguais.");
            }

        }
    }
}

//14) Escreva um programa que leia uma matriz
// de ordem 5 e verifique se os elementos da diagonal principal (da esquerda para a direita)
// são os mesmos da diagonal 
// secundária (direita pra esquerda).
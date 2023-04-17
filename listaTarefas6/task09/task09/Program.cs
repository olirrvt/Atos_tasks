namespace task09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrizA = new int[3, 3];
            Random random = new Random();
            int numeroEscolhido, numeroExiste = -1;

            // Leitura da Matriz com números Aleatórios
            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)
                {
                    matrizA[i, j] = random.Next(0, 50);
                }
            }
            

            // Leitura do número escolhido
            Console.Write($"Digite um número: ");
            numeroEscolhido = int.Parse(Console.ReadLine());
            

            // Verificando se existe na matriz
            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)
                {
                    if (matrizA[i, j] == numeroEscolhido)
                    {
                        numeroExiste = numeroEscolhido;
                    }
                }
            }

            // Saída da Matriz
            for (int i = 0; i < matrizA.GetLength(0); i++)
            {
                for (int j = 0; j < matrizA.GetLength(1); j++)
                {
                    Console.Write(matrizA[i, j] + " ");
                }
                Console.WriteLine(); // quebra de linha para imprimir nova linha da matriz
            }

            Console.WriteLine("---------------------------------------");

            // Existe ou não
            if(numeroExiste != -1)
            {
                Console.WriteLine($"O número {numeroEscolhido} existe na Matriz!");
            }
            else
            {
                Console.WriteLine($"O número {numeroEscolhido} não existe na Matriz!");
            }

        }
    }
}

// 9) Leia uma matriz 3x3. Em seguida, solicite um número qualquer ao usuário e
// pesquise na matriz se o número existe.
// Caso, seja verdade imprima a mensagem: “O número existe no vetor” , caso contrário “Número inexistente”.
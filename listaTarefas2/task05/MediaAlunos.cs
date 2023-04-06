namespace HelloWorld;

class MediaAlunos
{

    // 5 - Escrever um algoritmo para ler duas notas de um aluno e escrever na tela a palavra “Aprovado”. Se a média das duas notas for maior ou igual a 7,0.
    // Caso a média seja inferior a 7,0, o programa deve ler a nota do exame e calcular a média final,
    // é a média entre a nota do exame e a média das 2 notas. 
    // Se esta média final for maior ou igual a 5,0, o programa deve escrever “Aprovado”, caso contrário deve 
    // escrever “Reprovado”.

    static void Main(string[] args)
    {
        float nota1, nota2, media;

        // Informações da segunda nota
        Console.WriteLine("Digite a sua primeira nota:");
        nota1 = float.Parse(Console.ReadLine());

        // Informações da segunda nota
        Console.WriteLine("Digite a sua segunda nota:");
        nota2 = float.Parse(Console.ReadLine());
        
        media = (nota1 + nota2) / 2;

        if (media > 11)
        {
            media = media / 10f;
        } 

        // Lógica da média final

        if( media < 7.0 )
        {
            float exameFinal;

            Console.WriteLine($"Sua nota foi {media}.");
            Console.WriteLine("Você não conseguiu pontos suficientes para passar direto!");
            Console.WriteLine("Digite a nota do seu exame final:");
            exameFinal = float.Parse(Console.ReadLine());

            float mediaFinal = ( media + exameFinal) / 3;
            float mediaArredondada = (float)Math.Round(mediaFinal, 1);

            if( mediaArredondada >= 5.0 )
            {
                Console.WriteLine($"Sua nota foi {mediaArredondada}.");
                Console.WriteLine("Aprovado no exame final!");
            }
            else
            {
                Console.WriteLine($"Sua nota foi {mediaArredondada}.");
                Console.WriteLine("Reprovado!");
            }

        }
        else
        {
            Console.WriteLine($"Sua nota foi {media.ToString("F1")}.");
            Console.WriteLine("Parabéns! Aluno aprovado, curta suas férias.");
        }

    }
}
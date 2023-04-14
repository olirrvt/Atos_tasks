namespace Vetores;
class Program
{
    static void Main(string[] args)
    {
        double[] numeros = new double[10];
        double valorMenorQueZero = int.MaxValue;

        for(int i = 0; i < numeros.Length; i++)
        {
            Console.Write($"Digite o {i + 1}° número: ");
            numeros[i] = double.Parse(Console.ReadLine());
        }

        // Mostrando a posição dos valores menores que zero
        Console.WriteLine($"Posição na lista dos valores menores que zero:");
        for(int i = 0; i < numeros.Length; i++)
        {
            if(numeros[i] < 0)
            {   
                valorMenorQueZero = numeros[i];
                Console.Write($" {Array.IndexOf(numeros, valorMenorQueZero) + 1} |");
            }
        }


    }
}


// 8.	Fazer um algoritmo que leia trinta números reais armazenando-os em um vetor e após escreva a posição de cada número menor que zero desse vetor.
// Exemplo:
// Lê: |5.1|0|-3.6|4.1|-2.5|-1.3|-4|1.39|-128|-6.9|8.2|9|154|-88|6.4|7.1|...|
// Escreve: |3|5|6|7|9|10|14|. . .
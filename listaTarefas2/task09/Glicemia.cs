namespace HelloWorld;

class Glicemia
{
    //     9 - Faça um programa no VS que receba do usuário 3 valores de glicemia em jejum, representando a medição
    // diária de um paciente diabético. Para cada valor recebido analisar e informar ao paciente o seguinte:

    // Se o valor diário for menor que 65, avisá-lo que corre risco de hipoglicemia
    // Se o valor diário for maior que 250, avisá-lo que corre risco de hiperglicemia.

    // Além disso, o programa deve fazer a média dos 3 valores de glicemia coletados. E se a média for 
    // menor que 80, avisá-lo que é preciso diminuir 2 unidades de insulina. Se a média for maior que
    // 150, avisá-lo que será necessário adicionar 2 unidades de insulina.

    static void Main(string[] args)
    {

        double glicemiaDs1, glicemiaDs2, glicemiaDs3, mediaGlicemia;

        Console.WriteLine("Digite o valor da sua primeira dose de glicemia:");
        glicemiaDs1 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor da sua segunda dose de glicemia:");
        glicemiaDs2 = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite o valor da sua terceira dose de glicemia:");
        glicemiaDs3 = double.Parse(Console.ReadLine());

            mediaGlicemia = (glicemiaDs1 + glicemiaDs2 + glicemiaDs3) / 3;


            Console.WriteLine("____________________________________________________");
            Console.WriteLine("");
            // Verificação da Primeira dose de Glicemia

            if(glicemiaDs1 < 65)
            {
                Console.WriteLine($"A sua primeira dose, de {glicemiaDs1} mg/dl, corre risco de te causar Hipoglicemia.");
            }
            else if(glicemiaDs1 > 250)
            {
                Console.WriteLine($"A sua primeira dose, de {glicemiaDs1} mg/dl, corre risco de te causar Hiperglicemia.");
            }
            else
            {
                Console.WriteLine($"Sua dose de {glicemiaDs1} mg/dl está estável.");
            }

            Console.WriteLine("____________________________________________________");
            Console.WriteLine("");
            // Verificação da Segunda dose de Glicemia

            if(glicemiaDs2 < 65)
            {
                Console.WriteLine($"A sua segunda dose, de {glicemiaDs2} mg/dl, corre risco de te causar Hipoglicemia.");
            }
            else if(glicemiaDs2 > 250)
            {
                Console.WriteLine($"A sua segunda dose, de {glicemiaDs2} mg/dl, corre risco de te causar Hiperglicemia.");
            }
            else
            {
                Console.WriteLine($"Sua dose de {glicemiaDs2} mg/dl está estável.");
            }

            Console.WriteLine("____________________________________________________");
            Console.WriteLine("");

            // Verificação da Terceira dose de Glicemia

            if(glicemiaDs3 < 65)
            {
                Console.WriteLine($"A sua terceira dose, de {glicemiaDs3} mg/dl, corre risco de te causar Hipoglicemia.");
            }
            else if(glicemiaDs3 > 250)
            {
                Console.WriteLine($"A sua terceira dose, de {glicemiaDs3} mg/dl, corre risco de te causar Hiperglicemia.");
            }
            else
            {
                Console.WriteLine($"Sua dose de {glicemiaDs3} mg/dl está estável.");
            }

            Console.WriteLine("____________________________________________________");
            Console.WriteLine("");

            // Média da Glicemia para instruir a insulina

            if(mediaGlicemia < 80)
            {
                Console.WriteLine("Obs: Você precisa diminuir 2 unidades de insulina");
            }
            else if(mediaGlicemia > 150)
            {
                Console.WriteLine("Obs: Você precisa adicionar 2 unidades de insulina");
            }


    }
}
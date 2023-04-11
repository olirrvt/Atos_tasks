namespace HelloWorld;
class Program
{
    static void Main(string[] args)
    {
        int vtJoao = 0, vtZeca = 0, vtNulo = 0, vtBranco = 0;
        string voto;

        for(;true;)
        {
            Console.WriteLine("Caso queira encerrar a votação, digite 'FIM'.");
            Console.WriteLine("Caso queira votar em Branco, digite 'BRANCO'.");
            Console.WriteLine("Digite o nome do candidato da sua preferência:");

            voto = Console.ReadLine().ToLower();

            if (voto == "fim")
            {
                Console.WriteLine("Obrigado por exercer o seu direito de cidadão!");
                Console.WriteLine("--------------------------------------");
                Console.WriteLine("Tabela de apuração");
                Console.WriteLine("--------------------------------------");
                Console.WriteLine($"Candidato João: {vtJoao} votos");
                Console.WriteLine($"Candidato Zeca: {vtZeca} votos");
                Console.WriteLine($"Votos em Branco: {vtBranco} votos");
                Console.WriteLine($"Votos em nulo: {vtNulo} votos");
                Console.WriteLine("--------------------------------------");

                if(vtZeca > vtJoao)
                {
                    Console.WriteLine($"Com {vtZeca} votos, o candidato Zeca foi eleito!");
                }
                else if(vtJoao > vtZeca)
                {
                    Console.WriteLine($"Com {vtJoao} votos, o candidato João foi eleito!");
                }

                break;
            }

            switch (voto)
            {
                case "joao":
                    vtJoao++;
                break;

                case "zeca":
                    vtZeca++;
                break;

                case "branco":
                    vtBranco++;
                break;

                default:
                    vtNulo++;
                break;
            }
        }

    }
}

   
// 4. Em uma cidadezinha do interior há dois candidatos para prefeito (JOAO e ZECA). 
// Você foi contratado para fazer um programa em VS que conte os votos dos candidatos. 
// Cada vez que o usuário digitar JOAO, você deve somar um ao seu número de votos. O mesmo para ZECA. 
// Você também pode aceitar votos em branco (palavra BRANCO). O programa em VS termina quando o usuário 
// escrever FIM. Ao final devem ser mostradas as quantidades de votos para cada um dos candidatos e o número 
// de votos em branco.

// 5. Modifique o programa em VS anterior para aceitar votos nulos 
// (qualquer nome diferente de FIM, JOAO, ZECA e BRANCO). 
// Ao final, informe o nome do candidato vencedor, o número de votos nulos 
// e o número de pessoas que votaram.
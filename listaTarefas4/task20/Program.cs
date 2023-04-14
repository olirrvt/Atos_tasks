using System;
namespace Matrizes;
class Program
{
    static void Main(string[] args)
    {
        string opcao, sexo, corDosOlhos, corDoCabelo;
        int idade, idadeMaior = 0, padraoDaPesquisa = 0;
        bool continua = true;
        do
        {
            // Sexo
            Console.WriteLine("Qual o seu sexo?");
            sexo = Console.ReadLine().ToLower();
            // Cor dos Olhos
            Console.WriteLine("Qual a cor dos seus olhos?");
            corDosOlhos = Console.ReadLine().ToLower();
            // Cor do Cabelo
            Console.WriteLine("Qual a cor do seu cabelo?");
            corDoCabelo = Console.ReadLine().ToLower();
            // Idade
            Console.WriteLine("Qual a sua idade?");
            idade = int.Parse(Console.ReadLine());
            // Verificando a maior idade entre os habitantes
            idadeMaior = idade > idadeMaior ? idade : idadeMaior;
            // a quantidade de indivíduos do sexo feminino cuja idade está entre 18 e 35 anos inclusive
            // e que tenham olhos verdes e cabelos louros.
            if((sexo == "feminino") && (idade >= 18 && idade <= 35) && (corDosOlhos == "verde") && (corDoCabelo == "loiro" || corDoCabelo == "loira"))
            {
                padraoDaPesquisa++;
            }
            // Encerramento do Programa
            Console.WriteLine("Deseja encerrar a pesquisa? (S/N)?");
            opcao = Console.ReadLine().ToLower();
            continua = opcao == "s" ? false : true;
        }
        while(continua);
        Console.WriteLine($"A maior idade entre os habitantes é: {idadeMaior}");
        Console.WriteLine($"A quantidade de indivíduos que correspondem a pesquisa: {padraoDaPesquisa}");
    }
}

// 20. Foi realizada uma pesquisa de algumas características físicas da população de uma 
// certa região, a qual coletou os seguintes dados referentes a cada habitante para 
// serem analisados:
// - sexo (masculino e feminino)
// - cor dos olhos (azuis, verdes ou castanhos)
// - cor dos cabelos ( louros, castanhos, pretos)
// - idade 
 
// Faça um algoritmo que determine e escreva: 
 
// - a maior idade dos habitantes
// - a quantidade de indivíduos do sexo feminino cuja idade está entre 18 e 35 anos inclusive
// e que tenham olhos verdes e cabelos louros.
// O final do conjunto de habitantes é reconhecido pelo valor -1 entrada como idade.
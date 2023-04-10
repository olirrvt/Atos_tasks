using System;

namespace ConversorDeUnidades
{
    class Program

    // 21 - Crie um programa que permita que o usuário selecione uma unidade de medida de entrada (metros, centímetros, polegadas ou pés) e uma unidade de 
    // medida de saída usando um menu com o comando switch case. O programa deve, em seguida, pedir ao usuário  um valor de entrada e converter esse 
    // valor para a unidade de saída selecionada.

    {
        static void Main(string[] args)
        {
            Console.WriteLine("Selecione a unidade de medida de entrada:");
            Console.WriteLine("1 - Metros");
            Console.WriteLine("2 - Centímetros");
            Console.WriteLine("3 - Polegadas");
            Console.WriteLine("4 - Pés");

            int unidadeEntrada = int.Parse(Console.ReadLine());

            Console.WriteLine("Selecione a unidade de medida de saída:");
            Console.WriteLine("1 - Metros");
            Console.WriteLine("2 - Centímetros");
            Console.WriteLine("3 - Polegadas");
            Console.WriteLine("4 - Pés");

            int unidadeSaida = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o valor de entrada:");
            double valorEntrada = double.Parse(Console.ReadLine());

            double valorSaida = 0;

            switch (unidadeEntrada)
            {
                case 1: // metros
                    switch (unidadeSaida)
                    {
                        case 1: // metros
                            valorSaida = valorEntrada;
                            break;
                        case 2: // centímetros
                            valorSaida = valorEntrada * 100;
                            break;
                        case 3: // polegadas
                            valorSaida = valorEntrada * 39.37;
                            break;
                        case 4: // pés
                            valorSaida = valorEntrada * 3.281;
                            break;
                    }
                    break;

                case 2: // centímetros
                    switch (unidadeSaida)
                    {
                        case 1: // metros
                            valorSaida = valorEntrada / 100;
                            break;
                        case 2: // centímetros
                            valorSaida = valorEntrada;
                            break;
                        case 3: // polegadas
                            valorSaida = valorEntrada * 0.3937;
                            break;
                        case 4: // pés
                            valorSaida = valorEntrada * 0.03281;
                            break;
                    }
                    break;

                case 3: // polegadas
                    switch (unidadeSaida)
                    {
                        case 1: // metros
                            valorSaida = valorEntrada / 39.37;
                            break;
                        case 2: // centímetros
                            valorSaida = valorEntrada / 0.3937;
                            break;
                        case 3: // polegadas
                            valorSaida = valorEntrada;
                            break;
                        case 4: // pés
                            valorSaida = valorEntrada * 0.08333;
                            break;
                    }
                    break;

                case 4: // pés
                    switch (unidadeSaida)
                    {
                        case 1: // metros
                            valorSaida = valorEntrada / 3.281;
                            break;
                        case 2: // centímetros
                            valorSaida = valorEntrada / 0.03281;
                            break;
                        case 3: // polegadas
                            valorSaida = valorEntrada / 0.08333;
                            break;
                        case 4: // pés
                            valorSaida = valorEntrada;
                            break;
                    }
                    break;
            }

            Console.WriteLine($"Valor de saída: {valorSaida}");
        }
    }
}

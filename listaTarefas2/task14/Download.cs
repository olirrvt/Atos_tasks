using System;
 namespace HelloWorld;

class Download
{
    static void Main(string[] args)
    {
        double tamanho, vel, tempo, velMB;
        int min;

        Console.WriteLine("Digite o tamanho do arquivo:");
        tamanho = double.Parse(Console.ReadLine());

        Console.WriteLine("Digite a velocidade do link:");
        vel = double.Parse(Console.ReadLine());

        // Fórmula para saber velocidade em MB
        velMB = vel * 0.125;

        // t = tamanho / velocidade para saber o tempo
        tempo = (tamanho / velMB) / 60;
        min = (int)tempo % 60;

        Console.WriteLine($"O tempo aproximado será de {min} minutos...");

    }
}
﻿namespace HelloWorld;
class Program
{
    static void Main(string[] args)
    {
        int idade;
        double salario;
        string nome;

        Console.WriteLine("Hello World!");
    }
}

// 7. Faça um programa em VS que solicite o nome, a idade e o salário de uma pessoa. 


// A cada solicitação, teste se o usuário informou um valor válido. 
// Por exemplo: se o nome for não for lido corretamente (ou seja, se estiver em branco ou se for um número), 
// informe que ele está incorreto e saia do programa em VS. 
// Se o nome for lido corretamente, solicite a idade. Se ela for incorreta (menor ou igual a zero), 
// informe que está errada e saia. Se estiver correta, solicite o salário. 
// Se ele estiver incorreto (menor ou igual a zero), informe que está incorreto e saia. 
// Se estiver correto, mostre todos os valores lidos.
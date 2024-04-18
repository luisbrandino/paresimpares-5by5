//faça um programa que leia um número inicial e um numero final mostrando entre eles quais são os valores pares e impares

Console.Write("Informe um número inicial: ");
int start = int.Parse(Console.ReadLine());

Console.Write("Informe um número final: ");
int final = int.Parse(Console.ReadLine());

for (int i = start + 1; i < final; i++)
    if (i == 0)
        Console.WriteLine("0 é neutro!");
    else if (i % 2 == 0)
        Console.WriteLine($"{i} é par!");
    else
        Console.WriteLine($"{i} é ímpar!");
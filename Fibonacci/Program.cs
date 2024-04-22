/*
 1- faça um programa que leia um numero inteiro e imprima até esta posicao da sequencia fibonnaci (sem vetor)

 
Logica:
    temp: variavel auxiliar para logica
    anterior: variavel que representa o numero anterior na sequencia fibonacci
    atual: variavel que representa o numero atual

    temp = atual + anterior; // temp recebe a soma do atual com antecessor
    anterior = atual; // atual vira o antecessor
    atual = temp; // atual agora possui a soma
 */

int tamanho = 0, temp = 0, anterior = 0, atual = 1;

Console.WriteLine("=====Fibonacci=====");

do
{
    Console.Write("Digite um numero do tamanho da sequencia: ");
    tamanho = int.Parse(Console.ReadLine());

    if (tamanho <= 0)
    {
        Console.WriteLine("Numero inválido");
    }
    else {

        Console.Write("Sequencia: ");    
            
        if (tamanho >= 1)
            Console.Write($"{anterior} ");
        if(tamanho >= 2)
            Console.Write($"{atual} ");
        for(int i = 2; i < tamanho; i++)
        {
            temp = atual + anterior;
            anterior = atual;
            atual = temp;

            Console.Write($"{atual} ");
        }
    }
} while (tamanho <= 0);

Console.WriteLine("\n=============================");

Console.Write("\nDigite qualquer tecla para sair: ");
Console.ReadKey();
// 1
using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Xml;
using Microsoft.Win32.SafeHandles;

void ObterNums(){
    float num1 = float.Parse(Console.ReadLine()!);
    float num2 = float.Parse(Console.ReadLine()!);
    CalcularOps(num1, num2);
}

void CalcularOps(float num1, float num2)
{   
    Console.WriteLine($"Soma = {num1 + num2}");
    Console.WriteLine($"Subtração = {num1 - num2}");
    if(num2 !=0) {Console.WriteLine($"Multiplicação: {num1 * num2}");}
    else{ Console.WriteLine("Dividendo igual a zero. Não foi possível dividir!"); }
    Console.WriteLine($"Divisão: {num1 / num2}");
}

// 2
void MostrarBandasFavoritas(){
    List<string> bandas = new List<string> {"Coldplay", "ANAVITÓRIA", "The Neighborhood"};

    // 3
    foreach (string banda in bandas)
    {
        Console.WriteLine(banda);
    }
}
// 4

void CalcularLista(){
    List<int> elementos = new List<int>{1, 22, 33, 55};
    
    int total = 0;
    foreach (int el in elementos)
    {
        total += el;
    }
    Console.WriteLine(total);
}

// Exercício "Faça como eu fiz": Crie uma lista de inteiros utilizando o List<int> e utilize o for e o foreach para iterar sobre essa lista e exibir apenas os números pares.
void MostrarPares()
{
    List<int> listNum = new List<int>();
    Random rand = new Random();
    for (int i = 0; i < 10; i++)
    {
        listNum.Add(rand.Next(1, 101));
    }
    
    foreach(int num in listNum)
    {
        if(num % 2 == 0) Console.WriteLine(num);
    }

}

void ColetarOpcao(){
int opcao = int.Parse(Console.ReadLine()!);
switch (opcao)
    {
        case 1: ObterNums(); break;
        case 2: MostrarBandasFavoritas(); break;
        case 3: CalcularLista(); break;
        case 4: MostrarPares(); break;
        default: Console.WriteLine("Opção inválida."); break;
    }
}

ColetarOpcao();
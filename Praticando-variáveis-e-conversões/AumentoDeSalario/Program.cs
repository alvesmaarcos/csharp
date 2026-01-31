double salarioAtual = double.Parse(Console.ReadLine()!);
double percentualAumento = double.Parse(Console.ReadLine()!);

double novoSalario = salarioAtual + (salarioAtual * percentualAumento/100);

Console.WriteLine($"O novo salário é de R${novoSalario:F2}");
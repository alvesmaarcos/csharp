Console.Write("Insira a nota final do aluno: ");
double nota = double.Parse(Console.ReadLine()!);
char desempenho;
if(nota >= 9)
{
    desempenho = 'A';
}
else if(nota >= 7)
{
    desempenho = 'B';
}
else if(nota >= 5)
{
    desempenho = 'C';
}
else
{
    desempenho = 'D';
}

Console.WriteLine($"O aluno recebeu nota {desempenho}");
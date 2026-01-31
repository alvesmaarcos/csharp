List<string> alunos = new List<string>{"Ana", "Carlos", "Bianca", "João", "Marina" };

while (true)
{
    Console.Write("Digite o nome do aluno: ");
    string aluno = Console.ReadLine()!;

    if (alunos.Contains(aluno))
    {
        Console.WriteLine($"Aluno(a) encontrado na posição {alunos.IndexOf(aluno)}"); 
        break;
    }
    else
    {
        Console.WriteLine("Aluno(a) não está presente na lista");
    }
}
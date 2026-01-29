// 1
void MediaDasNotas()
{
    var notasAlunos = new Dictionary<string, Dictionary<string, List<int>>> {
    { "Ana", new Dictionary<string, List<int>> {
        { "C#", new List<int> { 8, 7, 6 } },
        { "Java", new List<int> { 7, 6, 5 } },
        { "Python", new List<int> { 9, 8, 8 } }
    }},
    { "Maria", new Dictionary<string, List<int>> {
        { "C#", new List<int> { 6, 5, 4 } },
        { "Java", new List<int> { 8, 7, 6 } },
        { "Python", new List<int> { 6, 10, 5 } }
    }},
    { "Luiza", new Dictionary<string, List<int>> {
        { "C#", new List<int> { 2, 3, 10 } },
        { "Java", new List<int> { 8, 8, 8 } },
        { "Python", new List<int> { 7, 7, 7 } }
    }}
};

    foreach (string aluno in notasAlunos.Keys)
    {
        int sumCs = 0;
        int sumJava = 0;
        int sumPython = 0;
        for (int i = 0; i < 3; i++)
        {
            sumCs += notasAlunos[aluno]["C#"][i];
            sumJava += notasAlunos[aluno]["Java"][i];
            sumPython += notasAlunos[aluno]["Python"][i];
        }
        double meanCs = sumCs / 3;
        double meanJava = sumJava / 3;
        double meanPy = sumPython / 3;

        Console.WriteLine($"{aluno}:");
        Console.WriteLine($"Médias:\nC# = {meanCs}\nJava = {meanJava}\nPython = {meanPy}");
    }
}

MediaDasNotas();
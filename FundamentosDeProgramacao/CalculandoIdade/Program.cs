void CalcularIdade()
{
    Console.Write("Olá! Insira o ano de nascimento: ");
    int anoNasc = int.Parse(Console.ReadLine()!);
    int anoAtual = 2026;

    int idade = anoAtual - anoNasc;

    if (idade > 0)
    {
        Console.WriteLine($"Estamos em {anoAtual}. Como você nasceu em {anoNasc}, possui {idade} anos.");
    } else
    {
        Console.WriteLine("Ano inválido. Tente novamente.");
        CalcularIdade();
    }
}

CalcularIdade();
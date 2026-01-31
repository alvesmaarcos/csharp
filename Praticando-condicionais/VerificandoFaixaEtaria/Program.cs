Console.Write("Digite a idade: ");
int idade = int.Parse(Console.ReadLine()!);
string faixaEtaria;


if (idade >= 60)
{
    faixaEtaria = "Idoso";
}
else if(idade >= 18)
{
    faixaEtaria = "Adulto";
}
else if(idade >= 13)
{
    faixaEtaria = "Adolescente";
}
else
{
    faixaEtaria = "Infantil";
}

Console.WriteLine($"Classificação: {faixaEtaria}");
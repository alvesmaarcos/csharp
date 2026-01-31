Console.WriteLine("1 - Manhã\n2 - Tarde\n3 - Noite");
Console.Write("Que momento do dia é agora? ");
int horario = int.Parse(Console.ReadLine()!);

string saudacao = "";
bool horarioValido = true;

switch (horario)
{
    case 1: saudacao = "Bom dia"; break;
    case 2: saudacao = "Boa tarde"; break;
    case 3: saudacao = "Boa noite"; break;
    default:
        horarioValido = false;
        Console.WriteLine("Erro: horário inválido.");
    break;
}

if (horarioValido)
{
    Console.Write("Qual seu nome? ");
    string nome = Console.ReadLine()!;
    Console.WriteLine($"{saudacao}, {nome}.");
}
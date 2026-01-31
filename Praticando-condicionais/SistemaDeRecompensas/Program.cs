Console.Write("Digite o código de recompensa (DOBRAR, CURAR, OURO, ESPECIAL): ");
string cupom = Console.ReadLine()!;

switch (cupom)
{
    case "DOBRAR":
    Console.WriteLine("Ganhou 2x de EXP por 1 hora");
    break;

    case "CURAR":
    Console.WriteLine("Ganhou uma poção de cura");
    break;

    case "OURO":
    Console.WriteLine("Ganhou 1000 em moedas de ouro");
    break;

    case "ESPECIAL":
    Console.WriteLine("Item lendário desbloqueado!");
    break;
    
    default:
    Console.WriteLine("Cupom inválido");
    break;
}
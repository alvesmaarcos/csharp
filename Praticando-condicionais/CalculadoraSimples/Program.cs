Console.Write("Número 1: ");
double n1 = double.Parse(Console.ReadLine()!);

Console.Write("Operação: ");
string op = Console.ReadLine()!;

Console.Write("Número 2: ");
double n2 = double.Parse(Console.ReadLine()!);


double res = 0.0;
bool operacaoValida = true;


switch (op)
{
    case "+": res = n1 + n2; break;
    case "-": res = n1 - n2; break;
    case "/":
        if(n2 == 0)
        {
            Console.WriteLine("Erro: não é possível dividir por 0.");
            operacaoValida= false;
        }
        else
        {
            res = n1 / n2;
        }
        break;
    case "*": res = n1 * n2; break;
    default: 
        Console.WriteLine("Operação inválida."); 
        operacaoValida = false;
    break;
}

if(operacaoValida)
{
    Console.WriteLine($"{res}");
}
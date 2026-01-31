int sum = 0;
int val = 0;
while (true)
{
    Console.Write("Digite o valor da venda (ou 0 para sair): ");
    val = int.Parse(Console.ReadLine()!);
    if(val == 0)
    {
        break;
    }
    else
    {
        sum += val;
    }
}

Console.WriteLine($"Total de vendas do dia: {sum}.");
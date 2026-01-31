Console.WriteLine("Deseja adicionar um produto ao estoque?\n 1 - Sim\n 2 - Não");
int res = int.Parse(Console.ReadLine()!);
int estoque = 0;

if (res == 1)
{
    while (true)
    {
        Console.WriteLine("Deseja continuar? 1 - Sim | 2 - Não");
        res = int.Parse(Console.ReadLine()!);
        if(res == 1)
        {
            continue;
        }
        else if(res == 2)
        {
            Console.WriteLine("Saindo...");
        }
        else
        {
            Console.WriteLine("Opção inválida.");
        }
        Console.Write("Quantidade: ");
        int qtd = int.Parse(Console.ReadLine()!);
        estoque += qtd;
        Console.WriteLine($"Estoque atual: {estoque}");
    }
}
else if(res == 2)
{
    Console.WriteLine("Saindo...");
}
else
{
    Console.WriteLine("Opção inválida.");
}
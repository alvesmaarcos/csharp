int codProduto = int.Parse(Console.ReadLine()!);

if (codProduto == 1)
{
    Console.WriteLine("Perecível");
}
else if (codProduto == 2)
{
    Console.WriteLine("Não perecível");
}
else
{
    Console.WriteLine("Código inválido");
}
Console.Write("Insira o código do livro: ");
int cod = int.Parse(Console.ReadLine()!);
int primeiroDig = int.Parse(cod.ToString()[0].ToString());

switch (primeiroDig)
{
    case 1:
        Console.WriteLine("Categoria: Ficção científica");
        break;
    case 2:
        Console.WriteLine("Categoria: Literatura Clássica");
        break;
    case 3:
        Console.WriteLine("Categoria: Fantasia");
        break;
    case 4:
        Console.WriteLine("Categoria: Romance");
        break;
    case 5:
        Console.WriteLine("Categoria: Suspense/Mistério");
        break;
    case 6:
        Console.WriteLine("Categoria: Não ficção");
        break;
    case 7:
        Console.WriteLine("Categoria: Biografias/Memórias");
        break;
    case 8:
        Console.WriteLine("Categoria: Distopia");
        break;
    case 9:
        Console.WriteLine("Categoria: Infantojuvenil");
        break;
    default:
        Console.WriteLine("Categoria desconhecida");
        break;
}

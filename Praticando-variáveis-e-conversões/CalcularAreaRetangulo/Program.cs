double CalcularAreaRetangulo(double l, double c)
{
    double area = l * c;
    return area;
}

double largura = double.Parse(Console.ReadLine()!);
double comprimento = double.Parse(Console.ReadLine()!);
double area = CalcularAreaRetangulo(largura, comprimento);
Console.WriteLine($"A área do terreno é de {area:F2} metros quadrados");
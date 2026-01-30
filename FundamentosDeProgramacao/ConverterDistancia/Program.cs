double ConverterDistancia(double milhas)
{
    double km = milhas * 1.60934;
    return km;
}

double milhas = double.Parse(Console.ReadLine()!);
Console.WriteLine($"{milhas} equivale(m) a {ConverterDistancia(milhas)} quilômetro(s).");
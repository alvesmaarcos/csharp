void ConverterTempo(int minutos)
{
    if(minutos < 60)
    {
        Console.WriteLine($"{minutos} minutos");
    }
    else if (minutos % 60 != 0)
    {
        Console.WriteLine($"{minutos/60} hora(s) e {minutos%60} minuto(s)");
    }
    else
    {
        Console.WriteLine($"{minutos/60} hora(s)");
    }
}


int totalMinutos = int.Parse(Console.ReadLine()!);
ConverterTempo(totalMinutos);
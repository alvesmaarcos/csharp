using System.Globalization;

Console.Write("Olá! Escolha um número:");
Random rnd = new Random();
int randInt = rnd.Next(1, 101);

while (true)
{
    int num = int.Parse(Console.ReadLine()!);
    if(num == randInt)
    {
        Console.WriteLine("Parabéns, você acertou!!");
        break;
    }
    else if(randInt > num)
    {
        Console.WriteLine("Maior");
    }
    else
    {
        Console.WriteLine("Menor");
    }

}
void ObterNums(){
    float num1 = float.Parse(Console.ReadLine()!);
    float num2 = float.Parse(Console.ReadLine()!);
    CalcularOps(num1, num2);
}

void CalcularOps(float num1, float num2)
{   
    Console.WriteLine($"Soma = {num1 + num2}");
    Console.WriteLine($"Subtração = {num1 - num2}");
    if(num2 !=0) {Console.WriteLine($"Multiplicação: {num1 * num2}");}
    else{ Console.WriteLine("Dividendo igual a zero. Não foi possível dividir!"); }
    Console.WriteLine($"Divisão: {num1 / num2}");
}

ObterNums();
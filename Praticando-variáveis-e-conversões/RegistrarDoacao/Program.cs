
void RegistrarDoacao(double valor, bool anonima, string tipoConta)
{
    if(tipoConta == "Poupança")
    {
        tipoConta = "P";
    }
    else
    {
        tipoConta = "C";
    }
    Console.WriteLine($"Valor recebido: R${valor:F2}");
    Console.WriteLine($"Doação anônima: {anonima}");
    Console.WriteLine($"Tipo de conta: {tipoConta}");
}



Console.WriteLine("Insira os dados da doação: ");
Console.Write("Valor: R$");
double valor = double.Parse(Console.ReadLine()!);
Console.Write("\nAnônima? (Sim/Não): ");
string resAnonima = Console.ReadLine()!;
bool anonima;
if(resAnonima == "Sim")
{
    anonima = true;
}
else
{
    anonima = false;  
}
Console.Write("Tipo da conta: (Corrente/Poupança)");
string tipoConta = Console.ReadLine()!;
if(tipoConta == "Poupança"|| tipoConta == "Corrente")
{
    RegistrarDoacao(valor, anonima, tipoConta);
} else
{
    Console.WriteLine("Tipo de conta inválido. Tente novamente.");
}




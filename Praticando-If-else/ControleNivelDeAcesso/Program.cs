int senha = 42;
int nivelAcesso = 5;

Console.Write("Digite a senha: ");
int inputSenha = int.Parse(Console.ReadLine()!);
Console.Write("Digite o nível de acesso: ");
int inputAcesso = int.Parse(Console.ReadLine()!);

if(inputSenha == senha && inputAcesso >= nivelAcesso)
{
    Console.WriteLine("Acesso liberado.");
}
else
{
    Console.WriteLine("Acesso negado.");
}
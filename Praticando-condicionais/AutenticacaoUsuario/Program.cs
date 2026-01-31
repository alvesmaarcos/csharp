List<string> usuarios = new List<string>{"Admin"};

Console.WriteLine("Digite seu nome de usuário: ");
string userName = Console.ReadLine()!;

if (usuarios.Contains(userName))
{
    Console.WriteLine($"Seja bem-vindo(a), {userName}");
}
else
{
    Console.WriteLine("Usuário não cadastrado.");
    Console.WriteLine("Opções disponíveis:\n[1] Cadastrar novo usuário\n[2] Acessar como convidado\n[3] Sair");
    int op = int.Parse(Console.ReadLine()!);

    switch (op)
    {
        case 1:
            usuarios.Add(userName);
            Console.WriteLine($"Usuário {userName} cadastrado com sucesso");
        break;

        case 2:
            Console.WriteLine("Acesso concedido como convidado");
        break;

        case 3:
            Console.WriteLine("Saindo...");
        break;
        
        default:
            Console.WriteLine("Opção inválida");
        break;
    }
}
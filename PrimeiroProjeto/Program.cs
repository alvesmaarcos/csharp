string msgBoasVindas =  "Boas vindas ao Screen Sound";
List<string> listaBandas = new List<string>();
void ExibirLogo()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
    ");
    Console.WriteLine(msgBoasVindas);
}

void ExibirOpcoesMenu()
{
    Console.WriteLine("\nDigite 1 para registrar uma banda");
    Console.WriteLine("Digite 2 para mostrar todas as bandas");
    Console.WriteLine("Digite 3 para avaliar uma banda");
    Console.WriteLine("Digite 4 para exibir a média de uma banda");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNum = int.Parse(opcaoEscolhida);
    switch (opcaoEscolhidaNum)
    {
        case 1: RegistrarBanda();
            break;
        case 2: Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNum);
            break;
        case 3: Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNum);
            break;
        case 4: Console.WriteLine("Você escolheu a opção " + opcaoEscolhidaNum);
            break;
        case -1: Console.WriteLine("Tchau tchau <3");
            break;
        default: Console.WriteLine("Opção inválida. Tente novamente.");
            break;
    }

}

void RegistrarBanda()
{
    Console.Clear();
    Console.WriteLine("Registro de bandas");
    Console.Write("Digite o nome da banda que você deseja registrar: ");
    string banda = Console.ReadLine()!;
    listaBandas.Add(banda);
    Console.WriteLine($"A banda {banda} foi registrada com sucesso.");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesMenu();
}
ExibirLogo();
ExibirOpcoesMenu();
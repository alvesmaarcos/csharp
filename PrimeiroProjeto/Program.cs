using System.Runtime;

string msgBoasVindas =  "Boas vindas ao Screen Sound";
//List<string> listaBandas = new List<string> {"U2", "The Beatles"};
Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Linkin Park", new List<int> {10, 8, 6});
bandasRegistradas.Add("The Beatles", new List<int>());

void ExibirLogo()
{
    Console.Clear();
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
        case 2: MostrarBandas();
            break;
        case 3: AvaliarBanda();
            break;
        case 4: ExibirMedia();
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
    ExibirTituloDaOpcao("Registro de bandas");
    Console.Write("Digite o nome da banda que você deseja registrar: ");
    string banda = Console.ReadLine()!;
    bandasRegistradas.Add(banda, new List<int>());
    Console.WriteLine($"A banda {banda} foi registrada com sucesso.");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesMenu();
}

void MostrarBandas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Mostrando todas as bandas registradas");
    //for(int i = 0; i < listaBandas.Count; i++)
    //{
    //    Console.WriteLine($"{i+1}: {listaBandas[i]}");
    //}
    
    foreach(string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"{banda}");
    }
}

void AvaliarBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Avaliar banda");
    Console.WriteLine("Qual banda gostaria de avaliar?");
    string banda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(banda))
    {
        Console.Write($"Qual nota a banda {banda} merece? ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[banda].Add(nota);
        Console.WriteLine($"Nota {nota} adicionada com sucesso à banda {banda}!");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirLogo(); ExibirOpcoesMenu();
    } else
    {
        Console.WriteLine($"Banda {banda} não encontrada.\nDigite 1 para escrever novamente ou qualquer outra tecla para voltar ao menu principal.");
        string entrada = Console.ReadLine()!;
        switch (entrada)
        {
            case "1": AvaliarBanda(); break;
            default: ExibirLogo(); ExibirOpcoesMenu(); break;
        }
    }
}

void ExibirMedia()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibição de Média");
    Console.Write("Qual banda gostaria de visualizar? ");
    string banda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(banda))
    {
        List<int> notas = bandasRegistradas[banda];
        Console.WriteLine($"\nA média da banda {banda} é {notas.Average()}.");
        Console.WriteLine("Digite qualquer tecla para voltar ao menu principal.");
        Console.ReadKey();
        ExibirOpcoesMenu();
    } 
    else
    {
        Console.WriteLine($"Banda {banda} não encontrada.\nDigite 1 para escrever novamente ou qualquer outra tecla para voltar ao menu principal.");
        string entrada = Console.ReadLine()!;
        switch (entrada)
        {
            case "1": AvaliarBanda(); break;
            default: ExibirLogo(); ExibirOpcoesMenu(); break;
        }
    }
}


void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos);

}
ExibirLogo();
ExibirOpcoesMenu();
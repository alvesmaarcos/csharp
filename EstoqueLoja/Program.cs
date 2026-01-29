

Dictionary<string, int> estoque = new Dictionary<string, int>();

void MostrarEstoque()
{
    Console.Clear();
    foreach (string produto in estoque.Keys)
    {
        Console.WriteLine($"{produto}: {estoque[produto]} unidades");
    }
    Console.ReadKey();
    TelaInicial();
}

void AddProduto(string nome, int quantidade)
{
    Console.Clear();
    if (estoque.ContainsKey(nome))
    {
        estoque[nome] += quantidade;
    } else {
        estoque[nome] = quantidade;
    }
    Console.ReadKey();
    TelaInicial();
}

void UpdateProduto(string nome, int quantidade)
{
    Console.Clear();
    if (estoque.ContainsKey(nome))
    {
        estoque[nome] = quantidade;
    } else {
        Console.WriteLine($"Produto {nome} não encontrado no estoque.");
    }
    Console.ReadKey();
    TelaInicial();
}

void RemoveProduto(string nome)
{
    Console.Clear();
    if (estoque.ContainsKey(nome))
    {
        estoque.Remove(nome);
        Console.WriteLine($"Produto {nome} removido");
    } else {
        Console.WriteLine("Produto não encontrado no estoque.");
    }
    Console.ReadKey();
    TelaInicial();
}

void TelaInicial(){
    Console.Clear();
    Console.WriteLine("Opções: ");
    Console.WriteLine("1 - Adicionar produto");
    Console.WriteLine("2 - Atualizar produto");
    Console.WriteLine("3 - Remover produto");
    Console.WriteLine("4 - Mostrar estoque");

    int opcao = int.Parse(Console.ReadLine()!);

    if (opcao == 1){ 
        Console.Write("Nome: ");
        string nome = Console.ReadLine()!;
        Console.Write("Quantidade: ");
        int quantidade = int.Parse(Console.ReadLine()!);
        AddProduto(nome, quantidade); 
    } 

    else if (opcao == 2) {
        Console.Write("Nome: ");
        string nome = Console.ReadLine()!;
        Console.Write("Quantidade: ");
        int quantidade = int.Parse(Console.ReadLine()!);
        UpdateProduto(nome, quantidade); 
    }

    else if (opcao == 3)
    {
        Console.Write("Nome: ");
        string nome = Console.ReadLine()!;
        RemoveProduto(nome);
    }

    else if (opcao == 4)
    {
        MostrarEstoque();
    }

    else if (opcao == 5)
    {
        Console.WriteLine("Encerrando...");
    }
}
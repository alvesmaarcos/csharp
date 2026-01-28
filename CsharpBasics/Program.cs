// 1. Criar uma variável chamada notaMedia e atribua um valor inteiro a ela. Caso seu valor seja maior ou igual a 5, escreva na tela "Nota suficiente para aprovação".
void CalcularMedia()
{
    int notaMedia;
    Console.Write("Insira a média: "); 
    notaMedia = int.Parse(Console.ReadLine()!);

    if (notaMedia >= 7)
    {
        Console.WriteLine("Nota suficiente para aprovação");
    }
    else
    {
        Console.WriteLine("Nota insuficiente. Reprovado");
    }

}


// 2. Criar uma lista de linguagens de programação, com as linguagens C#, Java e JavaScript.
void ListarLips()
{
    string[] lips = new string[] {"C#", "C", "Python", "JavaScript", "Go", "Java"};
    foreach (var lip in lips)
    {
        Console.WriteLine(lip);
    }

    // 3. Exibir o valor "C#" no console, utilizando a lista criada no exercício anterior.
    // 4. Criar um programa que, dado a entrada de dados de um número n inteiro, a partir do teclado, exibir a n-ésima posição de uma lista.

    int selecionado = int.Parse(Console.ReadLine()!);
    Console.WriteLine(lips[selecionado]);
}


void ExibirOpcoes()
{
    Console.WriteLine("Olá! O que deseja fazer?");
    Console.WriteLine("1. Calcular Aprovação");
    Console.WriteLine("2. Listar e selecionar LIPs em uma lista");
    Console.WriteLine("0. Sair");
    Console.Write("\nSelecione: ");
    int opcao = int.Parse(Console.ReadLine()!);
    switch (opcao)
    {
        case 1: CalcularMedia(); break;
        case 2: ListarLips(); break;
        case 0: Console.WriteLine("Saindo..."); break;
        default: Console.WriteLine("Inválido. Tente novamente"); break;
    }


}

ExibirOpcoes();
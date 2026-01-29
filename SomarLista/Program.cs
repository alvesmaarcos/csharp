void CalcularLista(){
    List<int> elementos = new List<int>{1, 22, 33, 55};
    
    int total = 0;
    foreach (int el in elementos)
    {
        total += el;
    }
    Console.WriteLine(total);
}

CalcularLista();
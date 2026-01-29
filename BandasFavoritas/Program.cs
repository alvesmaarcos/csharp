void MostrarBandasFavoritas(){
    List<string> bandas = new List<string> {"Coldplay", "ANAVITÓRIA", "The Neighborhood"};

    foreach (string banda in bandas)
    {
        Console.WriteLine(banda);
    }
}

MostrarBandasFavoritas();
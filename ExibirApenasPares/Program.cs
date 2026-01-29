void MostrarPares()
{
    List<int> listNum = new List<int>();
    Random rand = new Random();
    for (int i = 0; i < 10; i++)
    {
        listNum.Add(rand.Next(1, 101));
    }
    
    foreach(int num in listNum)
    {
        if(num % 2 == 0) Console.WriteLine(num);
    }

}

MostrarPares();
int[] ArrayGenerator()
{
    int[] Array = new int[8];
    for(int i = 0; i < 8; i++)
    {
        Array[i] = new Random().Next(1,1000);
    }
    return Array;
}

Console.WriteLine($"[{string.Join(",", ArrayGenerator())}]");
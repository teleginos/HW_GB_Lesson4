double NewPow(int a, int b)
{
    return Math.Pow(a, b);
}

string CheckingTheInput(string number, string degree)
{
    if(int.TryParse(number, out var newNumber) && int.TryParse(degree, out var newDegree))
    {
        double result = NewPow(newNumber, newDegree);
        return $"Результат возведения числа {number} в степень {degree} = {result}";
    }

    else
    {
        return "Введены не коректные данные";
    }
}

Console.WriteLine("Для остановки программы введите 0");

while(true)
{
    
    Console.Write("Введите первое число: ");
    string num1 = Console.ReadLine();
    if(num1 == "0") break;
    Console.Write("Введите второе число: ");
    string num2 = Console.ReadLine();
    Console.WriteLine($"{CheckingTheInput(num1, num2)}\n");
    
}
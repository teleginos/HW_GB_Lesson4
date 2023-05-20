int SumNumber(int number)
{

    int sum = 0;
    while(number != 0)
    {
        sum += number % 10;
        number /= 10;
    }
    return sum;
}


string CheckingTheInput(string num)
{
    if(int.TryParse(num, out var newNum))
    {
        int result = SumNumber(Convert.ToInt32(newNum));
        return $"Суммы цифр числа {newNum} = {result}";
    }

    else
    {
        return "Введены не коректные данные";
    }
}

Console.Write("Введите число: ");
Console.WriteLine(CheckingTheInput(Console.ReadLine()));
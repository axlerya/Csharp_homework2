void NumberWeekDay(int numberDay)
{
    if (numberDay == 6 | numberDay == 7) Console.WriteLine("да");
    else Console.WriteLine("нет");
}

Console.WriteLine("Введите число - день недели");
int numberInput = Convert.ToInt32(Console.ReadLine());

if (numberInput > 8) Console.WriteLine("Введите день недили правильно");
else NumberWeekDay(numberInput);
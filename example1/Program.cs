void Number(int number)
{   
    double positionTwo = 0;
    if (number/100 > 0) 
    {
        positionTwo = number / 10 % 10;
        Console.WriteLine($"Вторая чифра числа = {positionTwo}");
    }

    else
    {
        Console.WriteLine($"Введите трех значное число");
    }
}

﻿Console.WriteLine("Введите первое число");
int number = Convert.ToInt32(Console.ReadLine());
Number(number);
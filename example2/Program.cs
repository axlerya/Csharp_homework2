int[] GetIntArray(int num)
{
    List<int> listOfInts = new List<int>();
    while(num > 0)
    {
        listOfInts.Add(num % 10);
        num = num / 10;
    }
    listOfInts.Reverse();
    int[] arrayNumbers = listOfInts.ToArray();
    return arrayNumbers;
}


Console.WriteLine("Введите число");
int numberInput = Convert.ToInt32(Console.ReadLine());
int[] arrayNumbers = GetIntArray(numberInput);

if (numberInput%100 > 0)
{
    Console.WriteLine($"Третья цифра числа = {arrayNumbers[2]}");
}

else 
{
    Console.WriteLine("Третьей цифры нет");
}

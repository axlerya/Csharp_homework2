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
if (numberInput/100 < 1)
{
    Console.WriteLine("Третьей цифры числа нет");
}
else
{
    int[] arrayNumbers = GetIntArray(numberInput);
    Console.WriteLine($"Третья цифра числа = {arrayNumbers[2]}");
}
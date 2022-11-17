Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int ToThird(int num)
{
    while (num > 1000)
    {
        num = num / 10;
    }
    return num % 10;
}
if (number < 0) number = -number;
if (number > 99)
{
    int result = ToThird(number);
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("третьей цифры нет");
}
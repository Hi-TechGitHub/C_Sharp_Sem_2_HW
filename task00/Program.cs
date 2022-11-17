Console.WriteLine("Пожалуйста напишите число в диапозоне --> 100 до 999 ");
int enter = Convert.ToInt32(Console.ReadLine());

int task(int num1)
{
    int first = num1 / 10;
    int second = first % 10;
    return second;
}
int result = task(enter);
Console.WriteLine(result);
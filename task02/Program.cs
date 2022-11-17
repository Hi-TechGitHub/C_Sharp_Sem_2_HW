Console.WriteLine("напишите число от 1 до 7 ");
int number = Convert.ToInt32(Console.ReadLine());
int Week (int num) {
    int day = 0;
    if (num == 1) day = 1;
    if (num == 2) day = 2;
    if (num == 3) day = 3;
    if (num == 4) day = 4;
    if (num == 5) day = 5;
    if (num == 6) day = 6;
    if (num == 7) day = 7;
    return day;
}
int result = Week(number);
if (result == 1) Console.WriteLine("Нет");
if (result == 2) Console.WriteLine("Нет");
if (result == 3) Console.WriteLine("Нет");
if (result == 4) Console.WriteLine("Нет");
if (result == 5) Console.WriteLine("Нет");
if (result == 6) Console.WriteLine("Да");
if (result == 7) Console.WriteLine("Да");



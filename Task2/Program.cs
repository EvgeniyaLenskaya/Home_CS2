Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int result = number / 100 % 10;
if (number < 100)
{
    Console.WriteLine("Третьей цифры нет.");
}
else
{
    if (number >= 10000 && number < 100000)
    {
        Console.WriteLine ($"{number} -> {result}");
    }
    else
    {
        Console.WriteLine ("Вы ввели НЕ пятизначное число.");
    }
}        

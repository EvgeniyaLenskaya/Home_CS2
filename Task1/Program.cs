Console.Write("Введите трёхзначное число: ");
int value = Convert.ToInt32(Console.ReadLine());
int result = value / 10 % 10;

Console.WriteLine ($"{value} -> {result}");

Console.Write ("Введите день недели: ");
int day = Convert.ToInt32(Console.ReadLine ());

if (day >= 1 && day < 6)
{
    Console.WriteLine ("Идём на работу(");
}
else
{
    if (day >=6 && day < 8)
    {
        Console.WriteLine ("Ура! Выходной!");
    }
    else
    {
        Console.WriteLine ("Это не день недели.");
    }
}
// Дано число обозначающее день недели. Выяснить является номер дня недели выходным

bool WeekendOrNot(int day_number)
{
    if (day_number == 6 || day_number == 7)
    {
        return true;
    }
    else
    {
        return false;
    }
}

Console.Write("Enter any day of the week number (1 -7): ");
int week_day_number = int.Parse(Console.ReadLine());

if (week_day_number >= 1 && week_day_number <= 7)
{
    if (WeekendOrNot(week_day_number))
    {
        Console.Write("A day with a number " + week_day_number + " is a weekend.");
    }
    else
    {
        Console.Write("A day with a number " + week_day_number + " is not a weekend.");
    }
}
else
{
    Console.Write("There is no a day of the week with the number " + week_day_number);
}

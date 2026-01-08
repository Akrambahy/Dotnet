DateOnly date=DateOnly.Parse(Console.ReadLine());

Console.WriteLine($"Name of Day : {date.DayOfWeek}");
Console.WriteLine("{0:dddd} Of Month {0:MMMM} Year {0:yyyy}",date);


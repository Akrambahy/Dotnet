/*DateOnly date=DateOnly.Parse(Console.ReadLine());

Console.WriteLine($"Name of Day : {date.DayOfWeek}");
Console.WriteLine("{0:dddd} Of Month {0:MMMM} Year {0:yyyy}",date);
*/
int num = int.Parse(Console.ReadLine());
for (int i = 1; i <= num; i++)
{
for (int k = i; k <=num-1; k++)
    {
        Console.Write(" ");  
    }
        for (int j = 1; j <= i*2-1; j++)
    {
        Console.Write($"*");  // Print MultiTable for 1 to 10
    }
    Console.WriteLine();
}


for (int i = num; i >= 1; i--)
{
for (int k = num-1 ; k >=i; k--)
    {
        Console.Write(" ");  
    }
        for (int j = i*2-1; j >=1; j--)
    {
        Console.Write($"*");  
    }
    Console.WriteLine();
}
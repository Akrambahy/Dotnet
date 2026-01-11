/*DateOnly date = DateOnly.Parse(Console.ReadLine());

Console.WriteLine($"Name of Day : {date.DayOfWeek}");
Console.WriteLine("{0:dddd} Of Month {0:MMMM} Year {0:yyyy}", date);
*/
int num = int.Parse(Console.ReadLine());

// Print Pyramid
for (int i = 1; i <= num; i++)
{
    for (int k = i; k <= num - 1; k++)
    {
        Console.Write(" ");
    }
    for (int j = 1; j <= i * 2 - 1; j++)
    {
        Console.Write($"*");  // Print MultiTable for 1 to 10
    }
    Console.WriteLine();
}

// Print Interval Pyramid
for (int i = num; i >= 1; i--)
{
    for (int k = num - 1; k >= i; k--)
    {
        Console.Write(" ");
    }
    for (int j = i * 2 - 1; j >= 1; j--)
    {
        Console.Write($"*");
    }
    Console.WriteLine();
}

// Get and Print maximum number of array 

int[] array = new int[5] { 1, 2, 3, 6, 9 };

int maxNumber = array[0];

foreach (var number in array)
{
    if (number > maxNumber) maxNumber = number;
}
Console.WriteLine($"Maximum Value : {maxNumber}");
// Get and Print minimum number of array 


int minNumber = array[0];

foreach (var number in array)
{
    if (number < minNumber) minNumber = number;
}
Console.WriteLine($"Minimum Value : {minNumber}");
// Bubble Sort
int swap = 0;

for (int i = 0; i < array.Length - 1; i++)
{
    for (int k = 0; k < array.Length - 1; k++)
    {
        if (array[k] > array[k + 1])
        {
            swap = array[k + 1];
            array[k + 1] = array[k];
            array[k] = swap;
        }

    }


}
// with built in function Array.Sort(arrayName)
Array.Sort(array);
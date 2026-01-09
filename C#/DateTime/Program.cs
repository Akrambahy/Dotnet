DateTime MyDate = DateTime.Now; // Global Time 
DateTime Date = new DateTime(11, 11, 2006);// Specific  Time 

Console.WriteLine("Date : {0}", MyDate);

string formattedDate = string.Format("Date : {0:yyyy MMMM dddd} , Time {0:hhhh mmmm sss tt} ", MyDate); // y-> year M->Month d->day , h->hour m->minute  s->secund tt -> am or pm 
Console.WriteLine(formattedDate);


Console.WriteLine(Date.Year); // Print Year Of Date
Console.WriteLine(Date.Month);// Print Month Of Date
Console.WriteLine(Date.Day); // Print Day of Date
Console.WriteLine(Date.DayOfWeek); // Print the name of day in this week
Console.WriteLine(Date.DayOfYear); // print the number of day in year


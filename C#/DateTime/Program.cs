DateTime MyDate=DateTime.Now;

Console.WriteLine("Date : {0}",MyDate);

string formattedDate=string.Format("Date : {0:yyyy MMMM dddd} , Time {0:hhhh mmmm sss} ", MyDate);

Console.WriteLine(formattedDate);

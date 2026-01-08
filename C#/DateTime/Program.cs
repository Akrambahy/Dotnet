DateTime MyDate=DateTime.Now; // Global date
DateTime Date= new DateTime(2022,02,2); //Specific Date  

Console.WriteLine("Date : {0}",MyDate);

string formattedDate=string.Format("Date : {0:yyyy MMMM dddd} , Time {0:hhhh mmmm sss} ", MyDate); 

Console.WriteLine(formattedDate);

//DateOnly

DateOnly newDate= new DateOnly(2024,05,6);
Console.WriteLine(newDate.DayNumber); // Print Day Number in Year
Console.WriteLine(newDate.Month); // Print Month Of newDate
Console.WriteLine(newDate.Day); // Print Day Of newDate
Console.WriteLine(newDate.DayOfWeek);  // Print Name of day in week

var currentDate=DateOnly.FromDateTime(DateTime.Now);

//TimeOnly

TimeOnly eventIn=new TimeOnly(5,0);// with 24 h
TimeOnly eventOut=new TimeOnly(13,0); // with 24 h

var span = eventOut-eventIn; // var = span time type

Console.WriteLine($"Duration : {span.TotalHours}"); // Print total house of Work
//IF Statement
int x = 2, y = 7;

if (x > y) Console.WriteLine("X  Greater Than Y");
else if (x < y) Console.WriteLine("X  Less Than Y");
else Console.WriteLine("X  Equal  Y");

// Nested IF

if (x > y) Console.WriteLine("X  Greater Than Y");
else
{
  if (x < y) Console.WriteLine("X  Less Than Y");
  else Console.WriteLine("X  Equal  Y");
}



//Switch statement
// classic switch in c#
var temp=15.0;
switch (temp)
{
  case >=12:
  Console.WriteLine("Greater Than");
  break;
  case <71 :
  Console.WriteLine("Less Than\n");
   break;
    default :
 break;
   
}

var massage = x switch
{
 1=>"One",
 2=>"Two",
  8=>"eight",
  _=>"digit",
};

Console.WriteLine($"x is : {massage}");


//Output
Console.WriteLine("Hello, World!"); // We Use Console.WriteLine("Print Statement") to Print Statement With newLine
Console.Write("Hello, World!"); // We Use Console.Write("Print Statement") to Print Statement Without newLine
//Input
string name = Console.ReadLine(); // We Use Console.ReadLine() to Take input from User With newLine
string name2 ;
name2=Console.ReadLine(); // We Use Console.Read(variable) to Take input from User Without newLine
Console.WriteLine($"name : {name}");
Console.WriteLine($"name 2 : {name2}");


Console.WriteLine("Pleas Enter Your salary ");

decimal salary;
salary=decimal.Parse(Console.ReadLine()); // We use dataType.Parse(Console.ReadLine()) to convert type of input of ReadLine Becouse it Return string By Default

Console.WriteLine($"Salary : {salary}");


// TryParse

bool validInput=int.TryParse(Console.ReadLine(),out int x); // convert Console.ReadLine() from string to integer in store in x if valid input if else not invalid store 0 in x and return true if valid false if invalid 

if(validInput==false) Console.WriteLine("invalid Input");
else Console.WriteLine($"Valid Input : {x}");



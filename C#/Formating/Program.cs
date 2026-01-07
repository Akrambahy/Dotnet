using System.Text;


string name = "Akram";
var massage = string.Format("Hi, {0}", name);//string.Format("massage, {varNumber}",var);
Console.WriteLine($"Hi, I am {name}"); // this is a string interpolation
var strBuilder = new StringBuilder();
strBuilder.AppendFormat("Hi, My Name Is {0}", "Akram");
Console.WriteLine(strBuilder.Length); // Print Number of Character Of string
Console.WriteLine(strBuilder.Replace('a', 'A')); // Replace(oldChar,NewChar) to replace tow character in string 
Console.WriteLine("Hi, My Name Is {0}{1}", "Akram", "Bahy"); //string.Format("massage, {var1Number}{var2Number}",var1,var2);


Console.WriteLine("Number : {0:N}", 50);//Print as a floating Number
Console.WriteLine("Number : {0:D}", 50);//Print With Dolar sign
Console.WriteLine("Number : {0:P}", 50);//Print as a Percentage Number
Console.WriteLine("Number : {0:D7}", 50);//Print With Leading Zeros  7 her as a Number of Zeros
Console.WriteLine("Hex : {0:X}", 1358580);//Print as A Hex Decimal

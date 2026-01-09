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
// String manipulation
 string text ="  my name is akram ";

 // trim() to remove white spaces form right and left
Console.WriteLine($"Trim : {text.Trim()}");


 // ToUpper() to Convert all character to Capital letters
Console.WriteLine($"ToUpper : {text.ToUpper()}");

 // ToLower() to Convert all character to small letters
Console.WriteLine($"ToLower : {text.ToLower()}");


 // Length to get the size of string
Console.WriteLine($"Length : {text.Length}");


 // Replace(char oldChar,char newChar) to Replace char in string
Console.WriteLine($"Replace : {text.Replace('a','o')}");

// IndexOf(char char) to get index of character in string
Console.WriteLine($"IndexOf : {text.IndexOf('a')}");


// Last IndexOf(char char) to get Last index of character in string
Console.WriteLine($"LastIndexOf : {text.LastIndexOf('a')}");


// SubString(int stIndex) to get  Sub of string from string started in stIndex
Console.WriteLine($"Substring : {text.Substring(3)}");

// Remove(int stIndex) to get  Sub of string from string started in stIndex
Console.WriteLine($"Remove : {text.Remove(5)}");


// Insert(Pos) To add text to String started in Index
Console.WriteLine($"Insert : {text.Trim().Insert(0,"Hi, ")}");
// Contains (char char) toCheck char Be in string or not and return true or false
Console.WriteLine($"Contains : {text.Contains('a')}");



 
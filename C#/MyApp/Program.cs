//Data Types In C#
 //Integers
   int Number=5;
    Console.WriteLine("Number : "+ Number);

 //Strings 
  string firstName="Akram";
  Console.WriteLine("Hello, "+ firstName);
 //Numeric 
   float fNumber=2.2F; // We must put type after Number
   decimal deNumber=86.2M;
   double duNumber=2.2D; // default is D as a Double
  
  Console.WriteLine("Float Number : "+fNumber);
  Console.WriteLine("Decimal Number : "+deNumber);
  Console.WriteLine("Double Number : "+duNumber);
 //boolean  
  bool IsWork=false;
  Console.WriteLine(IsWork);
 // Type Conversion
    int intVar=5;
    double doubleVar=13.6;
     Console.WriteLine("Integer Number : "+intVar);
     Console.WriteLine("Double Number : "+doubleVar);
   //Implicit Conversion
     Console.WriteLine("After Conversion");
  //   doubleVar=intVar;
     Console.WriteLine("Integer Number : "+intVar);
     Console.WriteLine("Double Number : "+doubleVar);

   //Explicit Conversion  

  Console.WriteLine("After Conversion");
     intVar=(int)doubleVar;
     Console.WriteLine("Integer Number : "+intVar);
     Console.WriteLine("Double Number : "+doubleVar);






 